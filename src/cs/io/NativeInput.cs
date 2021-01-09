// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs.io {
	public class NativeInput : global::haxe.io.Input {
		
		public NativeInput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public NativeInput(global::System.IO.Stream stream) {
			#line 37 "/opt/haxe/std/cs/io/NativeInput.hx"
			global::cs.io.NativeInput.__hx_ctor_cs_io_NativeInput(this, stream);
		}
		#line default
		
		protected static void __hx_ctor_cs_io_NativeInput(global::cs.io.NativeInput __hx_this, global::System.IO.Stream stream) {
			#line 38 "/opt/haxe/std/cs/io/NativeInput.hx"
			__hx_this.stream = stream;
			__hx_this._eof = false;
			#line 40 "/opt/haxe/std/cs/io/NativeInput.hx"
			if ( ! (stream.CanRead) ) {
				#line 41 "/opt/haxe/std/cs/io/NativeInput.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown("Write-only stream")) );
			}
			
		}
		#line default
		
		
		
		public global::System.IO.Stream stream;
		
		public bool _eof;
		
		public override int readByte() {
			unchecked {
				#line 45 "/opt/haxe/std/cs/io/NativeInput.hx"
				int ret = this.stream.ReadByte();
				if (( ret == -1 )) {
					#line 47 "/opt/haxe/std/cs/io/NativeInput.hx"
					this._eof = true;
					throw ((global::System.Exception) (global::haxe.Exception.thrown(new global::haxe.io.Eof())) );
				}
				
				#line 50 "/opt/haxe/std/cs/io/NativeInput.hx"
				return ret;
			}
			#line default
		}
		
		
		public override int readBytes(global::haxe.io.Bytes s, int pos, int len) {
			#line 54 "/opt/haxe/std/cs/io/NativeInput.hx"
			if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) {
				#line 55 "/opt/haxe/std/cs/io/NativeInput.hx"
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.io.Error.OutsideBounds)) );
			}
			
			#line 56 "/opt/haxe/std/cs/io/NativeInput.hx"
			int ret = 0;
			byte[] data = s.b;
			#line 59 "/opt/haxe/std/cs/io/NativeInput.hx"
			try {
				#line 59 "/opt/haxe/std/cs/io/NativeInput.hx"
				ret = this.stream.Read(((byte[]) (data) ), ((int) (pos) ), ((int) (len) ));
			}
			catch (global::System.Exception _g){
				{
					global::haxe.NativeStackTrace.exception = ((global::System.Exception) (((object) (_g) )) );
				}
				
			}
			
			
			#line 61 "/opt/haxe/std/cs/io/NativeInput.hx"
			if (( ret == 0 )) {
				#line 62 "/opt/haxe/std/cs/io/NativeInput.hx"
				this._eof = true;
				throw ((global::System.Exception) (global::haxe.Exception.thrown(new global::haxe.io.Eof())) );
			}
			
			#line 65 "/opt/haxe/std/cs/io/NativeInput.hx"
			return ret;
		}
		#line default
		
		public override void close() {
			#line 69 "/opt/haxe/std/cs/io/NativeInput.hx"
			this.stream.Close();
		}
		#line default
		
		public bool get_canSeek() {
			#line 73 "/opt/haxe/std/cs/io/NativeInput.hx"
			return this.stream.CanSeek;
		}
		#line default
		
		public virtual void seek(int p, global::sys.io.FileSeek pos) {
			unchecked {
				#line 77 "/opt/haxe/std/cs/io/NativeInput.hx"
				this._eof = false;
				global::System.IO.SeekOrigin pos1 = default(global::System.IO.SeekOrigin);
				switch (pos._hx_index) {
					case 0:
					{
						#line 78 "/opt/haxe/std/cs/io/NativeInput.hx"
						pos1 = global::System.IO.SeekOrigin.Begin;
						#line 78 "/opt/haxe/std/cs/io/NativeInput.hx"
						break;
					}
					
					
					case 1:
					{
						#line 78 "/opt/haxe/std/cs/io/NativeInput.hx"
						pos1 = global::System.IO.SeekOrigin.Current;
						#line 78 "/opt/haxe/std/cs/io/NativeInput.hx"
						break;
					}
					
					
					case 2:
					{
						#line 78 "/opt/haxe/std/cs/io/NativeInput.hx"
						pos1 = global::System.IO.SeekOrigin.End;
						#line 78 "/opt/haxe/std/cs/io/NativeInput.hx"
						break;
					}
					
					
				}
				
				#line 84 "/opt/haxe/std/cs/io/NativeInput.hx"
				this.stream.Seek(((long) (p) ), ((global::System.IO.SeekOrigin) (pos1) ));
			}
			#line default
		}
		
		
		public virtual int tell() {
			#line 88 "/opt/haxe/std/cs/io/NativeInput.hx"
			return ((int) (this.stream.Position) );
		}
		#line default
		
		public bool eof() {
			#line 92 "/opt/haxe/std/cs/io/NativeInput.hx"
			return this._eof;
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
				switch (hash) {
					case 1058556349:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						this._eof = global::haxe.lang.Runtime.toBool(@value);
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return @value;
					}
					
					
					case 288167040:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						this.stream = ((global::System.IO.Stream) (@value) );
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return @value;
					}
					
					
					default:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
				switch (hash) {
					case 5047484:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "eof", 5047484)) );
					}
					
					
					case 1291436593:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "tell", 1291436593)) );
					}
					
					
					case 1280345464:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "seek", 1280345464)) );
					}
					
					
					case 1889717695:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_canSeek", 1889717695)) );
					}
					
					
					case 1214453688:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 243225909:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readBytes", 243225909)) );
					}
					
					
					case 1763375486:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "readByte", 1763375486)) );
					}
					
					
					case 1058556349:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return this._eof;
					}
					
					
					case 288167040:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return this.stream;
					}
					
					
					case 1789423016:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return this.get_canSeek();
					}
					
					
					default:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
				switch (hash) {
					case 1763375486:
					case 243225909:
					case 1214453688:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 5047484:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return this.eof();
					}
					
					
					case 1291436593:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return this.tell();
					}
					
					
					case 1280345464:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						this.seek(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((global::sys.io.FileSeek) (dynargs[1]) ));
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						break;
					}
					
					
					case 1889717695:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return this.get_canSeek();
					}
					
					
					default:
					{
						#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
			baseArr.push("_eof");
			#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
			baseArr.push("stream");
			#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
			baseArr.push("canSeek");
			#line 31 "/opt/haxe/std/cs/io/NativeInput.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}

