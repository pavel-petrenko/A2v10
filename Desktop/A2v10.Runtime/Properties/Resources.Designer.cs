﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A2v10.Runtime.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("A2v10.Runtime.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright © 2015-2018 Alex Kukhtin. All rights reserved.
        ///
        ////*
        ///global elements for context
        ///*/
        ///
        ///(function () {
        ///	// this = global context
        ///
        ///	let g = this;
        ///	const modules = {};
        ///
        ///	g.require = function (module) {
        ///		if (!(module in modules))
        ///			modules[module] = __require(module, g.__context._dir_);
        ///		return modules[module];
        ///	};
        ///
        ///	g.__context = {
        ///		_file_: null,
        ///		_dir_: null
        ///	};
        ///})();
        ///.
        /// </summary>
        internal static string App_context {
            get {
                return ResourceManager.GetString("App_context", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright © 2015-2018 Alex Kukhtin. All rights reserved.
        ///
        ///// global variables!
        ///
        ///var designer = (function () {
        ///
        ///	function createElement(name, ...args) {
        ///		if (name in this.elements) {
        ///			return new this.elements[name](...args);
        ///		}
        ///		console.log(`__createElement. Element &apos;${name}&apos; not found`);
        ///		return null;
        ///	}
        ///
        ///	function registerElement(ctor) {
        ///		var name = ctor.prototype.type;
        ///		//console.log(&apos;register: &apos; + name);
        ///		this.elements[name] = ctor;
        ///	}
        ///
        ///	let designer = {
        ///		form: {
        ///			ele [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Application {
            get {
                return ResourceManager.GetString("Application", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ;
        ///@About=Про систему
        ///@Confidentiality=Конфедіційність
        ///@Contacts=Конакти
        ///@Version=Версія
        ///@Debug=Відладка
        ///@Quit=Вихід
        ///@Tracing=Трасування
        ///@Settings=Налаштування
        ///@Feedback=Зворотній зв&apos;язок
        ///@DataModel=Модель даних
        ///@Profiling=Профілювання
        ///@Profile=Профіль
        ///@ChangePassword=Змінити пароль
        ///@SubstUser=Змінити користувача
        ///@AllUsers=Всі користувачі
        ///@AdminUsers=Адміністратори
        ///@User=Користувач
        ///@OldPassword=Старий пароль
        ///@NewPassword=Новий пароль
        ///@SetPassword=Встановити пароль
        ///@Error=Помилка
        ///@Warnin [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string default_uk {
            get {
                return ResourceManager.GetString("default_uk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright © 2015-2018 Alex Kukhtin. All rights reserved.
        ///
        ///(function () {
        ///
        ///	function Form() {
        ///		// form properties
        ///		this.Width = 150;
        ///		this.Height = 200;
        ///		this.Title = &quot;Form title from JS&quot;;
        ///	}
        ///
        ///	Form.prototype.type = &quot;Form&quot;;
        ///
        ///	Form.prototype._meta_ = {
        ///		Title: {
        ///			category: &quot;Appearance&quot;,
        ///			type: &quot;string&quot;,
        ///			description: &quot;Specifies the text that will be displayed in the form&apos;s title bar&quot;
        ///		},
        ///		Width: {
        ///			category: &quot;Layout&quot;,
        ///			type: &quot;number&quot;,
        ///			description: &quot;Specifies the wi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Form_form {
            get {
                return ResourceManager.GetString("Form_form", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] publicKeys {
            get {
                object obj = ResourceManager.GetObject("publicKeys", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright © 2015-2018 Alex Kukhtin. All rights reserved.
        ///
        ///(function () {
        ///
        ///	const cats = {
        ///		general: &quot;Общие&quot;
        ///	};
        ///
        ///	function createProp(mi, sprop) {
        ///		switch (mi.type) {
        ///			case &quot;string&quot;:
        ///				return sprop || &apos;&apos;;
        ///			case &quot;enum&quot;:
        ///				// TODO: check enum values
        ///				return sprop || &apos;&apos;;
        ///			case &quot;boolean&quot;:
        ///				return sprop || false;
        ///		}
        ///		return null;
        ///	}
        ///
        ///	function copyProps(trg, src) {
        ///		for (let p in trg._meta_) {
        ///			let sprop = src[p];
        ///			let mi = trg._meta_[p];
        ///			trg[p] = createPro [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Solution {
            get {
                return ResourceManager.GetString("Solution", resourceCulture);
            }
        }
    }
}
