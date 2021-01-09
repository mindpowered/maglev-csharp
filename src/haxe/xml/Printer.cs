// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.xml {
	public class Printer : global::haxe.lang.HxObject {
		
		public Printer(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Printer(bool pretty) {
			#line 44 "/opt/haxe/std/haxe/xml/Printer.hx"
			global::haxe.xml.Printer.__hx_ctor_haxe_xml_Printer(this, pretty);
		}
		#line default
		
		protected static void __hx_ctor_haxe_xml_Printer(global::haxe.xml.Printer __hx_this, bool pretty) {
			#line 45 "/opt/haxe/std/haxe/xml/Printer.hx"
			__hx_this.output = new global::StringBuf();
			__hx_this.pretty = pretty;
		}
		#line default
		
		public static string print(global::Xml xml, global::haxe.lang.Null<bool> pretty) {
			#line 35 "/opt/haxe/std/haxe/xml/Printer.hx"
			global::haxe.lang.Null<bool> pretty1 = ( ( ! (pretty.hasValue) ) ? (new global::haxe.lang.Null<bool>(false, true)) : (pretty) );
			global::haxe.xml.Printer printer = new global::haxe.xml.Printer((pretty1).@value);
			#line 37 "/opt/haxe/std/haxe/xml/Printer.hx"
			printer.writeNode(xml, "");
			return printer.output.b.ToString();
		}
		#line default
		
		public global::StringBuf output;
		
		public bool pretty;
		
		public virtual void writeNode(global::Xml @value, string tabs) {
			unchecked {
				#line 50 "/opt/haxe/std/haxe/xml/Printer.hx"
				switch (@value.nodeType) {
					case 0:
					{
						#line 68 "/opt/haxe/std/haxe/xml/Printer.hx"
						this.output.b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.concat(tabs, "<"))) ));
						{
							#line 69 "/opt/haxe/std/haxe/xml/Printer.hx"
							if (( @value.nodeType != global::Xml.Element )) {
								#line 69 "/opt/haxe/std/haxe/xml/Printer.hx"
								throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, expected Element but found ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
							}
							
							#line 69 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) (global::Std.@string(@value.nodeName)) ));
						}
						
						#line 70 "/opt/haxe/std/haxe/xml/Printer.hx"
						{
							#line 70 "/opt/haxe/std/haxe/xml/Printer.hx"
							object attribute = @value.attributes();
							#line 70 "/opt/haxe/std/haxe/xml/Printer.hx"
							while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(attribute, "hasNext", 407283053, null))) {
								#line 70 "/opt/haxe/std/haxe/xml/Printer.hx"
								string attribute1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(attribute, "next", 1224901875, null));
								this.output.b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(" ", attribute1), "=\""))) ));
								#line 72 "/opt/haxe/std/haxe/xml/Printer.hx"
								{
									#line 72 "/opt/haxe/std/haxe/xml/Printer.hx"
									string input = global::StringTools.htmlEscape(@value.@get(attribute1), new global::haxe.lang.Null<bool>(true, true));
									#line 72 "/opt/haxe/std/haxe/xml/Printer.hx"
									this.output.b.Append(((string) (global::Std.@string(input)) ));
								}
								
								#line 73 "/opt/haxe/std/haxe/xml/Printer.hx"
								this.output.b.Append(((string) ("\"") ));
							}
							
						}
						
						#line 75 "/opt/haxe/std/haxe/xml/Printer.hx"
						if (this.hasChildren(@value)) {
							#line 76 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) (">") ));
							if (this.pretty) {
								#line 77 "/opt/haxe/std/haxe/xml/Printer.hx"
								this.output.b.Append(((string) ("\n") ));
							}
							
							#line 78 "/opt/haxe/std/haxe/xml/Printer.hx"
							{
								#line 78 "/opt/haxe/std/haxe/xml/Printer.hx"
								if (( ( @value.nodeType != global::Xml.Document ) && ( @value.nodeType != global::Xml.Element ) )) {
									#line 78 "/opt/haxe/std/haxe/xml/Printer.hx"
									throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, expected Element or Document but found ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
								}
								
								#line 78 "/opt/haxe/std/haxe/xml/Printer.hx"
								int _g_current = 0;
								#line 78 "/opt/haxe/std/haxe/xml/Printer.hx"
								global::Array<object> _g_array = @value.children;
								#line 78 "/opt/haxe/std/haxe/xml/Printer.hx"
								while (( _g_current < _g_array.length )) {
									#line 78 "/opt/haxe/std/haxe/xml/Printer.hx"
									global::Xml child = ((global::Xml) (_g_array[_g_current++]) );
									this.writeNode(child, ( (this.pretty) ? (global::haxe.lang.Runtime.concat(tabs, "\t")) : (tabs) ));
								}
								
							}
							
							#line 81 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.concat(tabs, "</"))) ));
							{
								#line 82 "/opt/haxe/std/haxe/xml/Printer.hx"
								if (( @value.nodeType != global::Xml.Element )) {
									#line 82 "/opt/haxe/std/haxe/xml/Printer.hx"
									throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, expected Element but found ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
								}
								
								#line 82 "/opt/haxe/std/haxe/xml/Printer.hx"
								this.output.b.Append(((string) (global::Std.@string(@value.nodeName)) ));
							}
							
							#line 83 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) (">") ));
							if (this.pretty) {
								#line 84 "/opt/haxe/std/haxe/xml/Printer.hx"
								this.output.b.Append(((string) ("\n") ));
							}
							
						}
						else {
							#line 86 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) ("/>") ));
							if (this.pretty) {
								#line 87 "/opt/haxe/std/haxe/xml/Printer.hx"
								this.output.b.Append(((string) ("\n") ));
							}
							
						}
						
						#line 67 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					case 1:
					{
						#line 90 "/opt/haxe/std/haxe/xml/Printer.hx"
						if (( ( @value.nodeType == global::Xml.Document ) || ( @value.nodeType == global::Xml.Element ) )) {
							#line 90 "/opt/haxe/std/haxe/xml/Printer.hx"
							throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, unexpected ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
						}
						
						#line 90 "/opt/haxe/std/haxe/xml/Printer.hx"
						string nodeValue = @value.nodeValue;
						if (( nodeValue.Length != 0 )) {
							#line 92 "/opt/haxe/std/haxe/xml/Printer.hx"
							{
								#line 92 "/opt/haxe/std/haxe/xml/Printer.hx"
								string input1 = global::haxe.lang.Runtime.concat(tabs, global::StringTools.htmlEscape(nodeValue, default(global::haxe.lang.Null<bool>)));
								#line 92 "/opt/haxe/std/haxe/xml/Printer.hx"
								this.output.b.Append(((string) (global::Std.@string(input1)) ));
							}
							
							#line 93 "/opt/haxe/std/haxe/xml/Printer.hx"
							if (this.pretty) {
								#line 93 "/opt/haxe/std/haxe/xml/Printer.hx"
								this.output.b.Append(((string) ("\n") ));
							}
							
						}
						
						#line 89 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					case 2:
					{
						#line 52 "/opt/haxe/std/haxe/xml/Printer.hx"
						this.output.b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.concat(tabs, "<![CDATA["))) ));
						{
							#line 53 "/opt/haxe/std/haxe/xml/Printer.hx"
							if (( ( @value.nodeType == global::Xml.Document ) || ( @value.nodeType == global::Xml.Element ) )) {
								#line 53 "/opt/haxe/std/haxe/xml/Printer.hx"
								throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, unexpected ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
							}
							
							#line 53 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) (global::Std.@string(@value.nodeValue)) ));
						}
						
						#line 54 "/opt/haxe/std/haxe/xml/Printer.hx"
						this.output.b.Append(((string) ("]]>") ));
						if (this.pretty) {
							#line 55 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) ("\n") ));
						}
						
						#line 51 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					case 3:
					{
						#line 57 "/opt/haxe/std/haxe/xml/Printer.hx"
						if (( ( @value.nodeType == global::Xml.Document ) || ( @value.nodeType == global::Xml.Element ) )) {
							#line 57 "/opt/haxe/std/haxe/xml/Printer.hx"
							throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, unexpected ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
						}
						
						#line 57 "/opt/haxe/std/haxe/xml/Printer.hx"
						string commentContent = @value.nodeValue;
						commentContent = new global::EReg("[\n\r\t]+", "g").replace(commentContent, "");
						#line 59 "/opt/haxe/std/haxe/xml/Printer.hx"
						commentContent = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<!--", commentContent), "-->");
						this.output.b.Append(((string) (global::Std.@string(tabs)) ));
						#line 61 "/opt/haxe/std/haxe/xml/Printer.hx"
						{
							#line 61 "/opt/haxe/std/haxe/xml/Printer.hx"
							string input2 = commentContent.Trim();
							#line 61 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) (global::Std.@string(input2)) ));
						}
						
						#line 62 "/opt/haxe/std/haxe/xml/Printer.hx"
						if (this.pretty) {
							#line 62 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) ("\n") ));
						}
						
						#line 56 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					case 4:
					{
						#line 99 "/opt/haxe/std/haxe/xml/Printer.hx"
						{
							#line 99 "/opt/haxe/std/haxe/xml/Printer.hx"
							if (( ( @value.nodeType == global::Xml.Document ) || ( @value.nodeType == global::Xml.Element ) )) {
								#line 99 "/opt/haxe/std/haxe/xml/Printer.hx"
								throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, unexpected ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
							}
							
							#line 99 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<!DOCTYPE ", @value.nodeValue), ">"))) ));
						}
						
						#line 100 "/opt/haxe/std/haxe/xml/Printer.hx"
						if (this.pretty) {
							#line 100 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) ("\n") ));
						}
						
						#line 98 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					case 5:
					{
						#line 96 "/opt/haxe/std/haxe/xml/Printer.hx"
						{
							#line 96 "/opt/haxe/std/haxe/xml/Printer.hx"
							if (( ( @value.nodeType == global::Xml.Document ) || ( @value.nodeType == global::Xml.Element ) )) {
								#line 96 "/opt/haxe/std/haxe/xml/Printer.hx"
								throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, unexpected ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
							}
							
							#line 96 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<?", @value.nodeValue), "?>"))) ));
						}
						
						#line 97 "/opt/haxe/std/haxe/xml/Printer.hx"
						if (this.pretty) {
							#line 97 "/opt/haxe/std/haxe/xml/Printer.hx"
							this.output.b.Append(((string) ("\n") ));
						}
						
						#line 95 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					case 6:
					{
						#line 64 "/opt/haxe/std/haxe/xml/Printer.hx"
						if (( ( @value.nodeType != global::Xml.Document ) && ( @value.nodeType != global::Xml.Element ) )) {
							#line 64 "/opt/haxe/std/haxe/xml/Printer.hx"
							throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, expected Element or Document but found ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
						}
						
						#line 64 "/opt/haxe/std/haxe/xml/Printer.hx"
						int _g_current1 = 0;
						#line 64 "/opt/haxe/std/haxe/xml/Printer.hx"
						global::Array<object> _g_array1 = @value.children;
						#line 64 "/opt/haxe/std/haxe/xml/Printer.hx"
						while (( _g_current1 < _g_array1.length )) {
							#line 64 "/opt/haxe/std/haxe/xml/Printer.hx"
							global::Xml child1 = ((global::Xml) (_g_array1[_g_current1++]) );
							this.writeNode(child1, tabs);
						}
						
						#line 64 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
				}
				
			}
			#line default
		}
		
		
		public void write(string input) {
			#line 105 "/opt/haxe/std/haxe/xml/Printer.hx"
			this.output.b.Append(((string) (global::Std.@string(input)) ));
		}
		#line default
		
		public void newline() {
			#line 109 "/opt/haxe/std/haxe/xml/Printer.hx"
			if (this.pretty) {
				#line 110 "/opt/haxe/std/haxe/xml/Printer.hx"
				this.output.b.Append(((string) ("\n") ));
			}
			
		}
		#line default
		
		public virtual bool hasChildren(global::Xml @value) {
			unchecked {
				#line 115 "/opt/haxe/std/haxe/xml/Printer.hx"
				{
					#line 115 "/opt/haxe/std/haxe/xml/Printer.hx"
					if (( ( @value.nodeType != global::Xml.Document ) && ( @value.nodeType != global::Xml.Element ) )) {
						#line 115 "/opt/haxe/std/haxe/xml/Printer.hx"
						throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, expected Element or Document but found ", global::_Xml.XmlType_Impl_.toString(@value.nodeType)))) );
					}
					
					#line 115 "/opt/haxe/std/haxe/xml/Printer.hx"
					int _g_current = 0;
					#line 115 "/opt/haxe/std/haxe/xml/Printer.hx"
					global::Array<object> _g_array = @value.children;
					#line 115 "/opt/haxe/std/haxe/xml/Printer.hx"
					while (( _g_current < _g_array.length )) {
						#line 115 "/opt/haxe/std/haxe/xml/Printer.hx"
						global::Xml child = ((global::Xml) (_g_array[_g_current++]) );
						switch (child.nodeType) {
							case 0:
							case 1:
							{
								#line 118 "/opt/haxe/std/haxe/xml/Printer.hx"
								return true;
							}
							
							
							case 2:
							case 3:
							{
								#line 120 "/opt/haxe/std/haxe/xml/Printer.hx"
								if (( ( child.nodeType == global::Xml.Document ) || ( child.nodeType == global::Xml.Element ) )) {
									#line 120 "/opt/haxe/std/haxe/xml/Printer.hx"
									throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Bad node type, unexpected ", global::_Xml.XmlType_Impl_.toString(child.nodeType)))) );
								}
								
								#line 120 "/opt/haxe/std/haxe/xml/Printer.hx"
								if (( child.nodeValue.TrimStart().Length != 0 )) {
									#line 121 "/opt/haxe/std/haxe/xml/Printer.hx"
									return true;
								}
								
								#line 120 "/opt/haxe/std/haxe/xml/Printer.hx"
								break;
							}
							
							
							default:
							{
								#line 123 "/opt/haxe/std/haxe/xml/Printer.hx"
								break;
							}
							
						}
						
					}
					
				}
				
				#line 126 "/opt/haxe/std/haxe/xml/Printer.hx"
				return false;
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
				switch (hash) {
					case 784433846:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						this.pretty = global::haxe.lang.Runtime.toBool(@value);
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return @value;
					}
					
					
					case 209784577:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						this.output = ((global::StringBuf) (@value) );
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return @value;
					}
					
					
					default:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
				switch (hash) {
					case 1126235833:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasChildren", 1126235833)) );
					}
					
					
					case 212244564:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "newline", 212244564)) );
					}
					
					
					case 1348037855:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "write", 1348037855)) );
					}
					
					
					case 1371405953:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeNode", 1371405953)) );
					}
					
					
					case 784433846:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return this.pretty;
					}
					
					
					case 209784577:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return this.output;
					}
					
					
					default:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
				switch (hash) {
					case 1126235833:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return this.hasChildren(((global::Xml) (dynargs[0]) ));
					}
					
					
					case 212244564:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						this.newline();
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					case 1348037855:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						this.write(global::haxe.lang.Runtime.toString(dynargs[0]));
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					case 1371405953:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						this.writeNode(((global::Xml) (dynargs[0]) ), global::haxe.lang.Runtime.toString(dynargs[1]));
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						break;
					}
					
					
					default:
					{
						#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
			baseArr.push("pretty");
			#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
			baseArr.push("output");
			#line 29 "/opt/haxe/std/haxe/xml/Printer.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}

