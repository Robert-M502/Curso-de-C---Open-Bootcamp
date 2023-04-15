using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion_de_dependencias
{
    public class LoggerOperation
    {
        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly ISingletonOperation _singletonOperation;

        // Constructor 
        public LoggerOperation(
            ITransientOperation transientOperation,
            IScopedOperation scopedOperation,
            ISingletonOperation singletonOperation) =>
            (_transientOperation, _scopedOperation, _singletonOperation) =
            (transientOperation, scopedOperation, singletonOperation);

        public void LogOperation(string scope) {
            LogOperation(_transientOperation, scope, "Desde TransientOperation");
            LogOperation(_scopedOperation, scope, "Desde ScopedOperation");
            LogOperation(_singletonOperation, scope, "Desde SingletonOperation");
        }

        private static void LogOperation<T>(T operation, string scope, string msg)
        where T : IOperation =>
            Console.WriteLine(
                $"{scope}: {typeof(T).Name} [ {operation.OperationId} - {msg}]"
                );
        
    }
}
