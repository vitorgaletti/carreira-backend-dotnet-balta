using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Services;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;

namespace PaymentContext.Domain.Handlers;

public class SubscriptionHandler(IStudentRepository studentRepository, IEmailService emailService)
    : Notifiable, IHandler<CreateBoletoSubscriptionCommand>
{
    public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
    {
        command.Validate();

        if (command.Invalid)
        {
            AddNotifications(command);
            return new CommandResult(false, "Não foi possível realizar seu cadastro");
        }
        
        if (studentRepository.DocumentExists(command.Document))
            AddNotification("Document", "Este CPF já está em uso");
        
        if (studentRepository.EmailExists(command.Email))
            AddNotification("Email", "Este E-mail já está em uso");
        
        var name = new Name(command.FirstName, command.LastName);
        var document = new Document(command.Document, EDocumentType.CPF);
        var email = new Email(command.Email);
        var address = new Address(command.Street, command.Number, command.Neighborhood, command.City, command.State, command.Country, command.ZipCode);

        var student = new Student(name, document, email);
        var subscription = new Subscription(DateTime.Now.AddMonths(1));
        var payment = new BoletoPayment(command.PaidDate, command.ExpireDate, command.Total,
                                        command.TotalPaid, command.Payer, new Document(command.PayerDocument, command.PayerDocumentType),
                                        address, email, command.BarCode, command.Number);
        
        
        subscription.AddPayment(payment);
        student.AddSubscription(subscription);
        
        AddNotifications(name, document, email, address, student, subscription, payment);

        if (Invalid)
            return new CommandResult(false, "Não foi possível realizar sua assinatura");
        
        studentRepository.CreateSubscription(student);
        
        emailService.Send(student.Name.ToString(), student.Email.Address, "Bem vindo ao balta.io", "Sua assinatura foi criada");
        
        return new CommandResult(true, "Assinatura realizada com sucesso");
    }
    
}