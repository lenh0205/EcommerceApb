using TeduEcommerce.Admin;
using Volo.Abp.Modularity;

namespace TeduEcommerce;

[DependsOn(
    typeof(TeduEcommerceAdminApplicationModule),
    typeof(TeduEcommerceDomainTestModule)
    )]
public class TeduEcommerceApplicationTestModule : AbpModule
{

}
