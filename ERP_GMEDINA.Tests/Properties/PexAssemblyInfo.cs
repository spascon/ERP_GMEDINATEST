using System.Web;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using ERP_GMEDINA.Controllers;
using Inspinia_MVC5_SeedProject.Controllers;
using System.Data.Entity;
using System;
using System.Web.Mvc.Async;
using System.Web.Mvc;
using Microsoft.Pex.Framework.Using;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Suppression;
using System.Runtime.ExceptionServices;
// <copyright file="PexAssemblyInfo.cs">Copyright ©  2014</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;
using System.Collections.Generic;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("ERP_GMEDINA")]
[assembly: PexInstrumentAssembly("Microsoft.AspNet.Identity.Core")]
[assembly: PexInstrumentAssembly("Microsoft.AspNet.Identity.Owin")]
[assembly: PexInstrumentAssembly("System.Web")]
[assembly: PexInstrumentAssembly("Owin")]
[assembly: PexInstrumentAssembly("System.Configuration")]
[assembly: PexInstrumentAssembly("Microsoft.Owin.Security")]
[assembly: PexInstrumentAssembly("Microsoft.Owin.Host.SystemWeb")]
[assembly: PexInstrumentAssembly("Microsoft.CSharp")]
[assembly: PexInstrumentAssembly("Microsoft.Owin.Security.Cookies")]
[assembly: PexInstrumentAssembly("System.Web.Optimization")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("Microsoft.AspNet.Identity.EntityFramework")]
[assembly: PexInstrumentAssembly("Microsoft.Owin")]
[assembly: PexInstrumentAssembly("System.ComponentModel.DataAnnotations")]
[assembly: PexInstrumentAssembly("EntityFramework")]
[assembly: PexInstrumentAssembly("System.Web.Mvc")]
[assembly: PexInstrumentAssembly("System.Transactions")]
[assembly: PexInstrumentAssembly("System.Data")]
[assembly: PexInstrumentAssembly("System.Data.DataSetExtensions")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.AspNet.Identity.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.AspNet.Identity.Owin")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Owin")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Configuration")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Owin.Security")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Owin.Host.SystemWeb")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.CSharp")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Owin.Security.Cookies")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web.Optimization")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.AspNet.Identity.EntityFramework")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Owin")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.ComponentModel.DataAnnotations")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "EntityFramework")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web.Mvc")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Transactions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Data")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Data.DataSetExtensions")]
[assembly: PexInstrumentType(typeof(ExceptionDispatchInfo))]
[assembly: PexSuppressExplorableEvent(typeof(BancoController))]
[assembly: PexSuppressExplorableEvent(typeof(CuentaBancoController))]
[assembly: PexUseType(typeof(IView), "System.Web.Mvc.DependencyResolver+CacheDependencyResolver")]
[assembly: PexUseType(typeof(IView), "System.Web.Mvc.DependencyResolver+DefaultDependencyResolver")]
[assembly: PexUseType(typeof(IView), "System.Web.Mvc.DependencyResolver+DelegateBasedDependencyResolver")]
[assembly: PexUseType(typeof(ControllerActionInvoker))]
[assembly: PexUseType(typeof(AsyncControllerActionInvoker))]
[assembly: PexUseType(typeof(SessionStateTempDataProvider))]
[assembly: PexUseType(typeof(JQueryFormValueProvider))]
[assembly: PexUseType(typeof(ChildActionValueProvider))]
[assembly: PexUseType(typeof(FormValueProvider))]
[assembly: PexUseType(typeof(HttpFileCollectionValueProvider))]
[assembly: PexUseType(typeof(QueryStringValueProvider))]
[assembly: PexUseType(typeof(RouteDataValueProvider))]
[assembly: PexUseType(typeof(ValueProviderCollection))]
[assembly: PexUseType(typeof(NameValueCollectionValueProvider))]
[assembly: PexUseType(typeof(ValueProviderDictionary))]
[assembly: PexUseType(typeof(FormCollection))]
[assembly: PexUseType(typeof(IView), "System.Web.Mvc.ModelBindingContext+UnvalidatedValueProviderWrapper")]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(Environment))]
[assembly: PexSuppressExplorableEvent(typeof(ISet<>))]
[assembly: PexSuppressExplorableEvent("System.Web.Mvc.ModelBindingContext+UnvalidatedValueProviderWrapper")]
[assembly: PexSuppressExplorableEvent("System.Web.Mvc.DependencyResolver+CacheDependencyResolver")]
[assembly: PexSuppressExplorableEvent(typeof(EstadoFacturaController))]
[assembly: PexSuppressExplorableEvent(typeof(MovimientoCajaController))]
[assembly: PexSuppressExplorableEvent("System.Web.Mvc.ControllerContext+EmptyHttpContext")]
[assembly: PexSuppressExplorableEvent(typeof(PuntoEmisionController))]
[assembly: PexSuppressStaticFieldStore("System.Web.Mvc.ModelStateDictionary+<>c", "<>9__8_0")]
[assembly: PexSuppressExplorableEvent(typeof(ClienteController))]
[assembly: PexInstrumentType(typeof(CallContext))]
[assembly: PexInstrumentType(typeof(TextInfo))]
[assembly: PexInstrumentType("mscorlib", "System.Runtime.Remoting.Messaging.IllogicalCallContext+Reader")]
[assembly: PexInstrumentType("mscorlib", "System.Runtime.Remoting.Messaging.LogicalCallContext+Reader")]
[assembly: PexInstrumentType(typeof(TextInfo))]
[assembly: PexSuppressExplorableEvent("System.Data.Entity.Internal.LazyInternalContext")]
[assembly: PexSuppressExplorableEvent("System.Data.Entity.Internal.EagerInternalContext")]
[assembly: PexSuppressExplorableEvent(typeof(PedidoController))]
[assembly: PexUseType(typeof(IView), "System.Web.Mvc.ControllerContext+EmptyHttpContext")]
[assembly: PexUseType(typeof(HttpContextWrapper))]

