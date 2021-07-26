using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Esercizio_Convertitore
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface ConvertiMisure
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        double KilometriMiglia(double value);

        [OperationContract]
        double MigliaKilometri(double value);

        // TODO: aggiungere qui le operazioni del servizio
    }

    // Per aggiungere tipi compositi alle operazioni del servizio utilizzare un contratto di dati come descritto nell'esempio seguente.
    // È possibile aggiungere file XSD nel progetto. Dopo la compilazione del progetto è possibile utilizzare direttamente i tipi di dati definiti qui con lo spazio dei nomi "Esercizio_Convertitore.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

        [DataMember]
        public double doubleValueKmMiglia
        {
            get
            {
                return doubleValueKmMiglia;
            }
            set
            {
                doubleValueKmMiglia = value;
            }
        }

        [DataMember]
        public double doubleValueMigliaKm
        {
            get
            {
                return doubleValueMigliaKm;
            }
            set
            {
                doubleValueMigliaKm = value;
            }
        }
    }
}
