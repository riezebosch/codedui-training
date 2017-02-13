﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// AssertDemoActivationPage - Use 'AssertDemoActivationPageExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertDemoActivationPage()
        {
            #region Variable Declarations
            HtmlCustom uIItemCustom = this.UIHomePageASPNETMVCMusWindow.UIDemolinkdisplaypageNDocument.UIItemCustom;
            #endregion

            // Verify that the 'InnerText' property of custom control equals 'Demo link display page - Not for production use.'
            Assert.AreEqual(this.AssertDemoActivationPageExpectedValues.UIItemCustomInnerText, uIItemCustom.InnerText);
        }
        
        /// <summary>
        /// ClickRegister
        /// </summary>
        public void ClickRegister()
        {
            #region Variable Declarations
            HtmlInputButton uIRegisterButton = this.UIHomePageASPNETMVCMusWindow.UIRegisterASPNETMVCMusDocument.UIRegisterButton;
            #endregion

            // Click 'Register' button
            Mouse.Click(uIRegisterButton, new Point(25, 24));
        }
        
        /// <summary>
        /// EnterEmailAddress - Use 'EnterEmailAddressParams' to pass parameters into this method.
        /// </summary>
        public void EnterEmailAddress()
        {
            #region Variable Declarations
            HtmlEdit uIEmailEdit = this.UIHomePageASPNETMVCMusWindow.UIRegisterASPNETMVCMusDocument.UIEmailEdit;
            #endregion

            // Type 'demo@gmail.com' in 'Email' text box
            uIEmailEdit.Text = this.EnterEmailAddressParams.UIEmailEditText;
        }
        
        /// <summary>
        /// EnterPassword - Use 'EnterPasswordParams' to pass parameters into this method.
        /// </summary>
        public void EnterPassword()
        {
            #region Variable Declarations
            HtmlEdit uIPasswordEdit = this.UIHomePageASPNETMVCMusWindow.UIRegisterASPNETMVCMusDocument.UIPasswordEdit;
            #endregion

            // Type '********' in 'Password' text box
            uIPasswordEdit.Password = this.EnterPasswordParams.UIPasswordEditPassword;
        }
        
        /// <summary>
        /// EnterPasswordConfirmation - Use 'EnterPasswordConfirmationParams' to pass parameters into this method.
        /// </summary>
        public void EnterPasswordConfirmation()
        {
            #region Variable Declarations
            HtmlEdit uIConfirmpasswordEdit = this.UIHomePageASPNETMVCMusWindow.UIRegisterASPNETMVCMusDocument.UIConfirmpasswordEdit;
            #endregion

            // Type '********' in 'Confirm password' text box
            uIConfirmpasswordEdit.Password = this.EnterPasswordConfirmationParams.UIConfirmpasswordEditPassword;
        }
        
        /// <summary>
        /// NavigateRegisterPage
        /// </summary>
        public void NavigateRegisterPage()
        {
            #region Variable Declarations
            HtmlHyperlink uIRegisterHyperlink = this.UIHomePageASPNETMVCMusWindow.UIHomePageASPNETMVCMusDocument.UIRegisterHyperlink;
            #endregion

            // Click 'Register' link
            Mouse.Click(uIRegisterHyperlink, new Point(49, 25));
        }
        
        #region Properties
        public virtual AssertDemoActivationPageExpectedValues AssertDemoActivationPageExpectedValues
        {
            get
            {
                if ((this.mAssertDemoActivationPageExpectedValues == null))
                {
                    this.mAssertDemoActivationPageExpectedValues = new AssertDemoActivationPageExpectedValues();
                }
                return this.mAssertDemoActivationPageExpectedValues;
            }
        }
        
        public virtual EnterEmailAddressParams EnterEmailAddressParams
        {
            get
            {
                if ((this.mEnterEmailAddressParams == null))
                {
                    this.mEnterEmailAddressParams = new EnterEmailAddressParams();
                }
                return this.mEnterEmailAddressParams;
            }
        }
        
        public virtual EnterPasswordParams EnterPasswordParams
        {
            get
            {
                if ((this.mEnterPasswordParams == null))
                {
                    this.mEnterPasswordParams = new EnterPasswordParams();
                }
                return this.mEnterPasswordParams;
            }
        }
        
        public virtual EnterPasswordConfirmationParams EnterPasswordConfirmationParams
        {
            get
            {
                if ((this.mEnterPasswordConfirmationParams == null))
                {
                    this.mEnterPasswordConfirmationParams = new EnterPasswordConfirmationParams();
                }
                return this.mEnterPasswordConfirmationParams;
            }
        }
        
        public UIHomePageASPNETMVCMusWindow UIHomePageASPNETMVCMusWindow
        {
            get
            {
                if ((this.mUIHomePageASPNETMVCMusWindow == null))
                {
                    this.mUIHomePageASPNETMVCMusWindow = new UIHomePageASPNETMVCMusWindow();
                }
                return this.mUIHomePageASPNETMVCMusWindow;
            }
        }
        #endregion
        
        #region Fields
        private AssertDemoActivationPageExpectedValues mAssertDemoActivationPageExpectedValues;
        
        private EnterEmailAddressParams mEnterEmailAddressParams;
        
        private EnterPasswordParams mEnterPasswordParams;
        
        private EnterPasswordConfirmationParams mEnterPasswordConfirmationParams;
        
        private UIHomePageASPNETMVCMusWindow mUIHomePageASPNETMVCMusWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertDemoActivationPage'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AssertDemoActivationPageExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of custom control equals 'Demo link display page - Not for production use.'
        /// </summary>
        public string UIItemCustomInnerText = "Demo link display page - Not for production use.";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'EnterEmailAddress'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class EnterEmailAddressParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'demo@gmail.com' in 'Email' text box
        /// </summary>
        public string UIEmailEditText = "demo@gmail.com";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'EnterPassword'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class EnterPasswordParams
    {
        
        #region Fields
        /// <summary>
        /// Type '********' in 'Password' text box
        /// </summary>
        public string UIPasswordEditPassword = "K2gHpANDeOOtYhGGA0aZ04zjQIbIYSLh";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'EnterPasswordConfirmation'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class EnterPasswordConfirmationParams
    {
        
        #region Fields
        /// <summary>
        /// Type '********' in 'Confirm password' text box
        /// </summary>
        public string UIConfirmpasswordEditPassword = "K2gHpANDeOOtYhGGA0aZ04zjQIbIYSLh";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHomePageASPNETMVCMusWindow : BrowserWindow
    {
        
        public UIHomePageASPNETMVCMusWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Home Page – ASP.NET MVC Music Store";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Home Page – ASP.NET MVC Music Store");
            this.WindowTitles.Add("Register – ASP.NET MVC Music Store");
            this.WindowTitles.Add("Demo link display page - Not for production use – ASP.NET MVC Music Store");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHomePageASPNETMVCMusDocument UIHomePageASPNETMVCMusDocument
        {
            get
            {
                if ((this.mUIHomePageASPNETMVCMusDocument == null))
                {
                    this.mUIHomePageASPNETMVCMusDocument = new UIHomePageASPNETMVCMusDocument(this);
                }
                return this.mUIHomePageASPNETMVCMusDocument;
            }
        }
        
        public UIRegisterASPNETMVCMusDocument UIRegisterASPNETMVCMusDocument
        {
            get
            {
                if ((this.mUIRegisterASPNETMVCMusDocument == null))
                {
                    this.mUIRegisterASPNETMVCMusDocument = new UIRegisterASPNETMVCMusDocument(this);
                }
                return this.mUIRegisterASPNETMVCMusDocument;
            }
        }
        
        public UIDemolinkdisplaypageNDocument UIDemolinkdisplaypageNDocument
        {
            get
            {
                if ((this.mUIDemolinkdisplaypageNDocument == null))
                {
                    this.mUIDemolinkdisplaypageNDocument = new UIDemolinkdisplaypageNDocument(this);
                }
                return this.mUIDemolinkdisplaypageNDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHomePageASPNETMVCMusDocument mUIHomePageASPNETMVCMusDocument;
        
        private UIRegisterASPNETMVCMusDocument mUIRegisterASPNETMVCMusDocument;
        
        private UIDemolinkdisplaypageNDocument mUIDemolinkdisplaypageNDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHomePageASPNETMVCMusDocument : HtmlDocument
    {
        
        public UIHomePageASPNETMVCMusDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page – ASP.NET MVC Music Store";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:5000/";
            this.WindowTitles.Add("Home Page – ASP.NET MVC Music Store");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIRegisterHyperlink
        {
            get
            {
                if ((this.mUIRegisterHyperlink == null))
                {
                    this.mUIRegisterHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIRegisterHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "registerLink";
                    this.mUIRegisterHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIRegisterHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIRegisterHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Register";
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Account/Register";
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:5000/Account/Register";
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"registerLink\" href=\"/Account/Registe";
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "14";
                    this.mUIRegisterHyperlink.WindowTitles.Add("Home Page – ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIRegisterHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIRegisterHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRegisterASPNETMVCMusDocument : HtmlDocument
    {
        
        public UIRegisterASPNETMVCMusDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Register – ASP.NET MVC Music Store";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Account/Register";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:5000/Account/Register";
            this.WindowTitles.Add("Register – ASP.NET MVC Music Store");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIEmailEdit
        {
            get
            {
                if ((this.mUIEmailEdit == null))
                {
                    this.mUIEmailEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIEmailEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Email";
                    this.mUIEmailEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Email";
                    this.mUIEmailEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Email";
                    this.mUIEmailEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIEmailEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIEmailEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIEmailEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Email\" class=\"form-control\" id=\"Em";
                    this.mUIEmailEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    this.mUIEmailEdit.WindowTitles.Add("Register – ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIEmailEdit;
            }
        }
        
        public HtmlEdit UIPasswordEdit
        {
            get
            {
                if ((this.mUIPasswordEdit == null))
                {
                    this.mUIPasswordEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIPasswordEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Password";
                    this.mUIPasswordEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Password";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Password";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "PASSWORD";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"Password\" class=\"form-control\" id=";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    this.mUIPasswordEdit.WindowTitles.Add("Register – ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIPasswordEdit;
            }
        }
        
        public HtmlEdit UIConfirmpasswordEdit
        {
            get
            {
                if ((this.mUIConfirmpasswordEdit == null))
                {
                    this.mUIConfirmpasswordEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIConfirmpasswordEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "ConfirmPassword";
                    this.mUIConfirmpasswordEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "ConfirmPassword";
                    this.mUIConfirmpasswordEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Confirm password";
                    this.mUIConfirmpasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "PASSWORD";
                    this.mUIConfirmpasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIConfirmpasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIConfirmpasswordEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"ConfirmPassword\" class=\"form-contr";
                    this.mUIConfirmpasswordEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "3";
                    this.mUIConfirmpasswordEdit.WindowTitles.Add("Register – ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIConfirmpasswordEdit;
            }
        }
        
        public HtmlInputButton UIRegisterButton
        {
            get
            {
                if ((this.mUIRegisterButton == null))
                {
                    this.mUIRegisterButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIRegisterButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUIRegisterButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUIRegisterButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Register";
                    this.mUIRegisterButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIRegisterButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIRegisterButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUIRegisterButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"btn btn-default\" type=\"submit\" va";
                    this.mUIRegisterButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "4";
                    this.mUIRegisterButton.WindowTitles.Add("Register – ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIRegisterButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIEmailEdit;
        
        private HtmlEdit mUIPasswordEdit;
        
        private HtmlEdit mUIConfirmpasswordEdit;
        
        private HtmlInputButton mUIRegisterButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDemolinkdisplaypageNDocument : HtmlDocument
    {
        
        public UIDemolinkdisplaypageNDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Demo link display page - Not for production use – ASP.NET MVC Music Store";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Account/Register";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:5000/Account/Register";
            this.WindowTitles.Add("Demo link display page - Not for production use – ASP.NET MVC Music Store");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIItemCustom.SearchProperties["TagName"] = "HGROUP";
                    this.mUIItemCustom.SearchProperties["Id"] = null;
                    this.mUIItemCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIItemCustom.FilterProperties["Class"] = "title";
                    this.mUIItemCustom.FilterProperties["ControlDefinition"] = "class=\"title\"";
                    this.mUIItemCustom.FilterProperties["TagInstance"] = "1";
                    this.mUIItemCustom.WindowTitles.Add("Demo link display page - Not for production use – ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIItemCustom;
        #endregion
    }
}
