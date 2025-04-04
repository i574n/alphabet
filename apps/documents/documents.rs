#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
#![allow(unused_assignments)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_b8cdef03 {
    pub mod Documents {
        use super::*;
        use fable_library_rust::Async_::Async;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::List_::List;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::getNull;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
        use fable_library_rust::Seq_::ofArray as ofArray_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::concat;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith3;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::indexOf;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::lastIndexOf;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::split;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::toString;
        use fable_library_rust::String_::trim;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Text::StringBuilder;
        use fable_library_rust::System::Threading::CancellationToken;
        type TaskCanceledException = ();
        pub mod TraceState {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Documents::Mut0>,
                        LrcPtr<Documents::Mut1>,
                        LrcPtr<Documents::Mut2>,
                        LrcPtr<Documents::Mut3>,
                        LrcPtr<Documents::Mut4>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Documents::Mut0>,
                                LrcPtr<Documents::Mut1>,
                                LrcPtr<Documents::Mut2>,
                                LrcPtr<Documents::Mut3>,
                                LrcPtr<Documents::Mut4>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Documents::Mut0>,
                                LrcPtr<Documents::Mut1>,
                                LrcPtr<Documents::Mut2>,
                                LrcPtr<Documents::Mut3>,
                                LrcPtr<Documents::Mut4>,
                                Option<i64>,
                            )>,
                        ))
                    })
                    .clone()
            }
        }
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        pub trait IFs: core::fmt::Debug + core::fmt::Display {
            fn realpathSync(&self, path: string) -> string;
        }
        impl<V: IFs + core::fmt::Debug + core::fmt::Display> IFs for LrcPtr<V> {
            #[inline]
            fn realpathSync(&self, path: string) -> string {
                (**self).realpathSync(path)
            }
        }
        pub trait IPathJoin: core::fmt::Debug + core::fmt::Display {
            fn join(&self, paths: Array<string>) -> string;
        }
        impl<V: IPathJoin + core::fmt::Debug + core::fmt::Display> IPathJoin for LrcPtr<V> {
            #[inline]
            fn join(&self, paths: Array<string>) -> string {
                (**self).join(paths)
            }
        }
        pub trait IFsExistsSync: core::fmt::Debug + core::fmt::Display {
            fn existsSync(&self, path: string) -> bool;
        }
        impl<V: IFsExistsSync + core::fmt::Debug + core::fmt::Display> IFsExistsSync for LrcPtr<V> {
            #[inline]
            fn existsSync(&self, path: string) -> bool {
                (**self).existsSync(path)
            }
        }
        pub trait IPathDirname: core::fmt::Debug + core::fmt::Display {
            fn dirname(&self, path: string) -> string;
        }
        impl<V: IPathDirname + core::fmt::Debug + core::fmt::Display> IPathDirname for LrcPtr<V> {
            #[inline]
            fn dirname(&self, path: string) -> string {
                (**self).dirname(path)
            }
        }
        pub trait IPathBasename: core::fmt::Debug + core::fmt::Display {
            fn basename(&self, path: string) -> string;
        }
        impl<V: IPathBasename + core::fmt::Debug + core::fmt::Display> IPathBasename for LrcPtr<V> {
            #[inline]
            fn basename(&self, path: string) -> string {
                (**self).basename(path)
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut4 {
            pub l0: MutCell<Documents::US0>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Documents::US0),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(Documents::US3),
            US4_1(Documents::US3),
            US4_2(Documents::US3),
            US4_3(Documents::US3),
            US4_4(Documents::US3),
            US4_5(Documents::US3),
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0(string),
            US5_1,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(std::string::String),
            US6_1,
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US7 {
            US7_0,
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(string),
            US8_1(string),
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(std::path::PathBuf),
            US9_1(string),
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(std::path::PathBuf),
            US10_1,
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(std::fs::FileType),
            US11_1(std::string::String),
        }
        impl core::fmt::Display for US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US12 {
            US12_0,
            US12_1,
            US12_2,
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(async_walkdir::DirEntry),
            US13_1(std::string::String),
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US14 {
            US14_0(string, Documents::US5),
            US14_1(string),
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US15_1(string),
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(char, LrcPtr<Documents::UH0>),
        }
        impl core::fmt::Display for UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US15>,
                LrcPtr<Documents::UH1>,
            ),
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US16_1(string),
        }
        impl core::fmt::Display for US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US17 {
            US17_0(char),
            US17_1,
        }
        impl core::fmt::Display for US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0(string, LrcPtr<StringBuilder>, i32, i32),
            US18_1(string),
        }
        impl core::fmt::Display for US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(
                string,
                Documents::US5,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US19_1(string),
        }
        impl core::fmt::Display for US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(Documents::US17, string, LrcPtr<StringBuilder>, i32, i32),
            US20_1(string),
        }
        impl core::fmt::Display for US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(Documents::US5, string, LrcPtr<StringBuilder>, i32, i32),
            US21_1(string),
        }
        impl core::fmt::Display for US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US22 {
            US22_0(Array<string>),
            US22_1(string),
        }
        impl core::fmt::Display for US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH2 {
            UH2_0,
            UH2_1(string, LrcPtr<Documents::UH2>),
        }
        impl core::fmt::Display for UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(
                LrcPtr<Documents::UH2>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US23_1(string),
        }
        impl core::fmt::Display for US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US16>,
                LrcPtr<Documents::UH3>,
            ),
        }
        impl core::fmt::Display for UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US24_1(std::string::String),
        }
        impl core::fmt::Display for US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US25_1,
        }
        impl core::fmt::Display for US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(std::string::String),
            US26_1(std::string::String),
        }
        impl core::fmt::Display for US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US27_1,
        }
        impl core::fmt::Display for US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US28_1,
        }
        impl core::fmt::Display for US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(std::process::Output),
            US29_1(std::string::String),
        }
        impl core::fmt::Display for US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US30 {
            US30_0(i32),
            US30_1,
        }
        impl core::fmt::Display for US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US31_1,
        }
        impl core::fmt::Display for US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US32 {
            US32_0(CancellationToken),
            US32_1,
        }
        impl core::fmt::Display for US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US33 {
            US33_0(Result<string, LrcPtr<(string, string)>>),
            US33_1,
        }
        impl core::fmt::Display for US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH5 {
            UH5_0,
            UH5_1(
                string,
                string,
                Func2<string, string, Documents::US33>,
                LrcPtr<Documents::UH5>,
            ),
        }
        impl core::fmt::Display for UH5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH4 {
            UH4_0,
            UH4_1(LrcPtr<Documents::UH5>, LrcPtr<Documents::UH4>),
        }
        impl core::fmt::Display for UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(string),
            US34_1(std::string::String),
        }
        impl core::fmt::Display for US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0(u64),
            US35_1(std::string::String),
        }
        impl core::fmt::Display for US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US36 {
            US36_0(i32, string),
            US36_1(i32, string),
        }
        impl core::fmt::Display for US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut7 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
        }
        impl core::fmt::Display for Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut8 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
            pub l2: MutCell<i32>,
            pub l3: MutCell<i32>,
        }
        impl core::fmt::Display for Mut8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0(
                Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >,
            ),
            US37_1(std::string::String),
        }
        impl core::fmt::Display for US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"source-dir\"#");
            let v7: &'static str = r#"source-dir"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.short('s');
            let v12: string = string("r#\"source-dir\"#");
            let v13: &'static str = r#"source-dir"#;
            let v15: clap::Arg = v11.long(v13);
            let v17: clap::Arg = v15.required(true);
            let v19: clap::Command = clap::Command::arg(v4, v17);
            let v21: string = string("r#\"dist-dir\"#");
            let v22: &'static str = r#"dist-dir"#;
            let v24: clap::Arg = clap::Arg::new(v22);
            let v26: clap::Arg = v24.short('d');
            let v27: string = string("r#\"dist-dir\"#");
            let v28: &'static str = r#"dist-dir"#;
            let v30: clap::Arg = v26.long(v28);
            let v32: clap::Arg = v30.required(true);
            let v34: clap::Command = clap::Command::arg(v19, v32);
            let v36: string = string("r#\"cache-dir\"#");
            let v37: &'static str = r#"cache-dir"#;
            let v39: clap::Arg = clap::Arg::new(v37);
            let v41: clap::Arg = v39.short('c');
            let v42: string = string("r#\"cache-dir\"#");
            let v43: &'static str = r#"cache-dir"#;
            let v45: clap::Arg = v41.long(v43);
            let v47: clap::Arg = v45.required(true);
            let v49: clap::Command = clap::Command::arg(v34, v47);
            let v51: string = string("r#\"hangul-spec\"#");
            let v52: &'static str = r#"hangul-spec"#;
            let v54: clap::Arg = clap::Arg::new(v52);
            let v56: clap::Arg = v54.short('h');
            let v57: string = string("r#\"hangul-spec\"#");
            let v58: &'static str = r#"hangul-spec"#;
            let v60: clap::Arg = v56.long(v58);
            let v62: clap::Arg = v60.required(true);
            clap::Command::arg(v49, v62)
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {
            let v1_1: bool = true;
            () //;
        } /* /*;
        {
        let v4: string = string("*/ #[test] fn verify_app() { //");
        let v5: bool = */
        #[test]
        fn verify_app() {
            //;
            let v6: clap::Command = Documents::method0();
            clap::Command::debug_assert(v6);
            {
                //;
                ()
            }
        }
        pub fn method4(v0_1: string) -> string {
            v0_1
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn method6() -> Func1<string, Documents::US5> {
            Func1::new(move |v: string| Documents::closure3((), v))
        }
        pub fn method3(v0_1: string) -> string {
            let v3: string = Documents::method4(v0_1);
            let v5: Result<std::string::String, std::env::VarError> = std::env::var(&*v3);
            let v7: bool = true;
            let _result_map_ = v5.map(|x| {
                //;
                let v9: std::string::String = x;
                let v11: string = fable_library_rust::String_::fromString(v9);
                let v13: bool = true;
                v11
            });
            let v15: Result<string, std::env::VarError> = _result_map_;
            let v16: string = Documents::method5();
            v15.unwrap_or(v16)
        }
        pub fn method2() -> (Documents::US1, Documents::US2) {
            let v1_1: string = Documents::method3(string("TRACE_LEVEL"));
            let v6: string = toLower(string("Critical"));
            let v13: string = toLower(string("Warning"));
            let v20: string = toLower(string("Info"));
            let v27: string = toLower(string("Debug"));
            let v34: string = toLower(string("Verbose"));
            let v41: Documents::US1 = if string("Verbose") == (v1_1.clone()) {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            (
                match &v41 {
                    Documents::US1::US1_0(v41_0_0) => Documents::US1::US1_0(
                        match &v41 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v48: Documents::US1 = if string("Debug") == (v1_1.clone()) {
                            Documents::US1::US1_0(Documents::US0::US0_1)
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v48 {
                            Documents::US1::US1_0(v48_0_0) => Documents::US1::US1_0(
                                match &v48 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v55: Documents::US1 = if string("Info") == (v1_1.clone()) {
                                    Documents::US1::US1_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US1::US1_1
                                };
                                match &v55 {
                                    Documents::US1::US1_0(v55_0_0) => Documents::US1::US1_0(
                                        match &v55 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v62: Documents::US1 =
                                            if string("Warning") == (v1_1.clone()) {
                                                Documents::US1::US1_0(Documents::US0::US0_3)
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v62 {
                                            Documents::US1::US1_0(v62_0_0) => {
                                                Documents::US1::US1_0(
                                                    match &v62 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v69: Documents::US1 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                match &v69 {
                                                    Documents::US1::US1_0(v69_0_0) => {
                                                        Documents::US1::US1_0(
                                                            match &v69 {
                                                                Documents::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v76: Documents::US1 =
                                                            if (v34.clone()) == (v1_1.clone()) {
                                                                Documents::US1::US1_0(
                                                                    Documents::US0::US0_0,
                                                                )
                                                            } else {
                                                                Documents::US1::US1_1
                                                            };
                                                        match &v76 {
                                                            Documents::US1::US1_0(v76_0_0) => {
                                                                Documents::US1::US1_0(
                                                                    match &v76 {
                                                                        Documents::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                )
                                                            }
                                                            _ => {
                                                                let v83: Documents::US1 = if (v27
                                                                    .clone())
                                                                    == (v1_1.clone())
                                                                {
                                                                    Documents::US1::US1_0(
                                                                        Documents::US0::US0_1,
                                                                    )
                                                                } else {
                                                                    Documents::US1::US1_1
                                                                };
                                                                match &v83 {
                                                                 Documents::US1::US1_0(v83_0_0)
                                                                 =>
                                                                 Documents::US1::US1_0(match &v83
                                                                                           {
                                                                                           Documents::US1::US1_0(x)
                                                                                           =>
                                                                                           x.clone(),
                                                                                           _
                                                                                           =>
                                                                                           unreachable!(),
                                                                                       }.clone()),
                                                                 _ => {
                                                                     let v90:
                                                                             Documents::US1 =
                                                                         if (v20.clone())
                                                                                ==
                                                                                (v1_1.clone())
                                                                            {
                                                                             Documents::US1::US1_0(Documents::US0::US0_2)
                                                                         } else {
                                                                             Documents::US1::US1_1
                                                                         };
                                                                     match &v90
                                                                         {
                                                                         Documents::US1::US1_0(v90_0_0)
                                                                         =>
                                                                         Documents::US1::US1_0(match &v90
                                                                                                   {
                                                                                                   Documents::US1::US1_0(x)
                                                                                                   =>
                                                                                                   x.clone(),
                                                                                                   _
                                                                                                   =>
                                                                                                   unreachable!(),
                                                                                               }.clone()),
                                                                         _ =>
                                                                         {
                                                                             let v97:
                                                                                     Documents::US1 =
                                                                                 if (v13.clone())
                                                                                        ==
                                                                                        (v1_1.clone())
                                                                                    {
                                                                                     Documents::US1::US1_0(Documents::US0::US0_3)
                                                                                 } else {
                                                                                     Documents::US1::US1_1
                                                                                 };
                                                                             match &v97
                                                                                 {
                                                                                 Documents::US1::US1_0(v97_0_0)
                                                                                 =>
                                                                                 Documents::US1::US1_0(match &v97
                                                                                                           {
                                                                                                           Documents::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       }.clone()),
                                                                                 _
                                                                                 =>
                                                                                 {
                                                                                     let v104:
                                                                                             Documents::US1 =
                                                                                         if (v6.clone())
                                                                                                ==
                                                                                                (v1_1.clone())
                                                                                            {
                                                                                             Documents::US1::US1_0(Documents::US0::US0_4)
                                                                                         } else {
                                                                                             Documents::US1::US1_1
                                                                                         };
                                                                                     match &v104
                                                                                         {
                                                                                         Documents::US1::US1_0(v104_0_0)
                                                                                         =>
                                                                                         Documents::US1::US1_0(match &v104
                                                                                                                   {
                                                                                                                   Documents::US1::US1_0(x)
                                                                                                                   =>
                                                                                                                   x.clone(),
                                                                                                                   _
                                                                                                                   =>
                                                                                                                   unreachable!(),
                                                                                                               }.clone()),
                                                                                         _
                                                                                         =>
                                                                                         Documents::US1::US1_1,
                                                                                     }
                                                                                 }
                                                                             }
                                                                         }
                                                                     }
                                                                 }
                                                             }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if (Documents::method3(string("AUTOMATION"))) != string("True") {
                    Documents::US2::US2_1
                } else {
                    Documents::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                },
            )
        }
        pub fn closure4(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(
            v0_1: Documents::US0,
        ) -> (
            LrcPtr<Documents::Mut0>,
            LrcPtr<Documents::Mut1>,
            LrcPtr<Documents::Mut2>,
            LrcPtr<Documents::Mut3>,
            LrcPtr<Documents::Mut4>,
            Option<i64>,
        ) {
            let patternInput: (Documents::US1, Documents::US2) = Documents::method2();
            let _run_target_args__v3: (Documents::US1, Documents::US2) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v173: Documents::US2 = _run_target_args__v3.1.clone();
            let v172: Documents::US1 = _run_target_args__v3.0.clone();
            (
                LrcPtr::new(Documents::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Documents::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Documents::closure4((), v))),
                }),
                LrcPtr::new(Documents::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(match &v172 {
                        Documents::US1::US1_0(v172_0_0) => match &v172 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v173 {
                    Documents::US2::US2_0(v173_0_0) => Some(match &v173 {
                        Documents::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) {
            if Documents::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_2);
                Documents::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) {
            if Documents::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_0);
                Documents::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn method7(v0_1: Documents::US0) -> bool {
            let v17: () = {
                Documents::closure6((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v56: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                (find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                        LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                        LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                        LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                        LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                    ])))),
                )) >= (find(
                    v56,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                        LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                        LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                        LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                        LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                    ])))),
                ))
            }
        }
        pub fn closure7(unitVar: (), v0_1: i64) -> Documents::US2 {
            Documents::US2::US2_0(v0_1)
        }
        pub fn method9() -> Func1<i64, Documents::US2> {
            Func1::new(move |v: i64| Documents::closure7((), v))
        }
        pub fn method10() -> string {
            string("hh:mm:ss")
        }
        pub fn method11() -> string {
            string("HH:mm:ss")
        }
        pub fn method8(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v212: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method9(), v5));
            let v344: DateTime = match &v212 {
                Documents::US2::US2_0(v212_0_0) => {
                    let v292: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v212 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v292.hours(),
                        v292.minutes(),
                        v292.seconds(),
                        v292.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v346: string = Documents::method10();
            let provider: string = if (v346.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v346
            };
            v344.toString(provider)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v4: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method12() -> string {
            let v7: char = getCharAt(toLower(string("Info")), 0_i32);
            let v9: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v9.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v30: string = v9.l0.get().clone();
            let v49: &str = inline_colorization::color_bright_green;
            let v56: &str = &*v30;
            let v84: &str = inline_colorization::color_reset;
            let v86: std::string::String = format!("{}{}{}", v49, v56, v84);
            fable_library_rust::String_::fromString(v86)
        }
        pub fn method16(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method15(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Array<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("args"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v8), ());
                ()
            };
            let v102: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v108: string = v10.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v108),
            ))
        }
        pub fn closure9(v0_1: LrcPtr<Documents::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure11(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure10(unitVar: (), v0_1: string) {
            let v4: () = {
                Documents::closure11(v0_1, ());
                ()
            };
            ()
        }
        pub fn method17(v0_1: string) {
            let v17: () = {
                Documents::closure6((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v60: () = {
                Documents::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v19: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method15(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Documents::method8(v40, v41, v42, v43, v44, v45),
                    Documents::method12(),
                    v0_1,
                ))
            };
        }
        pub fn method18() -> string {
            string("source-dir")
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn method19() -> Func1<std::string::String, Documents::US6> {
            Func1::new(move |v: std::string::String| Documents::closure12((), v))
        }
        pub fn method20() -> string {
            string("dist-dir")
        }
        pub fn method21() -> string {
            string("cache-dir")
        }
        pub fn method22() -> string {
            string("hangul-spec")
        }
        pub fn method24() -> string {
            let v6: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v10: std::path::PathBuf = v6.unwrap();
            let v28: std::path::Display = v10.display();
            let v61: std::string::String = format!("{}", v28);
            fable_library_rust::String_::fromString(v61)
        }
        pub fn method26(v0_1: string, v1_1: string) -> string {
            let v13: &str = &*v0_1;
            let v46: std::string::String = String::from(v13);
            let v79: std::path::PathBuf = std::path::PathBuf::from(v46);
            let v112: &str = &*v1_1;
            let v145: std::string::String = String::from(v112);
            let v173: std::path::PathBuf = v79.join(v145);
            let v180: std::path::Display = v173.display();
            let v213: std::string::String = format!("{}", v180);
            fable_library_rust::String_::fromString(v213)
        }
        pub fn method28(v0_1: string) -> bool {
            let v12: &str = &*v0_1;
            let v45: std::string::String = String::from(v12);
            let v99: std::path::PathBuf = std::path::PathBuf::from(v45);
            if v99.clone().exists() {
                v99.is_file()
            } else {
                false
            }
        }
        pub fn closure13(unitVar: (), v0_1: string) -> bool {
            Documents::method28(v0_1)
        }
        pub fn method29(v0_1: string) -> bool {
            let v12: &str = &*v0_1;
            let v45: std::string::String = String::from(v12);
            let v99: std::path::PathBuf = std::path::PathBuf::from(v45);
            if v99.clone().exists() {
                v99.is_dir()
            } else {
                false
            }
        }
        pub fn closure14(unitVar: (), v0_1: string) -> bool {
            Documents::method29(v0_1)
        }
        pub fn method31(v0_1: string) -> Option<string> {
            let v12: &str = &*v0_1;
            let v45: std::string::String = String::from(v12);
            let v78: std::path::PathBuf = std::path::PathBuf::from(v45);
            let v106: Option<std::path::PathBuf> = v78.parent().map(std::path::PathBuf::from);
            let v108: bool = true;
            let _optionm_map_ = v106.map(|x| {
                //;
                let v110: std::path::PathBuf = x;
                let v117: std::path::Display = v110.display();
                let v150: std::string::String = format!("{}", v117);
                let v178: string = fable_library_rust::String_::fromString(v150);
                let v180: bool = true;
                v178
            });
            _optionm_map_
        }
        pub fn method32(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
            v4: string,
        ) -> Documents::US8 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<bool> = MutCell::new(v2);
            let v3 = MutCell::new(v3.clone());
            let v4: MutCell<string> = MutCell::new(v4.clone());
            '_method32: loop {
                break '_method32 (if v3(Documents::method26(v4.get().clone(), v0_1.get().clone())) {
                    Documents::US8::US8_0(v4.get().clone())
                } else {
                    let v8: Option<string> = Documents::method31(v4.get().clone());
                    let v33: Documents::US5 =
                        defaultValue(Documents::US5::US5_1, map(Documents::method6(), v8));
                    match &v33 {
                        Documents::US5::US5_0(v33_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: bool = v2.get().clone();
                            let v3_temp = v3.get().clone();
                            let v4_temp: string = match &v33 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method32;
                        }
                        _ => Documents::US8::US8_1(append(
                            (concat(new_array(&[
                                string("file_system.find_parent / No parent for "),
                                if v2.get().clone() {
                                    string("file")
                                } else {
                                    string("dir")
                                },
                            ]))),
                            sprintf!(
                                " \'{}\' at \'{}\' (until \'{}\')",
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v4.get().clone()
                            ),
                        )),
                    }
                });
            }
        }
        pub fn method30(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
        ) -> Documents::US8 {
            if v3(Documents::method26(v1_1.clone(), v0_1.clone())) {
                Documents::US8::US8_0(v1_1.clone())
            } else {
                let v7: Option<string> = Documents::method31(v1_1.clone());
                let v32: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method6(), v7));
                match &v32 {
                    Documents::US5::US5_0(v32_0_0) => Documents::method32(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2,
                        v3.clone(),
                        match &v32 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => Documents::US8::US8_1(append(
                        (concat(new_array(&[
                            string("file_system.find_parent / No parent for "),
                            if v2 { string("file") } else { string("dir") },
                        ]))),
                        sprintf!(
                            " \'{}\' at \'{}\' (until \'{}\')",
                            v0_1.clone(),
                            v1_1.clone(),
                            v1_1.clone()
                        ),
                    )),
                }
            }
        }
        pub fn method27(v0_1: Documents::US7, v1_1: string, v2: string) -> Documents::US8 {
            let v3: bool = if let Documents::US7::US7_0 = &v0_1 {
                true
            } else {
                false
            };
            Documents::method30(
                v1_1,
                v2,
                v3,
                if v3 {
                    Func1::new(move |v: string| Documents::closure13((), v))
                } else {
                    Func1::new(move |v_1: string| Documents::closure14((), v_1))
                },
            )
        }
        pub fn method33() -> string {
            let v7: char = getCharAt(toLower(string("Warning")), 0_i32);
            let v9: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v9.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v30: string = v9.l0.get().clone();
            let v49: &str = inline_colorization::color_yellow;
            let v56: &str = &*v30;
            let v84: &str = inline_colorization::color_reset;
            let v86: std::string::String = format!("{}{}{}", v49, v56, v84);
            fable_library_rust::String_::fromString(v86)
        }
        pub fn method34(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("dir"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v80: () = {
                Documents::closure8(v11.clone(), v8, ());
                ()
            };
            let v99: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v118: () = {
                Documents::closure8(v11.clone(), string("error"), ());
                ()
            };
            let v135: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v152: () = {
                Documents::closure8(v11.clone(), v9, ());
                ()
            };
            let v171: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v177: string = v11.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.get_workspace_root"),
                    )),
                    string(" / "),
                )),
                (v177),
            ))
        }
        pub fn closure15(v0_1: string, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v20: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v46: Option<i64> = patternInput.5.clone();
                let v45: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v44: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v43: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v42: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v41: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method34(
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    Documents::method8(v41, v42, v43, v44, v45, v46),
                    Documents::method33(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn closure16(unitVar: (), v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: std::string::String = format!("{:#?}", v0_1);
            let v53: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v9), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method38() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Documents::closure16((), v))
        }
        pub fn closure17(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn method39() -> Func1<std::path::PathBuf, Documents::US9> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure17((), v))
        }
        pub fn closure18(unitVar: (), v0_1: string) -> Documents::US9 {
            Documents::US9::US9_1(v0_1)
        }
        pub fn method40() -> Func1<string, Documents::US9> {
            Func1::new(move |v: string| Documents::closure18((), v))
        }
        pub fn method43(v0_1: string) -> string {
            let v12: &str = &*v0_1;
            let v45: std::string::String = String::from(v12);
            let v78: std::path::PathBuf = std::path::PathBuf::from(v45);
            let v106: Option<&std::ffi::OsStr> = v78.file_name();
            let v108: bool = true;
            let _optionm_map_ = v106.map(|x| {
                //;
                let v110: &std::ffi::OsStr = x;
                let v112: std::ffi::OsString = v110.to_os_string();
                let v114: Option<&str> = v112.to_str();
                let v116: &str = v114.unwrap();
                let v123: std::string::String = String::from(v116);
                let v151: string = fable_library_rust::String_::fromString(v123);
                let v153: bool = true;
                v151
            });
            let v155: Option<string> = _optionm_map_;
            let v180: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v155));
            match &v180 {
                Documents::US5::US5_0(v180_0_0) => match &v180 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method42(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method43(v4.clone());
            let v6: Option<string> = Documents::method31(v4.clone());
            let v31: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v36: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v48: () = {
                Documents::closure8(v36.clone(), v3, ());
                ()
            };
            let v54: string = v36.l0.get().clone();
            if (v2) >= 11_u8 {
                let v58: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v65: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v58);
                Err(v65)
            } else {
                if let Documents::US5::US5_0(v31_0_0) = &v31 {
                    if (v4.clone()) != string("") {
                        let v116: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v31_0_0.clone());
                        let v117 = Documents::method38();
                        let v130: Result<std::path::PathBuf, string> = v116.map_err(|x| v117(x));
                        let v133 = Documents::method39();
                        let v134 = Documents::method40();
                        let v136: Documents::US9 = match &v130 {
                            Err(v130_1_0) => v134(v130_1_0.clone()),
                            Ok(v130_0_0) => v133(v130_0_0.clone()),
                        };
                        match &v136 {
                            Documents::US9::US9_0(v136_0_0) => {
                                let v177: string = Documents::method26(
                                    toString(v136_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v184: &str = &*v177;
                                let v217: std::string::String = String::from(v184);
                                let v250: std::path::PathBuf = std::path::PathBuf::from(v217);
                                Ok(v250)
                            }
                            Documents::US9::US9_1(v136_1_0) => {
                                let v295: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v136_1_0.clone(),
                                        v54.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v302: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v295);
                                Err(v302)
                            }
                        }
                    } else {
                        let v348: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v54.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v355: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v348);
                        Err(v355)
                    }
                } else {
                    let v400: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v54.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v407: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v400);
                    Err(v407)
                }
            }
        }
        pub fn method41(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v9: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v10 = Documents::method38();
            let v23: Result<std::path::PathBuf, string> = v9.map_err(|x| v10(x));
            let v26 = Documents::method39();
            let v27 = Documents::method40();
            let v29: Documents::US9 = match &v23 {
                Err(v23_1_0) => v27(v23_1_0.clone()),
                Ok(v23_0_0) => v26(v23_0_0.clone()),
            };
            match &v29 {
                Documents::US9::US9_0(v29_0_0) => Ok(v29_0_0.clone()),
                Documents::US9::US9_1(v29_1_0) => Documents::method42(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure19(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v29_1_0.clone(),
                    v2.clone(),
                ),
            }
        }
        pub fn closure20(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method41(v0_1, v1_1, v2)
        }
        pub fn closure19(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure20(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method44(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method43(v0_1.clone());
            let v5: Option<string> = Documents::method31(v0_1.clone());
            let v30: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v35: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v47: () = {
                Documents::closure8(v35.clone(), v3, ());
                ()
            };
            let v53: string = v35.l0.get().clone();
            if (v2) >= 11_u8 {
                let v57: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v64: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v57);
                Err(v64)
            } else {
                if let Documents::US5::US5_0(v30_0_0) = &v30 {
                    if (v0_1.clone()) != string("") {
                        let v115: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v30_0_0.clone());
                        let v116 = Documents::method38();
                        let v129: Result<std::path::PathBuf, string> = v115.map_err(|x| v116(x));
                        let v132 = Documents::method39();
                        let v133 = Documents::method40();
                        let v135: Documents::US9 = match &v129 {
                            Err(v129_1_0) => v133(v129_1_0.clone()),
                            Ok(v129_0_0) => v132(v129_0_0.clone()),
                        };
                        match &v135 {
                            Documents::US9::US9_0(v135_0_0) => {
                                let v176: string = Documents::method26(
                                    toString(v135_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v183: &str = &*v176;
                                let v216: std::string::String = String::from(v183);
                                let v249: std::path::PathBuf = std::path::PathBuf::from(v216);
                                Ok(v249)
                            }
                            Documents::US9::US9_1(v135_1_0) => {
                                let v294: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v135_1_0.clone(),
                                        v53.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v301: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v294);
                                Err(v301)
                            }
                        }
                    } else {
                        let v347: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v53.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v354: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v347);
                        Err(v354)
                    }
                } else {
                    let v399: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v53.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v406: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v399);
                    Err(v406)
                }
            }
        }
        pub fn method37(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v8: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v9 = Documents::method38();
            let v22: Result<std::path::PathBuf, string> = v8.map_err(|x| v9(x));
            let v25 = Documents::method39();
            let v26 = Documents::method40();
            let v28: Documents::US9 = match &v22 {
                Err(v22_1_0) => v26(v22_1_0.clone()),
                Ok(v22_0_0) => v25(v22_0_0.clone()),
            };
            match &v28 {
                Documents::US9::US9_0(v28_0_0) => Ok(v28_0_0.clone()),
                Documents::US9::US9_1(v28_1_0) => Documents::method44(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure19(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v28_1_0.clone(),
                ),
            }
        }
        pub fn method46(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method47() -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method48(v0_1: i32, v1_1: i32) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method50(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method43(v4.clone());
            let v6: Option<string> = Documents::method31(v4.clone());
            let v31: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v36: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v43: std::string::String = format!("{:#?}", v3);
            let v87: () = {
                Documents::closure8(
                    v36.clone(),
                    fable_library_rust::String_::fromString(v43),
                    (),
                );
                ()
            };
            let v93: string = v36.l0.get().clone();
            if (v2) >= 11_u8 {
                let v97: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v104: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v97);
                Err(v104)
            } else {
                if let Documents::US5::US5_0(v31_0_0) = &v31 {
                    if (v4.clone()) != string("") {
                        let v155: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v31_0_0.clone());
                        let v156 = Documents::method38();
                        let v169: Result<std::path::PathBuf, string> = v155.map_err(|x| v156(x));
                        let v172 = Documents::method39();
                        let v173 = Documents::method40();
                        let v175: Documents::US9 = match &v169 {
                            Err(v169_1_0) => v173(v169_1_0.clone()),
                            Ok(v169_0_0) => v172(v169_0_0.clone()),
                        };
                        match &v175 {
                            Documents::US9::US9_0(v175_0_0) => {
                                let v216: string = Documents::method26(
                                    toString(v175_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v223: &str = &*v216;
                                let v256: std::string::String = String::from(v223);
                                let v289: std::path::PathBuf = std::path::PathBuf::from(v256);
                                Ok(v289)
                            }
                            Documents::US9::US9_1(v175_1_0) => {
                                let v334: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v175_1_0.clone(),
                                        v93.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v341: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v334);
                                Err(v341)
                            }
                        }
                    } else {
                        let v387: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v93.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v394: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v387);
                        Err(v394)
                    }
                } else {
                    let v439: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v93.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v446: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v439);
                    Err(v446)
                }
            }
        }
        pub fn method49(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v42: i32 =
                Documents::method46(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v44: bool = Documents::method48(Documents::method47(), v42);
            if v44 {
                let v51: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v122: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v122)
            } else {
                let v144: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v44,
                        v2.clone(),
                        v1_1
                    ),
                );
                Documents::method50(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure21(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v144),
                    v2,
                )
            }
        }
        pub fn closure22(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method49(v0_1, v1_1, v2)
        }
        pub fn closure21(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure22(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method51(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method43(v0_1.clone());
            let v5: Option<string> = Documents::method31(v0_1.clone());
            let v30: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v35: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v42: std::string::String = format!("{:#?}", v3);
            let v86: () = {
                Documents::closure8(
                    v35.clone(),
                    fable_library_rust::String_::fromString(v42),
                    (),
                );
                ()
            };
            let v92: string = v35.l0.get().clone();
            if (v2) >= 11_u8 {
                let v96: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v103: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v96);
                Err(v103)
            } else {
                if let Documents::US5::US5_0(v30_0_0) = &v30 {
                    if (v0_1.clone()) != string("") {
                        let v154: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v30_0_0.clone());
                        let v155 = Documents::method38();
                        let v168: Result<std::path::PathBuf, string> = v154.map_err(|x| v155(x));
                        let v171 = Documents::method39();
                        let v172 = Documents::method40();
                        let v174: Documents::US9 = match &v168 {
                            Err(v168_1_0) => v172(v168_1_0.clone()),
                            Ok(v168_0_0) => v171(v168_0_0.clone()),
                        };
                        match &v174 {
                            Documents::US9::US9_0(v174_0_0) => {
                                let v215: string = Documents::method26(
                                    toString(v174_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v222: &str = &*v215;
                                let v255: std::string::String = String::from(v222);
                                let v288: std::path::PathBuf = std::path::PathBuf::from(v255);
                                Ok(v288)
                            }
                            Documents::US9::US9_1(v174_1_0) => {
                                let v333: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v174_1_0.clone(),
                                        v92.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v340: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v333);
                                Err(v340)
                            }
                        }
                    } else {
                        let v386: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v92.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v393: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v386);
                        Err(v393)
                    }
                } else {
                    let v438: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v92.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v445: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v438);
                    Err(v445)
                }
            }
        }
        pub fn method45(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v41: i32 =
                Documents::method46(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v43: bool = Documents::method48(Documents::method47(), v41);
            if v43 {
                let v50: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v121: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v121)
            } else {
                let v143: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v43,
                        v0_1.clone(),
                        v1_1
                    ),
                );
                Documents::method51(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure21(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v143),
                )
            }
        }
        pub fn method36(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Documents::method29(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Documents::method37(v0_1, 0_u8)
            }
        }
        pub fn closure23(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn method52() -> Func1<std::path::PathBuf, Documents::US10> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure23((), v))
        }
        pub fn method54(v0_1: string) -> string {
            v0_1
        }
        pub fn method55() -> string {
            string("")
        }
        pub fn method53(v0_1: string, v1_1: string, v2: string) -> string {
            let v6: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v10: regex::Regex = v6.unwrap();
            let v22: string = Documents::method54(v2);
            let v24: std::borrow::Cow<str> = v10.replace_all(&*v22, &*v1_1);
            let v26: std::string::String = String::from(v24);
            fable_library_rust::String_::fromString(v26)
        }
        pub fn method35(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method36(v0_1.clone());
                let v7: Option<std::path::PathBuf> = v3.ok();
                let v43: Documents::US10 =
                    defaultValue(Documents::US10::US10_1, map(Documents::method52(), v7));
                let v86: string = match &v43 {
                    Documents::US10::US10_0(v43_0_0) => toString(
                        match &v43 {
                            Documents::US10::US10_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone()
                        .display(),
                    ),
                    _ => v0_1.clone(),
                };
                let v91: string = Documents::method53(
                    string("^\\\\\\\\\\?\\\\"),
                    string(""),
                    if (v86.clone()) == string("") {
                        v0_1.clone()
                    } else {
                        v86
                    },
                );
                if (length(v91.clone())) < 2_i32 {
                    v0_1.clone()
                } else {
                    replace(
                        concat(new_array(&[
                            toLower(ofChar(getCharAt(v91.clone(), 0_i32))),
                            getSlice(v91, Some(1_i32), None::<i32>),
                        ])),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method25(v0_1: string) -> Documents::US5 {
            let v5: Documents::US8 = Documents::method27(
                Documents::US7::US7_1,
                Documents::method26(string("spiral"), string("workspace")),
                v0_1.clone(),
            );
            match &v5 {
                Documents::US8::US8_0(v5_0_0) => {
                    Documents::US5::US5_0(Documents::method35(v5_0_0.clone()))
                }
                Documents::US8::US8_1(v5_1_0) => {
                    let v72: () = {
                        Documents::closure15(v0_1.clone(), v5_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            }
        }
        pub fn method57(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method58(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method59() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method60(v0_1: string) -> string {
            v0_1
        }
        pub fn method56(v0_1: string) -> string {
            let v12: &str = &*v0_1.clone();
            let v45: std::string::String = String::from(v12);
            let v78: std::path::PathBuf = std::path::PathBuf::from(v45);
            if (v78.exists()) == false {
                let v108: string = Documents::method24();
                let v119: Array<string> = split(
                    Documents::method35(Documents::method26(v108.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v123: i32 = get_Count(v119.clone());
                let v124: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method57(v123, v124.clone()) {
                    let v126: i32 = v124.l0.get().clone();
                    let v129: i32 = ((v126.wrapping_neg()) + (v123)) - 1_i32;
                    let matchValue: i32 = v124.l1.get().clone();
                    let v131: Array<string> = v124.l2.get().clone();
                    let v130: i32 = matchValue;
                    let v132: string = v119[v129].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == (v132.clone()) {
                        ((v130) + 1_i32, v131.clone())
                    } else {
                        if string(".") == (v132.clone()) {
                            (v130, v131.clone())
                        } else {
                            if 0_i32 == (v130) {
                                if endsWith3(v132.clone(), string(":"), false) {
                                    let v144: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v108.clone(), 0_i32)
                                    )]);
                                    let v145: i32 = get_Count(v144.clone());
                                    let v147: i32 = (v145) + (get_Count(v131.clone()));
                                    let v148: Array<string> = new_init(&string(""), v147);
                                    let v149: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method58(v147, v149.clone()) {
                                        let v151: i32 = v149.l0.get().clone();
                                        let v156: string = if (v151) < (v145) {
                                            v144[v151].clone()
                                        } else {
                                            let v154: i32 = (v151) - (v145);
                                            v131[v154].clone()
                                        };
                                        v148.get_mut()[v151 as usize] = v156;
                                        {
                                            let v157: i32 = (v151) + 1_i32;
                                            v149.l0.set(v157);
                                            ()
                                        }
                                    }
                                    (0_i32, v148.clone())
                                } else {
                                    let v158: Array<string> = new_array(&[v132]);
                                    let v159: i32 = get_Count(v158.clone());
                                    let v161: i32 = (v159) + (get_Count(v131.clone()));
                                    let v162: Array<string> = new_init(&string(""), v161);
                                    let v163: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method58(v161, v163.clone()) {
                                        let v165: i32 = v163.l0.get().clone();
                                        let v170: string = if (v165) < (v159) {
                                            v158[v165].clone()
                                        } else {
                                            let v168: i32 = (v165) - (v159);
                                            v131[v168].clone()
                                        };
                                        v162.get_mut()[v165 as usize] = v170;
                                        {
                                            let v171: i32 = (v165) + 1_i32;
                                            v163.l0.set(v171);
                                            ()
                                        }
                                    }
                                    (0_i32, v162.clone())
                                }
                            } else {
                                ((v130) - 1_i32, v131.clone())
                            }
                        }
                    };
                    let v181: i32 = (v126) + 1_i32;
                    v124.l0.set(v181);
                    v124.l1.set(patternInput_1.0.clone());
                    v124.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v124.l1.get().clone();
                    let v183: Array<string> = v124.l2.get().clone();
                    let _let__v188: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v183 = v183.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v183 = v183.clone();
                                    move |i: i32| v183[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, (get_Count(v183.clone())) - 1_i32),
                            )
                        }
                    }));
                    let v200: string = ofChar(Documents::method59());
                    join(
                        if (v200.clone()) == string("\n") {
                            Documents::method60(v200.clone())
                        } else {
                            v200
                        },
                        toArray_1(_let__v188),
                    )
                }
            } else {
                let v213: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v217: std::path::PathBuf = v213.unwrap();
                let v235: std::path::Display = v217.display();
                let v268: std::string::String = format!("{}", v235);
                fable_library_rust::String_::fromString(v268)
            }
        }
        pub fn method61() -> string {
            let v7: char = getCharAt(toLower(string("Debug")), 0_i32);
            let v9: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v9.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v30: string = v9.l0.get().clone();
            let v49: &str = inline_colorization::color_bright_blue;
            let v56: &str = &*v30;
            let v84: &str = inline_colorization::color_reset;
            let v86: std::string::String = format!("{}{}{}", v49, v56, v84);
            fable_library_rust::String_::fromString(v86)
        }
        pub fn method62(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v13: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v27: () = {
                Documents::closure8(v13.clone(), string("{ "), ());
                ()
            };
            let v46: () = {
                Documents::closure8(v13.clone(), string("source_dir"), ());
                ()
            };
            let v65: () = {
                Documents::closure8(v13.clone(), string(" = "), ());
                ()
            };
            let v82: () = {
                Documents::closure8(v13.clone(), v8, ());
                ()
            };
            let v101: () = {
                Documents::closure8(v13.clone(), string("; "), ());
                ()
            };
            let v120: () = {
                Documents::closure8(v13.clone(), string("dist_dir"), ());
                ()
            };
            let v137: () = {
                Documents::closure8(v13.clone(), string(" = "), ());
                ()
            };
            let v154: () = {
                Documents::closure8(v13.clone(), v9, ());
                ()
            };
            let v171: () = {
                Documents::closure8(v13.clone(), string("; "), ());
                ()
            };
            let v190: () = {
                Documents::closure8(v13.clone(), string("cache_dir"), ());
                ()
            };
            let v207: () = {
                Documents::closure8(v13.clone(), string(" = "), ());
                ()
            };
            let v224: () = {
                Documents::closure8(v13.clone(), v10, ());
                ()
            };
            let v241: () = {
                Documents::closure8(v13.clone(), string("; "), ());
                ()
            };
            let v260: () = {
                Documents::closure8(v13.clone(), string("hangul_spec"), ());
                ()
            };
            let v277: () = {
                Documents::closure8(v13.clone(), string(" = "), ());
                ()
            };
            let v294: () = {
                Documents::closure8(v13.clone(), v11, ());
                ()
            };
            let v313: () = {
                Documents::closure8(v13.clone(), string(" }"), ());
                ()
            };
            let v319: string = v13.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run"),
                    )),
                    string(" / "),
                )),
                (v319),
            ))
        }
        pub fn closure24(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v22: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v48: Option<i64> = patternInput.5.clone();
                let v47: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v46: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v45: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v44: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v43: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method62(
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    v48.clone(),
                    Documents::method8(v43, v44, v45, v46, v47, v48),
                    Documents::method61(),
                    v1_1,
                    v2,
                    v3,
                    v0_1,
                ))
            };
        }
        pub fn closure26(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method63() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure26((), v))
        }
        pub fn closure27(unitVar: (), v0_1: std::fs::FileType) -> Documents::US11 {
            Documents::US11::US11_0(v0_1)
        }
        pub fn method64() -> Func1<std::fs::FileType, Documents::US11> {
            Func1::new(move |v: std::fs::FileType| Documents::closure27((), v))
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Documents::US11 {
            Documents::US11::US11_1(v0_1)
        }
        pub fn method65() -> Func1<std::string::String, Documents::US11> {
            Func1::new(move |v: std::string::String| Documents::closure28((), v))
        }
        pub fn closure25(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(
                /*;
                let v4: bool = */
                async {
                    /*;
                    let v6: bool = */
                    ();
                    let v8: bool = true;
                    let __future_init = Box::pin(
                        /*;
                        let v10: bool = */
                        async move {
                            /*;
                            let v12: bool = */
                            ();
                            let v14: async_walkdir::DirEntry = v0_1.clone();
                            let v16: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                            Output = Result<std::fs::FileType, std::io::Error>,
                                        > + Send,
                                >,
                            > = Box::pin(async_walkdir::DirEntry::file_type(&v14));
                            let v18: Result<std::fs::FileType, std::io::Error> = v16.await;
                            let v19 = Documents::method63();
                            let v32: Result<std::fs::FileType, std::string::String> =
                                v18.map_err(|x| v19(x));
                            let v35 = Documents::method64();
                            let v36 = Documents::method65();
                            let v38: Documents::US11 = match &v32 {
                                Err(v32_1_0) => v36(v32_1_0.clone()),
                                Ok(v32_0_0) => v35(v32_0_0.clone()),
                            };
                            let v220: Documents::US12 = if let Documents::US11::US11_0(v38_0_0) =
                                &v38
                            {
                                if std::fs::FileType::is_dir(&v38_0_0.clone()) {
                                    Documents::US12::US12_0
                                } else {
                                    let v46: std::path::PathBuf =
                                        async_walkdir::DirEntry::path(&v0_1.clone());
                                    let v53: std::path::Display = v46.display();
                                    let v86: std::string::String = format!("{}", v53);
                                    let v114: string = fable_library_rust::String_::fromString(v86);
                                    if if (endsWith3(v114.clone(), string(".md"), false)) == false {
                                        true
                                    } else {
                                        endsWith3(v114, string(".hangul.md"), false)
                                    } {
                                        Documents::US12::US12_0
                                    } else {
                                        Documents::US12::US12_2
                                    }
                                }
                            } else {
                                let v134: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                                let v141: std::path::Display = v134.display();
                                let v174: std::string::String = format!("{}", v141);
                                let v202: string = fable_library_rust::String_::fromString(v174);
                                if if (endsWith3(v202.clone(), string(".md"), false)) == false {
                                    true
                                } else {
                                    endsWith3(v202, string(".hangul.md"), false)
                                } {
                                    Documents::US12::US12_0
                                } else {
                                    Documents::US12::US12_2
                                }
                            };
                            let v223: string = string("}");
                            let v228: bool = true;
                            let _fix_closure_v225 = v220;
                            let v235: string = append(
                                (append(
                                    (append(
                                        (append(string("true; _fix_closure_v225 "), (v223))),
                                        string("); "),
                                    )),
                                    string(""),
                                )),
                                string(" // rust.fix_closure\'"),
                            );
                            let v236: bool = true;
                            _fix_closure_v225
                        },
                    ); // rust.fix_closure';
                    let v238 = __future_init;
                    let v240: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US12> + Send>,
                    > = v238;
                    let v242: Documents::US12 = v240.await;
                    let v251: async_walkdir::Filtering = match &v242 {
                        Documents::US12::US12_0 => async_walkdir::Filtering::Ignore,
                        Documents::US12::US12_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    };
                    let v252: string = string("}");
                    let v257: bool = true;
                    let _fix_closure_v254 = v251;
                    let v264: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v254 "), (v252))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v265: bool = true;
                    _fix_closure_v254
                },
            ); // rust.fix_closure';
            let v267 = __future_init;
            v267
        }
        pub fn closure30(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method67() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure30((), v))
        }
        pub fn closure31(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US13 {
            Documents::US13::US13_0(v0_1)
        }
        pub fn method68() -> Func1<async_walkdir::DirEntry, Documents::US13> {
            Func1::new(move |v: async_walkdir::DirEntry| Documents::closure31((), v))
        }
        pub fn closure32(unitVar: (), v0_1: std::string::String) -> Documents::US13 {
            Documents::US13::US13_1(v0_1)
        }
        pub fn method69() -> Func1<std::string::String, Documents::US13> {
            Func1::new(move |v: std::string::String| Documents::closure32((), v))
        }
        pub fn method70() -> string {
            let v7: char = getCharAt(toLower(string("Critical")), 0_i32);
            let v9: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v9.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v30: string = v9.l0.get().clone();
            let v49: &str = inline_colorization::color_bright_red;
            let v56: &str = &*v30;
            let v84: &str = inline_colorization::color_reset;
            let v86: std::string::String = format!("{}{}{}", v49, v56, v84);
            fable_library_rust::String_::fromString(v86)
        }
        pub fn method71(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("error"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v74: std::string::String = format!("{:#?}", v8);
            let v118: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v74),
                    (),
                );
                ()
            };
            let v137: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v143: string = v10.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run / stream_filter_map"),
                    )),
                    string(" / "),
                )),
                (v143),
            ))
        }
        pub fn closure33(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v19: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method71(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Documents::method8(v40, v41, v42, v43, v44, v45),
                    Documents::method70(),
                    v0_1,
                ))
            };
        }
        pub fn closure29(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method67();
            let v14: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v17 = Documents::method68();
            let v18 = Documents::method69();
            let v20: Documents::US13 = match &v14 {
                Err(v14_1_0) => v18(v14_1_0.clone()),
                Ok(v14_0_0) => v17(v14_0_0.clone()),
            };
            let v221: Documents::US5 = match &v20 {
                Documents::US13::US13_0(v20_0_0) => {
                    let v25: std::path::PathBuf = async_walkdir::DirEntry::path(&v20_0_0.clone());
                    let v32: std::path::Display = v25.display();
                    let v65: std::string::String = format!("{}", v32);
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(v65))
                }
                Documents::US13::US13_1(v20_1_0) => {
                    let v158: () = {
                        Documents::closure33(v20_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v221 {
                Documents::US5::US5_0(v221_0_0) => Some(
                    match &v221 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<string>,
            }
        }
        pub fn method66()
        -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure29((), v)
                },
            )
        }
        pub fn method72(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: usize,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("files_len"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v74: std::string::String = format!("{:#?}", v8);
            let v118: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v74),
                    (),
                );
                ()
            };
            let v137: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v143: string = v10.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run"),
                    )),
                    string(" / "),
                )),
                (v143),
            ))
        }
        pub fn closure34(v0_1: Vec<string>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v19: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method72(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Documents::method8(v40, v41, v42, v43, v44, v45),
                    Documents::method61(),
                    v0_1.len(),
                ))
            };
        }
        pub fn method73() -> string {
            string("")
        }
        pub fn method74(v0_1: string) -> string {
            Documents::method35(Documents::method56(v0_1))
        }
        pub fn method76(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> string {
            v0_1
        }
        pub fn method78() -> string {
            string("")
        }
        pub fn method79(v0_1: i64, v1_1: string, v2: i64) -> LrcPtr<Documents::UH0> {
            if (v2) < (v0_1) {
                LrcPtr::new(Documents::UH0::UH0_1(
                    getCharAt(v1_1.clone(), v2 as i32),
                    Documents::method79(v0_1, v1_1, (v2) + 1_i64),
                ))
            } else {
                LrcPtr::new(Documents::UH0::UH0_0)
            }
        }
        pub fn method80(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method80: loop {
                break '_method80 (match v0_1.get().clone().as_ref() {
                    Documents::UH0::UH0_0 => {
                        (v1_1.get().clone(), v2.get().clone(), v3.get().clone())
                    }
                    Documents::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v4: char = match v0_1.get().clone().as_ref() {
                            Documents::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: bool = '\n' == (v4);
                        let patternInput: (i32, i32) = if v6 {
                            ((v2.get().clone()) + 1_i32, 1_i32)
                        } else {
                            (v2.get().clone(), (v3.get().clone()) + 1_i32)
                        };
                        {
                            let v0_1_temp: LrcPtr<Documents::UH0> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = if v6 {
                                let v13: LrcPtr<StringBuilder> = v1_1.get().clone().Clear();
                                v1_1.get().clone()
                            } else {
                                let v24: LrcPtr<StringBuilder> = {
                                    let value: string = ofChar(v4);
                                    v1_1.get().clone().Append_Z721C83C5(value)
                                };
                                v1_1.get().clone()
                            };
                            let v2_temp: i32 = patternInput.0.clone();
                            let v3_temp: i32 = patternInput.1.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method80;
                        }
                    }
                });
            }
        }
        pub fn closure37(v0_1: i32, v1_1: i32, v2: string) -> string {
            if (v1_1) >= (v0_1) {
                v2.clone()
            } else {
                (Documents::method81(v0_1, (v1_1) + 1_i32))(append((v2), string(" ")))
            }
        }
        pub fn method81(v0_1: i32, v1_1: i32) -> Func1<string, string> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure37(v0_1, v1_1, v)
            })
        }
        pub fn closure36(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\"',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\"' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method80(
                        Documents::method79(length(v51.clone()) as i64, v51, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US15::US15_0(
                        v10,
                        v45,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v66: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US15::US15_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\"',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v66) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v66) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method81((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn closure38(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\'',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\'' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method80(
                        Documents::method79(length(v51.clone()) as i64, v51, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US15::US15_0(
                        v10,
                        v45,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v66: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US15::US15_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\'',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v66) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v66) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method81((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn method82(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method82: loop {
                break '_method82 (match v2.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US15::US15_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v2_1_0, v2_1_1) => {
                        let v7: Documents::US15 = (match v2.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            1_i32,
                            1_i32,
                        ));
                        match &v7 {
                            Documents::US15::US15_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => {
                                v7.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH1> =
                                    match v2.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method82;
                            }
                        }
                    }
                });
            }
        }
        pub fn method83(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method83: loop {
                break '_method83 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US17::US17_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US17::US17_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Documents::US17::US17_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Documents::US17::US17_0(v11_0_0) => match &v11 {
                                Documents::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method83;
                    }
                });
            }
        }
        pub fn method84(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method84: loop {
                break '_method84 ({
                    let v98: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method83(v25, 0_i64)) == false {
                            let v62: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v68: string = ofChar(v25);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method80(
                                    Documents::method79(length(v68.clone()) as i64, v68, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US15::US15_0(
                                v25,
                                v62,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v110: Documents::US15 = match &v98 {
                        Documents::US15::US15_0(v98_0_0, v98_0_1, v98_0_2, v98_0_3, v98_0_4) => {
                            let v99: char = v98_0_0.clone();
                            Documents::US15::US15_0(
                                if '\\' == (v99) { '/' } else { v99 },
                                v98_0_1.clone(),
                                v98_0_2.clone(),
                                v98_0_3.clone(),
                                v98_0_4.clone(),
                            )
                        }
                        Documents::US15::US15_1(v98_1_0) => {
                            Documents::US15::US15_1(v98_1_0.clone())
                        }
                    };
                    match &v110 {
                        Documents::US15::US15_0(
                            v110_0_0,
                            v110_0_1,
                            v110_0_2,
                            v110_0_3,
                            v110_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v110_0_0.clone())));
                            let v1_1_temp: string = v110_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v110_0_2.clone();
                            let v3_temp: i32 = v110_0_3.clone();
                            let v4_temp: i32 = v110_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method84;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method85(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH1>,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v4.clone());
            '_method85: loop {
                break '_method85 (match v4.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US15::US15_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US15 = (match v4.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US15::US15_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH1> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method85;
                            }
                        }
                    }
                });
            }
        }
        pub fn method86(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method86: loop {
                break '_method86 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US17::US17_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US17::US17_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US17::US17_0(' ')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US17::US17_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US17::US17_0(v15_0_0) => match &v15 {
                                Documents::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method86;
                    }
                });
            }
        }
        pub fn method87(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method87: loop {
                break '_method87 ({
                    let v106: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method86(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method80(
                                    Documents::method79(length(v72.clone()) as i64, v72, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US15::US15_0(
                                v29,
                                v66,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v118: Documents::US15 = match &v106 {
                        Documents::US15::US15_0(
                            v106_0_0,
                            v106_0_1,
                            v106_0_2,
                            v106_0_3,
                            v106_0_4,
                        ) => {
                            let v107: char = v106_0_0.clone();
                            Documents::US15::US15_0(
                                if '\\' == (v107) { '/' } else { v107 },
                                v106_0_1.clone(),
                                v106_0_2.clone(),
                                v106_0_3.clone(),
                                v106_0_4.clone(),
                            )
                        }
                        Documents::US15::US15_1(v106_1_0) => {
                            Documents::US15::US15_1(v106_1_0.clone())
                        }
                    };
                    match &v118 {
                        Documents::US15::US15_0(
                            v118_0_0,
                            v118_0_1,
                            v118_0_2,
                            v118_0_3,
                            v118_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v118_0_0.clone())));
                            let v1_1_temp: string = v118_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v118_0_2.clone();
                            let v3_temp: i32 = v118_0_3.clone();
                            let v4_temp: i32 = v118_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method87;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method88(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method88: loop {
                break '_method88 (if (v1_1.get().clone()) >= (length(v0_1.get().clone())) {
                    v1_1.get().clone()
                } else {
                    if ' ' == (getCharAt(v0_1.get().clone(), v1_1.get().clone())) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method88;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method89(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method89: loop {
                break '_method89 ({
                    let v66: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v16: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v50: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v56: string = ofChar(v16);
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method80(
                            Documents::method79(length(v56.clone()) as i64, v56, 0_i64),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        );
                        Documents::US15::US15_0(
                            v16,
                            v50,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    };
                    match &v66 {
                        Documents::US15::US15_0(v66_0_0, v66_0_1, v66_0_2, v66_0_3, v66_0_4) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v66_0_0.clone())));
                            let v1_1_temp: string = v66_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v66_0_2.clone();
                            let v3_temp: i32 = v66_0_3.clone();
                            let v4_temp: i32 = v66_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method89;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method77(v0_1: string) -> Documents::US14 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v10: string = defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                );
                let v16: LrcPtr<StringBuilder> =
                    StringBuilder::_ctor__Z721C83C5(Documents::method78());
                fn v19(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US15 {
                    Documents::closure36((), arg10_0040)
                }
                fn v20(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US15 {
                    Documents::closure38((), arg10_0040_1)
                }
                let v24: Documents::US15 = Documents::method82(
                    v10.clone(),
                    v16.clone(),
                    LrcPtr::new(Documents::UH1::UH1_1(
                        Func1::from(v19),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::from(v20),
                            LrcPtr::new(Documents::UH1::UH1_0),
                        )),
                    )),
                );
                let v197: Documents::US16 = match &v24 {
                    Documents::US15::US15_0(v24_0_0, v24_0_1, v24_0_2, v24_0_3, v24_0_4) => {
                        let v29: i32 = v24_0_4.clone();
                        let v28: i32 = v24_0_3.clone();
                        let v27: LrcPtr<StringBuilder> = v24_0_2.clone();
                        let v26: string = v24_0_1.clone();
                        let v123: Documents::US15 = if string("") == (v26.clone()) {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v27.clone(), v28, v29)
                            ))
                        } else {
                            let v50: char = getCharAt(v26.clone(), 0_i32);
                            if (Documents::method83(v50, 0_i64)) == false {
                                let v87: string = getSlice(
                                    v26.clone(),
                                    Some(1_i32),
                                    Some((length(v26.clone())) - 1_i32),
                                );
                                let v93: string = ofChar(v50);
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method80(
                                        Documents::method79(length(v93.clone()) as i64, v93, 0_i64),
                                        v27.clone(),
                                        v28,
                                        v29,
                                    );
                                Documents::US15::US15_0(
                                    v50,
                                    v87,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            } else {
                                Documents::US15::US15_1(sprintf!(
                                    "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                    v50,
                                    toArray(ofArray(new_array(&['\"', '\'']))),
                                    (v27.clone(), v28, v29)
                                ))
                            }
                        };
                        let v135: Documents::US15 = match &v123 {
                            Documents::US15::US15_0(
                                v123_0_0,
                                v123_0_1,
                                v123_0_2,
                                v123_0_3,
                                v123_0_4,
                            ) => {
                                let v124: char = v123_0_0.clone();
                                Documents::US15::US15_0(
                                    if '\\' == (v124) { '/' } else { v124 },
                                    v123_0_1.clone(),
                                    v123_0_2.clone(),
                                    v123_0_3.clone(),
                                    v123_0_4.clone(),
                                )
                            }
                            Documents::US15::US15_1(v123_1_0) => {
                                Documents::US15::US15_1(v123_1_0.clone())
                            }
                        };
                        let v155: Documents::US16 = match &v135 {
                            Documents::US15::US15_0(
                                v135_0_0,
                                v135_0_1,
                                v135_0_2,
                                v135_0_3,
                                v135_0_4,
                            ) => {
                                let patternInput_1: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method84(
                                    ofChar(v135_0_0.clone()),
                                    v135_0_1.clone(),
                                    v135_0_2.clone(),
                                    v135_0_3.clone(),
                                    v135_0_4.clone(),
                                );
                                Documents::US16::US16_0(
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                    patternInput_1.3.clone(),
                                    patternInput_1.4.clone(),
                                )
                            }
                            Documents::US15::US15_1(v135_1_0) => {
                                Documents::US16::US16_1(v135_1_0.clone())
                            }
                        };
                        let v165: Documents::US16 = match &v155 {
                            Documents::US16::US16_0(
                                v155_0_0,
                                v155_0_1,
                                v155_0_2,
                                v155_0_3,
                                v155_0_4,
                            ) => Documents::US16::US16_0(
                                v155_0_0.clone(),
                                v155_0_1.clone(),
                                v155_0_2.clone(),
                                v155_0_3.clone(),
                                v155_0_4.clone(),
                            ),
                            _ => Documents::US16::US16_0(
                                string(""),
                                v26.clone(),
                                v27.clone(),
                                v28,
                                v29,
                            ),
                        };
                        match &v165 {
                            Documents::US16::US16_0(
                                v165_0_0,
                                v165_0_1,
                                v165_0_2,
                                v165_0_3,
                                v165_0_4,
                            ) => {
                                let v170: i32 = v165_0_4.clone();
                                let v169: i32 = v165_0_3.clone();
                                let v168: LrcPtr<StringBuilder> = v165_0_2.clone();
                                let v167: string = v165_0_1.clone();
                                let v174: Documents::US15 = Documents::method85(
                                    v167.clone(),
                                    v168.clone(),
                                    v169,
                                    v170,
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::from(v19),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::from(v20),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v174 {
                                    Documents::US15::US15_0(
                                        v174_0_0,
                                        v174_0_1,
                                        v174_0_2,
                                        v174_0_3,
                                        v174_0_4,
                                    ) => Documents::US16::US16_0(
                                        v165_0_0.clone(),
                                        v174_0_1.clone(),
                                        v174_0_2.clone(),
                                        v174_0_3.clone(),
                                        v174_0_4.clone(),
                                    ),
                                    Documents::US15::US15_1(v174_1_0) => {
                                        Documents::US16::US16_1(sprintf!(
                                            "parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                            v174_1_0.clone(),
                                            (v10.clone(), v16.clone(), 1_i32, 1_i32),
                                            (v26.clone(), v27.clone(), v28, v29),
                                            (v167.clone(), v168.clone(), v169, v170)
                                        ))
                                    }
                                }
                            }
                            _ => Documents::US16::US16_1(string(
                                "parsing.between / expected content",
                            )),
                        }
                    }
                    Documents::US15::US15_1(v24_1_0) => Documents::US16::US16_1(v24_1_0.clone()),
                };
                let v416: Documents::US16 = match &v197 {
                    Documents::US16::US16_0(v197_0_0, v197_0_1, v197_0_2, v197_0_3, v197_0_4) => {
                        v197.clone()
                    }
                    _ => {
                        let v307: Documents::US15 = if string("") == (v10.clone()) {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v16.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v228: char = getCharAt(v10.clone(), 0_i32);
                            if (Documents::method86(v228, 0_i64)) == false {
                                let v265: string = getSlice(
                                    v10.clone(),
                                    Some(1_i32),
                                    Some((length(v10.clone())) - 1_i32),
                                );
                                let v271: string = ofChar(v228);
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method80(
                                        Documents::method79(
                                            length(v271.clone()) as i64,
                                            v271,
                                            0_i64,
                                        ),
                                        v16.clone(),
                                        1_i32,
                                        1_i32,
                                    );
                                Documents::US15::US15_0(
                                    v228,
                                    v265,
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone(),
                                    patternInput_2.2.clone(),
                                )
                            } else {
                                Documents::US15::US15_1(sprintf!(
                                    "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                    v228,
                                    toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                    (v16.clone(), 1_i32, 1_i32)
                                ))
                            }
                        };
                        let v319: Documents::US15 = match &v307 {
                            Documents::US15::US15_0(
                                v307_0_0,
                                v307_0_1,
                                v307_0_2,
                                v307_0_3,
                                v307_0_4,
                            ) => {
                                let v308: char = v307_0_0.clone();
                                Documents::US15::US15_0(
                                    if '\\' == (v308) { '/' } else { v308 },
                                    v307_0_1.clone(),
                                    v307_0_2.clone(),
                                    v307_0_3.clone(),
                                    v307_0_4.clone(),
                                )
                            }
                            Documents::US15::US15_1(v307_1_0) => {
                                Documents::US15::US15_1(v307_1_0.clone())
                            }
                        };
                        let v339: Documents::US16 = match &v319 {
                            Documents::US15::US15_0(
                                v319_0_0,
                                v319_0_1,
                                v319_0_2,
                                v319_0_3,
                                v319_0_4,
                            ) => {
                                let patternInput_3: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method87(
                                    ofChar(v319_0_0.clone()),
                                    v319_0_1.clone(),
                                    v319_0_2.clone(),
                                    v319_0_3.clone(),
                                    v319_0_4.clone(),
                                );
                                Documents::US16::US16_0(
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                    patternInput_3.2.clone(),
                                    patternInput_3.3.clone(),
                                    patternInput_3.4.clone(),
                                )
                            }
                            Documents::US15::US15_1(v319_1_0) => {
                                Documents::US16::US16_1(v319_1_0.clone())
                            }
                        };
                        match &v339 {
                            Documents::US16::US16_0(
                                v339_0_0,
                                v339_0_1,
                                v339_0_2,
                                v339_0_3,
                                v339_0_4,
                            ) => v339.clone(),
                            _ => {
                                let v354: Documents::US18 = if (length(v10.clone())) == 0_i32 {
                                    Documents::US18::US18_0(v10.clone(), v16.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US18::US18_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v10.clone()
                                    ))
                                };
                                let v363: Documents::US16 = match &v354 {
                                    Documents::US18::US18_0(
                                        v354_0_0,
                                        v354_0_1,
                                        v354_0_2,
                                        v354_0_3,
                                    ) => Documents::US16::US16_0(
                                        string(""),
                                        v354_0_0.clone(),
                                        v354_0_1.clone(),
                                        v354_0_2.clone(),
                                        v354_0_3.clone(),
                                    ),
                                    Documents::US18::US18_1(v354_1_0) => {
                                        Documents::US16::US16_1(v354_1_0.clone())
                                    }
                                };
                                match &v363 {
                                    Documents::US16::US16_0(
                                        v363_0_0,
                                        v363_0_1,
                                        v363_0_2,
                                        v363_0_3,
                                        v363_0_4,
                                    ) => {
                                        let v365: string = v363_0_1.clone();
                                        Documents::US16::US16_0(
                                            v363_0_0.clone(),
                                            getSlice(
                                                v365.clone(),
                                                Some(Documents::method88(v365.clone(), 0_i32)),
                                                Some((length(v365)) - 1_i32),
                                            ),
                                            v363_0_2.clone(),
                                            v363_0_3.clone(),
                                            v363_0_4.clone(),
                                        )
                                    }
                                    Documents::US16::US16_1(v363_1_0) => {
                                        Documents::US16::US16_1(v363_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v671: Documents::US19 = match &v416 {
                    Documents::US16::US16_0(v416_0_0, v416_0_1, v416_0_2, v416_0_3, v416_0_4) => {
                        let v421: i32 = v416_0_4.clone();
                        let v420: i32 = v416_0_3.clone();
                        let v419: LrcPtr<StringBuilder> = v416_0_2.clone();
                        let v418: string = v416_0_1.clone();
                        let v542: Documents::US15 = if string("") == (v418.clone()) {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                ' ',
                                (v419.clone(), v420, v421)
                            ))
                        } else {
                            let v428: char = getCharAt(v418.clone(), 0_i32);
                            if (v428) == ' ' {
                                let v463: string = getSlice(
                                    v418.clone(),
                                    Some(1_i32),
                                    Some((length(v418.clone())) - 1_i32),
                                );
                                let v469: string = ofChar(v428);
                                let patternInput_4: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method80(
                                        Documents::method79(
                                            length(v469.clone()) as i64,
                                            v469,
                                            0_i64,
                                        ),
                                        v419.clone(),
                                        v420,
                                        v421,
                                    );
                                Documents::US15::US15_0(
                                    v428,
                                    v463,
                                    patternInput_4.0.clone(),
                                    patternInput_4.1.clone(),
                                    patternInput_4.2.clone(),
                                )
                            } else {
                                let v484: i32 = (indexOf(v418.clone(), string("\n"))) - 1_i32;
                                Documents::US15::US15_1(concat(new_array(&[
                                    sprintf!(
                                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                        ' ',
                                        v420,
                                        v421,
                                        v419.clone(),
                                        getSlice(
                                            v418.clone(),
                                            Some(0_i32),
                                            Some(
                                                (if -2_i32 == (v484) {
                                                    (length(v418.clone())) + 1_i32
                                                } else {
                                                    (v484) + 1_i32
                                                }) - 1_i32
                                            )
                                        )
                                    ),
                                    string("\n"),
                                    append(
                                        ((Documents::method81((v421) - 1_i32, 0_i32))(string(""))),
                                        string("^"),
                                    ),
                                    string("\n"),
                                ])))
                            }
                        };
                        let v554: Documents::US20 = match &v542 {
                            Documents::US15::US15_0(
                                v542_0_0,
                                v542_0_1,
                                v542_0_2,
                                v542_0_3,
                                v542_0_4,
                            ) => Documents::US20::US20_0(
                                Documents::US17::US17_0(v542_0_0.clone()),
                                v542_0_1.clone(),
                                v542_0_2.clone(),
                                v542_0_3.clone(),
                                v542_0_4.clone(),
                            ),
                            _ => Documents::US20::US20_0(
                                Documents::US17::US17_1,
                                v418.clone(),
                                v419.clone(),
                                v420,
                                v421,
                            ),
                        };
                        let v645: Documents::US16 = match &v554 {
                            Documents::US20::US20_0(
                                v554_0_0,
                                v554_0_1,
                                v554_0_2,
                                v554_0_3,
                                v554_0_4,
                            ) => {
                                let v559: i32 = v554_0_4.clone();
                                let v558: i32 = v554_0_3.clone();
                                let v557: LrcPtr<StringBuilder> = v554_0_2.clone();
                                let v556: string = v554_0_1.clone();
                                let v621: Documents::US15 = if string("") == (v556.clone()) {
                                    Documents::US15::US15_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v557.clone(), v558, v559)
                                    ))
                                } else {
                                    let v571: char = getCharAt(v556.clone(), 0_i32);
                                    let v605: string = getSlice(
                                        v556.clone(),
                                        Some(1_i32),
                                        Some((length(v556)) - 1_i32),
                                    );
                                    let v611: string = ofChar(v571);
                                    let patternInput_5: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method80(
                                            Documents::method79(
                                                length(v611.clone()) as i64,
                                                v611,
                                                0_i64,
                                            ),
                                            v557,
                                            v558,
                                            v559,
                                        );
                                    Documents::US15::US15_0(
                                        v571,
                                        v605,
                                        patternInput_5.0.clone(),
                                        patternInput_5.1.clone(),
                                        patternInput_5.2.clone(),
                                    )
                                };
                                match &v621 {
                                    Documents::US15::US15_0(
                                        v621_0_0,
                                        v621_0_1,
                                        v621_0_2,
                                        v621_0_3,
                                        v621_0_4,
                                    ) => {
                                        let patternInput_6: (
                                            string,
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        ) = Documents::method89(
                                            ofChar(v621_0_0.clone()),
                                            v621_0_1.clone(),
                                            v621_0_2.clone(),
                                            v621_0_3.clone(),
                                            v621_0_4.clone(),
                                        );
                                        Documents::US16::US16_0(
                                            patternInput_6.0.clone(),
                                            patternInput_6.1.clone(),
                                            patternInput_6.2.clone(),
                                            patternInput_6.3.clone(),
                                            patternInput_6.4.clone(),
                                        )
                                    }
                                    Documents::US15::US15_1(v621_1_0) => {
                                        Documents::US16::US16_1(v621_1_0.clone())
                                    }
                                }
                            }
                            Documents::US20::US20_1(v554_1_0) => {
                                Documents::US16::US16_1(v554_1_0.clone())
                            }
                        };
                        let v657: Documents::US21 = match &v645 {
                            Documents::US16::US16_0(
                                v645_0_0,
                                v645_0_1,
                                v645_0_2,
                                v645_0_3,
                                v645_0_4,
                            ) => Documents::US21::US21_0(
                                Documents::US5::US5_0(v645_0_0.clone()),
                                v645_0_1.clone(),
                                v645_0_2.clone(),
                                v645_0_3.clone(),
                                v645_0_4.clone(),
                            ),
                            _ => Documents::US21::US21_0(
                                Documents::US5::US5_1,
                                v418.clone(),
                                v419.clone(),
                                v420,
                                v421,
                            ),
                        };
                        match &v657 {
                            Documents::US21::US21_0(
                                v657_0_0,
                                v657_0_1,
                                v657_0_2,
                                v657_0_3,
                                v657_0_4,
                            ) => Documents::US19::US19_0(
                                v416_0_0.clone(),
                                v657_0_0.clone(),
                                v657_0_1.clone(),
                                v657_0_2.clone(),
                                v657_0_3.clone(),
                                v657_0_4.clone(),
                            ),
                            Documents::US21::US21_1(v657_1_0) => {
                                Documents::US19::US19_1(v657_1_0.clone())
                            }
                        }
                    }
                    Documents::US16::US16_1(v416_1_0) => Documents::US19::US19_1(v416_1_0.clone()),
                };
                match &v671 {
                    Documents::US19::US19_0(
                        v671_0_0,
                        v671_0_1,
                        v671_0_2,
                        v671_0_3,
                        v671_0_4,
                        v671_0_5,
                    ) => Documents::US14::US14_0(v671_0_0.clone(), v671_0_1.clone()),
                    Documents::US19::US19_1(v671_1_0) => Documents::US14::US14_1(v671_1_0.clone()),
                }
            }
        }
        pub fn method92(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method92: loop {
                break '_method92 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US17::US17_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US17::US17_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US17::US17_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Documents::US17::US17_0(' ')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Documents::US17::US17_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Documents::US17::US17_0(v19_0_0) => match &v19 {
                                Documents::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method92;
                    }
                });
            }
        }
        pub fn method93(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method93: loop {
                break '_method93 ({
                    let v114: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v33: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method92(v33, 0_i64)) == false {
                            let v70: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v76: string = ofChar(v33);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method80(
                                    Documents::method79(length(v76.clone()) as i64, v76, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US15::US15_0(
                                v33,
                                v70,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v33,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v114 {
                        Documents::US15::US15_0(
                            v114_0_0,
                            v114_0_1,
                            v114_0_2,
                            v114_0_3,
                            v114_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v114_0_0.clone())));
                            let v1_1_temp: string = v114_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v114_0_2.clone();
                            let v3_temp: i32 = v114_0_3.clone();
                            let v4_temp: i32 = v114_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method93;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method95(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method95: loop {
                break '_method95 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US17::US17_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US17::US17_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US17::US17_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US17::US17_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US17::US17_0(v15_0_0) => match &v15 {
                                Documents::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method95;
                    }
                });
            }
        }
        pub fn closure39(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v125: Documents::US15 = if string("") == (v0_1.clone()) {
                Documents::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\\',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\\' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method80(
                        Documents::method79(length(v51.clone()) as i64, v51, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US15::US15_0(
                        v10,
                        v45,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v66: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US15::US15_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v66) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v66) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method81((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            };
            let v196: Documents::US15 = match &v125 {
                Documents::US15::US15_0(v125_0_0, v125_0_1, v125_0_2, v125_0_3, v125_0_4) => {
                    let v130: i32 = v125_0_4.clone();
                    let v129: i32 = v125_0_3.clone();
                    let v128: LrcPtr<StringBuilder> = v125_0_2.clone();
                    let v127: string = v125_0_1.clone();
                    if string("") == (v127.clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v128.clone(), v129, v130)
                        ))
                    } else {
                        let v142: char = getCharAt(v127.clone(), 0_i32);
                        let v176: string =
                            getSlice(v127.clone(), Some(1_i32), Some((length(v127)) - 1_i32));
                        let v182: string = ofChar(v142);
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Documents::method80(
                            Documents::method79(length(v182.clone()) as i64, v182, 0_i64),
                            v128,
                            v129,
                            v130,
                        );
                        Documents::US15::US15_0(
                            v142,
                            v176,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
                Documents::US15::US15_1(v125_1_0) => Documents::US15::US15_1(v125_1_0.clone()),
            };
            match &v196 {
                Documents::US15::US15_0(v196_0_0, v196_0_1, v196_0_2, v196_0_3, v196_0_4) => {
                    Documents::US16::US16_0(
                        append((ofChar('\\')), (ofChar(v196_0_0.clone()))),
                        v196_0_1.clone(),
                        v196_0_2.clone(),
                        v196_0_3.clone(),
                        v196_0_4.clone(),
                    )
                }
                Documents::US15::US15_1(v196_1_0) => Documents::US16::US16_1(v196_1_0.clone()),
            }
        }
        pub fn closure40(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v125: Documents::US15 = if string("") == (v0_1.clone()) {
                Documents::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '`',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '`' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method80(
                        Documents::method79(length(v51.clone()) as i64, v51, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US15::US15_0(
                        v10,
                        v45,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v66: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US15::US15_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v66) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v66) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method81((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            };
            let v196: Documents::US15 = match &v125 {
                Documents::US15::US15_0(v125_0_0, v125_0_1, v125_0_2, v125_0_3, v125_0_4) => {
                    let v130: i32 = v125_0_4.clone();
                    let v129: i32 = v125_0_3.clone();
                    let v128: LrcPtr<StringBuilder> = v125_0_2.clone();
                    let v127: string = v125_0_1.clone();
                    if string("") == (v127.clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v128.clone(), v129, v130)
                        ))
                    } else {
                        let v142: char = getCharAt(v127.clone(), 0_i32);
                        let v176: string =
                            getSlice(v127.clone(), Some(1_i32), Some((length(v127)) - 1_i32));
                        let v182: string = ofChar(v142);
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Documents::method80(
                            Documents::method79(length(v182.clone()) as i64, v182, 0_i64),
                            v128,
                            v129,
                            v130,
                        );
                        Documents::US15::US15_0(
                            v142,
                            v176,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
                Documents::US15::US15_1(v125_1_0) => Documents::US15::US15_1(v125_1_0.clone()),
            };
            match &v196 {
                Documents::US15::US15_0(v196_0_0, v196_0_1, v196_0_2, v196_0_3, v196_0_4) => {
                    Documents::US16::US16_0(
                        append((ofChar('`')), (ofChar(v196_0_0.clone()))),
                        v196_0_1.clone(),
                        v196_0_2.clone(),
                        v196_0_3.clone(),
                        v196_0_4.clone(),
                    )
                }
                Documents::US15::US15_1(v196_1_0) => Documents::US16::US16_1(v196_1_0.clone()),
            }
        }
        pub fn method96(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH3>,
        ) -> Documents::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH3>> = MutCell::new(v4.clone());
            '_method96: loop {
                break '_method96 (match v4.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => {
                        Documents::US16::US16_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH3::UH3_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US16 = (match v4.get().clone().as_ref() {
                            Documents::UH3::UH3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US16::US16_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH3> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH3::UH3_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method96;
                            }
                        }
                    }
                });
            }
        }
        pub fn method97(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method97: loop {
                break '_method97 (match v0_1.get().clone().as_ref() {
                    Documents::UH2::UH2_0 => v1_1.get().clone(),
                    Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Documents::UH2> = match v0_1.get().clone().as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(Documents::UH2::UH2_1(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH2::UH2_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            v1_1.get().clone(),
                        ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method97;
                    }
                });
            }
        }
        pub fn method94(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US23 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method94: loop {
                break '_method94 ({
                    let v106: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method95(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method80(
                                    Documents::method79(length(v72.clone()) as i64, v72, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US15::US15_0(
                                v29,
                                v66,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v121: Documents::US16 = match &v106 {
                        Documents::US15::US15_0(
                            v106_0_0,
                            v106_0_1,
                            v106_0_2,
                            v106_0_3,
                            v106_0_4,
                        ) => Documents::US16::US16_0(
                            ofChar(v106_0_0.clone()),
                            v106_0_1.clone(),
                            v106_0_2.clone(),
                            v106_0_3.clone(),
                            v106_0_4.clone(),
                        ),
                        Documents::US15::US15_1(v106_1_0) => {
                            Documents::US16::US16_1(v106_1_0.clone())
                        }
                    };
                    let v135: Documents::US16 = match &v121 {
                        Documents::US16::US16_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => v121.clone(),
                        _ => Documents::method96(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure39((), arg10_0040)
                                    },
                                ),
                                LrcPtr::new(Documents::UH3::UH3_1(
                                    Func1::new(
                                        move |arg10_0040_1: (
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        )| {
                                            Documents::closure40((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH3::UH3_0),
                                )),
                            )),
                        ),
                    };
                    match &v135 {
                        Documents::US16::US16_0(
                            v135_0_0,
                            v135_0_1,
                            v135_0_2,
                            v135_0_3,
                            v135_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v135_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v135_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v135_0_2.clone();
                            let v3_temp: i32 = v135_0_3.clone();
                            let v4_temp: i32 = v135_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method94;
                        }
                        _ => Documents::US23::US23_0(
                            Documents::method97(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method98(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method98(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method99(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US23 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method99: loop {
                break '_method99 ({
                    let v106: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method95(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method80(
                                    Documents::method79(length(v72.clone()) as i64, v72, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US15::US15_0(
                                v29,
                                v66,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v121: Documents::US16 = match &v106 {
                        Documents::US15::US15_0(
                            v106_0_0,
                            v106_0_1,
                            v106_0_2,
                            v106_0_3,
                            v106_0_4,
                        ) => Documents::US16::US16_0(
                            ofChar(v106_0_0.clone()),
                            v106_0_1.clone(),
                            v106_0_2.clone(),
                            v106_0_3.clone(),
                            v106_0_4.clone(),
                        ),
                        Documents::US15::US15_1(v106_1_0) => {
                            Documents::US16::US16_1(v106_1_0.clone())
                        }
                    };
                    match &v121 {
                        Documents::US16::US16_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v121_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method99;
                        }
                        _ => Documents::US23::US23_0(
                            Documents::method97(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method91(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US23 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method91: loop {
                break '_method91 ({
                    let v5: bool = string("") == (v1_1.get().clone());
                    let v114: Documents::US15 = if v5 {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v33: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method92(v33, 0_i64)) == false {
                            let v70: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v76: string = ofChar(v33);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method80(
                                    Documents::method79(length(v76.clone()) as i64, v76, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US15::US15_0(
                                v33,
                                v70,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v33,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v134: Documents::US16 = match &v114 {
                        Documents::US15::US15_0(
                            v114_0_0,
                            v114_0_1,
                            v114_0_2,
                            v114_0_3,
                            v114_0_4,
                        ) => {
                            let patternInput_1: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method93(
                                    ofChar(v114_0_0.clone()),
                                    v114_0_1.clone(),
                                    v114_0_2.clone(),
                                    v114_0_3.clone(),
                                    v114_0_4.clone(),
                                );
                            Documents::US16::US16_0(
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                            )
                        }
                        Documents::US15::US15_1(v114_1_0) => {
                            Documents::US16::US16_1(v114_1_0.clone())
                        }
                    };
                    let v522: Documents::US16 = match &v134 {
                        Documents::US16::US16_0(
                            v134_0_0,
                            v134_0_1,
                            v134_0_2,
                            v134_0_3,
                            v134_0_4,
                        ) => v134.clone(),
                        _ => {
                            let v261: Documents::US15 = if v5 {
                                Documents::US15::US15_1(sprintf!(
                                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                    '\"',
                                    (v2.get().clone(), v3.get().clone(), v4.get().clone())
                                ))
                            } else {
                                let v146: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if (v146) == '\"' {
                                    let v181: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some((length(v1_1.get().clone())) - 1_i32),
                                    );
                                    let v187: string = ofChar(v146);
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method80(
                                            Documents::method79(
                                                length(v187.clone()) as i64,
                                                v187,
                                                0_i64,
                                            ),
                                            v2.get().clone(),
                                            v3.get().clone(),
                                            v4.get().clone(),
                                        );
                                    Documents::US15::US15_0(
                                        v146,
                                        v181,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                } else {
                                    let v202: i32 =
                                        (indexOf(v1_1.get().clone(), string("\n"))) - 1_i32;
                                    Documents::US15::US15_1(concat(new_array(&[
                                        sprintf!(
                                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                            '\"',
                                            v3.get().clone(),
                                            v4.get().clone(),
                                            v2.get().clone(),
                                            getSlice(
                                                v1_1.get().clone(),
                                                Some(0_i32),
                                                Some(
                                                    (if -2_i32 == (v202) {
                                                        (length(v1_1.get().clone())) + 1_i32
                                                    } else {
                                                        (v202) + 1_i32
                                                    }) - 1_i32
                                                )
                                            )
                                        ),
                                        string("\n"),
                                        append(
                                            ((Documents::method81(
                                                (v4.get().clone()) - 1_i32,
                                                0_i32,
                                            ))(
                                                string("")
                                            )),
                                            string("^"),
                                        ),
                                        string("\n"),
                                    ])))
                                }
                            };
                            let v451: Documents::US16 = match &v261 {
                                Documents::US15::US15_0(
                                    v261_0_0,
                                    v261_0_1,
                                    v261_0_2,
                                    v261_0_3,
                                    v261_0_4,
                                ) => {
                                    let v266: i32 = v261_0_4.clone();
                                    let v265: i32 = v261_0_3.clone();
                                    let v264: LrcPtr<StringBuilder> = v261_0_2.clone();
                                    let v263: string = v261_0_1.clone();
                                    let v268: Documents::US23 = Documents::method94(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v263.clone(),
                                        v264.clone(),
                                        v265,
                                        v266,
                                    );
                                    let v301: Documents::US16 = match &v268 {
                                        Documents::US23::US23_0(
                                            v268_0_0,
                                            v268_0_1,
                                            v268_0_2,
                                            v268_0_3,
                                            v268_0_4,
                                        ) => {
                                            let v275: List<string> = Documents::method98(
                                                v268_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v275 = v275.clone();
                                                        move || ofList(v275.clone()).clone()
                                                    }))),
                                                ),
                                                v268_0_1.clone(),
                                                v268_0_2.clone(),
                                                v268_0_3.clone(),
                                                v268_0_4.clone(),
                                            )
                                        }
                                        Documents::US23::US23_1(v268_1_0) => {
                                            Documents::US16::US16_1(v268_1_0.clone())
                                        }
                                    };
                                    match &v301 {
                                        Documents::US16::US16_0(
                                            v301_0_0,
                                            v301_0_1,
                                            v301_0_2,
                                            v301_0_3,
                                            v301_0_4,
                                        ) => {
                                            let v306: i32 = v301_0_4.clone();
                                            let v305: i32 = v301_0_3.clone();
                                            let v304: LrcPtr<StringBuilder> = v301_0_2.clone();
                                            let v303: string = v301_0_1.clone();
                                            let v428: Documents::US15 = if string("")
                                                == (v303.clone())
                                            {
                                                Documents::US15::US15_1(sprintf!(
                                                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                    '\"',
                                                    (v304.clone(), v305, v306)
                                                ))
                                            } else {
                                                let v313: char = getCharAt(v303.clone(), 0_i32);
                                                if (v313) == '\"' {
                                                    let v348: string = getSlice(
                                                        v303.clone(),
                                                        Some(1_i32),
                                                        Some((length(v303.clone())) - 1_i32),
                                                    );
                                                    let v354: string = ofChar(v313);
                                                    let patternInput_3: (
                                                        LrcPtr<StringBuilder>,
                                                        i32,
                                                        i32,
                                                    ) = Documents::method80(
                                                        Documents::method79(
                                                            length(v354.clone()) as i64,
                                                            v354,
                                                            0_i64,
                                                        ),
                                                        v304.clone(),
                                                        v305,
                                                        v306,
                                                    );
                                                    Documents::US15::US15_0(
                                                        v313,
                                                        v348,
                                                        patternInput_3.0.clone(),
                                                        patternInput_3.1.clone(),
                                                        patternInput_3.2.clone(),
                                                    )
                                                } else {
                                                    let v369: i32 =
                                                        (indexOf(v303.clone(), string("\n")))
                                                            - 1_i32;
                                                    Documents::US15::US15_1(concat(new_array(&[
                                                        sprintf!(
                                                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                            '\"',
                                                            v305,
                                                            v306,
                                                            v304.clone(),
                                                            getSlice(
                                                                v303.clone(),
                                                                Some(0_i32),
                                                                Some(
                                                                    (if -2_i32 == (v369) {
                                                                        (length(v303.clone()))
                                                                            + 1_i32
                                                                    } else {
                                                                        (v369) + 1_i32
                                                                    }) - 1_i32
                                                                )
                                                            )
                                                        ),
                                                        string("\n"),
                                                        append(
                                                            ((Documents::method81(
                                                                (v306) - 1_i32,
                                                                0_i32,
                                                            ))(
                                                                string("")
                                                            )),
                                                            string("^"),
                                                        ),
                                                        string("\n"),
                                                    ])))
                                                }
                                            };
                                            match &v428 {
                                                Documents::US15::US15_0(
                                                    v428_0_0,
                                                    v428_0_1,
                                                    v428_0_2,
                                                    v428_0_3,
                                                    v428_0_4,
                                                ) => Documents::US16::US16_0(
                                                    v301_0_0.clone(),
                                                    v428_0_1.clone(),
                                                    v428_0_2.clone(),
                                                    v428_0_3.clone(),
                                                    v428_0_4.clone(),
                                                ),
                                                Documents::US15::US15_1(v428_1_0) => {
                                                    Documents::US16::US16_1(sprintf!(
                                                        "parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                        v428_1_0.clone(),
                                                        (
                                                            v1_1.get().clone(),
                                                            v2.get().clone(),
                                                            v3.get().clone(),
                                                            v4.get().clone()
                                                        ),
                                                        (v263.clone(), v264.clone(), v265, v266),
                                                        (v303.clone(), v304.clone(), v305, v306)
                                                    ))
                                                }
                                            }
                                        }
                                        _ => Documents::US16::US16_1(string(
                                            "parsing.between / expected content",
                                        )),
                                    }
                                }
                                Documents::US15::US15_1(v261_1_0) => {
                                    Documents::US16::US16_1(v261_1_0.clone())
                                }
                            };
                            match &v451 {
                                Documents::US16::US16_0(
                                    v451_0_0,
                                    v451_0_1,
                                    v451_0_2,
                                    v451_0_3,
                                    v451_0_4,
                                ) => v451.clone(),
                                _ => {
                                    let v463: Documents::US16 =
                                                     Documents::method96(v1_1.get().clone(),
                                                                         v2.get().clone(),
                                                                         v3.get().clone(),
                                                                         v4.get().clone(),
                                                                         LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                          |arg10_0040:
                                                                                                                               (string,
                                                                                                                                LrcPtr<StringBuilder>,
                                                                                                                                i32,
                                                                                                                                i32)|
                                                                                                                          Documents::closure39((),
                                                                                                                                               arg10_0040)),
                                                                                                           LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                            |arg10_0040_1:
                                                                                                                                                                 (string,
                                                                                                                                                                  LrcPtr<StringBuilder>,
                                                                                                                                                                  i32,
                                                                                                                                                                  i32)|
                                                                                                                                                            Documents::closure40((),
                                                                                                                                                                                 arg10_0040_1)),
                                                                                                                                             LrcPtr::new(Documents::UH3::UH3_0))))));
                                    let v474: Documents::US16 = match &v463 {
                                        Documents::US16::US16_0(
                                            v463_0_0,
                                            v463_0_1,
                                            v463_0_2,
                                            v463_0_3,
                                            v463_0_4,
                                        ) => Documents::US16::US16_0(
                                            string(""),
                                            v463_0_1.clone(),
                                            v463_0_2.clone(),
                                            v463_0_3.clone(),
                                            v463_0_4.clone(),
                                        ),
                                        Documents::US16::US16_1(v463_1_0) => {
                                            Documents::US16::US16_1(v463_1_0.clone())
                                        }
                                    };
                                    let v485: Documents::US23 = match &v474 {
                                        Documents::US16::US16_0(
                                            v474_0_0,
                                            v474_0_1,
                                            v474_0_2,
                                            v474_0_3,
                                            v474_0_4,
                                        ) => Documents::method99(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v474_0_1.clone(),
                                            v474_0_2.clone(),
                                            v474_0_3.clone(),
                                            v474_0_4.clone(),
                                        ),
                                        Documents::US16::US16_1(v474_1_0) => {
                                            Documents::US23::US23_1(v474_1_0.clone())
                                        }
                                    };
                                    match &v485 {
                                        Documents::US23::US23_0(
                                            v485_0_0,
                                            v485_0_1,
                                            v485_0_2,
                                            v485_0_3,
                                            v485_0_4,
                                        ) => {
                                            let v492: List<string> = Documents::method98(
                                                v485_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v492 = v492.clone();
                                                        move || ofList(v492.clone()).clone()
                                                    }))),
                                                ),
                                                v485_0_1.clone(),
                                                v485_0_2.clone(),
                                                v485_0_3.clone(),
                                                v485_0_4.clone(),
                                            )
                                        }
                                        Documents::US23::US23_1(v485_1_0) => {
                                            Documents::US16::US16_1(v485_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v522 {
                        Documents::US16::US16_0(
                            v522_0_0,
                            v522_0_1,
                            v522_0_2,
                            v522_0_3,
                            v522_0_4,
                        ) => {
                            let v527: i32 = v522_0_4.clone();
                            let v526: i32 = v522_0_3.clone();
                            let v525: LrcPtr<StringBuilder> = v522_0_2.clone();
                            let v524: string = v522_0_1.clone();
                            let v523: string = v522_0_0.clone();
                            let v529: i32 = Documents::method88(v524.clone(), 0_i32);
                            let v571: Documents::US18 = if 0_i32 == (v529) {
                                Documents::US18::US18_1(string(
                                    "parsing.spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US18::US18_0(
                                    getSlice(
                                        v524.clone(),
                                        Some(v529),
                                        Some((length(v524.clone())) - 1_i32),
                                    ),
                                    v525.clone(),
                                    v526,
                                    v527,
                                )
                            };
                            match &v571 {
                                Documents::US18::US18_0(v571_0_0, v571_0_1, v571_0_2, v571_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                        Documents::UH2::UH2_1(v523.clone(), v0_1.get().clone()),
                                    );
                                    let v1_1_temp: string = v571_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v571_0_1.clone();
                                    let v3_temp: i32 = v571_0_2.clone();
                                    let v4_temp: i32 = v571_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method91;
                                }
                                _ => Documents::US23::US23_0(
                                    Documents::method97(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v523.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v524.clone(),
                                    v525.clone(),
                                    v526,
                                    v527,
                                ),
                            }
                        }
                        _ => Documents::US23::US23_0(
                            Documents::method97(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method90(v0_1: string) -> Documents::US22 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v22: Documents::US23 = Documents::method91(
                    LrcPtr::new(Documents::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Documents::method78()),
                    1_i32,
                    1_i32,
                );
                match &v22 {
                    Documents::US23::US23_0(v22_0_0, v22_0_1, v22_0_2, v22_0_3, v22_0_4) => {
                        Documents::US22::US22_0(toArray(Documents::method98(
                            v22_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US23::US23_1(v22_1_0) => Documents::US22::US22_1(v22_1_0.clone()),
                }
            }
        }
        pub fn method100(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v18: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v32: () = {
                Documents::closure8(v18.clone(), string("{ "), ());
                ()
            };
            let v51: () = {
                Documents::closure8(v18.clone(), string("file_name"), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v87: () = {
                Documents::closure8(v18.clone(), v8, ());
                ()
            };
            let v106: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v125: () = {
                Documents::closure8(v18.clone(), string("arguments"), ());
                ()
            };
            let v142: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v159: () = {
                Documents::closure8(v18.clone(), v9, ());
                ()
            };
            let v176: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v195: () = {
                Documents::closure8(v18.clone(), string("options"), ());
                ()
            };
            let v212: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v229: () = {
                Documents::closure8(v18.clone(), string("{ "), ());
                ()
            };
            let v248: () = {
                Documents::closure8(v18.clone(), string("command"), ());
                ()
            };
            let v265: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v282: () = {
                Documents::closure8(v18.clone(), v10, ());
                ()
            };
            let v299: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v318: () = {
                Documents::closure8(v18.clone(), string("cancellation_token"), ());
                ()
            };
            let v335: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v347: std::string::String = format!("{:#?}", v11);
            let v391: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v347),
                    (),
                );
                ()
            };
            let v408: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v427: () = {
                Documents::closure8(v18.clone(), string("environment_variables"), ());
                ()
            };
            let v444: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v465: () = {
                Documents::closure8(v18.clone(), sprintf!("{:?}", v12), ());
                ()
            };
            let v482: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v501: () = {
                Documents::closure8(v18.clone(), string("on_line"), ());
                ()
            };
            let v518: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v530: std::string::String = format!("{:#?}", v13);
            let v574: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v530),
                    (),
                );
                ()
            };
            let v591: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v610: () = {
                Documents::closure8(v18.clone(), string("stdin"), ());
                ()
            };
            let v627: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v639: std::string::String = format!("{:#?}", v14);
            let v683: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v639),
                    (),
                );
                ()
            };
            let v700: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v719: () = {
                Documents::closure8(v18.clone(), string("trace"), ());
                ()
            };
            let v736: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v756: () = {
                Documents::closure8(
                    v18.clone(),
                    if v15 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v773: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v792: () = {
                Documents::closure8(v18.clone(), string("working_directory"), ());
                ()
            };
            let v809: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v821: std::string::String = format!("{:#?}", v16);
            let v865: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v821),
                    (),
                );
                ()
            };
            let v884: () = {
                Documents::closure8(v18.clone(), string(" }"), ());
                ()
            };
            let v901: () = {
                Documents::closure8(v18.clone(), string(" }"), ());
                ()
            };
            let v907: string = v18.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options"),
                    )),
                    string(" / "),
                )),
                (v907),
            ))
        }
        pub fn closure41(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_1) {
                let v27: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v53: Option<i64> = patternInput.5.clone();
                let v52: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v51: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v50: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v49: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v48: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method100(
                    v48.clone(),
                    v49.clone(),
                    v50.clone(),
                    v51.clone(),
                    v52.clone(),
                    v53.clone(),
                    Documents::method8(v48, v49, v50, v51, v52, v53),
                    Documents::method61(),
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn closure42(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method101() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure42((), v))
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US24 {
            Documents::US24::US24_0(v0_1)
        }
        pub fn method102()
        -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US24>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure43((), v)
                },
            )
        }
        pub fn closure44(unitVar: (), v0_1: std::string::String) -> Documents::US24 {
            Documents::US24::US24_1(v0_1)
        }
        pub fn method103() -> Func1<std::string::String, Documents::US24> {
            Func1::new(move |v: std::string::String| Documents::closure44((), v))
        }
        pub fn method104(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
            v9: string,
            v10: string,
            v11: string,
            v12: Option<CancellationToken>,
            v13: Array<(string, string)>,
            v14: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v15: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v16: bool,
            v17: Option<string>,
        ) -> string {
            let v19: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v33: () = {
                Documents::closure8(v19.clone(), string("{ "), ());
                ()
            };
            let v52: () = {
                Documents::closure8(v19.clone(), string("error"), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v83: std::string::String = format!("{:#?}", v8);
            let v127: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v83),
                    (),
                );
                ()
            };
            let v146: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v165: () = {
                Documents::closure8(v19.clone(), string("file_name"), ());
                ()
            };
            let v182: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v199: () = {
                Documents::closure8(v19.clone(), v9, ());
                ()
            };
            let v216: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v235: () = {
                Documents::closure8(v19.clone(), string("arguments"), ());
                ()
            };
            let v252: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v269: () = {
                Documents::closure8(v19.clone(), v10, ());
                ()
            };
            let v286: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v305: () = {
                Documents::closure8(v19.clone(), string("options"), ());
                ()
            };
            let v322: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v339: () = {
                Documents::closure8(v19.clone(), string("{ "), ());
                ()
            };
            let v358: () = {
                Documents::closure8(v19.clone(), string("command"), ());
                ()
            };
            let v375: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v392: () = {
                Documents::closure8(v19.clone(), v11, ());
                ()
            };
            let v409: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v428: () = {
                Documents::closure8(v19.clone(), string("cancellation_token"), ());
                ()
            };
            let v445: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v457: std::string::String = format!("{:#?}", v12);
            let v501: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v457),
                    (),
                );
                ()
            };
            let v518: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v537: () = {
                Documents::closure8(v19.clone(), string("environment_variables"), ());
                ()
            };
            let v554: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v575: () = {
                Documents::closure8(v19.clone(), sprintf!("{:?}", v13), ());
                ()
            };
            let v592: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v611: () = {
                Documents::closure8(v19.clone(), string("on_line"), ());
                ()
            };
            let v628: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v640: std::string::String = format!("{:#?}", v14);
            let v684: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v640),
                    (),
                );
                ()
            };
            let v701: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v720: () = {
                Documents::closure8(v19.clone(), string("stdin"), ());
                ()
            };
            let v737: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v749: std::string::String = format!("{:#?}", v15);
            let v793: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v749),
                    (),
                );
                ()
            };
            let v810: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v829: () = {
                Documents::closure8(v19.clone(), string("trace"), ());
                ()
            };
            let v846: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v866: () = {
                Documents::closure8(
                    v19.clone(),
                    if v16 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v883: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v902: () = {
                Documents::closure8(v19.clone(), string("working_directory"), ());
                ()
            };
            let v919: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v931: std::string::String = format!("{:#?}", v17);
            let v975: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v931),
                    (),
                );
                ()
            };
            let v994: () = {
                Documents::closure8(v19.clone(), string(" }"), ());
                ()
            };
            let v1011: () = {
                Documents::closure8(v19.clone(), string(" }"), ());
                ()
            };
            let v1017: string = v19.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / child error"),
                    )),
                    string(" / "),
                )),
                (v1017),
            ))
        }
        pub fn closure45(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            v9: std::string::String,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_4) {
                let v28: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v54: Option<i64> = patternInput.5.clone();
                let v53: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v52: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v51: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v50: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v49: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method104(
                    v49.clone(),
                    v50.clone(),
                    v51.clone(),
                    v52.clone(),
                    v53.clone(),
                    v54.clone(),
                    Documents::method8(v49, v50, v51, v52, v53, v54),
                    Documents::method70(),
                    v9,
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn method105(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure46(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method106()
        -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure46((), v))
        }
        pub fn closure47(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method107() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn method108() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn closure48(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method109() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Documents::closure48((), v)
                },
            )
        }
        pub fn closure49(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_0(v0_1)
        }
        pub fn method110() -> Func1<std::string::String, Documents::US26> {
            Func1::new(move |v: std::string::String| Documents::closure49((), v))
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_1(v0_1)
        }
        pub fn method111() -> Func1<std::string::String, Documents::US26> {
            Func1::new(move |v: std::string::String| Documents::closure50((), v))
        }
        pub fn method112(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: bool,
            v9: std::string::String,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("trace\'"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(
                    v11.clone(),
                    if v8 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v102: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v121: () = {
                Documents::closure8(v11.clone(), string("e"), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v150: std::string::String = format!("{:#?}", v9);
            let v194: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v150),
                    (),
                );
                ()
            };
            let v213: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v219: string = v11.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.stdio_line"),
                    )),
                    string(" / "),
                )),
                (v219),
            ))
        }
        pub fn closure51(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v20: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v46: Option<i64> = patternInput.5.clone();
                let v45: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v44: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v43: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v42: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v41: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method112(
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    Documents::method8(v41, v42, v43, v44, v45, v46),
                    Documents::method70(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method113() -> string {
            let v7: char = getCharAt(toLower(string("Verbose")), 0_i32);
            let v9: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v9.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v30: string = v9.l0.get().clone();
            let v49: &str = inline_colorization::color_bright_black;
            let v56: &str = &*v30;
            let v84: &str = inline_colorization::color_reset;
            let v86: std::string::String = format!("{}{}{}", v49, v56, v84);
            fable_library_rust::String_::fromString(v86)
        }
        pub fn method114(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v11: string = v10.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        (v8),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure52(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v19: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method114(
                        v40.clone(),
                        v41.clone(),
                        v42.clone(),
                        v43.clone(),
                        v44.clone(),
                        v45.clone(),
                        Documents::method8(v40, v41, v42, v43, v44, v45),
                        Documents::method113(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure53(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method115()
        -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure53((), v)
            })
        }
        pub fn method116(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure54(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US27 {
            Documents::US27::US27_0(v0_1)
        }
        pub fn method117() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US27,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure54((), v)
                },
            )
        }
        pub fn method118(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure55(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US28 {
            Documents::US28::US28_0(v0_1)
        }
        pub fn method119()
        -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US28>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure55((), v)
                },
            )
        }
        pub fn method120(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure56(unitVar: (), v0_1: std::process::Output) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method121() -> Func1<std::process::Output, Documents::US29> {
            Func1::new(move |v: std::process::Output| Documents::closure56((), v))
        }
        pub fn closure57(unitVar: (), v0_1: std::string::String) -> Documents::US29 {
            Documents::US29::US29_1(v0_1)
        }
        pub fn method122() -> Func1<std::string::String, Documents::US29> {
            Func1::new(move |v: std::string::String| Documents::closure57((), v))
        }
        pub fn method123(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
            v9: string,
            v10: string,
            v11: string,
            v12: Option<CancellationToken>,
            v13: Array<(string, string)>,
            v14: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v15: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v16: bool,
            v17: Option<string>,
        ) -> string {
            let v19: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v33: () = {
                Documents::closure8(v19.clone(), string("{ "), ());
                ()
            };
            let v52: () = {
                Documents::closure8(v19.clone(), string("error"), ());
                ()
            };
            let v71: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v83: std::string::String = format!("{:#?}", v8);
            let v127: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v83),
                    (),
                );
                ()
            };
            let v146: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v165: () = {
                Documents::closure8(v19.clone(), string("file_name"), ());
                ()
            };
            let v182: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v199: () = {
                Documents::closure8(v19.clone(), v9, ());
                ()
            };
            let v216: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v235: () = {
                Documents::closure8(v19.clone(), string("arguments"), ());
                ()
            };
            let v252: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v269: () = {
                Documents::closure8(v19.clone(), v10, ());
                ()
            };
            let v286: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v305: () = {
                Documents::closure8(v19.clone(), string("options"), ());
                ()
            };
            let v322: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v339: () = {
                Documents::closure8(v19.clone(), string("{ "), ());
                ()
            };
            let v358: () = {
                Documents::closure8(v19.clone(), string("command"), ());
                ()
            };
            let v375: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v392: () = {
                Documents::closure8(v19.clone(), v11, ());
                ()
            };
            let v409: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v428: () = {
                Documents::closure8(v19.clone(), string("cancellation_token"), ());
                ()
            };
            let v445: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v457: std::string::String = format!("{:#?}", v12);
            let v501: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v457),
                    (),
                );
                ()
            };
            let v518: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v537: () = {
                Documents::closure8(v19.clone(), string("environment_variables"), ());
                ()
            };
            let v554: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v575: () = {
                Documents::closure8(v19.clone(), sprintf!("{:?}", v13), ());
                ()
            };
            let v592: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v611: () = {
                Documents::closure8(v19.clone(), string("on_line"), ());
                ()
            };
            let v628: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v640: std::string::String = format!("{:#?}", v14);
            let v684: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v640),
                    (),
                );
                ()
            };
            let v701: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v720: () = {
                Documents::closure8(v19.clone(), string("stdin"), ());
                ()
            };
            let v737: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v749: std::string::String = format!("{:#?}", v15);
            let v793: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v749),
                    (),
                );
                ()
            };
            let v810: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v829: () = {
                Documents::closure8(v19.clone(), string("trace"), ());
                ()
            };
            let v846: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v866: () = {
                Documents::closure8(
                    v19.clone(),
                    if v16 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v883: () = {
                Documents::closure8(v19.clone(), string("; "), ());
                ()
            };
            let v902: () = {
                Documents::closure8(v19.clone(), string("working_directory"), ());
                ()
            };
            let v919: () = {
                Documents::closure8(v19.clone(), string(" = "), ());
                ()
            };
            let v931: std::string::String = format!("{:#?}", v17);
            let v975: () = {
                Documents::closure8(
                    v19.clone(),
                    fable_library_rust::String_::fromString(v931),
                    (),
                );
                ()
            };
            let v994: () = {
                Documents::closure8(v19.clone(), string(" }"), ());
                ()
            };
            let v1011: () = {
                Documents::closure8(v19.clone(), string(" }"), ());
                ()
            };
            let v1017: string = v19.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / output error"),
                    )),
                    string(" / "),
                )),
                (v1017),
            ))
        }
        pub fn closure58(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            v9: std::string::String,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_4) {
                let v28: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v54: Option<i64> = patternInput.5.clone();
                let v53: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v52: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v51: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v50: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v49: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method123(
                    v49.clone(),
                    v50.clone(),
                    v51.clone(),
                    v52.clone(),
                    v53.clone(),
                    v54.clone(),
                    Documents::method8(v49, v50, v51, v52, v53, v54),
                    Documents::method70(),
                    v9,
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn closure59(unitVar: (), v0_1: i32) -> Documents::US30 {
            Documents::US30::US30_0(v0_1)
        }
        pub fn method124() -> Func1<i32, Documents::US30> {
            Func1::new(move |v: i32| Documents::closure59((), v))
        }
        pub fn method125() -> string {
            string("\n")
        }
        pub fn method126(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("exit_code"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v11.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v102: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v121: () = {
                Documents::closure8(v11.clone(), string("std_trace_length"), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v158: () = {
                Documents::closure8(v11.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v177: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v183: string = v11.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / result"),
                    )),
                    string(" / "),
                )),
                (v183),
            ))
        }
        pub fn closure60(v0_1: i32, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v20: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v46: Option<i64> = patternInput.5.clone();
                let v45: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v44: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v43: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v42: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v41: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method126(
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    Documents::method8(v41, v42, v43, v44, v45, v46),
                    Documents::method113(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method129(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: Documents::US5,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v18: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v32: () = {
                Documents::closure8(v18.clone(), string("{ "), ());
                ()
            };
            let v51: () = {
                Documents::closure8(v18.clone(), string("file_name"), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v87: () = {
                Documents::closure8(v18.clone(), v8, ());
                ()
            };
            let v106: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v125: () = {
                Documents::closure8(v18.clone(), string("arguments"), ());
                ()
            };
            let v142: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v163: () = {
                Documents::closure8(v18.clone(), sprintf!("{:?}", v9), ());
                ()
            };
            let v180: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v199: () = {
                Documents::closure8(v18.clone(), string("options"), ());
                ()
            };
            let v216: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v233: () = {
                Documents::closure8(v18.clone(), string("{ "), ());
                ()
            };
            let v252: () = {
                Documents::closure8(v18.clone(), string("command"), ());
                ()
            };
            let v269: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v286: () = {
                Documents::closure8(v18.clone(), v10, ());
                ()
            };
            let v303: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v322: () = {
                Documents::closure8(v18.clone(), string("cancellation_token"), ());
                ()
            };
            let v339: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v351: std::string::String = format!("{:#?}", v11);
            let v395: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v351),
                    (),
                );
                ()
            };
            let v412: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v431: () = {
                Documents::closure8(v18.clone(), string("environment_variables"), ());
                ()
            };
            let v448: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v469: () = {
                Documents::closure8(v18.clone(), sprintf!("{:?}", v12), ());
                ()
            };
            let v486: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v505: () = {
                Documents::closure8(v18.clone(), string("on_line"), ());
                ()
            };
            let v522: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v534: std::string::String = format!("{:#?}", v13);
            let v578: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v534),
                    (),
                );
                ()
            };
            let v595: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v614: () = {
                Documents::closure8(v18.clone(), string("stdin"), ());
                ()
            };
            let v631: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v643: std::string::String = format!("{:#?}", v14);
            let v687: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v643),
                    (),
                );
                ()
            };
            let v704: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v723: () = {
                Documents::closure8(v18.clone(), string("trace"), ());
                ()
            };
            let v740: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v760: () = {
                Documents::closure8(
                    v18.clone(),
                    if v15 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v777: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v796: () = {
                Documents::closure8(v18.clone(), string("working_directory"), ());
                ()
            };
            let v813: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v825: std::string::String = format!("{:#?}", v16);
            let v869: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v825),
                    (),
                );
                ()
            };
            let v888: () = {
                Documents::closure8(v18.clone(), string(" }"), ());
                ()
            };
            let v905: () = {
                Documents::closure8(v18.clone(), string(" }"), ());
                ()
            };
            let v911: string = v18.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async"),
                    )),
                    string(" / "),
                )),
                (v911),
            ))
        }
        pub fn closure61(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: Documents::US5,
            v8: string,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_1) {
                let v27: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v53: Option<i64> = patternInput.5.clone();
                let v52: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v51: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v50: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v49: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v48: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method129(
                    v48.clone(),
                    v49.clone(),
                    v50.clone(),
                    v51.clone(),
                    v52.clone(),
                    v53.clone(),
                    Documents::method8(v48, v49, v50, v51, v52, v53),
                    Documents::method61(),
                    v8,
                    v7,
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn method130(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Array<(string, string)> {
            v2
        }
        pub fn method133(v0_1: bool) -> string {
            unbox::<string>(fable_library_rust::Native_::getZero())
        }
        pub fn closure63(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method134() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Documents::US31> {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Documents::closure63((), v)
            })
        }
        pub fn method135(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn closure64(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v19: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method114(
                        v40.clone(),
                        v41.clone(),
                        v42.clone(),
                        v43.clone(),
                        v44.clone(),
                        v45.clone(),
                        Documents::method8(v40, v41, v42, v43, v44, v45),
                        Documents::method113(),
                        v0_1,
                    )
                })
            };
        }
        pub fn method132(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) -> Arc<Async<()>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method131(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) -> Arc<Async<()>> {
            Documents::method132(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
        }
        pub fn closure62(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) {
            let v11: Arc<Async<()>> =
                Documents::method131(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
            fable_library_rust::Native_::getZero::<()>();
            ()
        }
        pub fn closure65(unitVar: (), v0_1: CancellationToken) -> Documents::US32 {
            Documents::US32::US32_0(v0_1)
        }
        pub fn method136() -> Func1<CancellationToken, Documents::US32> {
            Func1::new(move |v: CancellationToken| Documents::closure65((), v))
        }
        pub fn method137(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method138(v0_1: bool) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method139(v0_1: bool) {
            ();
        }
        pub fn closure66(v0_1: bool, unitVar: ()) {
            if (Documents::method138(v0_1)) == false {
                Documents::method139(v0_1);
            };
        }
        pub fn method141(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<TaskCanceledException>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("ex"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v74: std::string::String = format!("{:#?}", v8);
            let v118: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v74),
                    (),
                );
                ()
            };
            let v137: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v143: string = v10.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async / WaitForExitAsync"),
                    )),
                    string(" / "),
                )),
                (v143),
            ))
        }
        pub fn closure67(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v19: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method141(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Documents::method8(v40, v41, v42, v43, v44, v45),
                    Documents::method33(),
                    v0_1,
                ))
            };
        }
        pub fn method140(
            v0_1: bool,
            v1_1: LrcPtr<ConcurrentStack_1<string>>,
            v2: CancellationToken,
        ) -> Arc<Async<i32>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method142(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v18: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v32: () = {
                Documents::closure8(v18.clone(), string("{ "), ());
                ()
            };
            let v51: () = {
                Documents::closure8(v18.clone(), string("exit_code"), ());
                ()
            };
            let v70: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v90: () = {
                Documents::closure8(v18.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v109: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v128: () = {
                Documents::closure8(v18.clone(), string("output_length"), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v165: () = {
                Documents::closure8(v18.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v182: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v201: () = {
                Documents::closure8(v18.clone(), string("options"), ());
                ()
            };
            let v218: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v235: () = {
                Documents::closure8(v18.clone(), string("{ "), ());
                ()
            };
            let v254: () = {
                Documents::closure8(v18.clone(), string("command"), ());
                ()
            };
            let v271: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v288: () = {
                Documents::closure8(v18.clone(), v10, ());
                ()
            };
            let v305: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v324: () = {
                Documents::closure8(v18.clone(), string("cancellation_token"), ());
                ()
            };
            let v341: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v353: std::string::String = format!("{:#?}", v11);
            let v397: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v353),
                    (),
                );
                ()
            };
            let v414: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v433: () = {
                Documents::closure8(v18.clone(), string("environment_variables"), ());
                ()
            };
            let v450: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v471: () = {
                Documents::closure8(v18.clone(), sprintf!("{:?}", v12), ());
                ()
            };
            let v488: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v507: () = {
                Documents::closure8(v18.clone(), string("on_line"), ());
                ()
            };
            let v524: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v536: std::string::String = format!("{:#?}", v13);
            let v580: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v536),
                    (),
                );
                ()
            };
            let v597: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v616: () = {
                Documents::closure8(v18.clone(), string("stdin"), ());
                ()
            };
            let v633: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v645: std::string::String = format!("{:#?}", v14);
            let v689: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v645),
                    (),
                );
                ()
            };
            let v706: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v725: () = {
                Documents::closure8(v18.clone(), string("trace"), ());
                ()
            };
            let v742: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v762: () = {
                Documents::closure8(
                    v18.clone(),
                    if v15 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v779: () = {
                Documents::closure8(v18.clone(), string("; "), ());
                ()
            };
            let v798: () = {
                Documents::closure8(v18.clone(), string("working_directory"), ());
                ()
            };
            let v815: () = {
                Documents::closure8(v18.clone(), string(" = "), ());
                ()
            };
            let v827: std::string::String = format!("{:#?}", v16);
            let v871: () = {
                Documents::closure8(
                    v18.clone(),
                    fable_library_rust::String_::fromString(v827),
                    (),
                );
                ()
            };
            let v890: () = {
                Documents::closure8(v18.clone(), string(" }"), ());
                ()
            };
            let v907: () = {
                Documents::closure8(v18.clone(), string(" }"), ());
                ()
            };
            let v913: string = v18.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async"),
                    )),
                    string(" / "),
                )),
                (v913),
            ))
        }
        pub fn closure68(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: i32,
            v8: string,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_1) {
                let v27: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v53: Option<i64> = patternInput.5.clone();
                let v52: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v51: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v50: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v49: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v48: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method142(
                    v48.clone(),
                    v49.clone(),
                    v50.clone(),
                    v51.clone(),
                    v52.clone(),
                    v53.clone(),
                    Documents::method8(v48, v49, v50, v51, v52, v53),
                    Documents::method61(),
                    v7,
                    length(v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn method128(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method127(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            Documents::method128(v0_1, v1_1, v2, v3, v4, v5, v6)
        }
        pub fn method75(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v17: Documents::US14 = Documents::method77(Documents::method76(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Documents::US5) = match &v17 {
                Documents::US14::US14_0(v17_0_0, v17_0_1) => (v17_0_0.clone(), v17_0_1.clone()),
                Documents::US14::US14_1(v17_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v17_1_0.clone()
                    ])),
                ),
            };
            let v30: Documents::US5 = patternInput.1.clone();
            let v29: string = patternInput.0.clone();
            let v35: Documents::US22 = Documents::method90(match &v30 {
                Documents::US5::US5_0(v30_0_0) => match &v30 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            });
            let v44: Array<string> = match &v35 {
                Documents::US22::US22_0(v35_0_0) => v35_0_0.clone(),
                Documents::US22::US22_1(v35_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v35_1_0.clone()
                    ])),
                ),
            };
            let v46: Vec<string> = v44.to_vec();
            let v48: bool = true;
            let _vec_map: Vec<_> = v46
                .into_iter()
                .map(|x| {
                    //;
                    let v50: string = x;
                    let v57: &str = &*v50;
                    let v90: std::string::String = String::from(v57);
                    let v118: bool = true;
                    v90
                })
                .collect::<Vec<_>>();
            let v120: Vec<std::string::String> = _vec_map;
            let v187: () = {
                Documents::closure41(
                    v0_1.clone(),
                    v1_1.clone(),
                    v2.clone(),
                    v3.clone(),
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v29.clone(),
                    v120.clone(),
                    (),
                );
                ()
            };
            let _capture_v253: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_5: LrcPtr<(i32, string)> = (Func0::new({
                    let v0_1 = v0_1.clone();
                    let v120 = v120.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v29 = v29.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    move || {
                        let v255: std::process::Command = std::process::Command::new(&*v29.clone());
                        let v257: bool = true;
                        let mut v255 = v255;
                        let v259: bool = true;
                        std::process::Command::args(&mut v255, &*v120.clone());
                        let v261: std::process::Command = v255;
                        let v263: std::process::Stdio = std::process::Stdio::piped();
                        let v265: bool = true;
                        let mut v261 = v261;
                        let v267: bool = true;
                        std::process::Command::stdout(&mut v261, std::process::Stdio::piped());
                        let v269: std::process::Command = v261;
                        let v271: std::process::Stdio = std::process::Stdio::piped();
                        let v273: bool = true;
                        let mut v269 = v269;
                        let v275: bool = true;
                        std::process::Command::stderr(&mut v269, std::process::Stdio::piped());
                        let v277: std::process::Command = v269;
                        let v279: std::process::Stdio = std::process::Stdio::piped();
                        let v281: bool = true;
                        let mut v277 = v277;
                        let v283: bool = true;
                        std::process::Command::stdin(&mut v277, std::process::Stdio::piped());
                        let v285: std::process::Command = v277;
                        let v310: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method6(), v6.clone()),
                        );
                        let v324: std::process::Command = match &v310 {
                            Documents::US5::US5_0(v310_0_0) => {
                                let v316: bool = true;
                                let mut v285 = v285;
                                let v318: bool = true;
                                std::process::Command::current_dir(
                                    &mut v285,
                                    &*match &v310 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v285
                            }
                            _ => v285,
                        };
                        let v346: std::process::Command = if (get_Count(v2.clone()) as u64) == 0_u64
                        {
                            v324
                        } else {
                            let v328: Vec<(string, string)> = v2.clone().to_vec();
                            let v330: bool = true;
                            let _vec_fold_ = v328.into_iter().fold(v324, |acc, x| {
                                //;
                                let v332: std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v337: bool = true;
                                let mut v332 = v332;
                                let v339: bool = true;
                                std::process::Command::env(
                                    &mut v332,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v341: std::process::Command = v332;
                                let v343: bool = true;
                                v341
                            });
                            _vec_fold_
                        };
                        let v348: bool = true;
                        let mut v346 = v346;
                        let v350: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v346);
                        let v351 = Documents::method63();
                        let v355: Result<std::process::Child, std::string::String> =
                            v350.map_err(|x| v351(x));
                        let v367 = Documents::method101();
                        let v369: bool = true;
                        let _result_map_ = v355.map(|x| {
                            //;
                            let v376: Option<std::process::Child> = v367(Some(x));
                            let v378: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v376);
                            let v380: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v378);
                            let v382: bool = true;
                            v380
                        });
                        let v384: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v385 = Documents::method102();
                        let v386 = Documents::method103();
                        let v388: Documents::US24 = match v384 {
                            Ok(x) => v385(x),
                            Err(e) => v386(e),
                        };
                        let patternInput_3: (i32, Documents::US6, Documents::US25) = match &v388 {
                            Documents::US24::US24_0(v388_0_0) => {
                                let v389: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v388_0_0.clone();
                                let v391: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v393: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v389.clone();
                                    let v395: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v393.lock();
                                    let v411: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method105(v395.unwrap());
                                    let v413: bool = true;
                                    let mut v411 = v411;
                                    let v415: &mut Option<std::process::Child> = &mut v411;
                                    let v417: Option<&mut std::process::Child> = v415.as_mut();
                                    let v419: &mut std::process::Child = v417.unwrap();
                                    let v421: &mut Option<std::process::ChildStdout> =
                                        &mut v419.stdout;
                                    let v423: Option<std::process::ChildStdout> =
                                        Option::take(v421);
                                    let v425: std::process::ChildStdout = v423.unwrap();
                                    let v427: bool = true;
                                    v425
                                })();
                                let v429: std::process::ChildStdout = _capture;
                                let v431: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v433: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v389.clone();
                                    let v435: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v433.lock();
                                    let v451: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method105(v435.unwrap());
                                    let v453: bool = true;
                                    let mut v451 = v451;
                                    let v455: &mut Option<std::process::Child> = &mut v451;
                                    let v457: Option<&mut std::process::Child> = v455.as_mut();
                                    let v459: &mut std::process::Child = v457.unwrap();
                                    let v461: &mut Option<std::process::ChildStderr> =
                                        &mut v459.stderr;
                                    let v463: Option<std::process::ChildStderr> =
                                        Option::take(v461);
                                    let v465: std::process::ChildStderr = v463.unwrap();
                                    let v467: bool = true;
                                    v465
                                })();
                                let v469: std::process::ChildStderr = _capture;
                                let v471: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v473: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v389.clone();
                                    let v475: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v473.lock();
                                    let v491: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method105(v475.unwrap());
                                    let v493: bool = true;
                                    let mut v491 = v491;
                                    let v495: &mut Option<std::process::Child> = &mut v491;
                                    let v497: Option<&mut std::process::Child> = v495.as_mut();
                                    let v499: &mut std::process::Child = v497.unwrap();
                                    let v501: &mut Option<std::process::ChildStdin> =
                                        &mut v499.stdin;
                                    let v503: Option<std::process::ChildStdin> = Option::take(v501);
                                    let v505: std::process::ChildStdin = v503.unwrap();
                                    let v511: Option<std::process::ChildStdin> =
                                        (Documents::method106())(Some(v505));
                                    let v513: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v511);
                                    let v515: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v513);
                                    let v517: bool = true;
                                    v515
                                })();
                                let v519: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v521: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v524: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method107())(v521.clone());
                                let v526: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v524);
                                let v528: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v526);
                                let v530: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method108())(v521);
                                let v532: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v530);
                                let v534: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v532);
                                let v536: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method109())(patternInput_2.1.clone());
                                let v538: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v536);
                                let v540: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v538);
                                let v542: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v544: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v429);
                                    let v546: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v544);
                                    let v548: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v546);
                                    let v550: bool = true;
                                    let mut v548 = v548;
                                    let _iter_try_for_each = v548.try_for_each(|x| {
                                        //;
                                        let v552: Result<std::string::String, std::io::Error> = x;
                                        let v554: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v528.clone();
                                        let v555 = Documents::method63();
                                        let v559: Result<std::string::String, std::string::String> =
                                            v552.map_err(|x| v555(x));
                                        let v571 = Documents::method110();
                                        let v572 = Documents::method111();
                                        let v574: Documents::US26 = match v559 {
                                            Ok(x) => v571(x),
                                            Err(e) => v572(e),
                                        };
                                        let v963: std::string::String = match &v574 {
                                            Documents::US26::US26_0(v574_0_0) => {
                                                let v577: string =
                                                    fable_library_rust::String_::fromString(
                                                        v574_0_0.clone(),
                                                    );
                                                let v579: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v581: std::borrow::Cow<[u8]> =
                                                    v579.encode(&*v577).0;
                                                let v583: &[u8] = v581.as_ref();
                                                let v585: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v583);
                                                let v589: &str = v585.unwrap();
                                                let v628: std::string::String = String::from(v589);
                                                let v636: string = concat(new_array(&[
                                                    string("> "),
                                                    fable_library_rust::String_::fromString(
                                                        v628.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v702: () = {
                                                        Documents::closure52(v636.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v769: () = {
                                                        Documents::closure11(v636, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v628
                                            }
                                            Documents::US26::US26_1(v574_1_0) => {
                                                let v771: std::string::String = v574_1_0.clone();
                                                let v834: () = {
                                                    Documents::closure51(v5, v771.clone(), ());
                                                    ()
                                                };
                                                let v895: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v771);
                                                let v902: &str = &*v895;
                                                String::from(v902)
                                            }
                                        };
                                        let v965: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v554;
                                        let v967: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v965.lock();
                                        let v971: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v967.unwrap();
                                        let v984: &std::sync::mpsc::Sender<std::string::String> =
                                            &v971;
                                        let v986: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v984.send(v963);
                                        let v987 = Documents::method115();
                                        let v991: Result<(), std::string::String> =
                                            v986.map_err(|x| v987(x));
                                        let v1004: _ = v991;
                                        let v1006: bool = true;
                                        v1004
                                    }); //;
                                    let v1009: Result<(), string> = Documents::method116(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v1012: string = string("}");
                                    let v1017: bool = true;
                                    let _fix_closure_v1014 = v1009;
                                    let v1024: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v1014 "),
                                                    (v1012),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v1025: bool = true;
                                    _fix_closure_v1014
                                }); // rust.fix_closure';
                                let v1027: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v1029: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v1031: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v469);
                                    let v1033: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v1031);
                                    let v1035: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v1033);
                                    let v1037: bool = true;
                                    let mut v1035 = v1035;
                                    let _iter_try_for_each = v1035.try_for_each(|x| {
                                        //;
                                        let v1039: Result<std::string::String, std::io::Error> = x;
                                        let v1041: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v534.clone();
                                        let v1042 = Documents::method63();
                                        let v1046: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v1039.map_err(|x| v1042(x));
                                        let v1058 = Documents::method110();
                                        let v1059 = Documents::method111();
                                        let v1061: Documents::US26 = match v1046 {
                                            Ok(x) => v1058(x),
                                            Err(e) => v1059(e),
                                        };
                                        let v1515: std::string::String = match &v1061 {
                                            Documents::US26::US26_0(v1061_0_0) => {
                                                let v1064: string =
                                                    fable_library_rust::String_::fromString(
                                                        v1061_0_0.clone(),
                                                    );
                                                let v1066: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v1068: std::borrow::Cow<[u8]> =
                                                    v1066.encode(&*v1064).0;
                                                let v1070: &[u8] = v1068.as_ref();
                                                let v1072: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v1070);
                                                let v1076: &str = v1072.unwrap();
                                                let v1115: std::string::String =
                                                    String::from(v1076);
                                                let v1123: string = concat(new_array(&[
                                                    string("! "),
                                                    fable_library_rust::String_::fromString(
                                                        v1115.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v1188: () = {
                                                        Documents::closure52(v1123.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v1254: () = {
                                                        Documents::closure11(v1123, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v1256: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v1115
                                                    );
                                                    let v1263: &str = &*v1256;
                                                    String::from(v1263)
                                                }
                                            }
                                            Documents::US26::US26_1(v1061_1_0) => {
                                                let v1323: std::string::String = v1061_1_0.clone();
                                                let v1386: () = {
                                                    Documents::closure51(v5, v1323.clone(), ());
                                                    ()
                                                };
                                                let v1447: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v1323);
                                                let v1454: &str = &*v1447;
                                                String::from(v1454)
                                            }
                                        };
                                        let v1517: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1041;
                                        let v1519: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v1517.lock();
                                        let v1523: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v1519.unwrap();
                                        let v1536: &std::sync::mpsc::Sender<std::string::String> =
                                            &v1523;
                                        let v1538: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v1536.send(v1515);
                                        let v1539 = Documents::method115();
                                        let v1543: Result<(), std::string::String> =
                                            v1538.map_err(|x| v1539(x));
                                        let v1556: _ = v1543;
                                        let v1558: bool = true;
                                        v1556
                                    }); //;
                                    let v1561: Result<(), string> = Documents::method116(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v1562: string = string("}");
                                    let v1567: bool = true;
                                    let _fix_closure_v1564 = v1561;
                                    let v1574: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v1564 "),
                                                    (v1562),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v1575: bool = true;
                                    _fix_closure_v1564
                                }); // rust.fix_closure';
                                let v1577: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v1602: Documents::US27 = defaultValue(
                                    Documents::US27::US27_1,
                                    map(Documents::method117(), v4.clone()),
                                );
                                match &v1602 {
                                    Documents::US27::US27_0(v1602_0_0) => {
                                        let v1608: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v519.clone();
                                        let v1610: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v1608.lock();
                                        let v1626: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method118(v1610.unwrap());
                                        let v1628: bool = true;
                                        let mut v1626 = v1626;
                                        let v1630: &mut Option<std::process::ChildStdin> =
                                            &mut v1626;
                                        let v1632: Option<std::process::ChildStdin> =
                                            Option::take(v1630);
                                        let v1634: bool = true;
                                        let _optionm_map_ = v1632.map(|x| {
                                            //;
                                            let v1636: std::process::ChildStdin = x;
                                            let v1638: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v1636);
                                            let v1640: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v1638);
                                            let v1642: bool = true;
                                            v1640
                                        });
                                        let v1644: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v1669: Documents::US28 = defaultValue(
                                            Documents::US28::US28_1,
                                            map(Documents::method119(), v1644),
                                        );
                                        match &v1669 {
                                            Documents::US28::US28_0(v1669_0_0) => {
                                                let v1673: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v1669 {
                                                    Documents::US28::US28_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone();
                                                (match &v1602 {
                                                    Documents::US27::US27_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v1673.clone()
                                                );
                                                {
                                                    let v1675: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v1673;
                                                    let v1677: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v1675.lock();
                                                    let v1693: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method120(v1677.unwrap());
                                                    let v1695: bool = true;
                                                    let mut v1693 = v1693;
                                                    let v1697: bool = true;
                                                    std::io::Write::flush(&mut *v1693).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v1699: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v389;
                                    let v1701: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1699.lock();
                                    let v1717: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method105(v1701.unwrap());
                                    let v1719: bool = true;
                                    let mut v1717 = v1717;
                                    let v1721: &mut Option<std::process::Child> = &mut v1717;
                                    let v1723: Option<std::process::Child> = Option::take(v1721);
                                    let v1725: std::process::Child = v1723.unwrap();
                                    let v1727: Result<std::process::Output, std::io::Error> =
                                        v1725.wait_with_output();
                                    let v1728 = Documents::method63();
                                    let v1741: Result<std::process::Output, std::string::String> =
                                        v1727.map_err(|x| v1728(x));
                                    let v1751: string = string("vec![v1027, v1577]");
                                    let v1752: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v1027, v1577];
                                    let v1754: bool = true;
                                    v1752.into_iter().for_each(|x| {
                                        //;
                                        let v1756: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v1758: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v1756);
                                        let v1762: Result<(), string> = v1758.unwrap();
                                        v1762.unwrap();
                                        {
                                            let v1779: bool = true;
                                            let v1781: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v1782 = Documents::method121();
                                        let v1783 = Documents::method122();
                                        let v1785: Documents::US29 = match &v1741 {
                                            Err(v1741_1_0) => v1783(v1741_1_0.clone()),
                                            Ok(v1741_0_0) => v1782(v1741_0_0.clone()),
                                        };
                                        match &v1785 {
                                            Documents::US29::US29_0(v1785_0_0) => {
                                                let v1790: std::process::ExitStatus =
                                                    v1785_0_0.clone().status;
                                                let v1792: Option<i32> = v1790.code();
                                                let v1817: Documents::US30 = defaultValue(
                                                    Documents::US30::US30_1,
                                                    map(Documents::method124(), v1792),
                                                );
                                                match &v1817 {
                                                    Documents::US30::US30_0(v1817_0_0) => (
                                                        match &v1817 {
                                                            Documents::US30::US30_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US6::US6_1,
                                                        Documents::US25::US25_0(v540.clone()),
                                                    ),
                                                    _ => {
                                                        let v1831: &str = &*string(
                                                            "runtime.execute_with_options / exit_code=None",
                                                        );
                                                        (
                                                            -1_i32,
                                                            Documents::US6::US6_0(String::from(
                                                                v1831,
                                                            )),
                                                            Documents::US25::US25_0(v540.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US29::US29_1(v1785_1_0) => {
                                                let v1899: std::string::String = v1785_1_0.clone();
                                                let v1966: () = {
                                                    Documents::closure58(
                                                        v0_1.clone(),
                                                        v1_1.clone(),
                                                        v2.clone(),
                                                        v3.clone(),
                                                        v4.clone(),
                                                        v5,
                                                        v6.clone(),
                                                        v29.clone(),
                                                        v120.clone(),
                                                        v1899.clone(),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US6::US6_0(v1899),
                                                    Documents::US25::US25_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US24::US24_1(v388_1_0) => {
                                let v2039: std::string::String = v388_1_0.clone();
                                let v2106: () = {
                                    Documents::closure45(
                                        v0_1.clone(),
                                        v1_1.clone(),
                                        v2.clone(),
                                        v3.clone(),
                                        v4.clone(),
                                        v5,
                                        v6.clone(),
                                        v29.clone(),
                                        v120.clone(),
                                        v2039.clone(),
                                        (),
                                    );
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US6::US6_0(v2039),
                                    Documents::US25::US25_1,
                                )
                            }
                        };
                        let v2178: Documents::US25 = patternInput_3.2.clone();
                        let v2177: Documents::US6 = patternInput_3.1.clone();
                        let v2176: i32 = patternInput_3.0.clone();
                        let v2189: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v2178 {
                            Documents::US25::US25_0(v2178_0_0) => Some(
                                match &v2178 {
                                    Documents::US25::US25_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                None::<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                >
                            }
                        };
                        let v2191: bool = true;
                        let _optionm_map_ = v2189.map(|x| {
                            //;
                            let v2193: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v2195: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v2193;
                            let v2197: Result<
                                std::sync::MutexGuard<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                                std::sync::PoisonError<
                                    std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                >,
                            > = v2195.lock();
                            let v2201: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v2197.unwrap();
                            let v2214 = v2201.iter();
                            let v2216: Vec<std::string::String> = v2214.collect::<Vec<_>>();
                            let v2218: bool = true;
                            let _vec_map: Vec<_> = v2216
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v2220: std::string::String = x;
                                    let v2222: string =
                                        fable_library_rust::String_::fromString(v2220);
                                    let v2224: bool = true;
                                    v2222
                                })
                                .collect::<Vec<_>>();
                            let v2226: Vec<string> = _vec_map;
                            let v2230: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                fable_library_rust::NativeArray_::array_from(v2226.clone()),
                            );
                            let v2238: string = join(Documents::method125(), toArray_1(v2230));
                            let v2243: bool = true;
                            v2238
                        });
                        let v2245: Option<string> = _optionm_map_;
                        let v2252: Documents::US5 = match &v2177 {
                            Documents::US6::US6_0(v2177_0_0) => {
                                Documents::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v2177 {
                                        Documents::US6::US6_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Documents::US5::US5_1,
                        };
                        let v2258: string = defaultValue(
                            match &v2252 {
                                Documents::US5::US5_0(v2252_0_0) => match &v2252 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => string(""),
                            },
                            v2245,
                        );
                        let v2324: () = {
                            Documents::closure60(v2176, v2258.clone(), ());
                            ()
                        };
                        LrcPtr::new((v2176, v2258))
                    }
                }))();
                _capture_v253.set(Some(x_5))
            }
            {
                let v2390: LrcPtr<(i32, string)> = match &_capture_v253.get().clone() {
                    None => panic!("{}", string("base.capture / _capture_v253=None"),),
                    Some(_capture_v253_0_0) => _capture_v253_0_0.clone(),
                };
                let _run_target_args__v15: (i32, string) = (v2390.0.clone(), v2390.1.clone());
                (
                    _run_target_args__v15.0.clone(),
                    _run_target_args__v15.1.clone(),
                )
            }
        }
        pub fn method143(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method26(v2, Documents::method43(v1_1.clone()));
            let v9: string = getSlice(
                v1_1.clone(),
                Some(0_i32),
                Some((lastIndexOf(v1_1.clone(), string("."))) - 1_i32),
            );
            let v16: string = getSlice(
                v4.clone(),
                Some(0_i32),
                Some((lastIndexOf(v4.clone(), string("."))) - 1_i32),
            );
            let v26: bool = (endsWith3(v0_1.clone(), string(".md"), false)) == false;
            (
                if v26 {
                    concat(new_array(&[v1_1, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v9, string("."), v0_1.clone()]))
                },
                if v26 {
                    concat(new_array(&[v4, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v16, string("."), v0_1]))
                },
            )
        }
        pub fn method144() -> string {
            string("")
        }
        pub fn closure69(unitVar: (), v0_1: string) -> Documents::US34 {
            Documents::US34::US34_0(v0_1)
        }
        pub fn method145() -> Func1<string, Documents::US34> {
            Func1::new(move |v: string| Documents::closure69((), v))
        }
        pub fn closure70(unitVar: (), v0_1: std::string::String) -> Documents::US34 {
            Documents::US34::US34_1(v0_1)
        }
        pub fn method146() -> Func1<std::string::String, Documents::US34> {
            Func1::new(move |v: std::string::String| Documents::closure70((), v))
        }
        pub fn method147(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: string,
            v12: i32,
            v13: string,
            v14: i32,
            v15: string,
            v16: string,
            v17: Documents::US5,
            v18: string,
            v19: string,
        ) -> string {
            let v21: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v35: () = {
                Documents::closure8(v21.clone(), string("{ "), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v21.clone(), string("file"), ());
                ()
            };
            let v73: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v90: () = {
                Documents::closure8(v21.clone(), v9, ());
                ()
            };
            let v109: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v128: () = {
                Documents::closure8(v21.clone(), string("real_path"), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v162: () = {
                Documents::closure8(v21.clone(), v10, ());
                ()
            };
            let v179: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v198: () = {
                Documents::closure8(v21.clone(), string("relative_path"), ());
                ()
            };
            let v215: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v232: () = {
                Documents::closure8(v21.clone(), v11, ());
                ()
            };
            let v249: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v268: () = {
                Documents::closure8(v21.clone(), string("origin_hash_exit_code"), ());
                ()
            };
            let v285: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v305: () = {
                Documents::closure8(v21.clone(), sprintf!("{}", v12), ());
                ()
            };
            let v322: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v341: () = {
                Documents::closure8(v21.clone(), string("origin_hash"), ());
                ()
            };
            let v358: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v375: () = {
                Documents::closure8(v21.clone(), v13, ());
                ()
            };
            let v392: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v411: () = {
                Documents::closure8(v21.clone(), string("local_git_hash_exit_code"), ());
                ()
            };
            let v428: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v448: () = {
                Documents::closure8(v21.clone(), sprintf!("{}", v14), ());
                ()
            };
            let v465: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v484: () = {
                Documents::closure8(v21.clone(), string("local_git_hash"), ());
                ()
            };
            let v501: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v518: () = {
                Documents::closure8(v21.clone(), v15, ());
                ()
            };
            let v535: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v554: () = {
                Documents::closure8(v21.clone(), string("hash1"), ());
                ()
            };
            let v571: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v588: () = {
                Documents::closure8(v21.clone(), v16, ());
                ()
            };
            let v605: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v624: () = {
                Documents::closure8(v21.clone(), string("hash2"), ());
                ()
            };
            let v641: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v662: () = {
                Documents::closure8(v21.clone(), sprintf!("{:?}", v17), ());
                ()
            };
            let v679: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v698: () = {
                Documents::closure8(v21.clone(), string("dist_path"), ());
                ()
            };
            let v715: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v732: () = {
                Documents::closure8(v21.clone(), v18, ());
                ()
            };
            let v749: () = {
                Documents::closure8(v21.clone(), string("; "), ());
                ()
            };
            let v768: () = {
                Documents::closure8(v21.clone(), string("cache_path"), ());
                ()
            };
            let v785: () = {
                Documents::closure8(v21.clone(), string(" = "), ());
                ()
            };
            let v802: () = {
                Documents::closure8(v21.clone(), v19, ());
                ()
            };
            let v821: () = {
                Documents::closure8(v21.clone(), string(" }"), ());
                ()
            };
            let v827: string = v21.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        (v8),
                    )),
                    string(" / "),
                )),
                (v827),
            ))
        }
        pub fn closure71(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: i32,
            v5: string,
            v6: string,
            v7: i32,
            v8: string,
            v9: string,
            v10: Documents::US5,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_2) {
                let v29: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v55: Option<i64> = patternInput.5.clone();
                let v54: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v53: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v52: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v51: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v50: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                let v74: string = string(
                    "documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2",
                );
                Documents::method17(if (v74.clone()) == string("") {
                    string("")
                } else {
                    Documents::method147(
                        v50.clone(),
                        v51.clone(),
                        v52.clone(),
                        v53.clone(),
                        v54.clone(),
                        v55.clone(),
                        Documents::method8(v50, v51, v52, v53, v54, v55),
                        Documents::method12(),
                        v74,
                        v1_1,
                        v2,
                        v0_1,
                        v4,
                        v3,
                        v7,
                        v6,
                        v9,
                        v10,
                        v5,
                        v8,
                    )
                })
            };
        }
        pub fn closure72(unitVar: (), v0_1: u64) -> Documents::US35 {
            Documents::US35::US35_0(v0_1)
        }
        pub fn method149() -> Func1<u64, Documents::US35> {
            Func1::new(move |v: u64| Documents::closure72((), v))
        }
        pub fn closure73(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_1(v0_1)
        }
        pub fn method150() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure73((), v))
        }
        pub fn method151(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: std::string::String,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v26: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), string("old_path"), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v81: () = {
                Documents::closure8(v12.clone(), v8, ());
                ()
            };
            let v100: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v119: () = {
                Documents::closure8(v12.clone(), string("new_path"), ());
                ()
            };
            let v136: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v153: () = {
                Documents::closure8(v12.clone(), v9, ());
                ()
            };
            let v170: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v189: () = {
                Documents::closure8(v12.clone(), string("error"), ());
                ()
            };
            let v206: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v218: std::string::String = format!("{:#?}", v10);
            let v262: () = {
                Documents::closure8(
                    v12.clone(),
                    fable_library_rust::String_::fromString(v218),
                    (),
                );
                ()
            };
            let v281: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            let v287: string = v12.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.file_copy"),
                    )),
                    string(" / "),
                )),
                (v287),
            ))
        }
        pub fn closure74(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v21: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v47: Option<i64> = patternInput.5.clone();
                let v46: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v45: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v44: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v43: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v42: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method151(
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    Documents::method8(v42, v43, v44, v45, v46, v47),
                    Documents::method33(),
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method152(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: u64,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v26: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), string("old_path"), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v81: () = {
                Documents::closure8(v12.clone(), v8, ());
                ()
            };
            let v100: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v119: () = {
                Documents::closure8(v12.clone(), string("new_path"), ());
                ()
            };
            let v136: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v153: () = {
                Documents::closure8(v12.clone(), v9, ());
                ()
            };
            let v170: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v189: () = {
                Documents::closure8(v12.clone(), string("result"), ());
                ()
            };
            let v206: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v226: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v10), ());
                ()
            };
            let v245: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            let v251: string = v12.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.file_copy"),
                    )),
                    string(" / "),
                )),
                (v251),
            ))
        }
        pub fn closure75(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v21: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v47: Option<i64> = patternInput.5.clone();
                let v46: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v45: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v44: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v43: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v42: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method152(
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    Documents::method8(v42, v43, v44, v45, v46, v47),
                    Documents::method61(),
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method148(v0_1: string, v1_1: string) {
            let v4: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v0_1.clone());
            let v5 = Documents::method63();
            let v18: Result<u64, std::string::String> = v4.map_err(|x| v5(x));
            let v21 = Documents::method149();
            let v22 = Documents::method150();
            let v24: Documents::US35 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v24 {
                Documents::US35::US35_0(v24_0_0) => {
                    let v90: () = {
                        Documents::closure75(v0_1.clone(), v1_1.clone(), v24_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US35::US35_1(v24_1_0) => {
                    let v214: () = {
                        Documents::closure74(v0_1.clone(), v1_1.clone(), v24_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ()
        }
        pub fn method154(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method155(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method156(v0_1: string) -> string {
            v0_1
        }
        pub fn method157(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure78(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v21: string = Documents::method156(v0_1);
            let v23: &[u8] = v21.as_bytes();
            let v24: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method157(v9);
            let v26: bool = true;
            let mut v24 = v24;
            let v28: bool = true;
            std::io::Write::write_all(&mut *v24, v23).unwrap();
            ()
        }
        pub fn method158(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method159(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
            v10: string,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v26: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), string("exit_code"), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v103: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v12.clone(), string("result_len"), ());
                ()
            };
            let v139: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v159: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v176: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v195: () = {
                Documents::closure8(v12.clone(), string("output_path"), ());
                ()
            };
            let v212: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v229: () = {
                Documents::closure8(v12.clone(), v10, ());
                ()
            };
            let v248: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            let v254: string = v12.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.hangul"),
                    )),
                    string(" / "),
                )),
                (v254),
            ))
        }
        pub fn closure79(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v21: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v47: Option<i64> = patternInput.5.clone();
                let v46: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v45: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v44: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v43: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v42: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method159(
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    Documents::method8(v42, v43, v44, v45, v46, v47),
                    Documents::method12(),
                    v1_1,
                    length(v2),
                    v0_1,
                ))
            };
        }
        pub fn method153(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US36 {
            let v15: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v60: Vec<u8> = Documents::method154(v15.unwrap());
            let v62: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v60);
            let v66: std::string::String = v62.unwrap();
            let v115: Array<string> = split(
                fable_library_rust::String_::fromString(v66),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v118: i32 = get_Count(v115.clone());
            let v119: Array<string> = new_init(&string(""), v118);
            let v120: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method58(v118, v120.clone()) {
                let v122: i32 = v120.l0.get().clone();
                let v126: string = trim(v115[v122].clone());
                v119.get_mut()[v122 as usize] = v126;
                {
                    let v129: i32 = (v122) + 1_i32;
                    v120.l0.set(v129);
                    ()
                }
            }
            {
                let v130: i32 = get_Count(v119.clone());
                let v131: Array<string> = new_init(&string(""), v130);
                let v132: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method155(v130, v132.clone()) {
                    let v134: i32 = v132.l0.get().clone();
                    let v135: i32 = v132.l1.get().clone();
                    let v136: string = v119[v134].clone();
                    let v144: i32 = if (v136.clone()) != string("") {
                        v131.get_mut()[v135 as usize] = v136;
                        (v135) + 1_i32
                    } else {
                        v135
                    };
                    let v145: i32 = (v134) + 1_i32;
                    v132.l0.set(v145);
                    v132.l1.set(v144);
                    ()
                }
                {
                    let v146: i32 = v132.l1.get().clone();
                    let v147: Array<string> = new_init(&string(""), v146);
                    let v148: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method58(v146, v148.clone()) {
                        let v150: i32 = v148.l0.get().clone();
                        let v151: string = v131[v150].clone();
                        v147.get_mut()[v150 as usize] = v151;
                        {
                            let v152: i32 = (v150) + 1_i32;
                            v148.l0.set(v152);
                            ()
                        }
                    }
                    {
                        let _let__v157: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v147 = v147.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v147 = v147.clone();
                                        move |i: i32| v147[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v147.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v173: string = concat(new_array(&[
                            join(Documents::method125(), toArray_1(_let__v157)),
                            string("\n\n"),
                        ]));
                        let patternInput: (i32, string) = Documents::method75(
                            concat(new_array(&[
                                Documents::method26(
                                    v0_1,
                                    concat(new_array(&[
                                        string(
                                            "../alphabet/deps/hangulize/cmd/hangulize/hangulize",
                                        ),
                                        if cfg!(windows) {
                                            string(".exe")
                                        } else {
                                            string("")
                                        },
                                    ])),
                                ),
                                string(" "),
                                v1_1,
                            ])),
                            None::<CancellationToken>,
                            new_empty::<(string, string)>(),
                            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                            Some(Func1::new({
                                let v173 = v173.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure78(v173.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                        );
                        let v232: i32 = patternInput.0.clone();
                        let v240: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v243: i32 = get_Count(v240.clone());
                        let v245: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method158(v130, v245.clone()) {
                            let v247: i32 = v245.l0.get().clone();
                            let matchValue: string = v245.l1.get().clone();
                            let matchValue_1: i32 = v245.l2.get().clone();
                            let v250: i32 = v245.l3.get().clone();
                            let v249: i32 = matchValue_1;
                            let v248: string = matchValue;
                            let v251: string = v119[v247].clone();
                            let patternInput_2: (string, i32, i32) = if (v251.clone()) == string("")
                            {
                                (
                                    concat(new_array(&[v248.clone(), string("\n")])),
                                    (v249) + 1_i32,
                                    (v250) + 1_i32,
                                )
                            } else {
                                let v256: i32 = (v249) - (v250);
                                (
                                    if (v256) >= (v243) {
                                        v248.clone()
                                    } else {
                                        let v259: string = v240[v256].clone();
                                        let v268: string = if contains(v259.clone(), string("://"))
                                        {
                                            v251
                                        } else {
                                            v259
                                        };
                                        if (v256) == ((v243) - 1_i32) {
                                            concat(new_array(&[v248.clone(), v268.clone()]))
                                        } else {
                                            concat(new_array(&[v248, v268, string("\n")]))
                                        }
                                    },
                                    (v249) + 1_i32,
                                    v250,
                                )
                            };
                            let v279: i32 = (v247) + 1_i32;
                            v245.l0.set(v279);
                            v245.l1.set(patternInput_2.0.clone());
                            v245.l2.set(patternInput_2.1.clone());
                            v245.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v245.l1.get().clone();
                            let matchValue_4: i32 = v245.l2.get().clone();
                            let matchValue_5: i32 = v245.l3.get().clone();
                            let v280: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v280.clone()).unwrap();
                            {
                                let v348: () = {
                                    Documents::closure79(v2, v232, v280.clone(), ());
                                    ()
                                };
                                Documents::US36::US36_0(v232, v280)
                            }
                        }
                    }
                }
            }
        }
        pub fn method160(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("exit_code"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v11.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v102: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v121: () = {
                Documents::closure8(v11.clone(), string("result"), ());
                ()
            };
            let v138: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v155: () = {
                Documents::closure8(v11.clone(), v9, ());
                ()
            };
            let v174: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v180: string = v11.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.files_fn / error"),
                    )),
                    string(" / "),
                )),
                (v180),
            ))
        }
        pub fn closure80(v0_1: string, v1_1: i32, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v20: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v46: Option<i64> = patternInput.5.clone();
                let v45: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v44: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v43: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v42: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v41: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method160(
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    Documents::method8(v41, v42, v43, v44, v45, v46),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn closure77(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US33 {
            let patternInput: (string, string) = Documents::method143(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if if if (Documents::method28(v6.clone())) == false {
                true
            } else {
                (Documents::method28(v7.clone())) == false
            } {
                false
            } else {
                let v13: string = Documents::method35(v6.clone());
                let v15: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v13);
                let v19: std::fs::File = v15.unwrap();
                let v32: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v19);
                let v34: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v32);
                let v36: bool = true;
                let mut v34 = v34;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v39: sha2::Sha256 = result;
                    let v41: bool = true;
                    let mut v39 = v39;
                    let v43: usize = 0_i32 as usize;
                    let v47: _ = [0_u8; 1024];
                    let v49: bool = true;
                    loop {
                        // rust.loop;
                        let v51: bool = true;
                        let mut v47 = v47;
                        let v53: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v34, &mut v47);
                        let v66: usize = v53.unwrap();
                        if (v66) == (v43) {
                            let v74: bool = true;
                            break;
                            ()
                        }
                        {
                            let v76: usize = v66;
                            let v93: &_ = if (v76) == (v47.len()) {
                                &v47[v43..]
                            } else {
                                &v47[v43..v76]
                            };
                            sha2::Digest::update(&mut v39, v93);
                            {
                                let v96: bool = true;
                            } // rust.loop;
                            let v98: bool = true;
                        } // rust.loop;
                        let v100: bool = true;
                    } // rust.loop;
                    let v102: bool = true;
                    {
                        // rust.loop;
                        let v104: bool = true;
                        {
                            // rust.loop;
                            let v106: &[u8] = &sha2::Digest::finalize(v39);
                            let v108: Vec<u8> = v106.iter().map(|x| *x).collect::<Vec<_>>();
                            let v110: bool = true;
                            let _vec_map: Vec<_> = v108
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v112: u8 = x;
                                    let v114: std::string::String = format!("{:02x}", v112);
                                    let v116: string =
                                        fable_library_rust::String_::fromString(v114);
                                    let v118: bool = true;
                                    v116
                                })
                                .collect::<Vec<_>>();
                            let v120: Vec<string> = _vec_map;
                            let v122: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v120.clone());
                            let _let__v127: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v122 = v122.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v122 = v122.clone();
                                                move |i: i32| v122[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v122.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v136: string = Documents::method144();
                            let v143: string = join(
                                if (v136.clone()) == string("\n") {
                                    Documents::method60(v136.clone())
                                } else {
                                    v136
                                },
                                toArray_1(_let__v127),
                            );
                            let v150 = Documents::method63();
                            let v154: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v143).map_err(|x| v150(x));
                            let v166 = Documents::method145();
                            let v167 = Documents::method146();
                            let v169: Documents::US34 = match v154 {
                                Ok(x) => v166(x),
                                Err(e) => v167(e),
                            };
                            let v178: string = match &v169 {
                                Documents::US34::US34_0(v169_0_0) => v169_0_0.clone(),
                                Documents::US34::US34_1(v169_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v169_1_0.clone()
                                    ),
                                ),
                            };
                            let v179: string = Documents::method35(v7.clone());
                            let v181: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v179);
                            let v185: std::fs::File = v181.unwrap();
                            let v198: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v185);
                            let v200: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v198);
                            let v202: bool = true;
                            let mut v200 = v200;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v205: sha2::Sha256 = result;
                                let v207: bool = true;
                                let mut v205 = v205;
                                let v209: usize = 0_i32 as usize;
                                let v213: _ = [0_u8; 1024];
                                let v215: bool = true;
                                loop {
                                    // rust.loop;
                                    let v217: bool = true;
                                    let mut v213 = v213;
                                    let v219: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v200, &mut v213);
                                    let v232: usize = v219.unwrap();
                                    if (v232) == (v209) {
                                        let v240: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v242: usize = v232;
                                        let v259: &_ = if (v242) == (v213.len()) {
                                            &v213[v209..]
                                        } else {
                                            &v213[v209..v242]
                                        };
                                        sha2::Digest::update(&mut v205, v259);
                                        {
                                            let v262: bool = true;
                                        } // rust.loop;
                                        let v264: bool = true;
                                    } // rust.loop;
                                    let v266: bool = true;
                                } // rust.loop;
                                let v268: bool = true;
                                {
                                    // rust.loop;
                                    let v270: bool = true;
                                    {
                                        // rust.loop;
                                        let v272: &[u8] = &sha2::Digest::finalize(v205);
                                        let v274: Vec<u8> =
                                            v272.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v276: bool = true;
                                        let _vec_map: Vec<_> = v274
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v278: u8 = x;
                                                let v280: std::string::String =
                                                    format!("{:02x}", v278);
                                                let v282: string =
                                                    fable_library_rust::String_::fromString(v280);
                                                let v284: bool = true;
                                                v282
                                            })
                                            .collect::<Vec<_>>();
                                        let v286: Vec<string> = _vec_map;
                                        let v288: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v286.clone(),
                                            );
                                        let _let__v293: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v288 = v288.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v288 = v288.clone();
                                                            move |i_1: i32| v288[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v288.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v302: string = Documents::method144();
                                        let v309: string = join(
                                            if (v302.clone()) == string("\n") {
                                                Documents::method60(v302.clone())
                                            } else {
                                                v302
                                            },
                                            toArray_1(_let__v293),
                                        );
                                        let v316 = Documents::method63();
                                        let v320: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v309).map_err(|x| v316(x));
                                        let v332 = Documents::method145();
                                        let v333 = Documents::method146();
                                        let v335: Documents::US34 = match v320 {
                                            Ok(x) => v332(x),
                                            Err(e) => v333(e),
                                        };
                                        (v178)
                                            == (match &v335 {
                                                Documents::US34::US34_0(v335_0_0) => {
                                                    v335_0_0.clone()
                                                }
                                                Documents::US34::US34_1(v335_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Result value was Error: {}",
                                                        v335_1_0.clone()
                                                    ),
                                                ),
                                            })
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US33::US33_1
            } else {
                let v348: Documents::US36 = Documents::method153(v2, v3, v6.clone(), v4);
                match &v348 {
                    Documents::US36::US36_0(v348_0_0, v348_0_1) => {
                        let v350: string = v348_0_1.clone();
                        let v349: i32 = v348_0_0.clone();
                        if (v349) != 0_i32 {
                            let v417: () = {
                                Documents::closure80(v350.clone(), v349, ());
                                ()
                            };
                            Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v350)),
                            ))
                        } else {
                            if Documents::method28(v6.clone()) {
                                Documents::method148(v7.clone(), v6.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v6.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US33::US33_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US36::US36_1(v348_1_0, v348_1_1) => {
                        Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v348_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure76(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US33> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure77(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v,
                    )
                }
            })
        }
        pub fn method162(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v26: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), string("exit_code"), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v8), ());
                ()
            };
            let v103: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v12.clone(), string("output_path"), ());
                ()
            };
            let v139: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v156: () = {
                Documents::closure8(v12.clone(), v9, ());
                ()
            };
            let v173: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v192: () = {
                Documents::closure8(v12.clone(), string("result"), ());
                ()
            };
            let v209: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v226: () = {
                Documents::closure8(v12.clone(), v10, ());
                ()
            };
            let v245: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            let v251: string = v12.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.crowbook / result contains ERROR"),
                    )),
                    string(" / "),
                )),
                (v251),
            ))
        }
        pub fn closure83(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v21: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v47: Option<i64> = patternInput.5.clone();
                let v46: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v45: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v44: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v43: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v42: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method162(
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    Documents::method8(v42, v43, v44, v45, v46, v47),
                    Documents::method33(),
                    v2,
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method161(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US36 {
            let v61: string = if string("html") == (v4.clone()) {
                string(
                    "--set html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                )
            } else {
                if string("pdf") == (v4.clone()) {
                    append(
                        (append(
                            string(
                                "--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\"",
                            ),
                            (if (v0_1) == false {
                                string("")
                            } else {
                                string(
                                    " tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13",
                                )
                            }),
                        )),
                        string(
                            " rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                        ),
                    )
                } else {
                    if string("epub") == (v4.clone()) {
                        string(
                            "--set epub.version 3 html.css.add \\\"\'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                        )
                    } else {
                        string("")
                    }
                }
            };
            let patternInput: (i32, string) = Documents::method75(
                append(
                    (concat(new_array(&[string("crowbook --verbose --to "), v4]))),
                    sprintf!(" --single \"{}\" --output \"{}\" {}", v2, v1_1.clone(), v61),
                ),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3),
            );
            let v88: string = patternInput.1.clone();
            let v87: i32 = patternInput.0.clone();
            if (contains(v88.clone(), string("ERROR"))) == false {
                Documents::US36::US36_0(v87, v88.clone())
            } else {
                let v159: () = {
                    Documents::closure83(v1_1, v88.clone(), v87, ());
                    ()
                };
                Documents::US36::US36_1(v87, v88)
            }
        }
        pub fn closure82(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US33 {
            let patternInput: (string, string) = Documents::method143(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if (Documents::method28(v5.clone())) == false {
                true
            } else {
                (Documents::method28(v6.clone())) == false
            } {
                false
            } else {
                let v12: string = Documents::method35(v5.clone());
                let v14: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v12);
                let v18: std::fs::File = v14.unwrap();
                let v31: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v18);
                let v33: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v31);
                let v35: bool = true;
                let mut v33 = v33;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v38: sha2::Sha256 = result;
                    let v40: bool = true;
                    let mut v38 = v38;
                    let v42: usize = 0_i32 as usize;
                    let v46: _ = [0_u8; 1024];
                    let v48: bool = true;
                    loop {
                        // rust.loop;
                        let v50: bool = true;
                        let mut v46 = v46;
                        let v52: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v33, &mut v46);
                        let v65: usize = v52.unwrap();
                        if (v65) == (v42) {
                            let v73: bool = true;
                            break;
                            ()
                        }
                        {
                            let v75: usize = v65;
                            let v92: &_ = if (v75) == (v46.len()) {
                                &v46[v42..]
                            } else {
                                &v46[v42..v75]
                            };
                            sha2::Digest::update(&mut v38, v92);
                            {
                                let v95: bool = true;
                            } // rust.loop;
                            let v97: bool = true;
                        } // rust.loop;
                        let v99: bool = true;
                    } // rust.loop;
                    let v101: bool = true;
                    {
                        // rust.loop;
                        let v103: bool = true;
                        {
                            // rust.loop;
                            let v105: &[u8] = &sha2::Digest::finalize(v38);
                            let v107: Vec<u8> = v105.iter().map(|x| *x).collect::<Vec<_>>();
                            let v109: bool = true;
                            let _vec_map: Vec<_> = v107
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v111: u8 = x;
                                    let v113: std::string::String = format!("{:02x}", v111);
                                    let v115: string =
                                        fable_library_rust::String_::fromString(v113);
                                    let v117: bool = true;
                                    v115
                                })
                                .collect::<Vec<_>>();
                            let v119: Vec<string> = _vec_map;
                            let v121: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v119.clone());
                            let _let__v126: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v121 = v121.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v121 = v121.clone();
                                                move |i: i32| v121[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v121.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v135: string = Documents::method144();
                            let v142: string = join(
                                if (v135.clone()) == string("\n") {
                                    Documents::method60(v135.clone())
                                } else {
                                    v135
                                },
                                toArray_1(_let__v126),
                            );
                            let v149 = Documents::method63();
                            let v153: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v142).map_err(|x| v149(x));
                            let v165 = Documents::method145();
                            let v166 = Documents::method146();
                            let v168: Documents::US34 = match v153 {
                                Ok(x) => v165(x),
                                Err(e) => v166(e),
                            };
                            let v177: string = match &v168 {
                                Documents::US34::US34_0(v168_0_0) => v168_0_0.clone(),
                                Documents::US34::US34_1(v168_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v168_1_0.clone()
                                    ),
                                ),
                            };
                            let v178: string = Documents::method35(v6.clone());
                            let v180: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v178);
                            let v184: std::fs::File = v180.unwrap();
                            let v197: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v184);
                            let v199: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v197);
                            let v201: bool = true;
                            let mut v199 = v199;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v204: sha2::Sha256 = result;
                                let v206: bool = true;
                                let mut v204 = v204;
                                let v208: usize = 0_i32 as usize;
                                let v212: _ = [0_u8; 1024];
                                let v214: bool = true;
                                loop {
                                    // rust.loop;
                                    let v216: bool = true;
                                    let mut v212 = v212;
                                    let v218: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v199, &mut v212);
                                    let v231: usize = v218.unwrap();
                                    if (v231) == (v208) {
                                        let v239: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v241: usize = v231;
                                        let v258: &_ = if (v241) == (v212.len()) {
                                            &v212[v208..]
                                        } else {
                                            &v212[v208..v241]
                                        };
                                        sha2::Digest::update(&mut v204, v258);
                                        {
                                            let v261: bool = true;
                                        } // rust.loop;
                                        let v263: bool = true;
                                    } // rust.loop;
                                    let v265: bool = true;
                                } // rust.loop;
                                let v267: bool = true;
                                {
                                    // rust.loop;
                                    let v269: bool = true;
                                    {
                                        // rust.loop;
                                        let v271: &[u8] = &sha2::Digest::finalize(v204);
                                        let v273: Vec<u8> =
                                            v271.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v275: bool = true;
                                        let _vec_map: Vec<_> = v273
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v277: u8 = x;
                                                let v279: std::string::String =
                                                    format!("{:02x}", v277);
                                                let v281: string =
                                                    fable_library_rust::String_::fromString(v279);
                                                let v283: bool = true;
                                                v281
                                            })
                                            .collect::<Vec<_>>();
                                        let v285: Vec<string> = _vec_map;
                                        let v287: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v285.clone(),
                                            );
                                        let _let__v292: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v287 = v287.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v287 = v287.clone();
                                                            move |i_1: i32| v287[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v287.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v301: string = Documents::method144();
                                        let v308: string = join(
                                            if (v301.clone()) == string("\n") {
                                                Documents::method60(v301.clone())
                                            } else {
                                                v301
                                            },
                                            toArray_1(_let__v292),
                                        );
                                        let v315 = Documents::method63();
                                        let v319: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v308).map_err(|x| v315(x));
                                        let v331 = Documents::method145();
                                        let v332 = Documents::method146();
                                        let v334: Documents::US34 = match v319 {
                                            Ok(x) => v331(x),
                                            Err(e) => v332(e),
                                        };
                                        (v177)
                                            == (match &v334 {
                                                Documents::US34::US34_0(v334_0_0) => {
                                                    v334_0_0.clone()
                                                }
                                                Documents::US34::US34_1(v334_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Result value was Error: {}",
                                                        v334_1_0.clone()
                                                    ),
                                                ),
                                            })
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US33::US33_1
            } else {
                let v347: Documents::US36 = Documents::method161(v2, v5.clone(), v3, v1_1, v4);
                match &v347 {
                    Documents::US36::US36_0(v347_0_0, v347_0_1) => {
                        let v349: string = v347_0_1.clone();
                        let v348: i32 = v347_0_0.clone();
                        if (v348) != 0_i32 {
                            let v416: () = {
                                Documents::closure80(v349.clone(), v348, ());
                                ()
                            };
                            Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v349)),
                            ))
                        } else {
                            if Documents::method28(v5.clone()) {
                                Documents::method148(v6.clone(), v5.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v5.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US33::US33_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US36::US36_1(v347_1_0, v347_1_1) => {
                        Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v347_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure81(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US33> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure82(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn method163(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("output_path"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v80: () = {
                Documents::closure8(v11.clone(), v8, ());
                ()
            };
            let v99: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v118: () = {
                Documents::closure8(v11.clone(), string("output_cache_path"), ());
                ()
            };
            let v135: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v152: () = {
                Documents::closure8(v11.clone(), v9, ());
                ()
            };
            let v171: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v177: string = v11.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run / par_map / files\' = [] / listm.iter"),
                    )),
                    string(" / "),
                )),
                (v177),
            ))
        }
        pub fn closure84(v0_1: string, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v20: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v46: Option<i64> = patternInput.5.clone();
                let v45: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v44: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v43: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v42: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v41: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method163(
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    Documents::method8(v41, v42, v43, v44, v45, v46),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method164(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: List<LrcPtr<Documents::UH5>>,
        ) -> List<LrcPtr<Documents::UH5>> {
            match v0_1.as_ref() {
                Documents::UH4::UH4_0 => v1_1.clone(),
                Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH4::UH4_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method164(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure86(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: LrcPtr<Documents::UH4>,
        ) -> LrcPtr<Documents::UH4> {
            LrcPtr::new(Documents::UH4::UH4_1(v0_1, v1_1))
        }
        pub fn closure85(
            unitVar: (),
            v0_1: LrcPtr<Documents::UH5>,
        ) -> Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH4>| Documents::closure86(v0_1.clone(), v)
            })
        }
        pub fn method165()
        -> Func1<LrcPtr<Documents::UH5>, Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>>>
        {
            Func1::new(move |v: LrcPtr<Documents::UH5>| Documents::closure85((), v))
        }
        pub fn method167(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US33>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US33>>,
        )> {
            match v0_1.as_ref() {
                Documents::UH5::UH5_0 => v1_1.clone(),
                Documents::UH5::UH5_1(v0_1_1_0, v0_1_1_1, v0_1_1_2, v0_1_1_3) => cons(
                    (
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(x, _, _, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, x, _, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            move |a0: string| {
                                Func1::new({
                                    let a0 = a0.clone();
                                    let v0_1 = v0_1.clone();
                                    move |a1: string| {
                                        (match v0_1.as_ref() {
                                            Documents::UH5::UH5_1(_, _, x, _) => x.clone(),
                                            _ => unreachable!(),
                                        })(a0.clone(), a1)
                                    }
                                })
                            }
                        }),
                    ),
                    Documents::method167(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure87(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US33>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US33 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US33::US33_0(v4_0_0) => Some(
                    match &v4 {
                        Documents::US33::US33_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method168(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method169(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method166(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            let v0_1: MutCell<LrcPtr<Documents::UH4>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>> =
                MutCell::new(v1_1.clone());
            '_method166: loop {
                break '_method166 (match v0_1.get().clone().as_ref() {
                    Documents::UH4::UH4_0 => v1_1.get().clone(),
                    Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => {
                        let v8 = toArray(Documents::method167(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH4::UH4_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            empty::<(
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US33>>,
                            )>(),
                        ));
                        let v12 = v8.to_vec();
                        let v14 = rayon::iter::IntoParallelIterator::into_par_iter(v12);
                        let v17 = rayon::iter::ParallelIterator::map(v14, |x| {
                            Func1::new(
                                move |arg10_0040: (
                                    string,
                                    string,
                                    Func1<string, Func1<string, Documents::US33>>,
                                )| {
                                    Documents::closure87((), arg10_0040)
                                },
                            )(x)
                        });
                        let v20: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method168(rayon::iter::ParallelIterator::collect(v17));
                        let v21: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method169(v1_1.get().clone());
                        let v23: bool = true;
                        let mut v21 = v21;
                        let v25: bool = true;
                        v21.extend(v20);
                        {
                            let v0_1_temp: LrcPtr<Documents::UH4> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH4::UH4_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                v21;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method166;
                        }
                    }
                });
            }
        }
        pub fn closure35(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Result<
            LrcPtr<(
                string,
                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
            )>,
            std::string::String,
        > {
            let v6: string = Documents::method56(v5);
            let v13: &str = &*v6.clone();
            let v46: std::string::String = String::from(v13);
            let v79: std::path::PathBuf = std::path::PathBuf::from(v46);
            let v112: std::path::Display = v79.display();
            let v145: std::string::String = format!("{}", v112);
            let v179: string = concat(new_array(&[
                string("."),
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v145),
                        v3.clone(),
                        Documents::method73(),
                    ),
                    string("\\"),
                    string("/"),
                ),
            ]));
            let v180: string = Documents::method35(v6);
            let v182: string = Documents::method74(Documents::method26(v2.clone(), v179.clone()));
            let patternInput: (i32, string) = Documents::method75(
                concat(new_array(&[
                    string("git ls-tree --format=\'%(objectname)\' origin/gh-pages \""),
                    v182.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v2),
            );
            let v207: string = patternInput.1.clone();
            let v206: i32 = patternInput.0.clone();
            let v209: string = Documents::method74(Documents::method26(v3.clone(), v179.clone()));
            let patternInput_1: (i32, string) = Documents::method75(
                concat(new_array(&[
                    string("git hash-object \""),
                    v209.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
            );
            let v234: string = patternInput_1.1.clone();
            let v233: i32 = patternInput_1.0.clone();
            let v236: string = Documents::method74(Documents::method26(v4.clone(), v179.clone()));
            let v238: string =
                (Documents::method143(string("hangul.md"), v209.clone(), v4.clone()))
                    .0
                    .clone();
            let v911: LrcPtr<Documents::UH4> = if contains(v207.clone(), v234.clone()) {
                LrcPtr::new(Documents::UH4::UH4_0)
            } else {
                let v251: string = Documents::method35(v209.clone());
                let v253: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v251);
                let v257: std::fs::File = v253.unwrap();
                let v270: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v257);
                let v272: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v270);
                let v274: bool = true;
                let mut v272 = v272;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v277: sha2::Sha256 = result;
                    let v279: bool = true;
                    let mut v277 = v277;
                    let v281: usize = 0_i32 as usize;
                    let v285: _ = [0_u8; 1024];
                    let v287: bool = true;
                    loop {
                        // rust.loop;
                        let v289: bool = true;
                        let mut v285 = v285;
                        let v291: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v272, &mut v285);
                        let v304: usize = v291.unwrap();
                        if (v304) == (v281) {
                            let v312: bool = true;
                            break;
                            ()
                        }
                        {
                            let v314: usize = v304;
                            let v331: &_ = if (v314) == (v285.len()) {
                                &v285[v281..]
                            } else {
                                &v285[v281..v314]
                            };
                            sha2::Digest::update(&mut v277, v331);
                            {
                                let v334: bool = true;
                            } // rust.loop;
                            let v336: bool = true;
                        } // rust.loop;
                        let v338: bool = true;
                    } // rust.loop;
                    let v340: bool = true;
                    {
                        // rust.loop;
                        let v342: bool = true;
                        {
                            // rust.loop;
                            let v344: &[u8] = &sha2::Digest::finalize(v277);
                            let v346: Vec<u8> = v344.iter().map(|x| *x).collect::<Vec<_>>();
                            let v348: bool = true;
                            let _vec_map: Vec<_> = v346
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v350: u8 = x;
                                    let v352: std::string::String = format!("{:02x}", v350);
                                    let v354: string =
                                        fable_library_rust::String_::fromString(v352);
                                    let v356: bool = true;
                                    v354
                                })
                                .collect::<Vec<_>>();
                            let v358: Vec<string> = _vec_map;
                            let v360: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v358.clone());
                            let _let__v365: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v360 = v360.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v360 = v360.clone();
                                                move |i: i32| v360[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v360.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v374: string = Documents::method144();
                            let v381: string = join(
                                if (v374.clone()) == string("\n") {
                                    Documents::method60(v374.clone())
                                } else {
                                    v374
                                },
                                toArray_1(_let__v365),
                            );
                            let v388 = Documents::method63();
                            let v392: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v381).map_err(|x| v388(x));
                            let v404 = Documents::method145();
                            let v405 = Documents::method146();
                            let v407: Documents::US34 = match v392 {
                                Ok(x) => v404(x),
                                Err(e) => v405(e),
                            };
                            let v416: string = match &v407 {
                                Documents::US34::US34_0(v407_0_0) => v407_0_0.clone(),
                                Documents::US34::US34_1(v407_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v407_1_0.clone()
                                    ),
                                ),
                            };
                            let v583: Documents::US5 = if (Documents::method28(v236.clone()))
                                == false
                            {
                                Documents::US5::US5_1
                            } else {
                                let v420: string = Documents::method35(v236.clone());
                                let v422: Result<std::fs::File, std::io::Error> =
                                    std::fs::File::open(&*v420);
                                let v426: std::fs::File = v422.unwrap();
                                let v439: std::io::BufReader<std::fs::File> =
                                    std::io::BufReader::new(v426);
                                let v441: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                    std::io::BufReader::new(v439);
                                let v443: bool = true;
                                let mut v441 = v441;
                                let result: sha2::Sha256 = sha2::Digest::new();
                                {
                                    let v446: sha2::Sha256 = result;
                                    let v448: bool = true;
                                    let mut v446 = v446;
                                    let v450: usize = 0_i32 as usize;
                                    let v454: _ = [0_u8; 1024];
                                    let v456: bool = true;
                                    loop {
                                        // rust.loop;
                                        let v458: bool = true;
                                        let mut v454 = v454;
                                        let v460: Result<usize, std::io::Error> =
                                            std::io::Read::read(&mut v441, &mut v454);
                                        let v473: usize = v460.unwrap();
                                        if (v473) == (v450) {
                                            let v481: bool = true;
                                            break;
                                            ()
                                        }
                                        {
                                            let v483: usize = v473;
                                            let v500: &_ = if (v483) == (v454.len()) {
                                                &v454[v450..]
                                            } else {
                                                &v454[v450..v483]
                                            };
                                            sha2::Digest::update(&mut v446, v500);
                                            {
                                                let v503: bool = true;
                                            } // rust.loop;
                                            let v505: bool = true;
                                        } // rust.loop;
                                        let v507: bool = true;
                                    } // rust.loop;
                                    let v509: bool = true;
                                    {
                                        // rust.loop;
                                        let v511: bool = true;
                                        {
                                            // rust.loop;
                                            let v513: &[u8] = &sha2::Digest::finalize(v446);
                                            let v515: Vec<u8> =
                                                v513.iter().map(|x| *x).collect::<Vec<_>>();
                                            let v517: bool = true;
                                            let _vec_map: Vec<_> = v515
                                                .into_iter()
                                                .map(|x| {
                                                    //;
                                                    let v519: u8 = x;
                                                    let v521: std::string::String =
                                                        format!("{:02x}", v519);
                                                    let v523: string =
                                                        fable_library_rust::String_::fromString(
                                                            v521,
                                                        );
                                                    let v525: bool = true;
                                                    v523
                                                })
                                                .collect::<Vec<_>>();
                                            let v527: Vec<string> = _vec_map;
                                            let v529: Array<string> =
                                                fable_library_rust::NativeArray_::array_from(
                                                    v527.clone(),
                                                );
                                            let _let__v534: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v529 = v529.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v529 = v529.clone();
                                                                move |i_1: i32| v529[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                (get_Count(v529.clone())) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let v543: string = Documents::method144();
                                            let v550: string = join(
                                                if (v543.clone()) == string("\n") {
                                                    Documents::method60(v543.clone())
                                                } else {
                                                    v543
                                                },
                                                toArray_1(_let__v534),
                                            );
                                            let v557 = Documents::method63();
                                            let v561: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v550)
                                                    .map_err(|x| v557(x));
                                            let v573 = Documents::method145();
                                            let v574 = Documents::method146();
                                            let v576: Documents::US34 = match v561 {
                                                Ok(x) => v573(x),
                                                Err(e) => v574(e),
                                            };
                                            match &v576 {
                                                Documents::US34::US34_0(v576_0_0) => {
                                                    Documents::US5::US5_0(v576_0_0.clone())
                                                }
                                                _ => Documents::US5::US5_1,
                                            }
                                        }
                                    }
                                }
                            };
                            if let Documents::US5::US5_0(v583_0_0) = &v583 {
                                if (v416.clone()) == (v583_0_0.clone()) {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                } else {
                                    let v657: () = {
                                        Documents::closure71(
                                            v179.clone(),
                                            v180.clone(),
                                            v182.clone(),
                                            v207.clone(),
                                            v206,
                                            v209.clone(),
                                            v234.clone(),
                                            v233,
                                            v236.clone(),
                                            v416.clone(),
                                            v583.clone(),
                                            (),
                                        );
                                        ()
                                    };
                                    Documents::method148(v236.clone(), v209.clone());
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("hangul.md"),
                                            v209.clone(),
                                            Func2::new({
                                                let v0_1 = v0_1.clone();
                                                let v1_1 = v1_1.clone();
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v1_1 = v1_1.clone();
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v: string| {
                                                            Documents::closure76(
                                                                v4.clone(),
                                                                v3.clone(),
                                                                v1_1.clone(),
                                                                v0_1.clone(),
                                                                v,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH5::UH5_0),
                                        )),
                                        LrcPtr::new(Documents::UH4::UH4_1(
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("html"),
                                                v209.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure81(
                                                                    v4.clone(),
                                                                    v3.clone(),
                                                                    false,
                                                                    v_1,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                    string("pdf"),
                                                    v209.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_2: string| {
                                                                    Documents::closure81(
                                                                        v4.clone(),
                                                                        v3.clone(),
                                                                        false,
                                                                        v_2,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH5::UH5_1(
                                                        string("epub"),
                                                        v209.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_3: string| {
                                                                        Documents::closure81(
                                                                            v4.clone(),
                                                                            v3.clone(),
                                                                            false,
                                                                            v_3,
                                                                        )
                                                                    }
                                                                }))(
                                                                    b0
                                                                )(
                                                                    b1
                                                                )
                                                            }
                                                        }),
                                                        LrcPtr::new(Documents::UH5::UH5_1(
                                                            string("html"),
                                                            v238.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_4: string| {
                                                                            Documents::closure81(
                                                                                v4.clone(),
                                                                                v3.clone(),
                                                                                true,
                                                                                v_4,
                                                                            )
                                                                        }
                                                                    }))(
                                                                        b0
                                                                    )(
                                                                        b1
                                                                    )
                                                                }
                                                            }),
                                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                                string("pdf"),
                                                                v238.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_5: string| {
                                                                                Documents::closure81(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
                                                                                    true,
                                                                                    v_5,
                                                                                )
                                                                            }
                                                                        }))(
                                                                            b0
                                                                        )(
                                                                            b1
                                                                        )
                                                                    }
                                                                }),
                                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                                    string("epub"),
                                                                    v238.clone(),
                                                                    Func2::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move
                                                                                                                                                                                                                                                                                                                                           |b0:
                                                                                                                                                                                                                                                                                                                                                string,
                                                                                                                                                                                                                                                                                                                                            b1:
                                                                                                                                                                                                                                                                                                                                                string|
                                                                                                                                                                                                                                                                                                                                           (Func1::new({
                                                                                                                                                                                                                                                                                                                                                           let v3
                                                                                                                                                                                                                                                                                                                                                               =
                                                                                                                                                                                                                                                                                                                                                               v3.clone();
                                                                                                                                                                                                                                                                                                                                                           let v4
                                                                                                                                                                                                                                                                                                                                                               =
                                                                                                                                                                                                                                                                                                                                                               v4.clone();
                                                                                                                                                                                                                                                                                                                                                           move
                                                                                                                                                                                                                                                                                                                                                               |v_6:
                                                                                                                                                                                                                                                                                                                                                                    string|
                                                                                                                                                                                                                                                                                                                                                               Documents::closure81(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    v3.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    true,
                                                                                                                                                                                                                                                                                                                                                                                    v_6)
                                                                                                                                                                                                                                                                                                                                                       }))(b0)(b1)
                                                                    }),
                                                                    LrcPtr::new(
                                                                        Documents::UH5::UH5_0,
                                                                    ),
                                                                )),
                                                            )),
                                                        )),
                                                    )),
                                                )),
                                            )),
                                            LrcPtr::new(Documents::UH4::UH4_0),
                                        )),
                                    ))
                                }
                            } else {
                                let v819: () = {
                                    Documents::closure71(
                                        v179,
                                        v180.clone(),
                                        v182,
                                        v207,
                                        v206,
                                        v209.clone(),
                                        v234,
                                        v233,
                                        v236.clone(),
                                        v416,
                                        v583.clone(),
                                        (),
                                    );
                                    ()
                                };
                                Documents::method148(v236, v209.clone());
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    LrcPtr::new(Documents::UH5::UH5_1(
                                        string("hangul.md"),
                                        v209.clone(),
                                        Func2::new({
                                            let v0_1 = v0_1.clone();
                                            let v1_1 = v1_1.clone();
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v0_1 = v0_1.clone();
                                                    let v1_1 = v1_1.clone();
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_7: string| {
                                                        Documents::closure76(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            v1_1.clone(),
                                                            v0_1.clone(),
                                                            v_7,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        LrcPtr::new(Documents::UH5::UH5_0),
                                    )),
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("html"),
                                            v209.clone(),
                                            Func2::new({
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v_8: string| {
                                                            Documents::closure81(
                                                                v4.clone(),
                                                                v3.clone(),
                                                                false,
                                                                v_8,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("pdf"),
                                                v209.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_9: string| {
                                                                Documents::closure81(
                                                                    v4.clone(),
                                                                    v3.clone(),
                                                                    false,
                                                                    v_9,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                    string("epub"),
                                                    v209.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_10: string| {
                                                                    Documents::closure81(
                                                                        v4.clone(),
                                                                        v3.clone(),
                                                                        false,
                                                                        v_10,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH5::UH5_1(
                                                        string("html"),
                                                        v238.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_11: string| {
                                                                        Documents::closure81(
                                                                            v4.clone(),
                                                                            v3.clone(),
                                                                            true,
                                                                            v_11,
                                                                        )
                                                                    }
                                                                }))(
                                                                    b0
                                                                )(
                                                                    b1
                                                                )
                                                            }
                                                        }),
                                                        LrcPtr::new(Documents::UH5::UH5_1(
                                                            string("pdf"),
                                                            v238.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_12: string| {
                                                                            Documents::closure81(
                                                                                v4.clone(),
                                                                                v3.clone(),
                                                                                true,
                                                                                v_12,
                                                                            )
                                                                        }
                                                                    }))(
                                                                        b0
                                                                    )(
                                                                        b1
                                                                    )
                                                                }
                                                            }),
                                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                                string("epub"),
                                                                v238.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_13: string| {
                                                                                Documents::closure81(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
                                                                                    true,
                                                                                    v_13,
                                                                                )
                                                                            }
                                                                        }))(
                                                                            b0
                                                                        )(
                                                                            b1
                                                                        )
                                                                    }
                                                                }),
                                                                LrcPtr::new(Documents::UH5::UH5_0),
                                                            )),
                                                        )),
                                                    )),
                                                )),
                                            )),
                                        )),
                                        LrcPtr::new(Documents::UH4::UH4_0),
                                    )),
                                ))
                            }
                        }
                    }
                }
            };
            let v1860: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method164(
                if (if let Documents::UH4::UH4_0 = v911.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v911
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method143(string("epub"), v238.clone(), v4.clone());
                    let v916: string = patternInput_3.1.clone();
                    let v915: string = patternInput_3.0.clone();
                    let v1049: LrcPtr<Documents::UH5> = if if Documents::method28(v915.clone()) {
                        true
                    } else {
                        if (Documents::method28(v916.clone())) == false {
                            true
                        } else {
                            let v982: () = {
                                Documents::closure84(v916.clone(), v915.clone(), ());
                                ()
                            };
                            Documents::method148(v915, v916);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v238.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_14: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_14)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            LrcPtr::new(Documents::UH5::UH5_0),
                        ))
                    } else {
                        LrcPtr::new(Documents::UH5::UH5_0)
                    };
                    let patternInput_4: (string, string) =
                        Documents::method143(string("pdf"), v238.clone(), v4.clone());
                    let v1052: string = patternInput_4.1.clone();
                    let v1051: string = patternInput_4.0.clone();
                    let v1183: LrcPtr<Documents::UH5> = if if Documents::method28(v1051.clone()) {
                        true
                    } else {
                        if (Documents::method28(v1052.clone())) == false {
                            true
                        } else {
                            let v1118: () = {
                                Documents::closure84(v1052.clone(), v1051.clone(), ());
                                ()
                            };
                            Documents::method148(v1051, v1052);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v238.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_15: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_15)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v1049.clone(),
                        ))
                    } else {
                        v1049
                    };
                    let patternInput_5: (string, string) =
                        Documents::method143(string("html"), v238.clone(), v4.clone());
                    let v1186: string = patternInput_5.1.clone();
                    let v1185: string = patternInput_5.0.clone();
                    let v1317: LrcPtr<Documents::UH5> = if if Documents::method28(v1185.clone()) {
                        true
                    } else {
                        if (Documents::method28(v1186.clone())) == false {
                            true
                        } else {
                            let v1252: () = {
                                Documents::closure84(v1186.clone(), v1185.clone(), ());
                                ()
                            };
                            Documents::method148(v1185, v1186);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v238,
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_16: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_16)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v1183.clone(),
                        ))
                    } else {
                        v1183
                    };
                    let patternInput_6: (string, string) =
                        Documents::method143(string("epub"), v209.clone(), v4.clone());
                    let v1319: string = patternInput_6.1.clone();
                    let v1318: string = patternInput_6.0.clone();
                    let v1450: LrcPtr<Documents::UH5> = if if Documents::method28(v1318.clone()) {
                        true
                    } else {
                        if (Documents::method28(v1319.clone())) == false {
                            true
                        } else {
                            let v1385: () = {
                                Documents::closure84(v1319.clone(), v1318.clone(), ());
                                ()
                            };
                            Documents::method148(v1318, v1319);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v209.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_17: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v1317.clone(),
                        ))
                    } else {
                        v1317
                    };
                    let patternInput_7: (string, string) =
                        Documents::method143(string("pdf"), v209.clone(), v4.clone());
                    let v1452: string = patternInput_7.1.clone();
                    let v1451: string = patternInput_7.0.clone();
                    let v1583: LrcPtr<Documents::UH5> = if if Documents::method28(v1451.clone()) {
                        true
                    } else {
                        if (Documents::method28(v1452.clone())) == false {
                            true
                        } else {
                            let v1518: () = {
                                Documents::closure84(v1452.clone(), v1451.clone(), ());
                                ()
                            };
                            Documents::method148(v1451, v1452);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v209.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_18: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v1450.clone(),
                        ))
                    } else {
                        v1450
                    };
                    let patternInput_8: (string, string) =
                        Documents::method143(string("html"), v209.clone(), v4.clone());
                    let v1585: string = patternInput_8.1.clone();
                    let v1584: string = patternInput_8.0.clone();
                    let v1716: LrcPtr<Documents::UH5> = if if Documents::method28(v1584.clone()) {
                        true
                    } else {
                        if (Documents::method28(v1585.clone())) == false {
                            true
                        } else {
                            let v1651: () = {
                                Documents::closure84(v1585.clone(), v1584.clone(), ());
                                ()
                            };
                            Documents::method148(v1584, v1585);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v209.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_19: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v1583.clone(),
                        ))
                    } else {
                        v1583
                    };
                    let patternInput_9: (string, string) =
                        Documents::method143(string("hangul.md"), v209.clone(), v4.clone());
                    let v1718: string = patternInput_9.1.clone();
                    let v1717: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method28(v1717.clone()) {
                            true
                        } else {
                            if (Documents::method28(v1718.clone())) == false {
                                true
                            } else {
                                let v1784: () = {
                                    Documents::closure84(v1718.clone(), v1717.clone(), ());
                                    ()
                                };
                                Documents::method148(v1717, v1718);
                                false
                            }
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("hangul.md"),
                                v209,
                                Func2::new({
                                    let v0_1 = v0_1.clone();
                                    let v1_1 = v1_1.clone();
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v0_1 = v0_1.clone();
                                            let v1_1 = v1_1.clone();
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_20: string| {
                                                Documents::closure76(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    v1_1.clone(),
                                                    v0_1.clone(),
                                                    v_20,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                LrcPtr::new(Documents::UH5::UH5_0),
                            ))
                        } else {
                            LrcPtr::new(Documents::UH5::UH5_0)
                        },
                        LrcPtr::new(Documents::UH4::UH4_1(
                            v1716,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v1864: Vec<LrcPtr<Documents::UH5>> = v1860.to_vec();
            let v1867: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v1871: List<LrcPtr<Documents::UH5>> =
                ofArray(fable_library_rust::NativeArray_::array_from(v1864.clone()));
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((
                v180,
                Documents::method166(
                    foldBack(
                        Func2::new(
                            move |b0: LrcPtr<Documents::UH5>, b1: LrcPtr<Documents::UH4>| {
                                (Documents::method165())(b0)(b1)
                            },
                        ),
                        v1871,
                        LrcPtr::new(Documents::UH4::UH4_0),
                    ),
                    v1867,
                ),
            )))
        }
        pub fn method23(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
        ) -> std::pin::Pin<
            Box<
                dyn std::future::Future<
                        Output = Result<
                            Vec<
                                Result<
                                    LrcPtr<(
                                        string,
                                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                    )>,
                                    std::string::String,
                                >,
                            >,
                            std::string::String,
                        >,
                    >,
            >,
        > {
            let v5: Documents::US5 = Documents::method25(Documents::method24());
            let v11: Documents::US5 = match &v5 {
                Documents::US5::US5_0(v5_0_0) => Documents::US5::US5_0(
                    match &v5 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method25(string(
                    "c:\\home\\git\\polyglot\\target\\Builder\\documents",
                )),
            };
            let v17: Documents::US5 = match &v11 {
                Documents::US5::US5_0(v11_0_0) => Documents::US5::US5_0(
                    match &v11 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method25(string("/workspaces")),
            };
            let v21: string = match &v17 {
                Documents::US5::US5_0(v17_0_0) => match &v17 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v36: string = Documents::method26(
                if string("deps") == (Documents::method43(v21.clone())) {
                    let v29: Documents::US5 =
                        Documents::method25(Documents::method31(v21.clone()).clone().unwrap());
                    match &v29 {
                        Documents::US5::US5_0(v29_0_0) => match &v29 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => panic!("{}", string("Option does not have a value."),),
                    }
                } else {
                    v21
                },
                string("polyglot"),
            );
            let v37: string = Documents::method56(v3);
            let v38: string = Documents::method56(v2);
            let v39: string = Documents::method56(v1_1);
            let v102: () = {
                Documents::closure24(v0_1.clone(), v37.clone(), v38.clone(), v39.clone(), ());
                ()
            };
            let v164: bool = true;
            let __future_init = Box::pin(
                /*;
                let v166: bool = */
                async move {
                    /*;
                    let v168: bool = */
                    ();
                    let v170: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v38.clone());
                    let v173: async_walkdir::WalkDir =
                        async_walkdir::WalkDir::filter(v170, move |x| {
                            Func1::new(move |v: async_walkdir::DirEntry| {
                                Documents::closure25((), v)
                            })(x)
                        });
                    let v174 = Documents::method66();
                    let v176 = futures::stream::StreamExt::filter_map(v173, |x| async { v174(x) });
                    let v178: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                        Box::pin(futures::stream::StreamExt::collect(v176));
                    let v180: Vec<string> = v178.await;
                    let v245: () = {
                        Documents::closure34(v180.clone(), ());
                        ()
                    };
                    let v309: rayon::vec::IntoIter<string> =
                        rayon::iter::IntoParallelIterator::into_par_iter(v180);
                    let v312: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                        rayon::iter::ParallelIterator::map(v309, |x| {
                            Func1::new({
                                let v0_1 = v0_1.clone();
                                let v36 = v36.clone();
                                let v37 = v37.clone();
                                let v38 = v38.clone();
                                let v39 = v39.clone();
                                move |v_1: string| {
                                    Documents::closure35(
                                        v0_1.clone(),
                                        v36.clone(),
                                        v37.clone(),
                                        v38.clone(),
                                        v39.clone(),
                                        v_1,
                                    )
                                }
                            })(x)
                        });
                    let v314: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = rayon::iter::ParallelIterator::collect(v312);
                    let v321: string = string("}");
                    let v326: bool = true;
                    let _fix_closure_v323 = Ok::<
                        Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        >,
                        std::string::String,
                    >(v314);
                    let v333: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v323 "), (v321))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v334: bool = true;
                    _fix_closure_v323
                },
            ); // rust.fix_closure';
            let v336 = __future_init;
            v336
        }
        pub fn closure88(
            unitVar: (),
            v0_1: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
        ) -> Documents::US37 {
            Documents::US37::US37_0(v0_1)
        }
        pub fn method170() -> Func1<
            Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            Documents::US37,
        > {
            Func1::new(
                move |v: Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >| Documents::closure88((), v),
            )
        }
        pub fn closure89(unitVar: (), v0_1: std::string::String) -> Documents::US37 {
            Documents::US37::US37_1(v0_1)
        }
        pub fn method171() -> Func1<std::string::String, Documents::US37> {
            Func1::new(move |v: std::string::String| Documents::closure89((), v))
        }
        pub fn method172(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("error"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v74: std::string::String = format!("{:#?}", v8);
            let v118: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v74),
                    (),
                );
                ()
            };
            let v137: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v143: string = v10.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v143),
            ))
        }
        pub fn closure90(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v19: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method172(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Documents::method8(v40, v41, v42, v43, v44, v45),
                    Documents::method70(),
                    v0_1,
                ))
            };
        }
        pub fn method173(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: usize,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("result_len"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v74: std::string::String = format!("{:#?}", v8);
            let v118: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v74),
                    (),
                );
                ()
            };
            let v137: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v143: string = v10.l0.get().clone();
            Documents::method16(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v143),
            ))
        }
        pub fn closure91(
            v0_1: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            unitVar: (),
        ) {
            if Documents::method7(Documents::US0::US0_2) {
                let v19: () = {
                    Documents::closure6((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method17(Documents::method173(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Documents::method8(v40, v41, v42, v43, v44, v45),
                    Documents::method12(),
                    v0_1.len(),
                ))
            };
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v17: () = {
                Documents::closure2((), ());
                ()
            };
            let v94: () = {
                Documents::closure5(v0_1, ());
                ()
            };
            let v155: clap::Command = Documents::method0();
            let v157: clap::ArgMatches = clap::Command::get_matches(v155);
            let v158: string = Documents::method18();
            let v165: &str = &*v158;
            let v193: Option<std::string::String> =
                clap::ArgMatches::get_one(&v157.clone(), v165).cloned();
            let v218: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method19(), v193));
            let v225: std::string::String = match &v218 {
                Documents::US6::US6_0(v218_0_0) => match &v218 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v227: string = fable_library_rust::String_::fromString(v225);
            let v228: string = Documents::method20();
            let v235: &str = &*v228;
            let v263: Option<std::string::String> =
                clap::ArgMatches::get_one(&v157.clone(), v235).cloned();
            let v288: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method19(), v263));
            let v295: std::string::String = match &v288 {
                Documents::US6::US6_0(v288_0_0) => match &v288 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v297: string = fable_library_rust::String_::fromString(v295);
            let v298: string = Documents::method21();
            let v305: &str = &*v298;
            let v333: Option<std::string::String> =
                clap::ArgMatches::get_one(&v157.clone(), v305).cloned();
            let v358: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method19(), v333));
            let v365: std::string::String = match &v358 {
                Documents::US6::US6_0(v358_0_0) => match &v358 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v367: string = fable_library_rust::String_::fromString(v365);
            let v368: string = Documents::method22();
            let v375: &str = &*v368;
            let v403: Option<std::string::String> = clap::ArgMatches::get_one(&v157, v375).cloned();
            let v428: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method19(), v403));
            let v435: std::string::String = match &v428 {
                Documents::US6::US6_0(v428_0_0) => match &v428 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v438: std::pin::Pin<
                Box<
                    dyn std::future::Future<
                            Output = Result<
                                Vec<
                                    Result<
                                        LrcPtr<(
                                            string,
                                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                        )>,
                                        std::string::String,
                                    >,
                                >,
                                std::string::String,
                            >,
                        >,
                >,
            > = Documents::method23(
                fable_library_rust::String_::fromString(v435),
                v367,
                v297,
                v227,
            );
            let v440: Result<
                Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >,
                std::string::String,
            > = futures::executor::block_on(v438);
            let v441 = Documents::method170();
            let v442 = Documents::method171();
            let v444: Documents::US37 = match &v440 {
                Err(v440_1_0) => v442(v440_1_0.clone()),
                Ok(v440_0_0) => v441(v440_0_0.clone()),
            };
            match &v444 {
                Documents::US37::US37_0(v444_0_0) => {
                    let v512: () = {
                        Documents::closure91(v444_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US37::US37_1(v444_1_0) => {
                    let v638: () = {
                        Documents::closure90(v444_1_0.clone(), ());
                        ()
                    };
                    1_i32
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Documents::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Documents::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Documents::closure1((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Documents::v1())(args)
        }
    }
}
pub use module_b8cdef03::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/async_.rs"]
mod module_763b9e6c;
pub use module_763b9e6c::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/common.rs"]
mod module_18f1c018;
pub use module_18f1c018::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/crypto.rs"]
mod module_c0301e36;
pub use module_c0301e36::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/date_time.rs"]
mod module_e5abed0b;
pub use module_e5abed0b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/file_system.rs"]
mod module_336d1dc9;
pub use module_336d1dc9::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/lib.rs"]
mod module_12dde172;
pub use module_12dde172::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/networking.rs"]
mod module_7e35832b;
pub use module_7e35832b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/platform.rs"]
mod module_afd02cca;
pub use module_afd02cca::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/runtime.rs"]
mod module_a3c64389;
pub use module_a3c64389::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/sm.rs"]
mod module_8f227ecb;
pub use module_8f227ecb::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/threading.rs"]
mod module_e08c16fb;
pub use module_e08c16fb::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/trace.rs"]
mod module_702ddcb4;
pub use module_702ddcb4::*;
#[path = "../../deps/polyglot/lib/fsharp/Common.rs"]
mod module_eb7e4788;
pub use module_eb7e4788::*;
pub mod Polyglot {
    pub use crate::module_eb7e4788::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Documents::main(array_from(args));
}
