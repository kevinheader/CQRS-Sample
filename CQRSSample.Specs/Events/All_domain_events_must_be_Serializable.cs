//using System;
//using System.Linq;
//using CQRSSample.Domain.Events;
//using NUnit.Framework;

//namespace CQRSSample.Specs.Events
//{
//    [TestFixture]
//    public class All_domain_events_must_be_Serializable
//    {
//        [Test]
//        public void All_domain_events_will_have_the_Serializable_attribute_assigned()
//        {
//            var domainEventTypes = typeof(CustomerCreatedEvent).Assembly.GetExportedTypes().Where(x => x.BaseType == typeof(DomainEvent)).ToList();
//            foreach (var domainEventType in domainEventTypes)
//            {
//                if (domainEventType.IsSerializable)
//                    continue;

//                throw new Exception(string.Format("Domain event '{0}' is not Serializable", domainEventType.FullName));
//            }
//        }
//    }
//}


using Machine.Specifications;

namespace CQRSSample.Specs.Events
{
    [Subject("lkj")]
    public class MyTestFixture
    {
        Establish context = () => { };

        It should_be_true = () => 1.ShouldEqual(1);
    }

}