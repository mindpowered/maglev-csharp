// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.crypto {
	public class Base64 : global::haxe.lang.HxObject {
		
		static Base64() {
			#line 29 "/opt/haxe/std/haxe/crypto/Base64.hx"
			global::haxe.crypto.Base64.CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
			global::haxe.crypto.Base64.BYTES = global::haxe.io.Bytes.ofString(global::haxe.crypto.Base64.CHARS, null);
			#line 32 "/opt/haxe/std/haxe/crypto/Base64.hx"
			global::haxe.crypto.Base64.URL_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_";
			global::haxe.crypto.Base64.URL_BYTES = global::haxe.io.Bytes.ofString(global::haxe.crypto.Base64.URL_CHARS, null);
		}
		#line default
		
		public Base64(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Base64() {
			#line 28 "/opt/haxe/std/haxe/crypto/Base64.hx"
			global::haxe.crypto.Base64.__hx_ctor_haxe_crypto_Base64(this);
		}
		#line default
		
		protected static void __hx_ctor_haxe_crypto_Base64(global::haxe.crypto.Base64 __hx_this) {
		}
		
		
		public static string CHARS;
		
		public static global::haxe.io.Bytes BYTES;
		
		public static string URL_CHARS;
		
		public static global::haxe.io.Bytes URL_BYTES;
		
		public static string encode(global::haxe.io.Bytes bytes, global::haxe.lang.Null<bool> complement) {
			unchecked {
				#line 35 "/opt/haxe/std/haxe/crypto/Base64.hx"
				bool complement1 = ( ( ! (complement.hasValue) ) ? (true) : ((complement).@value) );
				string str = new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.crypto.Base64.BYTES) )).encodeBytes(bytes).toString();
				#line 37 "/opt/haxe/std/haxe/crypto/Base64.hx"
				if (complement1) {
					#line 38 "/opt/haxe/std/haxe/crypto/Base64.hx"
					switch (( bytes.length % 3 )) {
						case 1:
						{
							#line 40 "/opt/haxe/std/haxe/crypto/Base64.hx"
							str = global::haxe.lang.Runtime.concat(str, "==");
							#line 40 "/opt/haxe/std/haxe/crypto/Base64.hx"
							break;
						}
						
						
						case 2:
						{
							#line 42 "/opt/haxe/std/haxe/crypto/Base64.hx"
							str = global::haxe.lang.Runtime.concat(str, "=");
							#line 42 "/opt/haxe/std/haxe/crypto/Base64.hx"
							break;
						}
						
						
						default:
						{
							#line 43 "/opt/haxe/std/haxe/crypto/Base64.hx"
							break;
						}
						
					}
					
				}
				
				#line 45 "/opt/haxe/std/haxe/crypto/Base64.hx"
				return str;
			}
			#line default
		}
		
		
		public static global::haxe.io.Bytes decode(string str, global::haxe.lang.Null<bool> complement) {
			unchecked {
				#line 48 "/opt/haxe/std/haxe/crypto/Base64.hx"
				bool complement1 = ( ( ! (complement.hasValue) ) ? (true) : ((complement).@value) );
				if (complement1) {
					#line 50 "/opt/haxe/std/haxe/crypto/Base64.hx"
					while (global::haxe.lang.Runtime.eq((global::haxe.lang.StringExt.charCodeAt(str, ( str.Length - 1 ))).toDynamic(), 61)) {
						#line 51 "/opt/haxe/std/haxe/crypto/Base64.hx"
						str = global::haxe.lang.StringExt.substr(str, 0, new global::haxe.lang.Null<int>(-1, true));
					}
					
				}
				
				#line 52 "/opt/haxe/std/haxe/crypto/Base64.hx"
				return new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.crypto.Base64.BYTES) )).decodeBytes(global::haxe.io.Bytes.ofString(str, null));
			}
			#line default
		}
		
		
		public static string urlEncode(global::haxe.io.Bytes bytes, global::haxe.lang.Null<bool> complement) {
			unchecked {
				#line 55 "/opt/haxe/std/haxe/crypto/Base64.hx"
				bool complement1 = ( ( ! (complement.hasValue) ) ? (false) : ((complement).@value) );
				string str = new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.crypto.Base64.URL_BYTES) )).encodeBytes(bytes).toString();
				#line 57 "/opt/haxe/std/haxe/crypto/Base64.hx"
				if (complement1) {
					#line 58 "/opt/haxe/std/haxe/crypto/Base64.hx"
					switch (( bytes.length % 3 )) {
						case 1:
						{
							#line 60 "/opt/haxe/std/haxe/crypto/Base64.hx"
							str = global::haxe.lang.Runtime.concat(str, "==");
							#line 60 "/opt/haxe/std/haxe/crypto/Base64.hx"
							break;
						}
						
						
						case 2:
						{
							#line 62 "/opt/haxe/std/haxe/crypto/Base64.hx"
							str = global::haxe.lang.Runtime.concat(str, "=");
							#line 62 "/opt/haxe/std/haxe/crypto/Base64.hx"
							break;
						}
						
						
						default:
						{
							#line 63 "/opt/haxe/std/haxe/crypto/Base64.hx"
							break;
						}
						
					}
					
				}
				
				#line 65 "/opt/haxe/std/haxe/crypto/Base64.hx"
				return str;
			}
			#line default
		}
		
		
		public static global::haxe.io.Bytes urlDecode(string str, global::haxe.lang.Null<bool> complement) {
			unchecked {
				#line 68 "/opt/haxe/std/haxe/crypto/Base64.hx"
				bool complement1 = ( ( ! (complement.hasValue) ) ? (false) : ((complement).@value) );
				if (complement1) {
					#line 70 "/opt/haxe/std/haxe/crypto/Base64.hx"
					while (global::haxe.lang.Runtime.eq((global::haxe.lang.StringExt.charCodeAt(str, ( str.Length - 1 ))).toDynamic(), 61)) {
						#line 71 "/opt/haxe/std/haxe/crypto/Base64.hx"
						str = global::haxe.lang.StringExt.substr(str, 0, new global::haxe.lang.Null<int>(-1, true));
					}
					
				}
				
				#line 72 "/opt/haxe/std/haxe/crypto/Base64.hx"
				return new global::haxe.crypto.BaseCode(((global::haxe.io.Bytes) (global::haxe.crypto.Base64.URL_BYTES) )).decodeBytes(global::haxe.io.Bytes.ofString(str, null));
			}
			#line default
		}
		
		
	}
}


