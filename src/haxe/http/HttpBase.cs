// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.http {
	public class HttpBase : global::haxe.lang.HxObject {
		
		public HttpBase(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HttpBase(string url) {
			#line 71 "/opt/haxe/std/haxe/http/HttpBase.hx"
			global::haxe.http.HttpBase.__hx_ctor_haxe_http_HttpBase(this, url);
		}
		#line default
		
		protected static void __hx_ctor_haxe_http_HttpBase(global::haxe.http.HttpBase __hx_this, string url) {
			#line 223 "/opt/haxe/std/haxe/http/HttpBase.hx"
			__hx_this.onStatus = ( (( global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_223__Fun.__hx_current != null )) ? (global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_223__Fun.__hx_current) : (global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_223__Fun.__hx_current = ((global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_223__Fun) (new global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_223__Fun()) )) );
			#line 214 "/opt/haxe/std/haxe/http/HttpBase.hx"
			__hx_this.onError = ( (( global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_214__Fun.__hx_current != null )) ? (global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_214__Fun.__hx_current) : (global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_214__Fun.__hx_current = ((global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_214__Fun) (new global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_214__Fun()) )) );
			#line 205 "/opt/haxe/std/haxe/http/HttpBase.hx"
			__hx_this.onBytes = ( (( global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_205__Fun.__hx_current != null )) ? (global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_205__Fun.__hx_current) : (global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_205__Fun.__hx_current = ((global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_205__Fun) (new global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_205__Fun()) )) );
			#line 196 "/opt/haxe/std/haxe/http/HttpBase.hx"
			__hx_this.onData = ( (( global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_196__Fun.__hx_current != null )) ? (global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_196__Fun.__hx_current) : (global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_196__Fun.__hx_current = ((global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_196__Fun) (new global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_196__Fun()) )) );
			#line 71 "/opt/haxe/std/haxe/http/HttpBase.hx"
			{
				#line 72 "/opt/haxe/std/haxe/http/HttpBase.hx"
				__hx_this.url = url;
				__hx_this.headers = new global::Array<object>(new object[]{});
				#line 74 "/opt/haxe/std/haxe/http/HttpBase.hx"
				__hx_this.@params = new global::Array<object>(new object[]{});
				__hx_this.emptyOnData = __hx_this.onData;
			}
			
		}
		#line default
		
		public string url;
		
		
		
		public global::haxe.io.Bytes responseBytes;
		
		public string responseAsString;
		
		public string postData;
		
		public global::haxe.io.Bytes postBytes;
		
		public global::Array<object> headers;
		
		public global::Array<object> @params;
		
		public global::haxe.lang.Function emptyOnData;
		
		public virtual void setHeader(string name, string @value) {
			#line 86 "/opt/haxe/std/haxe/http/HttpBase.hx"
			{
				#line 86 "/opt/haxe/std/haxe/http/HttpBase.hx"
				int _g = 0;
				#line 86 "/opt/haxe/std/haxe/http/HttpBase.hx"
				int _g1 = this.headers.length;
				#line 86 "/opt/haxe/std/haxe/http/HttpBase.hx"
				while (( _g < _g1 )) {
					#line 86 "/opt/haxe/std/haxe/http/HttpBase.hx"
					int i = _g++;
					if (( global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.headers[i], "name", 1224700491, true)) == name )) {
						#line 88 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.headers[i] = new global::haxe.lang.DynamicObject(new int[]{834174833, 1224700491}, new object[]{@value, name}, new int[]{}, new double[]{});
						return;
					}
					
				}
				
			}
			
			#line 92 "/opt/haxe/std/haxe/http/HttpBase.hx"
			this.headers.push(new global::haxe.lang.DynamicObject(new int[]{834174833, 1224700491}, new object[]{@value, name}, new int[]{}, new double[]{}));
		}
		#line default
		
		public virtual void addHeader(string header, string @value) {
			#line 99 "/opt/haxe/std/haxe/http/HttpBase.hx"
			this.headers.push(new global::haxe.lang.DynamicObject(new int[]{834174833, 1224700491}, new object[]{@value, header}, new int[]{}, new double[]{}));
		}
		#line default
		
		public virtual void setParameter(string name, string @value) {
			#line 113 "/opt/haxe/std/haxe/http/HttpBase.hx"
			{
				#line 113 "/opt/haxe/std/haxe/http/HttpBase.hx"
				int _g = 0;
				#line 113 "/opt/haxe/std/haxe/http/HttpBase.hx"
				int _g1 = this.@params.length;
				#line 113 "/opt/haxe/std/haxe/http/HttpBase.hx"
				while (( _g < _g1 )) {
					#line 113 "/opt/haxe/std/haxe/http/HttpBase.hx"
					int i = _g++;
					if (( global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.@params[i], "name", 1224700491, true)) == name )) {
						#line 115 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.@params[i] = new global::haxe.lang.DynamicObject(new int[]{834174833, 1224700491}, new object[]{@value, name}, new int[]{}, new double[]{});
						return;
					}
					
				}
				
			}
			
			#line 119 "/opt/haxe/std/haxe/http/HttpBase.hx"
			this.@params.push(new global::haxe.lang.DynamicObject(new int[]{834174833, 1224700491}, new object[]{@value, name}, new int[]{}, new double[]{}));
		}
		#line default
		
		public virtual void addParameter(string name, string @value) {
			#line 126 "/opt/haxe/std/haxe/http/HttpBase.hx"
			this.@params.push(new global::haxe.lang.DynamicObject(new int[]{834174833, 1224700491}, new object[]{@value, name}, new int[]{}, new double[]{}));
		}
		#line default
		
		public virtual void setPostData(string data) {
			#line 143 "/opt/haxe/std/haxe/http/HttpBase.hx"
			this.postData = data;
			this.postBytes = null;
		}
		#line default
		
		public virtual void setPostBytes(global::haxe.io.Bytes data) {
			#line 161 "/opt/haxe/std/haxe/http/HttpBase.hx"
			this.postBytes = data;
			this.postData = null;
		}
		#line default
		
		public virtual void request(global::haxe.lang.Null<bool> post) {
			#line 186 "/opt/haxe/std/haxe/http/HttpBase.hx"
			throw ((global::System.Exception) (global::haxe.Exception.thrown("not implemented")) );
		}
		#line default
		
		public global::haxe.lang.Function onData;
		
		public global::haxe.lang.Function onBytes;
		
		public global::haxe.lang.Function onError;
		
		public global::haxe.lang.Function onStatus;
		
		public virtual bool hasOnData() {
			#line 229 "/opt/haxe/std/haxe/http/HttpBase.hx"
			return  ! (global::Reflect.compareMethods(this.onData, this.emptyOnData)) ;
		}
		#line default
		
		public virtual void success(global::haxe.io.Bytes data) {
			#line 233 "/opt/haxe/std/haxe/http/HttpBase.hx"
			this.responseBytes = data;
			this.responseAsString = null;
			#line 235 "/opt/haxe/std/haxe/http/HttpBase.hx"
			if (this.hasOnData()) {
				#line 236 "/opt/haxe/std/haxe/http/HttpBase.hx"
				this.onData.__hx_invoke1_o(default(double), this.get_responseData());
			}
			
			#line 238 "/opt/haxe/std/haxe/http/HttpBase.hx"
			this.onBytes.__hx_invoke1_o(default(double), this.responseBytes);
		}
		#line default
		
		public virtual string get_responseData() {
			#line 242 "/opt/haxe/std/haxe/http/HttpBase.hx"
			if (( ( this.responseAsString == null ) && ( this.responseBytes != null ) )) {
				#line 246 "/opt/haxe/std/haxe/http/HttpBase.hx"
				this.responseAsString = this.responseBytes.getString(0, this.responseBytes.length, global::haxe.io.Encoding.UTF8);
			}
			
			#line 249 "/opt/haxe/std/haxe/http/HttpBase.hx"
			return this.responseAsString;
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
				switch (hash) {
					case 1705565617:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.onStatus = ((global::haxe.lang.Function) (@value) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 157772329:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.onError = ((global::haxe.lang.Function) (@value) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 1406510796:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.onBytes = ((global::haxe.lang.Function) (@value) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 1693277929:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.onData = ((global::haxe.lang.Function) (@value) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 756413782:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.emptyOnData = ((global::haxe.lang.Function) (@value) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 1836776262:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.@params = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 1661489734:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.headers = ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (@value) ))) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 1993152491:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.postBytes = ((global::haxe.io.Bytes) (@value) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 10663594:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.postData = global::haxe.lang.Runtime.toString(@value);
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 1757972228:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.responseAsString = global::haxe.lang.Runtime.toString(@value);
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 1879807530:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.responseBytes = ((global::haxe.io.Bytes) (@value) );
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					case 5843823:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.url = global::haxe.lang.Runtime.toString(@value);
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return @value;
					}
					
					
					default:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
				switch (hash) {
					case 1233646036:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_responseData", 1233646036)) );
					}
					
					
					case 944645571:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "success", 944645571)) );
					}
					
					
					case 634786275:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasOnData", 634786275)) );
					}
					
					
					case 1705565617:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.onStatus;
					}
					
					
					case 157772329:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.onError;
					}
					
					
					case 1406510796:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.onBytes;
					}
					
					
					case 1693277929:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.onData;
					}
					
					
					case 1149558607:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "request", 1149558607)) );
					}
					
					
					case 454875113:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setPostBytes", 454875113)) );
					}
					
					
					case 822313068:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setPostData", 822313068)) );
					}
					
					
					case 1208244040:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addParameter", 1208244040)) );
					}
					
					
					case 1828713895:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setParameter", 1828713895)) );
					}
					
					
					case 891567758:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addHeader", 891567758)) );
					}
					
					
					case 1554480847:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "setHeader", 1554480847)) );
					}
					
					
					case 756413782:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.emptyOnData;
					}
					
					
					case 1836776262:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.@params;
					}
					
					
					case 1661489734:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.headers;
					}
					
					
					case 1993152491:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.postBytes;
					}
					
					
					case 10663594:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.postData;
					}
					
					
					case 1757972228:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.responseAsString;
					}
					
					
					case 1879807530:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.responseBytes;
					}
					
					
					case 1156121931:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.get_responseData();
					}
					
					
					case 5843823:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.url;
					}
					
					
					default:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
				switch (hash) {
					case 1233646036:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.get_responseData();
					}
					
					
					case 944645571:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.success(((global::haxe.io.Bytes) (dynargs[0]) ));
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						break;
					}
					
					
					case 634786275:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return this.hasOnData();
					}
					
					
					case 1149558607:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.request(global::haxe.lang.Null<object>.ofDynamic<bool>(( (( dynargs.Length > 0 )) ? (dynargs[0]) : (null) )));
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						break;
					}
					
					
					case 454875113:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.setPostBytes(((global::haxe.io.Bytes) (dynargs[0]) ));
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						break;
					}
					
					
					case 822313068:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.setPostData(global::haxe.lang.Runtime.toString(dynargs[0]));
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						break;
					}
					
					
					case 1208244040:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.addParameter(global::haxe.lang.Runtime.toString(dynargs[0]), global::haxe.lang.Runtime.toString(dynargs[1]));
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						break;
					}
					
					
					case 1828713895:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.setParameter(global::haxe.lang.Runtime.toString(dynargs[0]), global::haxe.lang.Runtime.toString(dynargs[1]));
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						break;
					}
					
					
					case 891567758:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.addHeader(global::haxe.lang.Runtime.toString(dynargs[0]), global::haxe.lang.Runtime.toString(dynargs[1]));
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						break;
					}
					
					
					case 1554480847:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						this.setHeader(global::haxe.lang.Runtime.toString(dynargs[0]), global::haxe.lang.Runtime.toString(dynargs[1]));
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						break;
					}
					
					
					default:
					{
						#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("onStatus");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("onError");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("onBytes");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("onData");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("emptyOnData");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("params");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("headers");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("postBytes");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("postData");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("responseAsString");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("responseBytes");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("responseData");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			baseArr.push("url");
			#line 41 "/opt/haxe/std/haxe/http/HttpBase.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.http {
	public class HttpBase___hx_ctor_haxe_http_HttpBase_223__Fun : global::haxe.lang.Function {
		
		public HttpBase___hx_ctor_haxe_http_HttpBase_223__Fun() : base(1, 0) {
		}
		
		
		public static global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_223__Fun __hx_current;
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 223 "/opt/haxe/std/haxe/http/HttpBase.hx"
			int status = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((int) (__fn_float1) )) : (((int) (global::haxe.lang.Runtime.toInt(__fn_dyn1)) )) );
			#line 223 "/opt/haxe/std/haxe/http/HttpBase.hx"
			return null;
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.http {
	public class HttpBase___hx_ctor_haxe_http_HttpBase_214__Fun : global::haxe.lang.Function {
		
		public HttpBase___hx_ctor_haxe_http_HttpBase_214__Fun() : base(1, 0) {
		}
		
		
		public static global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_214__Fun __hx_current;
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 214 "/opt/haxe/std/haxe/http/HttpBase.hx"
			string msg = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (global::haxe.lang.Runtime.toString(__fn_float1)) : (global::haxe.lang.Runtime.toString(__fn_dyn1)) );
			#line 214 "/opt/haxe/std/haxe/http/HttpBase.hx"
			return null;
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.http {
	public class HttpBase___hx_ctor_haxe_http_HttpBase_205__Fun : global::haxe.lang.Function {
		
		public HttpBase___hx_ctor_haxe_http_HttpBase_205__Fun() : base(1, 0) {
		}
		
		
		public static global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_205__Fun __hx_current;
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 205 "/opt/haxe/std/haxe/http/HttpBase.hx"
			global::haxe.io.Bytes data = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((global::haxe.io.Bytes) (((object) (__fn_float1) )) )) : (((global::haxe.io.Bytes) (__fn_dyn1) )) );
			#line 205 "/opt/haxe/std/haxe/http/HttpBase.hx"
			return null;
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.http {
	public class HttpBase___hx_ctor_haxe_http_HttpBase_196__Fun : global::haxe.lang.Function {
		
		public HttpBase___hx_ctor_haxe_http_HttpBase_196__Fun() : base(1, 0) {
		}
		
		
		public static global::haxe.http.HttpBase___hx_ctor_haxe_http_HttpBase_196__Fun __hx_current;
		
		public override object __hx_invoke1_o(double __fn_float1, object __fn_dyn1) {
			#line 196 "/opt/haxe/std/haxe/http/HttpBase.hx"
			string data = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (global::haxe.lang.Runtime.toString(__fn_float1)) : (global::haxe.lang.Runtime.toString(__fn_dyn1)) );
			#line 196 "/opt/haxe/std/haxe/http/HttpBase.hx"
			return null;
		}
		#line default
		
	}
}


