// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace maglev {
	public class Telemetry : global::haxe.lang.HxObject {
		
		public Telemetry(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Telemetry() {
			#line 17 "/my-component/src/maglev/Telemetry.hx"
			global::maglev.Telemetry.__hx_ctor_maglev_Telemetry(this);
		}
		#line default
		
		protected static void __hx_ctor_maglev_Telemetry(global::maglev.Telemetry __hx_this) {
			#line 18 "/my-component/src/maglev/Telemetry.hx"
			__hx_this.info = new global::Array<string>();
		}
		#line default
		
		public global::Array<string> info;
		
		public virtual void addInfo(global::Array<string> args) {
			#line 21 "/my-component/src/maglev/Telemetry.hx"
			int _g = 0;
			#line 21 "/my-component/src/maglev/Telemetry.hx"
			while (( _g < args.length )) {
				#line 21 "/my-component/src/maglev/Telemetry.hx"
				string arg = args[_g];
				#line 21 "/my-component/src/maglev/Telemetry.hx"
				 ++ _g;
				this.info.push(arg);
			}
			
		}
		#line default
		
		public virtual void send(global::Array<string> args) {
			#line 26 "/my-component/src/maglev/Telemetry.hx"
			string url = "http://telemetry.mindpowered.link/send?";
			{
				#line 27 "/my-component/src/maglev/Telemetry.hx"
				int _g = 0;
				#line 27 "/my-component/src/maglev/Telemetry.hx"
				global::Array<string> _g1 = this.info;
				#line 27 "/my-component/src/maglev/Telemetry.hx"
				while (( _g < _g1.length )) {
					#line 27 "/my-component/src/maglev/Telemetry.hx"
					string item = _g1[_g];
					#line 27 "/my-component/src/maglev/Telemetry.hx"
					 ++ _g;
					url = global::haxe.lang.Runtime.concat(url, global::haxe.lang.Runtime.concat(global::System.Uri.EscapeDataString(((string) (item) )), "&"));
				}
				
			}
			
			#line 30 "/my-component/src/maglev/Telemetry.hx"
			{
				#line 30 "/my-component/src/maglev/Telemetry.hx"
				int _g2 = 0;
				#line 30 "/my-component/src/maglev/Telemetry.hx"
				while (( _g2 < args.length )) {
					#line 30 "/my-component/src/maglev/Telemetry.hx"
					string item1 = args[_g2];
					#line 30 "/my-component/src/maglev/Telemetry.hx"
					 ++ _g2;
					url = global::haxe.lang.Runtime.concat(url, global::haxe.lang.Runtime.concat(global::System.Uri.EscapeDataString(((string) (item1) )), "&"));
				}
				
			}
			
			#line 34 "/my-component/src/maglev/Telemetry.hx"
			global::sys.Http.requestUrl(url);
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 14 "/my-component/src/maglev/Telemetry.hx"
				switch (hash) {
					case 1169897582:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						this.info = ((global::Array<string>) (global::Array<object>.__hx_cast<string>(((global::Array) (@value) ))) );
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						return @value;
					}
					
					
					default:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 14 "/my-component/src/maglev/Telemetry.hx"
				switch (hash) {
					case 1280347464:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "send", 1280347464)) );
					}
					
					
					case 33061679:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "addInfo", 33061679)) );
					}
					
					
					case 1169897582:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						return this.info;
					}
					
					
					default:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 14 "/my-component/src/maglev/Telemetry.hx"
				switch (hash) {
					case 1280347464:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						this.send(((global::Array<string>) (global::Array<object>.__hx_cast<string>(((global::Array) (dynargs[0]) ))) ));
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						break;
					}
					
					
					case 33061679:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						this.addInfo(((global::Array<string>) (global::Array<object>.__hx_cast<string>(((global::Array) (dynargs[0]) ))) ));
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						break;
					}
					
					
					default:
					{
						#line 14 "/my-component/src/maglev/Telemetry.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 14 "/my-component/src/maglev/Telemetry.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 14 "/my-component/src/maglev/Telemetry.hx"
			baseArr.push("info");
			#line 14 "/my-component/src/maglev/Telemetry.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}


