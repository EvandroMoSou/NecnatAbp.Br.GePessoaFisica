using NecnatAbp.Br.GePessoaFisica.Samples;
using Xunit;

namespace NecnatAbp.Br.GePessoaFisica.MongoDB.Samples;

[Collection(MongoTestCollection.Name)]
public class SampleRepository_Tests : SampleRepository_Tests<GePessoaFisicaMongoDbTestModule>
{
    /* Don't write custom repository tests here, instead write to
     * the base class.
     * One exception can be some specific tests related to MongoDB.
     */
}
