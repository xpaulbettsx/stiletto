﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Abra.Compiler.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Abra.Compiler;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class RuntimeModule : RuntimeModuleBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nnamespace ");
            
            #line 11 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using Binding = global::Abra.Internal.Binding;\r\n    using Resolver = glo" +
                    "bal::Abra.Internal.Resolver;\r\n    using RuntimeModule = global::Abra.Internal.Ru" +
                    "ntimeModule;\r\n\r\n    public class ");
            
            #line 17 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BindingName(mod.LiteralName)));
            
            #line default
            #line hidden
            this.Write("_CompiledModule : RuntimeModule\r\n    {\r\n        public ");
            
            #line 19 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BindingName(mod.LiteralName)));
            
            #line default
            #line hidden
            this.Write("_CompiledModule()\r\n            : base(typeof(");
            
            #line 20 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.FullName));
            
            #line default
            #line hidden
            this.Write("),\r\n                   new string[] { ");
            
            #line 21 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", Quote(mod.EntryPointKeys))));
            
            #line default
            #line hidden
            this.Write(" },\r\n                   new Type[] { ");
            
            #line 22 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", mod.IncludedTypeofs)));
            
            #line default
            #line hidden
            this.Write(" },\r\n                   ");
            
            #line 23 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.IsComplete ? "true" : "false"));
            
            #line default
            #line hidden
            this.Write(")\r\n        {}\r\n\r\n        public override object CreateModule()\r\n        {\r\n      " +
                    "      return new ");
            
            #line 28 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.LiteralName));
            
            #line default
            #line hidden
            this.Write("();\r\n        }\r\n\r\n        public override void GetBindings(IDictionary<string, Bi" +
                    "nding> bindings)\r\n        {\r\n");
            
            #line 33 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 foreach (var prov in mod.ProviderMethods) { 
            
            #line default
            #line hidden
            this.Write("            bindings[\"");
            
            #line 34 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.Key));
            
            #line default
            #line hidden
            this.Write("\"] = new ");
            
            #line 34 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.BindingName));
            
            #line default
            #line hidden
            this.Write("((");
            
            #line 34 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.LiteralName));
            
            #line default
            #line hidden
            this.Write(") Module);\r\n");
            
            #line 35 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 38 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 foreach (var prov in mod.ProviderMethods) { 
            
            #line default
            #line hidden
            this.Write("\r\n        private class ");
            
            #line 40 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.BindingName));
            
            #line default
            #line hidden
            this.Write(" : Binding\r\n        {\r\n            private readonly ");
            
            #line 42 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.LiteralName));
            
            #line default
            #line hidden
            this.Write(" module;\r\n");
            
            #line 43 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 foreach (var param in prov.Params) { 
            
            #line default
            #line hidden
            this.Write("            private Binding ");
            
            #line 44 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(param.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 45 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n            public ");
            
            #line 47 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.BindingName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 47 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.LiteralName));
            
            #line default
            #line hidden
            this.Write(" module)\r\n                : base(\"");
            
            #line 48 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.Key));
            
            #line default
            #line hidden
            this.Write("\", null, ");
            
            #line 48 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.IsSingleton ? "true" : "false"));
            
            #line default
            #line hidden
            this.Write(", typeof(");
            
            #line 48 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.FullName));
            
            #line default
            #line hidden
            this.Write("))\r\n            {\r\n                this.module = module;\r\n            }\r\n");
            
            #line 52 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 if (prov.HasParams) { 
            
            #line default
            #line hidden
            this.Write("\r\n            public override void Resolve(Resolver resolver)\r\n            {\r\n");
            
            #line 56 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 foreach (var param in prov.Params) { 
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 57 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(param.Name));
            
            #line default
            #line hidden
            this.Write(" = resolver.RequestBinding(\"");
            
            #line 57 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(param.Key));
            
            #line default
            #line hidden
            this.Write("\", typeof(");
            
            #line 57 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mod.LiteralName));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 58 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            }\r\n\r\n            public override void GetDependencies(ISet<Binding> i" +
                    "njectDependencies, ISet<Binding> propertyDependencies)\r\n            {\r\n");
            
            #line 63 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 foreach (var param in prov.Params) { 
            
            #line default
            #line hidden
            this.Write("                injectDependencies.Add(");
            
            #line 64 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(param.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 65 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            }\r\n");
            
            #line 67 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n            public override object Get()\r\n            {\r\n");
            
            #line 71 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 if (prov.HasParams) { 
            
            #line default
            #line hidden
            this.Write("                return module.");
            
            #line 72 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.Name));
            
            #line default
            #line hidden
            this.Write("(\r\n");
            
            #line 73 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 for (var i = 0; i < prov.Params.Count; ++i) { 
            
            #line default
            #line hidden
            this.Write("                    (");
            
            #line 74 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.Params[i].TypeName));
            
            #line default
            #line hidden
            this.Write(") ");
            
            #line 74 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.Params[i].Name));
            
            #line default
            #line hidden
            this.Write(".Get()");
            
            #line 74 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i < prov.Params.Count - 1 ? "," : ");"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 75 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } 
            
            #line default
            #line hidden
            
            #line 76 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("                return module.");
            
            #line 77 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prov.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 78 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            }\r\n        }\r\n");
            
            #line 81 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"
 } // end of provider-binding classes 
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 83 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"

private IEnumerable<string> Quote(IEnumerable<string> strs)
{
    foreach (var str in strs) {
        yield return "\"" + str + "\"";
    }
}

private string BindingName(string name)
{
    return name.Replace(".", "_");
}

        
        #line default
        #line hidden
        
        #line 1 "C:\Users\ben\Development\abra-ioc\Abra.Compiler\Templates\RuntimeModule.tt"

private global::Abra.Compiler.Generators.ModuleGenerator _modField;

/// <summary>
/// Access the mod parameter of the template.
/// </summary>
private global::Abra.Compiler.Generators.ModuleGenerator mod
{
    get
    {
        return this._modField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool modValueAcquired = false;
if (this.Session.ContainsKey("mod"))
{
    if ((typeof(global::Abra.Compiler.Generators.ModuleGenerator).IsAssignableFrom(this.Session["mod"].GetType()) == false))
    {
        this.Error("The type \'Abra.Compiler.Generators.ModuleGenerator\' of the parameter \'mod\' did no" +
                "t match the type of the data passed to the template.");
    }
    else
    {
        this._modField = ((global::Abra.Compiler.Generators.ModuleGenerator)(this.Session["mod"]));
        modValueAcquired = true;
    }
}
if ((modValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("mod");
    if ((data != null))
    {
        if ((typeof(global::Abra.Compiler.Generators.ModuleGenerator).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'Abra.Compiler.Generators.ModuleGenerator\' of the parameter \'mod\' did no" +
                    "t match the type of the data passed to the template.");
        }
        else
        {
            this._modField = ((global::Abra.Compiler.Generators.ModuleGenerator)(data));
        }
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class RuntimeModuleBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
