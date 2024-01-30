using NecnatAbp.Br.GePessoaFisica.MongoDB;
using NecnatAbp.Br.GePessoaFisica.Samples;
using Xunit;

namespace NecnatAbp.Br.GePessoaFisica.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<GePessoaFisicaMongoDbTestModule>
{

}
