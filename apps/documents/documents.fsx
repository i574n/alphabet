#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>]
type std_path_PathBuf = class end
#else
type std_path_PathBuf = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Display")>]
type std_path_Display = class end
#else
type std_path_Display = string
#endif

#if FABLE_COMPILER
type System_IO_DirectoryInfo = bool
#else
type System_IO_DirectoryInfo = System.IO.DirectoryInfo
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
type std_io_Error = class end
#else
type std_io_Error = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
type System_IO_FileInfo = bool
#else
type System_IO_FileInfo = System.IO.FileInfo
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>]
#endif
type async_walkdir_WalkDir = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>]
#endif
type async_walkdir_DirEntry = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::FileType")>]
#endif
type std_fs_FileType = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Filtering")>]
#endif
type async_walkdir_Filtering = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Error")>]
#endif
type async_walkdir_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Command")>]
#endif
type std_process_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Child")>]
#endif
type std_process_Child = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::MutexGuard<$0>")>]
#endif
type std_sync_MutexGuard<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdout")>]
#endif
type std_process_ChildStdout = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStderr")>]
#endif
type std_process_ChildStderr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdin")>]
#endif
type std_process_ChildStdin = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs_io::DecodeReaderBytes<$0, $1>")>]
#endif
type encoding_rs_io_DecodeReaderBytes<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::SendError<$0>")>]
#endif
type std_sync_mpsc_SendError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::thread::JoinHandle<$0>")>]
#endif
type std_thread_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ExitStatus")>]
#endif
type std_process_ExitStatus = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::File")>]
#endif
type std_fs_File = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("sha2::Sha256")>]
#endif
type sha2_Sha256 = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
type IFs = abstract realpathSync: path: string -> string
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
type IPathBasename = abstract basename: path: string -> string
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::PoisonError<$0>")>]
#endif
type std_sync_PoisonError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
type core_any_Any = class end
#else
type core_any_Any = obj
#endif

#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = bool
  type DataReceivedEventArgs = bool
#endif
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : string}
and Mut4 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
and [<Struct>] US4 =
    | US4_0 of f0_0 : US3
    | US4_1 of f1_0 : US3
    | US4_2 of f2_0 : US3
    | US4_3 of f3_0 : US3
    | US4_4 of f4_0 : US3
    | US4_5 of f5_0 : US3
and [<Struct>] US5 =
    | US5_0 of f0_0 : string
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : std_string_String
    | US6_1
and [<Struct>] US7 =
    | US7_0
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : string
    | US8_1 of f1_0 : string
and [<Struct>] US9 =
    | US9_0 of f0_0 : std_path_PathBuf
    | US9_1 of f1_0 : string
and [<Struct>] US10 =
    | US10_0 of f0_0 : std_path_PathBuf
    | US10_1
and Mut5 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and Mut6 = {mutable l0 : int32}
and [<Struct>] US11 =
    | US11_0 of f0_0 : std_fs_FileType
    | US11_1 of f1_0 : std_string_String
and [<Struct>] US12 =
    | US12_0
    | US12_1
    | US12_2
and [<Struct>] US13 =
    | US13_0 of f0_0 : async_walkdir_DirEntry
    | US13_1 of f1_0 : std_string_String
and [<Struct>] US14 =
    | US14_0 of f0_0 : string * f0_1 : US5
    | US14_1 of f1_0 : string
and [<Struct>] US15 =
    | US15_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US15_1 of f1_0 : string
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and UH1 =
    | UH1_0
    | UH1_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) * UH1
and [<Struct>] US16 =
    | US16_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US16_1 of f1_0 : string
and [<Struct>] US17 =
    | US17_0 of f0_0 : char
    | US17_1
and [<Struct>] US18 =
    | US18_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
    | US18_1 of f1_0 : string
and [<Struct>] US19 =
    | US19_0 of f0_0 : string * f0_1 : US5 * f0_2 : string * f0_3 : System.Text.StringBuilder * f0_4 : int32 * f0_5 : int32
    | US19_1 of f1_0 : string
and [<Struct>] US20 =
    | US20_0 of f0_0 : US17 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US20_1 of f1_0 : string
and [<Struct>] US21 =
    | US21_0 of f0_0 : US5 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US21_1 of f1_0 : string
and [<Struct>] US22 =
    | US22_0 of f0_0 : (string [])
    | US22_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of string * UH2
and [<Struct>] US23 =
    | US23_0 of f0_0 : UH2 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US23_1 of f1_0 : string
and UH3 =
    | UH3_0
    | UH3_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) * UH3
and [<Struct>] US24 =
    | US24_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US24_1 of f1_0 : std_string_String
and [<Struct>] US25 =
    | US25_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US25_1
and [<Struct>] US26 =
    | US26_0 of f0_0 : std_string_String
    | US26_1 of f1_0 : std_string_String
and [<Struct>] US27 =
    | US27_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US27_1
and [<Struct>] US28 =
    | US28_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US28_1
and [<Struct>] US29 =
    | US29_0 of f0_0 : std_process_Output
    | US29_1 of f1_0 : std_string_String
and [<Struct>] US30 =
    | US30_0 of f0_0 : int32
    | US30_1
and [<Struct>] US31 =
    | US31_0 of f0_0 : (struct (int32 * string * bool) -> Async<unit>)
    | US31_1
and [<Struct>] US32 =
    | US32_0 of f0_0 : System.Threading.CancellationToken
    | US32_1
and [<Struct>] US33 =
    | US33_0 of f0_0 : Result<string, (string * string)>
    | US33_1
and UH5 =
    | UH5_0
    | UH5_1 of string * string * (string -> (string -> US33)) * UH5
and UH4 =
    | UH4_0
    | UH4_1 of UH5 * UH4
and [<Struct>] US34 =
    | US34_0 of f0_0 : string
    | US34_1 of f1_0 : std_string_String
and [<Struct>] US35 =
    | US35_0 of f0_0 : uint64
    | US35_1 of f1_0 : std_string_String
and [<Struct>] US36 =
    | US36_0 of f0_0 : int32 * f0_1 : string
    | US36_1 of f1_0 : int32 * f1_1 : string
and Mut7 = {mutable l0 : int32; mutable l1 : int32}
and Mut8 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32}
and [<Struct>] US37 =
    | US37_0 of f0_0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>
    | US37_1 of f1_0 : std_string_String
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "source-dir"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.short($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, 's') v10 
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v14 
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v15, true) v16 
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v17) v18 
    let v20 : string = "dist-dir"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "clap::Arg::new($0)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "$0.short($1)"
    let v26 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v24, 'd') v25 
    let v27 : string = "r#\"" + v20 + "\"#"
    let v28 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "$0.long($1)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v26, v28) v29 
    let v31 : string = "$0.required($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, true) v31 
    let v33 : string = "clap::Command::arg($0, $1)"
    let v34 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v19, v32) v33 
    let v35 : string = "cache-dir"
    let v36 : string = "r#\"" + v35 + "\"#"
    let v37 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "clap::Arg::new($0)"
    let v39 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "$0.short($1)"
    let v41 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v39, 'c') v40 
    let v42 : string = "r#\"" + v35 + "\"#"
    let v43 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "$0.long($1)"
    let v45 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v41, v43) v44 
    let v46 : string = "$0.required($1)"
    let v47 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v45, true) v46 
    let v48 : string = "clap::Command::arg($0, $1)"
    let v49 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v34, v47) v48 
    let v50 : string = "hangul-spec"
    let v51 : string = "r#\"" + v50 + "\"#"
    let v52 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v51 
    let v53 : string = "clap::Arg::new($0)"
    let v54 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "$0.short($1)"
    let v56 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, 'h') v55 
    let v57 : string = "r#\"" + v50 + "\"#"
    let v58 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "$0.long($1)"
    let v60 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v56, v58) v59 
    let v61 : string = "$0.required($1)"
    let v62 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v60, true) v61 
    let v63 : string = "clap::Command::arg($0, $1)"
    let v64 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v49, v62) v63 
    v64
and closure0 () () : unit =
    let v0 : string = "true; () //"
    let v1 : bool = Fable.Core.RustInterop.emitRustExpr () v0 
    let v2 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "verify_app"
    let v4 : string = $"*/ #[test] fn " + v3 + "() { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : clap_Command = method0()
    let v7 : string = "clap::Command::debug_assert($0)"
    Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v8 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    ()
and method4 (v0 : string) : string =
    v0
and method5 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US5 =
    US5_0(v0)
and method6 () : (string -> US5) =
    closure3()
and method3 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method4(v0)
    let v7 : string = "std::env::var(&*$0)"
    let v8 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "x"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "fable_library_rust::String_::fromString($0)"
    let v14 : string = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "true; $0 })"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "_result_map_"
    let v18 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : string = method5()
    let v20 : string = "$0.unwrap_or($1)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v20 
    let _run_target_args'_v5 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US3 = US3_1
    let v23 : US4 = US4_3(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _run_target_args'_v5 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : US3 = US3_2
    let v27 : US4 = US4_3(v26)
    let v28 : string = $"env.get_environment_variable / target: {v27} / var: {v0}"
    let v29 : string = failwith<string> v28
    let _run_target_args'_v5 = v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "process.env[$0] ?? \"\""
    let v31 : string = Fable.Core.JsInterop.emitJsExpr v0 v30 
    let _run_target_args'_v5 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : string = "os"
    let v34 : IOsEnviron = Fable.Core.PyInterop.importAll v33 
    let v35 : string = "v34.environ"
    let v36 : obj = Fable.Core.PyInterop.emitPyExpr () v35 
    let v40 : string = "v36.get($0)"
    let v41 : string = Fable.Core.PyInterop.emitPyExpr v0 v40 
    let mutable _v41 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v45 : (string -> string option) = Option.ofObj
    let v46 : string option = v45 v41
    v46 
    #else
    Some v41 
    #endif
    |> fun x -> _v41 <- Some x
    let v47 : string option = match _v41 with Some x -> x | None -> failwith "optionm'.of_obj / _v41=None"
    let v52 : (string -> US5) = method6()
    let v53 : US5 option = v47 |> Option.map v52 
    let v67 : US5 = US5_1
    let v68 : US5 = v53 |> Option.defaultValue v67 
    let v75 : string =
        match v68 with
        | US5_1 -> (* None *)
            let v73 : string = ""
            v73
        | US5_0(v72) -> (* Some *)
            v72
    let _run_target_args'_v5 = v75 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : US3 = US3_1
    let v77 : US4 = US4_1(v76)
    let v78 : string = $"env.get_environment_variable / target: {v77} / var: {v0}"
    let v79 : string = failwith<string> v78
    let _run_target_args'_v5 = v79 
    #endif
#else
    let v80 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v81 : string = v80 v0
    let mutable _v81 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v83 : (string -> string option) = Option.ofObj
    let v84 : string option = v83 v81
    v84 
    #else
    Some v81 
    #endif
    |> fun x -> _v81 <- Some x
    let v85 : string option = match _v81 with Some x -> x | None -> failwith "optionm'.of_obj / _v81=None"
    let v90 : (string -> US5) = method6()
    let v91 : US5 option = v85 |> Option.map v90 
    let v105 : US5 = US5_1
    let v106 : US5 = v91 |> Option.defaultValue v105 
    let v113 : string =
        match v106 with
        | US5_1 -> (* None *)
            let v111 : string = ""
            v111
        | US5_0(v110) -> (* Some *)
            v110
    let _run_target_args'_v5 = v113 
    #endif
    let v114 : string = _run_target_args'_v5 
    v114
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
    let v2 : bool = "Verbose" = v1
    let v6 : US1 =
        if v2 then
            let v3 : US0 = US0_0
            US1_0(v3)
        else
            US1_1
    let v47 : US1 =
        match v6 with
        | US1_1 -> (* None *)
            let v9 : bool = "Debug" = v1
            let v13 : US1 =
                if v9 then
                    let v10 : US0 = US0_1
                    US1_0(v10)
                else
                    US1_1
            match v13 with
            | US1_1 -> (* None *)
                let v16 : bool = "Info" = v1
                let v20 : US1 =
                    if v16 then
                        let v17 : US0 = US0_2
                        US1_0(v17)
                    else
                        US1_1
                match v20 with
                | US1_1 -> (* None *)
                    let v23 : bool = "Warning" = v1
                    let v27 : US1 =
                        if v23 then
                            let v24 : US0 = US0_3
                            US1_0(v24)
                        else
                            US1_1
                    match v27 with
                    | US1_1 -> (* None *)
                        let v30 : bool = "Critical" = v1
                        let v34 : US1 =
                            if v30 then
                                let v31 : US0 = US0_4
                                US1_0(v31)
                            else
                                US1_1
                        match v34 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v35) -> (* Some *)
                            US1_0(v35)
                    | US1_0(v28) -> (* Some *)
                        US1_0(v28)
                | US1_0(v21) -> (* Some *)
                    US1_0(v21)
            | US1_0(v14) -> (* Some *)
                US1_0(v14)
        | US1_0(v7) -> (* Some *)
            US1_0(v7)
    let v48 : string = "AUTOMATION"
    let v49 : string = method3(v48)
    let v52 : string = "True"
    let v53 : bool = v49 <> v52 
    let v120 : US2 =
        if v53 then
            US2_1
        else
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v60 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v61 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v63 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v66 
            #endif
#if FABLE_COMPILER_PYTHON
            let v67 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v67 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v68 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v68 
            #endif
#else
            let v69 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v69 
            #endif
            let v70 : System.DateTime = _run_target_args'_v59 
            (* run_target_args'
            let v78 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v79 : (System.DateTime -> int64) = _.Ticks
            let v80 : int64 = v79 v70
            let _run_target_args'_v78 = v80 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v81 : (System.DateTime -> int64) = _.Ticks
            let v82 : int64 = v81 v70
            let _run_target_args'_v78 = v82 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v84 : int64 = null |> unbox<int64>
            let _run_target_args'_v78 = v84 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v87 : (System.DateTime -> int64) = _.Ticks
            let v88 : int64 = v87 v70
            let _run_target_args'_v78 = v88 
            #endif
#if FABLE_COMPILER_PYTHON
            let v89 : (System.DateTime -> int64) = _.Ticks
            let v90 : int64 = v89 v70
            let _run_target_args'_v78 = v90 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v91 : (System.DateTime -> int64) = _.Ticks
            let v92 : int64 = v91 v70
            let _run_target_args'_v78 = v92 
            #endif
#else
            let v93 : (System.DateTime -> int64) = _.Ticks
            let v94 : int64 = v93 v70
            let _run_target_args'_v78 = v94 
            #endif
            let v95 : int64 = _run_target_args'_v78 
            let v116 : int64 = v95 |> int64 
            US2_0(v116)
    struct (v47, v120)
and closure4 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US1, v5 : US2) = method2()
    let _run_target_args'_v3 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : US1 = US1_1
    let v7 : US2 = US2_1
    let _run_target_args'_v3 = struct (v6, v7) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "AUTOMATION"
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "String::from($0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : std_string_String = _run_target_args'_v20 
    let v49 : string = "fable_library_rust::String_::fromString($0)"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr v43 v49 
    let _run_target_args'_v13 = v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51 
    (* run_target_args'
    let v57 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = "String::from($0)"
    let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v58 
    let _run_target_args'_v57 = v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : string = "String::from($0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v60 
    let _run_target_args'_v57 = v61 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v62 : string = "String::from($0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v62 
    let _run_target_args'_v57 = v63 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v65 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v65 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v69 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v73 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v73 
    #endif
#else
    let v77 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v77 
    #endif
    let v80 : std_string_String = _run_target_args'_v57 
    let v86 : string = "fable_library_rust::String_::fromString($0)"
    let v87 : string = Fable.Core.RustInterop.emitRustExpr v80 v86 
    let _run_target_args'_v13 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v89 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v88 
    (* run_target_args'
    let v94 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v95 
    let _run_target_args'_v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v97 
    let _run_target_args'_v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v99 
    let _run_target_args'_v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v102 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v102 
    #endif
#if FABLE_COMPILER_PYTHON
    let v106 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v106 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v110 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v110 
    #endif
#else
    let v114 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v114 
    #endif
    let v117 : std_string_String = _run_target_args'_v94 
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v117 v123 
    let _run_target_args'_v13 = v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v126 : string = null |> unbox<string>
    let _run_target_args'_v13 = v126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v130 : string = null |> unbox<string>
    let _run_target_args'_v13 = v130 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v134 : string = null |> unbox<string>
    let _run_target_args'_v13 = v134 
    #endif
#else
    let v138 : string = null |> unbox<string>
    let _run_target_args'_v13 = v138 
    #endif
    let v141 : string = _run_target_args'_v13 
    let v149 : string = "True"
    let v150 : bool = v141 <> v149 
    let v162 : US2 =
        if v150 then
            US2_1
        else
            let v154 : string = $"near_sdk::env::block_timestamp()"
            let v155 : uint64 = Fable.Core.RustInterop.emitRustExpr () v154 
            let v157 : (uint64 -> int64) = int64
            let v158 : int64 = v157 v155
            US2_0(v158)
    let v163 : US1 = US1_1
    let _run_target_args'_v3 = struct (v163, v162) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v164 : US1, v165 : US2) = method2()
    let _run_target_args'_v3 = struct (v164, v165) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v166 : US1, v167 : US2) = method2()
    let _run_target_args'_v3 = struct (v166, v167) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v168 : US1, v169 : US2) = method2()
    let _run_target_args'_v3 = struct (v168, v169) 
    #endif
#else
    let struct (v170 : US1, v171 : US2) = method2()
    let _run_target_args'_v3 = struct (v170, v171) 
    #endif
    let struct (v172 : US1, v173 : US2) = _run_target_args'_v3 
    let v178 : Mut0 = {l0 = 1L} : Mut0
    let v179 : (string -> unit) = closure4()
    let v180 : Mut1 = {l0 = v179} : Mut1
    let v181 : Mut2 = {l0 = true} : Mut2
    let v182 : string = ""
    let v183 : Mut3 = {l0 = v182} : Mut3
    let v186 : US0 =
        match v172 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v184) -> (* Some *)
            v184
    let v187 : Mut4 = {l0 = v186} : Mut4
    let v195 : int64 option =
        match v173 with
        | US2_1 -> (* None *)
            let v193 : int64 option = None
            v193
        | US2_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v195)
and closure2 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_2
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and closure6 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and method7 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v24 : Mut0, v25 : Mut1, v26 : Mut2, v27 : Mut3, v28 : Mut4, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : US0 = v28.l0
    let v43 : bool = v26.l0
    let v44 : bool = v43 = false
    if v44 then
        false
    else
        let v45 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v46 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v42
        let v47 : bool = v45 >= v46
        v47
and closure7 () (v0 : int64) : US2 =
    US2_0(v0)
and method9 () : (int64 -> US2) =
    closure7()
and method10 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method11 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method8 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    (* run_target_args'
    let v167 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v170 : (int64 -> US2) = method9()
    let v171 : US2 option = v5 |> Option.map v170 
    let v185 : US2 = US2_1
    let v186 : US2 = v171 |> Option.defaultValue v185 
    let v304 : System.DateTime =
        match v186 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v287 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v288 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v288 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v289 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v289 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v291 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v287 = v291 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v294 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v294 
            #endif
#if FABLE_COMPILER_PYTHON
            let v295 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v295 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v296 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v296 
            #endif
#else
            let v297 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v297 
            #endif
            let v298 : System.DateTime = _run_target_args'_v287 
            v298
        | US2_0(v190) -> (* Some *)
            (* run_target_args'
            let v193 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v194 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v194 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v195 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v195 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v197 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v193 = v197 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v200 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v200 
            #endif
#if FABLE_COMPILER_PYTHON
            let v201 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v201 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v202 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v202 
            #endif
#else
            let v203 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v203 
            #endif
            let v204 : System.DateTime = _run_target_args'_v193 
            (* run_target_args'
            let v212 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v213 : (System.DateTime -> int64) = _.Ticks
            let v214 : int64 = v213 v204
            let _run_target_args'_v212 = v214 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v215 : (System.DateTime -> int64) = _.Ticks
            let v216 : int64 = v215 v204
            let _run_target_args'_v212 = v216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : int64 = null |> unbox<int64>
            let _run_target_args'_v212 = v218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v221 : (System.DateTime -> int64) = _.Ticks
            let v222 : int64 = v221 v204
            let _run_target_args'_v212 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v223 : (System.DateTime -> int64) = _.Ticks
            let v224 : int64 = v223 v204
            let _run_target_args'_v212 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v225 : (System.DateTime -> int64) = _.Ticks
            let v226 : int64 = v225 v204
            let _run_target_args'_v212 = v226 
            #endif
#else
            let v227 : (System.DateTime -> int64) = _.Ticks
            let v228 : int64 = v227 v204
            let _run_target_args'_v212 = v228 
            #endif
            let v229 : int64 = _run_target_args'_v212 
            let v250 : int64 = v229 |> int64 
            let v253 : int64 = v250 - v190
            let v256 : System.TimeSpan = v253 |> System.TimeSpan 
            let v262 : (System.TimeSpan -> int32) = _.Hours
            let v263 : int32 = v262 v256
            let v267 : (System.TimeSpan -> int32) = _.Minutes
            let v268 : int32 = v267 v256
            let v272 : (System.TimeSpan -> int32) = _.Seconds
            let v273 : int32 = v272 v256
            let v277 : (System.TimeSpan -> int32) = _.Milliseconds
            let v278 : int32 = v277 v256
            let v282 : System.DateTime = System.DateTime (1, 1, 1, v263, v268, v273, v278)
            v282
    let v306 : string = method10()
    let v310 : bool = v306 = ""
    let v312 : string =
        if v310 then
            let v311 : string = "M-d-y hh:mm:ss tt"
            v311
        else
            v306
    let v313 : (string -> string) = v304.ToString
    let v314 : string = v313 v312
    let _run_target_args'_v167 = v314 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v331 : (int64 -> US2) = method9()
    let v332 : US2 option = v5 |> Option.map v331 
    let v346 : US2 = US2_1
    let v347 : US2 = v332 |> Option.defaultValue v346 
    let v465 : System.DateTime =
        match v347 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v448 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v449 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v449 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v450 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v450 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v452 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v448 = v452 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v455 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v455 
            #endif
#if FABLE_COMPILER_PYTHON
            let v456 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v456 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v457 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v457 
            #endif
#else
            let v458 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v458 
            #endif
            let v459 : System.DateTime = _run_target_args'_v448 
            v459
        | US2_0(v351) -> (* Some *)
            (* run_target_args'
            let v354 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v355 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v355 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v356 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v356 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v358 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v354 = v358 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v361 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v361 
            #endif
#if FABLE_COMPILER_PYTHON
            let v362 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v362 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v363 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v363 
            #endif
#else
            let v364 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v364 
            #endif
            let v365 : System.DateTime = _run_target_args'_v354 
            (* run_target_args'
            let v373 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v374 : (System.DateTime -> int64) = _.Ticks
            let v375 : int64 = v374 v365
            let _run_target_args'_v373 = v375 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v376 : (System.DateTime -> int64) = _.Ticks
            let v377 : int64 = v376 v365
            let _run_target_args'_v373 = v377 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v379 : int64 = null |> unbox<int64>
            let _run_target_args'_v373 = v379 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v382 : (System.DateTime -> int64) = _.Ticks
            let v383 : int64 = v382 v365
            let _run_target_args'_v373 = v383 
            #endif
#if FABLE_COMPILER_PYTHON
            let v384 : (System.DateTime -> int64) = _.Ticks
            let v385 : int64 = v384 v365
            let _run_target_args'_v373 = v385 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v386 : (System.DateTime -> int64) = _.Ticks
            let v387 : int64 = v386 v365
            let _run_target_args'_v373 = v387 
            #endif
#else
            let v388 : (System.DateTime -> int64) = _.Ticks
            let v389 : int64 = v388 v365
            let _run_target_args'_v373 = v389 
            #endif
            let v390 : int64 = _run_target_args'_v373 
            let v411 : int64 = v390 |> int64 
            let v414 : int64 = v411 - v351
            let v417 : System.TimeSpan = v414 |> System.TimeSpan 
            let v423 : (System.TimeSpan -> int32) = _.Hours
            let v424 : int32 = v423 v417
            let v428 : (System.TimeSpan -> int32) = _.Minutes
            let v429 : int32 = v428 v417
            let v433 : (System.TimeSpan -> int32) = _.Seconds
            let v434 : int32 = v433 v417
            let v438 : (System.TimeSpan -> int32) = _.Milliseconds
            let v439 : int32 = v438 v417
            let v443 : System.DateTime = System.DateTime (1, 1, 1, v424, v429, v434, v439)
            v443
    let v467 : string = method10()
    let v471 : bool = v467 = ""
    let v473 : string =
        if v471 then
            let v472 : string = "M-d-y hh:mm:ss tt"
            v472
        else
            v467
    let v474 : (string -> string) = v465.ToString
    let v475 : string = v474 v473
    let _run_target_args'_v167 = v475 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v490 : string = $"near_sdk::env::block_timestamp()"
    let v491 : uint64 = Fable.Core.RustInterop.emitRustExpr () v490 
    let v494 : (int64 -> US2) = method9()
    let v495 : US2 option = v5 |> Option.map v494 
    let v509 : US2 = US2_1
    let v510 : US2 = v495 |> Option.defaultValue v509 
    let v522 : uint64 =
        match v510 with
        | US2_1 -> (* None *)
            v491
        | US2_0(v514) -> (* Some *)
            let v516 : (int64 -> uint64) = uint64
            let v517 : uint64 = v516 v514
            let v520 : uint64 = v491 - v517
            v520
    let v523 : uint64 = v522 / 1000000000UL
    let v524 : uint64 = v523 % 60UL
    let v525 : uint64 = v523 / 60UL
    let v526 : uint64 = v525 % 60UL
    let v527 : uint64 = v523 / 3600UL
    let v528 : uint64 = v527 % 24UL
    let v529 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v530 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v528, v526, v524) v529 
    let v531 : string = "fable_library_rust::String_::fromString($0)"
    let v532 : string = Fable.Core.RustInterop.emitRustExpr v530 v531 
    let _run_target_args'_v167 = v532 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v535 : (int64 -> US2) = method9()
    let v536 : US2 option = v5 |> Option.map v535 
    let v550 : US2 = US2_1
    let v551 : US2 = v536 |> Option.defaultValue v550 
    let v669 : System.DateTime =
        match v551 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v652 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v653 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v653 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v654 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v654 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v656 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v652 = v656 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v659 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v659 
            #endif
#if FABLE_COMPILER_PYTHON
            let v660 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v660 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v661 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v661 
            #endif
#else
            let v662 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v662 
            #endif
            let v663 : System.DateTime = _run_target_args'_v652 
            v663
        | US2_0(v555) -> (* Some *)
            (* run_target_args'
            let v558 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v559 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v559 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v560 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v560 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v562 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v558 = v562 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v565 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v565 
            #endif
#if FABLE_COMPILER_PYTHON
            let v566 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v566 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v567 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v567 
            #endif
#else
            let v568 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v568 
            #endif
            let v569 : System.DateTime = _run_target_args'_v558 
            (* run_target_args'
            let v577 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v578 : (System.DateTime -> int64) = _.Ticks
            let v579 : int64 = v578 v569
            let _run_target_args'_v577 = v579 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v580 : (System.DateTime -> int64) = _.Ticks
            let v581 : int64 = v580 v569
            let _run_target_args'_v577 = v581 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v583 : int64 = null |> unbox<int64>
            let _run_target_args'_v577 = v583 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v586 : (System.DateTime -> int64) = _.Ticks
            let v587 : int64 = v586 v569
            let _run_target_args'_v577 = v587 
            #endif
#if FABLE_COMPILER_PYTHON
            let v588 : (System.DateTime -> int64) = _.Ticks
            let v589 : int64 = v588 v569
            let _run_target_args'_v577 = v589 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v590 : (System.DateTime -> int64) = _.Ticks
            let v591 : int64 = v590 v569
            let _run_target_args'_v577 = v591 
            #endif
#else
            let v592 : (System.DateTime -> int64) = _.Ticks
            let v593 : int64 = v592 v569
            let _run_target_args'_v577 = v593 
            #endif
            let v594 : int64 = _run_target_args'_v577 
            let v615 : int64 = v594 |> int64 
            let v618 : int64 = v615 - v555
            let v621 : System.TimeSpan = v618 |> System.TimeSpan 
            let v627 : (System.TimeSpan -> int32) = _.Hours
            let v628 : int32 = v627 v621
            let v632 : (System.TimeSpan -> int32) = _.Minutes
            let v633 : int32 = v632 v621
            let v637 : (System.TimeSpan -> int32) = _.Seconds
            let v638 : int32 = v637 v621
            let v642 : (System.TimeSpan -> int32) = _.Milliseconds
            let v643 : int32 = v642 v621
            let v647 : System.DateTime = System.DateTime (1, 1, 1, v628, v633, v638, v643)
            v647
    let v671 : string = method11()
    let v675 : bool = v671 = ""
    let v677 : string =
        if v675 then
            let v676 : string = "M-d-y hh:mm:ss tt"
            v676
        else
            v671
    let v678 : (string -> string) = v669.ToString
    let v679 : string = v678 v677
    let _run_target_args'_v167 = v679 
    #endif
#if FABLE_COMPILER_PYTHON
    let v696 : (int64 -> US2) = method9()
    let v697 : US2 option = v5 |> Option.map v696 
    let v711 : US2 = US2_1
    let v712 : US2 = v697 |> Option.defaultValue v711 
    let v830 : System.DateTime =
        match v712 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v813 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v814 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v814 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v815 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v815 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v817 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v813 = v817 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v820 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v820 
            #endif
#if FABLE_COMPILER_PYTHON
            let v821 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v821 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v822 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v822 
            #endif
#else
            let v823 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v823 
            #endif
            let v824 : System.DateTime = _run_target_args'_v813 
            v824
        | US2_0(v716) -> (* Some *)
            (* run_target_args'
            let v719 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v720 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v720 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v721 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v721 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v723 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v719 = v723 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v726 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v726 
            #endif
#if FABLE_COMPILER_PYTHON
            let v727 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v727 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v728 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v728 
            #endif
#else
            let v729 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v729 
            #endif
            let v730 : System.DateTime = _run_target_args'_v719 
            (* run_target_args'
            let v738 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v739 : (System.DateTime -> int64) = _.Ticks
            let v740 : int64 = v739 v730
            let _run_target_args'_v738 = v740 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v741 : (System.DateTime -> int64) = _.Ticks
            let v742 : int64 = v741 v730
            let _run_target_args'_v738 = v742 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v744 : int64 = null |> unbox<int64>
            let _run_target_args'_v738 = v744 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v747 : (System.DateTime -> int64) = _.Ticks
            let v748 : int64 = v747 v730
            let _run_target_args'_v738 = v748 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : (System.DateTime -> int64) = _.Ticks
            let v750 : int64 = v749 v730
            let _run_target_args'_v738 = v750 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v751 : (System.DateTime -> int64) = _.Ticks
            let v752 : int64 = v751 v730
            let _run_target_args'_v738 = v752 
            #endif
#else
            let v753 : (System.DateTime -> int64) = _.Ticks
            let v754 : int64 = v753 v730
            let _run_target_args'_v738 = v754 
            #endif
            let v755 : int64 = _run_target_args'_v738 
            let v776 : int64 = v755 |> int64 
            let v779 : int64 = v776 - v716
            let v782 : System.TimeSpan = v779 |> System.TimeSpan 
            let v788 : (System.TimeSpan -> int32) = _.Hours
            let v789 : int32 = v788 v782
            let v793 : (System.TimeSpan -> int32) = _.Minutes
            let v794 : int32 = v793 v782
            let v798 : (System.TimeSpan -> int32) = _.Seconds
            let v799 : int32 = v798 v782
            let v803 : (System.TimeSpan -> int32) = _.Milliseconds
            let v804 : int32 = v803 v782
            let v808 : System.DateTime = System.DateTime (1, 1, 1, v789, v794, v799, v804)
            v808
    let v832 : string = method11()
    let v836 : bool = v832 = ""
    let v838 : string =
        if v836 then
            let v837 : string = "M-d-y hh:mm:ss tt"
            v837
        else
            v832
    let v839 : (string -> string) = v830.ToString
    let v840 : string = v839 v838
    let _run_target_args'_v167 = v840 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v857 : (int64 -> US2) = method9()
    let v858 : US2 option = v5 |> Option.map v857 
    let v872 : US2 = US2_1
    let v873 : US2 = v858 |> Option.defaultValue v872 
    let v991 : System.DateTime =
        match v873 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v974 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v975 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v975 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v976 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v976 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v978 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v974 = v978 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v981 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v981 
            #endif
#if FABLE_COMPILER_PYTHON
            let v982 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v982 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v983 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v983 
            #endif
#else
            let v984 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v984 
            #endif
            let v985 : System.DateTime = _run_target_args'_v974 
            v985
        | US2_0(v877) -> (* Some *)
            (* run_target_args'
            let v880 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v881 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v881 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v882 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v882 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v884 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v880 = v884 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v887 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v887 
            #endif
#if FABLE_COMPILER_PYTHON
            let v888 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v888 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v889 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v889 
            #endif
#else
            let v890 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v890 
            #endif
            let v891 : System.DateTime = _run_target_args'_v880 
            (* run_target_args'
            let v899 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v900 : (System.DateTime -> int64) = _.Ticks
            let v901 : int64 = v900 v891
            let _run_target_args'_v899 = v901 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v902 : (System.DateTime -> int64) = _.Ticks
            let v903 : int64 = v902 v891
            let _run_target_args'_v899 = v903 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v905 : int64 = null |> unbox<int64>
            let _run_target_args'_v899 = v905 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v908 : (System.DateTime -> int64) = _.Ticks
            let v909 : int64 = v908 v891
            let _run_target_args'_v899 = v909 
            #endif
#if FABLE_COMPILER_PYTHON
            let v910 : (System.DateTime -> int64) = _.Ticks
            let v911 : int64 = v910 v891
            let _run_target_args'_v899 = v911 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v912 : (System.DateTime -> int64) = _.Ticks
            let v913 : int64 = v912 v891
            let _run_target_args'_v899 = v913 
            #endif
#else
            let v914 : (System.DateTime -> int64) = _.Ticks
            let v915 : int64 = v914 v891
            let _run_target_args'_v899 = v915 
            #endif
            let v916 : int64 = _run_target_args'_v899 
            let v937 : int64 = v916 |> int64 
            let v940 : int64 = v937 - v877
            let v943 : System.TimeSpan = v940 |> System.TimeSpan 
            let v949 : (System.TimeSpan -> int32) = _.Hours
            let v950 : int32 = v949 v943
            let v954 : (System.TimeSpan -> int32) = _.Minutes
            let v955 : int32 = v954 v943
            let v959 : (System.TimeSpan -> int32) = _.Seconds
            let v960 : int32 = v959 v943
            let v964 : (System.TimeSpan -> int32) = _.Milliseconds
            let v965 : int32 = v964 v943
            let v969 : System.DateTime = System.DateTime (1, 1, 1, v950, v955, v960, v965)
            v969
    let v993 : string = method11()
    let v997 : bool = v993 = ""
    let v999 : string =
        if v997 then
            let v998 : string = "M-d-y hh:mm:ss tt"
            v998
        else
            v993
    let v1000 : (string -> string) = v991.ToString
    let v1001 : string = v1000 v999
    let _run_target_args'_v167 = v1001 
    #endif
#else
    let v1018 : (int64 -> US2) = method9()
    let v1019 : US2 option = v5 |> Option.map v1018 
    let v1033 : US2 = US2_1
    let v1034 : US2 = v1019 |> Option.defaultValue v1033 
    let v1152 : System.DateTime =
        match v1034 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1135 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1136 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1136 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1137 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1137 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1139 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1135 = v1139 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1142 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1142 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1143 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1143 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1144 
            #endif
#else
            let v1145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1145 
            #endif
            let v1146 : System.DateTime = _run_target_args'_v1135 
            v1146
        | US2_0(v1038) -> (* Some *)
            (* run_target_args'
            let v1041 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1042 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1042 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1043 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1043 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1045 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1041 = v1045 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1048 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1048 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1049 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1049 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1050 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1050 
            #endif
#else
            let v1051 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1051 
            #endif
            let v1052 : System.DateTime = _run_target_args'_v1041 
            (* run_target_args'
            let v1060 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1061 : (System.DateTime -> int64) = _.Ticks
            let v1062 : int64 = v1061 v1052
            let _run_target_args'_v1060 = v1062 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1063 : (System.DateTime -> int64) = _.Ticks
            let v1064 : int64 = v1063 v1052
            let _run_target_args'_v1060 = v1064 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1066 : int64 = null |> unbox<int64>
            let _run_target_args'_v1060 = v1066 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1069 : (System.DateTime -> int64) = _.Ticks
            let v1070 : int64 = v1069 v1052
            let _run_target_args'_v1060 = v1070 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1071 : (System.DateTime -> int64) = _.Ticks
            let v1072 : int64 = v1071 v1052
            let _run_target_args'_v1060 = v1072 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1073 : (System.DateTime -> int64) = _.Ticks
            let v1074 : int64 = v1073 v1052
            let _run_target_args'_v1060 = v1074 
            #endif
#else
            let v1075 : (System.DateTime -> int64) = _.Ticks
            let v1076 : int64 = v1075 v1052
            let _run_target_args'_v1060 = v1076 
            #endif
            let v1077 : int64 = _run_target_args'_v1060 
            let v1098 : int64 = v1077 |> int64 
            let v1101 : int64 = v1098 - v1038
            let v1104 : System.TimeSpan = v1101 |> System.TimeSpan 
            let v1110 : (System.TimeSpan -> int32) = _.Hours
            let v1111 : int32 = v1110 v1104
            let v1115 : (System.TimeSpan -> int32) = _.Minutes
            let v1116 : int32 = v1115 v1104
            let v1120 : (System.TimeSpan -> int32) = _.Seconds
            let v1121 : int32 = v1120 v1104
            let v1125 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1126 : int32 = v1125 v1104
            let v1130 : System.DateTime = System.DateTime (1, 1, 1, v1111, v1116, v1121, v1126)
            v1130
    let v1154 : string = method11()
    let v1158 : bool = v1154 = ""
    let v1160 : string =
        if v1158 then
            let v1159 : string = "M-d-y hh:mm:ss tt"
            v1159
        else
            v1154
    let v1161 : (string -> string) = v1152.ToString
    let v1162 : string = v1161 v1160
    let _run_target_args'_v167 = v1162 
    #endif
    let v1177 : string = _run_target_args'_v167 
    v1177
and method14 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method13 (v0 : char) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = $"{v0}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = v2.l0
    v12
and method15 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method12 () : string =
    
    
    
    
    
    let v1 : string = "Info"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_green"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_green"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_green"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[92m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[92m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[92m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[92m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method17 (v0 : (string [])) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "args"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v34 : string = $"%A{v0}"
    let v38 : string = $"{v34}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v2, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v47 : string = " }"
    let v48 : string = $"{v47}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure8(v2, v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v56 : string = v2.l0
    v56
and method18 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v38 : char list = []
    let v40 : char list = '/' :: v38 
    let v44 : char list = ' ' :: v40 
    let v49 : (char list -> (char [])) = List.toArray
    let v50 : (char []) = v49 v44
    let v53 : string = v8.TrimEnd v50 
    v53
and method16 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : string = method17(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure9 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method19 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v24 : Mut0, v25 : Mut1, v26 : Mut2, v27 : Mut3, v28 : Mut4, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure9(v24)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : (string -> unit) = closure10()
    (* run_target_args'
    let v48 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = v27.l0
    let v52 : bool = v51 = ""
    let v60 : string =
        if v52 then
            v0
        else
            let v53 : bool = v0 = ""
            if v53 then
                let v54 : string = v27.l0
                v54
            else
                let v55 : string = v27.l0
                let v56 : string = "\n"
                let v57 : string = v55 + v56 
                let v58 : string = v57 + v0 
                v58
    (* run_target_args'
    let v65 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v66 
    let _run_target_args'_v65 = v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : string = "&*$0"
    let v69 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v68 
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = "&*$0"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v70 
    let _run_target_args'_v65 = v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v77 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v81 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v81 
    #endif
#else
    let v85 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v85 
    #endif
    let v88 : Ref<Str> = _run_target_args'_v65 
    let v94 : string = $"$0.chars()"
    let v95 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let v96 : string = "$0"
    let v97 : _ = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : string = "$0.collect::<Vec<_>>()"
    let v99 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let v100 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v101 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v99 v100 
    let v102 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v103 : bool = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let v104 : string = "x"
    let v105 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v104 
    let v106 : string = "String::from_iter($0)"
    let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let v108 : string = "true; $0 }).collect::<Vec<_>>()"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
    let v110 : string = "_vec_map"
    let v111 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v110 
    let v112 : string = "$0.len()"
    let v113 : unativeint = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v119 : int32 = v113 |> int32 
    let v129 : string = ""
    let v130 : bool = v0 <> v129 
    let v134 : bool =
        if v130 then
            let v133 : bool = v119 <= 1
            v133
        else
            false
    if v134 then
        v27.l0 <- v60
        ()
    else
        v27.l0 <- v129
        let v135 : string = "true; $0.into_iter().for_each(|x| { //"
        let v136 : bool = Fable.Core.RustInterop.emitRustExpr v111 v135 
        let v137 : string = "x"
        let v138 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v137 
        let v139 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v140 : bool = Fable.Core.RustInterop.emitRustExpr v138 v139 
        let v141 : string = $"true"
        let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
        let v143 : string = "true; }); //"
        let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v47 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v47 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v47 v0
    #endif
#else
    v47 v0
    #endif
    // run_target_args' is_unit
    let v145 : (string -> unit) = v25.l0
    v145 v0
and closure5 (v0 : (string [])) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method12()
        let v46 : string = method16(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method20 () : string =
    let v0 : string = "source-dir"
    v0
and closure12 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method21 () : (std_string_String -> US6) =
    closure12()
and method22 () : string =
    let v0 : string = "dist-dir"
    v0
and method23 () : string =
    let v0 : string = "cache-dir"
    v0
and method24 () : string =
    let v0 : string = "hangul-spec"
    v0
and method26 () : string =
    (* run_target_args'
    let v4 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = "std::env::current_dir()"
    let v6 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5 
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.unwrap()"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.unwrap()"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.unwrap()"
    let v14 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : std_path_PathBuf = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : std_path_PathBuf = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : std_path_PathBuf = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v17 
    #endif
#else
    let v18 : std_path_PathBuf = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v18 
    #endif
    let v19 : std_path_PathBuf = _run_target_args'_v8 
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "$0.display()"
    let v28 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v27 
    let _run_target_args'_v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.display()"
    let v30 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v29 
    let _run_target_args'_v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "$0.display()"
    let v32 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v31 
    let _run_target_args'_v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : std_path_Display = v19 |> unbox<std_path_Display>
    let _run_target_args'_v26 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v38 : std_path_Display = v19 |> unbox<std_path_Display>
    let _run_target_args'_v26 = v38 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v42 : std_path_Display = v19 |> unbox<std_path_Display>
    let _run_target_args'_v26 = v42 
    #endif
#else
    let v46 : std_path_Display = v19 |> unbox<std_path_Display>
    let _run_target_args'_v26 = v46 
    #endif
    let v49 : std_path_Display = _run_target_args'_v26 
    (* run_target_args'
    let v59 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v60 : string = "format!(\"{}\", $0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v60 
    let _run_target_args'_v59 = v61 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v62 : string = "format!(\"{}\", $0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v62 
    let _run_target_args'_v59 = v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = "format!(\"{}\", $0)"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v64 
    let _run_target_args'_v59 = v65 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v59 = v67 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v59 = v71 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v75 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v59 = v75 
    #endif
#else
    let v79 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v59 = v79 
    #endif
    let v82 : std_string_String = _run_target_args'_v59 
    let v88 : string = "fable_library_rust::String_::fromString($0)"
    let v89 : string = Fable.Core.RustInterop.emitRustExpr v82 v88 
    let _run_target_args'_v4 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = null |> unbox<string>
    let _run_target_args'_v4 = v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = null |> unbox<string>
    let _run_target_args'_v4 = v95 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : string = "fs"
    let v99 : IFs = Fable.Core.JsInterop.importAll v98 
    let v100 : string = "fs.realpathSync('.')"
    let v101 : string = Fable.Core.JsInterop.emitJsExpr () v100 
    let _run_target_args'_v4 = v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v103 : string = null |> unbox<string>
    let _run_target_args'_v4 = v103 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v107 : string = null |> unbox<string>
    let _run_target_args'_v4 = v107 
    #endif
#else
    let v110 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v111 : string = v110 ()
    let _run_target_args'_v4 = v111 
    #endif
    let v112 : string = _run_target_args'_v4 
    v112
and method28 (v0 : string, v1 : string) : string =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v12 
    let _run_target_args'_v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v14 
    let _run_target_args'_v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "&*$0"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v16 
    let _run_target_args'_v11 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v27 
    #endif
#else
    let v31 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v31 
    #endif
    let v34 : Ref<Str> = _run_target_args'_v11 
    (* run_target_args'
    let v44 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v45 
    let _run_target_args'_v44 = v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v47 
    let _run_target_args'_v44 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v49 
    let _run_target_args'_v44 = v50 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v56 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v56 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v60 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v60 
    #endif
#else
    let v64 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v64 
    #endif
    let v67 : std_string_String = _run_target_args'_v44 
    (* run_target_args'
    let v77 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v78 : string = "std::path::PathBuf::from($0)"
    let v79 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v78 
    let _run_target_args'_v77 = v79 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v80 : string = "std::path::PathBuf::from($0)"
    let v81 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v80 
    let _run_target_args'_v77 = v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : string = "std::path::PathBuf::from($0)"
    let v83 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v82 
    let _run_target_args'_v77 = v83 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v93 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v93 
    #endif
#else
    let v97 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v97 
    #endif
    let v100 : std_path_PathBuf = _run_target_args'_v77 
    (* run_target_args'
    let v110 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = "&*$0"
    let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v111 
    let _run_target_args'_v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : string = "&*$0"
    let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v113 
    let _run_target_args'_v110 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : string = "&*$0"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v115 
    let _run_target_args'_v110 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v110 = v118 
    #endif
#if FABLE_COMPILER_PYTHON
    let v122 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v110 = v122 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v126 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v110 = v126 
    #endif
#else
    let v130 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _run_target_args'_v110 = v130 
    #endif
    let v133 : Ref<Str> = _run_target_args'_v110 
    (* run_target_args'
    let v143 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : string = "String::from($0)"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v144 
    let _run_target_args'_v143 = v145 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v146 : string = "String::from($0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v146 
    let _run_target_args'_v143 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v148 : string = "String::from($0)"
    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v148 
    let _run_target_args'_v143 = v149 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : std_string_String = v133 |> unbox<std_string_String>
    let _run_target_args'_v143 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v155 : std_string_String = v133 |> unbox<std_string_String>
    let _run_target_args'_v143 = v155 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v159 : std_string_String = v133 |> unbox<std_string_String>
    let _run_target_args'_v143 = v159 
    #endif
#else
    let v163 : std_string_String = v133 |> unbox<std_string_String>
    let _run_target_args'_v143 = v163 
    #endif
    let v166 : std_string_String = _run_target_args'_v143 
    let v172 : string = "$0.join($1)"
    let v173 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v100, v166) v172 
    (* run_target_args'
    let v178 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v179 : string = "$0.display()"
    let v180 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v173 v179 
    let _run_target_args'_v178 = v180 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v181 : string = "$0.display()"
    let v182 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v173 v181 
    let _run_target_args'_v178 = v182 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v183 : string = "$0.display()"
    let v184 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v173 v183 
    let _run_target_args'_v178 = v184 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v186 : std_path_Display = v173 |> unbox<std_path_Display>
    let _run_target_args'_v178 = v186 
    #endif
#if FABLE_COMPILER_PYTHON
    let v190 : std_path_Display = v173 |> unbox<std_path_Display>
    let _run_target_args'_v178 = v190 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v194 : std_path_Display = v173 |> unbox<std_path_Display>
    let _run_target_args'_v178 = v194 
    #endif
#else
    let v198 : std_path_Display = v173 |> unbox<std_path_Display>
    let _run_target_args'_v178 = v198 
    #endif
    let v201 : std_path_Display = _run_target_args'_v178 
    (* run_target_args'
    let v211 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v212 : string = "format!(\"{}\", $0)"
    let v213 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v212 
    let _run_target_args'_v211 = v213 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v214 : string = "format!(\"{}\", $0)"
    let v215 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v214 
    let _run_target_args'_v211 = v215 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v216 : string = "format!(\"{}\", $0)"
    let v217 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v216 
    let _run_target_args'_v211 = v217 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v219 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v211 = v219 
    #endif
#if FABLE_COMPILER_PYTHON
    let v223 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v211 = v223 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v227 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v211 = v227 
    #endif
#else
    let v231 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v211 = v231 
    #endif
    let v234 : std_string_String = _run_target_args'_v211 
    let v240 : string = "fable_library_rust::String_::fromString($0)"
    let v241 : string = Fable.Core.RustInterop.emitRustExpr v234 v240 
    let _run_target_args'_v6 = v241 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v242 : US3 = US3_1
    let v243 : US4 = US4_3(v242)
    let v244 : string = $"file_system.(</>) / target: {v243} / a: {v0} / b: {v1}"
    let v245 : string = failwith<string> v244
    let _run_target_args'_v6 = v245 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v247 : string = null |> unbox<string>
    let _run_target_args'_v6 = v247 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v250 : string = "path"
    let v251 : IPathJoin = Fable.Core.JsInterop.importAll v250 
    let v252 : string = "v251.join($0, $1)"
    let v253 : string = Fable.Core.JsInterop.emitJsExpr struct (v0, v1) v252 
    let _run_target_args'_v6 = v253 
    #endif
#if FABLE_COMPILER_PYTHON
    let v254 : US3 = US3_0
    let v255 : US4 = US4_5(v254)
    let v256 : string = $"file_system.(</>) / target: {v255} / a: {v0} / b: {v1}"
    let v257 : string = failwith<string> v256
    let _run_target_args'_v6 = v257 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v258 : US3 = US3_1
    let v259 : US4 = US4_1(v258)
    let v260 : string = $"file_system.(</>) / target: {v259} / a: {v0} / b: {v1}"
    let v261 : string = failwith<string> v260
    let _run_target_args'_v6 = v261 
    #endif
#else
    let v262 : string = System.IO.Path.Combine (v0, v1)
    let _run_target_args'_v6 = v262 
    #endif
    let v263 : string = _run_target_args'_v6 
    v263
and method30 (v0 : string) : bool =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
#else
    let v30 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v30 
    #endif
    let v33 : Ref<Str> = _run_target_args'_v10 
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v44 
    let _run_target_args'_v43 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v48 
    let _run_target_args'_v43 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v59 
    #endif
#else
    let v63 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v63 
    #endif
    let v66 : std_string_String = _run_target_args'_v43 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "std::path::PathBuf::from($0)"
    let v78 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "std::path::PathBuf::from($0)"
    let v80 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "std::path::PathBuf::from($0)"
    let v82 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : std_path_PathBuf = _run_target_args'_v76 
    let v105 : string = "$0.exists()"
    let v106 : bool = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v109 : bool =
        if v106 then
            let v107 : string = "$0.is_file()"
            let v108 : bool = Fable.Core.RustInterop.emitRustExpr v99 v107 
            v108
        else
            false
    let _run_target_args'_v5 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v111 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v115 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : string = "fs"
    let v119 : IFsExistsSync = Fable.Core.JsInterop.importAll v118 
    let v120 : string = "$0.existsSync($1)"
    let v121 : bool = Fable.Core.JsInterop.emitJsExpr struct (v119, v0) v120 
    let _run_target_args'_v5 = v121 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v127 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v127 
    #endif
#else
    let v130 : (string -> bool) = System.IO.File.Exists
    let v131 : bool = v130 v0
    let _run_target_args'_v5 = v131 
    #endif
    let v132 : bool = _run_target_args'_v5 
    v132
and closure13 () (v0 : string) : bool =
    method30(v0)
and method31 (v0 : string) : bool =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
#else
    let v30 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v30 
    #endif
    let v33 : Ref<Str> = _run_target_args'_v10 
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v44 
    let _run_target_args'_v43 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v48 
    let _run_target_args'_v43 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v59 
    #endif
#else
    let v63 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v63 
    #endif
    let v66 : std_string_String = _run_target_args'_v43 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "std::path::PathBuf::from($0)"
    let v78 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "std::path::PathBuf::from($0)"
    let v80 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "std::path::PathBuf::from($0)"
    let v82 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : std_path_PathBuf = _run_target_args'_v76 
    let v105 : string = "$0.exists()"
    let v106 : bool = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v109 : bool =
        if v106 then
            let v107 : string = "$0.is_dir()"
            let v108 : bool = Fable.Core.RustInterop.emitRustExpr v99 v107 
            v108
        else
            false
    let _run_target_args'_v5 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v111 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v115 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : string = "fs"
    let v119 : IFsExistsSync = Fable.Core.JsInterop.importAll v118 
    let v120 : string = "$0.existsSync($1)"
    let v121 : bool = Fable.Core.JsInterop.emitJsExpr struct (v119, v0) v120 
    let _run_target_args'_v5 = v121 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v127 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v127 
    #endif
#else
    let v130 : (string -> bool) = System.IO.Directory.Exists
    let v131 : bool = v130 v0
    let _run_target_args'_v5 = v131 
    #endif
    let v132 : bool = _run_target_args'_v5 
    v132
and closure14 () (v0 : string) : bool =
    method31(v0)
and method33 (v0 : string) : string option =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "&*$0"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v12 
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v7 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v7 = v19 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v7 = v23 
    #endif
#else
    let v27 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v7 = v27 
    #endif
    let v30 : Ref<Str> = _run_target_args'_v7 
    (* run_target_args'
    let v40 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v41 
    let _run_target_args'_v40 = v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = "String::from($0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v43 
    let _run_target_args'_v40 = v44 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v45 
    let _run_target_args'_v40 = v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v48 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v40 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v40 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v56 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v40 = v56 
    #endif
#else
    let v60 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v40 = v60 
    #endif
    let v63 : std_string_String = _run_target_args'_v40 
    (* run_target_args'
    let v73 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : string = "std::path::PathBuf::from($0)"
    let v75 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v63 v74 
    let _run_target_args'_v73 = v75 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v76 : string = "std::path::PathBuf::from($0)"
    let v77 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v63 v76 
    let _run_target_args'_v73 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "std::path::PathBuf::from($0)"
    let v79 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v63 v78 
    let _run_target_args'_v73 = v79 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : std_path_PathBuf = v63 |> unbox<std_path_PathBuf>
    let _run_target_args'_v73 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v85 : std_path_PathBuf = v63 |> unbox<std_path_PathBuf>
    let _run_target_args'_v73 = v85 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v89 : std_path_PathBuf = v63 |> unbox<std_path_PathBuf>
    let _run_target_args'_v73 = v89 
    #endif
#else
    let v93 : std_path_PathBuf = v63 |> unbox<std_path_PathBuf>
    let _run_target_args'_v73 = v93 
    #endif
    let v96 : std_path_PathBuf = _run_target_args'_v73 
    let v102 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v103 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v96 v102 
    let v104 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v105 : bool = Fable.Core.RustInterop.emitRustExpr v103 v104 
    let v106 : string = "x"
    let v107 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v106 
    (* run_target_args'
    let v112 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v113 : string = "$0.display()"
    let v114 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v107 v113 
    let _run_target_args'_v112 = v114 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v115 : string = "$0.display()"
    let v116 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v107 v115 
    let _run_target_args'_v112 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v117 : string = "$0.display()"
    let v118 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v107 v117 
    let _run_target_args'_v112 = v118 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v120 : std_path_Display = v107 |> unbox<std_path_Display>
    let _run_target_args'_v112 = v120 
    #endif
#if FABLE_COMPILER_PYTHON
    let v124 : std_path_Display = v107 |> unbox<std_path_Display>
    let _run_target_args'_v112 = v124 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v128 : std_path_Display = v107 |> unbox<std_path_Display>
    let _run_target_args'_v112 = v128 
    #endif
#else
    let v132 : std_path_Display = v107 |> unbox<std_path_Display>
    let _run_target_args'_v112 = v132 
    #endif
    let v135 : std_path_Display = _run_target_args'_v112 
    (* run_target_args'
    let v145 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v146 : string = "format!(\"{}\", $0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v135 v146 
    let _run_target_args'_v145 = v147 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v148 : string = "format!(\"{}\", $0)"
    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v135 v148 
    let _run_target_args'_v145 = v149 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v150 : string = "format!(\"{}\", $0)"
    let v151 : std_string_String = Fable.Core.RustInterop.emitRustExpr v135 v150 
    let _run_target_args'_v145 = v151 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v145 = v153 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v145 = v157 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v161 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v145 = v161 
    #endif
#else
    let v165 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v145 = v165 
    #endif
    let v168 : std_string_String = _run_target_args'_v145 
    let v174 : string = "fable_library_rust::String_::fromString($0)"
    let v175 : string = Fable.Core.RustInterop.emitRustExpr v168 v174 
    let v176 : string = "true; $0 })"
    let v177 : bool = Fable.Core.RustInterop.emitRustExpr v175 v176 
    let v178 : string = "_optionm_map_"
    let v179 : string option = Fable.Core.RustInterop.emitRustExpr () v178 
    let _run_target_args'_v2 = v179 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v180 : string option = None
    let _run_target_args'_v2 = v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : string option = None
    let _run_target_args'_v2 = v181 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v182 : string = "path"
    let v183 : IPathDirname = Fable.Core.JsInterop.importAll v182 
    let v184 : string = "v183.dirname($0)"
    let v185 : string = Fable.Core.JsInterop.emitJsExpr v0 v184 
    let v186 : bool = v185 = v0
    let v189 : US5 =
        if v186 then
            US5_1
        else
            US5_0(v185)
    let v197 : string option =
        match v189 with
        | US5_1 -> (* None *)
            let v195 : string option = None
            v195
        | US5_0(v190) -> (* Some *)
            let v192 : string option = Some v190 
            v192
    let _run_target_args'_v2 = v197 
    #endif
#if FABLE_COMPILER_PYTHON
    let v198 : string option = None
    let _run_target_args'_v2 = v198 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v199 : string option = None
    let _run_target_args'_v2 = v199 
    #endif
#else
    let v200 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.GetParent
    let v201 : System_IO_DirectoryInfo = v200 v0
    let v203 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let v207 : bool = v201 = v203 
    let v249 : US5 =
        if v207 then
            US5_1
        else
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v217 : string = null |> unbox<string>
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v221 : string = null |> unbox<string>
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v225 : string = null |> unbox<string>
            let _run_target_args'_v215 = v225 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v229 : string = null |> unbox<string>
            let _run_target_args'_v215 = v229 
            #endif
#if FABLE_COMPILER_PYTHON
            let v233 : string = null |> unbox<string>
            let _run_target_args'_v215 = v233 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v237 : string = null |> unbox<string>
            let _run_target_args'_v215 = v237 
            #endif
#else
            let v240 : (System_IO_DirectoryInfo -> string) = _.FullName
            let v241 : string = v240 v201
            let _run_target_args'_v215 = v241 
            #endif
            let v242 : string = _run_target_args'_v215 
            US5_0(v242)
    let v257 : string option =
        match v249 with
        | US5_1 -> (* None *)
            let v255 : string option = None
            v255
        | US5_0(v250) -> (* Some *)
            let v252 : string option = Some v250 
            v252
    let _run_target_args'_v2 = v257 
    #endif
    let v258 : string option = _run_target_args'_v2 
    v258
and method34 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool), v4 : string) : US8 =
    let v5 : string = method28(v4, v0)
    let v6 : bool = v3 v5
    if v6 then
        US8_0(v4)
    else
        let v8 : string option = method33(v4)
        let v11 : (string -> US5) = method6()
        let v12 : US5 option = v8 |> Option.map v11 
        let v26 : US5 = US5_1
        let v27 : US5 = v12 |> Option.defaultValue v26 
        match v27 with
        | US5_1 -> (* None *)
            let v33 : string = $"""file_system.find_parent / No parent for {if v2 then "file" else "dir"}"""
            let v34 : string = $" '{v0}' at '{v1}' (until '{v4}')"
            let v35 : string = v33 + v34 
            US8_1(v35)
        | US5_0(v31) -> (* Some *)
            method34(v0, v1, v2, v3, v31)
and method32 (v0 : string, v1 : string, v2 : bool, v3 : (string -> bool)) : US8 =
    let v4 : string = method28(v1, v0)
    let v5 : bool = v3 v4
    if v5 then
        US8_0(v1)
    else
        let v7 : string option = method33(v1)
        let v10 : (string -> US5) = method6()
        let v11 : US5 option = v7 |> Option.map v10 
        let v25 : US5 = US5_1
        let v26 : US5 = v11 |> Option.defaultValue v25 
        match v26 with
        | US5_1 -> (* None *)
            let v32 : string = $"""file_system.find_parent / No parent for {if v2 then "file" else "dir"}"""
            let v33 : string = $" '{v0}' at '{v1}' (until '{v1}')"
            let v34 : string = v32 + v33 
            US8_1(v34)
        | US5_0(v30) -> (* Some *)
            method34(v0, v1, v2, v3, v30)
and method29 (v0 : US7, v1 : string, v2 : string) : US8 =
    let v3 : bool =
        match v0 with
        | US7_0 -> (* File *)
            true
        | _ ->
            false
    let v6 : (string -> bool) =
        if v3 then
            closure13()
        else
            closure14()
    method32(v1, v2, v3, v6)
and method35 () : string =
    
    
    
    
    
    let v1 : string = "Warning"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_yellow"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_yellow"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_yellow"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[93m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[93m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[93m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[93m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method37 (v0 : string, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "dir"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "error"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method37(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "file_system.get_workspace_root"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure15 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_3
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method35()
        let v47 : string = method36(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method19(v47)
and method42 (v0 : std_io_Error) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "format!(\"{:#?}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = "format!(\"{:#?}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v12 
    let v14 : string = "fable_library_rust::String_::fromString($0)"
    let v15 : string = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let _run_target_args'_v7 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "format!(\"{:#?}\", $0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v16 
    let v18 : string = "fable_library_rust::String_::fromString($0)"
    let v19 : string = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let _run_target_args'_v7 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : string = $"%A{v0}"
    let _run_target_args'_v7 = v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : string = $"%A{v0}"
    let _run_target_args'_v7 = v25 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v29 : string = $"%A{v0}"
    let _run_target_args'_v7 = v29 
    #endif
#else
    let v33 : string = $"%A{v0}"
    let _run_target_args'_v7 = v33 
    #endif
    let v36 : string = _run_target_args'_v7 
    let v43 : string = $"{v36}"
    let v46 : unit = ()
    let v47 : (unit -> unit) = closure8(v2, v43)
    let v48 : unit = (fun () -> v47 (); v46) ()
    let v51 : string = v2.l0
    v51
and closure16 () (v0 : std_io_Error) : string =
    method42(v0)
and method41 () : (std_io_Error -> string) =
    closure16()
and closure17 () (v0 : std_path_PathBuf) : US9 =
    US9_0(v0)
and method43 () : (std_path_PathBuf -> US9) =
    closure17()
and closure18 () (v0 : string) : US9 =
    US9_1(v0)
and method44 () : (string -> US9) =
    closure18()
and method47 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
#else
    let v30 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v30 
    #endif
    let v33 : Ref<Str> = _run_target_args'_v10 
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v44 
    let _run_target_args'_v43 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v48 
    let _run_target_args'_v43 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v59 
    #endif
#else
    let v63 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v63 
    #endif
    let v66 : std_string_String = _run_target_args'_v43 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "std::path::PathBuf::from($0)"
    let v78 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "std::path::PathBuf::from($0)"
    let v80 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "std::path::PathBuf::from($0)"
    let v82 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : std_path_PathBuf = _run_target_args'_v76 
    let v105 : string = "$0.file_name()"
    let v106 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v107 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v108 : bool = Fable.Core.RustInterop.emitRustExpr v106 v107 
    let v109 : string = "x"
    let v110 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr () v109 
    let v111 : string = "$0.to_os_string()"
    let v112 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v110 v111 
    let v113 : string = "$0.to_str()"
    let v114 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v112 v113 
    let v115 : string = "$0.unwrap()"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v114 v115 
    (* run_target_args'
    let v121 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v122 : string = "String::from($0)"
    let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v122 
    let _run_target_args'_v121 = v123 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v124 : string = "String::from($0)"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v124 
    let _run_target_args'_v121 = v125 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v126 : string = "String::from($0)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v126 
    let _run_target_args'_v121 = v127 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v129 : std_string_String = v116 |> unbox<std_string_String>
    let _run_target_args'_v121 = v129 
    #endif
#if FABLE_COMPILER_PYTHON
    let v133 : std_string_String = v116 |> unbox<std_string_String>
    let _run_target_args'_v121 = v133 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v137 : std_string_String = v116 |> unbox<std_string_String>
    let _run_target_args'_v121 = v137 
    #endif
#else
    let v141 : std_string_String = v116 |> unbox<std_string_String>
    let _run_target_args'_v121 = v141 
    #endif
    let v144 : std_string_String = _run_target_args'_v121 
    let v150 : string = "fable_library_rust::String_::fromString($0)"
    let v151 : string = Fable.Core.RustInterop.emitRustExpr v144 v150 
    let v152 : string = "true; $0 })"
    let v153 : bool = Fable.Core.RustInterop.emitRustExpr v151 v152 
    let v154 : string = "_optionm_map_"
    let v155 : string option = Fable.Core.RustInterop.emitRustExpr () v154 
    let v158 : (string -> US5) = method6()
    let v159 : US5 option = v155 |> Option.map v158 
    let v173 : US5 = US5_1
    let v174 : US5 = v159 |> Option.defaultValue v173 
    let v181 : string =
        match v174 with
        | US5_1 -> (* None *)
            let v179 : string = ""
            v179
        | US5_0(v178) -> (* Some *)
            v178
    let _run_target_args'_v5 = v181 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v182 : US3 = US3_1
    let v183 : US4 = US4_3(v182)
    let v184 : string = $"file_system.get_file_name / target: {v183} / path: {v0}"
    let v185 : string = failwith<string> v184
    let _run_target_args'_v5 = v185 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v187 : string = null |> unbox<string>
    let _run_target_args'_v5 = v187 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v190 : string = "path"
    let v191 : IPathBasename = Fable.Core.JsInterop.importAll v190 
    let v192 : string = "v191.basename($0)"
    let v193 : string = Fable.Core.JsInterop.emitJsExpr v0 v192 
    let _run_target_args'_v5 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v194 : US3 = US3_0
    let v195 : US4 = US4_5(v194)
    let v196 : string = $"file_system.get_file_name / target: {v195} / path: {v0}"
    let v197 : string = failwith<string> v196
    let _run_target_args'_v5 = v197 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v198 : US3 = US3_1
    let v199 : US4 = US4_1(v198)
    let v200 : string = $"file_system.get_file_name / target: {v199} / path: {v0}"
    let v201 : string = failwith<string> v200
    let _run_target_args'_v5 = v201 
    #endif
#else
    let v202 : (string -> string) = System.IO.Path.GetFileName
    let v203 : string = v202 v0
    let _run_target_args'_v5 = v203 
    #endif
    let v204 : string = _run_target_args'_v5 
    v204
and method48 (v0 : string) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = $"{v0}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = v2.l0
    v12
and method46 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method47(v4)
    let v6 : string option = method33(v4)
    let v9 : (string -> US5) = method6()
    let v10 : US5 option = v6 |> Option.map v9 
    let v24 : US5 = US5_1
    let v25 : US5 = v10 |> Option.defaultValue v24 
    let v29 : string = method48(v3)
    let v30 : bool = v2 >= 11uy
    if v30 then
        let v31 : string = $"file_system.read_link / "
        let v32 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v33 : string = v31 + v32 
        (* run_target_args'
        let v38 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v39 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v40 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v39 
        let _run_target_args'_v38 = v40 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v41 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v42 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v41 
        let _run_target_args'_v38 = v42 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v43 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v44 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v43 
        let _run_target_args'_v38 = v44 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v46 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v46 
        #endif
#if FABLE_COMPILER_PYTHON
        let v50 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v50 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v54 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v54 
        #endif
#else
        let v58 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v58 
        #endif
        let v61 : std_io_Error = _run_target_args'_v38 
        (* run_target_args'
        let v68 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v69 : string = "Err($0)"
        let v70 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v69 
        let _run_target_args'_v68 = v70 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v71 : string = "Err($0)"
        let v72 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v71 
        let _run_target_args'_v68 = v72 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v73 : string = "Err($0)"
        let v74 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v73 
        let _run_target_args'_v68 = v74 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v75 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v75 
        #endif
#if FABLE_COMPILER_PYTHON
        let v76 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v76 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v77 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v77 
        #endif
#else
        let v78 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v78 
        #endif
        let v79 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v68 
        v79
    else
        match v25 with
        | US5_0(v82) -> (* Some *)
            let v85 : string = ""
            let v86 : bool = v4 <> v85 
            if v86 then
                let v89 : uint8 = v2 + 1uy
                let v90 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v89
                let v91 : Result<std_path_PathBuf, std_io_Error> = v90 v82
                let v92 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v94 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v95 : string = "$0.map_err(|x| $1(x))"
                let v96 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v95 
                let _run_target_args'_v94 = v96 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v97 : string = "$0.map_err(|x| $1(x))"
                let v98 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v97 
                let _run_target_args'_v94 = v98 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v99 : string = "$0.map_err(|x| $1(x))"
                let v100 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v99 
                let _run_target_args'_v94 = v100 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v101 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v101 
                #endif
#if FABLE_COMPILER_PYTHON
                let v102 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v102 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v103 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v103 
                #endif
#else
                let v104 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v104 
                #endif
                let v105 : Result<std_path_PathBuf, string> = _run_target_args'_v94 
                let v108 : (std_path_PathBuf -> US9) = method43()
                let v109 : (string -> US9) = method44()
                let v111 : US9 = match v105 with Ok x -> v108 x | Error x -> v109 x
                match v111 with
                | US9_1(v267) -> (* Error *)
                    let v268 : string = $"file_system.read_link / "
                    let v269 : string = $"error': {v267} / error: {v29} / name: {v5}"
                    let v270 : string = v268 + v269 
                    (* run_target_args'
                    let v275 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v276 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v277 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v276 
                    let _run_target_args'_v275 = v277 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v278 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v279 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v278 
                    let _run_target_args'_v275 = v279 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v280 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v281 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v280 
                    let _run_target_args'_v275 = v281 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v283 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v283 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v287 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v287 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v291 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v291 
                    #endif
#else
                    let v295 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v295 
                    #endif
                    let v298 : std_io_Error = _run_target_args'_v275 
                    (* run_target_args'
                    let v305 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v306 : string = "Err($0)"
                    let v307 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v306 
                    let _run_target_args'_v305 = v307 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v308 : string = "Err($0)"
                    let v309 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v308 
                    let _run_target_args'_v305 = v309 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v310 : string = "Err($0)"
                    let v311 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v310 
                    let _run_target_args'_v305 = v311 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v312 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v312 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v313 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v313 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v314 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v314 
                    #endif
#else
                    let v315 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v315 
                    #endif
                    let v316 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v305 
                    v316
                | US9_0(v114) -> (* Ok *)
                    (* run_target_args'
                    let v119 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v120 : string = "$0.display()"
                    let v121 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v120 
                    let _run_target_args'_v119 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v122 : string = "$0.display()"
                    let v123 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v122 
                    let _run_target_args'_v119 = v123 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v124 : string = "$0.display()"
                    let v125 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v124 
                    let _run_target_args'_v119 = v125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v127 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v131 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v131 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v135 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v135 
                    #endif
#else
                    let v139 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v139 
                    #endif
                    let v142 : std_path_Display = _run_target_args'_v119 
                    let v149 : string = v142 |> string 
                    let v152 : string = method28(v149, v5)
                    (* run_target_args'
                    let v157 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v158 : string = "&*$0"
                    let v159 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v158 
                    let _run_target_args'_v157 = v159 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v160 : string = "&*$0"
                    let v161 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v160 
                    let _run_target_args'_v157 = v161 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v162 : string = "&*$0"
                    let v163 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v162 
                    let _run_target_args'_v157 = v163 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v165 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v165 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v169 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v169 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v173 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v173 
                    #endif
#else
                    let v177 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v177 
                    #endif
                    let v180 : Ref<Str> = _run_target_args'_v157 
                    (* run_target_args'
                    let v190 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v191 : string = "String::from($0)"
                    let v192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v191 
                    let _run_target_args'_v190 = v192 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v193 : string = "String::from($0)"
                    let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v193 
                    let _run_target_args'_v190 = v194 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v195 : string = "String::from($0)"
                    let v196 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v195 
                    let _run_target_args'_v190 = v196 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v198 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v198 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v202 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v202 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v206 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v206 
                    #endif
#else
                    let v210 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v210 
                    #endif
                    let v213 : std_string_String = _run_target_args'_v190 
                    (* run_target_args'
                    let v223 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v224 : string = "std::path::PathBuf::from($0)"
                    let v225 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v224 
                    let _run_target_args'_v223 = v225 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v226 : string = "std::path::PathBuf::from($0)"
                    let v227 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v226 
                    let _run_target_args'_v223 = v227 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v228 : string = "std::path::PathBuf::from($0)"
                    let v229 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v228 
                    let _run_target_args'_v223 = v229 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v231 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v231 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v235 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v235 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v239 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v239 
                    #endif
#else
                    let v243 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v243 
                    #endif
                    let v246 : std_path_PathBuf = _run_target_args'_v223 
                    (* run_target_args'
                    let v253 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v254 : string = "Ok($0)"
                    let v255 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v254 
                    let _run_target_args'_v253 = v255 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v256 : string = "Ok($0)"
                    let v257 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v256 
                    let _run_target_args'_v253 = v257 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v258 : string = "Ok($0)"
                    let v259 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v258 
                    let _run_target_args'_v253 = v259 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v260 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v260 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v261 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v261 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v262 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v262 
                    #endif
#else
                    let v263 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v263 
                    #endif
                    let v264 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v253 
                    v264
            else
                let v321 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v322 : string = $"path: {v0} / error: {v29} / path': {v4} / name: {v5}"
                let v323 : string = v321 + v322 
                (* run_target_args'
                let v328 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v329 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v330 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v329 
                let _run_target_args'_v328 = v330 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v331 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v332 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v331 
                let _run_target_args'_v328 = v332 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v333 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v334 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v333 
                let _run_target_args'_v328 = v334 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v336 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v336 
                #endif
#if FABLE_COMPILER_PYTHON
                let v340 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v340 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v344 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v344 
                #endif
#else
                let v348 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v348 
                #endif
                let v351 : std_io_Error = _run_target_args'_v328 
                (* run_target_args'
                let v358 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v359 : string = "Err($0)"
                let v360 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v359 
                let _run_target_args'_v358 = v360 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v361 : string = "Err($0)"
                let v362 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v361 
                let _run_target_args'_v358 = v362 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v363 : string = "Err($0)"
                let v364 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v363 
                let _run_target_args'_v358 = v364 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v365 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v365 
                #endif
#if FABLE_COMPILER_PYTHON
                let v366 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v366 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v367 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v367 
                #endif
#else
                let v368 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v368 
                #endif
                let v369 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v358 
                v369
        | _ ->
            let v373 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v374 : string = $"path: {v0} / error: {v29} / path': {v4} / name: {v5}"
            let v375 : string = v373 + v374 
            (* run_target_args'
            let v380 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v381 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v382 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v381 
            let _run_target_args'_v380 = v382 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v383 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v384 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v383 
            let _run_target_args'_v380 = v384 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v385 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v386 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v385 
            let _run_target_args'_v380 = v386 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v388 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v388 
            #endif
#if FABLE_COMPILER_PYTHON
            let v392 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v392 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v396 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v396 
            #endif
#else
            let v400 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v400 
            #endif
            let v403 : std_io_Error = _run_target_args'_v380 
            (* run_target_args'
            let v410 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v411 : string = "Err($0)"
            let v412 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v411 
            let _run_target_args'_v410 = v412 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v413 : string = "Err($0)"
            let v414 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v413 
            let _run_target_args'_v410 = v414 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v415 : string = "Err($0)"
            let v416 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v415 
            let _run_target_args'_v410 = v416 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v417 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v417 
            #endif
#if FABLE_COMPILER_PYTHON
            let v418 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v418 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v419 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v419 
            #endif
#else
            let v420 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v420 
            #endif
            let v421 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v410 
            v421
and method45 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "std::fs::read_link(&*$0)"
    let v9 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v8 
    let v10 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "$0.map_err(|x| $1(x))"
    let v14 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v13 
    let _run_target_args'_v12 = v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = "$0.map_err(|x| $1(x))"
    let v16 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v15 
    let _run_target_args'_v12 = v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : string = "$0.map_err(|x| $1(x))"
    let v18 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v17 
    let _run_target_args'_v12 = v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Result<std_path_PathBuf, string> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _run_target_args'_v12 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Result<std_path_PathBuf, string> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _run_target_args'_v12 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : Result<std_path_PathBuf, string> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _run_target_args'_v12 = v21 
    #endif
#else
    let v22 : Result<std_path_PathBuf, string> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _run_target_args'_v12 = v22 
    #endif
    let v23 : Result<std_path_PathBuf, string> = _run_target_args'_v12 
    let v26 : (std_path_PathBuf -> US9) = method43()
    let v27 : (string -> US9) = method44()
    let v29 : US9 = match v23 with Ok x -> v26 x | Error x -> v27 x
    let v52 : Result<std_path_PathBuf, std_io_Error> =
        match v29 with
        | US9_1(v48) -> (* Error *)
            let v49 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v49, v1, v48, v2)
        | US9_0(v32) -> (* Ok *)
            (* run_target_args'
            let v34 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v35 : string = "Ok($0)"
            let v36 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v32 v35 
            let _run_target_args'_v34 = v36 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v37 : string = "Ok($0)"
            let v38 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v32 v37 
            let _run_target_args'_v34 = v38 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v39 : string = "Ok($0)"
            let v40 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v32 v39 
            let _run_target_args'_v34 = v40 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v41 : Result<std_path_PathBuf, std_io_Error> = v32 |> Ok
            let _run_target_args'_v34 = v41 
            #endif
#if FABLE_COMPILER_PYTHON
            let v42 : Result<std_path_PathBuf, std_io_Error> = v32 |> Ok
            let _run_target_args'_v34 = v42 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v43 : Result<std_path_PathBuf, std_io_Error> = v32 |> Ok
            let _run_target_args'_v34 = v43 
            #endif
#else
            let v44 : Result<std_path_PathBuf, std_io_Error> = v32 |> Ok
            let _run_target_args'_v34 = v44 
            #endif
            let v45 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v34 
            v45
    let _run_target_args'_v7 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::fs::read_link(&*$0)"
    let v54 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v53 
    let v55 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v57 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = "$0.map_err(|x| $1(x))"
    let v59 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v54, v55) v58 
    let _run_target_args'_v57 = v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : string = "$0.map_err(|x| $1(x))"
    let v61 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v54, v55) v60 
    let _run_target_args'_v57 = v61 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v62 : string = "$0.map_err(|x| $1(x))"
    let v63 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v54, v55) v62 
    let _run_target_args'_v57 = v63 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v64 : Result<std_path_PathBuf, string> = match v54 with Ok x -> Ok x | Error x -> Error (v55 x)
    let _run_target_args'_v57 = v64 
    #endif
#if FABLE_COMPILER_PYTHON
    let v65 : Result<std_path_PathBuf, string> = match v54 with Ok x -> Ok x | Error x -> Error (v55 x)
    let _run_target_args'_v57 = v65 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v66 : Result<std_path_PathBuf, string> = match v54 with Ok x -> Ok x | Error x -> Error (v55 x)
    let _run_target_args'_v57 = v66 
    #endif
#else
    let v67 : Result<std_path_PathBuf, string> = match v54 with Ok x -> Ok x | Error x -> Error (v55 x)
    let _run_target_args'_v57 = v67 
    #endif
    let v68 : Result<std_path_PathBuf, string> = _run_target_args'_v57 
    let v71 : (std_path_PathBuf -> US9) = method43()
    let v72 : (string -> US9) = method44()
    let v74 : US9 = match v68 with Ok x -> v71 x | Error x -> v72 x
    let v97 : Result<std_path_PathBuf, std_io_Error> =
        match v74 with
        | US9_1(v93) -> (* Error *)
            let v94 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v94, v1, v93, v2)
        | US9_0(v77) -> (* Ok *)
            (* run_target_args'
            let v79 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v80 : string = "Ok($0)"
            let v81 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v77 v80 
            let _run_target_args'_v79 = v81 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v82 : string = "Ok($0)"
            let v83 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v77 v82 
            let _run_target_args'_v79 = v83 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v84 : string = "Ok($0)"
            let v85 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v77 v84 
            let _run_target_args'_v79 = v85 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v86 : Result<std_path_PathBuf, std_io_Error> = v77 |> Ok
            let _run_target_args'_v79 = v86 
            #endif
#if FABLE_COMPILER_PYTHON
            let v87 : Result<std_path_PathBuf, std_io_Error> = v77 |> Ok
            let _run_target_args'_v79 = v87 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v88 : Result<std_path_PathBuf, std_io_Error> = v77 |> Ok
            let _run_target_args'_v79 = v88 
            #endif
#else
            let v89 : Result<std_path_PathBuf, std_io_Error> = v77 |> Ok
            let _run_target_args'_v79 = v89 
            #endif
            let v90 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v79 
            v90
    let _run_target_args'_v7 = v97 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v98 : string = "std::fs::read_link(&*$0)"
    let v99 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v98 
    let v100 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "$0.map_err(|x| $1(x))"
    let v104 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "$0.map_err(|x| $1(x))"
    let v106 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "$0.map_err(|x| $1(x))"
    let v108 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Result<std_path_PathBuf, string> = match v99 with Ok x -> Ok x | Error x -> Error (v100 x)
    let _run_target_args'_v102 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : Result<std_path_PathBuf, string> = match v99 with Ok x -> Ok x | Error x -> Error (v100 x)
    let _run_target_args'_v102 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Result<std_path_PathBuf, string> = match v99 with Ok x -> Ok x | Error x -> Error (v100 x)
    let _run_target_args'_v102 = v111 
    #endif
#else
    let v112 : Result<std_path_PathBuf, string> = match v99 with Ok x -> Ok x | Error x -> Error (v100 x)
    let _run_target_args'_v102 = v112 
    #endif
    let v113 : Result<std_path_PathBuf, string> = _run_target_args'_v102 
    let v116 : (std_path_PathBuf -> US9) = method43()
    let v117 : (string -> US9) = method44()
    let v119 : US9 = match v113 with Ok x -> v116 x | Error x -> v117 x
    let v142 : Result<std_path_PathBuf, std_io_Error> =
        match v119 with
        | US9_1(v138) -> (* Error *)
            let v139 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method46(v0, v139, v1, v138, v2)
        | US9_0(v122) -> (* Ok *)
            (* run_target_args'
            let v124 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v125 : string = "Ok($0)"
            let v126 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v125 
            let _run_target_args'_v124 = v126 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v127 : string = "Ok($0)"
            let v128 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v127 
            let _run_target_args'_v124 = v128 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v129 : string = "Ok($0)"
            let v130 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v129 
            let _run_target_args'_v124 = v130 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v131 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
            let _run_target_args'_v124 = v131 
            #endif
#if FABLE_COMPILER_PYTHON
            let v132 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
            let _run_target_args'_v124 = v132 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v133 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
            let _run_target_args'_v124 = v133 
            #endif
#else
            let v134 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
            let _run_target_args'_v124 = v134 
            #endif
            let v135 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v124 
            v135
    let _run_target_args'_v7 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v152 
    #endif
#else
    let v156 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v7 = v156 
    #endif
    let v159 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v7 
    v159
and closure20 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method45(v0, v1, v2)
and closure19 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure20(v0, v1)
and method49 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method47(v0)
    let v5 : string option = method33(v0)
    let v8 : (string -> US5) = method6()
    let v9 : US5 option = v5 |> Option.map v8 
    let v23 : US5 = US5_1
    let v24 : US5 = v9 |> Option.defaultValue v23 
    let v28 : string = method48(v3)
    let v29 : bool = v2 >= 11uy
    if v29 then
        let v30 : string = $"file_system.read_link / "
        let v31 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v32 : string = v30 + v31 
        (* run_target_args'
        let v37 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v38 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v39 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v38 
        let _run_target_args'_v37 = v39 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v40 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v41 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v40 
        let _run_target_args'_v37 = v41 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v42 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v43 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v42 
        let _run_target_args'_v37 = v43 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v45 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v45 
        #endif
#if FABLE_COMPILER_PYTHON
        let v49 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v49 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v53 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v53 
        #endif
#else
        let v57 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v57 
        #endif
        let v60 : std_io_Error = _run_target_args'_v37 
        (* run_target_args'
        let v67 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v68 : string = "Err($0)"
        let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v68 
        let _run_target_args'_v67 = v69 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v70 : string = "Err($0)"
        let v71 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v70 
        let _run_target_args'_v67 = v71 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v72 : string = "Err($0)"
        let v73 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v72 
        let _run_target_args'_v67 = v73 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v74 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v74 
        #endif
#if FABLE_COMPILER_PYTHON
        let v75 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v75 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v76 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v76 
        #endif
#else
        let v77 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v77 
        #endif
        let v78 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v67 
        v78
    else
        match v24 with
        | US5_0(v81) -> (* Some *)
            let v84 : string = ""
            let v85 : bool = v0 <> v84 
            if v85 then
                let v88 : uint8 = v2 + 1uy
                let v89 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v88
                let v90 : Result<std_path_PathBuf, std_io_Error> = v89 v81
                let v91 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v93 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v94 : string = "$0.map_err(|x| $1(x))"
                let v95 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v94 
                let _run_target_args'_v93 = v95 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v96 : string = "$0.map_err(|x| $1(x))"
                let v97 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v96 
                let _run_target_args'_v93 = v97 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v98 : string = "$0.map_err(|x| $1(x))"
                let v99 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v98 
                let _run_target_args'_v93 = v99 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v100 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v100 
                #endif
#if FABLE_COMPILER_PYTHON
                let v101 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v101 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v102 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v102 
                #endif
#else
                let v103 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v103 
                #endif
                let v104 : Result<std_path_PathBuf, string> = _run_target_args'_v93 
                let v107 : (std_path_PathBuf -> US9) = method43()
                let v108 : (string -> US9) = method44()
                let v110 : US9 = match v104 with Ok x -> v107 x | Error x -> v108 x
                match v110 with
                | US9_1(v266) -> (* Error *)
                    let v267 : string = $"file_system.read_link / "
                    let v268 : string = $"error': {v266} / error: {v28} / name: {v4}"
                    let v269 : string = v267 + v268 
                    (* run_target_args'
                    let v274 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v275 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v276 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v275 
                    let _run_target_args'_v274 = v276 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v277 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v278 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v277 
                    let _run_target_args'_v274 = v278 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v279 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v280 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v279 
                    let _run_target_args'_v274 = v280 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v282 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v282 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v286 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v286 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v290 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v290 
                    #endif
#else
                    let v294 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v294 
                    #endif
                    let v297 : std_io_Error = _run_target_args'_v274 
                    (* run_target_args'
                    let v304 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v305 : string = "Err($0)"
                    let v306 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v305 
                    let _run_target_args'_v304 = v306 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v307 : string = "Err($0)"
                    let v308 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v307 
                    let _run_target_args'_v304 = v308 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v309 : string = "Err($0)"
                    let v310 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v309 
                    let _run_target_args'_v304 = v310 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v311 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v311 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v312 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v312 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v313 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v313 
                    #endif
#else
                    let v314 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v314 
                    #endif
                    let v315 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v304 
                    v315
                | US9_0(v113) -> (* Ok *)
                    (* run_target_args'
                    let v118 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v119 : string = "$0.display()"
                    let v120 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v119 
                    let _run_target_args'_v118 = v120 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v121 : string = "$0.display()"
                    let v122 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v121 
                    let _run_target_args'_v118 = v122 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v123 : string = "$0.display()"
                    let v124 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v123 
                    let _run_target_args'_v118 = v124 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v126 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v126 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v130 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v130 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v134 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v134 
                    #endif
#else
                    let v138 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v138 
                    #endif
                    let v141 : std_path_Display = _run_target_args'_v118 
                    let v148 : string = v141 |> string 
                    let v151 : string = method28(v148, v4)
                    (* run_target_args'
                    let v156 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v157 : string = "&*$0"
                    let v158 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v157 
                    let _run_target_args'_v156 = v158 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v159 : string = "&*$0"
                    let v160 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v159 
                    let _run_target_args'_v156 = v160 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v161 : string = "&*$0"
                    let v162 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v161 
                    let _run_target_args'_v156 = v162 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v164 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v164 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v168 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v168 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v172 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v172 
                    #endif
#else
                    let v176 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v176 
                    #endif
                    let v179 : Ref<Str> = _run_target_args'_v156 
                    (* run_target_args'
                    let v189 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v190 : string = "String::from($0)"
                    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v190 
                    let _run_target_args'_v189 = v191 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v192 : string = "String::from($0)"
                    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v192 
                    let _run_target_args'_v189 = v193 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v194 : string = "String::from($0)"
                    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v194 
                    let _run_target_args'_v189 = v195 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v197 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v197 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v201 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v201 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v205 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v205 
                    #endif
#else
                    let v209 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v209 
                    #endif
                    let v212 : std_string_String = _run_target_args'_v189 
                    (* run_target_args'
                    let v222 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v223 : string = "std::path::PathBuf::from($0)"
                    let v224 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v223 
                    let _run_target_args'_v222 = v224 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v225 : string = "std::path::PathBuf::from($0)"
                    let v226 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v225 
                    let _run_target_args'_v222 = v226 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v227 : string = "std::path::PathBuf::from($0)"
                    let v228 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v227 
                    let _run_target_args'_v222 = v228 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v230 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v230 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v234 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v234 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v238 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v238 
                    #endif
#else
                    let v242 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v242 
                    #endif
                    let v245 : std_path_PathBuf = _run_target_args'_v222 
                    (* run_target_args'
                    let v252 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v253 : string = "Ok($0)"
                    let v254 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v253 
                    let _run_target_args'_v252 = v254 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v255 : string = "Ok($0)"
                    let v256 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v255 
                    let _run_target_args'_v252 = v256 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v257 : string = "Ok($0)"
                    let v258 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v257 
                    let _run_target_args'_v252 = v258 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v259 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v259 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v260 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v260 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v261 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v261 
                    #endif
#else
                    let v262 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v262 
                    #endif
                    let v263 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v252 
                    v263
            else
                let v320 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v321 : string = $"path: {v0} / error: {v28} / path': {v0} / name: {v4}"
                let v322 : string = v320 + v321 
                (* run_target_args'
                let v327 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v328 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v329 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v328 
                let _run_target_args'_v327 = v329 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v330 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v331 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v330 
                let _run_target_args'_v327 = v331 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v332 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v333 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v332 
                let _run_target_args'_v327 = v333 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v335 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v335 
                #endif
#if FABLE_COMPILER_PYTHON
                let v339 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v339 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v343 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v343 
                #endif
#else
                let v347 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v347 
                #endif
                let v350 : std_io_Error = _run_target_args'_v327 
                (* run_target_args'
                let v357 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v358 : string = "Err($0)"
                let v359 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v358 
                let _run_target_args'_v357 = v359 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v360 : string = "Err($0)"
                let v361 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v360 
                let _run_target_args'_v357 = v361 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v362 : string = "Err($0)"
                let v363 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v362 
                let _run_target_args'_v357 = v363 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v364 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v364 
                #endif
#if FABLE_COMPILER_PYTHON
                let v365 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v365 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v366 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v366 
                #endif
#else
                let v367 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v367 
                #endif
                let v368 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v357 
                v368
        | _ ->
            let v372 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v373 : string = $"path: {v0} / error: {v28} / path': {v0} / name: {v4}"
            let v374 : string = v372 + v373 
            (* run_target_args'
            let v379 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v380 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v381 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v380 
            let _run_target_args'_v379 = v381 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v382 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v383 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v382 
            let _run_target_args'_v379 = v383 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v384 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v385 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v384 
            let _run_target_args'_v379 = v385 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v387 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v387 
            #endif
#if FABLE_COMPILER_PYTHON
            let v391 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v391 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v395 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v395 
            #endif
#else
            let v399 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v399 
            #endif
            let v402 : std_io_Error = _run_target_args'_v379 
            (* run_target_args'
            let v409 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v410 : string = "Err($0)"
            let v411 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v410 
            let _run_target_args'_v409 = v411 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v412 : string = "Err($0)"
            let v413 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v412 
            let _run_target_args'_v409 = v413 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v414 : string = "Err($0)"
            let v415 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v414 
            let _run_target_args'_v409 = v415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v416 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v416 
            #endif
#if FABLE_COMPILER_PYTHON
            let v417 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v417 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v418 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v418 
            #endif
#else
            let v419 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v419 
            #endif
            let v420 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v409 
            v420
and method40 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "std::fs::read_link(&*$0)"
    let v8 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let v9 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "$0.map_err(|x| $1(x))"
    let v13 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v8, v9) v12 
    let _run_target_args'_v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "$0.map_err(|x| $1(x))"
    let v15 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v8, v9) v14 
    let _run_target_args'_v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "$0.map_err(|x| $1(x))"
    let v17 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v8, v9) v16 
    let _run_target_args'_v11 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Result<std_path_PathBuf, string> = match v8 with Ok x -> Ok x | Error x -> Error (v9 x)
    let _run_target_args'_v11 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : Result<std_path_PathBuf, string> = match v8 with Ok x -> Ok x | Error x -> Error (v9 x)
    let _run_target_args'_v11 = v19 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v20 : Result<std_path_PathBuf, string> = match v8 with Ok x -> Ok x | Error x -> Error (v9 x)
    let _run_target_args'_v11 = v20 
    #endif
#else
    let v21 : Result<std_path_PathBuf, string> = match v8 with Ok x -> Ok x | Error x -> Error (v9 x)
    let _run_target_args'_v11 = v21 
    #endif
    let v22 : Result<std_path_PathBuf, string> = _run_target_args'_v11 
    let v25 : (std_path_PathBuf -> US9) = method43()
    let v26 : (string -> US9) = method44()
    let v28 : US9 = match v22 with Ok x -> v25 x | Error x -> v26 x
    let v51 : Result<std_path_PathBuf, std_io_Error> =
        match v28 with
        | US9_1(v47) -> (* Error *)
            let v48 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v48, v1, v47)
        | US9_0(v31) -> (* Ok *)
            (* run_target_args'
            let v33 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v34 : string = "Ok($0)"
            let v35 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v31 v34 
            let _run_target_args'_v33 = v35 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v36 : string = "Ok($0)"
            let v37 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v31 v36 
            let _run_target_args'_v33 = v37 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v38 : string = "Ok($0)"
            let v39 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v31 v38 
            let _run_target_args'_v33 = v39 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v40 : Result<std_path_PathBuf, std_io_Error> = v31 |> Ok
            let _run_target_args'_v33 = v40 
            #endif
#if FABLE_COMPILER_PYTHON
            let v41 : Result<std_path_PathBuf, std_io_Error> = v31 |> Ok
            let _run_target_args'_v33 = v41 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v42 : Result<std_path_PathBuf, std_io_Error> = v31 |> Ok
            let _run_target_args'_v33 = v42 
            #endif
#else
            let v43 : Result<std_path_PathBuf, std_io_Error> = v31 |> Ok
            let _run_target_args'_v33 = v43 
            #endif
            let v44 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v33 
            v44
    let _run_target_args'_v6 = v51 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v52 : string = "std::fs::read_link(&*$0)"
    let v53 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v52 
    let v54 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v56 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v57 : string = "$0.map_err(|x| $1(x))"
    let v58 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v53, v54) v57 
    let _run_target_args'_v56 = v58 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v59 : string = "$0.map_err(|x| $1(x))"
    let v60 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v53, v54) v59 
    let _run_target_args'_v56 = v60 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : string = "$0.map_err(|x| $1(x))"
    let v62 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v53, v54) v61 
    let _run_target_args'_v56 = v62 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : Result<std_path_PathBuf, string> = match v53 with Ok x -> Ok x | Error x -> Error (v54 x)
    let _run_target_args'_v56 = v63 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : Result<std_path_PathBuf, string> = match v53 with Ok x -> Ok x | Error x -> Error (v54 x)
    let _run_target_args'_v56 = v64 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v65 : Result<std_path_PathBuf, string> = match v53 with Ok x -> Ok x | Error x -> Error (v54 x)
    let _run_target_args'_v56 = v65 
    #endif
#else
    let v66 : Result<std_path_PathBuf, string> = match v53 with Ok x -> Ok x | Error x -> Error (v54 x)
    let _run_target_args'_v56 = v66 
    #endif
    let v67 : Result<std_path_PathBuf, string> = _run_target_args'_v56 
    let v70 : (std_path_PathBuf -> US9) = method43()
    let v71 : (string -> US9) = method44()
    let v73 : US9 = match v67 with Ok x -> v70 x | Error x -> v71 x
    let v96 : Result<std_path_PathBuf, std_io_Error> =
        match v73 with
        | US9_1(v92) -> (* Error *)
            let v93 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v93, v1, v92)
        | US9_0(v76) -> (* Ok *)
            (* run_target_args'
            let v78 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v79 : string = "Ok($0)"
            let v80 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v76 v79 
            let _run_target_args'_v78 = v80 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v81 : string = "Ok($0)"
            let v82 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v76 v81 
            let _run_target_args'_v78 = v82 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v83 : string = "Ok($0)"
            let v84 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v76 v83 
            let _run_target_args'_v78 = v84 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v85 : Result<std_path_PathBuf, std_io_Error> = v76 |> Ok
            let _run_target_args'_v78 = v85 
            #endif
#if FABLE_COMPILER_PYTHON
            let v86 : Result<std_path_PathBuf, std_io_Error> = v76 |> Ok
            let _run_target_args'_v78 = v86 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v87 : Result<std_path_PathBuf, std_io_Error> = v76 |> Ok
            let _run_target_args'_v78 = v87 
            #endif
#else
            let v88 : Result<std_path_PathBuf, std_io_Error> = v76 |> Ok
            let _run_target_args'_v78 = v88 
            #endif
            let v89 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v78 
            v89
    let _run_target_args'_v6 = v96 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v97 : string = "std::fs::read_link(&*$0)"
    let v98 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v97 
    let v99 : (std_io_Error -> string) = method41()
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "$0.map_err(|x| $1(x))"
    let v103 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v98, v99) v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "$0.map_err(|x| $1(x))"
    let v105 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v98, v99) v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "$0.map_err(|x| $1(x))"
    let v107 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v98, v99) v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v108 : Result<std_path_PathBuf, string> = match v98 with Ok x -> Ok x | Error x -> Error (v99 x)
    let _run_target_args'_v101 = v108 
    #endif
#if FABLE_COMPILER_PYTHON
    let v109 : Result<std_path_PathBuf, string> = match v98 with Ok x -> Ok x | Error x -> Error (v99 x)
    let _run_target_args'_v101 = v109 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v110 : Result<std_path_PathBuf, string> = match v98 with Ok x -> Ok x | Error x -> Error (v99 x)
    let _run_target_args'_v101 = v110 
    #endif
#else
    let v111 : Result<std_path_PathBuf, string> = match v98 with Ok x -> Ok x | Error x -> Error (v99 x)
    let _run_target_args'_v101 = v111 
    #endif
    let v112 : Result<std_path_PathBuf, string> = _run_target_args'_v101 
    let v115 : (std_path_PathBuf -> US9) = method43()
    let v116 : (string -> US9) = method44()
    let v118 : US9 = match v112 with Ok x -> v115 x | Error x -> v116 x
    let v141 : Result<std_path_PathBuf, std_io_Error> =
        match v118 with
        | US9_1(v137) -> (* Error *)
            let v138 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
            method49(v0, v138, v1, v137)
        | US9_0(v121) -> (* Ok *)
            (* run_target_args'
            let v123 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v124 : string = "Ok($0)"
            let v125 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v124 
            let _run_target_args'_v123 = v125 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v126 : string = "Ok($0)"
            let v127 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v126 
            let _run_target_args'_v123 = v127 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v128 : string = "Ok($0)"
            let v129 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v128 
            let _run_target_args'_v123 = v129 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v130 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
            let _run_target_args'_v123 = v130 
            #endif
#if FABLE_COMPILER_PYTHON
            let v131 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
            let _run_target_args'_v123 = v131 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v132 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
            let _run_target_args'_v123 = v132 
            #endif
#else
            let v133 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
            let _run_target_args'_v123 = v133 
            #endif
            let v134 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v123 
            v134
    let _run_target_args'_v6 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v143 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v143 
    #endif
#if FABLE_COMPILER_PYTHON
    let v147 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v147 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v151 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v151 
    #endif
#else
    let v155 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _run_target_args'_v6 = v155 
    #endif
    let v158 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v6 
    v158
and method51 (v0 : System_IO_DirectoryInfo) : System.IO.FileAttributes =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v5 = v27 
    #endif
#else
    let v30 : (System_IO_DirectoryInfo -> System.IO.FileAttributes) = _.Attributes
    let v31 : System.IO.FileAttributes = v30 v0
    let _run_target_args'_v5 = v31 
    #endif
    let v32 : System.IO.FileAttributes = _run_target_args'_v5 
    v32
and method52 () : System.IO.FileAttributes =
    (* run_target_args'
    let v4 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _run_target_args'_v4 = v26 
    #endif
#else
    let v29 : System.IO.FileAttributes = System.IO.FileAttributes.ReparsePoint
    let _run_target_args'_v4 = v29 
    #endif
    let v30 : System.IO.FileAttributes = _run_target_args'_v4 
    v30
and method53 (v0 : System.IO.FileAttributes, v1 : System.IO.FileAttributes) : bool =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v24 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v28 : bool = null |> unbox<bool>
    let _run_target_args'_v6 = v28 
    #endif
#else
    let v31 : bool = v1.HasFlag v0 
    let _run_target_args'_v6 = v31 
    #endif
    let v32 : bool = _run_target_args'_v6 
    v32
and method55 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method47(v4)
    let v6 : string option = method33(v4)
    let v9 : (string -> US5) = method6()
    let v10 : US5 option = v6 |> Option.map v9 
    let v24 : US5 = US5_1
    let v25 : US5 = v10 |> Option.defaultValue v24 
    let v29 : string = method42(v3)
    let v30 : bool = v2 >= 11uy
    if v30 then
        let v31 : string = $"file_system.read_link / "
        let v32 : string = $"path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v33 : string = v31 + v32 
        (* run_target_args'
        let v38 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v39 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v40 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v39 
        let _run_target_args'_v38 = v40 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v41 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v42 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v41 
        let _run_target_args'_v38 = v42 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v43 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v44 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v33 v43 
        let _run_target_args'_v38 = v44 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v46 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v46 
        #endif
#if FABLE_COMPILER_PYTHON
        let v50 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v50 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v54 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v54 
        #endif
#else
        let v58 : std_io_Error = v33 |> unbox<std_io_Error>
        let _run_target_args'_v38 = v58 
        #endif
        let v61 : std_io_Error = _run_target_args'_v38 
        (* run_target_args'
        let v68 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v69 : string = "Err($0)"
        let v70 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v69 
        let _run_target_args'_v68 = v70 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v71 : string = "Err($0)"
        let v72 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v71 
        let _run_target_args'_v68 = v72 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v73 : string = "Err($0)"
        let v74 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v61 v73 
        let _run_target_args'_v68 = v74 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v75 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v75 
        #endif
#if FABLE_COMPILER_PYTHON
        let v76 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v76 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v77 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v77 
        #endif
#else
        let v78 : Result<std_path_PathBuf, std_io_Error> = v61 |> Error
        let _run_target_args'_v68 = v78 
        #endif
        let v79 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v68 
        v79
    else
        match v25 with
        | US5_0(v82) -> (* Some *)
            let v85 : string = ""
            let v86 : bool = v4 <> v85 
            if v86 then
                let v89 : uint8 = v2 + 1uy
                let v90 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v89
                let v91 : Result<std_path_PathBuf, std_io_Error> = v90 v82
                let v92 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v94 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v95 : string = "$0.map_err(|x| $1(x))"
                let v96 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v95 
                let _run_target_args'_v94 = v96 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v97 : string = "$0.map_err(|x| $1(x))"
                let v98 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v97 
                let _run_target_args'_v94 = v98 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v99 : string = "$0.map_err(|x| $1(x))"
                let v100 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v91, v92) v99 
                let _run_target_args'_v94 = v100 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v101 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v101 
                #endif
#if FABLE_COMPILER_PYTHON
                let v102 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v102 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v103 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v103 
                #endif
#else
                let v104 : Result<std_path_PathBuf, string> = match v91 with Ok x -> Ok x | Error x -> Error (v92 x)
                let _run_target_args'_v94 = v104 
                #endif
                let v105 : Result<std_path_PathBuf, string> = _run_target_args'_v94 
                let v108 : (std_path_PathBuf -> US9) = method43()
                let v109 : (string -> US9) = method44()
                let v111 : US9 = match v105 with Ok x -> v108 x | Error x -> v109 x
                match v111 with
                | US9_1(v267) -> (* Error *)
                    let v268 : string = $"file_system.read_link / "
                    let v269 : string = $"error': {v267} / error: {v29} / name: {v5}"
                    let v270 : string = v268 + v269 
                    (* run_target_args'
                    let v275 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v276 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v277 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v276 
                    let _run_target_args'_v275 = v277 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v278 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v279 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v278 
                    let _run_target_args'_v275 = v279 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v280 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v281 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v270 v280 
                    let _run_target_args'_v275 = v281 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v283 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v283 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v287 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v287 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v291 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v291 
                    #endif
#else
                    let v295 : std_io_Error = v270 |> unbox<std_io_Error>
                    let _run_target_args'_v275 = v295 
                    #endif
                    let v298 : std_io_Error = _run_target_args'_v275 
                    (* run_target_args'
                    let v305 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v306 : string = "Err($0)"
                    let v307 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v306 
                    let _run_target_args'_v305 = v307 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v308 : string = "Err($0)"
                    let v309 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v308 
                    let _run_target_args'_v305 = v309 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v310 : string = "Err($0)"
                    let v311 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v298 v310 
                    let _run_target_args'_v305 = v311 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v312 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v312 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v313 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v313 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v314 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v314 
                    #endif
#else
                    let v315 : Result<std_path_PathBuf, std_io_Error> = v298 |> Error
                    let _run_target_args'_v305 = v315 
                    #endif
                    let v316 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v305 
                    v316
                | US9_0(v114) -> (* Ok *)
                    (* run_target_args'
                    let v119 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v120 : string = "$0.display()"
                    let v121 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v120 
                    let _run_target_args'_v119 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v122 : string = "$0.display()"
                    let v123 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v122 
                    let _run_target_args'_v119 = v123 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v124 : string = "$0.display()"
                    let v125 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v114 v124 
                    let _run_target_args'_v119 = v125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v127 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v131 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v131 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v135 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v135 
                    #endif
#else
                    let v139 : std_path_Display = v114 |> unbox<std_path_Display>
                    let _run_target_args'_v119 = v139 
                    #endif
                    let v142 : std_path_Display = _run_target_args'_v119 
                    let v149 : string = v142 |> string 
                    let v152 : string = method28(v149, v5)
                    (* run_target_args'
                    let v157 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v158 : string = "&*$0"
                    let v159 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v158 
                    let _run_target_args'_v157 = v159 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v160 : string = "&*$0"
                    let v161 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v160 
                    let _run_target_args'_v157 = v161 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v162 : string = "&*$0"
                    let v163 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v152 v162 
                    let _run_target_args'_v157 = v163 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v165 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v165 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v169 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v169 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v173 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v173 
                    #endif
#else
                    let v177 : Ref<Str> = v152 |> unbox<Ref<Str>>
                    let _run_target_args'_v157 = v177 
                    #endif
                    let v180 : Ref<Str> = _run_target_args'_v157 
                    (* run_target_args'
                    let v190 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v191 : string = "String::from($0)"
                    let v192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v191 
                    let _run_target_args'_v190 = v192 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v193 : string = "String::from($0)"
                    let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v193 
                    let _run_target_args'_v190 = v194 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v195 : string = "String::from($0)"
                    let v196 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v195 
                    let _run_target_args'_v190 = v196 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v198 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v198 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v202 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v202 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v206 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v206 
                    #endif
#else
                    let v210 : std_string_String = v180 |> unbox<std_string_String>
                    let _run_target_args'_v190 = v210 
                    #endif
                    let v213 : std_string_String = _run_target_args'_v190 
                    (* run_target_args'
                    let v223 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v224 : string = "std::path::PathBuf::from($0)"
                    let v225 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v224 
                    let _run_target_args'_v223 = v225 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v226 : string = "std::path::PathBuf::from($0)"
                    let v227 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v226 
                    let _run_target_args'_v223 = v227 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v228 : string = "std::path::PathBuf::from($0)"
                    let v229 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v213 v228 
                    let _run_target_args'_v223 = v229 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v231 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v231 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v235 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v235 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v239 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v239 
                    #endif
#else
                    let v243 : std_path_PathBuf = v213 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v223 = v243 
                    #endif
                    let v246 : std_path_PathBuf = _run_target_args'_v223 
                    (* run_target_args'
                    let v253 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v254 : string = "Ok($0)"
                    let v255 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v254 
                    let _run_target_args'_v253 = v255 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v256 : string = "Ok($0)"
                    let v257 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v256 
                    let _run_target_args'_v253 = v257 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v258 : string = "Ok($0)"
                    let v259 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v246 v258 
                    let _run_target_args'_v253 = v259 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v260 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v260 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v261 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v261 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v262 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v262 
                    #endif
#else
                    let v263 : Result<std_path_PathBuf, std_io_Error> = v246 |> Ok
                    let _run_target_args'_v253 = v263 
                    #endif
                    let v264 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v253 
                    v264
            else
                let v321 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v322 : string = $"path: {v0} / error: {v29} / path': {v4} / name: {v5}"
                let v323 : string = v321 + v322 
                (* run_target_args'
                let v328 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v329 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v330 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v329 
                let _run_target_args'_v328 = v330 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v331 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v332 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v331 
                let _run_target_args'_v328 = v332 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v333 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v334 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v323 v333 
                let _run_target_args'_v328 = v334 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v336 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v336 
                #endif
#if FABLE_COMPILER_PYTHON
                let v340 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v340 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v344 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v344 
                #endif
#else
                let v348 : std_io_Error = v323 |> unbox<std_io_Error>
                let _run_target_args'_v328 = v348 
                #endif
                let v351 : std_io_Error = _run_target_args'_v328 
                (* run_target_args'
                let v358 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v359 : string = "Err($0)"
                let v360 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v359 
                let _run_target_args'_v358 = v360 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v361 : string = "Err($0)"
                let v362 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v361 
                let _run_target_args'_v358 = v362 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v363 : string = "Err($0)"
                let v364 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v351 v363 
                let _run_target_args'_v358 = v364 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v365 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v365 
                #endif
#if FABLE_COMPILER_PYTHON
                let v366 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v366 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v367 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v367 
                #endif
#else
                let v368 : Result<std_path_PathBuf, std_io_Error> = v351 |> Error
                let _run_target_args'_v358 = v368 
                #endif
                let v369 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v358 
                v369
        | _ ->
            let v373 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v374 : string = $"path: {v0} / error: {v29} / path': {v4} / name: {v5}"
            let v375 : string = v373 + v374 
            (* run_target_args'
            let v380 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v381 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v382 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v381 
            let _run_target_args'_v380 = v382 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v383 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v384 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v383 
            let _run_target_args'_v380 = v384 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v385 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v386 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v375 v385 
            let _run_target_args'_v380 = v386 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v388 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v388 
            #endif
#if FABLE_COMPILER_PYTHON
            let v392 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v392 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v396 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v396 
            #endif
#else
            let v400 : std_io_Error = v375 |> unbox<std_io_Error>
            let _run_target_args'_v380 = v400 
            #endif
            let v403 : std_io_Error = _run_target_args'_v380 
            (* run_target_args'
            let v410 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v411 : string = "Err($0)"
            let v412 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v411 
            let _run_target_args'_v410 = v412 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v413 : string = "Err($0)"
            let v414 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v413 
            let _run_target_args'_v410 = v414 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v415 : string = "Err($0)"
            let v416 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v403 v415 
            let _run_target_args'_v410 = v416 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v417 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v417 
            #endif
#if FABLE_COMPILER_PYTHON
            let v418 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v418 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v419 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v419 
            #endif
#else
            let v420 : Result<std_path_PathBuf, std_io_Error> = v403 |> Error
            let _run_target_args'_v410 = v420 
            #endif
            let v421 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v410 
            v421
and method54 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v25 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v29 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v7 = v29 
    #endif
#else
    let v33 : System_IO_DirectoryInfo = v2 |> System_IO_DirectoryInfo 
    let _run_target_args'_v7 = v33 
    #endif
    let v36 : System_IO_DirectoryInfo = _run_target_args'_v7 
    let v42 : System.IO.FileAttributes = method51(v36)
    let v43 : System.IO.FileAttributes = method52()
    let v44 : bool = method53(v43, v42)
    if v44 then
        (* run_target_args'
        let v49 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v51 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v55 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v55 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v59 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v59 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v63 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v63 
        #endif
#if FABLE_COMPILER_PYTHON
        let v67 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v67 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v71 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v49 = v71 
        #endif
#else
        let v75 : System_IO_FileInfo = v2 |> System_IO_FileInfo 
        let _run_target_args'_v49 = v75 
        #endif
        let v78 : System_IO_FileInfo = _run_target_args'_v49 
        (* run_target_args'
        let v88 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v90 : string = null |> unbox<string>
        let _run_target_args'_v88 = v90 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v94 : string = null |> unbox<string>
        let _run_target_args'_v88 = v94 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v98 : string = null |> unbox<string>
        let _run_target_args'_v88 = v98 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v102 : string = null |> unbox<string>
        let _run_target_args'_v88 = v102 
        #endif
#if FABLE_COMPILER_PYTHON
        let v106 : string = null |> unbox<string>
        let _run_target_args'_v88 = v106 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v110 : string = null |> unbox<string>
        let _run_target_args'_v88 = v110 
        #endif
#else
        let v113 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v114 : string = v113 v78
        let _run_target_args'_v88 = v114 
        #endif
        let v115 : string = _run_target_args'_v88 
        let v122 : std_path_PathBuf = v115 |> unbox<std_path_PathBuf>
        (* run_target_args'
        let v126 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v127 : string = "Ok($0)"
        let v128 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v127 
        let _run_target_args'_v126 = v128 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v129 : string = "Ok($0)"
        let v130 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v129 
        let _run_target_args'_v126 = v130 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v131 : string = "Ok($0)"
        let v132 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v122 v131 
        let _run_target_args'_v126 = v132 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v133 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
        let _run_target_args'_v126 = v133 
        #endif
#if FABLE_COMPILER_PYTHON
        let v134 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
        let _run_target_args'_v126 = v134 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v135 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
        let _run_target_args'_v126 = v135 
        #endif
#else
        let v136 : Result<std_path_PathBuf, std_io_Error> = v122 |> Ok
        let _run_target_args'_v126 = v136 
        #endif
        let v137 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v126 
        v137
    else
        let v140 : string = $"file_system.read_link / Fsharp / "
        let v141 : string = $"The file or directory is not a reparse point. / "
        let v142 : string = v140 + v141 
        let v143 : string = $"path: {v0} / result: {v44} / path': {v2} / n: {v1}"
        let v144 : string = v142 + v143 
        (* run_target_args'
        let v149 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v150 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v151 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v144 v150 
        let _run_target_args'_v149 = v151 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v152 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v153 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v144 v152 
        let _run_target_args'_v149 = v153 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v154 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v155 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v144 v154 
        let _run_target_args'_v149 = v155 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v157 : std_io_Error = v144 |> unbox<std_io_Error>
        let _run_target_args'_v149 = v157 
        #endif
#if FABLE_COMPILER_PYTHON
        let v161 : std_io_Error = v144 |> unbox<std_io_Error>
        let _run_target_args'_v149 = v161 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v165 : std_io_Error = v144 |> unbox<std_io_Error>
        let _run_target_args'_v149 = v165 
        #endif
#else
        let v169 : std_io_Error = v144 |> unbox<std_io_Error>
        let _run_target_args'_v149 = v169 
        #endif
        let v172 : std_io_Error = _run_target_args'_v149 
        let v178 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure21(v0)
        method55(v0, v178, v1, v172, v2)
and closure22 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method54(v0, v1, v2)
and closure21 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure22(v0, v1)
and method56 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method47(v0)
    let v5 : string option = method33(v0)
    let v8 : (string -> US5) = method6()
    let v9 : US5 option = v5 |> Option.map v8 
    let v23 : US5 = US5_1
    let v24 : US5 = v9 |> Option.defaultValue v23 
    let v28 : string = method42(v3)
    let v29 : bool = v2 >= 11uy
    if v29 then
        let v30 : string = $"file_system.read_link / "
        let v31 : string = $"path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v32 : string = v30 + v31 
        (* run_target_args'
        let v37 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v38 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v39 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v38 
        let _run_target_args'_v37 = v39 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v40 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v41 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v40 
        let _run_target_args'_v37 = v41 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v42 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v43 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v32 v42 
        let _run_target_args'_v37 = v43 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v45 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v45 
        #endif
#if FABLE_COMPILER_PYTHON
        let v49 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v49 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v53 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v53 
        #endif
#else
        let v57 : std_io_Error = v32 |> unbox<std_io_Error>
        let _run_target_args'_v37 = v57 
        #endif
        let v60 : std_io_Error = _run_target_args'_v37 
        (* run_target_args'
        let v67 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v68 : string = "Err($0)"
        let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v68 
        let _run_target_args'_v67 = v69 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v70 : string = "Err($0)"
        let v71 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v70 
        let _run_target_args'_v67 = v71 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v72 : string = "Err($0)"
        let v73 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v60 v72 
        let _run_target_args'_v67 = v73 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v74 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v74 
        #endif
#if FABLE_COMPILER_PYTHON
        let v75 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v75 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v76 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v76 
        #endif
#else
        let v77 : Result<std_path_PathBuf, std_io_Error> = v60 |> Error
        let _run_target_args'_v67 = v77 
        #endif
        let v78 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v67 
        v78
    else
        match v24 with
        | US5_0(v81) -> (* Some *)
            let v84 : string = ""
            let v85 : bool = v0 <> v84 
            if v85 then
                let v88 : uint8 = v2 + 1uy
                let v89 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v88
                let v90 : Result<std_path_PathBuf, std_io_Error> = v89 v81
                let v91 : (std_io_Error -> string) = method41()
                (* run_target_args'
                let v93 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v94 : string = "$0.map_err(|x| $1(x))"
                let v95 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v94 
                let _run_target_args'_v93 = v95 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v96 : string = "$0.map_err(|x| $1(x))"
                let v97 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v96 
                let _run_target_args'_v93 = v97 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v98 : string = "$0.map_err(|x| $1(x))"
                let v99 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v98 
                let _run_target_args'_v93 = v99 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v100 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v100 
                #endif
#if FABLE_COMPILER_PYTHON
                let v101 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v101 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v102 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v102 
                #endif
#else
                let v103 : Result<std_path_PathBuf, string> = match v90 with Ok x -> Ok x | Error x -> Error (v91 x)
                let _run_target_args'_v93 = v103 
                #endif
                let v104 : Result<std_path_PathBuf, string> = _run_target_args'_v93 
                let v107 : (std_path_PathBuf -> US9) = method43()
                let v108 : (string -> US9) = method44()
                let v110 : US9 = match v104 with Ok x -> v107 x | Error x -> v108 x
                match v110 with
                | US9_1(v266) -> (* Error *)
                    let v267 : string = $"file_system.read_link / "
                    let v268 : string = $"error': {v266} / error: {v28} / name: {v4}"
                    let v269 : string = v267 + v268 
                    (* run_target_args'
                    let v274 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v275 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v276 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v275 
                    let _run_target_args'_v274 = v276 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v277 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v278 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v277 
                    let _run_target_args'_v274 = v278 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v279 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v280 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v269 v279 
                    let _run_target_args'_v274 = v280 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v282 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v282 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v286 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v286 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v290 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v290 
                    #endif
#else
                    let v294 : std_io_Error = v269 |> unbox<std_io_Error>
                    let _run_target_args'_v274 = v294 
                    #endif
                    let v297 : std_io_Error = _run_target_args'_v274 
                    (* run_target_args'
                    let v304 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v305 : string = "Err($0)"
                    let v306 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v305 
                    let _run_target_args'_v304 = v306 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v307 : string = "Err($0)"
                    let v308 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v307 
                    let _run_target_args'_v304 = v308 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v309 : string = "Err($0)"
                    let v310 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v297 v309 
                    let _run_target_args'_v304 = v310 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v311 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v311 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v312 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v312 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v313 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v313 
                    #endif
#else
                    let v314 : Result<std_path_PathBuf, std_io_Error> = v297 |> Error
                    let _run_target_args'_v304 = v314 
                    #endif
                    let v315 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v304 
                    v315
                | US9_0(v113) -> (* Ok *)
                    (* run_target_args'
                    let v118 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v119 : string = "$0.display()"
                    let v120 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v119 
                    let _run_target_args'_v118 = v120 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v121 : string = "$0.display()"
                    let v122 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v121 
                    let _run_target_args'_v118 = v122 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v123 : string = "$0.display()"
                    let v124 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v113 v123 
                    let _run_target_args'_v118 = v124 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v126 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v126 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v130 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v130 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v134 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v134 
                    #endif
#else
                    let v138 : std_path_Display = v113 |> unbox<std_path_Display>
                    let _run_target_args'_v118 = v138 
                    #endif
                    let v141 : std_path_Display = _run_target_args'_v118 
                    let v148 : string = v141 |> string 
                    let v151 : string = method28(v148, v4)
                    (* run_target_args'
                    let v156 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v157 : string = "&*$0"
                    let v158 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v157 
                    let _run_target_args'_v156 = v158 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v159 : string = "&*$0"
                    let v160 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v159 
                    let _run_target_args'_v156 = v160 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v161 : string = "&*$0"
                    let v162 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v151 v161 
                    let _run_target_args'_v156 = v162 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v164 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v164 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v168 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v168 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v172 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v172 
                    #endif
#else
                    let v176 : Ref<Str> = v151 |> unbox<Ref<Str>>
                    let _run_target_args'_v156 = v176 
                    #endif
                    let v179 : Ref<Str> = _run_target_args'_v156 
                    (* run_target_args'
                    let v189 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v190 : string = "String::from($0)"
                    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v190 
                    let _run_target_args'_v189 = v191 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v192 : string = "String::from($0)"
                    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v192 
                    let _run_target_args'_v189 = v193 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v194 : string = "String::from($0)"
                    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v194 
                    let _run_target_args'_v189 = v195 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v197 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v197 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v201 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v201 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v205 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v205 
                    #endif
#else
                    let v209 : std_string_String = v179 |> unbox<std_string_String>
                    let _run_target_args'_v189 = v209 
                    #endif
                    let v212 : std_string_String = _run_target_args'_v189 
                    (* run_target_args'
                    let v222 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v223 : string = "std::path::PathBuf::from($0)"
                    let v224 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v223 
                    let _run_target_args'_v222 = v224 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v225 : string = "std::path::PathBuf::from($0)"
                    let v226 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v225 
                    let _run_target_args'_v222 = v226 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v227 : string = "std::path::PathBuf::from($0)"
                    let v228 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v212 v227 
                    let _run_target_args'_v222 = v228 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v230 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v230 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v234 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v234 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v238 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v238 
                    #endif
#else
                    let v242 : std_path_PathBuf = v212 |> unbox<std_path_PathBuf>
                    let _run_target_args'_v222 = v242 
                    #endif
                    let v245 : std_path_PathBuf = _run_target_args'_v222 
                    (* run_target_args'
                    let v252 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v253 : string = "Ok($0)"
                    let v254 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v253 
                    let _run_target_args'_v252 = v254 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v255 : string = "Ok($0)"
                    let v256 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v255 
                    let _run_target_args'_v252 = v256 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v257 : string = "Ok($0)"
                    let v258 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v245 v257 
                    let _run_target_args'_v252 = v258 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v259 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v259 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v260 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v260 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v261 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v261 
                    #endif
#else
                    let v262 : Result<std_path_PathBuf, std_io_Error> = v245 |> Ok
                    let _run_target_args'_v252 = v262 
                    #endif
                    let v263 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v252 
                    v263
            else
                let v320 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
                let v321 : string = $"path: {v0} / error: {v28} / path': {v0} / name: {v4}"
                let v322 : string = v320 + v321 
                (* run_target_args'
                let v327 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v328 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v329 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v328 
                let _run_target_args'_v327 = v329 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v330 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v331 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v330 
                let _run_target_args'_v327 = v331 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v332 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v333 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v322 v332 
                let _run_target_args'_v327 = v333 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v335 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v335 
                #endif
#if FABLE_COMPILER_PYTHON
                let v339 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v339 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v343 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v343 
                #endif
#else
                let v347 : std_io_Error = v322 |> unbox<std_io_Error>
                let _run_target_args'_v327 = v347 
                #endif
                let v350 : std_io_Error = _run_target_args'_v327 
                (* run_target_args'
                let v357 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v358 : string = "Err($0)"
                let v359 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v358 
                let _run_target_args'_v357 = v359 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v360 : string = "Err($0)"
                let v361 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v360 
                let _run_target_args'_v357 = v361 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v362 : string = "Err($0)"
                let v363 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v350 v362 
                let _run_target_args'_v357 = v363 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v364 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v364 
                #endif
#if FABLE_COMPILER_PYTHON
                let v365 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v365 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v366 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v366 
                #endif
#else
                let v367 : Result<std_path_PathBuf, std_io_Error> = v350 |> Error
                let _run_target_args'_v357 = v367 
                #endif
                let v368 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v357 
                v368
        | _ ->
            let v372 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / "
            let v373 : string = $"path: {v0} / error: {v28} / path': {v0} / name: {v4}"
            let v374 : string = v372 + v373 
            (* run_target_args'
            let v379 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v380 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v381 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v380 
            let _run_target_args'_v379 = v381 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v382 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v383 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v382 
            let _run_target_args'_v379 = v383 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v384 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v385 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v374 v384 
            let _run_target_args'_v379 = v385 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v387 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v387 
            #endif
#if FABLE_COMPILER_PYTHON
            let v391 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v391 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v395 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v395 
            #endif
#else
            let v399 : std_io_Error = v374 |> unbox<std_io_Error>
            let _run_target_args'_v379 = v399 
            #endif
            let v402 : std_io_Error = _run_target_args'_v379 
            (* run_target_args'
            let v409 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v410 : string = "Err($0)"
            let v411 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v410 
            let _run_target_args'_v409 = v411 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v412 : string = "Err($0)"
            let v413 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v412 
            let _run_target_args'_v409 = v413 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v414 : string = "Err($0)"
            let v415 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v402 v414 
            let _run_target_args'_v409 = v415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v416 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v416 
            #endif
#if FABLE_COMPILER_PYTHON
            let v417 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v417 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v418 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v418 
            #endif
#else
            let v419 : Result<std_path_PathBuf, std_io_Error> = v402 |> Error
            let _run_target_args'_v409 = v419 
            #endif
            let v420 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v409 
            v420
and method50 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v24 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v28 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _run_target_args'_v6 = v28 
    #endif
#else
    let v32 : System_IO_DirectoryInfo = v0 |> System_IO_DirectoryInfo 
    let _run_target_args'_v6 = v32 
    #endif
    let v35 : System_IO_DirectoryInfo = _run_target_args'_v6 
    let v41 : System.IO.FileAttributes = method51(v35)
    let v42 : System.IO.FileAttributes = method52()
    let v43 : bool = method53(v42, v41)
    if v43 then
        (* run_target_args'
        let v48 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v50 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v50 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v54 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v58 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v58 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v62 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v62 
        #endif
#if FABLE_COMPILER_PYTHON
        let v66 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v66 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v70 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _run_target_args'_v48 = v70 
        #endif
#else
        let v74 : System_IO_FileInfo = v0 |> System_IO_FileInfo 
        let _run_target_args'_v48 = v74 
        #endif
        let v77 : System_IO_FileInfo = _run_target_args'_v48 
        (* run_target_args'
        let v87 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v89 : string = null |> unbox<string>
        let _run_target_args'_v87 = v89 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v93 : string = null |> unbox<string>
        let _run_target_args'_v87 = v93 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v97 : string = null |> unbox<string>
        let _run_target_args'_v87 = v97 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v101 : string = null |> unbox<string>
        let _run_target_args'_v87 = v101 
        #endif
#if FABLE_COMPILER_PYTHON
        let v105 : string = null |> unbox<string>
        let _run_target_args'_v87 = v105 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v109 : string = null |> unbox<string>
        let _run_target_args'_v87 = v109 
        #endif
#else
        let v112 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v113 : string = v112 v77
        let _run_target_args'_v87 = v113 
        #endif
        let v114 : string = _run_target_args'_v87 
        let v121 : std_path_PathBuf = v114 |> unbox<std_path_PathBuf>
        (* run_target_args'
        let v125 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v126 : string = "Ok($0)"
        let v127 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v126 
        let _run_target_args'_v125 = v127 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v128 : string = "Ok($0)"
        let v129 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v128 
        let _run_target_args'_v125 = v129 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v130 : string = "Ok($0)"
        let v131 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v121 v130 
        let _run_target_args'_v125 = v131 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v132 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
        let _run_target_args'_v125 = v132 
        #endif
#if FABLE_COMPILER_PYTHON
        let v133 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
        let _run_target_args'_v125 = v133 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v134 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
        let _run_target_args'_v125 = v134 
        #endif
#else
        let v135 : Result<std_path_PathBuf, std_io_Error> = v121 |> Ok
        let _run_target_args'_v125 = v135 
        #endif
        let v136 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v125 
        v136
    else
        let v139 : string = $"file_system.read_link / Fsharp / "
        let v140 : string = $"The file or directory is not a reparse point. / "
        let v141 : string = v139 + v140 
        let v142 : string = $"path: {v0} / result: {v43} / path': {v0} / n: {v1}"
        let v143 : string = v141 + v142 
        (* run_target_args'
        let v148 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v149 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v150 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v143 v149 
        let _run_target_args'_v148 = v150 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v151 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v152 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v143 v151 
        let _run_target_args'_v148 = v152 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v153 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v154 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v143 v153 
        let _run_target_args'_v148 = v154 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v156 : std_io_Error = v143 |> unbox<std_io_Error>
        let _run_target_args'_v148 = v156 
        #endif
#if FABLE_COMPILER_PYTHON
        let v160 : std_io_Error = v143 |> unbox<std_io_Error>
        let _run_target_args'_v148 = v160 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v164 : std_io_Error = v143 |> unbox<std_io_Error>
        let _run_target_args'_v148 = v164 
        #endif
#else
        let v168 : std_io_Error = v143 |> unbox<std_io_Error>
        let _run_target_args'_v148 = v168 
        #endif
        let v171 : std_io_Error = _run_target_args'_v148 
        let v177 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure21(v0)
        method56(v0, v177, v1, v171)
and method39 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method31(v0)
    let v8 : Result<std_path_PathBuf, std_io_Error> =
        if v3 then
            let v4 : string = "std::fs::read_link(&*$0)"
            let v5 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v4 
            v5
        else
            let v6 : uint8 = 0uy
            method40(v0, v6)
    let _run_target_args'_v2 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : bool = method31(v0)
    let v14 : Result<std_path_PathBuf, std_io_Error> =
        if v9 then
            let v10 : string = "std::fs::read_link(&*$0)"
            let v11 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v10 
            v11
        else
            let v12 : uint8 = 0uy
            method40(v0, v12)
    let _run_target_args'_v2 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : bool = method31(v0)
    let v20 : Result<std_path_PathBuf, std_io_Error> =
        if v15 then
            let v16 : string = "std::fs::read_link(&*$0)"
            let v17 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v16 
            v17
        else
            let v18 : uint8 = 0uy
            method40(v0, v18)
    let _run_target_args'_v2 = v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : uint8 = 0uy
    let v22 : Result<std_path_PathBuf, std_io_Error> = method50(v0, v21)
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
    let _run_target_args'_v2 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24 : uint8 = 0uy
    let v25 : Result<std_path_PathBuf, std_io_Error> = method50(v0, v24)
    let _run_target_args'_v2 = v25 
    #endif
#else
    let v26 : uint8 = 0uy
    let v27 : Result<std_path_PathBuf, std_io_Error> = method50(v0, v26)
    let _run_target_args'_v2 = v27 
    #endif
    let v28 : Result<std_path_PathBuf, std_io_Error> = _run_target_args'_v2 
    v28
and closure23 () (v0 : std_path_PathBuf) : US10 =
    US10_0(v0)
and method57 () : (std_path_PathBuf -> US10) =
    closure23()
and method59 (v0 : string) : string =
    v0
and method60 () : string =
    let v0 : string = ""
    v0
and method58 (v0 : string, v1 : string, v2 : string) : string =
    (* run_target_args'
    let v4 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = $"regex::Regex::new(&$0)"
    let v6 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.unwrap()"
    let v10 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v6 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.unwrap()"
    let v12 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.unwrap()"
    let v14 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : regex_Regex = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : regex_Regex = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : regex_Regex = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v17 
    #endif
#else
    let v18 : regex_Regex = match v6 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v8 = v18 
    #endif
    let v19 : regex_Regex = _run_target_args'_v8 
    let v22 : string = method59(v2)
    let v23 : string = $"$0.replace_all(&*$1, &*$2)"
    let v24 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v19, v22, v1) v23 
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "fable_library_rust::String_::fromString($0)"
    let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let _run_target_args'_v4 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = method60()
    let _run_target_args'_v4 = v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = method60()
    let _run_target_args'_v4 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : string = method60()
    let _run_target_args'_v4 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : string = method60()
    let _run_target_args'_v4 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v33 : string = method60()
    let _run_target_args'_v4 = v33 
    #endif
#else
    let v34 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    let _run_target_args'_v4 = v34 
    #endif
    let v35 : string = _run_target_args'_v4 
    v35
and method38 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = method39(v0)
        (* run_target_args'
        let v5 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6 : string = "$0.ok()"
        let v7 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v6 
        let _run_target_args'_v5 = v7 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v8 : string = "$0.ok()"
        let v9 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v8 
        let _run_target_args'_v5 = v9 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v10 : string = "$0.ok()"
        let v11 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v10 
        let _run_target_args'_v5 = v11 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v12 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v5 = v12 
        #endif
#if FABLE_COMPILER_PYTHON
        let v13 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v5 = v13 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v14 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v5 = v14 
        #endif
#else
        let v15 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v5 = v15 
        #endif
        let v16 : std_path_PathBuf option = _run_target_args'_v5 
        let v21 : (std_path_PathBuf -> US10) = method57()
        let v22 : US10 option = v16 |> Option.map v21 
        let v36 : US10 = US10_1
        let v37 : US10 = v22 |> Option.defaultValue v36 
        let v80 : string =
            match v37 with
            | US10_1 -> (* None *)
                v0
            | US10_0(v41) -> (* Some *)
                (* run_target_args'
                let v46 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v47 : string = "$0.display()"
                let v48 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v41 v47 
                let _run_target_args'_v46 = v48 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v49 : string = "$0.display()"
                let v50 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v41 v49 
                let _run_target_args'_v46 = v50 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v51 : string = "$0.display()"
                let v52 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v41 v51 
                let _run_target_args'_v46 = v52 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v54 : std_path_Display = v41 |> unbox<std_path_Display>
                let _run_target_args'_v46 = v54 
                #endif
#if FABLE_COMPILER_PYTHON
                let v58 : std_path_Display = v41 |> unbox<std_path_Display>
                let _run_target_args'_v46 = v58 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v62 : std_path_Display = v41 |> unbox<std_path_Display>
                let _run_target_args'_v46 = v62 
                #endif
#else
                let v66 : std_path_Display = v41 |> unbox<std_path_Display>
                let _run_target_args'_v46 = v66 
                #endif
                let v69 : std_path_Display = _run_target_args'_v46 
                let v76 : string = v69 |> string 
                v76
        let v81 : bool = v80 = ""
        let v82 : string =
            if v81 then
                v0
            else
                v80
        let v83 : string = "^\\\\\\\\\\?\\\\"
        let v84 : string = ""
        let v85 : string = method58(v83, v84, v82)
        let v86 : int32 = v85.Length
        let v87 : bool = v86 < 2
        if v87 then
            v0
        else
            let v88 : string = $"{v85.[0] |> string |> _.ToLower()}{v85.[1..]}"
            let v89 : string = "\\"
            let v90 : string = "/"
            let v91 : string = v88.Replace (v89, v90)
            v91
and method27 (v0 : string) : US5 =
    let v1 : US7 = US7_1
    let v2 : string = "spiral"
    let v3 : string = "workspace"
    let v4 : string = method28(v2, v3)
    let v5 : US8 = method29(v1, v4, v0)
    match v5 with
    | US8_1(v9) -> (* Error *)
        let v10 : unit = ()
        let v11 : (unit -> unit) = closure15(v0, v9)
        let v12 : unit = (fun () -> v11 (); v10) ()
        US5_1
    | US8_0(v6) -> (* Ok *)
        let v7 : string = method38(v6)
        US5_0(v7)
and method62 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method63 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method64 () : char =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::path::MAIN_SEPARATOR"
    let v3 : char = Fable.Core.RustInterop.emitRustExpr () v2 
    let _run_target_args'_v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "std::path::MAIN_SEPARATOR"
    let v5 : char = Fable.Core.RustInterop.emitRustExpr () v4 
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "std::path::MAIN_SEPARATOR"
    let v7 : char = Fable.Core.RustInterop.emitRustExpr () v6 
    let _run_target_args'_v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v1 = '/' 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v1 = '/' 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v8 : char = System.IO.Path.DirectorySeparatorChar
    let _run_target_args'_v1 = v8 
    #endif
#else
    let v9 : char = System.IO.Path.DirectorySeparatorChar
    let _run_target_args'_v1 = v9 
    #endif
    let v10 : char = _run_target_args'_v1 
    v10
and method65 (v0 : string) : string =
    v0
and method61 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v22 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
#else
    let v30 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v30 
    #endif
    let v33 : Ref<Str> = _run_target_args'_v10 
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v44 
    let _run_target_args'_v43 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v48 
    let _run_target_args'_v43 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v59 
    #endif
#else
    let v63 : std_string_String = v33 |> unbox<std_string_String>
    let _run_target_args'_v43 = v63 
    #endif
    let v66 : std_string_String = _run_target_args'_v43 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "std::path::PathBuf::from($0)"
    let v78 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "std::path::PathBuf::from($0)"
    let v80 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "std::path::PathBuf::from($0)"
    let v82 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v66 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : std_path_PathBuf = v66 |> unbox<std_path_PathBuf>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : std_path_PathBuf = _run_target_args'_v76 
    let v105 : string = "$0.exists()"
    let v106 : bool = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let v107 : bool = v106 = false
    let v289 : string =
        if v107 then
            let v108 : string = method26()
            let v109 : string = method28(v108, v0)
            let v110 : string = method38(v109)
            let v112 : string = "/"
            let v113 : (string []) = v110.Split v112 
            let v116 : (string []) = [||]
            let v117 : int32 = v113.Length
            let v118 : Mut5 = {l0 = 0; l1 = 0; l2 = v116} : Mut5
            while method62(v117, v118) do
                let v120 : int32 = v118.l0
                let v121 : int32 =  -v120
                let v122 : int32 = v121 + v117
                let v123 : int32 = v122 - 1
                let struct (v124 : int32, v125 : (string [])) = v118.l1, v118.l2
                let v126 : string = v113.[int v123]
                let v127 : bool = ".." = v126
                let struct (v172 : int32, v173 : (string [])) =
                    if v127 then
                        let v128 : int32 = v124 + 1
                        struct (v128, v125)
                    else
                        let v129 : bool = "." = v126
                        if v129 then
                            struct (v124, v125)
                        else
                            let v130 : bool = 0 = v124
                            if v130 then
                                let v132 : string = ":"
                                let v133 : bool = v126.EndsWith (v132, false, null)
                                if v133 then
                                    let v136 : string = $"{v108.[0]}:"
                                    let v137 : (string []) = [|v136|]
                                    let v138 : int32 = v137.Length
                                    let v139 : int32 = v125.Length
                                    let v140 : int32 = v138 + v139
                                    let v141 : (string []) = Array.zeroCreate<string> (v140)
                                    let v142 : Mut6 = {l0 = 0} : Mut6
                                    while method63(v140, v142) do
                                        let v144 : int32 = v142.l0
                                        let v145 : bool = v144 < v138
                                        let v149 : string =
                                            if v145 then
                                                let v146 : string = v137.[int v144]
                                                v146
                                            else
                                                let v147 : int32 = v144 - v138
                                                let v148 : string = v125.[int v147]
                                                v148
                                        v141.[int v144] <- v149
                                        let v150 : int32 = v144 + 1
                                        v142.l0 <- v150
                                        ()
                                    struct (0, v141)
                                else
                                    let v151 : (string []) = [|v126|]
                                    let v152 : int32 = v151.Length
                                    let v153 : int32 = v125.Length
                                    let v154 : int32 = v152 + v153
                                    let v155 : (string []) = Array.zeroCreate<string> (v154)
                                    let v156 : Mut6 = {l0 = 0} : Mut6
                                    while method63(v154, v156) do
                                        let v158 : int32 = v156.l0
                                        let v159 : bool = v158 < v152
                                        let v163 : string =
                                            if v159 then
                                                let v160 : string = v151.[int v158]
                                                v160
                                            else
                                                let v161 : int32 = v158 - v152
                                                let v162 : string = v125.[int v161]
                                                v162
                                        v155.[int v158] <- v163
                                        let v164 : int32 = v158 + 1
                                        v156.l0 <- v164
                                        ()
                                    struct (0, v155)
                            else
                                let v167 : int32 = v124 - 1
                                struct (v167, v125)
                let v174 : int32 = v120 + 1
                v118.l0 <- v174
                v118.l1 <- v172
                v118.l2 <- v173
                ()
            let struct (v175 : int32, v176 : (string [])) = v118.l1, v118.l2
            let v180 : unit = ()
            let _let'_v180 =
                seq {
                    for i = 0 to v176.Length - 1 do yield v176.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v183 : string seq = _let'_v180 
            let v189 : char = method64()
            let v191 : (char -> string) = _.ToString()
            let v192 : string = v191 v189
            let v196 : bool = v192 = "\n"
            let v198 : string =
                if v196 then
                    method65(v192)
                else
                    v192
            let v199 : (string -> (string seq -> string)) = String.concat
            let v200 : (string seq -> string) = v199 v198
            v200 v183
        else
            let v204 : string = "std::fs::canonicalize(&*$0)"
            let v205 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v204 
            (* run_target_args'
            let v207 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v208 : string = "$0.unwrap()"
            let v209 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v205 v208 
            let _run_target_args'_v207 = v209 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v210 : string = "$0.unwrap()"
            let v211 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v205 v210 
            let _run_target_args'_v207 = v211 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v212 : string = "$0.unwrap()"
            let v213 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v205 v212 
            let _run_target_args'_v207 = v213 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v214 : std_path_PathBuf = match v205 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v207 = v214 
            #endif
#if FABLE_COMPILER_PYTHON
            let v215 : std_path_PathBuf = match v205 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v207 = v215 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v216 : std_path_PathBuf = match v205 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v207 = v216 
            #endif
#else
            let v217 : std_path_PathBuf = match v205 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v207 = v217 
            #endif
            let v218 : std_path_PathBuf = _run_target_args'_v207 
            (* run_target_args'
            let v225 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v226 : string = "$0.display()"
            let v227 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v218 v226 
            let _run_target_args'_v225 = v227 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v228 : string = "$0.display()"
            let v229 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v218 v228 
            let _run_target_args'_v225 = v229 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v230 : string = "$0.display()"
            let v231 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v218 v230 
            let _run_target_args'_v225 = v231 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v233 : std_path_Display = v218 |> unbox<std_path_Display>
            let _run_target_args'_v225 = v233 
            #endif
#if FABLE_COMPILER_PYTHON
            let v237 : std_path_Display = v218 |> unbox<std_path_Display>
            let _run_target_args'_v225 = v237 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v241 : std_path_Display = v218 |> unbox<std_path_Display>
            let _run_target_args'_v225 = v241 
            #endif
#else
            let v245 : std_path_Display = v218 |> unbox<std_path_Display>
            let _run_target_args'_v225 = v245 
            #endif
            let v248 : std_path_Display = _run_target_args'_v225 
            (* run_target_args'
            let v258 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v259 : string = "format!(\"{}\", $0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v248 v259 
            let _run_target_args'_v258 = v260 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v261 : string = "format!(\"{}\", $0)"
            let v262 : std_string_String = Fable.Core.RustInterop.emitRustExpr v248 v261 
            let _run_target_args'_v258 = v262 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v263 : string = "format!(\"{}\", $0)"
            let v264 : std_string_String = Fable.Core.RustInterop.emitRustExpr v248 v263 
            let _run_target_args'_v258 = v264 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v266 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v258 = v266 
            #endif
#if FABLE_COMPILER_PYTHON
            let v270 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v258 = v270 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v274 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v258 = v274 
            #endif
#else
            let v278 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v258 = v278 
            #endif
            let v281 : std_string_String = _run_target_args'_v258 
            let v287 : string = "fable_library_rust::String_::fromString($0)"
            let v288 : string = Fable.Core.RustInterop.emitRustExpr v281 v287 
            v288
    let _run_target_args'_v5 = v289 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v291 : string = null |> unbox<string>
    let _run_target_args'_v5 = v291 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v295 : string = null |> unbox<string>
    let _run_target_args'_v5 = v295 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v299 : string = null |> unbox<string>
    let _run_target_args'_v5 = v299 
    #endif
#if FABLE_COMPILER_PYTHON
    let v303 : string = null |> unbox<string>
    let _run_target_args'_v5 = v303 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v307 : string = null |> unbox<string>
    let _run_target_args'_v5 = v307 
    #endif
#else
    let v310 : (string -> string) = System.IO.Path.GetFullPath
    let v311 : string = v310 v0
    let _run_target_args'_v5 = v311 
    #endif
    let v312 : string = _run_target_args'_v5 
    v312
and method66 () : string =
    
    
    
    
    
    let v1 : string = "Debug"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_blue"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_blue"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_blue"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[94m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[94m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[94m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[94m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method68 (v0 : string, v1 : string, v2 : string, v3 : string) : string =
    let v4 : string = method14()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure8(v5, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v17 : string = "source_dir"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure8(v5, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure8(v5, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure8(v5, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure8(v5, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v56 : string = "dist_dir"
    let v57 : string = $"{v56}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v5, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v66 : string = $"{v27}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v5, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v75 : string = $"{v1}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure8(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v84 : string = $"{v46}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure8(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = "cache_dir"
    let v94 : string = $"{v93}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure8(v5, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v103 : string = $"{v27}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure8(v5, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v2}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure8(v5, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v46}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v5, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "hangul_spec"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure8(v5, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v27}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure8(v5, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v3}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure8(v5, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = " }"
    let v159 : string = $"{v158}"
    let v162 : unit = ()
    let v163 : (unit -> unit) = closure8(v5, v159)
    let v164 : unit = (fun () -> v163 (); v162) ()
    let v167 : string = v5.l0
    v167
and method67 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string) : string =
    let v12 : string = method68(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v15 : string = "documents.run"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method18(v16)
and closure24 (v0 : string, v1 : string, v2 : string, v3 : string) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method7(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure6()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v29 : Mut0, v30 : Mut1, v31 : Mut2, v32 : Mut3, v33 : Mut4, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method8(v29, v30, v31, v32, v33, v34)
        let v48 : string = method66()
        let v49 : string = method67(v29, v30, v31, v32, v33, v34, v47, v48, v1, v2, v3, v0)
        method19(v49)
and closure26 () (v0 : std_io_Error) : std_string_String =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _run_target_args'_v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v17 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v21 
    #endif
#else
    let v25 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v25 
    #endif
    let v28 : std_string_String = _run_target_args'_v5 
    v28
and method69 () : (std_io_Error -> std_string_String) =
    closure26()
and closure27 () (v0 : std_fs_FileType) : US11 =
    US11_0(v0)
and method70 () : (std_fs_FileType -> US11) =
    closure27()
and closure28 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and method71 () : (std_string_String -> US11) =
    closure28()
and closure25 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(/*"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "*/ async { /*"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "*/ ()"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : string = "true; let __future_init = Box::pin(/*"
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "*/ async move { /*"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : string = "*/ ()"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "$0"
    let v14 : async_walkdir_DirEntry = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let v15 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v14))"
    let v16 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : string = "v16.await"
    let v18 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : (std_io_Error -> std_string_String) = method69()
    (* run_target_args'
    let v21 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : string = "$0.map_err(|x| $1(x))"
    let v23 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v22 
    let _run_target_args'_v21 = v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = "$0.map_err(|x| $1(x))"
    let v25 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v24 
    let _run_target_args'_v21 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = "$0.map_err(|x| $1(x))"
    let v27 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v26 
    let _run_target_args'_v21 = v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Result<std_fs_FileType, std_string_String> = match v18 with Ok x -> Ok x | Error x -> Error (v19 x)
    let _run_target_args'_v21 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v29 : Result<std_fs_FileType, std_string_String> = match v18 with Ok x -> Ok x | Error x -> Error (v19 x)
    let _run_target_args'_v21 = v29 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v30 : Result<std_fs_FileType, std_string_String> = match v18 with Ok x -> Ok x | Error x -> Error (v19 x)
    let _run_target_args'_v21 = v30 
    #endif
#else
    let v31 : Result<std_fs_FileType, std_string_String> = match v18 with Ok x -> Ok x | Error x -> Error (v19 x)
    let _run_target_args'_v21 = v31 
    #endif
    let v32 : Result<std_fs_FileType, std_string_String> = _run_target_args'_v21 
    let v35 : (std_fs_FileType -> US11) = method70()
    let v36 : (std_string_String -> US11) = method71()
    let v38 : US11 = match v32 with Ok x -> v35 x | Error x -> v36 x
    let v216 : US12 =
        match v38 with
        | US11_0(v41) -> (* Ok *)
            let v42 : string = "std::fs::FileType::is_dir(&$0)"
            let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
            if v43 then
                US12_0
            else
                let v45 : string = "async_walkdir::DirEntry::path(&$0)"
                let v46 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v45 
                (* run_target_args'
                let v51 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v52 : string = "$0.display()"
                let v53 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v46 v52 
                let _run_target_args'_v51 = v53 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v54 : string = "$0.display()"
                let v55 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v46 v54 
                let _run_target_args'_v51 = v55 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v56 : string = "$0.display()"
                let v57 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v46 v56 
                let _run_target_args'_v51 = v57 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v59 : std_path_Display = v46 |> unbox<std_path_Display>
                let _run_target_args'_v51 = v59 
                #endif
#if FABLE_COMPILER_PYTHON
                let v63 : std_path_Display = v46 |> unbox<std_path_Display>
                let _run_target_args'_v51 = v63 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v67 : std_path_Display = v46 |> unbox<std_path_Display>
                let _run_target_args'_v51 = v67 
                #endif
#else
                let v71 : std_path_Display = v46 |> unbox<std_path_Display>
                let _run_target_args'_v51 = v71 
                #endif
                let v74 : std_path_Display = _run_target_args'_v51 
                (* run_target_args'
                let v84 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v85 : string = "format!(\"{}\", $0)"
                let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v85 
                let _run_target_args'_v84 = v86 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v87 : string = "format!(\"{}\", $0)"
                let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v87 
                let _run_target_args'_v84 = v88 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v89 : string = "format!(\"{}\", $0)"
                let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v89 
                let _run_target_args'_v84 = v90 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v92 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v84 = v92 
                #endif
#if FABLE_COMPILER_PYTHON
                let v96 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v84 = v96 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v100 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v84 = v100 
                #endif
#else
                let v104 : std_string_String = null |> unbox<std_string_String>
                let _run_target_args'_v84 = v104 
                #endif
                let v107 : std_string_String = _run_target_args'_v84 
                let v113 : string = "fable_library_rust::String_::fromString($0)"
                let v114 : string = Fable.Core.RustInterop.emitRustExpr v107 v113 
                let v116 : string = ".md"
                let v117 : bool = v114.EndsWith (v116, false, null)
                let v120 : bool = v117 = false
                let v126 : bool =
                    if v120 then
                        true
                    else
                        let v122 : string = ".hangul.md"
                        let v123 : bool = v114.EndsWith (v122, false, null)
                        v123
                if v126 then
                    US12_0
                else
                    US12_2
        | _ ->
            let v131 : string = "async_walkdir::DirEntry::path(&$0)"
            let v132 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v131 
            (* run_target_args'
            let v137 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v138 : string = "$0.display()"
            let v139 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v132 v138 
            let _run_target_args'_v137 = v139 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v140 : string = "$0.display()"
            let v141 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v132 v140 
            let _run_target_args'_v137 = v141 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v142 : string = "$0.display()"
            let v143 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v132 v142 
            let _run_target_args'_v137 = v143 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v145 : std_path_Display = v132 |> unbox<std_path_Display>
            let _run_target_args'_v137 = v145 
            #endif
#if FABLE_COMPILER_PYTHON
            let v149 : std_path_Display = v132 |> unbox<std_path_Display>
            let _run_target_args'_v137 = v149 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v153 : std_path_Display = v132 |> unbox<std_path_Display>
            let _run_target_args'_v137 = v153 
            #endif
#else
            let v157 : std_path_Display = v132 |> unbox<std_path_Display>
            let _run_target_args'_v137 = v157 
            #endif
            let v160 : std_path_Display = _run_target_args'_v137 
            (* run_target_args'
            let v170 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v171 : string = "format!(\"{}\", $0)"
            let v172 : std_string_String = Fable.Core.RustInterop.emitRustExpr v160 v171 
            let _run_target_args'_v170 = v172 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v173 : string = "format!(\"{}\", $0)"
            let v174 : std_string_String = Fable.Core.RustInterop.emitRustExpr v160 v173 
            let _run_target_args'_v170 = v174 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v175 : string = "format!(\"{}\", $0)"
            let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v160 v175 
            let _run_target_args'_v170 = v176 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v178 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v170 = v178 
            #endif
#if FABLE_COMPILER_PYTHON
            let v182 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v170 = v182 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v186 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v170 = v186 
            #endif
#else
            let v190 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v170 = v190 
            #endif
            let v193 : std_string_String = _run_target_args'_v170 
            let v199 : string = "fable_library_rust::String_::fromString($0)"
            let v200 : string = Fable.Core.RustInterop.emitRustExpr v193 v199 
            let v202 : string = ".md"
            let v203 : bool = v200.EndsWith (v202, false, null)
            let v206 : bool = v203 = false
            let v212 : bool =
                if v206 then
                    true
                else
                    let v208 : string = ".hangul.md"
                    let v209 : bool = v200.EndsWith (v208, false, null)
                    v209
            if v212 then
                US12_0
            else
                US12_2
    let v217 : string = ""
    let v218 : string = "}"
    let v219 : string = v217 + v218 
    let x = v216 //
    let v220 : _ = x
    let v221 : unit = ()
    (* run_target_args'
    let v222 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v223 : string = $"true; let _fix_closure_v221 = $0"
    let v224 : bool = Fable.Core.RustInterop.emitRustExpr v220 v223 
    let _run_target_args'_v222 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v225 : string = $"true; let _fix_closure_v221 = $0"
    let v226 : bool = Fable.Core.RustInterop.emitRustExpr v220 v225 
    let _run_target_args'_v222 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v227 : string = $"true; let _fix_closure_v221 = $0"
    let v228 : bool = Fable.Core.RustInterop.emitRustExpr v220 v227 
    let _run_target_args'_v222 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v222 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v222 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v222 = false 
    #endif
#else
    let _run_target_args'_v222 = false 
    #endif
    let v229 : bool = _run_target_args'_v222 
    let v231 : string = $"true; _fix_closure_v221 " + v219 + "); " + v217 + " // rust.fix_closure'"
    let v232 : bool = Fable.Core.RustInterop.emitRustExpr () v231 
    let v233 : string = "__future_init"
    let v234 : _ = Fable.Core.RustInterop.emitRustExpr () v233 
    let v235 : string = "v234"
    let v236 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US12>>, Send<Dyn<std_future_Future<US12>>>>>> = Fable.Core.RustInterop.emitRustExpr () v235 
    let v237 : string = "v236.await"
    let v238 : US12 = Fable.Core.RustInterop.emitRustExpr () v237 
    let v247 : async_walkdir_Filtering =
        match v238 with
        | US12_2 -> (* Continue *)
            let v243 : string = "async_walkdir::Filtering::Continue"
            let v244 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v243 
            v244
        | US12_0 -> (* Ignore *)
            let v239 : string = "async_walkdir::Filtering::Ignore"
            let v240 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v239 
            v240
        | US12_1 -> (* IgnoreDir *)
            let v241 : string = "async_walkdir::Filtering::IgnoreDir"
            let v242 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v241 
            v242
    let v248 : string = v217 + v218 
    let x = v247 //
    let v249 : _ = x
    let v250 : unit = ()
    (* run_target_args'
    let v251 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v252 : string = $"true; let _fix_closure_v250 = $0"
    let v253 : bool = Fable.Core.RustInterop.emitRustExpr v249 v252 
    let _run_target_args'_v251 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v254 : string = $"true; let _fix_closure_v250 = $0"
    let v255 : bool = Fable.Core.RustInterop.emitRustExpr v249 v254 
    let _run_target_args'_v251 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v256 : string = $"true; let _fix_closure_v250 = $0"
    let v257 : bool = Fable.Core.RustInterop.emitRustExpr v249 v256 
    let _run_target_args'_v251 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v251 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v251 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v251 = false 
    #endif
#else
    let _run_target_args'_v251 = false 
    #endif
    let v258 : bool = _run_target_args'_v251 
    let v260 : string = $"true; _fix_closure_v250 " + v248 + "); " + v217 + " // rust.fix_closure'"
    let v261 : bool = Fable.Core.RustInterop.emitRustExpr () v260 
    let v262 : string = "__future_init"
    let v263 : _ = Fable.Core.RustInterop.emitRustExpr () v262 
    let v264 : string = "v263"
    let v265 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v264 
    v265
and closure30 () (v0 : async_walkdir_Error) : std_string_String =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _run_target_args'_v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v17 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v21 
    #endif
#else
    let v25 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v25 
    #endif
    let v28 : std_string_String = _run_target_args'_v5 
    v28
and method73 () : (async_walkdir_Error -> std_string_String) =
    closure30()
and closure31 () (v0 : async_walkdir_DirEntry) : US13 =
    US13_0(v0)
and method74 () : (async_walkdir_DirEntry -> US13) =
    closure31()
and closure32 () (v0 : std_string_String) : US13 =
    US13_1(v0)
and method75 () : (std_string_String -> US13) =
    closure32()
and method76 () : string =
    
    
    
    
    
    let v1 : string = "Critical"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_red"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_red"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_red"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[91m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[91m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[91m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[91m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method78 (v0 : std_string_String) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "error"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    (* run_target_args'
    let v37 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _run_target_args'_v37 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v37 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v37 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = $"%A{v0}"
    let _run_target_args'_v37 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v37 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v37 = v59 
    #endif
#else
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v37 = v63 
    #endif
    let v66 : string = _run_target_args'_v37 
    let v73 : string = $"{v66}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v2, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v2, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v2.l0
    v91
and method77 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.run / stream_filter_map"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure33 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method77(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and closure29 () (v0 : Result<async_walkdir_DirEntry, async_walkdir_Error>) : string option =
    let v1 : (async_walkdir_Error -> std_string_String) = method73()
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "$0.map_err(|x| $1(x))"
    let v5 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v4 
    let _run_target_args'_v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v6 
    let _run_target_args'_v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v8 
    let _run_target_args'_v3 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _run_target_args'_v3 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _run_target_args'_v3 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _run_target_args'_v3 = v12 
    #endif
#else
    let v13 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _run_target_args'_v3 = v13 
    #endif
    let v14 : Result<async_walkdir_DirEntry, std_string_String> = _run_target_args'_v3 
    let v17 : (async_walkdir_DirEntry -> US13) = method74()
    let v18 : (std_string_String -> US13) = method75()
    let v20 : US13 = match v14 with Ok x -> v17 x | Error x -> v18 x
    let v147 : US5 =
        match v20 with
        | US13_1(v95) -> (* Error *)
            let v96 : unit = ()
            let v97 : (unit -> unit) = closure33(v95)
            let v98 : unit = (fun () -> v97 (); v96) ()
            US5_1
        | US13_0(v23) -> (* Ok *)
            let v24 : string = "async_walkdir::DirEntry::path(&$0)"
            let v25 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v23 v24 
            (* run_target_args'
            let v30 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v31 : string = "$0.display()"
            let v32 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v25 v31 
            let _run_target_args'_v30 = v32 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v33 : string = "$0.display()"
            let v34 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v25 v33 
            let _run_target_args'_v30 = v34 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v35 : string = "$0.display()"
            let v36 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v25 v35 
            let _run_target_args'_v30 = v36 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v38 : std_path_Display = v25 |> unbox<std_path_Display>
            let _run_target_args'_v30 = v38 
            #endif
#if FABLE_COMPILER_PYTHON
            let v42 : std_path_Display = v25 |> unbox<std_path_Display>
            let _run_target_args'_v30 = v42 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v46 : std_path_Display = v25 |> unbox<std_path_Display>
            let _run_target_args'_v30 = v46 
            #endif
#else
            let v50 : std_path_Display = v25 |> unbox<std_path_Display>
            let _run_target_args'_v30 = v50 
            #endif
            let v53 : std_path_Display = _run_target_args'_v30 
            (* run_target_args'
            let v63 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v64 : string = "format!(\"{}\", $0)"
            let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v64 
            let _run_target_args'_v63 = v65 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v66 : string = "format!(\"{}\", $0)"
            let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v66 
            let _run_target_args'_v63 = v67 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v68 : string = "format!(\"{}\", $0)"
            let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v68 
            let _run_target_args'_v63 = v69 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v71 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v63 = v71 
            #endif
#if FABLE_COMPILER_PYTHON
            let v75 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v63 = v75 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v79 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v63 = v79 
            #endif
#else
            let v83 : std_string_String = null |> unbox<std_string_String>
            let _run_target_args'_v63 = v83 
            #endif
            let v86 : std_string_String = _run_target_args'_v63 
            let v92 : string = "fable_library_rust::String_::fromString($0)"
            let v93 : string = Fable.Core.RustInterop.emitRustExpr v86 v92 
            US5_0(v93)
    match v147 with
    | US5_1 -> (* None *)
        let v153 : string option = None
        v153
    | US5_0(v148) -> (* Some *)
        let v150 : string option = Some v148 
        v150
and method72 () : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) =
    closure29()
and method80 (v0 : unativeint) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "files_len"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    (* run_target_args'
    let v37 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _run_target_args'_v37 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v37 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v37 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = $"%A{v0}"
    let _run_target_args'_v37 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v37 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v37 = v59 
    #endif
#else
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v37 = v63 
    #endif
    let v66 : string = _run_target_args'_v37 
    let v73 : string = $"{v66}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v2, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v2, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v2.l0
    v91
and method79 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method80(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.run"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure34 (v0 : Vec<string>) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method66()
        let v46 : string = "$0.len()"
        let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v46 
        let v48 : string = method79(v26, v27, v28, v29, v30, v31, v44, v45, v47)
        method19(v48)
and method81 () : string =
    let v0 : string = ""
    v0
and method82 (v0 : string) : string =
    let v1 : string = method61(v0)
    method38(v1)
and method84 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v0
and method86 () : string =
    let v0 : string = ""
    v0
and closure38 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure37 () (v0 : char) : (UH0 -> UH0) =
    closure38(v0)
and method87 () : (char -> (UH0 -> UH0)) =
    closure37()
and method88 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
    match v0 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '\n' = v4
        let struct (v9 : int32, v10 : int32) =
            if v6 then
                let v7 : int32 = v2 + 1
                struct (v7, 1)
            else
                let v8 : int32 = v3 + 1
                struct (v2, v8)
        let v27 : System.Text.StringBuilder =
            if v6 then
                let v12 : (unit -> System.Text.StringBuilder) = v1.Clear
                let v13 : System.Text.StringBuilder = v12 ()
                v1
            else
                let v18 : (char -> string) = _.ToString()
                let v19 : string = v18 v4
                let v23 : (string -> System.Text.StringBuilder) = v1.Append
                let v24 : System.Text.StringBuilder = v23 v19
                v1
        method88(v5, v27, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure39 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : bool = v1 >= v0
    if v3 then
        v2
    else
        let v4 : int32 = v1 + 1
        let v5 : (string -> string) = method89(v0, v4)
        let v6 : string = " "
        let v7 : string = v2 + v6 
        v5 v7
and method89 (v0 : int32, v1 : int32) : (string -> string) =
    closure39(v0, v1)
and closure36 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
    let v4 : bool = "" = v0
    if v4 then
        let v6 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v1, v2, v3)}"
        US15_1(v6)
    else
        let v10 : char = v0.[int 0]
        let v11 : bool = v10 = '"'
        if v11 then
            let v13 : (string -> int32) = String.length
            let v14 : int32 = v13 v0
            let v22 : int32 = 1 |> int32 
            let v35 : int32 = v14 |> int32 
            let v43 : int32 = v35 - 1
            let v45 : string = v0.[int v22..int v43]
            let v50 : (char -> string) = _.ToString()
            let v51 : string = v50 v10
            let v54 : int32 = v51.Length
            let v55 : (char []) = Array.zeroCreate<char> (v54)
            let v56 : Mut6 = {l0 = 0} : Mut6
            while method63(v54, v56) do
                let v58 : int32 = v56.l0
                let v59 : char = v51.[int v58]
                v55.[int v58] <- v59
                let v60 : int32 = v58 + 1
                v56.l0 <- v60
                ()
            let v62 : char list = v55 |> Array.toList
            let v70 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v71 : (char -> (UH0 -> UH0)) = method87()
            let v72 : (char list -> (UH0 -> UH0)) = v70 v71
            let v73 : (UH0 -> UH0) = v72 v62
            let v74 : UH0 = UH0_0
            let v75 : UH0 = v73 v74
            let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method88(v75, v1, v2, v3)
            US15_0(v10, v45, v104, v105, v106)
        else
            let v109 : string = "\n"
            let v110 : int32 = v0.IndexOf v109 
            let v113 : int32 = v110 - 1
            let v114 : bool = -2 = v113
            let v122 : int32 =
                if v114 then
                    let v116 : (string -> int32) = String.length
                    let v117 : int32 = v116 v0
                    let v120 : int32 = v117 + 1
                    v120
                else
                    let v121 : int32 = v113 + 1
                    v121
            let v128 : int32 = 0 |> int32 
            let v141 : int32 = v122 |> int32 
            let v149 : int32 = v141 - 1
            let v151 : string = v0.[int v128..int v149]
            let v156 : string = $"parsing.p_char / expected: '{'"'}' / line: {v2} / col: {v3}
{v1}{v151}"
            let v159 : int32 = v3 - 1
            let v160 : int32 = 0
            let v161 : (string -> string) = method89(v159, v160)
            let v162 : string = ""
            let v163 : string = v161 v162
            let v164 : string = "^"
            let v165 : string = v163 + v164 
            let v167 : string = $"{v156}
{v165}
"
            US15_1(v167)
and closure40 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
    let v4 : bool = "" = v0
    if v4 then
        let v6 : string = $"parsing.p_char / unexpected end of input / c: '{'''}' / s: %A{struct (v1, v2, v3)}"
        US15_1(v6)
    else
        let v10 : char = v0.[int 0]
        let v11 : bool = v10 = '''
        if v11 then
            let v13 : (string -> int32) = String.length
            let v14 : int32 = v13 v0
            let v22 : int32 = 1 |> int32 
            let v35 : int32 = v14 |> int32 
            let v43 : int32 = v35 - 1
            let v45 : string = v0.[int v22..int v43]
            let v50 : (char -> string) = _.ToString()
            let v51 : string = v50 v10
            let v54 : int32 = v51.Length
            let v55 : (char []) = Array.zeroCreate<char> (v54)
            let v56 : Mut6 = {l0 = 0} : Mut6
            while method63(v54, v56) do
                let v58 : int32 = v56.l0
                let v59 : char = v51.[int v58]
                v55.[int v58] <- v59
                let v60 : int32 = v58 + 1
                v56.l0 <- v60
                ()
            let v62 : char list = v55 |> Array.toList
            let v70 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v71 : (char -> (UH0 -> UH0)) = method87()
            let v72 : (char list -> (UH0 -> UH0)) = v70 v71
            let v73 : (UH0 -> UH0) = v72 v62
            let v74 : UH0 = UH0_0
            let v75 : UH0 = v73 v74
            let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method88(v75, v1, v2, v3)
            US15_0(v10, v45, v104, v105, v106)
        else
            let v109 : string = "\n"
            let v110 : int32 = v0.IndexOf v109 
            let v113 : int32 = v110 - 1
            let v114 : bool = -2 = v113
            let v122 : int32 =
                if v114 then
                    let v116 : (string -> int32) = String.length
                    let v117 : int32 = v116 v0
                    let v120 : int32 = v117 + 1
                    v120
                else
                    let v121 : int32 = v113 + 1
                    v121
            let v128 : int32 = 0 |> int32 
            let v141 : int32 = v122 |> int32 
            let v149 : int32 = v141 - 1
            let v151 : string = v0.[int v128..int v149]
            let v156 : string = $"parsing.p_char / expected: '{'''}' / line: {v2} / col: {v3}
{v1}{v151}"
            let v159 : int32 = v3 - 1
            let v160 : int32 = 0
            let v161 : (string -> string) = method89(v159, v160)
            let v162 : string = ""
            let v163 : string = v161 v162
            let v164 : string = "^"
            let v165 : string = v163 + v164 
            let v167 : string = $"{v156}
{v165}
"
            US15_1(v167)
and method90 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US15 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US15 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US15_1(v13) -> (* Error *)
            method90(v0, v1, v6)
        | US15_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "parsing.choice / no parsers succeeded"
        US15_1(v3)
and method91 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US17 =
            if v3 then
                US17_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US17_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    US17_1
        let v15 : char =
            match v11 with
            | US17_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US17_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method91(v0, v17)
and method92 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v145 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = ''' :: v6 
            let v12 : char list = '"' :: v8 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v12
            let v21 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US15_1(v21)
        else
            let v25 : char = v1.[int 0]
            let v26 : int64 = 0L
            let v27 : bool = method91(v25, v26)
            let v28 : bool = v27 = false
            if v28 then
                let v30 : (string -> int32) = String.length
                let v31 : int32 = v30 v1
                let v39 : int32 = 1 |> int32 
                let v52 : int32 = v31 |> int32 
                let v60 : int32 = v52 - 1
                let v62 : string = v1.[int v39..int v60]
                let v67 : (char -> string) = _.ToString()
                let v68 : string = v67 v25
                let v71 : int32 = v68.Length
                let v72 : (char []) = Array.zeroCreate<char> (v71)
                let v73 : Mut6 = {l0 = 0} : Mut6
                while method63(v71, v73) do
                    let v75 : int32 = v73.l0
                    let v76 : char = v68.[int v75]
                    v72.[int v75] <- v76
                    let v77 : int32 = v75 + 1
                    v73.l0 <- v77
                    ()
                let v79 : char list = v72 |> Array.toList
                let v87 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v88 : (char -> (UH0 -> UH0)) = method87()
                let v89 : (char list -> (UH0 -> UH0)) = v87 v88
                let v90 : (UH0 -> UH0) = v89 v79
                let v91 : UH0 = UH0_0
                let v92 : UH0 = v90 v91
                let struct (v121 : System.Text.StringBuilder, v122 : int32, v123 : int32) = method88(v92, v2, v3, v4)
                US15_0(v25, v62, v121, v122, v123)
            else
                let v125 : char list = []
                let v127 : char list = ''' :: v125 
                let v131 : char list = '"' :: v127 
                let v135 : (char list -> (char [])) = List.toArray
                let v136 : (char []) = v135 v131
                let v140 : string = $"parsing.none_of / unexpected char: '{v25}' / chars: %A{v136} / s: %A{struct (v2, v3, v4)}"
                US15_1(v140)
    let v157 : US15 =
        match v145 with
        | US15_1(v154) -> (* Error *)
            US15_1(v154)
        | US15_0(v146, v147, v148, v149, v150) -> (* Ok *)
            let v151 : bool = '\\' = v146
            let v152 : char =
                if v151 then
                    '/'
                else
                    v146
            US15_0(v152, v147, v148, v149, v150)
    match v157 with
    | US15_1(v174) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v158, v159, v160, v161, v162) -> (* Ok *)
        let v164 : (char -> string) = _.ToString()
        let v165 : string = v164 v158
        let v168 : string = v0 + v165 
        method92(v168, v159, v160, v161, v162)
and method93 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US15 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US15 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US15_1(v15) -> (* Error *)
            method93(v0, v1, v2, v3, v8)
        | US15_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US15_1(v5)
and method94 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US17 =
            if v3 then
                US17_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US17_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US17_0(' ')
                    else
                        let v11 : int64 = v8 - 1L
                        US17_1
        let v19 : char =
            match v15 with
            | US17_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US17_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method94(v0, v21)
and method95 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v153 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = ' ' :: v6 
            let v12 : char list = ''' :: v8 
            let v16 : char list = '"' :: v12 
            let v20 : (char list -> (char [])) = List.toArray
            let v21 : (char []) = v20 v16
            let v25 : string = $"parsing.none_of / unexpected end of input / chars: %A{v21} / s: %A{struct (v2, v3, v4)}"
            US15_1(v25)
        else
            let v29 : char = v1.[int 0]
            let v30 : int64 = 0L
            let v31 : bool = method94(v29, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v34 : (string -> int32) = String.length
                let v35 : int32 = v34 v1
                let v43 : int32 = 1 |> int32 
                let v56 : int32 = v35 |> int32 
                let v64 : int32 = v56 - 1
                let v66 : string = v1.[int v43..int v64]
                let v71 : (char -> string) = _.ToString()
                let v72 : string = v71 v29
                let v75 : int32 = v72.Length
                let v76 : (char []) = Array.zeroCreate<char> (v75)
                let v77 : Mut6 = {l0 = 0} : Mut6
                while method63(v75, v77) do
                    let v79 : int32 = v77.l0
                    let v80 : char = v72.[int v79]
                    v76.[int v79] <- v80
                    let v81 : int32 = v79 + 1
                    v77.l0 <- v81
                    ()
                let v83 : char list = v76 |> Array.toList
                let v91 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v92 : (char -> (UH0 -> UH0)) = method87()
                let v93 : (char list -> (UH0 -> UH0)) = v91 v92
                let v94 : (UH0 -> UH0) = v93 v83
                let v95 : UH0 = UH0_0
                let v96 : UH0 = v94 v95
                let struct (v125 : System.Text.StringBuilder, v126 : int32, v127 : int32) = method88(v96, v2, v3, v4)
                US15_0(v29, v66, v125, v126, v127)
            else
                let v129 : char list = []
                let v131 : char list = ' ' :: v129 
                let v135 : char list = ''' :: v131 
                let v139 : char list = '"' :: v135 
                let v143 : (char list -> (char [])) = List.toArray
                let v144 : (char []) = v143 v139
                let v148 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v144} / s: %A{struct (v2, v3, v4)}"
                US15_1(v148)
    let v165 : US15 =
        match v153 with
        | US15_1(v162) -> (* Error *)
            US15_1(v162)
        | US15_0(v154, v155, v156, v157, v158) -> (* Ok *)
            let v159 : bool = '\\' = v154
            let v160 : char =
                if v159 then
                    '/'
                else
                    v154
            US15_0(v160, v155, v156, v157, v158)
    match v165 with
    | US15_1(v182) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v166, v167, v168, v169, v170) -> (* Ok *)
        let v172 : (char -> string) = _.ToString()
        let v173 : string = v172 v166
        let v176 : string = v0 + v173 
        method95(v176, v167, v168, v169, v170)
and method96 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = ' ' = v4
        if v5 then
            let v6 : int32 = v1 + 1
            method96(v0, v6)
        else
            v1
and method97 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v108 : US15 =
        if v5 then
            let v7 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
            US15_1(v7)
        else
            let v11 : char = v1.[int 0]
            let v13 : (string -> int32) = String.length
            let v14 : int32 = v13 v1
            let v22 : int32 = 1 |> int32 
            let v35 : int32 = v14 |> int32 
            let v43 : int32 = v35 - 1
            let v45 : string = v1.[int v22..int v43]
            let v50 : (char -> string) = _.ToString()
            let v51 : string = v50 v11
            let v54 : int32 = v51.Length
            let v55 : (char []) = Array.zeroCreate<char> (v54)
            let v56 : Mut6 = {l0 = 0} : Mut6
            while method63(v54, v56) do
                let v58 : int32 = v56.l0
                let v59 : char = v51.[int v58]
                v55.[int v58] <- v59
                let v60 : int32 = v58 + 1
                v56.l0 <- v60
                ()
            let v62 : char list = v55 |> Array.toList
            let v70 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v71 : (char -> (UH0 -> UH0)) = method87()
            let v72 : (char list -> (UH0 -> UH0)) = v70 v71
            let v73 : (UH0 -> UH0) = v72 v62
            let v74 : UH0 = UH0_0
            let v75 : UH0 = v73 v74
            let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method88(v75, v2, v3, v4)
            US15_0(v11, v45, v104, v105, v106)
    match v108 with
    | US15_1(v125) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v109, v110, v111, v112, v113) -> (* Ok *)
        let v115 : (char -> string) = _.ToString()
        let v116 : string = v115 v109
        let v119 : string = v0 + v116 
        method97(v119, v110, v111, v112, v113)
and method85 (v0 : string) : US14 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v2 : (string -> string option) = Option.ofObj
    let v3 : string option = v2 v0
    v3 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v4 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v9 : string = ""
    let v10 : string = v4 |> Option.defaultValue v9 
    let v13 : string = method86()
    let v15 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v16 : System.Text.StringBuilder = v15 v13
    let v19 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure36()
    let v20 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure40()
    let v21 : UH1 = UH1_0
    let v22 : UH1 = UH1_1(v20, v21)
    let v23 : UH1 = UH1_1(v19, v22)
    let v24 : US15 = method90(v10, v16, v23)
    let v244 : US16 =
        match v24 with
        | US15_1(v241) -> (* Error *)
            US16_1(v241)
        | US15_0(v25, v26, v27, v28, v29) -> (* Ok *)
            let v30 : bool = "" = v26
            let v170 : US15 =
                if v30 then
                    let v31 : char list = []
                    let v33 : char list = ''' :: v31 
                    let v37 : char list = '"' :: v33 
                    let v41 : (char list -> (char [])) = List.toArray
                    let v42 : (char []) = v41 v37
                    let v46 : string = $"parsing.none_of / unexpected end of input / chars: %A{v42} / s: %A{struct (v27, v28, v29)}"
                    US15_1(v46)
                else
                    let v50 : char = v26.[int 0]
                    let v51 : int64 = 0L
                    let v52 : bool = method91(v50, v51)
                    let v53 : bool = v52 = false
                    if v53 then
                        let v55 : (string -> int32) = String.length
                        let v56 : int32 = v55 v26
                        let v64 : int32 = 1 |> int32 
                        let v77 : int32 = v56 |> int32 
                        let v85 : int32 = v77 - 1
                        let v87 : string = v26.[int v64..int v85]
                        let v92 : (char -> string) = _.ToString()
                        let v93 : string = v92 v50
                        let v96 : int32 = v93.Length
                        let v97 : (char []) = Array.zeroCreate<char> (v96)
                        let v98 : Mut6 = {l0 = 0} : Mut6
                        while method63(v96, v98) do
                            let v100 : int32 = v98.l0
                            let v101 : char = v93.[int v100]
                            v97.[int v100] <- v101
                            let v102 : int32 = v100 + 1
                            v98.l0 <- v102
                            ()
                        let v104 : char list = v97 |> Array.toList
                        let v112 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v113 : (char -> (UH0 -> UH0)) = method87()
                        let v114 : (char list -> (UH0 -> UH0)) = v112 v113
                        let v115 : (UH0 -> UH0) = v114 v104
                        let v116 : UH0 = UH0_0
                        let v117 : UH0 = v115 v116
                        let struct (v146 : System.Text.StringBuilder, v147 : int32, v148 : int32) = method88(v117, v27, v28, v29)
                        US15_0(v50, v87, v146, v147, v148)
                    else
                        let v150 : char list = []
                        let v152 : char list = ''' :: v150 
                        let v156 : char list = '"' :: v152 
                        let v160 : (char list -> (char [])) = List.toArray
                        let v161 : (char []) = v160 v156
                        let v165 : string = $"parsing.none_of / unexpected char: '{v50}' / chars: %A{v161} / s: %A{struct (v27, v28, v29)}"
                        US15_1(v165)
            let v182 : US15 =
                match v170 with
                | US15_1(v179) -> (* Error *)
                    US15_1(v179)
                | US15_0(v171, v172, v173, v174, v175) -> (* Ok *)
                    let v176 : bool = '\\' = v171
                    let v177 : char =
                        if v176 then
                            '/'
                        else
                            v171
                    US15_0(v177, v172, v173, v174, v175)
            let v202 : US16 =
                match v182 with
                | US15_1(v199) -> (* Error *)
                    US16_1(v199)
                | US15_0(v183, v184, v185, v186, v187) -> (* Ok *)
                    let v189 : (char -> string) = _.ToString()
                    let v190 : string = v189 v183
                    let struct (v193 : string, v194 : string, v195 : System.Text.StringBuilder, v196 : int32, v197 : int32) = method92(v190, v184, v185, v186, v187)
                    US16_0(v193, v194, v195, v196, v197)
            let v212 : US16 =
                match v202 with
                | US16_1(v209) -> (* Error *)
                    US16_0(v9, v26, v27, v28, v29)
                | US16_0(v203, v204, v205, v206, v207) -> (* Ok *)
                    US16_0(v203, v204, v205, v206, v207)
            match v212 with
            | US16_1(v236) -> (* Error *)
                let v237 : string = "parsing.between / expected content"
                US16_1(v237)
            | US16_0(v213, v214, v215, v216, v217) -> (* Ok *)
                let v218 : UH1 = UH1_0
                let v219 : UH1 = UH1_1(v20, v218)
                let v220 : UH1 = UH1_1(v19, v219)
                let v221 : US15 = method93(v214, v215, v216, v217, v220)
                match v221 with
                | US15_1(v228) -> (* Error *)
                    let v230 : string = $"parsing.between / expected closing delimiter / e: %A{v228} / input: %A{struct (v10, v16, 1, 1)} / rest1: %A{struct (v26, v27, v28, v29)} / rest2: %A{struct (v214, v215, v216, v217)}"
                    US16_1(v230)
                | US15_0(v222, v223, v224, v225, v226) -> (* Ok *)
                    US16_0(v213, v223, v224, v225, v226)
    let v510 : US16 =
        match v244 with
        | US16_1(v250) -> (* Error *)
            let v251 : bool = "" = v10
            let v401 : US15 =
                if v251 then
                    let v252 : char list = []
                    let v254 : char list = ' ' :: v252 
                    let v258 : char list = ''' :: v254 
                    let v262 : char list = '"' :: v258 
                    let v266 : (char list -> (char [])) = List.toArray
                    let v267 : (char []) = v266 v262
                    let v271 : string = $"parsing.none_of / unexpected end of input / chars: %A{v267} / s: %A{struct (v16, 1, 1)}"
                    US15_1(v271)
                else
                    let v275 : char = v10.[int 0]
                    let v276 : int64 = 0L
                    let v277 : bool = method94(v275, v276)
                    let v278 : bool = v277 = false
                    if v278 then
                        let v280 : (string -> int32) = String.length
                        let v281 : int32 = v280 v10
                        let v289 : int32 = 1 |> int32 
                        let v302 : int32 = v281 |> int32 
                        let v310 : int32 = v302 - 1
                        let v312 : string = v10.[int v289..int v310]
                        let v317 : (char -> string) = _.ToString()
                        let v318 : string = v317 v275
                        let v321 : int32 = v318.Length
                        let v322 : (char []) = Array.zeroCreate<char> (v321)
                        let v323 : Mut6 = {l0 = 0} : Mut6
                        while method63(v321, v323) do
                            let v325 : int32 = v323.l0
                            let v326 : char = v318.[int v325]
                            v322.[int v325] <- v326
                            let v327 : int32 = v325 + 1
                            v323.l0 <- v327
                            ()
                        let v329 : char list = v322 |> Array.toList
                        let v337 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v338 : (char -> (UH0 -> UH0)) = method87()
                        let v339 : (char list -> (UH0 -> UH0)) = v337 v338
                        let v340 : (UH0 -> UH0) = v339 v329
                        let v341 : UH0 = UH0_0
                        let v342 : UH0 = v340 v341
                        let v371 : int32 = 1
                        let v372 : int32 = 1
                        let struct (v373 : System.Text.StringBuilder, v374 : int32, v375 : int32) = method88(v342, v16, v371, v372)
                        US15_0(v275, v312, v373, v374, v375)
                    else
                        let v377 : char list = []
                        let v379 : char list = ' ' :: v377 
                        let v383 : char list = ''' :: v379 
                        let v387 : char list = '"' :: v383 
                        let v391 : (char list -> (char [])) = List.toArray
                        let v392 : (char []) = v391 v387
                        let v396 : string = $"parsing.none_of / unexpected char: '{v275}' / chars: %A{v392} / s: %A{struct (v16, 1, 1)}"
                        US15_1(v396)
            let v413 : US15 =
                match v401 with
                | US15_1(v410) -> (* Error *)
                    US15_1(v410)
                | US15_0(v402, v403, v404, v405, v406) -> (* Ok *)
                    let v407 : bool = '\\' = v402
                    let v408 : char =
                        if v407 then
                            '/'
                        else
                            v402
                    US15_0(v408, v403, v404, v405, v406)
            let v433 : US16 =
                match v413 with
                | US15_1(v430) -> (* Error *)
                    US16_1(v430)
                | US15_0(v414, v415, v416, v417, v418) -> (* Ok *)
                    let v420 : (char -> string) = _.ToString()
                    let v421 : string = v420 v414
                    let struct (v424 : string, v425 : string, v426 : System.Text.StringBuilder, v427 : int32, v428 : int32) = method95(v421, v415, v416, v417, v418)
                    US16_0(v424, v425, v426, v427, v428)
            match v433 with
            | US16_1(v439) -> (* Error *)
                let v440 : int32 = v10.Length
                let v441 : bool = v440 = 0
                let v448 : US18 =
                    if v441 then
                        US18_0(v10, v16, 1, 1)
                    else
                        let v444 : string = $"parsing.eof / expected end of input / input: %A{v10}"
                        US18_1(v444)
                let v457 : US16 =
                    match v448 with
                    | US18_1(v454) -> (* Error *)
                        US16_1(v454)
                    | US18_0(v449, v450, v451, v452) -> (* Ok *)
                        US16_0(v9, v449, v450, v451, v452)
                match v457 with
                | US16_1(v503) -> (* Error *)
                    US16_1(v503)
                | US16_0(v458, v459, v460, v461, v462) -> (* Ok *)
                    let v463 : int32 = 0
                    let v464 : int32 = method96(v459, v463)
                    let v466 : (string -> int32) = String.length
                    let v467 : int32 = v466 v459
                    let v475 : int32 = v464 |> int32 
                    let v488 : int32 = v467 |> int32 
                    let v496 : int32 = v488 - 1
                    let v498 : string = v459.[int v475..int v496]
                    US16_0(v458, v498, v460, v461, v462)
            | US16_0(v434, v435, v436, v437, v438) -> (* Ok *)
                v433
        | US16_0(v245, v246, v247, v248, v249) -> (* Ok *)
            v244
    let v854 : US19 =
        match v510 with
        | US16_1(v851) -> (* Error *)
            US19_1(v851)
        | US16_0(v511, v512, v513, v514, v515) -> (* Ok *)
            let v516 : bool = "" = v512
            let v683 : US15 =
                if v516 then
                    let v518 : string = $"parsing.p_char / unexpected end of input / c: '{' '}' / s: %A{struct (v513, v514, v515)}"
                    US15_1(v518)
                else
                    let v522 : char = v512.[int 0]
                    let v523 : bool = v522 = ' '
                    if v523 then
                        let v525 : (string -> int32) = String.length
                        let v526 : int32 = v525 v512
                        let v534 : int32 = 1 |> int32 
                        let v547 : int32 = v526 |> int32 
                        let v555 : int32 = v547 - 1
                        let v557 : string = v512.[int v534..int v555]
                        let v562 : (char -> string) = _.ToString()
                        let v563 : string = v562 v522
                        let v566 : int32 = v563.Length
                        let v567 : (char []) = Array.zeroCreate<char> (v566)
                        let v568 : Mut6 = {l0 = 0} : Mut6
                        while method63(v566, v568) do
                            let v570 : int32 = v568.l0
                            let v571 : char = v563.[int v570]
                            v567.[int v570] <- v571
                            let v572 : int32 = v570 + 1
                            v568.l0 <- v572
                            ()
                        let v574 : char list = v567 |> Array.toList
                        let v582 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v583 : (char -> (UH0 -> UH0)) = method87()
                        let v584 : (char list -> (UH0 -> UH0)) = v582 v583
                        let v585 : (UH0 -> UH0) = v584 v574
                        let v586 : UH0 = UH0_0
                        let v587 : UH0 = v585 v586
                        let struct (v616 : System.Text.StringBuilder, v617 : int32, v618 : int32) = method88(v587, v513, v514, v515)
                        US15_0(v522, v557, v616, v617, v618)
                    else
                        let v621 : string = "\n"
                        let v622 : int32 = v512.IndexOf v621 
                        let v625 : int32 = v622 - 1
                        let v626 : bool = -2 = v625
                        let v634 : int32 =
                            if v626 then
                                let v628 : (string -> int32) = String.length
                                let v629 : int32 = v628 v512
                                let v632 : int32 = v629 + 1
                                v632
                            else
                                let v633 : int32 = v625 + 1
                                v633
                        let v640 : int32 = 0 |> int32 
                        let v653 : int32 = v634 |> int32 
                        let v661 : int32 = v653 - 1
                        let v663 : string = v512.[int v640..int v661]
                        let v668 : string = $"parsing.p_char / expected: '{' '}' / line: {v514} / col: {v515}
{v513}{v663}"
                        let v671 : int32 = v515 - 1
                        let v672 : int32 = 0
                        let v673 : (string -> string) = method89(v671, v672)
                        let v674 : string = v673 v9
                        let v675 : string = "^"
                        let v676 : string = v674 + v675 
                        let v678 : string = $"{v668}
{v676}
"
                        US15_1(v678)
            let v695 : US20 =
                match v683 with
                | US15_1(v691) -> (* Error *)
                    let v692 : US17 = US17_1
                    US20_0(v692, v512, v513, v514, v515)
                | US15_0(v684, v685, v686, v687, v688) -> (* Ok *)
                    let v689 : US17 = US17_0(v684)
                    US20_0(v689, v685, v686, v687, v688)
            let v828 : US16 =
                match v695 with
                | US20_1(v825) -> (* Error *)
                    US16_1(v825)
                | US20_0(v696, v697, v698, v699, v700) -> (* Ok *)
                    let v701 : bool = "" = v697
                    let v804 : US15 =
                        if v701 then
                            let v703 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v698, v699, v700)}"
                            US15_1(v703)
                        else
                            let v707 : char = v697.[int 0]
                            let v709 : (string -> int32) = String.length
                            let v710 : int32 = v709 v697
                            let v718 : int32 = 1 |> int32 
                            let v731 : int32 = v710 |> int32 
                            let v739 : int32 = v731 - 1
                            let v741 : string = v697.[int v718..int v739]
                            let v746 : (char -> string) = _.ToString()
                            let v747 : string = v746 v707
                            let v750 : int32 = v747.Length
                            let v751 : (char []) = Array.zeroCreate<char> (v750)
                            let v752 : Mut6 = {l0 = 0} : Mut6
                            while method63(v750, v752) do
                                let v754 : int32 = v752.l0
                                let v755 : char = v747.[int v754]
                                v751.[int v754] <- v755
                                let v756 : int32 = v754 + 1
                                v752.l0 <- v756
                                ()
                            let v758 : char list = v751 |> Array.toList
                            let v766 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v767 : (char -> (UH0 -> UH0)) = method87()
                            let v768 : (char list -> (UH0 -> UH0)) = v766 v767
                            let v769 : (UH0 -> UH0) = v768 v758
                            let v770 : UH0 = UH0_0
                            let v771 : UH0 = v769 v770
                            let struct (v800 : System.Text.StringBuilder, v801 : int32, v802 : int32) = method88(v771, v698, v699, v700)
                            US15_0(v707, v741, v800, v801, v802)
                    match v804 with
                    | US15_1(v821) -> (* Error *)
                        US16_1(v821)
                    | US15_0(v805, v806, v807, v808, v809) -> (* Ok *)
                        let v811 : (char -> string) = _.ToString()
                        let v812 : string = v811 v805
                        let struct (v815 : string, v816 : string, v817 : System.Text.StringBuilder, v818 : int32, v819 : int32) = method97(v812, v806, v807, v808, v809)
                        US16_0(v815, v816, v817, v818, v819)
            let v840 : US21 =
                match v828 with
                | US16_1(v836) -> (* Error *)
                    let v837 : US5 = US5_1
                    US21_0(v837, v512, v513, v514, v515)
                | US16_0(v829, v830, v831, v832, v833) -> (* Ok *)
                    let v834 : US5 = US5_0(v829)
                    US21_0(v834, v830, v831, v832, v833)
            match v840 with
            | US21_1(v847) -> (* Error *)
                US19_1(v847)
            | US21_0(v841, v842, v843, v844, v845) -> (* Ok *)
                US19_0(v511, v841, v842, v843, v844, v845)
    match v854 with
    | US19_1(v862) -> (* Error *)
        US14_1(v862)
    | US19_0(v855, v856, v857, v858, v859, v860) -> (* Ok *)
        US14_0(v855, v856)
and method100 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US17 =
            if v3 then
                US17_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US17_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US17_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US17_0(' ')
                        else
                            let v14 : int64 = v11 - 1L
                            US17_1
        let v23 : char =
            match v19 with
            | US17_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US17_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method100(v0, v25)
and method101 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v161 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = ' ' :: v6 
            let v12 : char list = '"' :: v8 
            let v16 : char list = '`' :: v12 
            let v20 : char list = '\\' :: v16 
            let v24 : (char list -> (char [])) = List.toArray
            let v25 : (char []) = v24 v20
            let v29 : string = $"parsing.none_of / unexpected end of input / chars: %A{v25} / s: %A{struct (v2, v3, v4)}"
            US15_1(v29)
        else
            let v33 : char = v1.[int 0]
            let v34 : int64 = 0L
            let v35 : bool = method100(v33, v34)
            let v36 : bool = v35 = false
            if v36 then
                let v38 : (string -> int32) = String.length
                let v39 : int32 = v38 v1
                let v47 : int32 = 1 |> int32 
                let v60 : int32 = v39 |> int32 
                let v68 : int32 = v60 - 1
                let v70 : string = v1.[int v47..int v68]
                let v75 : (char -> string) = _.ToString()
                let v76 : string = v75 v33
                let v79 : int32 = v76.Length
                let v80 : (char []) = Array.zeroCreate<char> (v79)
                let v81 : Mut6 = {l0 = 0} : Mut6
                while method63(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v76.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v87 : char list = v80 |> Array.toList
                let v95 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v96 : (char -> (UH0 -> UH0)) = method87()
                let v97 : (char list -> (UH0 -> UH0)) = v95 v96
                let v98 : (UH0 -> UH0) = v97 v87
                let v99 : UH0 = UH0_0
                let v100 : UH0 = v98 v99
                let struct (v129 : System.Text.StringBuilder, v130 : int32, v131 : int32) = method88(v100, v2, v3, v4)
                US15_0(v33, v70, v129, v130, v131)
            else
                let v133 : char list = []
                let v135 : char list = ' ' :: v133 
                let v139 : char list = '"' :: v135 
                let v143 : char list = '`' :: v139 
                let v147 : char list = '\\' :: v143 
                let v151 : (char list -> (char [])) = List.toArray
                let v152 : (char []) = v151 v147
                let v156 : string = $"parsing.none_of / unexpected char: '{v33}' / chars: %A{v152} / s: %A{struct (v2, v3, v4)}"
                US15_1(v156)
    match v161 with
    | US15_1(v178) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US15_0(v162, v163, v164, v165, v166) -> (* Ok *)
        let v168 : (char -> string) = _.ToString()
        let v169 : string = v168 v162
        let v172 : string = v0 + v169 
        method101(v172, v163, v164, v165, v166)
and method103 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US17 =
            if v3 then
                US17_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US17_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US17_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        US17_1
        let v19 : char =
            match v15 with
            | US17_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US17_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method103(v0, v21)
and closure41 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US16 =
    let v4 : bool = "" = v0
    let v172 : US15 =
        if v4 then
            let v6 : string = $"parsing.p_char / unexpected end of input / c: '{'\\'}' / s: %A{struct (v1, v2, v3)}"
            US15_1(v6)
        else
            let v10 : char = v0.[int 0]
            let v11 : bool = v10 = '\\'
            if v11 then
                let v13 : (string -> int32) = String.length
                let v14 : int32 = v13 v0
                let v22 : int32 = 1 |> int32 
                let v35 : int32 = v14 |> int32 
                let v43 : int32 = v35 - 1
                let v45 : string = v0.[int v22..int v43]
                let v50 : (char -> string) = _.ToString()
                let v51 : string = v50 v10
                let v54 : int32 = v51.Length
                let v55 : (char []) = Array.zeroCreate<char> (v54)
                let v56 : Mut6 = {l0 = 0} : Mut6
                while method63(v54, v56) do
                    let v58 : int32 = v56.l0
                    let v59 : char = v51.[int v58]
                    v55.[int v58] <- v59
                    let v60 : int32 = v58 + 1
                    v56.l0 <- v60
                    ()
                let v62 : char list = v55 |> Array.toList
                let v70 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v71 : (char -> (UH0 -> UH0)) = method87()
                let v72 : (char list -> (UH0 -> UH0)) = v70 v71
                let v73 : (UH0 -> UH0) = v72 v62
                let v74 : UH0 = UH0_0
                let v75 : UH0 = v73 v74
                let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method88(v75, v1, v2, v3)
                US15_0(v10, v45, v104, v105, v106)
            else
                let v109 : string = "\n"
                let v110 : int32 = v0.IndexOf v109 
                let v113 : int32 = v110 - 1
                let v114 : bool = -2 = v113
                let v122 : int32 =
                    if v114 then
                        let v116 : (string -> int32) = String.length
                        let v117 : int32 = v116 v0
                        let v120 : int32 = v117 + 1
                        v120
                    else
                        let v121 : int32 = v113 + 1
                        v121
                let v128 : int32 = 0 |> int32 
                let v141 : int32 = v122 |> int32 
                let v149 : int32 = v141 - 1
                let v151 : string = v0.[int v128..int v149]
                let v156 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v2} / col: {v3}
{v1}{v151}"
                let v159 : int32 = v3 - 1
                let v160 : int32 = 0
                let v161 : (string -> string) = method89(v159, v160)
                let v162 : string = ""
                let v163 : string = v161 v162
                let v164 : string = "^"
                let v165 : string = v163 + v164 
                let v167 : string = $"{v156}
{v165}
"
                US15_1(v167)
    let v285 : US15 =
        match v172 with
        | US15_1(v282) -> (* Error *)
            US15_1(v282)
        | US15_0(v173, v174, v175, v176, v177) -> (* Ok *)
            let v178 : bool = "" = v174
            if v178 then
                let v180 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v175, v176, v177)}"
                US15_1(v180)
            else
                let v184 : char = v174.[int 0]
                let v186 : (string -> int32) = String.length
                let v187 : int32 = v186 v174
                let v195 : int32 = 1 |> int32 
                let v208 : int32 = v187 |> int32 
                let v216 : int32 = v208 - 1
                let v218 : string = v174.[int v195..int v216]
                let v223 : (char -> string) = _.ToString()
                let v224 : string = v223 v184
                let v227 : int32 = v224.Length
                let v228 : (char []) = Array.zeroCreate<char> (v227)
                let v229 : Mut6 = {l0 = 0} : Mut6
                while method63(v227, v229) do
                    let v231 : int32 = v229.l0
                    let v232 : char = v224.[int v231]
                    v228.[int v231] <- v232
                    let v233 : int32 = v231 + 1
                    v229.l0 <- v233
                    ()
                let v235 : char list = v228 |> Array.toList
                let v243 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v244 : (char -> (UH0 -> UH0)) = method87()
                let v245 : (char list -> (UH0 -> UH0)) = v243 v244
                let v246 : (UH0 -> UH0) = v245 v235
                let v247 : UH0 = UH0_0
                let v248 : UH0 = v246 v247
                let struct (v277 : System.Text.StringBuilder, v278 : int32, v279 : int32) = method88(v248, v175, v176, v177)
                US15_0(v184, v218, v277, v278, v279)
    match v285 with
    | US15_1(v303) -> (* Error *)
        US16_1(v303)
    | US15_0(v286, v287, v288, v289, v290) -> (* Ok *)
        let v292 : (char -> string) = _.ToString()
        let v293 : string = v292 '\\'
        let v297 : (char -> string) = _.ToString()
        let v298 : string = v297 v286
        let v301 : string = v293 + v298 
        US16_0(v301, v287, v288, v289, v290)
and closure42 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US16 =
    let v4 : bool = "" = v0
    let v172 : US15 =
        if v4 then
            let v6 : string = $"parsing.p_char / unexpected end of input / c: '{'`'}' / s: %A{struct (v1, v2, v3)}"
            US15_1(v6)
        else
            let v10 : char = v0.[int 0]
            let v11 : bool = v10 = '`'
            if v11 then
                let v13 : (string -> int32) = String.length
                let v14 : int32 = v13 v0
                let v22 : int32 = 1 |> int32 
                let v35 : int32 = v14 |> int32 
                let v43 : int32 = v35 - 1
                let v45 : string = v0.[int v22..int v43]
                let v50 : (char -> string) = _.ToString()
                let v51 : string = v50 v10
                let v54 : int32 = v51.Length
                let v55 : (char []) = Array.zeroCreate<char> (v54)
                let v56 : Mut6 = {l0 = 0} : Mut6
                while method63(v54, v56) do
                    let v58 : int32 = v56.l0
                    let v59 : char = v51.[int v58]
                    v55.[int v58] <- v59
                    let v60 : int32 = v58 + 1
                    v56.l0 <- v60
                    ()
                let v62 : char list = v55 |> Array.toList
                let v70 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v71 : (char -> (UH0 -> UH0)) = method87()
                let v72 : (char list -> (UH0 -> UH0)) = v70 v71
                let v73 : (UH0 -> UH0) = v72 v62
                let v74 : UH0 = UH0_0
                let v75 : UH0 = v73 v74
                let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method88(v75, v1, v2, v3)
                US15_0(v10, v45, v104, v105, v106)
            else
                let v109 : string = "\n"
                let v110 : int32 = v0.IndexOf v109 
                let v113 : int32 = v110 - 1
                let v114 : bool = -2 = v113
                let v122 : int32 =
                    if v114 then
                        let v116 : (string -> int32) = String.length
                        let v117 : int32 = v116 v0
                        let v120 : int32 = v117 + 1
                        v120
                    else
                        let v121 : int32 = v113 + 1
                        v121
                let v128 : int32 = 0 |> int32 
                let v141 : int32 = v122 |> int32 
                let v149 : int32 = v141 - 1
                let v151 : string = v0.[int v128..int v149]
                let v156 : string = $"parsing.p_char / expected: '{'`'}' / line: {v2} / col: {v3}
{v1}{v151}"
                let v159 : int32 = v3 - 1
                let v160 : int32 = 0
                let v161 : (string -> string) = method89(v159, v160)
                let v162 : string = ""
                let v163 : string = v161 v162
                let v164 : string = "^"
                let v165 : string = v163 + v164 
                let v167 : string = $"{v156}
{v165}
"
                US15_1(v167)
    let v285 : US15 =
        match v172 with
        | US15_1(v282) -> (* Error *)
            US15_1(v282)
        | US15_0(v173, v174, v175, v176, v177) -> (* Ok *)
            let v178 : bool = "" = v174
            if v178 then
                let v180 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v175, v176, v177)}"
                US15_1(v180)
            else
                let v184 : char = v174.[int 0]
                let v186 : (string -> int32) = String.length
                let v187 : int32 = v186 v174
                let v195 : int32 = 1 |> int32 
                let v208 : int32 = v187 |> int32 
                let v216 : int32 = v208 - 1
                let v218 : string = v174.[int v195..int v216]
                let v223 : (char -> string) = _.ToString()
                let v224 : string = v223 v184
                let v227 : int32 = v224.Length
                let v228 : (char []) = Array.zeroCreate<char> (v227)
                let v229 : Mut6 = {l0 = 0} : Mut6
                while method63(v227, v229) do
                    let v231 : int32 = v229.l0
                    let v232 : char = v224.[int v231]
                    v228.[int v231] <- v232
                    let v233 : int32 = v231 + 1
                    v229.l0 <- v233
                    ()
                let v235 : char list = v228 |> Array.toList
                let v243 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v244 : (char -> (UH0 -> UH0)) = method87()
                let v245 : (char list -> (UH0 -> UH0)) = v243 v244
                let v246 : (UH0 -> UH0) = v245 v235
                let v247 : UH0 = UH0_0
                let v248 : UH0 = v246 v247
                let struct (v277 : System.Text.StringBuilder, v278 : int32, v279 : int32) = method88(v248, v175, v176, v177)
                US15_0(v184, v218, v277, v278, v279)
    match v285 with
    | US15_1(v303) -> (* Error *)
        US16_1(v303)
    | US15_0(v286, v287, v288, v289, v290) -> (* Ok *)
        let v292 : (char -> string) = _.ToString()
        let v293 : string = v292 '`'
        let v297 : (char -> string) = _.ToString()
        let v298 : string = v297 v286
        let v301 : string = v293 + v298 
        US16_0(v301, v287, v288, v289, v290)
and method104 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US16 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US16 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US16_1(v15) -> (* Error *)
            method104(v0, v1, v2, v3, v8)
        | US16_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US16_1(v5)
and method105 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method105(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method102 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v153 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = '"' :: v6 
            let v12 : char list = '`' :: v8 
            let v16 : char list = '\\' :: v12 
            let v20 : (char list -> (char [])) = List.toArray
            let v21 : (char []) = v20 v16
            let v25 : string = $"parsing.none_of / unexpected end of input / chars: %A{v21} / s: %A{struct (v2, v3, v4)}"
            US15_1(v25)
        else
            let v29 : char = v1.[int 0]
            let v30 : int64 = 0L
            let v31 : bool = method103(v29, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v34 : (string -> int32) = String.length
                let v35 : int32 = v34 v1
                let v43 : int32 = 1 |> int32 
                let v56 : int32 = v35 |> int32 
                let v64 : int32 = v56 - 1
                let v66 : string = v1.[int v43..int v64]
                let v71 : (char -> string) = _.ToString()
                let v72 : string = v71 v29
                let v75 : int32 = v72.Length
                let v76 : (char []) = Array.zeroCreate<char> (v75)
                let v77 : Mut6 = {l0 = 0} : Mut6
                while method63(v75, v77) do
                    let v79 : int32 = v77.l0
                    let v80 : char = v72.[int v79]
                    v76.[int v79] <- v80
                    let v81 : int32 = v79 + 1
                    v77.l0 <- v81
                    ()
                let v83 : char list = v76 |> Array.toList
                let v91 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v92 : (char -> (UH0 -> UH0)) = method87()
                let v93 : (char list -> (UH0 -> UH0)) = v91 v92
                let v94 : (UH0 -> UH0) = v93 v83
                let v95 : UH0 = UH0_0
                let v96 : UH0 = v94 v95
                let struct (v125 : System.Text.StringBuilder, v126 : int32, v127 : int32) = method88(v96, v2, v3, v4)
                US15_0(v29, v66, v125, v126, v127)
            else
                let v129 : char list = []
                let v131 : char list = '"' :: v129 
                let v135 : char list = '`' :: v131 
                let v139 : char list = '\\' :: v135 
                let v143 : (char list -> (char [])) = List.toArray
                let v144 : (char []) = v143 v139
                let v148 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v144} / s: %A{struct (v2, v3, v4)}"
                US15_1(v148)
    let v168 : US16 =
        match v153 with
        | US15_1(v165) -> (* Error *)
            US16_1(v165)
        | US15_0(v154, v155, v156, v157, v158) -> (* Ok *)
            let v160 : (char -> string) = _.ToString()
            let v161 : string = v160 v154
            US16_0(v161, v155, v156, v157, v158)
    let v182 : US16 =
        match v168 with
        | US16_1(v174) -> (* Error *)
            let v175 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure41()
            let v176 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure42()
            let v177 : UH3 = UH3_0
            let v178 : UH3 = UH3_1(v176, v177)
            let v179 : UH3 = UH3_1(v175, v178)
            method104(v1, v2, v3, v4, v179)
        | US16_0(v169, v170, v171, v172, v173) -> (* Ok *)
            v168
    match v182 with
    | US16_1(v190) -> (* Error *)
        let v191 : UH2 = UH2_0
        let v192 : UH2 = method105(v0, v191)
        US23_0(v192, v1, v2, v3, v4)
    | US16_0(v183, v184, v185, v186, v187) -> (* Ok *)
        let v188 : UH2 = UH2_1(v183, v0)
        method102(v188, v184, v185, v186, v187)
and method106 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method106(v3, v1)
        let v6 : string list = v2 :: v4 
        v6
    | UH2_0 -> (* Nil *)
        v1
and method107 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v153 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = '"' :: v6 
            let v12 : char list = '`' :: v8 
            let v16 : char list = '\\' :: v12 
            let v20 : (char list -> (char [])) = List.toArray
            let v21 : (char []) = v20 v16
            let v25 : string = $"parsing.none_of / unexpected end of input / chars: %A{v21} / s: %A{struct (v2, v3, v4)}"
            US15_1(v25)
        else
            let v29 : char = v1.[int 0]
            let v30 : int64 = 0L
            let v31 : bool = method103(v29, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v34 : (string -> int32) = String.length
                let v35 : int32 = v34 v1
                let v43 : int32 = 1 |> int32 
                let v56 : int32 = v35 |> int32 
                let v64 : int32 = v56 - 1
                let v66 : string = v1.[int v43..int v64]
                let v71 : (char -> string) = _.ToString()
                let v72 : string = v71 v29
                let v75 : int32 = v72.Length
                let v76 : (char []) = Array.zeroCreate<char> (v75)
                let v77 : Mut6 = {l0 = 0} : Mut6
                while method63(v75, v77) do
                    let v79 : int32 = v77.l0
                    let v80 : char = v72.[int v79]
                    v76.[int v79] <- v80
                    let v81 : int32 = v79 + 1
                    v77.l0 <- v81
                    ()
                let v83 : char list = v76 |> Array.toList
                let v91 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v92 : (char -> (UH0 -> UH0)) = method87()
                let v93 : (char list -> (UH0 -> UH0)) = v91 v92
                let v94 : (UH0 -> UH0) = v93 v83
                let v95 : UH0 = UH0_0
                let v96 : UH0 = v94 v95
                let struct (v125 : System.Text.StringBuilder, v126 : int32, v127 : int32) = method88(v96, v2, v3, v4)
                US15_0(v29, v66, v125, v126, v127)
            else
                let v129 : char list = []
                let v131 : char list = '"' :: v129 
                let v135 : char list = '`' :: v131 
                let v139 : char list = '\\' :: v135 
                let v143 : (char list -> (char [])) = List.toArray
                let v144 : (char []) = v143 v139
                let v148 : string = $"parsing.none_of / unexpected char: '{v29}' / chars: %A{v144} / s: %A{struct (v2, v3, v4)}"
                US15_1(v148)
    let v168 : US16 =
        match v153 with
        | US15_1(v165) -> (* Error *)
            US16_1(v165)
        | US15_0(v154, v155, v156, v157, v158) -> (* Ok *)
            let v160 : (char -> string) = _.ToString()
            let v161 : string = v160 v154
            US16_0(v161, v155, v156, v157, v158)
    match v168 with
    | US16_1(v176) -> (* Error *)
        let v177 : UH2 = UH2_0
        let v178 : UH2 = method105(v0, v177)
        US23_0(v178, v1, v2, v3, v4)
    | US16_0(v169, v170, v171, v172, v173) -> (* Ok *)
        let v174 : UH2 = UH2_1(v169, v0)
        method107(v174, v170, v171, v172, v173)
and method99 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US23 =
    let v5 : bool = "" = v1
    let v161 : US15 =
        if v5 then
            let v6 : char list = []
            let v8 : char list = ' ' :: v6 
            let v12 : char list = '"' :: v8 
            let v16 : char list = '`' :: v12 
            let v20 : char list = '\\' :: v16 
            let v24 : (char list -> (char [])) = List.toArray
            let v25 : (char []) = v24 v20
            let v29 : string = $"parsing.none_of / unexpected end of input / chars: %A{v25} / s: %A{struct (v2, v3, v4)}"
            US15_1(v29)
        else
            let v33 : char = v1.[int 0]
            let v34 : int64 = 0L
            let v35 : bool = method100(v33, v34)
            let v36 : bool = v35 = false
            if v36 then
                let v38 : (string -> int32) = String.length
                let v39 : int32 = v38 v1
                let v47 : int32 = 1 |> int32 
                let v60 : int32 = v39 |> int32 
                let v68 : int32 = v60 - 1
                let v70 : string = v1.[int v47..int v68]
                let v75 : (char -> string) = _.ToString()
                let v76 : string = v75 v33
                let v79 : int32 = v76.Length
                let v80 : (char []) = Array.zeroCreate<char> (v79)
                let v81 : Mut6 = {l0 = 0} : Mut6
                while method63(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v76.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v87 : char list = v80 |> Array.toList
                let v95 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v96 : (char -> (UH0 -> UH0)) = method87()
                let v97 : (char list -> (UH0 -> UH0)) = v95 v96
                let v98 : (UH0 -> UH0) = v97 v87
                let v99 : UH0 = UH0_0
                let v100 : UH0 = v98 v99
                let struct (v129 : System.Text.StringBuilder, v130 : int32, v131 : int32) = method88(v100, v2, v3, v4)
                US15_0(v33, v70, v129, v130, v131)
            else
                let v133 : char list = []
                let v135 : char list = ' ' :: v133 
                let v139 : char list = '"' :: v135 
                let v143 : char list = '`' :: v139 
                let v147 : char list = '\\' :: v143 
                let v151 : (char list -> (char [])) = List.toArray
                let v152 : (char []) = v151 v147
                let v156 : string = $"parsing.none_of / unexpected char: '{v33}' / chars: %A{v152} / s: %A{struct (v2, v3, v4)}"
                US15_1(v156)
    let v181 : US16 =
        match v161 with
        | US15_1(v178) -> (* Error *)
            US16_1(v178)
        | US15_0(v162, v163, v164, v165, v166) -> (* Ok *)
            let v168 : (char -> string) = _.ToString()
            let v169 : string = v168 v162
            let struct (v172 : string, v173 : string, v174 : System.Text.StringBuilder, v175 : int32, v176 : int32) = method101(v169, v163, v164, v165, v166)
            US16_0(v172, v173, v174, v175, v176)
    let v659 : US16 =
        match v181 with
        | US16_1(v187) -> (* Error *)
            let v355 : US15 =
                if v5 then
                    let v189 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v2, v3, v4)}"
                    US15_1(v189)
                else
                    let v193 : char = v1.[int 0]
                    let v194 : bool = v193 = '"'
                    if v194 then
                        let v196 : (string -> int32) = String.length
                        let v197 : int32 = v196 v1
                        let v205 : int32 = 1 |> int32 
                        let v218 : int32 = v197 |> int32 
                        let v226 : int32 = v218 - 1
                        let v228 : string = v1.[int v205..int v226]
                        let v233 : (char -> string) = _.ToString()
                        let v234 : string = v233 v193
                        let v237 : int32 = v234.Length
                        let v238 : (char []) = Array.zeroCreate<char> (v237)
                        let v239 : Mut6 = {l0 = 0} : Mut6
                        while method63(v237, v239) do
                            let v241 : int32 = v239.l0
                            let v242 : char = v234.[int v241]
                            v238.[int v241] <- v242
                            let v243 : int32 = v241 + 1
                            v239.l0 <- v243
                            ()
                        let v245 : char list = v238 |> Array.toList
                        let v253 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v254 : (char -> (UH0 -> UH0)) = method87()
                        let v255 : (char list -> (UH0 -> UH0)) = v253 v254
                        let v256 : (UH0 -> UH0) = v255 v245
                        let v257 : UH0 = UH0_0
                        let v258 : UH0 = v256 v257
                        let struct (v287 : System.Text.StringBuilder, v288 : int32, v289 : int32) = method88(v258, v2, v3, v4)
                        US15_0(v193, v228, v287, v288, v289)
                    else
                        let v292 : string = "\n"
                        let v293 : int32 = v1.IndexOf v292 
                        let v296 : int32 = v293 - 1
                        let v297 : bool = -2 = v296
                        let v305 : int32 =
                            if v297 then
                                let v299 : (string -> int32) = String.length
                                let v300 : int32 = v299 v1
                                let v303 : int32 = v300 + 1
                                v303
                            else
                                let v304 : int32 = v296 + 1
                                v304
                        let v311 : int32 = 0 |> int32 
                        let v324 : int32 = v305 |> int32 
                        let v332 : int32 = v324 - 1
                        let v334 : string = v1.[int v311..int v332]
                        let v339 : string = $"parsing.p_char / expected: '{'"'}' / line: {v3} / col: {v4}
{v2}{v334}"
                        let v342 : int32 = v4 - 1
                        let v343 : int32 = 0
                        let v344 : (string -> string) = method89(v342, v343)
                        let v345 : string = ""
                        let v346 : string = v344 v345
                        let v347 : string = "^"
                        let v348 : string = v346 + v347 
                        let v350 : string = $"{v339}
{v348}
"
                        US15_1(v350)
            let v590 : US16 =
                match v355 with
                | US15_1(v587) -> (* Error *)
                    US16_1(v587)
                | US15_0(v356, v357, v358, v359, v360) -> (* Ok *)
                    let v361 : UH2 = UH2_0
                    let v362 : US23 = method102(v361, v357, v358, v359, v360)
                    let v393 : US16 =
                        match v362 with
                        | US23_1(v390) -> (* Error *)
                            US16_1(v390)
                        | US23_0(v363, v364, v365, v366, v367) -> (* Ok *)
                            let v368 : string list = []
                            let v369 : string list = method106(v363, v368)
                            let v373 : unit = ()
                            let _let'_v373 =
                                seq {
                                    yield! v369 
                                    (* indent
                                    ()
                                indent *)
                                }
                                (* indent
                                ()
                            indent *)
                            let v376 : string seq = _let'_v373 
                            let v383 : (string -> (string seq -> string)) = String.concat
                            let v384 : string = ""
                            let v385 : (string seq -> string) = v383 v384
                            let v386 : string = v385 v376
                            US16_0(v386, v364, v365, v366, v367)
                    match v393 with
                    | US16_1(v582) -> (* Error *)
                        let v583 : string = "parsing.between / expected content"
                        US16_1(v583)
                    | US16_0(v394, v395, v396, v397, v398) -> (* Ok *)
                        let v399 : bool = "" = v395
                        let v567 : US15 =
                            if v399 then
                                let v401 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v396, v397, v398)}"
                                US15_1(v401)
                            else
                                let v405 : char = v395.[int 0]
                                let v406 : bool = v405 = '"'
                                if v406 then
                                    let v408 : (string -> int32) = String.length
                                    let v409 : int32 = v408 v395
                                    let v417 : int32 = 1 |> int32 
                                    let v430 : int32 = v409 |> int32 
                                    let v438 : int32 = v430 - 1
                                    let v440 : string = v395.[int v417..int v438]
                                    let v445 : (char -> string) = _.ToString()
                                    let v446 : string = v445 v405
                                    let v449 : int32 = v446.Length
                                    let v450 : (char []) = Array.zeroCreate<char> (v449)
                                    let v451 : Mut6 = {l0 = 0} : Mut6
                                    while method63(v449, v451) do
                                        let v453 : int32 = v451.l0
                                        let v454 : char = v446.[int v453]
                                        v450.[int v453] <- v454
                                        let v455 : int32 = v453 + 1
                                        v451.l0 <- v455
                                        ()
                                    let v457 : char list = v450 |> Array.toList
                                    let v465 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v466 : (char -> (UH0 -> UH0)) = method87()
                                    let v467 : (char list -> (UH0 -> UH0)) = v465 v466
                                    let v468 : (UH0 -> UH0) = v467 v457
                                    let v469 : UH0 = UH0_0
                                    let v470 : UH0 = v468 v469
                                    let struct (v499 : System.Text.StringBuilder, v500 : int32, v501 : int32) = method88(v470, v396, v397, v398)
                                    US15_0(v405, v440, v499, v500, v501)
                                else
                                    let v504 : string = "\n"
                                    let v505 : int32 = v395.IndexOf v504 
                                    let v508 : int32 = v505 - 1
                                    let v509 : bool = -2 = v508
                                    let v517 : int32 =
                                        if v509 then
                                            let v511 : (string -> int32) = String.length
                                            let v512 : int32 = v511 v395
                                            let v515 : int32 = v512 + 1
                                            v515
                                        else
                                            let v516 : int32 = v508 + 1
                                            v516
                                    let v523 : int32 = 0 |> int32 
                                    let v536 : int32 = v517 |> int32 
                                    let v544 : int32 = v536 - 1
                                    let v546 : string = v395.[int v523..int v544]
                                    let v551 : string = $"parsing.p_char / expected: '{'"'}' / line: {v397} / col: {v398}
{v396}{v546}"
                                    let v554 : int32 = v398 - 1
                                    let v555 : int32 = 0
                                    let v556 : (string -> string) = method89(v554, v555)
                                    let v557 : string = ""
                                    let v558 : string = v556 v557
                                    let v559 : string = "^"
                                    let v560 : string = v558 + v559 
                                    let v562 : string = $"{v551}
{v560}
"
                                    US15_1(v562)
                        match v567 with
                        | US15_1(v574) -> (* Error *)
                            let v576 : string = $"parsing.between / expected closing delimiter / e: %A{v574} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v357, v358, v359, v360)} / rest2: %A{struct (v395, v396, v397, v398)}"
                            US16_1(v576)
                        | US15_0(v568, v569, v570, v571, v572) -> (* Ok *)
                            US16_0(v394, v569, v570, v571, v572)
            match v590 with
            | US16_1(v596) -> (* Error *)
                let v597 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure41()
                let v598 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure42()
                let v599 : UH3 = UH3_0
                let v600 : UH3 = UH3_1(v598, v599)
                let v601 : UH3 = UH3_1(v597, v600)
                let v602 : US16 = method104(v1, v2, v3, v4, v601)
                let v613 : US16 =
                    match v602 with
                    | US16_1(v610) -> (* Error *)
                        US16_1(v610)
                    | US16_0(v603, v604, v605, v606, v607) -> (* Ok *)
                        let v608 : string = ""
                        US16_0(v608, v604, v605, v606, v607)
                let v624 : US23 =
                    match v613 with
                    | US16_1(v621) -> (* Error *)
                        US23_1(v621)
                    | US16_0(v614, v615, v616, v617, v618) -> (* Ok *)
                        let v619 : UH2 = UH2_0
                        method107(v619, v615, v616, v617, v618)
                match v624 with
                | US23_1(v652) -> (* Error *)
                    US16_1(v652)
                | US23_0(v625, v626, v627, v628, v629) -> (* Ok *)
                    let v630 : string list = []
                    let v631 : string list = method106(v625, v630)
                    let v635 : unit = ()
                    let _let'_v635 =
                        seq {
                            yield! v631 
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v638 : string seq = _let'_v635 
                    let v645 : (string -> (string seq -> string)) = String.concat
                    let v646 : string = ""
                    let v647 : (string seq -> string) = v645 v646
                    let v648 : string = v647 v638
                    US16_0(v648, v626, v627, v628, v629)
            | US16_0(v591, v592, v593, v594, v595) -> (* Ok *)
                v590
        | US16_0(v182, v183, v184, v185, v186) -> (* Ok *)
            v181
    match v659 with
    | US16_1(v722) -> (* Error *)
        let v723 : UH2 = UH2_0
        let v724 : UH2 = method105(v0, v723)
        US23_0(v724, v1, v2, v3, v4)
    | US16_0(v660, v661, v662, v663, v664) -> (* Ok *)
        let v665 : int32 = 0
        let v666 : int32 = method96(v661, v665)
        let v667 : bool = 0 = v666
        let v708 : US18 =
            if v667 then
                let v668 : string = "parsing.spaces1 / expected at least one space"
                US18_1(v668)
            else
                let v671 : (string -> int32) = String.length
                let v672 : int32 = v671 v661
                let v680 : int32 = v666 |> int32 
                let v693 : int32 = v672 |> int32 
                let v701 : int32 = v693 - 1
                let v703 : string = v661.[int v680..int v701]
                US18_0(v703, v662, v663, v664)
        match v708 with
        | US18_1(v715) -> (* Error *)
            let v716 : UH2 = UH2_0
            let v717 : UH2 = UH2_1(v660, v716)
            let v718 : UH2 = method105(v0, v717)
            US23_0(v718, v661, v662, v663, v664)
        | US18_0(v709, v710, v711, v712) -> (* Ok *)
            let v713 : UH2 = UH2_1(v660, v0)
            method99(v713, v709, v710, v711, v712)
and method98 (v0 : string) : US22 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v2 : (string -> string option) = Option.ofObj
    let v3 : string option = v2 v0
    v3 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v4 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v9 : string = ""
    let v10 : string = v4 |> Option.defaultValue v9 
    let v13 : string = method86()
    let v15 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v16 : System.Text.StringBuilder = v15 v13
    let v19 : UH2 = UH2_0
    let v20 : int32 = 1
    let v21 : int32 = 1
    let v22 : US23 = method99(v19, v10, v16, v20, v21)
    match v22 with
    | US23_1(v36) -> (* Error *)
        US22_1(v36)
    | US23_0(v23, v24, v25, v26, v27) -> (* Ok *)
        let v28 : string list = []
        let v29 : string list = method106(v23, v28)
        let v31 : (string list -> (string [])) = List.toArray
        let v32 : (string []) = v31 v29
        US22_0(v32)
and method109 (v0 : string, v1 : string, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v12 : string = "{ "
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v10, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v22 : string = "file_name"
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v10, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v32 : string = " = "
    let v33 : string = $"{v32}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v10, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v42 : string = $"{v0}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v10, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v51 : string = "; "
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v10, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v61 : string = "arguments"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure8(v10, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v32}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v10, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"{v1}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure8(v10, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v89 : string = $"{v51}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v10, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v98 : string = "options"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v10, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v32}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v10, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v12}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v10, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v126 : string = "command"
    let v127 : string = $"{v126}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure8(v10, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v136 : string = $"{v32}"
    let v139 : unit = ()
    let v140 : (unit -> unit) = closure8(v10, v136)
    let v141 : unit = (fun () -> v140 (); v139) ()
    let v145 : string = $"{v2}"
    let v148 : unit = ()
    let v149 : (unit -> unit) = closure8(v10, v145)
    let v150 : unit = (fun () -> v149 (); v148) ()
    let v154 : string = $"{v51}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v10, v154)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v163 : string = "cancellation_token"
    let v164 : string = $"{v163}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure8(v10, v164)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v173 : string = $"{v32}"
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure8(v10, v173)
    let v178 : unit = (fun () -> v177 (); v176) ()
    (* run_target_args'
    let v185 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v186 : string = "format!(\"{:#?}\", $0)"
    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v186 
    let v188 : string = "fable_library_rust::String_::fromString($0)"
    let v189 : string = Fable.Core.RustInterop.emitRustExpr v187 v188 
    let _run_target_args'_v185 = v189 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v190 : string = "format!(\"{:#?}\", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v190 
    let v192 : string = "fable_library_rust::String_::fromString($0)"
    let v193 : string = Fable.Core.RustInterop.emitRustExpr v191 v192 
    let _run_target_args'_v185 = v193 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _run_target_args'_v185 = v197 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v199 : string = $"%A{v3}"
    let _run_target_args'_v185 = v199 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : string = $"%A{v3}"
    let _run_target_args'_v185 = v203 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v207 : string = $"%A{v3}"
    let _run_target_args'_v185 = v207 
    #endif
#else
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v185 = v211 
    #endif
    let v214 : string = _run_target_args'_v185 
    let v221 : string = $"{v214}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v10, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v230 : string = $"{v51}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v10, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v239 : string = "environment_variables"
    let v240 : string = $"{v239}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure8(v10, v240)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v249 : string = $"{v32}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v10, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v258 : string = $"%A{v4}"
    let v262 : string = $"{v258}"
    let v265 : unit = ()
    let v266 : (unit -> unit) = closure8(v10, v262)
    let v267 : unit = (fun () -> v266 (); v265) ()
    let v271 : string = $"{v51}"
    let v274 : unit = ()
    let v275 : (unit -> unit) = closure8(v10, v271)
    let v276 : unit = (fun () -> v275 (); v274) ()
    let v280 : string = "on_line"
    let v281 : string = $"{v280}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure8(v10, v281)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v290 : string = $"{v32}"
    let v293 : unit = ()
    let v294 : (unit -> unit) = closure8(v10, v290)
    let v295 : unit = (fun () -> v294 (); v293) ()
    (* run_target_args'
    let v302 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v303 : string = "format!(\"{:#?}\", $0)"
    let v304 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v303 
    let v305 : string = "fable_library_rust::String_::fromString($0)"
    let v306 : string = Fable.Core.RustInterop.emitRustExpr v304 v305 
    let _run_target_args'_v302 = v306 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v307 : string = "format!(\"{:#?}\", $0)"
    let v308 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v307 
    let v309 : string = "fable_library_rust::String_::fromString($0)"
    let v310 : string = Fable.Core.RustInterop.emitRustExpr v308 v309 
    let _run_target_args'_v302 = v310 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v311 : string = "format!(\"{:#?}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v311 
    let v313 : string = "fable_library_rust::String_::fromString($0)"
    let v314 : string = Fable.Core.RustInterop.emitRustExpr v312 v313 
    let _run_target_args'_v302 = v314 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v316 : string = $"%A{v5}"
    let _run_target_args'_v302 = v316 
    #endif
#if FABLE_COMPILER_PYTHON
    let v320 : string = $"%A{v5}"
    let _run_target_args'_v302 = v320 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v324 : string = $"%A{v5}"
    let _run_target_args'_v302 = v324 
    #endif
#else
    let v328 : string = $"%A{v5}"
    let _run_target_args'_v302 = v328 
    #endif
    let v331 : string = _run_target_args'_v302 
    let v338 : string = $"{v331}"
    let v341 : unit = ()
    let v342 : (unit -> unit) = closure8(v10, v338)
    let v343 : unit = (fun () -> v342 (); v341) ()
    let v347 : string = $"{v51}"
    let v350 : unit = ()
    let v351 : (unit -> unit) = closure8(v10, v347)
    let v352 : unit = (fun () -> v351 (); v350) ()
    let v356 : string = "stdin"
    let v357 : string = $"{v356}"
    let v360 : unit = ()
    let v361 : (unit -> unit) = closure8(v10, v357)
    let v362 : unit = (fun () -> v361 (); v360) ()
    let v366 : string = $"{v32}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure8(v10, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    (* run_target_args'
    let v378 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v379 : string = "format!(\"{:#?}\", $0)"
    let v380 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v379 
    let v381 : string = "fable_library_rust::String_::fromString($0)"
    let v382 : string = Fable.Core.RustInterop.emitRustExpr v380 v381 
    let _run_target_args'_v378 = v382 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v383 : string = "format!(\"{:#?}\", $0)"
    let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v383 
    let v385 : string = "fable_library_rust::String_::fromString($0)"
    let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385 
    let _run_target_args'_v378 = v386 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v387 : string = "format!(\"{:#?}\", $0)"
    let v388 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v387 
    let v389 : string = "fable_library_rust::String_::fromString($0)"
    let v390 : string = Fable.Core.RustInterop.emitRustExpr v388 v389 
    let _run_target_args'_v378 = v390 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v392 : string = $"%A{v6}"
    let _run_target_args'_v378 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : string = $"%A{v6}"
    let _run_target_args'_v378 = v396 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v400 : string = $"%A{v6}"
    let _run_target_args'_v378 = v400 
    #endif
#else
    let v404 : string = $"%A{v6}"
    let _run_target_args'_v378 = v404 
    #endif
    let v407 : string = _run_target_args'_v378 
    let v414 : string = $"{v407}"
    let v417 : unit = ()
    let v418 : (unit -> unit) = closure8(v10, v414)
    let v419 : unit = (fun () -> v418 (); v417) ()
    let v423 : string = $"{v51}"
    let v426 : unit = ()
    let v427 : (unit -> unit) = closure8(v10, v423)
    let v428 : unit = (fun () -> v427 (); v426) ()
    let v432 : string = "trace"
    let v433 : string = $"{v432}"
    let v436 : unit = ()
    let v437 : (unit -> unit) = closure8(v10, v433)
    let v438 : unit = (fun () -> v437 (); v436) ()
    let v442 : string = $"{v32}"
    let v445 : unit = ()
    let v446 : (unit -> unit) = closure8(v10, v442)
    let v447 : unit = (fun () -> v446 (); v445) ()
    let v452 : string =
        if v7 then
            let v450 : string = "true"
            v450
        else
            let v451 : string = "false"
            v451
    let v454 : string = $"{v452}"
    let v457 : unit = ()
    let v458 : (unit -> unit) = closure8(v10, v454)
    let v459 : unit = (fun () -> v458 (); v457) ()
    let v463 : string = $"{v51}"
    let v466 : unit = ()
    let v467 : (unit -> unit) = closure8(v10, v463)
    let v468 : unit = (fun () -> v467 (); v466) ()
    let v472 : string = "working_directory"
    let v473 : string = $"{v472}"
    let v476 : unit = ()
    let v477 : (unit -> unit) = closure8(v10, v473)
    let v478 : unit = (fun () -> v477 (); v476) ()
    let v482 : string = $"{v32}"
    let v485 : unit = ()
    let v486 : (unit -> unit) = closure8(v10, v482)
    let v487 : unit = (fun () -> v486 (); v485) ()
    (* run_target_args'
    let v494 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v495 : string = "format!(\"{:#?}\", $0)"
    let v496 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v495 
    let v497 : string = "fable_library_rust::String_::fromString($0)"
    let v498 : string = Fable.Core.RustInterop.emitRustExpr v496 v497 
    let _run_target_args'_v494 = v498 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v499 : string = "format!(\"{:#?}\", $0)"
    let v500 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v499 
    let v501 : string = "fable_library_rust::String_::fromString($0)"
    let v502 : string = Fable.Core.RustInterop.emitRustExpr v500 v501 
    let _run_target_args'_v494 = v502 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v503 : string = "format!(\"{:#?}\", $0)"
    let v504 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v503 
    let v505 : string = "fable_library_rust::String_::fromString($0)"
    let v506 : string = Fable.Core.RustInterop.emitRustExpr v504 v505 
    let _run_target_args'_v494 = v506 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v508 : string = $"%A{v8}"
    let _run_target_args'_v494 = v508 
    #endif
#if FABLE_COMPILER_PYTHON
    let v512 : string = $"%A{v8}"
    let _run_target_args'_v494 = v512 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v516 : string = $"%A{v8}"
    let _run_target_args'_v494 = v516 
    #endif
#else
    let v520 : string = $"%A{v8}"
    let _run_target_args'_v494 = v520 
    #endif
    let v523 : string = _run_target_args'_v494 
    let v530 : string = $"{v523}"
    let v533 : unit = ()
    let v534 : (unit -> unit) = closure8(v10, v530)
    let v535 : unit = (fun () -> v534 (); v533) ()
    let v539 : string = " }"
    let v540 : string = $"{v539}"
    let v543 : unit = ()
    let v544 : (unit -> unit) = closure8(v10, v540)
    let v545 : unit = (fun () -> v544 (); v543) ()
    let v549 : string = $"{v539}"
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure8(v10, v549)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v557 : string = v10.l0
    v557
and method108 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method109(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure43 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v34 : Mut0, v35 : Mut1, v36 : Mut2, v37 : Mut3, v38 : Mut4, v39 : int64 option) = TraceState.trace_state.Value
        let v52 : string = method8(v34, v35, v36, v37, v38, v39)
        let v53 : string = method66()
        let v55 : string = $"%A{v8}"
        let v58 : string = method108(v34, v35, v36, v37, v38, v39, v52, v53, v7, v55, v0, v1, v2, v3, v4, v5, v6)
        method19(v58)
and closure44 () (v0 : std_process_Child option) : std_process_Child option =
    v0
and method110 () : (std_process_Child option -> std_process_Child option) =
    closure44()
and closure45 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US24 =
    US24_0(v0)
and method111 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) =
    closure45()
and closure46 () (v0 : std_string_String) : US24 =
    US24_1(v0)
and method112 () : (std_string_String -> US24) =
    closure46()
and method113 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options / child error"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure47 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method113(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method114 (v0 : std_sync_MutexGuard<std_process_Child option>) : std_sync_MutexGuard<std_process_Child option> =
    v0
and closure48 () (v0 : std_process_ChildStdin option) : std_process_ChildStdin option =
    v0
and method115 () : (std_process_ChildStdin option -> std_process_ChildStdin option) =
    closure48()
and closure49 () (v0 : std_sync_mpsc_Sender<std_string_String>) : std_sync_mpsc_Sender<std_string_String> =
    v0
and method116 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure49()
and method117 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure49()
and closure50 () (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method118 () : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) =
    closure50()
and closure51 () (v0 : std_string_String) : US26 =
    US26_0(v0)
and method119 () : (std_string_String -> US26) =
    closure51()
and closure52 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and method120 () : (std_string_String -> US26) =
    closure52()
and method122 (v0 : bool, v1 : std_string_String) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "trace'"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v36 : string =
        if v0 then
            let v34 : string = "true"
            v34
        else
            let v35 : string = "false"
            v35
    let v38 : string = $"{v36}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v3, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v47 : string = "; "
    let v48 : string = $"{v47}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure8(v3, v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v57 : string = "e"
    let v58 : string = $"{v57}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v3, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v67 : string = $"{v25}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure8(v3, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    (* run_target_args'
    let v79 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v80 : string = "format!(\"{:#?}\", $0)"
    let v81 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v80 
    let v82 : string = "fable_library_rust::String_::fromString($0)"
    let v83 : string = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let _run_target_args'_v79 = v83 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v84 : string = "format!(\"{:#?}\", $0)"
    let v85 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v84 
    let v86 : string = "fable_library_rust::String_::fromString($0)"
    let v87 : string = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let _run_target_args'_v79 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "format!(\"{:#?}\", $0)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v88 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let _run_target_args'_v79 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : string = $"%A{v1}"
    let _run_target_args'_v79 = v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v97 : string = $"%A{v1}"
    let _run_target_args'_v79 = v97 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v101 : string = $"%A{v1}"
    let _run_target_args'_v79 = v101 
    #endif
#else
    let v105 : string = $"%A{v1}"
    let _run_target_args'_v79 = v105 
    #endif
    let v108 : string = _run_target_args'_v79 
    let v115 : string = $"{v108}"
    let v118 : unit = ()
    let v119 : (unit -> unit) = closure8(v3, v115)
    let v120 : unit = (fun () -> v119 (); v118) ()
    let v124 : string = " }"
    let v125 : string = $"{v124}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure8(v3, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = v3.l0
    v133
and method121 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : string = method122(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "runtime.stdio_line"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure53 (v0 : bool, v1 : std_string_String) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method76()
        let v47 : string = method121(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method19(v47)
and method123 () : string =
    
    
    
    
    
    let v1 : string = "Verbose"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method13(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_black"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_black"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_black"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[90m"
    let v137 : string = method15()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[90m"
    let v141 : string = method15()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[90m"
    let v145 : string = method15()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[90m"
    let v149 : string = method15()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method125 () : string =
    let v0 : string = method14()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method124 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method125()
    let v10 : int64 = v0.l0
    let v12 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method18(v12)
and closure54 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method123()
        let v46 : bool = v0 = ""
        let v49 : string =
            if v46 then
                let v47 : string = ""
                v47
            else
                method124(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v49)
and closure55 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _run_target_args'_v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v17 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v21 
    #endif
#else
    let v25 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v5 = v25 
    #endif
    let v28 : std_string_String = _run_target_args'_v5 
    v28
and method126 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure55()
and method127 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure56 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US27 =
    US27_0(v0)
and method128 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) =
    closure56()
and method129 (v0 : std_sync_MutexGuard<std_process_ChildStdin option>) : std_sync_MutexGuard<std_process_ChildStdin option> =
    v0
and closure57 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US28 =
    US28_0(v0)
and method130 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) =
    closure57()
and method131 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure58 () (v0 : std_process_Output) : US29 =
    US29_0(v0)
and method132 () : (std_process_Output -> US29) =
    closure58()
and closure59 () (v0 : std_string_String) : US29 =
    US29_1(v0)
and method133 () : (std_string_String -> US29) =
    closure59()
and method134 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options / output error"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure60 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method134(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and closure61 () (v0 : int32) : US30 =
    US30_0(v0)
and method135 () : (int32 -> US30) =
    closure61()
and method136 () : string =
    let v0 : string = "\n"
    v0
and method138 (v0 : int32, v1 : int32) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "exit_code"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "std_trace_length"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method137 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method138(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "runtime.execute_with_options / result"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure62 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method123()
        let v47 : int32 = v1.Length
        let v48 : string = method137(v27, v28, v29, v30, v31, v32, v45, v46, v0, v47)
        method19(v48)
and method142 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v12 : string = "{ "
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v10, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v22 : string = "file_name"
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v10, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v32 : string = " = "
    let v33 : string = $"{v32}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v10, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v42 : string = $"{v0}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v10, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v51 : string = "; "
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v10, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v61 : string = "arguments"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure8(v10, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v32}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v10, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"%A{v1}"
    let v84 : string = $"{v80}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure8(v10, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = $"{v51}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v10, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = "options"
    let v103 : string = $"{v102}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure8(v10, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v32}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure8(v10, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v12}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v10, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "command"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure8(v10, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v32}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure8(v10, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v2}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure8(v10, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = $"{v51}"
    let v161 : unit = ()
    let v162 : (unit -> unit) = closure8(v10, v158)
    let v163 : unit = (fun () -> v162 (); v161) ()
    let v167 : string = "cancellation_token"
    let v168 : string = $"{v167}"
    let v171 : unit = ()
    let v172 : (unit -> unit) = closure8(v10, v168)
    let v173 : unit = (fun () -> v172 (); v171) ()
    let v177 : string = $"{v32}"
    let v180 : unit = ()
    let v181 : (unit -> unit) = closure8(v10, v177)
    let v182 : unit = (fun () -> v181 (); v180) ()
    (* run_target_args'
    let v189 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : string = "format!(\"{:#?}\", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v190 
    let v192 : string = "fable_library_rust::String_::fromString($0)"
    let v193 : string = Fable.Core.RustInterop.emitRustExpr v191 v192 
    let _run_target_args'_v189 = v193 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _run_target_args'_v189 = v197 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v198 : string = "format!(\"{:#?}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v198 
    let v200 : string = "fable_library_rust::String_::fromString($0)"
    let v201 : string = Fable.Core.RustInterop.emitRustExpr v199 v200 
    let _run_target_args'_v189 = v201 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v203 : string = $"%A{v3}"
    let _run_target_args'_v189 = v203 
    #endif
#if FABLE_COMPILER_PYTHON
    let v207 : string = $"%A{v3}"
    let _run_target_args'_v189 = v207 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v189 = v211 
    #endif
#else
    let v215 : string = $"%A{v3}"
    let _run_target_args'_v189 = v215 
    #endif
    let v218 : string = _run_target_args'_v189 
    let v225 : string = $"{v218}"
    let v228 : unit = ()
    let v229 : (unit -> unit) = closure8(v10, v225)
    let v230 : unit = (fun () -> v229 (); v228) ()
    let v234 : string = $"{v51}"
    let v237 : unit = ()
    let v238 : (unit -> unit) = closure8(v10, v234)
    let v239 : unit = (fun () -> v238 (); v237) ()
    let v243 : string = "environment_variables"
    let v244 : string = $"{v243}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure8(v10, v244)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v253 : string = $"{v32}"
    let v256 : unit = ()
    let v257 : (unit -> unit) = closure8(v10, v253)
    let v258 : unit = (fun () -> v257 (); v256) ()
    let v262 : string = $"%A{v4}"
    let v266 : string = $"{v262}"
    let v269 : unit = ()
    let v270 : (unit -> unit) = closure8(v10, v266)
    let v271 : unit = (fun () -> v270 (); v269) ()
    let v275 : string = $"{v51}"
    let v278 : unit = ()
    let v279 : (unit -> unit) = closure8(v10, v275)
    let v280 : unit = (fun () -> v279 (); v278) ()
    let v284 : string = "on_line"
    let v285 : string = $"{v284}"
    let v288 : unit = ()
    let v289 : (unit -> unit) = closure8(v10, v285)
    let v290 : unit = (fun () -> v289 (); v288) ()
    let v294 : string = $"{v32}"
    let v297 : unit = ()
    let v298 : (unit -> unit) = closure8(v10, v294)
    let v299 : unit = (fun () -> v298 (); v297) ()
    (* run_target_args'
    let v306 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v307 : string = "format!(\"{:#?}\", $0)"
    let v308 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v307 
    let v309 : string = "fable_library_rust::String_::fromString($0)"
    let v310 : string = Fable.Core.RustInterop.emitRustExpr v308 v309 
    let _run_target_args'_v306 = v310 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v311 : string = "format!(\"{:#?}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v311 
    let v313 : string = "fable_library_rust::String_::fromString($0)"
    let v314 : string = Fable.Core.RustInterop.emitRustExpr v312 v313 
    let _run_target_args'_v306 = v314 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v315 : string = "format!(\"{:#?}\", $0)"
    let v316 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v315 
    let v317 : string = "fable_library_rust::String_::fromString($0)"
    let v318 : string = Fable.Core.RustInterop.emitRustExpr v316 v317 
    let _run_target_args'_v306 = v318 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v320 : string = $"%A{v5}"
    let _run_target_args'_v306 = v320 
    #endif
#if FABLE_COMPILER_PYTHON
    let v324 : string = $"%A{v5}"
    let _run_target_args'_v306 = v324 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v328 : string = $"%A{v5}"
    let _run_target_args'_v306 = v328 
    #endif
#else
    let v332 : string = $"%A{v5}"
    let _run_target_args'_v306 = v332 
    #endif
    let v335 : string = _run_target_args'_v306 
    let v342 : string = $"{v335}"
    let v345 : unit = ()
    let v346 : (unit -> unit) = closure8(v10, v342)
    let v347 : unit = (fun () -> v346 (); v345) ()
    let v351 : string = $"{v51}"
    let v354 : unit = ()
    let v355 : (unit -> unit) = closure8(v10, v351)
    let v356 : unit = (fun () -> v355 (); v354) ()
    let v360 : string = "stdin"
    let v361 : string = $"{v360}"
    let v364 : unit = ()
    let v365 : (unit -> unit) = closure8(v10, v361)
    let v366 : unit = (fun () -> v365 (); v364) ()
    let v370 : string = $"{v32}"
    let v373 : unit = ()
    let v374 : (unit -> unit) = closure8(v10, v370)
    let v375 : unit = (fun () -> v374 (); v373) ()
    (* run_target_args'
    let v382 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v383 : string = "format!(\"{:#?}\", $0)"
    let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v383 
    let v385 : string = "fable_library_rust::String_::fromString($0)"
    let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385 
    let _run_target_args'_v382 = v386 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v387 : string = "format!(\"{:#?}\", $0)"
    let v388 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v387 
    let v389 : string = "fable_library_rust::String_::fromString($0)"
    let v390 : string = Fable.Core.RustInterop.emitRustExpr v388 v389 
    let _run_target_args'_v382 = v390 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v391 : string = "format!(\"{:#?}\", $0)"
    let v392 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v391 
    let v393 : string = "fable_library_rust::String_::fromString($0)"
    let v394 : string = Fable.Core.RustInterop.emitRustExpr v392 v393 
    let _run_target_args'_v382 = v394 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v396 : string = $"%A{v6}"
    let _run_target_args'_v382 = v396 
    #endif
#if FABLE_COMPILER_PYTHON
    let v400 : string = $"%A{v6}"
    let _run_target_args'_v382 = v400 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v404 : string = $"%A{v6}"
    let _run_target_args'_v382 = v404 
    #endif
#else
    let v408 : string = $"%A{v6}"
    let _run_target_args'_v382 = v408 
    #endif
    let v411 : string = _run_target_args'_v382 
    let v418 : string = $"{v411}"
    let v421 : unit = ()
    let v422 : (unit -> unit) = closure8(v10, v418)
    let v423 : unit = (fun () -> v422 (); v421) ()
    let v427 : string = $"{v51}"
    let v430 : unit = ()
    let v431 : (unit -> unit) = closure8(v10, v427)
    let v432 : unit = (fun () -> v431 (); v430) ()
    let v436 : string = "trace"
    let v437 : string = $"{v436}"
    let v440 : unit = ()
    let v441 : (unit -> unit) = closure8(v10, v437)
    let v442 : unit = (fun () -> v441 (); v440) ()
    let v446 : string = $"{v32}"
    let v449 : unit = ()
    let v450 : (unit -> unit) = closure8(v10, v446)
    let v451 : unit = (fun () -> v450 (); v449) ()
    let v456 : string =
        if v7 then
            let v454 : string = "true"
            v454
        else
            let v455 : string = "false"
            v455
    let v458 : string = $"{v456}"
    let v461 : unit = ()
    let v462 : (unit -> unit) = closure8(v10, v458)
    let v463 : unit = (fun () -> v462 (); v461) ()
    let v467 : string = $"{v51}"
    let v470 : unit = ()
    let v471 : (unit -> unit) = closure8(v10, v467)
    let v472 : unit = (fun () -> v471 (); v470) ()
    let v476 : string = "working_directory"
    let v477 : string = $"{v476}"
    let v480 : unit = ()
    let v481 : (unit -> unit) = closure8(v10, v477)
    let v482 : unit = (fun () -> v481 (); v480) ()
    let v486 : string = $"{v32}"
    let v489 : unit = ()
    let v490 : (unit -> unit) = closure8(v10, v486)
    let v491 : unit = (fun () -> v490 (); v489) ()
    (* run_target_args'
    let v498 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v499 : string = "format!(\"{:#?}\", $0)"
    let v500 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v499 
    let v501 : string = "fable_library_rust::String_::fromString($0)"
    let v502 : string = Fable.Core.RustInterop.emitRustExpr v500 v501 
    let _run_target_args'_v498 = v502 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v503 : string = "format!(\"{:#?}\", $0)"
    let v504 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v503 
    let v505 : string = "fable_library_rust::String_::fromString($0)"
    let v506 : string = Fable.Core.RustInterop.emitRustExpr v504 v505 
    let _run_target_args'_v498 = v506 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v507 : string = "format!(\"{:#?}\", $0)"
    let v508 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v507 
    let v509 : string = "fable_library_rust::String_::fromString($0)"
    let v510 : string = Fable.Core.RustInterop.emitRustExpr v508 v509 
    let _run_target_args'_v498 = v510 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v512 : string = $"%A{v8}"
    let _run_target_args'_v498 = v512 
    #endif
#if FABLE_COMPILER_PYTHON
    let v516 : string = $"%A{v8}"
    let _run_target_args'_v498 = v516 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v520 : string = $"%A{v8}"
    let _run_target_args'_v498 = v520 
    #endif
#else
    let v524 : string = $"%A{v8}"
    let _run_target_args'_v498 = v524 
    #endif
    let v527 : string = _run_target_args'_v498 
    let v534 : string = $"{v527}"
    let v537 : unit = ()
    let v538 : (unit -> unit) = closure8(v10, v534)
    let v539 : unit = (fun () -> v538 (); v537) ()
    let v543 : string = " }"
    let v544 : string = $"{v543}"
    let v547 : unit = ()
    let v548 : (unit -> unit) = closure8(v10, v544)
    let v549 : unit = (fun () -> v548 (); v547) ()
    let v553 : string = $"{v543}"
    let v556 : unit = ()
    let v557 : (unit -> unit) = closure8(v10, v553)
    let v558 : unit = (fun () -> v557 (); v556) ()
    let v561 : string = v10.l0
    v561
and method141 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method142(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options_async"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure63 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v34 : Mut0, v35 : Mut1, v36 : Mut2, v37 : Mut3, v38 : Mut4, v39 : int64 option) = TraceState.trace_state.Value
        let v52 : string = method8(v34, v35, v36, v37, v38, v39)
        let v53 : string = method66()
        let v54 : string = method141(v34, v35, v36, v37, v38, v39, v52, v53, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method19(v54)
and method143 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and method146 (v0 : System.Diagnostics.DataReceivedEventArgs) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = null |> unbox<string>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = null |> unbox<string>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = null |> unbox<string>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = null |> unbox<string>
    let _run_target_args'_v5 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : string = null |> unbox<string>
    let _run_target_args'_v5 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : string = null |> unbox<string>
    let _run_target_args'_v5 = v27 
    #endif
#else
    let v30 : (System.Diagnostics.DataReceivedEventArgs -> string) = _.Data
    let v31 : string = v30 v0
    let _run_target_args'_v5 = v31 
    #endif
    let v32 : string = _run_target_args'_v5 
    v32
and closure65 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US31 =
    US31_0(v0)
and method147 () : ((struct (int32 * string * bool) -> Async<unit>) -> US31) =
    closure65()
and method148 (v0 : System.Diagnostics.Process) : int32 =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : int32 = null |> unbox<int32>
    let _run_target_args'_v5 = v27 
    #endif
#else
    let v30 : (System.Diagnostics.Process -> int32) = _.Id
    let v31 : int32 = v30 v0
    let _run_target_args'_v5 = v31 
    #endif
    let v32 : int32 = _run_target_args'_v5 
    v32
and closure66 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method123()
        let v46 : bool = v0 = ""
        let v49 : string =
            if v46 then
                let v47 : string = ""
                v47
            else
                method124(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v49)
and method145 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    (* run_target_args'
    let v15 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v15 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v15 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v15 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : unit = ()
    let _let'_v29 =
        async {
            let v32 : string = method146(v10)
            let v34 : string = null |> unbox<string>
            let v37 : bool = v32 = v34
            let v38 : bool = v37 <> true
            if v38 then
                let v41 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v42 : US31 option = v3 |> Option.map v41 
                let v56 : US31 = US31_1
                let v57 : US31 = v42 |> Option.defaultValue v56 
                match v57 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v61) -> (* Some *)
                    let v62 : int32 = method148(v7)
                    let v63 : Async<unit> = v61 struct (v62, v32, v9)
                    do! v63 
                    ()
                let v66 : string =
                    if v9 then
                        let v64 : string = $"! {v32}"
                        v64
                    else
                        let v65 : string = $"> {v32}"
                        v65
                if v5 then
                    let v67 : unit = ()
                    let v68 : (unit -> unit) = closure66(v66)
                    let v69 : unit = (fun () -> v68 (); v67) ()
                    ()
                else
                    let v119 : unit = ()
                    let v120 : (unit -> unit) = closure11(v66)
                    let v121 : unit = (fun () -> v120 (); v119) ()
                    ()
                let v125 : string =
                    if v9 then
                        let v123 : string = "\u001b[7;4m"
                        v123
                    else
                        let v124 : string = ""
                        v124
                let v128 : string =
                    if v9 then
                        let v126 : string = "\u001b[0m"
                        v126
                    else
                        let v127 : string = ""
                        v127
                let v129 : string = $"{v125}{v32}{v128}"
                (* run_target_args'
                let v130 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v131 : (string -> unit) = v8.Push
                v131 v129
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v832 : Async<unit> = _let'_v29 
    let _run_target_args'_v15 = v832 
    #endif
#if FABLE_COMPILER_PYTHON
    let v834 : unit = ()
    let _let'_v834 =
        async {
            let v837 : string = method146(v10)
            let v839 : string = null |> unbox<string>
            let v842 : bool = v837 = v839
            let v843 : bool = v842 <> true
            if v843 then
                let v846 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v847 : US31 option = v3 |> Option.map v846 
                let v861 : US31 = US31_1
                let v862 : US31 = v847 |> Option.defaultValue v861 
                match v862 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v866) -> (* Some *)
                    let v867 : int32 = method148(v7)
                    let v868 : Async<unit> = v866 struct (v867, v837, v9)
                    do! v868 
                    ()
                let v871 : string =
                    if v9 then
                        let v869 : string = $"! {v837}"
                        v869
                    else
                        let v870 : string = $"> {v837}"
                        v870
                if v5 then
                    let v872 : unit = ()
                    let v873 : (unit -> unit) = closure66(v871)
                    let v874 : unit = (fun () -> v873 (); v872) ()
                    ()
                else
                    let v924 : unit = ()
                    let v925 : (unit -> unit) = closure11(v871)
                    let v926 : unit = (fun () -> v925 (); v924) ()
                    ()
                let v930 : string =
                    if v9 then
                        let v928 : string = "\u001b[7;4m"
                        v928
                    else
                        let v929 : string = ""
                        v929
                let v933 : string =
                    if v9 then
                        let v931 : string = "\u001b[0m"
                        v931
                    else
                        let v932 : string = ""
                        v932
                let v934 : string = $"{v930}{v837}{v933}"
                (* run_target_args'
                let v935 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v936 : (string -> unit) = v8.Push
                v936 v934
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1637 : Async<unit> = _let'_v834 
    let _run_target_args'_v15 = v1637 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1639 : unit = ()
    let _let'_v1639 =
        async {
            let v1642 : string = method146(v10)
            let v1644 : string = null |> unbox<string>
            let v1647 : bool = v1642 = v1644
            let v1648 : bool = v1647 <> true
            if v1648 then
                let v1651 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v1652 : US31 option = v3 |> Option.map v1651 
                let v1666 : US31 = US31_1
                let v1667 : US31 = v1652 |> Option.defaultValue v1666 
                match v1667 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v1671) -> (* Some *)
                    let v1672 : int32 = method148(v7)
                    let v1673 : Async<unit> = v1671 struct (v1672, v1642, v9)
                    do! v1673 
                    ()
                let v1676 : string =
                    if v9 then
                        let v1674 : string = $"! {v1642}"
                        v1674
                    else
                        let v1675 : string = $"> {v1642}"
                        v1675
                if v5 then
                    let v1677 : unit = ()
                    let v1678 : (unit -> unit) = closure66(v1676)
                    let v1679 : unit = (fun () -> v1678 (); v1677) ()
                    ()
                else
                    let v1729 : unit = ()
                    let v1730 : (unit -> unit) = closure11(v1676)
                    let v1731 : unit = (fun () -> v1730 (); v1729) ()
                    ()
                let v1735 : string =
                    if v9 then
                        let v1733 : string = "\u001b[7;4m"
                        v1733
                    else
                        let v1734 : string = ""
                        v1734
                let v1738 : string =
                    if v9 then
                        let v1736 : string = "\u001b[0m"
                        v1736
                    else
                        let v1737 : string = ""
                        v1737
                let v1739 : string = $"{v1735}{v1642}{v1738}"
                (* run_target_args'
                let v1740 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v1741 : (string -> unit) = v8.Push
                v1741 v1739
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2442 : Async<unit> = _let'_v1639 
    let _run_target_args'_v15 = v2442 
    #endif
#else
    let v2444 : unit = ()
    let _let'_v2444 =
        async {
            let v2447 : string = method146(v10)
            let v2449 : string = null |> unbox<string>
            let v2452 : bool = v2447 = v2449
            let v2453 : bool = v2452 <> true
            if v2453 then
                let v2456 : ((struct (int32 * string * bool) -> Async<unit>) -> US31) = method147()
                let v2457 : US31 option = v3 |> Option.map v2456 
                let v2471 : US31 = US31_1
                let v2472 : US31 = v2457 |> Option.defaultValue v2471 
                match v2472 with
                | US31_1 -> (* None *)
                    ()
                | US31_0(v2476) -> (* Some *)
                    let v2477 : int32 = method148(v7)
                    let v2478 : Async<unit> = v2476 struct (v2477, v2447, v9)
                    do! v2478 
                    ()
                let v2481 : string =
                    if v9 then
                        let v2479 : string = $"! {v2447}"
                        v2479
                    else
                        let v2480 : string = $"> {v2447}"
                        v2480
                if v5 then
                    let v2482 : unit = ()
                    let v2483 : (unit -> unit) = closure66(v2481)
                    let v2484 : unit = (fun () -> v2483 (); v2482) ()
                    ()
                else
                    let v2534 : unit = ()
                    let v2535 : (unit -> unit) = closure11(v2481)
                    let v2536 : unit = (fun () -> v2535 (); v2534) ()
                    ()
                let v2540 : string =
                    if v9 then
                        let v2538 : string = "\u001b[7;4m"
                        v2538
                    else
                        let v2539 : string = ""
                        v2539
                let v2543 : string =
                    if v9 then
                        let v2541 : string = "\u001b[0m"
                        v2541
                    else
                        let v2542 : string = ""
                        v2542
                let v2544 : string = $"{v2540}{v2447}{v2543}"
                (* run_target_args'
                let v2545 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v2546 : (string -> unit) = v8.Push
                v2546 v2544
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3247 : Async<unit> = _let'_v2444 
    let _run_target_args'_v15 = v3247 
    #endif
    let v3248 : Async<unit> = _run_target_args'_v15 
    v3248
and method144 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    method145(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure64 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool) (v10 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v11 : Async<unit> = method144(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : (Async<unit> -> unit) = Async.StartImmediate
    v13 v11
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : (Async<unit> -> unit) = Async.StartImmediate
    v14 v11
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : (Async<unit> -> unit) = Async.StartImmediate
    v15 v11
    #endif
#else
    let v16 : (Async<unit> -> unit) = Async.StartImmediate
    v16 v11
    #endif
    // run_target_args' is_unit
    ()
and closure67 () (v0 : System.Threading.CancellationToken) : US32 =
    US32_0(v0)
and method149 () : (System.Threading.CancellationToken -> US32) =
    closure67()
and method150 (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : unit = ()
    let _let'_v19 =
        async {
            (* run_target_args'
            let v26 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v28 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v32 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v32 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v36 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v36 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v40 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v40 
            #endif
#if FABLE_COMPILER_PYTHON
            let v44 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v44 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v48 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v48 
            #endif
#else
            let v51 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v51 = v51 
            let v52 : System.Threading.CancellationToken = v51 
            let v53 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v54 : (System.Threading.CancellationToken []) = [|v52; v53; v0|]
            let v55 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v56 : System.Threading.CancellationTokenSource = v55 v54
            let v57 : System.Threading.CancellationToken = v56.Token
            return v57 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v342 : Async<System.Threading.CancellationToken> = _let'_v19 
    let _run_target_args'_v5 = v342 
    #endif
#if FABLE_COMPILER_PYTHON
    let v344 : unit = ()
    let _let'_v344 =
        async {
            (* run_target_args'
            let v351 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v353 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v353 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v357 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v357 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v361 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v361 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v365 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v365 
            #endif
#if FABLE_COMPILER_PYTHON
            let v369 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v369 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v373 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v373 
            #endif
#else
            let v376 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v376 = v376 
            let v377 : System.Threading.CancellationToken = v376 
            let v378 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v379 : (System.Threading.CancellationToken []) = [|v377; v378; v0|]
            let v380 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v381 : System.Threading.CancellationTokenSource = v380 v379
            let v382 : System.Threading.CancellationToken = v381.Token
            return v382 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v667 : Async<System.Threading.CancellationToken> = _let'_v344 
    let _run_target_args'_v5 = v667 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v669 : unit = ()
    let _let'_v669 =
        async {
            (* run_target_args'
            let v676 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v678 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v678 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v682 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v682 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v686 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v686 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v690 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v690 
            #endif
#if FABLE_COMPILER_PYTHON
            let v694 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v694 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v698 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v698 
            #endif
#else
            let v701 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v701 = v701 
            let v702 : System.Threading.CancellationToken = v701 
            let v703 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v704 : (System.Threading.CancellationToken []) = [|v702; v703; v0|]
            let v705 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v706 : System.Threading.CancellationTokenSource = v705 v704
            let v707 : System.Threading.CancellationToken = v706.Token
            return v707 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v992 : Async<System.Threading.CancellationToken> = _let'_v669 
    let _run_target_args'_v5 = v992 
    #endif
#else
    let v994 : unit = ()
    let _let'_v994 =
        async {
            (* run_target_args'
            let v1001 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1003 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1003 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1007 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1007 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1011 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1011 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1015 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1015 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1019 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1019 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1023 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v1023 
            #endif
#else
            let v1026 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1026 = v1026 
            let v1027 : System.Threading.CancellationToken = v1026 
            let v1028 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v1029 : (System.Threading.CancellationToken []) = [|v1027; v1028; v0|]
            let v1030 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v1031 : System.Threading.CancellationTokenSource = v1030 v1029
            let v1032 : System.Threading.CancellationToken = v1031.Token
            return v1032 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1317 : Async<System.Threading.CancellationToken> = _let'_v994 
    let _run_target_args'_v5 = v1317 
    #endif
    let v1318 : Async<System.Threading.CancellationToken> = _run_target_args'_v5 
    v1318
and method151 (v0 : System.Diagnostics.Process) : bool =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : bool = null |> unbox<bool>
    let _run_target_args'_v5 = v27 
    #endif
#else
    let v30 : (System.Diagnostics.Process -> bool) = _.HasExited
    let v31 : bool = v30 v0
    let _run_target_args'_v5 = v31 
    #endif
    let v32 : bool = _run_target_args'_v5 
    v32
and method152 (v0 : System.Diagnostics.Process) : unit =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v2 : (System.Diagnostics.Process -> unit) = _.Kill()
    v2 v0
    #endif
    // run_target_args' is_unit
    ()
and closure68 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = method151(v0)
    let v2 : bool = v1 = false
    if v2 then
        method152(v0)
and method155 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "ex"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    (* run_target_args'
    let v37 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _run_target_args'_v37 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v37 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v37 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = $"%A{v0}"
    let _run_target_args'_v37 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v37 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v37 = v59 
    #endif
#else
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v37 = v63 
    #endif
    let v66 : string = _run_target_args'_v37 
    let v73 : string = $"{v66}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v2, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v2, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v2.l0
    v91
and method154 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method155(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure69 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method35()
        let v46 : string = method154(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method153 (v0 : System.Diagnostics.Process, v1 : System.Collections.Concurrent.ConcurrentStack<string>, v2 : System.Threading.CancellationToken) : Async<int32> =
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v7 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : unit = ()
    let _let'_v21 =
        async {
            try
                (* run_target_args'
                let v28 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v30 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v30 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v34 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v34 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v38 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v38 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v42 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v42 
                #endif
#if FABLE_COMPILER_PYTHON
                let v46 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v46 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v50 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v28 = v50 
                #endif
#else
                let v53 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v28 = v53 
                #endif
                let v54 : System.Threading.Tasks.Task = _run_target_args'_v28 
                (* run_target_args'
                let v64 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v66 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v64 = v66 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v70 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v64 = v70 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v74 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v64 = v74 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v77 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v78 : Async<unit> = v77 v54
                let _run_target_args'_v64 = v78 
                #endif
#if FABLE_COMPILER_PYTHON
                let v79 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v80 : Async<unit> = v79 v54
                let _run_target_args'_v64 = v80 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v81 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v82 : Async<unit> = v81 v54
                let _run_target_args'_v64 = v82 
                #endif
#else
                let v83 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v84 : Async<unit> = v83 v54
                let _run_target_args'_v64 = v84 
                #endif
                let v85 : Async<unit> = _run_target_args'_v64 
                do! v85 
                (* run_target_args'
                let v95 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v97 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v97 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v101 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v101 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v105 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v105 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v109 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v109 
                #endif
#if FABLE_COMPILER_PYTHON
                let v113 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v113 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v117 : int32 = null |> unbox<int32>
                let _run_target_args'_v95 = v117 
                #endif
#else
                let v120 : int32 = v0.ExitCode
                let _run_target_args'_v95 = v120 
                #endif
                let v121 : int32 = _run_target_args'_v95 
                return v121 
                (* indent
                ()
            indent *)
            with ex ->
                let v230 : exn = ex
                (* run_target_args'
                let v235 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v237 : string = $"%A{v230}"
                let _run_target_args'_v235 = v237 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v241 : string = $"%A{v230}"
                let _run_target_args'_v235 = v241 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v245 : string = $"%A{v230}"
                let _run_target_args'_v235 = v245 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v249 : string = $"%A{v230}"
                let _run_target_args'_v235 = v249 
                #endif
#if FABLE_COMPILER_PYTHON
                let v253 : string = $"%A{v230}"
                let _run_target_args'_v235 = v253 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v257 : string = $"%A{v230}"
                let _run_target_args'_v235 = v257 
                #endif
#else
                let v260 : string = $"{v230.GetType ()}: {v230.Message}"
                let _run_target_args'_v235 = v260 
                #endif
                let v261 : string = _run_target_args'_v235 
                (* run_target_args'
                let v267 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v268 : (string -> unit) = v1.Push
                v268 v261
                #endif
                // run_target_args' is_unit
                let v270 : System.Threading.Tasks.TaskCanceledException = v230 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v273 : unit = ()
                let v274 : (unit -> unit) = closure69(v270)
                let v275 : unit = (fun () -> v274 (); v273) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3144 : Async<int32> = _let'_v21 
    let _run_target_args'_v7 = v3144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3146 : unit = ()
    let _let'_v3146 =
        async {
            try
                (* run_target_args'
                let v3153 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3155 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3155 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3159 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3159 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3163 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3163 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3167 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3167 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3171 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3171 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3175 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v3153 = v3175 
                #endif
#else
                let v3178 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v3153 = v3178 
                #endif
                let v3179 : System.Threading.Tasks.Task = _run_target_args'_v3153 
                (* run_target_args'
                let v3189 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3191 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v3189 = v3191 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3195 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v3189 = v3195 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3199 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v3189 = v3199 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3202 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v3203 : Async<unit> = v3202 v3179
                let _run_target_args'_v3189 = v3203 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3204 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v3205 : Async<unit> = v3204 v3179
                let _run_target_args'_v3189 = v3205 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3206 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v3207 : Async<unit> = v3206 v3179
                let _run_target_args'_v3189 = v3207 
                #endif
#else
                let v3208 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v3209 : Async<unit> = v3208 v3179
                let _run_target_args'_v3189 = v3209 
                #endif
                let v3210 : Async<unit> = _run_target_args'_v3189 
                do! v3210 
                (* run_target_args'
                let v3220 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3222 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3222 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3226 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3226 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3230 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3230 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3234 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3234 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3238 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3238 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3242 : int32 = null |> unbox<int32>
                let _run_target_args'_v3220 = v3242 
                #endif
#else
                let v3245 : int32 = v0.ExitCode
                let _run_target_args'_v3220 = v3245 
                #endif
                let v3246 : int32 = _run_target_args'_v3220 
                return v3246 
                (* indent
                ()
            indent *)
            with ex ->
                let v3355 : exn = ex
                (* run_target_args'
                let v3360 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3362 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3362 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3366 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3366 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3370 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3370 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3374 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3374 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3378 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3378 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3382 : string = $"%A{v3355}"
                let _run_target_args'_v3360 = v3382 
                #endif
#else
                let v3385 : string = $"{v3355.GetType ()}: {v3355.Message}"
                let _run_target_args'_v3360 = v3385 
                #endif
                let v3386 : string = _run_target_args'_v3360 
                (* run_target_args'
                let v3392 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v3393 : (string -> unit) = v1.Push
                v3393 v3386
                #endif
                // run_target_args' is_unit
                let v3395 : System.Threading.Tasks.TaskCanceledException = v3355 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v3398 : unit = ()
                let v3399 : (unit -> unit) = closure69(v3395)
                let v3400 : unit = (fun () -> v3399 (); v3398) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6269 : Async<int32> = _let'_v3146 
    let _run_target_args'_v7 = v6269 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v6271 : unit = ()
    let _let'_v6271 =
        async {
            try
                (* run_target_args'
                let v6278 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6280 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6280 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6284 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6284 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6288 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6288 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6292 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6292 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6296 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6296 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6300 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v6278 = v6300 
                #endif
#else
                let v6303 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v6278 = v6303 
                #endif
                let v6304 : System.Threading.Tasks.Task = _run_target_args'_v6278 
                (* run_target_args'
                let v6314 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6316 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v6314 = v6316 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6320 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v6314 = v6320 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6324 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v6314 = v6324 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6327 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v6328 : Async<unit> = v6327 v6304
                let _run_target_args'_v6314 = v6328 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6329 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v6330 : Async<unit> = v6329 v6304
                let _run_target_args'_v6314 = v6330 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6331 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v6332 : Async<unit> = v6331 v6304
                let _run_target_args'_v6314 = v6332 
                #endif
#else
                let v6333 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v6334 : Async<unit> = v6333 v6304
                let _run_target_args'_v6314 = v6334 
                #endif
                let v6335 : Async<unit> = _run_target_args'_v6314 
                do! v6335 
                (* run_target_args'
                let v6345 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6347 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6347 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6351 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6351 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6355 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6355 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6359 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6359 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6363 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6363 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6367 : int32 = null |> unbox<int32>
                let _run_target_args'_v6345 = v6367 
                #endif
#else
                let v6370 : int32 = v0.ExitCode
                let _run_target_args'_v6345 = v6370 
                #endif
                let v6371 : int32 = _run_target_args'_v6345 
                return v6371 
                (* indent
                ()
            indent *)
            with ex ->
                let v6480 : exn = ex
                (* run_target_args'
                let v6485 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6487 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6487 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6491 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6491 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6495 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6495 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6499 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6499 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6503 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6503 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6507 : string = $"%A{v6480}"
                let _run_target_args'_v6485 = v6507 
                #endif
#else
                let v6510 : string = $"{v6480.GetType ()}: {v6480.Message}"
                let _run_target_args'_v6485 = v6510 
                #endif
                let v6511 : string = _run_target_args'_v6485 
                (* run_target_args'
                let v6517 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v6518 : (string -> unit) = v1.Push
                v6518 v6511
                #endif
                // run_target_args' is_unit
                let v6520 : System.Threading.Tasks.TaskCanceledException = v6480 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v6523 : unit = ()
                let v6524 : (unit -> unit) = closure69(v6520)
                let v6525 : unit = (fun () -> v6524 (); v6523) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9394 : Async<int32> = _let'_v6271 
    let _run_target_args'_v7 = v9394 
    #endif
#else
    let v9396 : unit = ()
    let _let'_v9396 =
        async {
            try
                (* run_target_args'
                let v9403 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v9405 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9405 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v9409 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9409 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v9413 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9413 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v9417 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9417 
                #endif
#if FABLE_COMPILER_PYTHON
                let v9421 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9421 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v9425 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v9403 = v9425 
                #endif
#else
                let v9428 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v9403 = v9428 
                #endif
                let v9429 : System.Threading.Tasks.Task = _run_target_args'_v9403 
                (* run_target_args'
                let v9439 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v9441 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v9439 = v9441 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v9445 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v9439 = v9445 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v9449 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v9439 = v9449 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v9452 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v9453 : Async<unit> = v9452 v9429
                let _run_target_args'_v9439 = v9453 
                #endif
#if FABLE_COMPILER_PYTHON
                let v9454 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v9455 : Async<unit> = v9454 v9429
                let _run_target_args'_v9439 = v9455 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v9456 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v9457 : Async<unit> = v9456 v9429
                let _run_target_args'_v9439 = v9457 
                #endif
#else
                let v9458 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v9459 : Async<unit> = v9458 v9429
                let _run_target_args'_v9439 = v9459 
                #endif
                let v9460 : Async<unit> = _run_target_args'_v9439 
                do! v9460 
                (* run_target_args'
                let v9470 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v9472 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9472 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v9476 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9476 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v9480 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9480 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v9484 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9484 
                #endif
#if FABLE_COMPILER_PYTHON
                let v9488 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9488 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v9492 : int32 = null |> unbox<int32>
                let _run_target_args'_v9470 = v9492 
                #endif
#else
                let v9495 : int32 = v0.ExitCode
                let _run_target_args'_v9470 = v9495 
                #endif
                let v9496 : int32 = _run_target_args'_v9470 
                return v9496 
                (* indent
                ()
            indent *)
            with ex ->
                let v9605 : exn = ex
                (* run_target_args'
                let v9610 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v9612 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9612 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v9616 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9616 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v9620 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9620 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v9624 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9624 
                #endif
#if FABLE_COMPILER_PYTHON
                let v9628 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9628 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v9632 : string = $"%A{v9605}"
                let _run_target_args'_v9610 = v9632 
                #endif
#else
                let v9635 : string = $"{v9605.GetType ()}: {v9605.Message}"
                let _run_target_args'_v9610 = v9635 
                #endif
                let v9636 : string = _run_target_args'_v9610 
                (* run_target_args'
                let v9642 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v9643 : (string -> unit) = v1.Push
                v9643 v9636
                #endif
                // run_target_args' is_unit
                let v9645 : System.Threading.Tasks.TaskCanceledException = v9605 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v9648 : unit = ()
                let v9649 : (unit -> unit) = closure69(v9645)
                let v9650 : unit = (fun () -> v9649 (); v9648) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v12519 : Async<int32> = _let'_v9396 
    let _run_target_args'_v7 = v12519 
    #endif
    let v12520 : Async<int32> = _run_target_args'_v7 
    v12520
and method157 (v0 : int32, v1 : int32, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v12 : string = "{ "
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v10, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v22 : string = "exit_code"
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v10, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v32 : string = " = "
    let v33 : string = $"{v32}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v10, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v42 : string = $"{v0}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v10, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v51 : string = "; "
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v10, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v61 : string = "output_length"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure8(v10, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v32}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v10, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"{v1}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure8(v10, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v89 : string = $"{v51}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v10, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v98 : string = "options"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v10, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v32}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v10, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v12}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v10, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v126 : string = "command"
    let v127 : string = $"{v126}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure8(v10, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v136 : string = $"{v32}"
    let v139 : unit = ()
    let v140 : (unit -> unit) = closure8(v10, v136)
    let v141 : unit = (fun () -> v140 (); v139) ()
    let v145 : string = $"{v2}"
    let v148 : unit = ()
    let v149 : (unit -> unit) = closure8(v10, v145)
    let v150 : unit = (fun () -> v149 (); v148) ()
    let v154 : string = $"{v51}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v10, v154)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v163 : string = "cancellation_token"
    let v164 : string = $"{v163}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure8(v10, v164)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v173 : string = $"{v32}"
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure8(v10, v173)
    let v178 : unit = (fun () -> v177 (); v176) ()
    (* run_target_args'
    let v185 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v186 : string = "format!(\"{:#?}\", $0)"
    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v186 
    let v188 : string = "fable_library_rust::String_::fromString($0)"
    let v189 : string = Fable.Core.RustInterop.emitRustExpr v187 v188 
    let _run_target_args'_v185 = v189 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v190 : string = "format!(\"{:#?}\", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v190 
    let v192 : string = "fable_library_rust::String_::fromString($0)"
    let v193 : string = Fable.Core.RustInterop.emitRustExpr v191 v192 
    let _run_target_args'_v185 = v193 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _run_target_args'_v185 = v197 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v199 : string = $"%A{v3}"
    let _run_target_args'_v185 = v199 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : string = $"%A{v3}"
    let _run_target_args'_v185 = v203 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v207 : string = $"%A{v3}"
    let _run_target_args'_v185 = v207 
    #endif
#else
    let v211 : string = $"%A{v3}"
    let _run_target_args'_v185 = v211 
    #endif
    let v214 : string = _run_target_args'_v185 
    let v221 : string = $"{v214}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v10, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v230 : string = $"{v51}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v10, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v239 : string = "environment_variables"
    let v240 : string = $"{v239}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure8(v10, v240)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v249 : string = $"{v32}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v10, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v258 : string = $"%A{v4}"
    let v262 : string = $"{v258}"
    let v265 : unit = ()
    let v266 : (unit -> unit) = closure8(v10, v262)
    let v267 : unit = (fun () -> v266 (); v265) ()
    let v271 : string = $"{v51}"
    let v274 : unit = ()
    let v275 : (unit -> unit) = closure8(v10, v271)
    let v276 : unit = (fun () -> v275 (); v274) ()
    let v280 : string = "on_line"
    let v281 : string = $"{v280}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure8(v10, v281)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v290 : string = $"{v32}"
    let v293 : unit = ()
    let v294 : (unit -> unit) = closure8(v10, v290)
    let v295 : unit = (fun () -> v294 (); v293) ()
    (* run_target_args'
    let v302 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v303 : string = "format!(\"{:#?}\", $0)"
    let v304 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v303 
    let v305 : string = "fable_library_rust::String_::fromString($0)"
    let v306 : string = Fable.Core.RustInterop.emitRustExpr v304 v305 
    let _run_target_args'_v302 = v306 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v307 : string = "format!(\"{:#?}\", $0)"
    let v308 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v307 
    let v309 : string = "fable_library_rust::String_::fromString($0)"
    let v310 : string = Fable.Core.RustInterop.emitRustExpr v308 v309 
    let _run_target_args'_v302 = v310 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v311 : string = "format!(\"{:#?}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v311 
    let v313 : string = "fable_library_rust::String_::fromString($0)"
    let v314 : string = Fable.Core.RustInterop.emitRustExpr v312 v313 
    let _run_target_args'_v302 = v314 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v316 : string = $"%A{v5}"
    let _run_target_args'_v302 = v316 
    #endif
#if FABLE_COMPILER_PYTHON
    let v320 : string = $"%A{v5}"
    let _run_target_args'_v302 = v320 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v324 : string = $"%A{v5}"
    let _run_target_args'_v302 = v324 
    #endif
#else
    let v328 : string = $"%A{v5}"
    let _run_target_args'_v302 = v328 
    #endif
    let v331 : string = _run_target_args'_v302 
    let v338 : string = $"{v331}"
    let v341 : unit = ()
    let v342 : (unit -> unit) = closure8(v10, v338)
    let v343 : unit = (fun () -> v342 (); v341) ()
    let v347 : string = $"{v51}"
    let v350 : unit = ()
    let v351 : (unit -> unit) = closure8(v10, v347)
    let v352 : unit = (fun () -> v351 (); v350) ()
    let v356 : string = "stdin"
    let v357 : string = $"{v356}"
    let v360 : unit = ()
    let v361 : (unit -> unit) = closure8(v10, v357)
    let v362 : unit = (fun () -> v361 (); v360) ()
    let v366 : string = $"{v32}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure8(v10, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    (* run_target_args'
    let v378 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v379 : string = "format!(\"{:#?}\", $0)"
    let v380 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v379 
    let v381 : string = "fable_library_rust::String_::fromString($0)"
    let v382 : string = Fable.Core.RustInterop.emitRustExpr v380 v381 
    let _run_target_args'_v378 = v382 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v383 : string = "format!(\"{:#?}\", $0)"
    let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v383 
    let v385 : string = "fable_library_rust::String_::fromString($0)"
    let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385 
    let _run_target_args'_v378 = v386 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v387 : string = "format!(\"{:#?}\", $0)"
    let v388 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v387 
    let v389 : string = "fable_library_rust::String_::fromString($0)"
    let v390 : string = Fable.Core.RustInterop.emitRustExpr v388 v389 
    let _run_target_args'_v378 = v390 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v392 : string = $"%A{v6}"
    let _run_target_args'_v378 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : string = $"%A{v6}"
    let _run_target_args'_v378 = v396 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v400 : string = $"%A{v6}"
    let _run_target_args'_v378 = v400 
    #endif
#else
    let v404 : string = $"%A{v6}"
    let _run_target_args'_v378 = v404 
    #endif
    let v407 : string = _run_target_args'_v378 
    let v414 : string = $"{v407}"
    let v417 : unit = ()
    let v418 : (unit -> unit) = closure8(v10, v414)
    let v419 : unit = (fun () -> v418 (); v417) ()
    let v423 : string = $"{v51}"
    let v426 : unit = ()
    let v427 : (unit -> unit) = closure8(v10, v423)
    let v428 : unit = (fun () -> v427 (); v426) ()
    let v432 : string = "trace"
    let v433 : string = $"{v432}"
    let v436 : unit = ()
    let v437 : (unit -> unit) = closure8(v10, v433)
    let v438 : unit = (fun () -> v437 (); v436) ()
    let v442 : string = $"{v32}"
    let v445 : unit = ()
    let v446 : (unit -> unit) = closure8(v10, v442)
    let v447 : unit = (fun () -> v446 (); v445) ()
    let v452 : string =
        if v7 then
            let v450 : string = "true"
            v450
        else
            let v451 : string = "false"
            v451
    let v454 : string = $"{v452}"
    let v457 : unit = ()
    let v458 : (unit -> unit) = closure8(v10, v454)
    let v459 : unit = (fun () -> v458 (); v457) ()
    let v463 : string = $"{v51}"
    let v466 : unit = ()
    let v467 : (unit -> unit) = closure8(v10, v463)
    let v468 : unit = (fun () -> v467 (); v466) ()
    let v472 : string = "working_directory"
    let v473 : string = $"{v472}"
    let v476 : unit = ()
    let v477 : (unit -> unit) = closure8(v10, v473)
    let v478 : unit = (fun () -> v477 (); v476) ()
    let v482 : string = $"{v32}"
    let v485 : unit = ()
    let v486 : (unit -> unit) = closure8(v10, v482)
    let v487 : unit = (fun () -> v486 (); v485) ()
    (* run_target_args'
    let v494 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v495 : string = "format!(\"{:#?}\", $0)"
    let v496 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v495 
    let v497 : string = "fable_library_rust::String_::fromString($0)"
    let v498 : string = Fable.Core.RustInterop.emitRustExpr v496 v497 
    let _run_target_args'_v494 = v498 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v499 : string = "format!(\"{:#?}\", $0)"
    let v500 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v499 
    let v501 : string = "fable_library_rust::String_::fromString($0)"
    let v502 : string = Fable.Core.RustInterop.emitRustExpr v500 v501 
    let _run_target_args'_v494 = v502 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v503 : string = "format!(\"{:#?}\", $0)"
    let v504 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v503 
    let v505 : string = "fable_library_rust::String_::fromString($0)"
    let v506 : string = Fable.Core.RustInterop.emitRustExpr v504 v505 
    let _run_target_args'_v494 = v506 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v508 : string = $"%A{v8}"
    let _run_target_args'_v494 = v508 
    #endif
#if FABLE_COMPILER_PYTHON
    let v512 : string = $"%A{v8}"
    let _run_target_args'_v494 = v512 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v516 : string = $"%A{v8}"
    let _run_target_args'_v494 = v516 
    #endif
#else
    let v520 : string = $"%A{v8}"
    let _run_target_args'_v494 = v520 
    #endif
    let v523 : string = _run_target_args'_v494 
    let v530 : string = $"{v523}"
    let v533 : unit = ()
    let v534 : (unit -> unit) = closure8(v10, v530)
    let v535 : unit = (fun () -> v534 (); v533) ()
    let v539 : string = " }"
    let v540 : string = $"{v539}"
    let v543 : unit = ()
    let v544 : (unit -> unit) = closure8(v10, v540)
    let v545 : unit = (fun () -> v544 (); v543) ()
    let v549 : string = $"{v539}"
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure8(v10, v549)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v557 : string = v10.l0
    v557
and method156 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method157(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v20 : string = "runtime.execute_with_options_async"
    let v21 : string = $"{v6} {v7} #{v18} %s{v20} / {v17}"
    method18(v21)
and closure70 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : int32, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v34 : Mut0, v35 : Mut1, v36 : Mut2, v37 : Mut3, v38 : Mut4, v39 : int64 option) = TraceState.trace_state.Value
        let v52 : string = method8(v34, v35, v36, v37, v38, v39)
        let v53 : string = method66()
        let v54 : int32 = v8.Length
        let v55 : string = method156(v34, v35, v36, v37, v38, v39, v52, v53, v7, v54, v0, v1, v2, v3, v4, v5, v6)
        method19(v55)
and method140 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v11 = v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v11 = v21 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : unit = ()
    let _let'_v25 =
        async {
            (* run_target_args'
            let v36 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v39 : int32, v40 : string) = null |> unbox<struct (int32 * string)>
            return struct (v39, v40) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v47 : int32, v48 : string) = null |> unbox<struct (int32 * string)>
            return struct (v47, v48) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v55 : int32, v56 : string) = null |> unbox<struct (int32 * string)>
            return struct (v55, v56) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v63 : int32, v64 : string) = null |> unbox<struct (int32 * string)>
            return struct (v63, v64) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v71 : int32, v72 : string) = null |> unbox<struct (int32 * string)>
            return struct (v71, v72) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v79 : int32, v80 : string) = null |> unbox<struct (int32 * string)>
            return struct (v79, v80) 
            #endif
#else
            let v85 : US14 = method85(v0)
            let struct (v97 : string, v98 : US5) =
                match v85 with
                | US14_1(v88) -> (* Error *)
                    let v90 : string = $"resultm.get / Result value was Error: {v88}"
                    failwith<struct (string * US5)> v90
                | US14_0(v86, v87) -> (* Ok *)
                    struct (v86, v87)
            let v101 : (string -> US5) = method6()
            let v102 : US5 option = v6 |> Option.map v101 
            let v116 : US5 = US5_1
            let v117 : US5 = v102 |> Option.defaultValue v116 
            let v124 : string =
                match v117 with
                | US5_1 -> (* None *)
                    let v122 : string = ""
                    v122
                | US5_0(v121) -> (* Some *)
                    v121
            let v125 : unit = ()
            let v126 : (unit -> unit) = closure63(v0, v1, v2, v3, v4, v5, v6, v98, v97)
            let v127 : unit = (fun () -> v126 (); v125) ()
            let v174 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v178 : string =
                match v98 with
                | US5_1 -> (* None *)
                    let v176 : string = ""
                    v176
                | US5_0(v175) -> (* Some *)
                    v175
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v178,
              StandardOutputEncoding = v174,
              WorkingDirectory = v124,
              FileName = v97,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v179 : System.Diagnostics.ProcessStartInfo = start_info
            let v180 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v181 : int32 = v180.Length
            let v182 : Mut6 = {l0 = 0} : Mut6
            while method63(v181, v182) do
                let v184 : int32 = v182.l0
                let struct (v185 : string, v186 : string) = v180.[int v184]
                v179.EnvironmentVariables.[v185] <- v186 
                let v187 : int32 = v184 + 1
                v182.l0 <- v187
                ()
            let v188 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v179)
            use v188 = v188 
            let v189 : System.Diagnostics.Process = v188 
            let v190 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v191 : System.Collections.Concurrent.ConcurrentStack<string> = v190 ()
            let v192 : bool = false
            let v193 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v189, v191, v192)
            v189.OutputDataReceived.Add v193 
            let v194 : bool = true
            let v195 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v189, v191, v194)
            v189.ErrorDataReceived.Add v195 
            let v196 : (unit -> bool) = v189.Start
            let v197 : bool = v196 ()
            let v198 : bool = v197 = false
            if v198 then
                let v199 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v199
            let v200 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v200 v189
            let v201 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v201 v189
            let v204 : (System.Threading.CancellationToken -> US32) = method149()
            let v205 : US32 option = v1 |> Option.map v204 
            let v219 : US32 = US32_1
            let v220 : US32 = v205 |> Option.defaultValue v219 
            let v227 : System.Threading.CancellationToken =
                match v220 with
                | US32_1 -> (* None *)
                    let v225 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v225
                | US32_0(v224) -> (* Some *)
                    v224
            let v228 : Async<System.Threading.CancellationToken> = method150(v227)
            let! v228 = v228 
            let v229 : System.Threading.CancellationToken = v228 
            let v230 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v229.Register
            let v231 : (unit -> unit) = closure68(v189)
            let v232 : System.Threading.CancellationTokenRegistration = v230 v231
            use v232 = v232 
            let v233 : System.Threading.CancellationTokenRegistration = v232 
            let v234 : Async<int32> = method153(v189, v191, v229)
            let! v234 = v234 
            let v235 : int32 = v234 
            let v237 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v238 : string seq = v237 v191
            let v242 : (string seq -> string seq) = Seq.rev
            let v243 : string seq = v242 v238
            let v247 : string = method136()
            let v248 : (string -> (string seq -> string)) = String.concat
            let v249 : (string seq -> string) = v248 v247
            let v250 : string = v249 v243
            let v254 : unit = ()
            let v255 : (unit -> unit) = closure70(v0, v1, v2, v3, v4, v5, v6, v235, v250)
            let v256 : unit = (fun () -> v255 (); v254) ()
            return struct (v235, v250) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2300 : Async<struct (int32 * string)> = _let'_v25 
    let _run_target_args'_v11 = v2300 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2302 : unit = ()
    let _let'_v2302 =
        async {
            (* run_target_args'
            let v2313 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v2316 : int32, v2317 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2316, v2317) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v2324 : int32, v2325 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2324, v2325) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v2332 : int32, v2333 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2332, v2333) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v2340 : int32, v2341 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2340, v2341) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v2348 : int32, v2349 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2348, v2349) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v2356 : int32, v2357 : string) = null |> unbox<struct (int32 * string)>
            return struct (v2356, v2357) 
            #endif
#else
            let v2362 : US14 = method85(v0)
            let struct (v2374 : string, v2375 : US5) =
                match v2362 with
                | US14_1(v2365) -> (* Error *)
                    let v2367 : string = $"resultm.get / Result value was Error: {v2365}"
                    failwith<struct (string * US5)> v2367
                | US14_0(v2363, v2364) -> (* Ok *)
                    struct (v2363, v2364)
            let v2378 : (string -> US5) = method6()
            let v2379 : US5 option = v6 |> Option.map v2378 
            let v2393 : US5 = US5_1
            let v2394 : US5 = v2379 |> Option.defaultValue v2393 
            let v2401 : string =
                match v2394 with
                | US5_1 -> (* None *)
                    let v2399 : string = ""
                    v2399
                | US5_0(v2398) -> (* Some *)
                    v2398
            let v2402 : unit = ()
            let v2403 : (unit -> unit) = closure63(v0, v1, v2, v3, v4, v5, v6, v2375, v2374)
            let v2404 : unit = (fun () -> v2403 (); v2402) ()
            let v2451 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v2455 : string =
                match v2375 with
                | US5_1 -> (* None *)
                    let v2453 : string = ""
                    v2453
                | US5_0(v2452) -> (* Some *)
                    v2452
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v2455,
              StandardOutputEncoding = v2451,
              WorkingDirectory = v2401,
              FileName = v2374,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v2456 : System.Diagnostics.ProcessStartInfo = start_info
            let v2457 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v2458 : int32 = v2457.Length
            let v2459 : Mut6 = {l0 = 0} : Mut6
            while method63(v2458, v2459) do
                let v2461 : int32 = v2459.l0
                let struct (v2462 : string, v2463 : string) = v2457.[int v2461]
                v2456.EnvironmentVariables.[v2462] <- v2463 
                let v2464 : int32 = v2461 + 1
                v2459.l0 <- v2464
                ()
            let v2465 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2456)
            use v2465 = v2465 
            let v2466 : System.Diagnostics.Process = v2465 
            let v2467 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v2468 : System.Collections.Concurrent.ConcurrentStack<string> = v2467 ()
            let v2469 : bool = false
            let v2470 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v2466, v2468, v2469)
            v2466.OutputDataReceived.Add v2470 
            let v2471 : bool = true
            let v2472 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v2466, v2468, v2471)
            v2466.ErrorDataReceived.Add v2472 
            let v2473 : (unit -> bool) = v2466.Start
            let v2474 : bool = v2473 ()
            let v2475 : bool = v2474 = false
            if v2475 then
                let v2476 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v2476
            let v2477 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v2477 v2466
            let v2478 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v2478 v2466
            let v2481 : (System.Threading.CancellationToken -> US32) = method149()
            let v2482 : US32 option = v1 |> Option.map v2481 
            let v2496 : US32 = US32_1
            let v2497 : US32 = v2482 |> Option.defaultValue v2496 
            let v2504 : System.Threading.CancellationToken =
                match v2497 with
                | US32_1 -> (* None *)
                    let v2502 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v2502
                | US32_0(v2501) -> (* Some *)
                    v2501
            let v2505 : Async<System.Threading.CancellationToken> = method150(v2504)
            let! v2505 = v2505 
            let v2506 : System.Threading.CancellationToken = v2505 
            let v2507 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2506.Register
            let v2508 : (unit -> unit) = closure68(v2466)
            let v2509 : System.Threading.CancellationTokenRegistration = v2507 v2508
            use v2509 = v2509 
            let v2510 : System.Threading.CancellationTokenRegistration = v2509 
            let v2511 : Async<int32> = method153(v2466, v2468, v2506)
            let! v2511 = v2511 
            let v2512 : int32 = v2511 
            let v2514 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v2515 : string seq = v2514 v2468
            let v2519 : (string seq -> string seq) = Seq.rev
            let v2520 : string seq = v2519 v2515
            let v2524 : string = method136()
            let v2525 : (string -> (string seq -> string)) = String.concat
            let v2526 : (string seq -> string) = v2525 v2524
            let v2527 : string = v2526 v2520
            let v2531 : unit = ()
            let v2532 : (unit -> unit) = closure70(v0, v1, v2, v3, v4, v5, v6, v2512, v2527)
            let v2533 : unit = (fun () -> v2532 (); v2531) ()
            return struct (v2512, v2527) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4577 : Async<struct (int32 * string)> = _let'_v2302 
    let _run_target_args'_v11 = v4577 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4579 : unit = ()
    let _let'_v4579 =
        async {
            (* run_target_args'
            let v4590 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v4593 : int32, v4594 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4593, v4594) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v4601 : int32, v4602 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4601, v4602) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v4609 : int32, v4610 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4609, v4610) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v4617 : int32, v4618 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4617, v4618) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v4625 : int32, v4626 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4625, v4626) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v4633 : int32, v4634 : string) = null |> unbox<struct (int32 * string)>
            return struct (v4633, v4634) 
            #endif
#else
            let v4639 : US14 = method85(v0)
            let struct (v4651 : string, v4652 : US5) =
                match v4639 with
                | US14_1(v4642) -> (* Error *)
                    let v4644 : string = $"resultm.get / Result value was Error: {v4642}"
                    failwith<struct (string * US5)> v4644
                | US14_0(v4640, v4641) -> (* Ok *)
                    struct (v4640, v4641)
            let v4655 : (string -> US5) = method6()
            let v4656 : US5 option = v6 |> Option.map v4655 
            let v4670 : US5 = US5_1
            let v4671 : US5 = v4656 |> Option.defaultValue v4670 
            let v4678 : string =
                match v4671 with
                | US5_1 -> (* None *)
                    let v4676 : string = ""
                    v4676
                | US5_0(v4675) -> (* Some *)
                    v4675
            let v4679 : unit = ()
            let v4680 : (unit -> unit) = closure63(v0, v1, v2, v3, v4, v5, v6, v4652, v4651)
            let v4681 : unit = (fun () -> v4680 (); v4679) ()
            let v4728 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v4732 : string =
                match v4652 with
                | US5_1 -> (* None *)
                    let v4730 : string = ""
                    v4730
                | US5_0(v4729) -> (* Some *)
                    v4729
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v4732,
              StandardOutputEncoding = v4728,
              WorkingDirectory = v4678,
              FileName = v4651,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v4733 : System.Diagnostics.ProcessStartInfo = start_info
            let v4734 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v4735 : int32 = v4734.Length
            let v4736 : Mut6 = {l0 = 0} : Mut6
            while method63(v4735, v4736) do
                let v4738 : int32 = v4736.l0
                let struct (v4739 : string, v4740 : string) = v4734.[int v4738]
                v4733.EnvironmentVariables.[v4739] <- v4740 
                let v4741 : int32 = v4738 + 1
                v4736.l0 <- v4741
                ()
            let v4742 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v4733)
            use v4742 = v4742 
            let v4743 : System.Diagnostics.Process = v4742 
            let v4744 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v4745 : System.Collections.Concurrent.ConcurrentStack<string> = v4744 ()
            let v4746 : bool = false
            let v4747 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v4743, v4745, v4746)
            v4743.OutputDataReceived.Add v4747 
            let v4748 : bool = true
            let v4749 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v4743, v4745, v4748)
            v4743.ErrorDataReceived.Add v4749 
            let v4750 : (unit -> bool) = v4743.Start
            let v4751 : bool = v4750 ()
            let v4752 : bool = v4751 = false
            if v4752 then
                let v4753 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v4753
            let v4754 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v4754 v4743
            let v4755 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v4755 v4743
            let v4758 : (System.Threading.CancellationToken -> US32) = method149()
            let v4759 : US32 option = v1 |> Option.map v4758 
            let v4773 : US32 = US32_1
            let v4774 : US32 = v4759 |> Option.defaultValue v4773 
            let v4781 : System.Threading.CancellationToken =
                match v4774 with
                | US32_1 -> (* None *)
                    let v4779 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v4779
                | US32_0(v4778) -> (* Some *)
                    v4778
            let v4782 : Async<System.Threading.CancellationToken> = method150(v4781)
            let! v4782 = v4782 
            let v4783 : System.Threading.CancellationToken = v4782 
            let v4784 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v4783.Register
            let v4785 : (unit -> unit) = closure68(v4743)
            let v4786 : System.Threading.CancellationTokenRegistration = v4784 v4785
            use v4786 = v4786 
            let v4787 : System.Threading.CancellationTokenRegistration = v4786 
            let v4788 : Async<int32> = method153(v4743, v4745, v4783)
            let! v4788 = v4788 
            let v4789 : int32 = v4788 
            let v4791 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v4792 : string seq = v4791 v4745
            let v4796 : (string seq -> string seq) = Seq.rev
            let v4797 : string seq = v4796 v4792
            let v4801 : string = method136()
            let v4802 : (string -> (string seq -> string)) = String.concat
            let v4803 : (string seq -> string) = v4802 v4801
            let v4804 : string = v4803 v4797
            let v4808 : unit = ()
            let v4809 : (unit -> unit) = closure70(v0, v1, v2, v3, v4, v5, v6, v4789, v4804)
            let v4810 : unit = (fun () -> v4809 (); v4808) ()
            return struct (v4789, v4804) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6854 : Async<struct (int32 * string)> = _let'_v4579 
    let _run_target_args'_v11 = v6854 
    #endif
#else
    let v6856 : unit = ()
    let _let'_v6856 =
        async {
            (* run_target_args'
            let v6867 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v6870 : int32, v6871 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6870, v6871) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v6878 : int32, v6879 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6878, v6879) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v6886 : int32, v6887 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6886, v6887) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v6894 : int32, v6895 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6894, v6895) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v6902 : int32, v6903 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6902, v6903) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v6910 : int32, v6911 : string) = null |> unbox<struct (int32 * string)>
            return struct (v6910, v6911) 
            #endif
#else
            let v6916 : US14 = method85(v0)
            let struct (v6928 : string, v6929 : US5) =
                match v6916 with
                | US14_1(v6919) -> (* Error *)
                    let v6921 : string = $"resultm.get / Result value was Error: {v6919}"
                    failwith<struct (string * US5)> v6921
                | US14_0(v6917, v6918) -> (* Ok *)
                    struct (v6917, v6918)
            let v6932 : (string -> US5) = method6()
            let v6933 : US5 option = v6 |> Option.map v6932 
            let v6947 : US5 = US5_1
            let v6948 : US5 = v6933 |> Option.defaultValue v6947 
            let v6955 : string =
                match v6948 with
                | US5_1 -> (* None *)
                    let v6953 : string = ""
                    v6953
                | US5_0(v6952) -> (* Some *)
                    v6952
            let v6956 : unit = ()
            let v6957 : (unit -> unit) = closure63(v0, v1, v2, v3, v4, v5, v6, v6929, v6928)
            let v6958 : unit = (fun () -> v6957 (); v6956) ()
            let v7005 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v7009 : string =
                match v6929 with
                | US5_1 -> (* None *)
                    let v7007 : string = ""
                    v7007
                | US5_0(v7006) -> (* Some *)
                    v7006
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v7009,
              StandardOutputEncoding = v7005,
              WorkingDirectory = v6955,
              FileName = v6928,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v7010 : System.Diagnostics.ProcessStartInfo = start_info
            let v7011 : (struct (string * string) []) = method143(v0, v1, v2, v3, v4, v5, v6)
            let v7012 : int32 = v7011.Length
            let v7013 : Mut6 = {l0 = 0} : Mut6
            while method63(v7012, v7013) do
                let v7015 : int32 = v7013.l0
                let struct (v7016 : string, v7017 : string) = v7011.[int v7015]
                v7010.EnvironmentVariables.[v7016] <- v7017 
                let v7018 : int32 = v7015 + 1
                v7013.l0 <- v7018
                ()
            let v7019 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v7010)
            use v7019 = v7019 
            let v7020 : System.Diagnostics.Process = v7019 
            let v7021 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v7022 : System.Collections.Concurrent.ConcurrentStack<string> = v7021 ()
            let v7023 : bool = false
            let v7024 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v7020, v7022, v7023)
            v7020.OutputDataReceived.Add v7024 
            let v7025 : bool = true
            let v7026 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure64(v0, v1, v2, v3, v4, v5, v6, v7020, v7022, v7025)
            v7020.ErrorDataReceived.Add v7026 
            let v7027 : (unit -> bool) = v7020.Start
            let v7028 : bool = v7027 ()
            let v7029 : bool = v7028 = false
            if v7029 then
                let v7030 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v7030
            let v7031 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v7031 v7020
            let v7032 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v7032 v7020
            let v7035 : (System.Threading.CancellationToken -> US32) = method149()
            let v7036 : US32 option = v1 |> Option.map v7035 
            let v7050 : US32 = US32_1
            let v7051 : US32 = v7036 |> Option.defaultValue v7050 
            let v7058 : System.Threading.CancellationToken =
                match v7051 with
                | US32_1 -> (* None *)
                    let v7056 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v7056
                | US32_0(v7055) -> (* Some *)
                    v7055
            let v7059 : Async<System.Threading.CancellationToken> = method150(v7058)
            let! v7059 = v7059 
            let v7060 : System.Threading.CancellationToken = v7059 
            let v7061 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v7060.Register
            let v7062 : (unit -> unit) = closure68(v7020)
            let v7063 : System.Threading.CancellationTokenRegistration = v7061 v7062
            use v7063 = v7063 
            let v7064 : System.Threading.CancellationTokenRegistration = v7063 
            let v7065 : Async<int32> = method153(v7020, v7022, v7060)
            let! v7065 = v7065 
            let v7066 : int32 = v7065 
            let v7068 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v7069 : string seq = v7068 v7022
            let v7073 : (string seq -> string seq) = Seq.rev
            let v7074 : string seq = v7073 v7069
            let v7078 : string = method136()
            let v7079 : (string -> (string seq -> string)) = String.concat
            let v7080 : (string seq -> string) = v7079 v7078
            let v7081 : string = v7080 v7074
            let v7085 : unit = ()
            let v7086 : (unit -> unit) = closure70(v0, v1, v2, v3, v4, v5, v6, v7066, v7081)
            let v7087 : unit = (fun () -> v7086 (); v7085) ()
            return struct (v7066, v7081) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9131 : Async<struct (int32 * string)> = _let'_v6856 
    let _run_target_args'_v11 = v9131 
    #endif
    let v9132 : Async<struct (int32 * string)> = _run_target_args'_v11 
    v9132
and method139 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method140(v0, v1, v2, v3, v4, v5, v6)
and method83 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    (* run_target_args'
    let v15 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : string = method84(v0, v1, v2, v3, v4, v5, v6)
    let v17 : US14 = method85(v16)
    let struct (v29 : string, v30 : US5) =
        match v17 with
        | US14_1(v20) -> (* Error *)
            let v22 : string = $"resultm.get / Result value was Error: {v20}"
            failwith<struct (string * US5)> v22
        | US14_0(v18, v19) -> (* Ok *)
            struct (v18, v19)
    let v34 : string =
        match v30 with
        | US5_1 -> (* None *)
            let v32 : string = ""
            v32
        | US5_0(v31) -> (* Some *)
            v31
    let v35 : US22 = method98(v34)
    let v44 : (string []) =
        match v35 with
        | US22_1(v37) -> (* Error *)
            let v39 : string = $"resultm.get / Result value was Error: {v37}"
            failwith<(string [])> v39
        | US22_0(v36) -> (* Ok *)
            v36
    let v45 : string = "$0.to_vec()"
    let v46 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v44 v45 
    let v47 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v48 : bool = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let v49 : string = "x"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr () v49 
    (* run_target_args'
    let v55 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v56 
    let _run_target_args'_v55 = v57 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v58 : string = "&*$0"
    let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v58 
    let _run_target_args'_v55 = v59 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : string = "&*$0"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v60 
    let _run_target_args'_v55 = v61 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : Ref<Str> = v50 |> unbox<Ref<Str>>
    let _run_target_args'_v55 = v63 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : Ref<Str> = v50 |> unbox<Ref<Str>>
    let _run_target_args'_v55 = v67 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v71 : Ref<Str> = v50 |> unbox<Ref<Str>>
    let _run_target_args'_v55 = v71 
    #endif
#else
    let v75 : Ref<Str> = v50 |> unbox<Ref<Str>>
    let _run_target_args'_v55 = v75 
    #endif
    let v78 : Ref<Str> = _run_target_args'_v55 
    (* run_target_args'
    let v88 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "String::from($0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v89 
    let _run_target_args'_v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v91 
    let _run_target_args'_v88 = v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : string = "String::from($0)"
    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v93 
    let _run_target_args'_v88 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v88 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v100 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v88 = v100 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v88 = v104 
    #endif
#else
    let v108 : std_string_String = v78 |> unbox<std_string_String>
    let _run_target_args'_v88 = v108 
    #endif
    let v111 : std_string_String = _run_target_args'_v88 
    let v117 : string = "true; $0 }).collect::<Vec<_>>()"
    let v118 : bool = Fable.Core.RustInterop.emitRustExpr v111 v117 
    let v119 : string = "_vec_map"
    let v120 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v119 
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure43(v0, v1, v2, v3, v4, v5, v6, v29, v120)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v175 : bool = true
    let mutable _capture_v175 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v176 : string = "std::process::Command::new(&*$0)"
    let v177 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v29 v176 
    let v178 : string = "true; let mut v177 = v177"
    let v179 : bool = Fable.Core.RustInterop.emitRustExpr () v178 
    let v180 : string = "true; std::process::Command::args(&mut v177, &*$0)"
    let v181 : bool = Fable.Core.RustInterop.emitRustExpr v120 v180 
    let v182 : string = "$0"
    let v183 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v177 v182 
    let v184 : string = "std::process::Stdio::piped()"
    let v185 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v184 
    let v186 : string = "true; let mut v183 = v183"
    let v187 : bool = Fable.Core.RustInterop.emitRustExpr () v186 
    let v188 : string = "true; std::process::Command::stdout(&mut v183, std::process::Stdio::piped())"
    let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
    let v190 : string = "$0"
    let v191 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v183 v190 
    let v192 : string = "std::process::Stdio::piped()"
    let v193 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = "true; let mut v191 = v191"
    let v195 : bool = Fable.Core.RustInterop.emitRustExpr () v194 
    let v196 : string = "true; std::process::Command::stderr(&mut v191, std::process::Stdio::piped())"
    let v197 : bool = Fable.Core.RustInterop.emitRustExpr () v196 
    let v198 : string = "$0"
    let v199 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v191 v198 
    let v200 : string = "std::process::Stdio::piped()"
    let v201 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v200 
    let v202 : string = "true; let mut v199 = v199"
    let v203 : bool = Fable.Core.RustInterop.emitRustExpr () v202 
    let v204 : string = "true; std::process::Command::stdin(&mut v199, std::process::Stdio::piped())"
    let v205 : bool = Fable.Core.RustInterop.emitRustExpr () v204 
    let v206 : string = "$0"
    let v207 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v199 v206 
    let v210 : (string -> US5) = method6()
    let v211 : US5 option = v6 |> Option.map v210 
    let v225 : US5 = US5_1
    let v226 : US5 = v211 |> Option.defaultValue v225 
    let v240 : std_process_Command =
        match v226 with
        | US5_1 -> (* None *)
            let v237 : string = $"v207"
            let v238 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v237 
            v238
        | US5_0(v230) -> (* Some *)
            let v231 : string = "true; let mut v207 = v207"
            let v232 : bool = Fable.Core.RustInterop.emitRustExpr () v231 
            let v233 : string = "true; std::process::Command::current_dir(&mut v207, &*$0)"
            let v234 : bool = Fable.Core.RustInterop.emitRustExpr v230 v233 
            let v235 : string = $"v207"
            let v236 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v235 
            v236
    let v241 : uint64 = System.Convert.ToUInt64 v2.Length
    let v242 : bool = v241 = 0UL
    let v262 : std_process_Command =
        if v242 then
            v240
        else
            let v243 : string = "$0.to_vec()"
            let v244 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v243 
            let v245 : string = "true; let _vec_fold_ = $0.into_iter().fold(v240, |acc, x| { //"
            let v246 : bool = Fable.Core.RustInterop.emitRustExpr v244 v245 
            let v247 : string = "acc"
            let v248 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v247 
            let v249 : string = "x"
            let struct (v250 : string, v251 : string) = Fable.Core.RustInterop.emitRustExpr () v249 
            let v252 : string = "true; let mut v248 = v248"
            let v253 : bool = Fable.Core.RustInterop.emitRustExpr () v252 
            let v254 : string = "true; std::process::Command::env(&mut v248, &*$0, &*$1)"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr struct (v250, v251) v254 
            let v256 : string = "$0"
            let v257 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v248 v256 
            let v258 : string = "true; $0 })"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "_vec_fold_"
            let v261 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v260 
            v261
    let v263 : string = "true; let mut v262 = v262"
    let v264 : bool = Fable.Core.RustInterop.emitRustExpr () v263 
    let v265 : string = "std::process::Command::spawn(&mut v262)"
    let v266 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v265 
    let v267 : (std_io_Error -> std_string_String) = method69()
    (* run_target_args'
    let v269 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v270 : string = "$0.map_err(|x| $1(x))"
    let v271 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v266, v267) v270 
    let _run_target_args'_v269 = v271 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v272 : string = "$0.map_err(|x| $1(x))"
    let v273 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v266, v267) v272 
    let _run_target_args'_v269 = v273 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : string = "$0.map_err(|x| $1(x))"
    let v275 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v266, v267) v274 
    let _run_target_args'_v269 = v275 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v276 : Result<std_process_Child, std_string_String> = match v266 with Ok x -> Ok x | Error x -> Error (v267 x)
    let _run_target_args'_v269 = v276 
    #endif
#if FABLE_COMPILER_PYTHON
    let v277 : Result<std_process_Child, std_string_String> = match v266 with Ok x -> Ok x | Error x -> Error (v267 x)
    let _run_target_args'_v269 = v277 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v278 : Result<std_process_Child, std_string_String> = match v266 with Ok x -> Ok x | Error x -> Error (v267 x)
    let _run_target_args'_v269 = v278 
    #endif
#else
    let v279 : Result<std_process_Child, std_string_String> = match v266 with Ok x -> Ok x | Error x -> Error (v267 x)
    let _run_target_args'_v269 = v279 
    #endif
    let v280 : Result<std_process_Child, std_string_String> = _run_target_args'_v269 
    let v283 : (std_process_Child option -> std_process_Child option) = method110()
    let v284 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v285 : bool = Fable.Core.RustInterop.emitRustExpr v280 v284 
    let v286 : string = "x"
    let v287 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v286 
    let v289 : std_process_Child option = Some v287 
    let v292 : std_process_Child option = v283 v289
    let v293 : string = "std::sync::Mutex::new(v292)"
    let v294 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v293 
    let v295 : string = "std::sync::Arc::new(v294)"
    let v296 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v295 
    let v297 : string = "true; $0 })"
    let v298 : bool = Fable.Core.RustInterop.emitRustExpr v296 v297 
    let v299 : string = "_result_map_"
    let v300 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v299 
    let v301 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US24) = method111()
    let v302 : (std_string_String -> US24) = method112()
    let v303 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v304 : US24 = Fable.Core.RustInterop.emitRustExpr struct (v301, v302, v300) v303 
    let struct (v1607 : int32, v1608 : US6, v1609 : US25) =
        match v304 with
        | US24_1(v1552) -> (* Error *)
            let v1553 : unit = ()
            let v1554 : (unit -> unit) = closure47(v1552)
            let v1555 : unit = (fun () -> v1554 (); v1553) ()
            let v1602 : US6 = US6_0(v1552)
            let v1603 : US25 = US25_1
            struct (-1, v1602, v1603)
        | US24_0(v305) -> (* Ok *)
            let v306 : string = "true; let _capture = (|| { //"
            let v307 : bool = Fable.Core.RustInterop.emitRustExpr () v306 
            let v308 : string = "$0"
            let v309 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v305 v308 
            let v310 : string = "v309.lock()"
            let v311 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v310 
            (* run_target_args'
            let v313 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v314 : string = "$0.unwrap()"
            let v315 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v311 v314 
            let _run_target_args'_v313 = v315 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v316 : string = "$0.unwrap()"
            let v317 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v311 v316 
            let _run_target_args'_v313 = v317 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v318 : string = "$0.unwrap()"
            let v319 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v311 v318 
            let _run_target_args'_v313 = v319 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v320 : std_sync_MutexGuard<std_process_Child option> = match v311 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v313 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : std_sync_MutexGuard<std_process_Child option> = match v311 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v313 = v321 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v322 : std_sync_MutexGuard<std_process_Child option> = match v311 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v313 = v322 
            #endif
#else
            let v323 : std_sync_MutexGuard<std_process_Child option> = match v311 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v313 = v323 
            #endif
            let v324 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v313 
            let v327 : std_sync_MutexGuard<std_process_Child option> = method114(v324)
            let v328 : string = "true; let mut v327 = v327"
            let v329 : bool = Fable.Core.RustInterop.emitRustExpr () v328 
            let v330 : string = "&mut $0"
            let v331 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v327 v330 
            let v332 : string = "$0.as_mut()"
            let v333 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v331 v332 
            let v334 : string = "$0.unwrap()"
            let v335 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v333 v334 
            let v336 : string = "&mut $0.stdout"
            let v337 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v335 v336 
            let v338 : string = "Option::take($0)"
            let v339 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v337 v338 
            let v340 : string = "$0.unwrap()"
            let v341 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v339 v340 
            let v342 : string = "true; $0 })()"
            let v343 : bool = Fable.Core.RustInterop.emitRustExpr v341 v342 
            let v344 : string = "_capture"
            let v345 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v344 
            let v346 : string = "true; let _capture = (|| { //"
            let v347 : bool = Fable.Core.RustInterop.emitRustExpr () v346 
            let v348 : string = "$0"
            let v349 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v305 v348 
            let v350 : string = "v349.lock()"
            let v351 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v350 
            (* run_target_args'
            let v353 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v354 : string = "$0.unwrap()"
            let v355 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v351 v354 
            let _run_target_args'_v353 = v355 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v356 : string = "$0.unwrap()"
            let v357 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v351 v356 
            let _run_target_args'_v353 = v357 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v358 : string = "$0.unwrap()"
            let v359 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v351 v358 
            let _run_target_args'_v353 = v359 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v360 : std_sync_MutexGuard<std_process_Child option> = match v351 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v353 = v360 
            #endif
#if FABLE_COMPILER_PYTHON
            let v361 : std_sync_MutexGuard<std_process_Child option> = match v351 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v353 = v361 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v362 : std_sync_MutexGuard<std_process_Child option> = match v351 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v353 = v362 
            #endif
#else
            let v363 : std_sync_MutexGuard<std_process_Child option> = match v351 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v353 = v363 
            #endif
            let v364 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v353 
            let v367 : std_sync_MutexGuard<std_process_Child option> = method114(v364)
            let v368 : string = "true; let mut v367 = v367"
            let v369 : bool = Fable.Core.RustInterop.emitRustExpr () v368 
            let v370 : string = "&mut $0"
            let v371 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v367 v370 
            let v372 : string = "$0.as_mut()"
            let v373 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v371 v372 
            let v374 : string = "$0.unwrap()"
            let v375 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v373 v374 
            let v376 : string = "&mut $0.stderr"
            let v377 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v375 v376 
            let v378 : string = "Option::take($0)"
            let v379 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v377 v378 
            let v380 : string = "$0.unwrap()"
            let v381 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v379 v380 
            let v382 : string = "true; $0 })()"
            let v383 : bool = Fable.Core.RustInterop.emitRustExpr v381 v382 
            let v384 : string = "_capture"
            let v385 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v384 
            let v386 : string = "true; let _capture = (|| { //"
            let v387 : bool = Fable.Core.RustInterop.emitRustExpr () v386 
            let v388 : string = "$0"
            let v389 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v305 v388 
            let v390 : string = "v389.lock()"
            let v391 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v390 
            (* run_target_args'
            let v393 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v394 : string = "$0.unwrap()"
            let v395 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v391 v394 
            let _run_target_args'_v393 = v395 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v396 : string = "$0.unwrap()"
            let v397 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v391 v396 
            let _run_target_args'_v393 = v397 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v398 : string = "$0.unwrap()"
            let v399 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v391 v398 
            let _run_target_args'_v393 = v399 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v400 : std_sync_MutexGuard<std_process_Child option> = match v391 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v393 = v400 
            #endif
#if FABLE_COMPILER_PYTHON
            let v401 : std_sync_MutexGuard<std_process_Child option> = match v391 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v393 = v401 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v402 : std_sync_MutexGuard<std_process_Child option> = match v391 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v393 = v402 
            #endif
#else
            let v403 : std_sync_MutexGuard<std_process_Child option> = match v391 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v393 = v403 
            #endif
            let v404 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v393 
            let v407 : std_sync_MutexGuard<std_process_Child option> = method114(v404)
            let v408 : string = "true; let mut v407 = v407"
            let v409 : bool = Fable.Core.RustInterop.emitRustExpr () v408 
            let v410 : string = "&mut $0"
            let v411 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v407 v410 
            let v412 : string = "$0.as_mut()"
            let v413 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v411 v412 
            let v414 : string = "$0.unwrap()"
            let v415 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v413 v414 
            let v416 : string = "&mut $0.stdin"
            let v417 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v415 v416 
            let v418 : string = "Option::take($0)"
            let v419 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v417 v418 
            let v420 : string = "$0.unwrap()"
            let v421 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v419 v420 
            let v423 : std_process_ChildStdin option = Some v421 
            let v426 : (std_process_ChildStdin option -> std_process_ChildStdin option) = method115()
            let v427 : std_process_ChildStdin option = v426 v423
            let v428 : string = "std::sync::Mutex::new(v427)"
            let v429 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v428 
            let v430 : string = "std::sync::Arc::new(v429)"
            let v431 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v430 
            let v432 : string = "true; $0 })()"
            let v433 : bool = Fable.Core.RustInterop.emitRustExpr v431 v432 
            let v434 : string = "_capture"
            let v435 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v434 
            let v436 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v437 : std_sync_mpsc_Sender<std_string_String>, v438 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v436 
            let v439 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method116()
            let v440 : std_sync_mpsc_Sender<std_string_String> = v439 v437
            let v441 : string = "std::sync::Mutex::new(v440)"
            let v442 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v441 
            let v443 : string = "std::sync::Arc::new(v442)"
            let v444 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v443 
            let v445 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method117()
            let v446 : std_sync_mpsc_Sender<std_string_String> = v445 v437
            let v447 : string = "std::sync::Mutex::new(v446)"
            let v448 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v447 
            let v449 : string = "std::sync::Arc::new(v448)"
            let v450 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v449 
            let v451 : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = method118()
            let v452 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = v451 v438
            let v453 : string = "std::sync::Mutex::new(v452)"
            let v454 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v453 
            let v455 : string = "std::sync::Arc::new(v454)"
            let v456 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v455 
            let v457 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v458 : bool = Fable.Core.RustInterop.emitRustExpr () v457 
            let v459 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v460 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v345 v459 
            let v461 : string = "std::io::BufReader::new($0)"
            let v462 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v460 v461 
            let v463 : string = "std::io::BufRead::lines(v462)"
            let v464 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v463 
            let v465 : string = "true; let mut v464 = v464; let _iter_try_for_each = v464.try_for_each(|x| { //"
            let v466 : bool = Fable.Core.RustInterop.emitRustExpr () v465 
            let v467 : string = "x"
            let v468 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v467 
            let v469 : string = "$0.clone()"
            let v470 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v444 v469 
            let v471 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v473 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : string = "$0.map_err(|x| $1(x))"
            let v475 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v468, v471) v474 
            let _run_target_args'_v473 = v475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : string = "$0.map_err(|x| $1(x))"
            let v477 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v468, v471) v476 
            let _run_target_args'_v473 = v477 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : string = "$0.map_err(|x| $1(x))"
            let v479 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v468, v471) v478 
            let _run_target_args'_v473 = v479 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v480 : Result<std_string_String, std_string_String> = match v468 with Ok x -> Ok x | Error x -> Error (v471 x)
            let _run_target_args'_v473 = v480 
            #endif
#if FABLE_COMPILER_PYTHON
            let v481 : Result<std_string_String, std_string_String> = match v468 with Ok x -> Ok x | Error x -> Error (v471 x)
            let _run_target_args'_v473 = v481 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v482 : Result<std_string_String, std_string_String> = match v468 with Ok x -> Ok x | Error x -> Error (v471 x)
            let _run_target_args'_v473 = v482 
            #endif
#else
            let v483 : Result<std_string_String, std_string_String> = match v468 with Ok x -> Ok x | Error x -> Error (v471 x)
            let _run_target_args'_v473 = v483 
            #endif
            let v484 : Result<std_string_String, std_string_String> = _run_target_args'_v473 
            let v487 : (std_string_String -> US26) = method119()
            let v488 : (std_string_String -> US26) = method120()
            let v489 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v490 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v487, v488, v484) v489 
            let v727 : std_string_String =
                match v490 with
                | US26_1(v609) -> (* Error *)
                    let v610 : unit = ()
                    let v611 : (unit -> unit) = closure53(v5, v609)
                    let v612 : unit = (fun () -> v611 (); v610) ()
                    let v659 : string = $"\u001b[4;7m{v609}\u001b[0m"
                    (* run_target_args'
                    let v664 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v665 : string = "&*$0"
                    let v666 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v659 v665 
                    let _run_target_args'_v664 = v666 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v667 : string = "&*$0"
                    let v668 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v659 v667 
                    let _run_target_args'_v664 = v668 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v669 : string = "&*$0"
                    let v670 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v659 v669 
                    let _run_target_args'_v664 = v670 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v672 : Ref<Str> = v659 |> unbox<Ref<Str>>
                    let _run_target_args'_v664 = v672 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v676 : Ref<Str> = v659 |> unbox<Ref<Str>>
                    let _run_target_args'_v664 = v676 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v680 : Ref<Str> = v659 |> unbox<Ref<Str>>
                    let _run_target_args'_v664 = v680 
                    #endif
#else
                    let v684 : Ref<Str> = v659 |> unbox<Ref<Str>>
                    let _run_target_args'_v664 = v684 
                    #endif
                    let v687 : Ref<Str> = _run_target_args'_v664 
                    (* run_target_args'
                    let v697 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v698 : string = "String::from($0)"
                    let v699 : std_string_String = Fable.Core.RustInterop.emitRustExpr v687 v698 
                    let _run_target_args'_v697 = v699 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v700 : string = "String::from($0)"
                    let v701 : std_string_String = Fable.Core.RustInterop.emitRustExpr v687 v700 
                    let _run_target_args'_v697 = v701 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v702 : string = "String::from($0)"
                    let v703 : std_string_String = Fable.Core.RustInterop.emitRustExpr v687 v702 
                    let _run_target_args'_v697 = v703 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v705 : std_string_String = v687 |> unbox<std_string_String>
                    let _run_target_args'_v697 = v705 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v709 : std_string_String = v687 |> unbox<std_string_String>
                    let _run_target_args'_v697 = v709 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v713 : std_string_String = v687 |> unbox<std_string_String>
                    let _run_target_args'_v697 = v713 
                    #endif
#else
                    let v717 : std_string_String = v687 |> unbox<std_string_String>
                    let _run_target_args'_v697 = v717 
                    #endif
                    let v720 : std_string_String = _run_target_args'_v697 
                    v720
                | US26_0(v491) -> (* Ok *)
                    let v492 : string = "fable_library_rust::String_::fromString($0)"
                    let v493 : string = Fable.Core.RustInterop.emitRustExpr v491 v492 
                    let v494 : string = "encoding_rs::UTF_8"
                    let v495 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v494 
                    let v496 : string = "$0.encode(&*$1).0"
                    let v497 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v495, v493) v496 
                    let v498 : string = "$0.as_ref()"
                    let v499 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v497 v498 
                    let v500 : string = "std::str::from_utf8($0)"
                    let v501 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v499 v500 
                    (* run_target_args'
                    let v503 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v504 : string = "$0.unwrap()"
                    let v505 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v501 v504 
                    let _run_target_args'_v503 = v505 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v506 : string = "$0.unwrap()"
                    let v507 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v501 v506 
                    let _run_target_args'_v503 = v507 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v508 : string = "$0.unwrap()"
                    let v509 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v501 v508 
                    let _run_target_args'_v503 = v509 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v510 : Ref<Str> = match v501 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v503 = v510 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v511 : Ref<Str> = match v501 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v503 = v511 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v512 : Ref<Str> = match v501 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v503 = v512 
                    #endif
#else
                    let v513 : Ref<Str> = match v501 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v503 = v513 
                    #endif
                    let v514 : Ref<Str> = _run_target_args'_v503 
                    (* run_target_args'
                    let v521 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v522 : string = "String::from($0)"
                    let v523 : std_string_String = Fable.Core.RustInterop.emitRustExpr v514 v522 
                    let _run_target_args'_v521 = v523 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v524 : string = "String::from($0)"
                    let v525 : std_string_String = Fable.Core.RustInterop.emitRustExpr v514 v524 
                    let _run_target_args'_v521 = v525 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v526 : string = "String::from($0)"
                    let v527 : std_string_String = Fable.Core.RustInterop.emitRustExpr v514 v526 
                    let _run_target_args'_v521 = v527 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v529 : std_string_String = v514 |> unbox<std_string_String>
                    let _run_target_args'_v521 = v529 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v533 : std_string_String = v514 |> unbox<std_string_String>
                    let _run_target_args'_v521 = v533 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v537 : std_string_String = v514 |> unbox<std_string_String>
                    let _run_target_args'_v521 = v537 
                    #endif
#else
                    let v541 : std_string_String = v514 |> unbox<std_string_String>
                    let _run_target_args'_v521 = v541 
                    #endif
                    let v544 : std_string_String = _run_target_args'_v521 
                    let v550 : string = "fable_library_rust::String_::fromString($0)"
                    let v551 : string = Fable.Core.RustInterop.emitRustExpr v544 v550 
                    let v552 : string = $"> {v551}"
                    if v5 then
                        let v553 : unit = ()
                        let v554 : (unit -> unit) = closure54(v552)
                        let v555 : unit = (fun () -> v554 (); v553) ()
                        ()
                    else
                        let v605 : unit = ()
                        let v606 : (unit -> unit) = closure11(v552)
                        let v607 : unit = (fun () -> v606 (); v605) ()
                        ()
                    v544
            let v728 : string = "$0"
            let v729 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v470 v728 
            let v730 : string = "v729.lock()"
            let v731 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v730 
            (* run_target_args'
            let v733 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v734 : string = "$0.unwrap()"
            let v735 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v731 v734 
            let _run_target_args'_v733 = v735 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v736 : string = "$0.unwrap()"
            let v737 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v731 v736 
            let _run_target_args'_v733 = v737 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v738 : string = "$0.unwrap()"
            let v739 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v731 v738 
            let _run_target_args'_v733 = v739 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v740 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v731 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v733 = v740 
            #endif
#if FABLE_COMPILER_PYTHON
            let v741 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v731 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v733 = v741 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v742 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v731 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v733 = v742 
            #endif
#else
            let v743 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v731 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v733 = v743 
            #endif
            let v744 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v733 
            let v747 : string = "&$0"
            let v748 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v744 v747 
            let v749 : string = "$0.send($1)"
            let v750 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v748, v727) v749 
            let v751 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method126()
            (* run_target_args'
            let v753 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v754 : string = "$0.map_err(|x| $1(x))"
            let v755 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v750, v751) v754 
            let _run_target_args'_v753 = v755 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v756 : string = "$0.map_err(|x| $1(x))"
            let v757 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v750, v751) v756 
            let _run_target_args'_v753 = v757 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v758 : string = "$0.map_err(|x| $1(x))"
            let v759 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v750, v751) v758 
            let _run_target_args'_v753 = v759 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v760 : Result<unit, std_string_String> = match v750 with Ok x -> Ok x | Error x -> Error (v751 x)
            let _run_target_args'_v753 = v760 
            #endif
#if FABLE_COMPILER_PYTHON
            let v761 : Result<unit, std_string_String> = match v750 with Ok x -> Ok x | Error x -> Error (v751 x)
            let _run_target_args'_v753 = v761 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v762 : Result<unit, std_string_String> = match v750 with Ok x -> Ok x | Error x -> Error (v751 x)
            let _run_target_args'_v753 = v762 
            #endif
#else
            let v763 : Result<unit, std_string_String> = match v750 with Ok x -> Ok x | Error x -> Error (v751 x)
            let _run_target_args'_v753 = v763 
            #endif
            let v764 : Result<unit, std_string_String> = _run_target_args'_v753 
            let v767 : string = "$0"
            let v768 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v764 v767 
            let v769 : string = "true; $0 }); //"
            let v770 : bool = Fable.Core.RustInterop.emitRustExpr v768 v769 
            let v771 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v772 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v771 
            let v773 : Result<unit, string> = method127(v772)
            let v774 : string = ""
            let v775 : string = "}"
            let v776 : string = v774 + v775 
            let x = v773 //
            let v777 : _ = x
            let v778 : unit = ()
            (* run_target_args'
            let v779 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v780 : string = $"true; let _fix_closure_v778 = $0"
            let v781 : bool = Fable.Core.RustInterop.emitRustExpr v777 v780 
            let _run_target_args'_v779 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v782 : string = $"true; let _fix_closure_v778 = $0"
            let v783 : bool = Fable.Core.RustInterop.emitRustExpr v777 v782 
            let _run_target_args'_v779 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v784 : string = $"true; let _fix_closure_v778 = $0"
            let v785 : bool = Fable.Core.RustInterop.emitRustExpr v777 v784 
            let _run_target_args'_v779 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v779 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v779 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v779 = false 
            #endif
#else
            let _run_target_args'_v779 = false 
            #endif
            let v786 : bool = _run_target_args'_v779 
            let v788 : string = $"true; _fix_closure_v778 " + v776 + "); " + v774 + " // rust.fix_closure'"
            let v789 : bool = Fable.Core.RustInterop.emitRustExpr () v788 
            let v790 : string = "__spawn"
            let v791 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v790 
            let v792 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v793 : bool = Fable.Core.RustInterop.emitRustExpr () v792 
            let v794 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v795 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v385 v794 
            let v796 : string = "std::io::BufReader::new($0)"
            let v797 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v795 v796 
            let v798 : string = "std::io::BufRead::lines(v797)"
            let v799 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v798 
            let v800 : string = "true; let mut v799 = v799; let _iter_try_for_each = v799.try_for_each(|x| { //"
            let v801 : bool = Fable.Core.RustInterop.emitRustExpr () v800 
            let v802 : string = "x"
            let v803 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v802 
            let v804 : string = "$0.clone()"
            let v805 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v450 v804 
            let v806 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v808 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v809 : string = "$0.map_err(|x| $1(x))"
            let v810 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v803, v806) v809 
            let _run_target_args'_v808 = v810 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v811 : string = "$0.map_err(|x| $1(x))"
            let v812 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v803, v806) v811 
            let _run_target_args'_v808 = v812 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v813 : string = "$0.map_err(|x| $1(x))"
            let v814 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v803, v806) v813 
            let _run_target_args'_v808 = v814 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v815 : Result<std_string_String, std_string_String> = match v803 with Ok x -> Ok x | Error x -> Error (v806 x)
            let _run_target_args'_v808 = v815 
            #endif
#if FABLE_COMPILER_PYTHON
            let v816 : Result<std_string_String, std_string_String> = match v803 with Ok x -> Ok x | Error x -> Error (v806 x)
            let _run_target_args'_v808 = v816 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v817 : Result<std_string_String, std_string_String> = match v803 with Ok x -> Ok x | Error x -> Error (v806 x)
            let _run_target_args'_v808 = v817 
            #endif
#else
            let v818 : Result<std_string_String, std_string_String> = match v803 with Ok x -> Ok x | Error x -> Error (v806 x)
            let _run_target_args'_v808 = v818 
            #endif
            let v819 : Result<std_string_String, std_string_String> = _run_target_args'_v808 
            let v822 : (std_string_String -> US26) = method119()
            let v823 : (std_string_String -> US26) = method120()
            let v824 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v825 : US26 = Fable.Core.RustInterop.emitRustExpr struct (v822, v823, v819) v824 
            let v1128 : std_string_String =
                match v825 with
                | US26_1(v1010) -> (* Error *)
                    let v1011 : unit = ()
                    let v1012 : (unit -> unit) = closure53(v5, v1010)
                    let v1013 : unit = (fun () -> v1012 (); v1011) ()
                    let v1060 : string = $"\u001b[4;7m{v1010}\u001b[0m"
                    (* run_target_args'
                    let v1065 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1066 : string = "&*$0"
                    let v1067 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1060 v1066 
                    let _run_target_args'_v1065 = v1067 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1068 : string = "&*$0"
                    let v1069 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1060 v1068 
                    let _run_target_args'_v1065 = v1069 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1070 : string = "&*$0"
                    let v1071 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1060 v1070 
                    let _run_target_args'_v1065 = v1071 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1073 : Ref<Str> = v1060 |> unbox<Ref<Str>>
                    let _run_target_args'_v1065 = v1073 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1077 : Ref<Str> = v1060 |> unbox<Ref<Str>>
                    let _run_target_args'_v1065 = v1077 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1081 : Ref<Str> = v1060 |> unbox<Ref<Str>>
                    let _run_target_args'_v1065 = v1081 
                    #endif
#else
                    let v1085 : Ref<Str> = v1060 |> unbox<Ref<Str>>
                    let _run_target_args'_v1065 = v1085 
                    #endif
                    let v1088 : Ref<Str> = _run_target_args'_v1065 
                    (* run_target_args'
                    let v1098 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1099 : string = "String::from($0)"
                    let v1100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1088 v1099 
                    let _run_target_args'_v1098 = v1100 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1101 : string = "String::from($0)"
                    let v1102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1088 v1101 
                    let _run_target_args'_v1098 = v1102 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1103 : string = "String::from($0)"
                    let v1104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1088 v1103 
                    let _run_target_args'_v1098 = v1104 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1106 : std_string_String = v1088 |> unbox<std_string_String>
                    let _run_target_args'_v1098 = v1106 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1110 : std_string_String = v1088 |> unbox<std_string_String>
                    let _run_target_args'_v1098 = v1110 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1114 : std_string_String = v1088 |> unbox<std_string_String>
                    let _run_target_args'_v1098 = v1114 
                    #endif
#else
                    let v1118 : std_string_String = v1088 |> unbox<std_string_String>
                    let _run_target_args'_v1098 = v1118 
                    #endif
                    let v1121 : std_string_String = _run_target_args'_v1098 
                    v1121
                | US26_0(v826) -> (* Ok *)
                    let v827 : string = "fable_library_rust::String_::fromString($0)"
                    let v828 : string = Fable.Core.RustInterop.emitRustExpr v826 v827 
                    let v829 : string = "encoding_rs::UTF_8"
                    let v830 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v829 
                    let v831 : string = "$0.encode(&*$1).0"
                    let v832 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v830, v828) v831 
                    let v833 : string = "$0.as_ref()"
                    let v834 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v832 v833 
                    let v835 : string = "std::str::from_utf8($0)"
                    let v836 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v834 v835 
                    (* run_target_args'
                    let v838 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v839 : string = "$0.unwrap()"
                    let v840 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v839 
                    let _run_target_args'_v838 = v840 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v841 : string = "$0.unwrap()"
                    let v842 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v841 
                    let _run_target_args'_v838 = v842 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v843 : string = "$0.unwrap()"
                    let v844 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v843 
                    let _run_target_args'_v838 = v844 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v845 : Ref<Str> = match v836 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v838 = v845 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v846 : Ref<Str> = match v836 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v838 = v846 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v847 : Ref<Str> = match v836 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v838 = v847 
                    #endif
#else
                    let v848 : Ref<Str> = match v836 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v838 = v848 
                    #endif
                    let v849 : Ref<Str> = _run_target_args'_v838 
                    (* run_target_args'
                    let v856 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v857 : string = "String::from($0)"
                    let v858 : std_string_String = Fable.Core.RustInterop.emitRustExpr v849 v857 
                    let _run_target_args'_v856 = v858 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v859 : string = "String::from($0)"
                    let v860 : std_string_String = Fable.Core.RustInterop.emitRustExpr v849 v859 
                    let _run_target_args'_v856 = v860 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v861 : string = "String::from($0)"
                    let v862 : std_string_String = Fable.Core.RustInterop.emitRustExpr v849 v861 
                    let _run_target_args'_v856 = v862 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v864 : std_string_String = v849 |> unbox<std_string_String>
                    let _run_target_args'_v856 = v864 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v868 : std_string_String = v849 |> unbox<std_string_String>
                    let _run_target_args'_v856 = v868 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v872 : std_string_String = v849 |> unbox<std_string_String>
                    let _run_target_args'_v856 = v872 
                    #endif
#else
                    let v876 : std_string_String = v849 |> unbox<std_string_String>
                    let _run_target_args'_v856 = v876 
                    #endif
                    let v879 : std_string_String = _run_target_args'_v856 
                    let v885 : string = "fable_library_rust::String_::fromString($0)"
                    let v886 : string = Fable.Core.RustInterop.emitRustExpr v879 v885 
                    let v887 : string = $"! {v886}"
                    if v5 then
                        let v888 : unit = ()
                        let v889 : (unit -> unit) = closure54(v887)
                        let v890 : unit = (fun () -> v889 (); v888) ()
                        ()
                    else
                        let v939 : unit = ()
                        let v940 : (unit -> unit) = closure11(v887)
                        let v941 : unit = (fun () -> v940 (); v939) ()
                        ()
                    let v943 : string = $"\u001b[4;7m{v879}\u001b[0m"
                    (* run_target_args'
                    let v948 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v949 : string = "&*$0"
                    let v950 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v943 v949 
                    let _run_target_args'_v948 = v950 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v951 : string = "&*$0"
                    let v952 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v943 v951 
                    let _run_target_args'_v948 = v952 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v953 : string = "&*$0"
                    let v954 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v943 v953 
                    let _run_target_args'_v948 = v954 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v956 : Ref<Str> = v943 |> unbox<Ref<Str>>
                    let _run_target_args'_v948 = v956 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v960 : Ref<Str> = v943 |> unbox<Ref<Str>>
                    let _run_target_args'_v948 = v960 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v964 : Ref<Str> = v943 |> unbox<Ref<Str>>
                    let _run_target_args'_v948 = v964 
                    #endif
#else
                    let v968 : Ref<Str> = v943 |> unbox<Ref<Str>>
                    let _run_target_args'_v948 = v968 
                    #endif
                    let v971 : Ref<Str> = _run_target_args'_v948 
                    (* run_target_args'
                    let v981 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v982 : string = "String::from($0)"
                    let v983 : std_string_String = Fable.Core.RustInterop.emitRustExpr v971 v982 
                    let _run_target_args'_v981 = v983 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v984 : string = "String::from($0)"
                    let v985 : std_string_String = Fable.Core.RustInterop.emitRustExpr v971 v984 
                    let _run_target_args'_v981 = v985 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v986 : string = "String::from($0)"
                    let v987 : std_string_String = Fable.Core.RustInterop.emitRustExpr v971 v986 
                    let _run_target_args'_v981 = v987 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v989 : std_string_String = v971 |> unbox<std_string_String>
                    let _run_target_args'_v981 = v989 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v993 : std_string_String = v971 |> unbox<std_string_String>
                    let _run_target_args'_v981 = v993 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v997 : std_string_String = v971 |> unbox<std_string_String>
                    let _run_target_args'_v981 = v997 
                    #endif
#else
                    let v1001 : std_string_String = v971 |> unbox<std_string_String>
                    let _run_target_args'_v981 = v1001 
                    #endif
                    let v1004 : std_string_String = _run_target_args'_v981 
                    v1004
            let v1129 : string = "$0"
            let v1130 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v805 v1129 
            let v1131 : string = "v1130.lock()"
            let v1132 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1131 
            (* run_target_args'
            let v1134 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1135 : string = "$0.unwrap()"
            let v1136 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1132 v1135 
            let _run_target_args'_v1134 = v1136 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1137 : string = "$0.unwrap()"
            let v1138 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1132 v1137 
            let _run_target_args'_v1134 = v1138 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1139 : string = "$0.unwrap()"
            let v1140 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1132 v1139 
            let _run_target_args'_v1134 = v1140 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1141 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1132 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1134 = v1141 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1142 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1132 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1134 = v1142 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1143 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1132 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1134 = v1143 
            #endif
#else
            let v1144 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v1132 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1134 = v1144 
            #endif
            let v1145 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _run_target_args'_v1134 
            let v1148 : string = "&$0"
            let v1149 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1145 v1148 
            let v1150 : string = "$0.send($1)"
            let v1151 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v1149, v1128) v1150 
            let v1152 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method126()
            (* run_target_args'
            let v1154 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1155 : string = "$0.map_err(|x| $1(x))"
            let v1156 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1151, v1152) v1155 
            let _run_target_args'_v1154 = v1156 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1157 : string = "$0.map_err(|x| $1(x))"
            let v1158 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1151, v1152) v1157 
            let _run_target_args'_v1154 = v1158 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1159 : string = "$0.map_err(|x| $1(x))"
            let v1160 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1151, v1152) v1159 
            let _run_target_args'_v1154 = v1160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1161 : Result<unit, std_string_String> = match v1151 with Ok x -> Ok x | Error x -> Error (v1152 x)
            let _run_target_args'_v1154 = v1161 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1162 : Result<unit, std_string_String> = match v1151 with Ok x -> Ok x | Error x -> Error (v1152 x)
            let _run_target_args'_v1154 = v1162 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1163 : Result<unit, std_string_String> = match v1151 with Ok x -> Ok x | Error x -> Error (v1152 x)
            let _run_target_args'_v1154 = v1163 
            #endif
#else
            let v1164 : Result<unit, std_string_String> = match v1151 with Ok x -> Ok x | Error x -> Error (v1152 x)
            let _run_target_args'_v1154 = v1164 
            #endif
            let v1165 : Result<unit, std_string_String> = _run_target_args'_v1154 
            let v1168 : string = "$0"
            let v1169 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1165 v1168 
            let v1170 : string = "true; $0 }); //"
            let v1171 : bool = Fable.Core.RustInterop.emitRustExpr v1169 v1170 
            let v1172 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1173 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1172 
            let v1174 : Result<unit, string> = method127(v1173)
            let v1175 : string = v774 + v775 
            let x = v1174 //
            let v1176 : _ = x
            let v1177 : unit = ()
            (* run_target_args'
            let v1178 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1179 : string = $"true; let _fix_closure_v1177 = $0"
            let v1180 : bool = Fable.Core.RustInterop.emitRustExpr v1176 v1179 
            let _run_target_args'_v1178 = true 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1181 : string = $"true; let _fix_closure_v1177 = $0"
            let v1182 : bool = Fable.Core.RustInterop.emitRustExpr v1176 v1181 
            let _run_target_args'_v1178 = true 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1183 : string = $"true; let _fix_closure_v1177 = $0"
            let v1184 : bool = Fable.Core.RustInterop.emitRustExpr v1176 v1183 
            let _run_target_args'_v1178 = true 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _run_target_args'_v1178 = false 
            #endif
#if FABLE_COMPILER_PYTHON
            let _run_target_args'_v1178 = false 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _run_target_args'_v1178 = false 
            #endif
#else
            let _run_target_args'_v1178 = false 
            #endif
            let v1185 : bool = _run_target_args'_v1178 
            let v1187 : string = $"true; _fix_closure_v1177 " + v1175 + "); " + v774 + " // rust.fix_closure'"
            let v1188 : bool = Fable.Core.RustInterop.emitRustExpr () v1187 
            let v1189 : string = "__spawn"
            let v1190 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1189 
            let v1193 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US27) = method128()
            let v1194 : US27 option = v4 |> Option.map v1193 
            let v1208 : US27 = US27_1
            let v1209 : US27 = v1194 |> Option.defaultValue v1208 
            match v1209 with
            | US27_1 -> (* None *)
                ()
            | US27_0(v1213) -> (* Some *)
                let v1214 : string = "$0"
                let v1215 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v435 v1214 
                let v1216 : string = "v1215.lock()"
                let v1217 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v1216 
                (* run_target_args'
                let v1219 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1220 : string = "$0.unwrap()"
                let v1221 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1217 v1220 
                let _run_target_args'_v1219 = v1221 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1222 : string = "$0.unwrap()"
                let v1223 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1217 v1222 
                let _run_target_args'_v1219 = v1223 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1224 : string = "$0.unwrap()"
                let v1225 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1217 v1224 
                let _run_target_args'_v1219 = v1225 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1226 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1219 = v1226 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1227 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1219 = v1227 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1228 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1219 = v1228 
                #endif
#else
                let v1229 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _run_target_args'_v1219 = v1229 
                #endif
                let v1230 : std_sync_MutexGuard<std_process_ChildStdin option> = _run_target_args'_v1219 
                let v1233 : std_sync_MutexGuard<std_process_ChildStdin option> = method129(v1230)
                let v1234 : string = "true; let mut v1233 = v1233"
                let v1235 : bool = Fable.Core.RustInterop.emitRustExpr () v1234 
                let v1236 : string = "&mut $0"
                let v1237 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v1233 v1236 
                let v1238 : string = "Option::take($0)"
                let v1239 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v1237 v1238 
                let v1240 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v1241 : bool = Fable.Core.RustInterop.emitRustExpr v1239 v1240 
                let v1242 : string = "x"
                let v1243 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v1242 
                let v1244 : string = "std::sync::Mutex::new(v1243)"
                let v1245 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v1244 
                let v1246 : string = "std::sync::Arc::new(v1245)"
                let v1247 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v1246 
                let v1248 : string = "true; $0 })"
                let v1249 : bool = Fable.Core.RustInterop.emitRustExpr v1247 v1248 
                let v1250 : string = "_optionm_map_"
                let v1251 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v1250 
                let v1254 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US28) = method130()
                let v1255 : US28 option = v1251 |> Option.map v1254 
                let v1269 : US28 = US28_1
                let v1270 : US28 = v1255 |> Option.defaultValue v1269 
                match v1270 with
                | US28_1 -> (* None *)
                    ()
                | US28_0(v1274) -> (* Some *)
                    v1213 v1274
                    let v1275 : string = "$0"
                    let v1276 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1274 v1275 
                    let v1277 : string = "v1276.lock()"
                    let v1278 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v1277 
                    (* run_target_args'
                    let v1280 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1281 : string = "$0.unwrap()"
                    let v1282 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1278 v1281 
                    let _run_target_args'_v1280 = v1282 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1283 : string = "$0.unwrap()"
                    let v1284 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1278 v1283 
                    let _run_target_args'_v1280 = v1284 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1285 : string = "$0.unwrap()"
                    let v1286 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1278 v1285 
                    let _run_target_args'_v1280 = v1286 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1287 : std_sync_MutexGuard<std_process_ChildStdin> = match v1278 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1280 = v1287 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1288 : std_sync_MutexGuard<std_process_ChildStdin> = match v1278 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1280 = v1288 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1289 : std_sync_MutexGuard<std_process_ChildStdin> = match v1278 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1280 = v1289 
                    #endif
#else
                    let v1290 : std_sync_MutexGuard<std_process_ChildStdin> = match v1278 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v1280 = v1290 
                    #endif
                    let v1291 : std_sync_MutexGuard<std_process_ChildStdin> = _run_target_args'_v1280 
                    let v1294 : std_sync_MutexGuard<std_process_ChildStdin> = method131(v1291)
                    let v1295 : string = "true; let mut v1294 = v1294"
                    let v1296 : bool = Fable.Core.RustInterop.emitRustExpr () v1295 
                    let v1297 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v1298 : bool = Fable.Core.RustInterop.emitRustExpr v1294 v1297 
                    ()
            let v1299 : string = "$0"
            let v1300 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v305 v1299 
            let v1301 : string = "v1300.lock()"
            let v1302 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v1301 
            (* run_target_args'
            let v1304 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1305 : string = "$0.unwrap()"
            let v1306 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1302 v1305 
            let _run_target_args'_v1304 = v1306 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1307 : string = "$0.unwrap()"
            let v1308 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1302 v1307 
            let _run_target_args'_v1304 = v1308 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1309 : string = "$0.unwrap()"
            let v1310 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1302 v1309 
            let _run_target_args'_v1304 = v1310 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1311 : std_sync_MutexGuard<std_process_Child option> = match v1302 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1304 = v1311 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1312 : std_sync_MutexGuard<std_process_Child option> = match v1302 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1304 = v1312 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1313 : std_sync_MutexGuard<std_process_Child option> = match v1302 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1304 = v1313 
            #endif
#else
            let v1314 : std_sync_MutexGuard<std_process_Child option> = match v1302 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1304 = v1314 
            #endif
            let v1315 : std_sync_MutexGuard<std_process_Child option> = _run_target_args'_v1304 
            let v1318 : std_sync_MutexGuard<std_process_Child option> = method114(v1315)
            let v1319 : string = "true; let mut v1318 = v1318"
            let v1320 : bool = Fable.Core.RustInterop.emitRustExpr () v1319 
            let v1321 : string = "&mut $0"
            let v1322 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v1318 v1321 
            let v1323 : string = "Option::take($0)"
            let v1324 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v1322 v1323 
            let v1325 : string = "$0.unwrap()"
            let v1326 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v1324 v1325 
            let v1327 : string = "$0.wait_with_output()"
            let v1328 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1326 v1327 
            let v1329 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v1331 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1332 : string = "$0.map_err(|x| $1(x))"
            let v1333 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1328, v1329) v1332 
            let _run_target_args'_v1331 = v1333 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1334 : string = "$0.map_err(|x| $1(x))"
            let v1335 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1328, v1329) v1334 
            let _run_target_args'_v1331 = v1335 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1336 : string = "$0.map_err(|x| $1(x))"
            let v1337 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1328, v1329) v1336 
            let _run_target_args'_v1331 = v1337 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1338 : Result<std_process_Output, std_string_String> = match v1328 with Ok x -> Ok x | Error x -> Error (v1329 x)
            let _run_target_args'_v1331 = v1338 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1339 : Result<std_process_Output, std_string_String> = match v1328 with Ok x -> Ok x | Error x -> Error (v1329 x)
            let _run_target_args'_v1331 = v1339 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1340 : Result<std_process_Output, std_string_String> = match v1328 with Ok x -> Ok x | Error x -> Error (v1329 x)
            let _run_target_args'_v1331 = v1340 
            #endif
#else
            let v1341 : Result<std_process_Output, std_string_String> = match v1328 with Ok x -> Ok x | Error x -> Error (v1329 x)
            let _run_target_args'_v1331 = v1341 
            #endif
            let v1342 : Result<std_process_Output, std_string_String> = _run_target_args'_v1331 
            let v1345 : string = "v1190"
            let v1346 : string = v1345 + v774 
            let v1347 : string = v1346 + v774 
            let v1348 : string = "v791"
            let v1349 : string = ", "
            let v1350 : string = v1348 + v1349 
            let v1351 : string = v1350 + v1347 
            let v1352 : string = "vec![" + v1351 + "]"
            let v1353 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v1352 
            let v1354 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1355 : bool = Fable.Core.RustInterop.emitRustExpr v1353 v1354 
            let v1356 : string = "x"
            let v1357 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1356 
            let v1358 : string = "std::thread::JoinHandle::join($0)"
            let v1359 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v1357 v1358 
            (* run_target_args'
            let v1361 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1362 : string = "$0.unwrap()"
            let v1363 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1359 v1362 
            let _run_target_args'_v1361 = v1363 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1364 : string = "$0.unwrap()"
            let v1365 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1359 v1364 
            let _run_target_args'_v1361 = v1365 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1366 : string = "$0.unwrap()"
            let v1367 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1359 v1366 
            let _run_target_args'_v1361 = v1367 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1368 : Result<unit, string> = match v1359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1361 = v1368 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1369 : Result<unit, string> = match v1359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1361 = v1369 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1370 : Result<unit, string> = match v1359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1361 = v1370 
            #endif
#else
            let v1371 : Result<unit, string> = match v1359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v1361 = v1371 
            #endif
            let v1372 : Result<unit, string> = _run_target_args'_v1361 
            (* run_target_args'
            let v1375 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1376 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1372 v1376 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1377 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1372 v1377 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1378 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1372 v1378 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v1372 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if FABLE_COMPILER_PYTHON
            match v1372 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v1372 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#else
            match v1372 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
            // run_target_args' is_unit
            let v1379 : string = $"true"
            let v1380 : bool = Fable.Core.RustInterop.emitRustExpr () v1379 
            let v1381 : string = "true; }}); { //"
            let v1382 : bool = Fable.Core.RustInterop.emitRustExpr () v1381 
            let v1383 : (std_process_Output -> US29) = method132()
            let v1384 : (std_string_String -> US29) = method133()
            let v1386 : US29 = match v1342 with Ok x -> v1383 x | Error x -> v1384 x
            match v1386 with
            | US29_1(v1494) -> (* Error *)
                let v1495 : unit = ()
                let v1496 : (unit -> unit) = closure60(v1494)
                let v1497 : unit = (fun () -> v1496 (); v1495) ()
                let v1544 : US6 = US6_0(v1494)
                let v1545 : US25 = US25_1
                struct (-2, v1544, v1545)
            | US29_0(v1389) -> (* Ok *)
                let v1390 : string = "$0.status"
                let v1391 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v1389 v1390 
                let v1392 : string = "$0.code()"
                let v1393 : int32 option = Fable.Core.RustInterop.emitRustExpr v1391 v1392 
                let v1396 : (int32 -> US30) = method135()
                let v1397 : US30 option = v1393 |> Option.map v1396 
                let v1411 : US30 = US30_1
                let v1412 : US30 = v1397 |> Option.defaultValue v1411 
                match v1412 with
                | US30_1 -> (* None *)
                    let v1419 : string = "runtime.execute_with_options / exit_code=None"
                    (* run_target_args'
                    let v1424 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1425 : string = "&*$0"
                    let v1426 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1419 v1425 
                    let _run_target_args'_v1424 = v1426 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1427 : string = "&*$0"
                    let v1428 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1419 v1427 
                    let _run_target_args'_v1424 = v1428 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1429 : string = "&*$0"
                    let v1430 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1419 v1429 
                    let _run_target_args'_v1424 = v1430 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1432 : Ref<Str> = v1419 |> unbox<Ref<Str>>
                    let _run_target_args'_v1424 = v1432 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1436 : Ref<Str> = v1419 |> unbox<Ref<Str>>
                    let _run_target_args'_v1424 = v1436 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1440 : Ref<Str> = v1419 |> unbox<Ref<Str>>
                    let _run_target_args'_v1424 = v1440 
                    #endif
#else
                    let v1444 : Ref<Str> = v1419 |> unbox<Ref<Str>>
                    let _run_target_args'_v1424 = v1444 
                    #endif
                    let v1447 : Ref<Str> = _run_target_args'_v1424 
                    (* run_target_args'
                    let v1457 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1458 : string = "String::from($0)"
                    let v1459 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1447 v1458 
                    let _run_target_args'_v1457 = v1459 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1460 : string = "String::from($0)"
                    let v1461 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1447 v1460 
                    let _run_target_args'_v1457 = v1461 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1462 : string = "String::from($0)"
                    let v1463 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1447 v1462 
                    let _run_target_args'_v1457 = v1463 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1465 : std_string_String = v1447 |> unbox<std_string_String>
                    let _run_target_args'_v1457 = v1465 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1469 : std_string_String = v1447 |> unbox<std_string_String>
                    let _run_target_args'_v1457 = v1469 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1473 : std_string_String = v1447 |> unbox<std_string_String>
                    let _run_target_args'_v1457 = v1473 
                    #endif
#else
                    let v1477 : std_string_String = v1447 |> unbox<std_string_String>
                    let _run_target_args'_v1457 = v1477 
                    #endif
                    let v1480 : std_string_String = _run_target_args'_v1457 
                    let v1486 : US6 = US6_0(v1480)
                    let v1487 : US25 = US25_0(v456)
                    struct (-1, v1486, v1487)
                | US30_0(v1416) -> (* Some *)
                    let v1417 : US6 = US6_1
                    let v1418 : US25 = US25_0(v456)
                    struct (v1416, v1417, v1418)
    let v1617 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v1609 with
        | US25_1 -> (* None *)
            let v1615 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v1615
        | US25_0(v1610) -> (* Some *)
            let v1612 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v1610 
            v1612
    let v1618 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v1619 : bool = Fable.Core.RustInterop.emitRustExpr v1617 v1618 
    let v1620 : string = "x"
    let v1621 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1620 
    let v1622 : string = "$0"
    let v1623 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v1621 v1622 
    let v1624 : string = "v1623.lock()"
    let v1625 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v1624 
    (* run_target_args'
    let v1627 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1628 : string = "$0.unwrap()"
    let v1629 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1625 v1628 
    let _run_target_args'_v1627 = v1629 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1630 : string = "$0.unwrap()"
    let v1631 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1625 v1630 
    let _run_target_args'_v1627 = v1631 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1632 : string = "$0.unwrap()"
    let v1633 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1625 v1632 
    let _run_target_args'_v1627 = v1633 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1634 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1625 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1627 = v1634 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1635 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1625 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1627 = v1635 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1636 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1625 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1627 = v1636 
    #endif
#else
    let v1637 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1625 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1627 = v1637 
    #endif
    let v1638 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = _run_target_args'_v1627 
    let v1641 : string = "$0.iter()"
    let v1642 : _ = Fable.Core.RustInterop.emitRustExpr v1638 v1641 
    let v1643 : string = "$0.collect::<Vec<_>>()"
    let v1644 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1642 v1643 
    let v1645 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v1646 : bool = Fable.Core.RustInterop.emitRustExpr v1644 v1645 
    let v1647 : string = "x"
    let v1648 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1647 
    let v1649 : string = "fable_library_rust::String_::fromString($0)"
    let v1650 : string = Fable.Core.RustInterop.emitRustExpr v1648 v1649 
    let v1651 : string = "true; $0 }).collect::<Vec<_>>()"
    let v1652 : bool = Fable.Core.RustInterop.emitRustExpr v1650 v1651 
    let v1653 : string = "_vec_map"
    let v1654 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1653 
    let v1655 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1656 : (string []) = Fable.Core.RustInterop.emitRustExpr v1654 v1655 
    let v1658 : string seq = v1656 |> Seq.ofArray
    let v1662 : string = method136()
    let v1663 : (string -> (string seq -> string)) = String.concat
    let v1664 : (string seq -> string) = v1663 v1662
    let v1665 : string = v1664 v1658
    let v1669 : string = "true; $0 })"
    let v1670 : bool = Fable.Core.RustInterop.emitRustExpr v1665 v1669 
    let v1671 : string = "_optionm_map_"
    let v1672 : string option = Fable.Core.RustInterop.emitRustExpr () v1671 
    let v1679 : US5 =
        match v1608 with
        | US6_1 -> (* None *)
            US5_1
        | US6_0(v1673) -> (* Some *)
            let v1674 : string = "fable_library_rust::String_::fromString($0)"
            let v1675 : string = Fable.Core.RustInterop.emitRustExpr v1673 v1674 
            US5_0(v1675)
    let v1683 : string =
        match v1679 with
        | US5_1 -> (* None *)
            let v1681 : string = ""
            v1681
        | US5_0(v1680) -> (* Some *)
            v1680
    let v1685 : string = v1672 |> Option.defaultValue v1683 
    let v1688 : unit = ()
    let v1689 : (unit -> unit) = closure62(v1607, v1685)
    let v1690 : unit = (fun () -> v1689 (); v1688) ()
    let v1739 : (int32 * string) = v1607, v1685 
    v1739 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _capture_v175 <- Some x
    let v1742 : (int32 * string) = match _capture_v175 with Some x -> x | None -> failwith "base.capture / _capture_v175=None"
    let (a, b) = v1742 
    let v3310 : int32 = a
    let v3311 : string = b
    let _run_target_args'_v15 = struct (v3310, v3311) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v3318 : int32, v3319 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3318, v3319) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v3326 : int32, v3327 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3326, v3327) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v3334 : int32, v3335 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3334, v3335) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v3342 : int32, v3343 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3342, v3343) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v3350 : int32, v3351 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v15 = struct (v3350, v3351) 
    #endif
#else
    let v3356 : Async<struct (int32 * string)> = method139(v0, v1, v2, v3, v4, v5, v6)
    (* run_target_args'
    let v3365 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v3368 : int32, v3369 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3365 = struct (v3368, v3369) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v3376 : int32, v3377 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3365 = struct (v3376, v3377) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v3384 : int32, v3385 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3365 = struct (v3384, v3385) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v3392 : int32, v3393 : string) = null |> unbox<struct (int32 * string)>
    let _run_target_args'_v3365 = struct (v3392, v3393) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3398 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3399 : int32, v3400 : string) = v3398 v3356
    let _run_target_args'_v3365 = struct (v3399, v3400) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3401 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3402 : int32, v3403 : string) = v3401 v3356
    let _run_target_args'_v3365 = struct (v3402, v3403) 
    #endif
#else
    let v3404 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v3405 : int32, v3406 : string) = v3404 v3356
    let _run_target_args'_v3365 = struct (v3405, v3406) 
    #endif
    let struct (v3407 : int32, v3408 : string) = _run_target_args'_v3365 
    let _run_target_args'_v15 = struct (v3407, v3408) 
    #endif
    let struct (v3413 : int32, v3414 : string) = _run_target_args'_v15 
    struct (v3413, v3414)
and method158 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method47(v1)
    let v4 : string = method28(v2, v3)
    let v5 : string = "."
    let v6 : int32 = v1.LastIndexOf v5 
    let v7 : int32 = v6 - 1
    let v9 : string = v1.[int 0..int v7]
    let v13 : int32 = v4.LastIndexOf v5 
    let v14 : int32 = v13 - 1
    let v16 : string = v4.[int 0..int v14]
    let v21 : string = ".md"
    let v22 : bool = v0.EndsWith (v21, false, null)
    let v25 : bool = v22 = false
    let v28 : string =
        if v25 then
            let v26 : string = $"{v1}.{v0}"
            v26
        else
            let v27 : string = $"{v9}.{v0}"
            v27
    let v31 : string =
        if v25 then
            let v29 : string = $"{v4}.{v0}"
            v29
        else
            let v30 : string = $"{v16}.{v0}"
            v30
    struct (v28, v31)
and method159 () : string =
    let v0 : string = ""
    v0
and closure71 () (v0 : string) : US34 =
    US34_0(v0)
and method160 () : (string -> US34) =
    closure71()
and closure72 () (v0 : std_string_String) : US34 =
    US34_1(v0)
and method161 () : (std_string_String -> US34) =
    closure72()
and method163 (v0 : string, v1 : string, v2 : string, v3 : int32, v4 : string, v5 : int32, v6 : string, v7 : string, v8 : US5, v9 : string, v10 : string) : string =
    let v11 : string = method14()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v12, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = "file"
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v12, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v34 : string = " = "
    let v35 : string = $"{v34}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v12, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = $"{v0}"
    let v47 : unit = ()
    let v48 : (unit -> unit) = closure8(v12, v44)
    let v49 : unit = (fun () -> v48 (); v47) ()
    let v53 : string = "; "
    let v54 : string = $"{v53}"
    let v57 : unit = ()
    let v58 : (unit -> unit) = closure8(v12, v54)
    let v59 : unit = (fun () -> v58 (); v57) ()
    let v63 : string = "real_path"
    let v64 : string = $"{v63}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v12, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v34}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v12, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = $"{v1}"
    let v85 : unit = ()
    let v86 : (unit -> unit) = closure8(v12, v82)
    let v87 : unit = (fun () -> v86 (); v85) ()
    let v91 : string = $"{v53}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v12, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v100 : string = "relative_path"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v12, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v110 : string = $"{v34}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure8(v12, v110)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v119 : string = $"{v2}"
    let v122 : unit = ()
    let v123 : (unit -> unit) = closure8(v12, v119)
    let v124 : unit = (fun () -> v123 (); v122) ()
    let v128 : string = $"{v53}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure8(v12, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v137 : string = "origin_hash_exit_code"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure8(v12, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v147 : string = $"{v34}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure8(v12, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v156 : string = $"{v3}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure8(v12, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v165 : string = $"{v53}"
    let v168 : unit = ()
    let v169 : (unit -> unit) = closure8(v12, v165)
    let v170 : unit = (fun () -> v169 (); v168) ()
    let v174 : string = "origin_hash"
    let v175 : string = $"{v174}"
    let v178 : unit = ()
    let v179 : (unit -> unit) = closure8(v12, v175)
    let v180 : unit = (fun () -> v179 (); v178) ()
    let v184 : string = $"{v34}"
    let v187 : unit = ()
    let v188 : (unit -> unit) = closure8(v12, v184)
    let v189 : unit = (fun () -> v188 (); v187) ()
    let v193 : string = $"{v4}"
    let v196 : unit = ()
    let v197 : (unit -> unit) = closure8(v12, v193)
    let v198 : unit = (fun () -> v197 (); v196) ()
    let v202 : string = $"{v53}"
    let v205 : unit = ()
    let v206 : (unit -> unit) = closure8(v12, v202)
    let v207 : unit = (fun () -> v206 (); v205) ()
    let v211 : string = "local_git_hash_exit_code"
    let v212 : string = $"{v211}"
    let v215 : unit = ()
    let v216 : (unit -> unit) = closure8(v12, v212)
    let v217 : unit = (fun () -> v216 (); v215) ()
    let v221 : string = $"{v34}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v12, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v230 : string = $"{v5}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure8(v12, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v239 : string = $"{v53}"
    let v242 : unit = ()
    let v243 : (unit -> unit) = closure8(v12, v239)
    let v244 : unit = (fun () -> v243 (); v242) ()
    let v248 : string = "local_git_hash"
    let v249 : string = $"{v248}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v12, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v258 : string = $"{v34}"
    let v261 : unit = ()
    let v262 : (unit -> unit) = closure8(v12, v258)
    let v263 : unit = (fun () -> v262 (); v261) ()
    let v267 : string = $"{v6}"
    let v270 : unit = ()
    let v271 : (unit -> unit) = closure8(v12, v267)
    let v272 : unit = (fun () -> v271 (); v270) ()
    let v276 : string = $"{v53}"
    let v279 : unit = ()
    let v280 : (unit -> unit) = closure8(v12, v276)
    let v281 : unit = (fun () -> v280 (); v279) ()
    let v285 : string = "hash1"
    let v286 : string = $"{v285}"
    let v289 : unit = ()
    let v290 : (unit -> unit) = closure8(v12, v286)
    let v291 : unit = (fun () -> v290 (); v289) ()
    let v295 : string = $"{v34}"
    let v298 : unit = ()
    let v299 : (unit -> unit) = closure8(v12, v295)
    let v300 : unit = (fun () -> v299 (); v298) ()
    let v304 : string = $"{v7}"
    let v307 : unit = ()
    let v308 : (unit -> unit) = closure8(v12, v304)
    let v309 : unit = (fun () -> v308 (); v307) ()
    let v313 : string = $"{v53}"
    let v316 : unit = ()
    let v317 : (unit -> unit) = closure8(v12, v313)
    let v318 : unit = (fun () -> v317 (); v316) ()
    let v322 : string = "hash2"
    let v323 : string = $"{v322}"
    let v326 : unit = ()
    let v327 : (unit -> unit) = closure8(v12, v323)
    let v328 : unit = (fun () -> v327 (); v326) ()
    let v332 : string = $"{v34}"
    let v335 : unit = ()
    let v336 : (unit -> unit) = closure8(v12, v332)
    let v337 : unit = (fun () -> v336 (); v335) ()
    let v341 : string = $"%A{v8}"
    let v345 : string = $"{v341}"
    let v348 : unit = ()
    let v349 : (unit -> unit) = closure8(v12, v345)
    let v350 : unit = (fun () -> v349 (); v348) ()
    let v354 : string = $"{v53}"
    let v357 : unit = ()
    let v358 : (unit -> unit) = closure8(v12, v354)
    let v359 : unit = (fun () -> v358 (); v357) ()
    let v363 : string = "dist_path"
    let v364 : string = $"{v363}"
    let v367 : unit = ()
    let v368 : (unit -> unit) = closure8(v12, v364)
    let v369 : unit = (fun () -> v368 (); v367) ()
    let v373 : string = $"{v34}"
    let v376 : unit = ()
    let v377 : (unit -> unit) = closure8(v12, v373)
    let v378 : unit = (fun () -> v377 (); v376) ()
    let v382 : string = $"{v9}"
    let v385 : unit = ()
    let v386 : (unit -> unit) = closure8(v12, v382)
    let v387 : unit = (fun () -> v386 (); v385) ()
    let v391 : string = $"{v53}"
    let v394 : unit = ()
    let v395 : (unit -> unit) = closure8(v12, v391)
    let v396 : unit = (fun () -> v395 (); v394) ()
    let v400 : string = "cache_path"
    let v401 : string = $"{v400}"
    let v404 : unit = ()
    let v405 : (unit -> unit) = closure8(v12, v401)
    let v406 : unit = (fun () -> v405 (); v404) ()
    let v410 : string = $"{v34}"
    let v413 : unit = ()
    let v414 : (unit -> unit) = closure8(v12, v410)
    let v415 : unit = (fun () -> v414 (); v413) ()
    let v419 : string = $"{v10}"
    let v422 : unit = ()
    let v423 : (unit -> unit) = closure8(v12, v419)
    let v424 : unit = (fun () -> v423 (); v422) ()
    let v428 : string = " }"
    let v429 : string = $"{v428}"
    let v432 : unit = ()
    let v433 : (unit -> unit) = closure8(v12, v429)
    let v434 : unit = (fun () -> v433 (); v432) ()
    let v437 : string = v12.l0
    v437
and method162 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US5, v18 : string, v19 : string) : string =
    let v20 : string = method163(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19)
    let v21 : int64 = v0.l0
    let v23 : string = $"{v6} {v7} #{v21} %s{v8} / {v20}"
    method18(v23)
and closure73 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US5) () : unit =
    let v11 : US0 = US0_2
    let v12 : bool = method7(v11)
    if v12 then
        let v13 : unit = ()
        let v14 : (unit -> unit) = closure6()
        let v15 : unit = (fun () -> v14 (); v13) ()
        let struct (v36 : Mut0, v37 : Mut1, v38 : Mut2, v39 : Mut3, v40 : Mut4, v41 : int64 option) = TraceState.trace_state.Value
        let v54 : string = method8(v36, v37, v38, v39, v40, v41)
        let v55 : string = method12()
        let v56 : string = "documents.run / par_map"
        let v57 : string = " / origin_hash |> sm'.contains local_git_hash |> not"
        let v58 : string = v56 + v57 
        let v59 : string = " / Some hash2 when hash1 = hash2"
        let v60 : string = v58 + v59 
        let v61 : bool = v60 = ""
        let v64 : string =
            if v61 then
                let v62 : string = ""
                v62
            else
                method162(v36, v37, v38, v39, v40, v41, v54, v55, v60, v1, v2, v0, v4, v3, v7, v6, v9, v10, v5, v8)
        method19(v64)
and closure74 () (v0 : uint64) : US35 =
    US35_0(v0)
and method165 () : (uint64 -> US35) =
    closure74()
and closure75 () (v0 : std_string_String) : US35 =
    US35_1(v0)
and method166 () : (std_string_String -> US35) =
    closure75()
and method168 (v0 : string, v1 : string, v2 : std_string_String) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "old_path"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "new_path"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "error"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure8(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    (* run_target_args'
    let v114 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v115 : string = "format!(\"{:#?}\", $0)"
    let v116 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v115 
    let v117 : string = "fable_library_rust::String_::fromString($0)"
    let v118 : string = Fable.Core.RustInterop.emitRustExpr v116 v117 
    let _run_target_args'_v114 = v118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : string = "format!(\"{:#?}\", $0)"
    let v120 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v119 
    let v121 : string = "fable_library_rust::String_::fromString($0)"
    let v122 : string = Fable.Core.RustInterop.emitRustExpr v120 v121 
    let _run_target_args'_v114 = v122 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v123 : string = "format!(\"{:#?}\", $0)"
    let v124 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v123 
    let v125 : string = "fable_library_rust::String_::fromString($0)"
    let v126 : string = Fable.Core.RustInterop.emitRustExpr v124 v125 
    let _run_target_args'_v114 = v126 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v128 : string = $"%A{v2}"
    let _run_target_args'_v114 = v128 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : string = $"%A{v2}"
    let _run_target_args'_v114 = v132 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v136 : string = $"%A{v2}"
    let _run_target_args'_v114 = v136 
    #endif
#else
    let v140 : string = $"%A{v2}"
    let _run_target_args'_v114 = v140 
    #endif
    let v143 : string = _run_target_args'_v114 
    let v150 : string = $"{v143}"
    let v153 : unit = ()
    let v154 : (unit -> unit) = closure8(v4, v150)
    let v155 : unit = (fun () -> v154 (); v153) ()
    let v159 : string = " }"
    let v160 : string = $"{v159}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure8(v4, v160)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v168 : string = v4.l0
    v168
and method167 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : std_string_String) : string =
    let v11 : string = method168(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "file_system.file_copy"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure76 (v0 : string, v1 : string, v2 : std_string_String) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method35()
        let v48 : string = method167(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method19(v48)
and method170 (v0 : string, v1 : string, v2 : uint64) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "old_path"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "new_path"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "result"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure8(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure8(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method169 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : uint64) : string =
    let v11 : string = method170(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "file_system.file_copy"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure77 (v0 : string, v1 : string, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method66()
        let v48 : string = method169(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method19(v48)
and method164 (v0 : string, v1 : string) : unit =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::fs::copy(&*$0, &*$1)"
    let v4 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr struct (v1, v0) v3 
    let v5 : (std_io_Error -> std_string_String) = method69()
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v8 
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.map_err(|x| $1(x))"
    let v11 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v10 
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.map_err(|x| $1(x))"
    let v13 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v12 
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _run_target_args'_v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _run_target_args'_v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _run_target_args'_v7 = v16 
    #endif
#else
    let v17 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _run_target_args'_v7 = v17 
    #endif
    let v18 : Result<uint64, std_string_String> = _run_target_args'_v7 
    let v21 : (uint64 -> US35) = method165()
    let v22 : (std_string_String -> US35) = method166()
    let v24 : US35 = match v18 with Ok x -> v21 x | Error x -> v22 x
    match v24 with
    | US35_1(v77) -> (* Error *)
        let v78 : unit = ()
        let v79 : (unit -> unit) = closure76(v0, v1, v77)
        let v80 : unit = (fun () -> v79 (); v78) ()
        ()
    | US35_0(v27) -> (* Ok *)
        let v28 : unit = ()
        let v29 : (unit -> unit) = closure77(v0, v1, v27)
        let v30 : unit = (fun () -> v29 (); v28) ()
        ()
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    System.IO.File.Copy (v1, v0, true)
    #endif
    // run_target_args' is_unit
    ()
and method172 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method173 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method174 (v0 : string) : string =
    v0
and method175 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure80 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0"
    let v3 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "v3.lock()"
    let v5 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v4 
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.unwrap()"
    let v9 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v8 
    let _run_target_args'_v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.unwrap()"
    let v11 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.unwrap()"
    let v13 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _run_target_args'_v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v7 = v16 
    #endif
#else
    let v17 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v7 = v17 
    #endif
    let v18 : std_sync_MutexGuard<std_process_ChildStdin> = _run_target_args'_v7 
    let v21 : string = method174(v0)
    let v22 : string = "v21.as_bytes()"
    let v23 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : std_sync_MutexGuard<std_process_ChildStdin> = method175(v18)
    let v25 : string = "true; let mut v24 = v24"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "true; std::io::Write::write_all(&mut *$0, v23).unwrap()"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    ()
and method176 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method178 (v0 : int32, v1 : int32, v2 : string) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "exit_code"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "result_len"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "output_path"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure8(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure8(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method177 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : string = method178(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "documents.hangul"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure81 (v0 : string, v1 : int32, v2 : string) () : unit =
    let v3 : US0 = US0_2
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method12()
        let v48 : int32 = v2.Length
        let v49 : string = method177(v28, v29, v30, v31, v32, v33, v46, v47, v1, v48, v0)
        method19(v49)
and method171 (v0 : string, v1 : string, v2 : string, v3 : string) : US36 =
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "std::fs::read(&*$0)"
    let v15 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v3 v14 
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "$0.unwrap()"
    let v19 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "$0.unwrap()"
    let v21 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "$0.unwrap()"
    let v23 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : Vec<uint8> = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v17 = v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : Vec<uint8> = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v17 = v25 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : Vec<uint8> = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v17 = v26 
    #endif
#else
    let v27 : Vec<uint8> = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v17 = v27 
    #endif
    let v28 : Vec<uint8> = _run_target_args'_v17 
    let _run_target_args'_v13 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v36 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v40 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v44 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v48 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _run_target_args'_v13 = v48 
    #endif
#else
    let v51 : (uint8 []) = v3 |> System.IO.File.ReadAllBytes
    let v52 : string = "$0.to_vec()"
    let v53 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v13 = v53 
    #endif
    let v54 : Vec<uint8> = _run_target_args'_v13 
    let v60 : Vec<uint8> = method172(v54)
    let v61 : string = "std::string::String::from_utf8($0)"
    let v62 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v60 v61 
    (* run_target_args'
    let v64 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : string = "$0.unwrap()"
    let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v65 
    let _run_target_args'_v64 = v66 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v67 : string = "$0.unwrap()"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v67 
    let _run_target_args'_v64 = v68 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v69 : string = "$0.unwrap()"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v69 
    let _run_target_args'_v64 = v70 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v71 : std_string_String = match v62 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v64 = v71 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : std_string_String = match v62 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v64 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v73 : std_string_String = match v62 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v64 = v73 
    #endif
#else
    let v74 : std_string_String = match v62 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v64 = v74 
    #endif
    let v75 : std_string_String = _run_target_args'_v64 
    let v78 : string = "fable_library_rust::String_::fromString($0)"
    let v79 : string = Fable.Core.RustInterop.emitRustExpr v75 v78 
    let _run_target_args'_v8 = v79 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v81 : string = null |> unbox<string>
    let _run_target_args'_v8 = v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = null |> unbox<string>
    let _run_target_args'_v8 = v85 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v89 : string = null |> unbox<string>
    let _run_target_args'_v8 = v89 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : string = null |> unbox<string>
    let _run_target_args'_v8 = v93 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v97 : string = null |> unbox<string>
    let _run_target_args'_v8 = v97 
    #endif
#else
    let v100 : string = v3 |> System.IO.File.ReadAllText
    let _run_target_args'_v8 = v100 
    #endif
    let v101 : string = _run_target_args'_v8 
    let v108 : string = "\n"
    let v109 : (string []) = v101.Split v108 
    let v112 : int32 = v109.Length
    let v113 : (string []) = Array.zeroCreate<string> (v112)
    let v114 : Mut6 = {l0 = 0} : Mut6
    while method63(v112, v114) do
        let v116 : int32 = v114.l0
        let v117 : string = v109.[int v116]
        let v119 : (unit -> string) = v117.Trim
        let v120 : string = v119 ()
        v113.[int v116] <- v120
        let v123 : int32 = v116 + 1
        v114.l0 <- v123
        ()
    let v124 : int32 = v113.Length
    let v125 : (string []) = Array.zeroCreate<string> (v124)
    let v126 : Mut7 = {l0 = 0; l1 = 0} : Mut7
    while method173(v124, v126) do
        let v128 : int32 = v126.l0
        let v129 : int32 = v126.l1
        let v130 : string = v113.[int v128]
        let v133 : string = ""
        let v134 : bool = v130 <> v133 
        let v138 : int32 =
            if v134 then
                v125.[int v129] <- v130
                let v137 : int32 = v129 + 1
                v137
            else
                v129
        let v139 : int32 = v128 + 1
        v126.l0 <- v139
        v126.l1 <- v138
        ()
    let v140 : int32 = v126.l1
    let v141 : (string []) = Array.zeroCreate<string> (v140)
    let v142 : Mut6 = {l0 = 0} : Mut6
    while method63(v140, v142) do
        let v144 : int32 = v142.l0
        let v145 : string = v125.[int v144]
        v141.[int v144] <- v145
        let v146 : int32 = v144 + 1
        v142.l0 <- v146
        ()
    let v150 : unit = ()
    let _let'_v150 =
        seq {
            for i = 0 to v141.Length - 1 do yield v141.[i]
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v153 : string seq = _let'_v150 
    let v160 : string = method136()
    let v161 : (string -> (string seq -> string)) = String.concat
    let v162 : (string seq -> string) = v161 v160
    let v163 : string = v162 v153
    let v166 : string = $"{v163}

"
    let v167 : System.Threading.CancellationToken option = None
    let v168 : (struct (string * string) []) = [||]
    let v169 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v170 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v171 : string option = None
    (* run_target_args'
    let v176 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : string = "cfg!(windows)"
    let v178 : bool = Fable.Core.RustInterop.emitRustExpr () v177 
    let _run_target_args'_v176 = v178 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v179 : string = "cfg!(windows)"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr () v179 
    let _run_target_args'_v176 = v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : string = "cfg!(windows)"
    let v182 : bool = Fable.Core.RustInterop.emitRustExpr () v181 
    let _run_target_args'_v176 = v182 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : US3 = US3_0
    let v184 : US4 = US4_4(v183)
    let v185 : string = $"platform.is_windows / target: {v184}"
    let v186 : bool = failwith<bool> v185
    let _run_target_args'_v176 = v186 
    #endif
#if FABLE_COMPILER_PYTHON
    let v187 : US3 = US3_0
    let v188 : US4 = US4_5(v187)
    let v189 : string = $"platform.is_windows / target: {v188}"
    let v190 : bool = failwith<bool> v189
    let _run_target_args'_v176 = v190 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v191 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v192 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v193 : bool = v192 v191
    let _run_target_args'_v176 = v193 
    #endif
#else
    let v194 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v195 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v196 : bool = v195 v194
    let _run_target_args'_v176 = v196 
    #endif
    let v197 : bool = _run_target_args'_v176 
    let v205 : string =
        if v197 then
            let v203 : string = ".exe"
            v203
        else
            let v204 : string = ""
            v204
    let v206 : string = $"../alphabet/deps/hangulize/cmd/hangulize/hangulize{v205}"
    let v207 : string = method28(v0, v206)
    let v208 : string = $"{v207} {v1}"
    let v211 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure80(v166)
    let v212 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v211 
    let v215 : bool = true
    let struct (v216 : int32, v217 : string) = method83(v208, v167, v168, v169, v212, v215, v171)
    let v219 : (string []) = v217.Split v108 
    let v222 : int32 = v219.Length
    let v223 : string = ""
    let v224 : Mut8 = {l0 = 0; l1 = v223; l2 = 0; l3 = 0} : Mut8
    while method176(v124, v224) do
        let v226 : int32 = v224.l0
        let struct (v227 : string, v228 : int32, v229 : int32) = v224.l1, v224.l2, v224.l3
        let v230 : string = v113.[int v226]
        let v231 : bool = v230 = ""
        let struct (v254 : string, v255 : int32, v256 : int32) =
            if v231 then
                let v232 : string = $"{v227}
"
                let v233 : int32 = v228 + 1
                let v234 : int32 = v229 + 1
                struct (v232, v233, v234)
            else
                let v235 : int32 = v228 - v229
                let v236 : bool = v235 >= v222
                let v252 : string =
                    if v236 then
                        v227
                    else
                        let v238 : string = v219.[int v235]
                        let v242 : string = "://"
                        let v243 : bool = v238.Contains v242 
                        let v246 : string =
                            if v243 then
                                v230
                            else
                                v238
                        let v247 : int32 = v222 - 1
                        let v248 : bool = v235 = v247
                        if v248 then
                            let v249 : string = $"{v227}{v246}"
                            v249
                        else
                            let v250 : string = $"{v227}{v246}
"
                            v250
                let v253 : int32 = v228 + 1
                struct (v252, v253, v229)
        let v257 : int32 = v226 + 1
        v224.l0 <- v257
        v224.l1 <- v254
        v224.l2 <- v255
        v224.l3 <- v256
        ()
    let struct (v258 : string, v259 : int32, v260 : int32) = v224.l1, v224.l2, v224.l3
    (* run_target_args'
    let v261 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v262 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v258) v262 
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    System.IO.File.WriteAllText (v2, v258)
    #endif
    // run_target_args' is_unit
    let v263 : unit = ()
    let v264 : (unit -> unit) = closure81(v2, v216, v258)
    let v265 : unit = (fun () -> v264 (); v263) ()
    US36_0(v216, v258)
and method180 (v0 : int32, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "exit_code"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "result"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method179 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method180(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "documents.files_fn / error"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure82 (v0 : string, v1 : int32) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method12()
        let v47 : string = method179(v27, v28, v29, v30, v31, v32, v45, v46, v1, v0)
        method19(v47)
and closure79 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US33 =
    let struct (v6 : string, v7 : string) = method158(v5, v4, v0)
    let v8 : bool = method30(v6)
    let v9 : bool = v8 = false
    let v12 : bool =
        if v9 then
            true
        else
            let v10 : bool = method30(v7)
            let v11 : bool = v10 = false
            v11
    let v344 : bool =
        if v12 then
            false
        else
            let v13 : string = method38(v6)
            let v14 : string = "std::fs::File::open(&*v13)"
            let v15 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v14 
            (* run_target_args'
            let v17 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18 : string = "$0.unwrap()"
            let v19 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v18 
            let _run_target_args'_v17 = v19 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20 : string = "$0.unwrap()"
            let v21 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v20 
            let _run_target_args'_v17 = v21 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v22 : string = "$0.unwrap()"
            let v23 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v22 
            let _run_target_args'_v17 = v23 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v17 = v24 
            #endif
#if FABLE_COMPILER_PYTHON
            let v25 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v17 = v25 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v26 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v17 = v26 
            #endif
#else
            let v27 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v17 = v27 
            #endif
            let v28 : std_fs_File = _run_target_args'_v17 
            let v31 : string = "std::io::BufReader::new($0)"
            let v32 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v28 v31 
            let v33 : string = "std::io::BufReader::new($0)"
            let v34 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v32 v33 
            let v35 : string = "true; let mut v34 = v34"
            let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
            let v37 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v37 
            let v38 : string = "result"
            let v39 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v38 
            let v40 : string = "true; let mut v39 = v39"
            let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40 
            let v43 : unativeint = 0 |> unativeint 
            let v46 : string = "[$0; 1024]"
            let v47 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v46 
            let v48 : string = "true; loop { // rust.loop"
            let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
            let v50 : string = "true; let mut v47 = v47"
            let v51 : bool = Fable.Core.RustInterop.emitRustExpr () v50 
            let v52 : string = "std::io::Read::read(&mut v34, &mut v47)"
            let v53 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v52 
            (* run_target_args'
            let v55 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : string = "$0.unwrap()"
            let v57 : unativeint = Fable.Core.RustInterop.emitRustExpr v53 v56 
            let _run_target_args'_v55 = v57 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v58 : string = "$0.unwrap()"
            let v59 : unativeint = Fable.Core.RustInterop.emitRustExpr v53 v58 
            let _run_target_args'_v55 = v59 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v60 : string = "$0.unwrap()"
            let v61 : unativeint = Fable.Core.RustInterop.emitRustExpr v53 v60 
            let _run_target_args'_v55 = v61 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v62 : unativeint = match v53 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v55 = v62 
            #endif
#if FABLE_COMPILER_PYTHON
            let v63 : unativeint = match v53 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v55 = v63 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v64 : unativeint = match v53 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v55 = v64 
            #endif
#else
            let v65 : unativeint = match v53 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v55 = v65 
            #endif
            let v66 : unativeint = _run_target_args'_v55 
            let v70 : bool = v66 = v43 
            if v70 then
                let v73 : string = "true; break"
                let v74 : bool = Fable.Core.RustInterop.emitRustExpr () v73 
                ()
            let v76 : unativeint = v66 |> unativeint 
            let v80 : unativeint = v76 |> unbox<unativeint>
            let v83 : string = "v47.len()"
            let v84 : unativeint = Fable.Core.RustInterop.emitRustExpr () v83 
            let v86 : bool = v80 = v84 
            let v93 : Ref<Slice'<uint8>> =
                if v86 then
                    let v89 : string = "&v47[v43..]"
                    let v90 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v89 
                    v90
                else
                    let v91 : string = "&v47[$0..$1]"
                    let v92 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v43, v76) v91 
                    v92
            let v94 : string = "sha2::Digest::update(&mut v39, v93)"
            Fable.Core.RustInterop.emitRustExpr () v94 
            let v95 : string = "true; } // rust.loop"
            let v96 : bool = Fable.Core.RustInterop.emitRustExpr () v95 
            let v97 : string = "true; } // rust.loop"
            let v98 : bool = Fable.Core.RustInterop.emitRustExpr () v97 
            let v99 : string = "true; } // rust.loop"
            let v100 : bool = Fable.Core.RustInterop.emitRustExpr () v99 
            let v101 : string = "true; { // rust.loop"
            let v102 : bool = Fable.Core.RustInterop.emitRustExpr () v101 
            let v103 : string = "true; { // rust.loop"
            let v104 : bool = Fable.Core.RustInterop.emitRustExpr () v103 
            let v105 : string = "&sha2::Digest::finalize(v39)"
            let v106 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v105 
            let v107 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v108 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v106 v107 
            let v109 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109 
            let v111 : string = "x"
            let v112 : uint8 = Fable.Core.RustInterop.emitRustExpr () v111 
            let v113 : string = "format!(\"{:02x}\", $0)"
            let v114 : std_string_String = Fable.Core.RustInterop.emitRustExpr v112 v113 
            let v115 : string = "fable_library_rust::String_::fromString($0)"
            let v116 : string = Fable.Core.RustInterop.emitRustExpr v114 v115 
            let v117 : string = "true; $0 }).collect::<Vec<_>>()"
            let v118 : bool = Fable.Core.RustInterop.emitRustExpr v116 v117 
            let v119 : string = "_vec_map"
            let v120 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v119 
            let v121 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v122 : (string []) = Fable.Core.RustInterop.emitRustExpr v120 v121 
            let v126 : unit = ()
            let _let'_v126 =
                seq {
                    for i = 0 to v122.Length - 1 do yield v122.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v129 : string seq = _let'_v126 
            let v135 : string = method159()
            let v137 : bool = v135 = "\n"
            let v139 : string =
                if v137 then
                    method65(v135)
                else
                    v135
            let v140 : (string -> (string seq -> string)) = String.concat
            let v141 : (string seq -> string) = v140 v139
            let v142 : string = v141 v129
            let v146 : Result<string, std_io_Error> = Ok v142 
            let v149 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v151 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v152 : string = "$0.map_err(|x| $1(x))"
            let v153 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v146, v149) v152 
            let _run_target_args'_v151 = v153 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v154 : string = "$0.map_err(|x| $1(x))"
            let v155 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v146, v149) v154 
            let _run_target_args'_v151 = v155 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v156 : string = "$0.map_err(|x| $1(x))"
            let v157 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v146, v149) v156 
            let _run_target_args'_v151 = v157 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v158 : Result<string, std_string_String> = match v146 with Ok x -> Ok x | Error x -> Error (v149 x)
            let _run_target_args'_v151 = v158 
            #endif
#if FABLE_COMPILER_PYTHON
            let v159 : Result<string, std_string_String> = match v146 with Ok x -> Ok x | Error x -> Error (v149 x)
            let _run_target_args'_v151 = v159 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v160 : Result<string, std_string_String> = match v146 with Ok x -> Ok x | Error x -> Error (v149 x)
            let _run_target_args'_v151 = v160 
            #endif
#else
            let v161 : Result<string, std_string_String> = match v146 with Ok x -> Ok x | Error x -> Error (v149 x)
            let _run_target_args'_v151 = v161 
            #endif
            let v162 : Result<string, std_string_String> = _run_target_args'_v151 
            let v165 : (string -> US34) = method160()
            let v166 : (std_string_String -> US34) = method161()
            let v167 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v168 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v165, v166, v162) v167 
            let v177 : string =
                match v168 with
                | US34_1(v170) -> (* Error *)
                    let v172 : string = $"resultm.get / Result value was Error: {v170}"
                    failwith<string> v172
                | US34_0(v169) -> (* Ok *)
                    v169
            let v178 : string = method38(v7)
            let v179 : string = "std::fs::File::open(&*v178)"
            let v180 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v179 
            (* run_target_args'
            let v182 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v183 : string = "$0.unwrap()"
            let v184 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v180 v183 
            let _run_target_args'_v182 = v184 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v185 : string = "$0.unwrap()"
            let v186 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v180 v185 
            let _run_target_args'_v182 = v186 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v187 : string = "$0.unwrap()"
            let v188 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v180 v187 
            let _run_target_args'_v182 = v188 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v189 : std_fs_File = match v180 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v182 = v189 
            #endif
#if FABLE_COMPILER_PYTHON
            let v190 : std_fs_File = match v180 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v182 = v190 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v191 : std_fs_File = match v180 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v182 = v191 
            #endif
#else
            let v192 : std_fs_File = match v180 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v182 = v192 
            #endif
            let v193 : std_fs_File = _run_target_args'_v182 
            let v196 : string = "std::io::BufReader::new($0)"
            let v197 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v193 v196 
            let v198 : string = "std::io::BufReader::new($0)"
            let v199 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v197 v198 
            let v200 : string = "true; let mut v199 = v199"
            let v201 : bool = Fable.Core.RustInterop.emitRustExpr () v200 
            let v202 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v202 
            let v203 : string = "result"
            let v204 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v203 
            let v205 : string = "true; let mut v204 = v204"
            let v206 : bool = Fable.Core.RustInterop.emitRustExpr () v205 
            let v208 : unativeint = 0 |> unativeint 
            let v211 : string = "[$0; 1024]"
            let v212 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v211 
            let v213 : string = "true; loop { // rust.loop"
            let v214 : bool = Fable.Core.RustInterop.emitRustExpr () v213 
            let v215 : string = "true; let mut v212 = v212"
            let v216 : bool = Fable.Core.RustInterop.emitRustExpr () v215 
            let v217 : string = "std::io::Read::read(&mut v199, &mut v212)"
            let v218 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v217 
            (* run_target_args'
            let v220 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v221 : string = "$0.unwrap()"
            let v222 : unativeint = Fable.Core.RustInterop.emitRustExpr v218 v221 
            let _run_target_args'_v220 = v222 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v223 : string = "$0.unwrap()"
            let v224 : unativeint = Fable.Core.RustInterop.emitRustExpr v218 v223 
            let _run_target_args'_v220 = v224 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v225 : string = "$0.unwrap()"
            let v226 : unativeint = Fable.Core.RustInterop.emitRustExpr v218 v225 
            let _run_target_args'_v220 = v226 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v227 : unativeint = match v218 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v220 = v227 
            #endif
#if FABLE_COMPILER_PYTHON
            let v228 : unativeint = match v218 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v220 = v228 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v229 : unativeint = match v218 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v220 = v229 
            #endif
#else
            let v230 : unativeint = match v218 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v220 = v230 
            #endif
            let v231 : unativeint = _run_target_args'_v220 
            let v235 : bool = v231 = v208 
            if v235 then
                let v238 : string = "true; break"
                let v239 : bool = Fable.Core.RustInterop.emitRustExpr () v238 
                ()
            let v241 : unativeint = v231 |> unativeint 
            let v245 : unativeint = v241 |> unbox<unativeint>
            let v248 : string = "v212.len()"
            let v249 : unativeint = Fable.Core.RustInterop.emitRustExpr () v248 
            let v251 : bool = v245 = v249 
            let v258 : Ref<Slice'<uint8>> =
                if v251 then
                    let v254 : string = "&v212[v208..]"
                    let v255 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v254 
                    v255
                else
                    let v256 : string = "&v212[$0..$1]"
                    let v257 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v208, v241) v256 
                    v257
            let v259 : string = "sha2::Digest::update(&mut v204, v258)"
            Fable.Core.RustInterop.emitRustExpr () v259 
            let v260 : string = "true; } // rust.loop"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "true; } // rust.loop"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "true; } // rust.loop"
            let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
            let v266 : string = "true; { // rust.loop"
            let v267 : bool = Fable.Core.RustInterop.emitRustExpr () v266 
            let v268 : string = "true; { // rust.loop"
            let v269 : bool = Fable.Core.RustInterop.emitRustExpr () v268 
            let v270 : string = "&sha2::Digest::finalize(v204)"
            let v271 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v270 
            let v272 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v273 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v271 v272 
            let v274 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v275 : bool = Fable.Core.RustInterop.emitRustExpr v273 v274 
            let v276 : string = "x"
            let v277 : uint8 = Fable.Core.RustInterop.emitRustExpr () v276 
            let v278 : string = "format!(\"{:02x}\", $0)"
            let v279 : std_string_String = Fable.Core.RustInterop.emitRustExpr v277 v278 
            let v280 : string = "fable_library_rust::String_::fromString($0)"
            let v281 : string = Fable.Core.RustInterop.emitRustExpr v279 v280 
            let v282 : string = "true; $0 }).collect::<Vec<_>>()"
            let v283 : bool = Fable.Core.RustInterop.emitRustExpr v281 v282 
            let v284 : string = "_vec_map"
            let v285 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v284 
            let v286 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v287 : (string []) = Fable.Core.RustInterop.emitRustExpr v285 v286 
            let v291 : unit = ()
            let _let'_v291 =
                seq {
                    for i = 0 to v287.Length - 1 do yield v287.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v294 : string seq = _let'_v291 
            let v300 : string = method159()
            let v302 : bool = v300 = "\n"
            let v304 : string =
                if v302 then
                    method65(v300)
                else
                    v300
            let v305 : (string -> (string seq -> string)) = String.concat
            let v306 : (string seq -> string) = v305 v304
            let v307 : string = v306 v294
            let v311 : Result<string, std_io_Error> = Ok v307 
            let v314 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v316 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v317 : string = "$0.map_err(|x| $1(x))"
            let v318 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v311, v314) v317 
            let _run_target_args'_v316 = v318 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v319 : string = "$0.map_err(|x| $1(x))"
            let v320 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v311, v314) v319 
            let _run_target_args'_v316 = v320 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v321 : string = "$0.map_err(|x| $1(x))"
            let v322 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v311, v314) v321 
            let _run_target_args'_v316 = v322 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v323 : Result<string, std_string_String> = match v311 with Ok x -> Ok x | Error x -> Error (v314 x)
            let _run_target_args'_v316 = v323 
            #endif
#if FABLE_COMPILER_PYTHON
            let v324 : Result<string, std_string_String> = match v311 with Ok x -> Ok x | Error x -> Error (v314 x)
            let _run_target_args'_v316 = v324 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v325 : Result<string, std_string_String> = match v311 with Ok x -> Ok x | Error x -> Error (v314 x)
            let _run_target_args'_v316 = v325 
            #endif
#else
            let v326 : Result<string, std_string_String> = match v311 with Ok x -> Ok x | Error x -> Error (v314 x)
            let _run_target_args'_v316 = v326 
            #endif
            let v327 : Result<string, std_string_String> = _run_target_args'_v316 
            let v330 : (string -> US34) = method160()
            let v331 : (std_string_String -> US34) = method161()
            let v332 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v333 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v330, v331, v327) v332 
            let v342 : string =
                match v333 with
                | US34_1(v335) -> (* Error *)
                    let v337 : string = $"resultm.get / Result value was Error: {v335}"
                    failwith<string> v337
                | US34_0(v334) -> (* Ok *)
                    v334
            let v343 : bool = v177 = v342
            v343
    if v344 then
        US33_1
    else
        let v346 : US36 = method171(v2, v3, v6, v4)
        match v346 with
        | US36_1(v419, v420) -> (* Error *)
            let v422 : (string * string) = v6, v420 
            let v426 : Result<string, (string * string)> = Error v422 
            US33_0(v426)
        | US36_0(v347, v348) -> (* Ok *)
            let v350 : bool = v347 <> 0 
            if v350 then
                let v353 : unit = ()
                let v354 : (unit -> unit) = closure82(v348, v347)
                let v355 : unit = (fun () -> v354 (); v353) ()
                let v403 : (string * string) = v6, v348 
                let v407 : Result<string, (string * string)> = Error v403 
                US33_0(v407)
            else
                let v411 : bool = method30(v6)
                if v411 then
                    method164(v7, v6)
                else
                    let v412 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v412
                let v414 : Result<string, (string * string)> = Ok v6 
                US33_0(v414)
and closure78 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US33) =
    closure79(v0, v1, v2, v3, v4)
and method183 (v0 : int32, v1 : string, v2 : string) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "exit_code"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure8(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure8(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "output_path"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "result"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure8(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure8(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method182 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : string = method183(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "documents.crowbook / result contains ERROR"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method18(v15)
and closure85 (v0 : string, v1 : string, v2 : int32) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method8(v28, v29, v30, v31, v32, v33)
        let v47 : string = method35()
        let v48 : string = method182(v28, v29, v30, v31, v32, v33, v46, v47, v2, v0, v1)
        method19(v48)
and method181 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US36 =
    let v5 : bool = "html" = v4
    let v61 : string =
        if v5 then
            let v6 : string = $"--set"
            let v7 : string = $" html.css.add \\\"'"
            let v8 : string = v6 + v7 
            let v9 : string = $" body {{ color: #e8e6e3; background-color: #202324; }}"
            let v10 : string = v8 + v9 
            let v11 : string = $" a {{ color: #989693; }}"
            let v12 : string = v10 + v11 
            let v13 : string = $" pre {{ background-color: #1b1b1b; padding: 10px; }}"
            let v14 : string = v12 + v13 
            let v15 : string = $" '\\\""
            let v16 : string = v14 + v15 
            let v17 : string = $" rendering.num_depth 6"
            let v18 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
            let v19 : string = v17 + v18 
            let v20 : string = v16 + v19 
            v20
        else
            let v21 : bool = "pdf" = v4
            if v21 then
                let v22 : string = $"--set"
                let v23 : string = $" tex.paper.size a4paper"
                let v24 : string = v22 + v23 
                let v25 : string = $" tex.template.add \"\\pagenumbering{{gobble}}\""
                let v26 : string = v24 + v25 
                let v27 : bool = v0 = false
                let v36 : string =
                    if v27 then
                        let v28 : string = ""
                        v28
                    else
                        let v29 : string = $" tex.template.add \"\\usepackage{{polyglossia}}\""
                        let v30 : string = $" tex.template.add \"\\setmainlanguage{{korean}}\""
                        let v31 : string = v29 + v30 
                        let v32 : string = $" tex.template.add \"\\setmainfont{{NanumGothicCoding}}\""
                        let v33 : string = v31 + v32 
                        let v34 : string = $" tex.font.size 13"
                        let v35 : string = v33 + v34 
                        v35
                let v37 : string = v26 + v36 
                let v38 : string = $" rendering.num_depth 6"
                let v39 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                let v40 : string = v38 + v39 
                let v41 : string = v37 + v40 
                v41
            else
                let v42 : bool = "epub" = v4
                if v42 then
                    let v43 : string = $"--set"
                    let v44 : string = $" epub.version 3"
                    let v45 : string = v43 + v44 
                    let v46 : string = $" html.css.add \\\"' "
                    let v47 : string = v45 + v46 
                    let v48 : string = $" body {{ color: #e8e6e3; background-color: #202324; }} "
                    let v49 : string = v47 + v48 
                    let v50 : string = $" a {{ color: #989693; }} "
                    let v51 : string = v49 + v50 
                    let v52 : string = $" '\\\""
                    let v53 : string = v51 + v52 
                    let v54 : string = $" rendering.num_depth 6"
                    let v55 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                    let v56 : string = v54 + v55 
                    let v57 : string = v53 + v56 
                    v57
                else
                    let v58 : string = ""
                    v58
    let v62 : System.Threading.CancellationToken option = None
    let v63 : (struct (string * string) []) = [||]
    let v64 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v65 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v66 : string option = None
    let v67 : string = $"crowbook --verbose --to {v4}"
    let v68 : string = $" --single \"{v2}\" --output \"{v1}\" {v61}"
    let v69 : string = v67 + v68 
    let v71 : string option = Some v3 
    let v74 : bool = true
    let struct (v75 : int32, v76 : string) = method83(v69, v62, v63, v64, v65, v74, v71)
    let v78 : string = "ERROR"
    let v79 : bool = v76.Contains v78 
    let v82 : bool = v79 = false
    if v82 then
        US36_0(v75, v76)
    else
        let v84 : unit = ()
        let v85 : (unit -> unit) = closure85(v1, v76, v75)
        let v86 : unit = (fun () -> v85 (); v84) ()
        US36_1(v75, v76)
and closure84 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US33 =
    let struct (v5 : string, v6 : string) = method158(v4, v3, v0)
    let v7 : bool = method30(v5)
    let v8 : bool = v7 = false
    let v11 : bool =
        if v8 then
            true
        else
            let v9 : bool = method30(v6)
            let v10 : bool = v9 = false
            v10
    let v343 : bool =
        if v11 then
            false
        else
            let v12 : string = method38(v5)
            let v13 : string = "std::fs::File::open(&*v12)"
            let v14 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v13 
            (* run_target_args'
            let v16 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17 : string = "$0.unwrap()"
            let v18 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v17 
            let _run_target_args'_v16 = v18 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19 : string = "$0.unwrap()"
            let v20 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v19 
            let _run_target_args'_v16 = v20 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21 : string = "$0.unwrap()"
            let v22 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v21 
            let _run_target_args'_v16 = v22 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v23 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v16 = v23 
            #endif
#if FABLE_COMPILER_PYTHON
            let v24 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v16 = v24 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v25 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v16 = v25 
            #endif
#else
            let v26 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v16 = v26 
            #endif
            let v27 : std_fs_File = _run_target_args'_v16 
            let v30 : string = "std::io::BufReader::new($0)"
            let v31 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v27 v30 
            let v32 : string = "std::io::BufReader::new($0)"
            let v33 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v31 v32 
            let v34 : string = "true; let mut v33 = v33"
            let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
            let v36 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v36 
            let v37 : string = "result"
            let v38 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v37 
            let v39 : string = "true; let mut v38 = v38"
            let v40 : bool = Fable.Core.RustInterop.emitRustExpr () v39 
            let v42 : unativeint = 0 |> unativeint 
            let v45 : string = "[$0; 1024]"
            let v46 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v45 
            let v47 : string = "true; loop { // rust.loop"
            let v48 : bool = Fable.Core.RustInterop.emitRustExpr () v47 
            let v49 : string = "true; let mut v46 = v46"
            let v50 : bool = Fable.Core.RustInterop.emitRustExpr () v49 
            let v51 : string = "std::io::Read::read(&mut v33, &mut v46)"
            let v52 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v51 
            (* run_target_args'
            let v54 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55 : string = "$0.unwrap()"
            let v56 : unativeint = Fable.Core.RustInterop.emitRustExpr v52 v55 
            let _run_target_args'_v54 = v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : string = "$0.unwrap()"
            let v58 : unativeint = Fable.Core.RustInterop.emitRustExpr v52 v57 
            let _run_target_args'_v54 = v58 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v59 : string = "$0.unwrap()"
            let v60 : unativeint = Fable.Core.RustInterop.emitRustExpr v52 v59 
            let _run_target_args'_v54 = v60 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : unativeint = match v52 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v54 = v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : unativeint = match v52 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v54 = v62 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63 : unativeint = match v52 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v54 = v63 
            #endif
#else
            let v64 : unativeint = match v52 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v54 = v64 
            #endif
            let v65 : unativeint = _run_target_args'_v54 
            let v69 : bool = v65 = v42 
            if v69 then
                let v72 : string = "true; break"
                let v73 : bool = Fable.Core.RustInterop.emitRustExpr () v72 
                ()
            let v75 : unativeint = v65 |> unativeint 
            let v79 : unativeint = v75 |> unbox<unativeint>
            let v82 : string = "v46.len()"
            let v83 : unativeint = Fable.Core.RustInterop.emitRustExpr () v82 
            let v85 : bool = v79 = v83 
            let v92 : Ref<Slice'<uint8>> =
                if v85 then
                    let v88 : string = "&v46[v42..]"
                    let v89 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v88 
                    v89
                else
                    let v90 : string = "&v46[$0..$1]"
                    let v91 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v42, v75) v90 
                    v91
            let v93 : string = "sha2::Digest::update(&mut v38, v92)"
            Fable.Core.RustInterop.emitRustExpr () v93 
            let v94 : string = "true; } // rust.loop"
            let v95 : bool = Fable.Core.RustInterop.emitRustExpr () v94 
            let v96 : string = "true; } // rust.loop"
            let v97 : bool = Fable.Core.RustInterop.emitRustExpr () v96 
            let v98 : string = "true; } // rust.loop"
            let v99 : bool = Fable.Core.RustInterop.emitRustExpr () v98 
            let v100 : string = "true; { // rust.loop"
            let v101 : bool = Fable.Core.RustInterop.emitRustExpr () v100 
            let v102 : string = "true; { // rust.loop"
            let v103 : bool = Fable.Core.RustInterop.emitRustExpr () v102 
            let v104 : string = "&sha2::Digest::finalize(v38)"
            let v105 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v107 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v105 v106 
            let v108 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
            let v110 : string = "x"
            let v111 : uint8 = Fable.Core.RustInterop.emitRustExpr () v110 
            let v112 : string = "format!(\"{:02x}\", $0)"
            let v113 : std_string_String = Fable.Core.RustInterop.emitRustExpr v111 v112 
            let v114 : string = "fable_library_rust::String_::fromString($0)"
            let v115 : string = Fable.Core.RustInterop.emitRustExpr v113 v114 
            let v116 : string = "true; $0 }).collect::<Vec<_>>()"
            let v117 : bool = Fable.Core.RustInterop.emitRustExpr v115 v116 
            let v118 : string = "_vec_map"
            let v119 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v118 
            let v120 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v121 : (string []) = Fable.Core.RustInterop.emitRustExpr v119 v120 
            let v125 : unit = ()
            let _let'_v125 =
                seq {
                    for i = 0 to v121.Length - 1 do yield v121.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v128 : string seq = _let'_v125 
            let v134 : string = method159()
            let v136 : bool = v134 = "\n"
            let v138 : string =
                if v136 then
                    method65(v134)
                else
                    v134
            let v139 : (string -> (string seq -> string)) = String.concat
            let v140 : (string seq -> string) = v139 v138
            let v141 : string = v140 v128
            let v145 : Result<string, std_io_Error> = Ok v141 
            let v148 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v150 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v151 : string = "$0.map_err(|x| $1(x))"
            let v152 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v145, v148) v151 
            let _run_target_args'_v150 = v152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v153 : string = "$0.map_err(|x| $1(x))"
            let v154 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v145, v148) v153 
            let _run_target_args'_v150 = v154 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v155 : string = "$0.map_err(|x| $1(x))"
            let v156 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v145, v148) v155 
            let _run_target_args'_v150 = v156 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v157 : Result<string, std_string_String> = match v145 with Ok x -> Ok x | Error x -> Error (v148 x)
            let _run_target_args'_v150 = v157 
            #endif
#if FABLE_COMPILER_PYTHON
            let v158 : Result<string, std_string_String> = match v145 with Ok x -> Ok x | Error x -> Error (v148 x)
            let _run_target_args'_v150 = v158 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v159 : Result<string, std_string_String> = match v145 with Ok x -> Ok x | Error x -> Error (v148 x)
            let _run_target_args'_v150 = v159 
            #endif
#else
            let v160 : Result<string, std_string_String> = match v145 with Ok x -> Ok x | Error x -> Error (v148 x)
            let _run_target_args'_v150 = v160 
            #endif
            let v161 : Result<string, std_string_String> = _run_target_args'_v150 
            let v164 : (string -> US34) = method160()
            let v165 : (std_string_String -> US34) = method161()
            let v166 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v167 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v164, v165, v161) v166 
            let v176 : string =
                match v167 with
                | US34_1(v169) -> (* Error *)
                    let v171 : string = $"resultm.get / Result value was Error: {v169}"
                    failwith<string> v171
                | US34_0(v168) -> (* Ok *)
                    v168
            let v177 : string = method38(v6)
            let v178 : string = "std::fs::File::open(&*v177)"
            let v179 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v178 
            (* run_target_args'
            let v181 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v182 : string = "$0.unwrap()"
            let v183 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v179 v182 
            let _run_target_args'_v181 = v183 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v184 : string = "$0.unwrap()"
            let v185 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v179 v184 
            let _run_target_args'_v181 = v185 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v186 : string = "$0.unwrap()"
            let v187 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v179 v186 
            let _run_target_args'_v181 = v187 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v188 : std_fs_File = match v179 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v181 = v188 
            #endif
#if FABLE_COMPILER_PYTHON
            let v189 : std_fs_File = match v179 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v181 = v189 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v190 : std_fs_File = match v179 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v181 = v190 
            #endif
#else
            let v191 : std_fs_File = match v179 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v181 = v191 
            #endif
            let v192 : std_fs_File = _run_target_args'_v181 
            let v195 : string = "std::io::BufReader::new($0)"
            let v196 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v192 v195 
            let v197 : string = "std::io::BufReader::new($0)"
            let v198 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v196 v197 
            let v199 : string = "true; let mut v198 = v198"
            let v200 : bool = Fable.Core.RustInterop.emitRustExpr () v199 
            let v201 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v201 
            let v202 : string = "result"
            let v203 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v202 
            let v204 : string = "true; let mut v203 = v203"
            let v205 : bool = Fable.Core.RustInterop.emitRustExpr () v204 
            let v207 : unativeint = 0 |> unativeint 
            let v210 : string = "[$0; 1024]"
            let v211 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v210 
            let v212 : string = "true; loop { // rust.loop"
            let v213 : bool = Fable.Core.RustInterop.emitRustExpr () v212 
            let v214 : string = "true; let mut v211 = v211"
            let v215 : bool = Fable.Core.RustInterop.emitRustExpr () v214 
            let v216 : string = "std::io::Read::read(&mut v198, &mut v211)"
            let v217 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v216 
            (* run_target_args'
            let v219 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v220 : string = "$0.unwrap()"
            let v221 : unativeint = Fable.Core.RustInterop.emitRustExpr v217 v220 
            let _run_target_args'_v219 = v221 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v222 : string = "$0.unwrap()"
            let v223 : unativeint = Fable.Core.RustInterop.emitRustExpr v217 v222 
            let _run_target_args'_v219 = v223 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v224 : string = "$0.unwrap()"
            let v225 : unativeint = Fable.Core.RustInterop.emitRustExpr v217 v224 
            let _run_target_args'_v219 = v225 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v226 : unativeint = match v217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v219 = v226 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : unativeint = match v217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v219 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v228 : unativeint = match v217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v219 = v228 
            #endif
#else
            let v229 : unativeint = match v217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v219 = v229 
            #endif
            let v230 : unativeint = _run_target_args'_v219 
            let v234 : bool = v230 = v207 
            if v234 then
                let v237 : string = "true; break"
                let v238 : bool = Fable.Core.RustInterop.emitRustExpr () v237 
                ()
            let v240 : unativeint = v230 |> unativeint 
            let v244 : unativeint = v240 |> unbox<unativeint>
            let v247 : string = "v211.len()"
            let v248 : unativeint = Fable.Core.RustInterop.emitRustExpr () v247 
            let v250 : bool = v244 = v248 
            let v257 : Ref<Slice'<uint8>> =
                if v250 then
                    let v253 : string = "&v211[v207..]"
                    let v254 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v253 
                    v254
                else
                    let v255 : string = "&v211[$0..$1]"
                    let v256 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v207, v240) v255 
                    v256
            let v258 : string = "sha2::Digest::update(&mut v203, v257)"
            Fable.Core.RustInterop.emitRustExpr () v258 
            let v259 : string = "true; } // rust.loop"
            let v260 : bool = Fable.Core.RustInterop.emitRustExpr () v259 
            let v261 : string = "true; } // rust.loop"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "true; } // rust.loop"
            let v264 : bool = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "true; { // rust.loop"
            let v266 : bool = Fable.Core.RustInterop.emitRustExpr () v265 
            let v267 : string = "true; { // rust.loop"
            let v268 : bool = Fable.Core.RustInterop.emitRustExpr () v267 
            let v269 : string = "&sha2::Digest::finalize(v203)"
            let v270 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v269 
            let v271 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v272 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v270 v271 
            let v273 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v274 : bool = Fable.Core.RustInterop.emitRustExpr v272 v273 
            let v275 : string = "x"
            let v276 : uint8 = Fable.Core.RustInterop.emitRustExpr () v275 
            let v277 : string = "format!(\"{:02x}\", $0)"
            let v278 : std_string_String = Fable.Core.RustInterop.emitRustExpr v276 v277 
            let v279 : string = "fable_library_rust::String_::fromString($0)"
            let v280 : string = Fable.Core.RustInterop.emitRustExpr v278 v279 
            let v281 : string = "true; $0 }).collect::<Vec<_>>()"
            let v282 : bool = Fable.Core.RustInterop.emitRustExpr v280 v281 
            let v283 : string = "_vec_map"
            let v284 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v283 
            let v285 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v286 : (string []) = Fable.Core.RustInterop.emitRustExpr v284 v285 
            let v290 : unit = ()
            let _let'_v290 =
                seq {
                    for i = 0 to v286.Length - 1 do yield v286.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v293 : string seq = _let'_v290 
            let v299 : string = method159()
            let v301 : bool = v299 = "\n"
            let v303 : string =
                if v301 then
                    method65(v299)
                else
                    v299
            let v304 : (string -> (string seq -> string)) = String.concat
            let v305 : (string seq -> string) = v304 v303
            let v306 : string = v305 v293
            let v310 : Result<string, std_io_Error> = Ok v306 
            let v313 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v315 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v316 : string = "$0.map_err(|x| $1(x))"
            let v317 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v310, v313) v316 
            let _run_target_args'_v315 = v317 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v318 : string = "$0.map_err(|x| $1(x))"
            let v319 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v310, v313) v318 
            let _run_target_args'_v315 = v319 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v320 : string = "$0.map_err(|x| $1(x))"
            let v321 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v310, v313) v320 
            let _run_target_args'_v315 = v321 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v322 : Result<string, std_string_String> = match v310 with Ok x -> Ok x | Error x -> Error (v313 x)
            let _run_target_args'_v315 = v322 
            #endif
#if FABLE_COMPILER_PYTHON
            let v323 : Result<string, std_string_String> = match v310 with Ok x -> Ok x | Error x -> Error (v313 x)
            let _run_target_args'_v315 = v323 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v324 : Result<string, std_string_String> = match v310 with Ok x -> Ok x | Error x -> Error (v313 x)
            let _run_target_args'_v315 = v324 
            #endif
#else
            let v325 : Result<string, std_string_String> = match v310 with Ok x -> Ok x | Error x -> Error (v313 x)
            let _run_target_args'_v315 = v325 
            #endif
            let v326 : Result<string, std_string_String> = _run_target_args'_v315 
            let v329 : (string -> US34) = method160()
            let v330 : (std_string_String -> US34) = method161()
            let v331 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v332 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v329, v330, v326) v331 
            let v341 : string =
                match v332 with
                | US34_1(v334) -> (* Error *)
                    let v336 : string = $"resultm.get / Result value was Error: {v334}"
                    failwith<string> v336
                | US34_0(v333) -> (* Ok *)
                    v333
            let v342 : bool = v176 = v341
            v342
    if v343 then
        US33_1
    else
        let v345 : US36 = method181(v2, v5, v3, v1, v4)
        match v345 with
        | US36_1(v418, v419) -> (* Error *)
            let v421 : (string * string) = v5, v419 
            let v425 : Result<string, (string * string)> = Error v421 
            US33_0(v425)
        | US36_0(v346, v347) -> (* Ok *)
            let v349 : bool = v346 <> 0 
            if v349 then
                let v352 : unit = ()
                let v353 : (unit -> unit) = closure82(v347, v346)
                let v354 : unit = (fun () -> v353 (); v352) ()
                let v402 : (string * string) = v5, v347 
                let v406 : Result<string, (string * string)> = Error v402 
                US33_0(v406)
            else
                let v410 : bool = method30(v5)
                if v410 then
                    method164(v6, v5)
                else
                    let v411 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v411
                let v413 : Result<string, (string * string)> = Ok v5 
                US33_0(v413)
and closure83 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US33) =
    closure84(v0, v1, v2, v3)
and method185 (v0 : string, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "output_path"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure8(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure8(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "output_cache_path"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method184 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method185(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "documents.run / par_map / files' = [] / listm.iter"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method18(v14)
and closure86 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method12()
        let v47 : string = method184(v27, v28, v29, v30, v31, v32, v45, v46, v1, v0)
        method19(v47)
and method186 (v0 : UH4, v1 : UH5 list) : UH5 list =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : UH5 list = method186(v3, v1)
        let v6 : UH5 list = v2 :: v4 
        v6
    | UH4_0 -> (* Nil *)
        v1
and closure88 (v0 : UH5) (v1 : UH4) : UH4 =
    UH4_1(v0, v1)
and closure87 () (v0 : UH5) : (UH4 -> UH4) =
    closure88(v0)
and method187 () : (UH5 -> (UH4 -> UH4)) =
    closure87()
and method189 (v0 : UH5, v1 : struct (string * string * (string -> (string -> US33))) list) : struct (string * string * (string -> (string -> US33))) list =
    match v0 with
    | UH5_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US33))) list = method189(v5, v1)
        let v8 : struct (string * string * (string -> (string -> US33))) list = struct (v2, v3, v4) :: v6 
        v8
    | UH5_0 -> (* Nil *)
        v1
and closure89 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US33))) : Result<string, (string * string)> option =
    let v3 : (string -> US33) = v2 v1
    let v4 : US33 = v3 v0
    match v4 with
    | US33_1 -> (* None *)
        let v10 : Result<string, (string * string)> option = None
        v10
    | US33_0(v5) -> (* Some *)
        let v7 : Result<string, (string * string)> option = Some v5 
        v7
and method190 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method191 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method188 (v0 : UH4, v1 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : struct (string * string * (string -> (string -> US33))) list = []
        let v5 : struct (string * string * (string -> (string -> US33))) list = method189(v2, v4)
        let v7 : (struct (string * string * (string -> (string -> US33))) list -> (struct (string * string * (string -> (string -> US33))) [])) = List.toArray
        let v8 : (struct (string * string * (string -> (string -> US33))) []) = v7 v5
        let v11 : string = "$0.to_vec()"
        let v12 : Vec<struct (string * string * (string -> (string -> US33)))> = Fable.Core.RustInterop.emitRustExpr v8 v11 
        let v13 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
        let v14 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US33)))> = Fable.Core.RustInterop.emitRustExpr v12 v13 
        let v15 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v16 : (struct (string * string * (string -> (string -> US33))) -> Result<string, (string * string)> option) = closure89()
        let v17 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US33)))>> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15 
        let v18 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v19 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v17 v18 
        let v20 : Vec<Result<string, (string * string)> option> = method190(v19)
        let v21 : Vec<Result<string, (string * string)> option> = method191(v1)
        let v22 : string = "true; let mut v21 = v21"
        let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
        let v24 : string = "true; v21.extend(v20)"
        let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
        let v26 : string = "v21"
        let v27 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v26 
        method188(v3, v27)
    | UH4_0 -> (* Nil *)
        v1
and closure35 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string = method61(v5)
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v12 
    let _run_target_args'_v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "&*$0"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v14 
    let _run_target_args'_v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "&*$0"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v16 
    let _run_target_args'_v11 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v27 
    #endif
#else
    let v31 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v11 = v31 
    #endif
    let v34 : Ref<Str> = _run_target_args'_v11 
    (* run_target_args'
    let v44 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v45 
    let _run_target_args'_v44 = v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v47 
    let _run_target_args'_v44 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v49 
    let _run_target_args'_v44 = v50 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v56 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v56 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v60 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v60 
    #endif
#else
    let v64 : std_string_String = v34 |> unbox<std_string_String>
    let _run_target_args'_v44 = v64 
    #endif
    let v67 : std_string_String = _run_target_args'_v44 
    (* run_target_args'
    let v77 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v78 : string = "std::path::PathBuf::from($0)"
    let v79 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v78 
    let _run_target_args'_v77 = v79 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v80 : string = "std::path::PathBuf::from($0)"
    let v81 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v80 
    let _run_target_args'_v77 = v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : string = "std::path::PathBuf::from($0)"
    let v83 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v67 v82 
    let _run_target_args'_v77 = v83 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v93 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v93 
    #endif
#else
    let v97 : std_path_PathBuf = v67 |> unbox<std_path_PathBuf>
    let _run_target_args'_v77 = v97 
    #endif
    let v100 : std_path_PathBuf = _run_target_args'_v77 
    (* run_target_args'
    let v110 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = "$0.display()"
    let v112 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v111 
    let _run_target_args'_v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : string = "$0.display()"
    let v114 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v113 
    let _run_target_args'_v110 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : string = "$0.display()"
    let v116 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v115 
    let _run_target_args'_v110 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : std_path_Display = v100 |> unbox<std_path_Display>
    let _run_target_args'_v110 = v118 
    #endif
#if FABLE_COMPILER_PYTHON
    let v122 : std_path_Display = v100 |> unbox<std_path_Display>
    let _run_target_args'_v110 = v122 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v126 : std_path_Display = v100 |> unbox<std_path_Display>
    let _run_target_args'_v110 = v126 
    #endif
#else
    let v130 : std_path_Display = v100 |> unbox<std_path_Display>
    let _run_target_args'_v110 = v130 
    #endif
    let v133 : std_path_Display = _run_target_args'_v110 
    (* run_target_args'
    let v143 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : string = "format!(\"{}\", $0)"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v144 
    let _run_target_args'_v143 = v145 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v146 : string = "format!(\"{}\", $0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v146 
    let _run_target_args'_v143 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v148 : string = "format!(\"{}\", $0)"
    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v133 v148 
    let _run_target_args'_v143 = v149 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v143 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v155 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v143 = v155 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v159 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v143 = v159 
    #endif
#else
    let v163 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v143 = v163 
    #endif
    let v166 : std_string_String = _run_target_args'_v143 
    let v172 : string = "fable_library_rust::String_::fromString($0)"
    let v173 : string = Fable.Core.RustInterop.emitRustExpr v166 v172 
    let v174 : string = method81()
    let v175 : string = v173.Replace (v3, v174)
    let v176 : string = "\\"
    let v177 : string = "/"
    let v178 : string = v175.Replace (v176, v177)
    let v179 : string = $".{v178}"
    let v180 : string = method38(v6)
    let v181 : string = method28(v2, v179)
    let v182 : string = method82(v181)
    let v183 : System.Threading.CancellationToken option = None
    let v184 : (struct (string * string) []) = [||]
    let v185 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v186 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v187 : string option = None
    let v188 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v182}\""
    let v190 : string option = Some v2 
    let v193 : bool = true
    let struct (v194 : int32, v195 : string) = method83(v188, v183, v184, v185, v186, v193, v190)
    let v196 : string = method28(v3, v179)
    let v197 : string = method82(v196)
    let v198 : System.Threading.CancellationToken option = None
    let v199 : (struct (string * string) []) = [||]
    let v200 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v201 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v202 : string option = None
    let v203 : string = $"git hash-object \"{v197}\""
    let v205 : string option = Some v3 
    let v208 : bool = true
    let struct (v209 : int32, v210 : string) = method83(v203, v198, v199, v200, v201, v208, v205)
    let v211 : string = method28(v4, v179)
    let v212 : string = method82(v211)
    let v213 : string = "hangul.md"
    let struct (v214 : string, v215 : string) = method158(v213, v197, v4)
    let v216 : bool = false
    let v217 : bool = false
    let v218 : bool = false
    let v219 : bool = true
    let v220 : bool = true
    let v221 : bool = true
    let v223 : bool = v195.Contains v210 
    let v721 : UH4 =
        if v223 then
            UH4_0
        else
            let v227 : string = method38(v197)
            let v228 : string = "std::fs::File::open(&*v227)"
            let v229 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v228 
            (* run_target_args'
            let v231 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v232 : string = "$0.unwrap()"
            let v233 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v229 v232 
            let _run_target_args'_v231 = v233 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v234 : string = "$0.unwrap()"
            let v235 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v229 v234 
            let _run_target_args'_v231 = v235 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : string = "$0.unwrap()"
            let v237 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v229 v236 
            let _run_target_args'_v231 = v237 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v238 : std_fs_File = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v231 = v238 
            #endif
#if FABLE_COMPILER_PYTHON
            let v239 : std_fs_File = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v231 = v239 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v240 : std_fs_File = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v231 = v240 
            #endif
#else
            let v241 : std_fs_File = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v231 = v241 
            #endif
            let v242 : std_fs_File = _run_target_args'_v231 
            let v245 : string = "std::io::BufReader::new($0)"
            let v246 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v242 v245 
            let v247 : string = "std::io::BufReader::new($0)"
            let v248 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v246 v247 
            let v249 : string = "true; let mut v248 = v248"
            let v250 : bool = Fable.Core.RustInterop.emitRustExpr () v249 
            let v251 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v251 
            let v252 : string = "result"
            let v253 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v252 
            let v254 : string = "true; let mut v253 = v253"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr () v254 
            let v257 : unativeint = 0 |> unativeint 
            let v260 : string = "[$0; 1024]"
            let v261 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v260 
            let v262 : string = "true; loop { // rust.loop"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "true; let mut v261 = v261"
            let v265 : bool = Fable.Core.RustInterop.emitRustExpr () v264 
            let v266 : string = "std::io::Read::read(&mut v248, &mut v261)"
            let v267 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v266 
            (* run_target_args'
            let v269 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v270 : string = "$0.unwrap()"
            let v271 : unativeint = Fable.Core.RustInterop.emitRustExpr v267 v270 
            let _run_target_args'_v269 = v271 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v272 : string = "$0.unwrap()"
            let v273 : unativeint = Fable.Core.RustInterop.emitRustExpr v267 v272 
            let _run_target_args'_v269 = v273 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v274 : string = "$0.unwrap()"
            let v275 : unativeint = Fable.Core.RustInterop.emitRustExpr v267 v274 
            let _run_target_args'_v269 = v275 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v276 : unativeint = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v269 = v276 
            #endif
#if FABLE_COMPILER_PYTHON
            let v277 : unativeint = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v269 = v277 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v278 : unativeint = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v269 = v278 
            #endif
#else
            let v279 : unativeint = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v269 = v279 
            #endif
            let v280 : unativeint = _run_target_args'_v269 
            let v284 : bool = v280 = v257 
            if v284 then
                let v287 : string = "true; break"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr () v287 
                ()
            let v290 : unativeint = v280 |> unativeint 
            let v294 : unativeint = v290 |> unbox<unativeint>
            let v297 : string = "v261.len()"
            let v298 : unativeint = Fable.Core.RustInterop.emitRustExpr () v297 
            let v300 : bool = v294 = v298 
            let v307 : Ref<Slice'<uint8>> =
                if v300 then
                    let v303 : string = "&v261[v257..]"
                    let v304 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v303 
                    v304
                else
                    let v305 : string = "&v261[$0..$1]"
                    let v306 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v257, v290) v305 
                    v306
            let v308 : string = "sha2::Digest::update(&mut v253, v307)"
            Fable.Core.RustInterop.emitRustExpr () v308 
            let v309 : string = "true; } // rust.loop"
            let v310 : bool = Fable.Core.RustInterop.emitRustExpr () v309 
            let v311 : string = "true; } // rust.loop"
            let v312 : bool = Fable.Core.RustInterop.emitRustExpr () v311 
            let v313 : string = "true; } // rust.loop"
            let v314 : bool = Fable.Core.RustInterop.emitRustExpr () v313 
            let v315 : string = "true; { // rust.loop"
            let v316 : bool = Fable.Core.RustInterop.emitRustExpr () v315 
            let v317 : string = "true; { // rust.loop"
            let v318 : bool = Fable.Core.RustInterop.emitRustExpr () v317 
            let v319 : string = "&sha2::Digest::finalize(v253)"
            let v320 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v319 
            let v321 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v322 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v320 v321 
            let v323 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v324 : bool = Fable.Core.RustInterop.emitRustExpr v322 v323 
            let v325 : string = "x"
            let v326 : uint8 = Fable.Core.RustInterop.emitRustExpr () v325 
            let v327 : string = "format!(\"{:02x}\", $0)"
            let v328 : std_string_String = Fable.Core.RustInterop.emitRustExpr v326 v327 
            let v329 : string = "fable_library_rust::String_::fromString($0)"
            let v330 : string = Fable.Core.RustInterop.emitRustExpr v328 v329 
            let v331 : string = "true; $0 }).collect::<Vec<_>>()"
            let v332 : bool = Fable.Core.RustInterop.emitRustExpr v330 v331 
            let v333 : string = "_vec_map"
            let v334 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v333 
            let v335 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v336 : (string []) = Fable.Core.RustInterop.emitRustExpr v334 v335 
            let v340 : unit = ()
            let _let'_v340 =
                seq {
                    for i = 0 to v336.Length - 1 do yield v336.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v343 : string seq = _let'_v340 
            let v349 : string = method159()
            let v351 : bool = v349 = "\n"
            let v353 : string =
                if v351 then
                    method65(v349)
                else
                    v349
            let v354 : (string -> (string seq -> string)) = String.concat
            let v355 : (string seq -> string) = v354 v353
            let v356 : string = v355 v343
            let v360 : Result<string, std_io_Error> = Ok v356 
            let v363 : (std_io_Error -> std_string_String) = method69()
            (* run_target_args'
            let v365 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v366 : string = "$0.map_err(|x| $1(x))"
            let v367 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v360, v363) v366 
            let _run_target_args'_v365 = v367 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v368 : string = "$0.map_err(|x| $1(x))"
            let v369 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v360, v363) v368 
            let _run_target_args'_v365 = v369 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v370 : string = "$0.map_err(|x| $1(x))"
            let v371 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v360, v363) v370 
            let _run_target_args'_v365 = v371 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v372 : Result<string, std_string_String> = match v360 with Ok x -> Ok x | Error x -> Error (v363 x)
            let _run_target_args'_v365 = v372 
            #endif
#if FABLE_COMPILER_PYTHON
            let v373 : Result<string, std_string_String> = match v360 with Ok x -> Ok x | Error x -> Error (v363 x)
            let _run_target_args'_v365 = v373 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v374 : Result<string, std_string_String> = match v360 with Ok x -> Ok x | Error x -> Error (v363 x)
            let _run_target_args'_v365 = v374 
            #endif
#else
            let v375 : Result<string, std_string_String> = match v360 with Ok x -> Ok x | Error x -> Error (v363 x)
            let _run_target_args'_v365 = v375 
            #endif
            let v376 : Result<string, std_string_String> = _run_target_args'_v365 
            let v379 : (string -> US34) = method160()
            let v380 : (std_string_String -> US34) = method161()
            let v381 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v382 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v379, v380, v376) v381 
            let v391 : string =
                match v382 with
                | US34_1(v384) -> (* Error *)
                    let v386 : string = $"resultm.get / Result value was Error: {v384}"
                    failwith<string> v386
                | US34_0(v383) -> (* Ok *)
                    v383
            let v392 : bool = method30(v212)
            let v393 : bool = v392 = false
            let v557 : US5 =
                if v393 then
                    US5_1
                else
                    let v395 : string = method38(v212)
                    let v396 : string = "std::fs::File::open(&*v395)"
                    let v397 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v396 
                    (* run_target_args'
                    let v399 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v400 : string = "$0.unwrap()"
                    let v401 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v397 v400 
                    let _run_target_args'_v399 = v401 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v402 : string = "$0.unwrap()"
                    let v403 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v397 v402 
                    let _run_target_args'_v399 = v403 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v404 : string = "$0.unwrap()"
                    let v405 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v397 v404 
                    let _run_target_args'_v399 = v405 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v406 : std_fs_File = match v397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v399 = v406 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v407 : std_fs_File = match v397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v399 = v407 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v408 : std_fs_File = match v397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v399 = v408 
                    #endif
#else
                    let v409 : std_fs_File = match v397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v399 = v409 
                    #endif
                    let v410 : std_fs_File = _run_target_args'_v399 
                    let v413 : string = "std::io::BufReader::new($0)"
                    let v414 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v410 v413 
                    let v415 : string = "std::io::BufReader::new($0)"
                    let v416 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v414 v415 
                    let v417 : string = "true; let mut v416 = v416"
                    let v418 : bool = Fable.Core.RustInterop.emitRustExpr () v417 
                    let v419 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v419 
                    let v420 : string = "result"
                    let v421 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v420 
                    let v422 : string = "true; let mut v421 = v421"
                    let v423 : bool = Fable.Core.RustInterop.emitRustExpr () v422 
                    let v425 : unativeint = 0 |> unativeint 
                    let v428 : string = "[$0; 1024]"
                    let v429 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v428 
                    let v430 : string = "true; loop { // rust.loop"
                    let v431 : bool = Fable.Core.RustInterop.emitRustExpr () v430 
                    let v432 : string = "true; let mut v429 = v429"
                    let v433 : bool = Fable.Core.RustInterop.emitRustExpr () v432 
                    let v434 : string = "std::io::Read::read(&mut v416, &mut v429)"
                    let v435 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v434 
                    (* run_target_args'
                    let v437 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v438 : string = "$0.unwrap()"
                    let v439 : unativeint = Fable.Core.RustInterop.emitRustExpr v435 v438 
                    let _run_target_args'_v437 = v439 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v440 : string = "$0.unwrap()"
                    let v441 : unativeint = Fable.Core.RustInterop.emitRustExpr v435 v440 
                    let _run_target_args'_v437 = v441 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v442 : string = "$0.unwrap()"
                    let v443 : unativeint = Fable.Core.RustInterop.emitRustExpr v435 v442 
                    let _run_target_args'_v437 = v443 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v444 : unativeint = match v435 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v437 = v444 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v445 : unativeint = match v435 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v437 = v445 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v446 : unativeint = match v435 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v437 = v446 
                    #endif
#else
                    let v447 : unativeint = match v435 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _run_target_args'_v437 = v447 
                    #endif
                    let v448 : unativeint = _run_target_args'_v437 
                    let v452 : bool = v448 = v425 
                    if v452 then
                        let v455 : string = "true; break"
                        let v456 : bool = Fable.Core.RustInterop.emitRustExpr () v455 
                        ()
                    let v458 : unativeint = v448 |> unativeint 
                    let v462 : unativeint = v458 |> unbox<unativeint>
                    let v465 : string = "v429.len()"
                    let v466 : unativeint = Fable.Core.RustInterop.emitRustExpr () v465 
                    let v468 : bool = v462 = v466 
                    let v475 : Ref<Slice'<uint8>> =
                        if v468 then
                            let v471 : string = "&v429[v425..]"
                            let v472 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v471 
                            v472
                        else
                            let v473 : string = "&v429[$0..$1]"
                            let v474 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v425, v458) v473 
                            v474
                    let v476 : string = "sha2::Digest::update(&mut v421, v475)"
                    Fable.Core.RustInterop.emitRustExpr () v476 
                    let v477 : string = "true; } // rust.loop"
                    let v478 : bool = Fable.Core.RustInterop.emitRustExpr () v477 
                    let v479 : string = "true; } // rust.loop"
                    let v480 : bool = Fable.Core.RustInterop.emitRustExpr () v479 
                    let v481 : string = "true; } // rust.loop"
                    let v482 : bool = Fable.Core.RustInterop.emitRustExpr () v481 
                    let v483 : string = "true; { // rust.loop"
                    let v484 : bool = Fable.Core.RustInterop.emitRustExpr () v483 
                    let v485 : string = "true; { // rust.loop"
                    let v486 : bool = Fable.Core.RustInterop.emitRustExpr () v485 
                    let v487 : string = "&sha2::Digest::finalize(v421)"
                    let v488 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v487 
                    let v489 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v490 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v488 v489 
                    let v491 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
                    let v492 : bool = Fable.Core.RustInterop.emitRustExpr v490 v491 
                    let v493 : string = "x"
                    let v494 : uint8 = Fable.Core.RustInterop.emitRustExpr () v493 
                    let v495 : string = "format!(\"{:02x}\", $0)"
                    let v496 : std_string_String = Fable.Core.RustInterop.emitRustExpr v494 v495 
                    let v497 : string = "fable_library_rust::String_::fromString($0)"
                    let v498 : string = Fable.Core.RustInterop.emitRustExpr v496 v497 
                    let v499 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v500 : bool = Fable.Core.RustInterop.emitRustExpr v498 v499 
                    let v501 : string = "_vec_map"
                    let v502 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v501 
                    let v503 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
                    let v504 : (string []) = Fable.Core.RustInterop.emitRustExpr v502 v503 
                    let v508 : unit = ()
                    let _let'_v508 =
                        seq {
                            for i = 0 to v504.Length - 1 do yield v504.[i]
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v511 : string seq = _let'_v508 
                    let v517 : string = method159()
                    let v519 : bool = v517 = "\n"
                    let v521 : string =
                        if v519 then
                            method65(v517)
                        else
                            v517
                    let v522 : (string -> (string seq -> string)) = String.concat
                    let v523 : (string seq -> string) = v522 v521
                    let v524 : string = v523 v511
                    let v528 : Result<string, std_io_Error> = Ok v524 
                    let v531 : (std_io_Error -> std_string_String) = method69()
                    (* run_target_args'
                    let v533 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v534 : string = "$0.map_err(|x| $1(x))"
                    let v535 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v528, v531) v534 
                    let _run_target_args'_v533 = v535 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v536 : string = "$0.map_err(|x| $1(x))"
                    let v537 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v528, v531) v536 
                    let _run_target_args'_v533 = v537 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v538 : string = "$0.map_err(|x| $1(x))"
                    let v539 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v528, v531) v538 
                    let _run_target_args'_v533 = v539 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v540 : Result<string, std_string_String> = match v528 with Ok x -> Ok x | Error x -> Error (v531 x)
                    let _run_target_args'_v533 = v540 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v541 : Result<string, std_string_String> = match v528 with Ok x -> Ok x | Error x -> Error (v531 x)
                    let _run_target_args'_v533 = v541 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v542 : Result<string, std_string_String> = match v528 with Ok x -> Ok x | Error x -> Error (v531 x)
                    let _run_target_args'_v533 = v542 
                    #endif
#else
                    let v543 : Result<string, std_string_String> = match v528 with Ok x -> Ok x | Error x -> Error (v531 x)
                    let _run_target_args'_v533 = v543 
                    #endif
                    let v544 : Result<string, std_string_String> = _run_target_args'_v533 
                    let v547 : (string -> US34) = method160()
                    let v548 : (std_string_String -> US34) = method161()
                    let v549 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v550 : US34 = Fable.Core.RustInterop.emitRustExpr struct (v547, v548, v544) v549 
                    match v550 with
                    | US34_1(v553) -> (* Error *)
                        US5_1
                    | US34_0(v551) -> (* Ok *)
                        US5_0(v551)
            match v557 with
            | US5_0(v558) -> (* Some *)
                let v559 : bool = v391 = v558
                if v559 then
                    UH4_0
                else
                    let v561 : unit = ()
                    let v562 : (unit -> unit) = closure73(v179, v180, v182, v195, v194, v197, v210, v209, v212, v391, v557)
                    let v563 : unit = (fun () -> v562 (); v561) ()
                    method164(v212, v197)
                    let v618 : (string -> (string -> US33)) = closure78(v4, v3, v1, v0)
                    let v619 : UH5 = UH5_0
                    let v620 : UH5 = UH5_1(v213, v197, v618, v619)
                    let v621 : string = "html"
                    let v622 : (string -> (string -> US33)) = closure83(v4, v3, v216)
                    let v623 : string = "pdf"
                    let v624 : (string -> (string -> US33)) = closure83(v4, v3, v217)
                    let v625 : string = "epub"
                    let v626 : (string -> (string -> US33)) = closure83(v4, v3, v218)
                    let v627 : (string -> (string -> US33)) = closure83(v4, v3, v219)
                    let v628 : (string -> (string -> US33)) = closure83(v4, v3, v220)
                    let v629 : (string -> (string -> US33)) = closure83(v4, v3, v221)
                    let v630 : UH5 = UH5_0
                    let v631 : UH5 = UH5_1(v625, v214, v629, v630)
                    let v632 : UH5 = UH5_1(v623, v214, v628, v631)
                    let v633 : UH5 = UH5_1(v621, v214, v627, v632)
                    let v634 : UH5 = UH5_1(v625, v197, v626, v633)
                    let v635 : UH5 = UH5_1(v623, v197, v624, v634)
                    let v636 : UH5 = UH5_1(v621, v197, v622, v635)
                    let v637 : UH4 = UH4_0
                    let v638 : UH4 = UH4_1(v636, v637)
                    UH4_1(v620, v638)
            | _ ->
                let v641 : unit = ()
                let v642 : (unit -> unit) = closure73(v179, v180, v182, v195, v194, v197, v210, v209, v212, v391, v557)
                let v643 : unit = (fun () -> v642 (); v641) ()
                method164(v212, v197)
                let v698 : (string -> (string -> US33)) = closure78(v4, v3, v1, v0)
                let v699 : UH5 = UH5_0
                let v700 : UH5 = UH5_1(v213, v197, v698, v699)
                let v701 : string = "html"
                let v702 : (string -> (string -> US33)) = closure83(v4, v3, v216)
                let v703 : string = "pdf"
                let v704 : (string -> (string -> US33)) = closure83(v4, v3, v217)
                let v705 : string = "epub"
                let v706 : (string -> (string -> US33)) = closure83(v4, v3, v218)
                let v707 : (string -> (string -> US33)) = closure83(v4, v3, v219)
                let v708 : (string -> (string -> US33)) = closure83(v4, v3, v220)
                let v709 : (string -> (string -> US33)) = closure83(v4, v3, v221)
                let v710 : UH5 = UH5_0
                let v711 : UH5 = UH5_1(v705, v214, v709, v710)
                let v712 : UH5 = UH5_1(v703, v214, v708, v711)
                let v713 : UH5 = UH5_1(v701, v214, v707, v712)
                let v714 : UH5 = UH5_1(v705, v197, v706, v713)
                let v715 : UH5 = UH5_1(v703, v197, v704, v714)
                let v716 : UH5 = UH5_1(v701, v197, v702, v715)
                let v717 : UH4 = UH4_0
                let v718 : UH4 = UH4_1(v716, v717)
                UH4_1(v700, v718)
    let v722 : bool =
        match v721 with
        | UH4_0 -> (* Nil *)
            true
        | _ ->
            false
    let v723 : bool = v722 <> true
    let v1147 : UH4 =
        if v723 then
            v721
        else
            let v724 : string = "epub"
            let struct (v725 : string, v726 : string) = method158(v724, v214, v4)
            let v727 : bool = method30(v725)
            let v780 : bool =
                if v727 then
                    true
                else
                    let v728 : bool = method30(v726)
                    let v729 : bool = v728 = false
                    if v729 then
                        true
                    else
                        let v730 : unit = ()
                        let v731 : (unit -> unit) = closure86(v726, v725)
                        let v732 : unit = (fun () -> v731 (); v730) ()
                        method164(v725, v726)
                        false
            let v785 : UH5 =
                if v780 then
                    let v781 : (string -> (string -> US33)) = closure83(v4, v3, v221)
                    let v782 : UH5 = UH5_0
                    UH5_1(v724, v214, v781, v782)
                else
                    UH5_0
            let v786 : string = "pdf"
            let struct (v787 : string, v788 : string) = method158(v786, v214, v4)
            let v789 : bool = method30(v787)
            let v842 : bool =
                if v789 then
                    true
                else
                    let v790 : bool = method30(v788)
                    let v791 : bool = v790 = false
                    if v791 then
                        true
                    else
                        let v792 : unit = ()
                        let v793 : (unit -> unit) = closure86(v788, v787)
                        let v794 : unit = (fun () -> v793 (); v792) ()
                        method164(v787, v788)
                        false
            let v845 : UH5 =
                if v842 then
                    let v843 : (string -> (string -> US33)) = closure83(v4, v3, v220)
                    UH5_1(v786, v214, v843, v785)
                else
                    v785
            let v846 : string = "html"
            let struct (v847 : string, v848 : string) = method158(v846, v214, v4)
            let v849 : bool = method30(v847)
            let v902 : bool =
                if v849 then
                    true
                else
                    let v850 : bool = method30(v848)
                    let v851 : bool = v850 = false
                    if v851 then
                        true
                    else
                        let v852 : unit = ()
                        let v853 : (unit -> unit) = closure86(v848, v847)
                        let v854 : unit = (fun () -> v853 (); v852) ()
                        method164(v847, v848)
                        false
            let v905 : UH5 =
                if v902 then
                    let v903 : (string -> (string -> US33)) = closure83(v4, v3, v219)
                    UH5_1(v846, v214, v903, v845)
                else
                    v845
            let struct (v906 : string, v907 : string) = method158(v724, v197, v4)
            let v908 : bool = method30(v906)
            let v961 : bool =
                if v908 then
                    true
                else
                    let v909 : bool = method30(v907)
                    let v910 : bool = v909 = false
                    if v910 then
                        true
                    else
                        let v911 : unit = ()
                        let v912 : (unit -> unit) = closure86(v907, v906)
                        let v913 : unit = (fun () -> v912 (); v911) ()
                        method164(v906, v907)
                        false
            let v964 : UH5 =
                if v961 then
                    let v962 : (string -> (string -> US33)) = closure83(v4, v3, v218)
                    UH5_1(v724, v197, v962, v905)
                else
                    v905
            let struct (v965 : string, v966 : string) = method158(v786, v197, v4)
            let v967 : bool = method30(v965)
            let v1020 : bool =
                if v967 then
                    true
                else
                    let v968 : bool = method30(v966)
                    let v969 : bool = v968 = false
                    if v969 then
                        true
                    else
                        let v970 : unit = ()
                        let v971 : (unit -> unit) = closure86(v966, v965)
                        let v972 : unit = (fun () -> v971 (); v970) ()
                        method164(v965, v966)
                        false
            let v1023 : UH5 =
                if v1020 then
                    let v1021 : (string -> (string -> US33)) = closure83(v4, v3, v217)
                    UH5_1(v786, v197, v1021, v964)
                else
                    v964
            let struct (v1024 : string, v1025 : string) = method158(v846, v197, v4)
            let v1026 : bool = method30(v1024)
            let v1079 : bool =
                if v1026 then
                    true
                else
                    let v1027 : bool = method30(v1025)
                    let v1028 : bool = v1027 = false
                    if v1028 then
                        true
                    else
                        let v1029 : unit = ()
                        let v1030 : (unit -> unit) = closure86(v1025, v1024)
                        let v1031 : unit = (fun () -> v1030 (); v1029) ()
                        method164(v1024, v1025)
                        false
            let v1082 : UH5 =
                if v1079 then
                    let v1080 : (string -> (string -> US33)) = closure83(v4, v3, v216)
                    UH5_1(v846, v197, v1080, v1023)
                else
                    v1023
            let struct (v1083 : string, v1084 : string) = method158(v213, v197, v4)
            let v1085 : bool = method30(v1083)
            let v1138 : bool =
                if v1085 then
                    true
                else
                    let v1086 : bool = method30(v1084)
                    let v1087 : bool = v1086 = false
                    if v1087 then
                        true
                    else
                        let v1088 : unit = ()
                        let v1089 : (unit -> unit) = closure86(v1084, v1083)
                        let v1090 : unit = (fun () -> v1089 (); v1088) ()
                        method164(v1083, v1084)
                        false
            let v1143 : UH5 =
                if v1138 then
                    let v1139 : (string -> (string -> US33)) = closure78(v4, v3, v1, v0)
                    let v1140 : UH5 = UH5_0
                    UH5_1(v213, v197, v1139, v1140)
                else
                    UH5_0
            let v1144 : UH4 = UH4_0
            let v1145 : UH4 = UH4_1(v1082, v1144)
            UH4_1(v1143, v1145)
    let v1148 : UH5 list = []
    let v1149 : UH5 list = method186(v1147, v1148)
    let v1151 : (UH5 list -> (UH5 [])) = List.toArray
    let v1152 : (UH5 []) = v1151 v1149
    let v1155 : string = "$0.to_vec()"
    let v1156 : Vec<UH5> = Fable.Core.RustInterop.emitRustExpr v1152 v1155 
    let v1157 : (Result<string, (string * string)> option []) = [||]
    let v1158 : string = "$0.to_vec()"
    let v1159 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1157 v1158 
    let v1160 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1161 : (UH5 []) = Fable.Core.RustInterop.emitRustExpr v1156 v1160 
    let v1163 : UH5 list = v1161 |> Array.toList
    let v1171 : ((UH5 -> (UH4 -> UH4)) -> (UH5 list -> (UH4 -> UH4))) = List.foldBack
    let v1172 : (UH5 -> (UH4 -> UH4)) = method187()
    let v1173 : (UH5 list -> (UH4 -> UH4)) = v1171 v1172
    let v1174 : (UH4 -> UH4) = v1173 v1163
    let v1175 : UH4 = UH4_0
    let v1176 : UH4 = v1174 v1175
    let v1205 : Vec<Result<string, (string * string)> option> = method188(v1176, v1159)
    let v1207 : (string * Vec<Result<string, (string * string)> option>) = v180, v1205 
    let v1211 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1207 
    v1211
and method25 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = method26()
    let v5 : US5 = method27(v4)
    let v11 : US5 =
        match v5 with
        | US5_1 -> (* None *)
            let v8 : string = __SOURCE_DIRECTORY__
            method27(v8)
        | US5_0(v6) -> (* Some *)
            US5_0(v6)
    let v17 : US5 =
        match v11 with
        | US5_1 -> (* None *)
            let v14 : string = "/workspaces"
            method27(v14)
        | US5_0(v12) -> (* Some *)
            US5_0(v12)
    let v21 : string =
        match v17 with
        | US5_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US5_0(v18) -> (* Some *)
            v18
    let v22 : string = method47(v21)
    let v23 : bool = "deps" = v22
    let v34 : string =
        if v23 then
            let v24 : string option = method33(v21)
            let v26 : string = v24 |> Option.get
            let v29 : US5 = method27(v26)
            match v29 with
            | US5_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US5_0(v30) -> (* Some *)
                v30
        else
            v21
    let v35 : string = "polyglot"
    let v36 : string = method28(v34, v35)
    let v37 : string = method61(v3)
    let v38 : string = method61(v2)
    let v39 : string = method61(v1)
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure24(v0, v37, v38, v39)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v89 : string = "true; let __future_init = Box::pin(/*"
    let v90 : bool = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = "*/ async move { /*"
    let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "*/ ()"
    let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93 
    let v95 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v96 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v38 v95 
    let v97 : string = "async_walkdir::WalkDir::filter($0, move |x| $1(x))"
    let v98 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure25()
    let v99 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v96, v98) v97 
    let v100 : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) = method72()
    let v101 : string = "futures::stream::StreamExt::filter_map(v99, |x| async { v100(x) })"
    let v102 : _ = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "Box::pin(futures::stream::StreamExt::collect(v102))"
    let v104 : std_pin_Pin<Box<Dyn<std_future_Future<Vec<string>>>>> = Fable.Core.RustInterop.emitRustExpr () v103 
    let v105 : string = "v104.await"
    let v106 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v105 
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure34(v106)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v158 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
    let v159 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr v106 v158 
    let v160 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v161 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure35(v0, v36, v37, v38, v39)
    let v162 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v159, v161) v160 
    let v163 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v164 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v162 v163 
    let v166 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v164 
    let v169 : string = ""
    let v170 : string = "}"
    let v171 : string = v169 + v170 
    let x = v166 //
    let v172 : _ = x
    let v173 : unit = ()
    (* run_target_args'
    let v174 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v175 : string = $"true; let _fix_closure_v173 = $0"
    let v176 : bool = Fable.Core.RustInterop.emitRustExpr v172 v175 
    let _run_target_args'_v174 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v177 : string = $"true; let _fix_closure_v173 = $0"
    let v178 : bool = Fable.Core.RustInterop.emitRustExpr v172 v177 
    let _run_target_args'_v174 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : string = $"true; let _fix_closure_v173 = $0"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr v172 v179 
    let _run_target_args'_v174 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v174 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v174 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v174 = false 
    #endif
#else
    let _run_target_args'_v174 = false 
    #endif
    let v181 : bool = _run_target_args'_v174 
    let v183 : string = $"true; _fix_closure_v173 " + v171 + "); " + v169 + " // rust.fix_closure'"
    let v184 : bool = Fable.Core.RustInterop.emitRustExpr () v183 
    let v185 : string = "__future_init"
    let v186 : _ = Fable.Core.RustInterop.emitRustExpr () v185 
    let v187 : string = "v186"
    let v188 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v187 
    v188
and closure90 () (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : US37 =
    US37_0(v0)
and method192 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) =
    closure90()
and closure91 () (v0 : std_string_String) : US37 =
    US37_1(v0)
and method193 () : (std_string_String -> US37) =
    closure91()
and method194 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure92 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method76()
        let v46 : string = method194(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method19(v46)
and method196 (v0 : unativeint) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "result_len"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    (* run_target_args'
    let v37 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _run_target_args'_v37 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v37 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v37 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = $"%A{v0}"
    let _run_target_args'_v37 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v37 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v37 = v59 
    #endif
#else
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v37 = v63 
    #endif
    let v66 : string = _run_target_args'_v37 
    let v73 : string = $"{v66}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure8(v2, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v2, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v2.l0
    v91
and method195 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method196(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "documents.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method18(v13)
and closure93 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method8(v26, v27, v28, v29, v30, v31)
        let v45 : string = method12()
        let v46 : string = "$0.len()"
        let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v46 
        let v48 : string = method195(v26, v27, v28, v29, v30, v31, v44, v45, v47)
        method19(v48)
and closure1 () (v0 : (string [])) : int32 =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure5(v0)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v67 : clap_Command = method0()
    let v68 : string = "clap::Command::get_matches($0)"
    let v69 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let v70 : string = method20()
    (* run_target_args'
    let v75 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v70 v76 
    let _run_target_args'_v75 = v77 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v70 v78 
    let _run_target_args'_v75 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v70 v80 
    let _run_target_args'_v75 = v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : Ref<Str> = v70 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v70 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v87 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v91 : Ref<Str> = v70 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v91 
    #endif
#else
    let v95 : Ref<Str> = v70 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v95 
    #endif
    let v98 : Ref<Str> = _run_target_args'_v75 
    let v104 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v105 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v98) v104 
    let v108 : (std_string_String -> US6) = method21()
    let v109 : US6 option = v105 |> Option.map v108 
    let v123 : US6 = US6_1
    let v124 : US6 = v109 |> Option.defaultValue v123 
    let v131 : std_string_String =
        match v124 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v128) -> (* Some *)
            v128
    let v132 : string = "fable_library_rust::String_::fromString($0)"
    let v133 : string = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let v134 : string = method22()
    (* run_target_args'
    let v139 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v140 : string = "&*$0"
    let v141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v134 v140 
    let _run_target_args'_v139 = v141 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v142 : string = "&*$0"
    let v143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v134 v142 
    let _run_target_args'_v139 = v143 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v144 : string = "&*$0"
    let v145 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v134 v144 
    let _run_target_args'_v139 = v145 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v147 : Ref<Str> = v134 |> unbox<Ref<Str>>
    let _run_target_args'_v139 = v147 
    #endif
#if FABLE_COMPILER_PYTHON
    let v151 : Ref<Str> = v134 |> unbox<Ref<Str>>
    let _run_target_args'_v139 = v151 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v155 : Ref<Str> = v134 |> unbox<Ref<Str>>
    let _run_target_args'_v139 = v155 
    #endif
#else
    let v159 : Ref<Str> = v134 |> unbox<Ref<Str>>
    let _run_target_args'_v139 = v159 
    #endif
    let v162 : Ref<Str> = _run_target_args'_v139 
    let v168 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v169 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v162) v168 
    let v172 : (std_string_String -> US6) = method21()
    let v173 : US6 option = v169 |> Option.map v172 
    let v187 : US6 = US6_1
    let v188 : US6 = v173 |> Option.defaultValue v187 
    let v195 : std_string_String =
        match v188 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v192) -> (* Some *)
            v192
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let v198 : string = method23()
    (* run_target_args'
    let v203 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v204 : string = "&*$0"
    let v205 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v198 v204 
    let _run_target_args'_v203 = v205 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v206 : string = "&*$0"
    let v207 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v198 v206 
    let _run_target_args'_v203 = v207 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v208 : string = "&*$0"
    let v209 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v198 v208 
    let _run_target_args'_v203 = v209 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v211 : Ref<Str> = v198 |> unbox<Ref<Str>>
    let _run_target_args'_v203 = v211 
    #endif
#if FABLE_COMPILER_PYTHON
    let v215 : Ref<Str> = v198 |> unbox<Ref<Str>>
    let _run_target_args'_v203 = v215 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v219 : Ref<Str> = v198 |> unbox<Ref<Str>>
    let _run_target_args'_v203 = v219 
    #endif
#else
    let v223 : Ref<Str> = v198 |> unbox<Ref<Str>>
    let _run_target_args'_v203 = v223 
    #endif
    let v226 : Ref<Str> = _run_target_args'_v203 
    let v232 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v233 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v226) v232 
    let v236 : (std_string_String -> US6) = method21()
    let v237 : US6 option = v233 |> Option.map v236 
    let v251 : US6 = US6_1
    let v252 : US6 = v237 |> Option.defaultValue v251 
    let v259 : std_string_String =
        match v252 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v256) -> (* Some *)
            v256
    let v260 : string = "fable_library_rust::String_::fromString($0)"
    let v261 : string = Fable.Core.RustInterop.emitRustExpr v259 v260 
    let v262 : string = method24()
    (* run_target_args'
    let v267 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v268 : string = "&*$0"
    let v269 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v262 v268 
    let _run_target_args'_v267 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : string = "&*$0"
    let v271 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v262 v270 
    let _run_target_args'_v267 = v271 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v272 : string = "&*$0"
    let v273 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v262 v272 
    let _run_target_args'_v267 = v273 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v275 : Ref<Str> = v262 |> unbox<Ref<Str>>
    let _run_target_args'_v267 = v275 
    #endif
#if FABLE_COMPILER_PYTHON
    let v279 : Ref<Str> = v262 |> unbox<Ref<Str>>
    let _run_target_args'_v267 = v279 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v283 : Ref<Str> = v262 |> unbox<Ref<Str>>
    let _run_target_args'_v267 = v283 
    #endif
#else
    let v287 : Ref<Str> = v262 |> unbox<Ref<Str>>
    let _run_target_args'_v267 = v287 
    #endif
    let v290 : Ref<Str> = _run_target_args'_v267 
    let v296 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v297 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v69, v290) v296 
    let v300 : (std_string_String -> US6) = method21()
    let v301 : US6 option = v297 |> Option.map v300 
    let v315 : US6 = US6_1
    let v316 : US6 = v301 |> Option.defaultValue v315 
    let v323 : std_string_String =
        match v316 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v320) -> (* Some *)
            v320
    let v324 : string = "fable_library_rust::String_::fromString($0)"
    let v325 : string = Fable.Core.RustInterop.emitRustExpr v323 v324 
    let v326 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method25(v325, v261, v197, v133)
    let v327 : string = "futures::executor::block_on($0)"
    let v328 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v326 v327 
    let v329 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US37) = method192()
    let v330 : (std_string_String -> US37) = method193()
    let v332 : US37 = match v328 with Ok x -> v329 x | Error x -> v330 x
    match v332 with
    | US37_1(v387) -> (* Error *)
        let v388 : unit = ()
        let v389 : (unit -> unit) = closure92(v387)
        let v390 : unit = (fun () -> v389 (); v388) ()
        1
    | US37_0(v335) -> (* Ok *)
        let v336 : unit = ()
        let v337 : (unit -> unit) = closure93(v335)
        let v338 : unit = (fun () -> v337 (); v336) ()
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
