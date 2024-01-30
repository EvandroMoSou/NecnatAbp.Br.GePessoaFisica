using NecnatAbp.Br.GePessoaFisica.Samples;
using Xunit;

namespace NecnatAbp.Br.GePessoaFisica.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<GePessoaFisicaMongoDbTestModule>
{

}
