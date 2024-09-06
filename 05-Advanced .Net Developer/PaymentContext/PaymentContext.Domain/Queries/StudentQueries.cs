using System.Linq.Expressions;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Queries;

public static class StudentQueries
{
    public static Expression<Func<Student, bool>> GetStudentInfo(string document)
    {
        return x => x.Document.Number.Equals(document);
    }
}