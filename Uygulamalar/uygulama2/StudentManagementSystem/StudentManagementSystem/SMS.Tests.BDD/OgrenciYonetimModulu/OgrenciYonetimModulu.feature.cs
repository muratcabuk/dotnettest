// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SMS.Tests.BDD.OgrenciYonetimModulu
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class OgrenciYonetimModuluFeature : object, Xunit.IClassFixture<OgrenciYonetimModuluFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "OgrenciYonetimModulu.feature"
#line hidden
        
        public OgrenciYonetimModuluFeature(OgrenciYonetimModuluFeature.FixtureData fixtureData, SMS_Tests_BDD_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OgrenciYonetimModulu", "\tYazlımcı olarak\r\n\tÖğrenci Yönetim Sisteminde Öğrenci ile ilgili bölümleri yönete" +
                    "bilmek amacıyla \r\n\tekleme, silme, güncelleme ve listleme işlemlerini yapabilceği" +
                    "m bir modul istiyorum", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
 testRunner.Given("\"http://localhost:5000\" adresi açılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.Then("Açılan sayfanın anasayfa olduğu görülür", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Öğrenci Ekle")]
        [Xunit.TraitAttribute("FeatureTitle", "OgrenciYonetimModulu")]
        [Xunit.TraitAttribute("Description", "Öğrenci Ekle")]
        [Xunit.TraitAttribute("Category", "OgrenciEkleme")]
        [Xunit.InlineDataAttribute("Murat", "Cabuk", "10.10.1960", "45", "Male", "234567", new string[0])]
        [Xunit.InlineDataAttribute("Murat2", "Cabuk", "10.10.1960", "45", "Male", "234567", new string[0])]
        [Xunit.InlineDataAttribute("Murat3", "Cabuk", "10.10.1960", "45", "Male", "234567", new string[0])]
        public virtual void OğrenciEkle(string firstname, string lastname, string birthdate, string age, string gender, string studentId, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "OgrenciEkleme"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Öğrenci Ekle", null, @__tags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 12
 testRunner.Given("Menüden öğrenci ekle linkine tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
 testRunner.And(string.Format("Ekleme ekranında yer alan {0}, {1}, {2}, {3}, {4} ve {5} bilgileri girilir", firstname, lastname, birthdate, age, gender, studentId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.When("Kaydet butonuna tıklanılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("Öğrenci ekleme işleminin başarılı olduğu görülür", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Öğrenci Listele")]
        [Xunit.TraitAttribute("FeatureTitle", "OgrenciYonetimModulu")]
        [Xunit.TraitAttribute("Description", "Öğrenci Listele")]
        [Xunit.TraitAttribute("Category", "OgrenciListeleme")]
        [Xunit.InlineDataAttribute("Murat", "Cabuk", "10.10.1960", "45", "Male", new string[0])]
        public virtual void OğrenciListele(string firstname, string lastname, string birthdate, string age, string gender, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "OgrenciListeleme"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Öğrenci Listele", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 25
 testRunner.Given("Menüden öğreci listele linkine tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.And(string.Format("Listeleme ekranında yer alan {0}, {1}, {2}, {3} ve {4} bilgileri girilir", firstname, lastname, birthdate, age, gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.When("Ara butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.Then("Öğrenci listeleme işleminin başarılı olduğu görülür", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Öğrenci Sil")]
        [Xunit.TraitAttribute("FeatureTitle", "OgrenciYonetimModulu")]
        [Xunit.TraitAttribute("Description", "Öğrenci Sil")]
        [Xunit.TraitAttribute("Category", "OgrenciSilme")]
        public virtual void OğrenciSil()
        {
            string[] tagsOfScenario = new string[] {
                    "OgrenciSilme"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Öğrenci Sil", null, new string[] {
                        "OgrenciSilme"});
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 36
 testRunner.Given("Menüden öğreci listele linkine tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
 testRunner.And("Listeleme ekranında yer alan <Firstname>, <Lastname>, <Birthdate>, <Age> ve <Gend" +
                        "er> bilgileri girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.When("Ara butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.Then("Öğrenci listeleme işleminin başarılı olduğu görülür", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.When("Listede yer alan sil linklerinden birine tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Firstname",
                            "Lastname",
                            "Birthdate",
                            "Age",
                            "Gender"});
                table1.AddRow(new string[] {
                            "Murat",
                            "Cabuk",
                            "10.10.1960",
                            "45",
                            "Male"});
#line 41
 testRunner.Then("Öğrenci silme işleminin başarılı olduğu görülür", ((string)(null)), table1, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                OgrenciYonetimModuluFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                OgrenciYonetimModuluFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
