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
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::getNull;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
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
            let v6: string = Documents::method4(v0_1);
            let v8: Result<std::string::String, std::env::VarError> = std::env::var(&*v6);
            let v10: bool = true;
            let _result_map_ = v8.map(|x| {
                //;
                let v12: std::string::String = x;
                let v14: string = fable_library_rust::String_::fromString(v12);
                let v16: bool = true;
                v14
            });
            let v18: Result<string, std::env::VarError> = _result_map_;
            let v19: string = Documents::method5();
            v18.unwrap_or(v19)
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
            let v3: () = {
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
            let v42: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
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
                    v42,
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
            let v198: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method9(), v5));
            let v316: DateTime = match &v198 {
                Documents::US2::US2_0(v198_0_0) => {
                    let v268: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v198 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v268.hours(),
                        v268.minutes(),
                        v268.seconds(),
                        v268.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v318: string = Documents::method10();
            let provider: string = if (v318.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v318
            };
            v316.toString(provider)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v3);
            ()
        }
        pub fn method13(v0_1: char) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method15() -> string {
            string("\u{001b}[0m")
        }
        pub fn method12() -> string {
            let v8: string = Documents::method13(getCharAt(toLower(string("Info")), 0_i32));
            let v15: &str = inline_colorization::color_bright_green;
            let v22: &str = &*v8;
            let v50: &str = inline_colorization::color_reset;
            let v52: std::string::String = format!("{}{}{}", v15, v22, v50);
            fable_library_rust::String_::fromString(v52)
        }
        pub fn method17(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v2.clone(), string("args"), ());
                ()
            };
            let v33: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v46: () = {
                Documents::closure8(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v57: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method18(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method16(
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
            let v9: string = Documents::method17(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
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
            let v3: () = {
                Documents::closure11(v0_1, ());
                ()
            };
            ()
        }
        pub fn method19(v0_1: string) {
            let v3: () = {
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
            let v44: () = {
                Documents::closure9(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v5: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method16(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method12(),
                    v0_1,
                ))
            };
        }
        pub fn method20() -> string {
            string("source-dir")
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn method21() -> Func1<std::string::String, Documents::US6> {
            Func1::new(move |v: std::string::String| Documents::closure12((), v))
        }
        pub fn method22() -> string {
            string("dist-dir")
        }
        pub fn method23() -> string {
            string("cache-dir")
        }
        pub fn method24() -> string {
            string("hangul-spec")
        }
        pub fn method26() -> string {
            let v6: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v10: std::path::PathBuf = v6.unwrap();
            let v28: std::path::Display = v10.display();
            let v61: std::string::String = format!("{}", v28);
            fable_library_rust::String_::fromString(v61)
        }
        pub fn method28(v0_1: string, v1_1: string) -> string {
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
        pub fn method30(v0_1: string) -> bool {
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
            Documents::method30(v0_1)
        }
        pub fn method31(v0_1: string) -> bool {
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
            Documents::method31(v0_1)
        }
        pub fn method33(v0_1: string) -> Option<string> {
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
        pub fn method34(
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
            '_method34: loop {
                break '_method34 (if v3(Documents::method28(v4.get().clone(), v0_1.get().clone())) {
                    Documents::US8::US8_0(v4.get().clone())
                } else {
                    let v8: Option<string> = Documents::method33(v4.get().clone());
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
                            continue '_method34;
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
        pub fn method32(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
        ) -> Documents::US8 {
            if v3(Documents::method28(v1_1.clone(), v0_1.clone())) {
                Documents::US8::US8_0(v1_1.clone())
            } else {
                let v7: Option<string> = Documents::method33(v1_1.clone());
                let v32: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method6(), v7));
                match &v32 {
                    Documents::US5::US5_0(v32_0_0) => Documents::method34(
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
        pub fn method29(v0_1: Documents::US7, v1_1: string, v2: string) -> Documents::US8 {
            let v3: bool = if let Documents::US7::US7_0 = &v0_1 {
                true
            } else {
                false
            };
            Documents::method32(
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
        pub fn method35() -> string {
            let v8: string = Documents::method13(getCharAt(toLower(string("Warning")), 0_i32));
            let v15: &str = inline_colorization::color_yellow;
            let v22: &str = &*v8;
            let v50: &str = inline_colorization::color_reset;
            let v52: std::string::String = format!("{}{}{}", v15, v22, v50);
            fable_library_rust::String_::fromString(v52)
        }
        pub fn method37(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v23: () = {
                Documents::closure8(v3.clone(), string("dir"), ());
                ()
            };
            let v34: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v65: () = {
                Documents::closure8(v3.clone(), string("error"), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method36(
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
            let v10: string = Documents::method37(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.get_workspace_root"),
                v10
            ))
        }
        pub fn closure15(v0_1: string, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v6: () = {
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
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method36(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method35(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method42(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: std::string::String = format!("{:#?}", v0_1);
            let v48: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v9), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure16(unitVar: (), v0_1: std::io::Error) -> string {
            Documents::method42(v0_1)
        }
        pub fn method41() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Documents::closure16((), v))
        }
        pub fn closure17(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn method43() -> Func1<std::path::PathBuf, Documents::US9> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure17((), v))
        }
        pub fn closure18(unitVar: (), v0_1: string) -> Documents::US9 {
            Documents::US9::US9_1(v0_1)
        }
        pub fn method44() -> Func1<string, Documents::US9> {
            Func1::new(move |v: string| Documents::closure18((), v))
        }
        pub fn method47(v0_1: string) -> string {
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
        pub fn method48(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v9: () = {
                Documents::closure8(v2.clone(), v0_1, ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method46(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method47(v4.clone());
            let v6: Option<string> = Documents::method33(v4.clone());
            let v31: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v35: string = Documents::method48(v3);
            if (v2) >= 11_u8 {
                let v39: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v46: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v39);
                Err(v46)
            } else {
                if let Documents::US5::US5_0(v31_0_0) = &v31 {
                    if (v4.clone()) != string("") {
                        let v97: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v31_0_0.clone());
                        let v98 = Documents::method41();
                        let v111: Result<std::path::PathBuf, string> = v97.map_err(|x| v98(x));
                        let v114 = Documents::method43();
                        let v115 = Documents::method44();
                        let v117: Documents::US9 = match &v111 {
                            Err(v111_1_0) => v115(v111_1_0.clone()),
                            Ok(v111_0_0) => v114(v111_0_0.clone()),
                        };
                        match &v117 {
                            Documents::US9::US9_0(v117_0_0) => {
                                let v158: string = Documents::method28(
                                    toString(v117_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v165: &str = &*v158;
                                let v198: std::string::String = String::from(v165);
                                let v231: std::path::PathBuf = std::path::PathBuf::from(v198);
                                Ok(v231)
                            }
                            Documents::US9::US9_1(v117_1_0) => {
                                let v276: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v117_1_0.clone(),
                                        v35.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v283: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v276);
                                Err(v283)
                            }
                        }
                    } else {
                        let v329: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v35.clone(),
                                            v4.clone(), v5.clone()));
                        let v336: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v329);
                        Err(v336)
                    }
                } else {
                    let v381: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1, v35.clone(), v4, v5.clone()));
                    let v388: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v381);
                    Err(v388)
                }
            }
        }
        pub fn method45(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v9: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v10 = Documents::method41();
            let v23: Result<std::path::PathBuf, string> = v9.map_err(|x| v10(x));
            let v26 = Documents::method43();
            let v27 = Documents::method44();
            let v29: Documents::US9 = match &v23 {
                Err(v23_1_0) => v27(v23_1_0.clone()),
                Ok(v23_0_0) => v26(v23_0_0.clone()),
            };
            match &v29 {
                Documents::US9::US9_0(v29_0_0) => Ok(v29_0_0.clone()),
                Documents::US9::US9_1(v29_1_0) => Documents::method46(
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
            Documents::method45(v0_1, v1_1, v2)
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
        pub fn method49(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method47(v0_1.clone());
            let v5: Option<string> = Documents::method33(v0_1.clone());
            let v30: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v34: string = Documents::method48(v3);
            if (v2) >= 11_u8 {
                let v38: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v45: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v38);
                Err(v45)
            } else {
                if let Documents::US5::US5_0(v30_0_0) = &v30 {
                    if (v0_1.clone()) != string("") {
                        let v96: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v30_0_0.clone());
                        let v97 = Documents::method41();
                        let v110: Result<std::path::PathBuf, string> = v96.map_err(|x| v97(x));
                        let v113 = Documents::method43();
                        let v114 = Documents::method44();
                        let v116: Documents::US9 = match &v110 {
                            Err(v110_1_0) => v114(v110_1_0.clone()),
                            Ok(v110_0_0) => v113(v110_0_0.clone()),
                        };
                        match &v116 {
                            Documents::US9::US9_0(v116_0_0) => {
                                let v157: string = Documents::method28(
                                    toString(v116_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v164: &str = &*v157;
                                let v197: std::string::String = String::from(v164);
                                let v230: std::path::PathBuf = std::path::PathBuf::from(v197);
                                Ok(v230)
                            }
                            Documents::US9::US9_1(v116_1_0) => {
                                let v275: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v116_1_0.clone(),
                                        v34.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v282: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v275);
                                Err(v282)
                            }
                        }
                    } else {
                        let v328: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v34.clone(),
                                            v0_1.clone(), v4.clone()));
                        let v335: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v328);
                        Err(v335)
                    }
                } else {
                    let v380: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v34.clone(), v0_1,
                                        v4.clone()));
                    let v387: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v380);
                    Err(v387)
                }
            }
        }
        pub fn method40(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v8: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v9 = Documents::method41();
            let v22: Result<std::path::PathBuf, string> = v8.map_err(|x| v9(x));
            let v25 = Documents::method43();
            let v26 = Documents::method44();
            let v28: Documents::US9 = match &v22 {
                Err(v22_1_0) => v26(v22_1_0.clone()),
                Ok(v22_0_0) => v25(v22_0_0.clone()),
            };
            match &v28 {
                Documents::US9::US9_0(v28_0_0) => Ok(v28_0_0.clone()),
                Documents::US9::US9_1(v28_1_0) => Documents::method49(
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
        pub fn method51(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method52() -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method53(v0_1: i32, v1_1: i32) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method55(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method47(v4.clone());
            let v6: Option<string> = Documents::method33(v4.clone());
            let v31: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v35: string = Documents::method42(v3);
            if (v2) >= 11_u8 {
                let v39: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v46: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v39);
                Err(v46)
            } else {
                if let Documents::US5::US5_0(v31_0_0) = &v31 {
                    if (v4.clone()) != string("") {
                        let v97: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v31_0_0.clone());
                        let v98 = Documents::method41();
                        let v111: Result<std::path::PathBuf, string> = v97.map_err(|x| v98(x));
                        let v114 = Documents::method43();
                        let v115 = Documents::method44();
                        let v117: Documents::US9 = match &v111 {
                            Err(v111_1_0) => v115(v111_1_0.clone()),
                            Ok(v111_0_0) => v114(v111_0_0.clone()),
                        };
                        match &v117 {
                            Documents::US9::US9_0(v117_0_0) => {
                                let v158: string = Documents::method28(
                                    toString(v117_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v165: &str = &*v158;
                                let v198: std::string::String = String::from(v165);
                                let v231: std::path::PathBuf = std::path::PathBuf::from(v198);
                                Ok(v231)
                            }
                            Documents::US9::US9_1(v117_1_0) => {
                                let v276: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v117_1_0.clone(),
                                        v35.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v283: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v276);
                                Err(v283)
                            }
                        }
                    } else {
                        let v329: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v35.clone(),
                                            v4.clone(), v5.clone()));
                        let v336: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v329);
                        Err(v336)
                    }
                } else {
                    let v381: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1, v35.clone(), v4, v5.clone()));
                    let v388: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v381);
                    Err(v388)
                }
            }
        }
        pub fn method54(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v42: i32 =
                Documents::method51(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v44: bool = Documents::method53(Documents::method52(), v42);
            if v44 {
                let v51: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v122: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v122)
            } else {
                let v144: string =
                    append(string("file_system.read_link / Fsharp / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / result: {} / path\': {} / n: {}",
                                    v0_1.clone(), v44, v2.clone(), v1_1));
                Documents::method55(
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
            Documents::method54(v0_1, v1_1, v2)
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
        pub fn method56(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method47(v0_1.clone());
            let v5: Option<string> = Documents::method33(v0_1.clone());
            let v30: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v34: string = Documents::method42(v3);
            if (v2) >= 11_u8 {
                let v38: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v45: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v38);
                Err(v45)
            } else {
                if let Documents::US5::US5_0(v30_0_0) = &v30 {
                    if (v0_1.clone()) != string("") {
                        let v96: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v30_0_0.clone());
                        let v97 = Documents::method41();
                        let v110: Result<std::path::PathBuf, string> = v96.map_err(|x| v97(x));
                        let v113 = Documents::method43();
                        let v114 = Documents::method44();
                        let v116: Documents::US9 = match &v110 {
                            Err(v110_1_0) => v114(v110_1_0.clone()),
                            Ok(v110_0_0) => v113(v110_0_0.clone()),
                        };
                        match &v116 {
                            Documents::US9::US9_0(v116_0_0) => {
                                let v157: string = Documents::method28(
                                    toString(v116_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v164: &str = &*v157;
                                let v197: std::string::String = String::from(v164);
                                let v230: std::path::PathBuf = std::path::PathBuf::from(v197);
                                Ok(v230)
                            }
                            Documents::US9::US9_1(v116_1_0) => {
                                let v275: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v116_1_0.clone(),
                                        v34.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v282: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v275);
                                Err(v282)
                            }
                        }
                    } else {
                        let v328: string =
                            append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                                   sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                            v0_1.clone(), v34.clone(),
                                            v0_1.clone(), v4.clone()));
                        let v335: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v328);
                        Err(v335)
                    }
                } else {
                    let v380: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v34.clone(), v0_1,
                                        v4.clone()));
                    let v387: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v380);
                    Err(v387)
                }
            }
        }
        pub fn method50(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v41: i32 =
                Documents::method51(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v43: bool = Documents::method53(Documents::method52(), v41);
            if v43 {
                let v50: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v121: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v121)
            } else {
                let v143: string =
                    append(string("file_system.read_link / Fsharp / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / result: {} / path\': {} / n: {}",
                                    v0_1.clone(), v43, v0_1.clone(), v1_1));
                Documents::method56(
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
        pub fn method39(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Documents::method31(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Documents::method40(v0_1, 0_u8)
            }
        }
        pub fn closure23(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn method57() -> Func1<std::path::PathBuf, Documents::US10> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure23((), v))
        }
        pub fn method59(v0_1: string) -> string {
            v0_1
        }
        pub fn method60() -> string {
            string("")
        }
        pub fn method58(v0_1: string, v1_1: string, v2: string) -> string {
            let v6: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v10: regex::Regex = v6.unwrap();
            let v22: string = Documents::method59(v2);
            let v24: std::borrow::Cow<str> = v10.replace_all(&*v22, &*v1_1);
            let v26: std::string::String = String::from(v24);
            fable_library_rust::String_::fromString(v26)
        }
        pub fn method38(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method39(v0_1.clone());
                let v7: Option<std::path::PathBuf> = v3.ok();
                let v43: Documents::US10 =
                    defaultValue(Documents::US10::US10_1, map(Documents::method57(), v7));
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
                let v91: string = Documents::method58(
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
        pub fn method27(v0_1: string) -> Documents::US5 {
            let v5: Documents::US8 = Documents::method29(
                Documents::US7::US7_1,
                Documents::method28(string("spiral"), string("workspace")),
                v0_1.clone(),
            );
            match &v5 {
                Documents::US8::US8_0(v5_0_0) => {
                    Documents::US5::US5_0(Documents::method38(v5_0_0.clone()))
                }
                Documents::US8::US8_1(v5_1_0) => {
                    let v12: () = {
                        Documents::closure15(v0_1.clone(), v5_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            }
        }
        pub fn method62(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method63(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method64() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method65(v0_1: string) -> string {
            v0_1
        }
        pub fn method61(v0_1: string) -> string {
            let v12: &str = &*v0_1.clone();
            let v45: std::string::String = String::from(v12);
            let v78: std::path::PathBuf = std::path::PathBuf::from(v45);
            if (v78.exists()) == false {
                let v108: string = Documents::method26();
                let v119: Array<string> = split(
                    Documents::method38(Documents::method28(v108.clone(), v0_1.clone())),
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
                while Documents::method62(v123, v124.clone()) {
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
                                    while Documents::method63(v147, v149.clone()) {
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
                                    while Documents::method63(v161, v163.clone()) {
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
                    let v200: string = ofChar(Documents::method64());
                    join(
                        if (v200.clone()) == string("\n") {
                            Documents::method65(v200.clone())
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
        pub fn method66() -> string {
            let v8: string = Documents::method13(getCharAt(toLower(string("Debug")), 0_i32));
            let v15: &str = inline_colorization::color_bright_blue;
            let v22: &str = &*v8;
            let v50: &str = inline_colorization::color_reset;
            let v52: std::string::String = format!("{}{}{}", v15, v22, v50);
            fable_library_rust::String_::fromString(v52)
        }
        pub fn method68(v0_1: string, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v14: () = {
                Documents::closure8(v5.clone(), string("{ "), ());
                ()
            };
            let v25: () = {
                Documents::closure8(v5.clone(), string("source_dir"), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v5.clone(), v0_1, ());
                ()
            };
            let v56: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v67: () = {
                Documents::closure8(v5.clone(), string("dist_dir"), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v85: () = {
                Documents::closure8(v5.clone(), v1_1, ());
                ()
            };
            let v94: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v105: () = {
                Documents::closure8(v5.clone(), string("cache_dir"), ());
                ()
            };
            let v114: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v123: () = {
                Documents::closure8(v5.clone(), v2, ());
                ()
            };
            let v132: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v143: () = {
                Documents::closure8(v5.clone(), string("hangul_spec"), ());
                ()
            };
            let v152: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v161: () = {
                Documents::closure8(v5.clone(), v3, ());
                ()
            };
            let v172: () = {
                Documents::closure8(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method67(
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
            let v12: string = Documents::method68(v8, v9, v10, v11);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v12
            ))
        }
        pub fn closure24(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v8: () = {
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
                let v34: Option<i64> = patternInput.5.clone();
                let v33: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v32: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v31: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v30: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v29: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method67(
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    v34.clone(),
                    Documents::method8(v29, v30, v31, v32, v33, v34),
                    Documents::method66(),
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
        pub fn method69() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure26((), v))
        }
        pub fn closure27(unitVar: (), v0_1: std::fs::FileType) -> Documents::US11 {
            Documents::US11::US11_0(v0_1)
        }
        pub fn method70() -> Func1<std::fs::FileType, Documents::US11> {
            Func1::new(move |v: std::fs::FileType| Documents::closure27((), v))
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Documents::US11 {
            Documents::US11::US11_1(v0_1)
        }
        pub fn method71() -> Func1<std::string::String, Documents::US11> {
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
                            let v19 = Documents::method69();
                            let v32: Result<std::fs::FileType, std::string::String> =
                                v18.map_err(|x| v19(x));
                            let v35 = Documents::method70();
                            let v36 = Documents::method71();
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
        pub fn method73() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure30((), v))
        }
        pub fn closure31(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US13 {
            Documents::US13::US13_0(v0_1)
        }
        pub fn method74() -> Func1<async_walkdir::DirEntry, Documents::US13> {
            Func1::new(move |v: async_walkdir::DirEntry| Documents::closure31((), v))
        }
        pub fn closure32(unitVar: (), v0_1: std::string::String) -> Documents::US13 {
            Documents::US13::US13_1(v0_1)
        }
        pub fn method75() -> Func1<std::string::String, Documents::US13> {
            Func1::new(move |v: std::string::String| Documents::closure32((), v))
        }
        pub fn method76() -> string {
            let v8: string = Documents::method13(getCharAt(toLower(string("Critical")), 0_i32));
            let v15: &str = inline_colorization::color_bright_red;
            let v22: &str = &*v8;
            let v50: &str = inline_colorization::color_reset;
            let v52: std::string::String = format!("{}{}{}", v15, v22, v50);
            fable_library_rust::String_::fromString(v52)
        }
        pub fn method78(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v2.clone(), string("error"), ());
                ()
            };
            let v33: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v42: std::string::String = format!("{:#?}", v0_1);
            let v81: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v42), ());
                ()
            };
            let v92: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method77(
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
            let v9: string = Documents::method78(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / stream_filter_map"),
                v9
            ))
        }
        pub fn closure33(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v5: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method77(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method76(),
                    v0_1,
                ))
            };
        }
        pub fn closure29(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method73();
            let v14: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v17 = Documents::method74();
            let v18 = Documents::method75();
            let v20: Documents::US13 = match &v14 {
                Err(v14_1_0) => v18(v14_1_0.clone()),
                Ok(v14_0_0) => v17(v14_0_0.clone()),
            };
            let v147: Documents::US5 = match &v20 {
                Documents::US13::US13_0(v20_0_0) => {
                    let v25: std::path::PathBuf = async_walkdir::DirEntry::path(&v20_0_0.clone());
                    let v32: std::path::Display = v25.display();
                    let v65: std::string::String = format!("{}", v32);
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(v65))
                }
                Documents::US13::US13_1(v20_1_0) => {
                    let v98: () = {
                        Documents::closure33(v20_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v147 {
                Documents::US5::US5_0(v147_0_0) => Some(
                    match &v147 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<string>,
            }
        }
        pub fn method72(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure29((), v)
                },
            )
        }
        pub fn method80(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v2.clone(), string("files_len"), ());
                ()
            };
            let v33: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v42: std::string::String = format!("{:#?}", v0_1);
            let v81: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v42), ());
                ()
            };
            let v92: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method79(
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
            let v9: string = Documents::method80(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run"),
                v9
            ))
        }
        pub fn closure34(v0_1: Vec<string>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v5: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method79(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method66(),
                    v0_1.len(),
                ))
            };
        }
        pub fn method81() -> string {
            string("")
        }
        pub fn method82(v0_1: string) -> string {
            Documents::method38(Documents::method61(v0_1))
        }
        pub fn method84(
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
        pub fn method86() -> string {
            string("")
        }
        pub fn method87(v0_1: i64, v1_1: string, v2: i64) -> LrcPtr<Documents::UH0> {
            if (v2) < (v0_1) {
                LrcPtr::new(Documents::UH0::UH0_1(
                    getCharAt(v1_1.clone(), v2 as i32),
                    Documents::method87(v0_1, v1_1, (v2) + 1_i64),
                ))
            } else {
                LrcPtr::new(Documents::UH0::UH0_0)
            }
        }
        pub fn method88(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method88: loop {
                break '_method88 (match v0_1.get().clone().as_ref() {
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
                            continue '_method88;
                        }
                    }
                });
            }
        }
        pub fn closure37(v0_1: i32, v1_1: i32, v2: string) -> string {
            if (v1_1) >= (v0_1) {
                v2.clone()
            } else {
                (Documents::method89(v0_1, (v1_1) + 1_i32))(append((v2), string(" ")))
            }
        }
        pub fn method89(v0_1: i32, v1_1: i32) -> Func1<string, string> {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                        Documents::method87(length(v51.clone()) as i64, v51, 0_i64),
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
                            ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                        Documents::method87(length(v51.clone()) as i64, v51, 0_i64),
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
                            ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn method90(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method90: loop {
                break '_method90 (match v2.get().clone().as_ref() {
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
                                continue '_method90;
                            }
                        }
                    }
                });
            }
        }
        pub fn method91(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method91: loop {
                break '_method91 (if (v1_1.get().clone()) >= 2_i64 {
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
                        continue '_method91;
                    }
                });
            }
        }
        pub fn method92(
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
            '_method92: loop {
                break '_method92 ({
                    let v98: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method91(v25, 0_i64)) == false {
                            let v62: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v68: string = ofChar(v25);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    Documents::method87(length(v68.clone()) as i64, v68, 0_i64),
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
                            continue '_method92;
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
        pub fn method93(
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
            '_method93: loop {
                break '_method93 (match v4.get().clone().as_ref() {
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
                                continue '_method93;
                            }
                        }
                    }
                });
            }
        }
        pub fn method94(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method94: loop {
                break '_method94 (if (v1_1.get().clone()) >= 3_i64 {
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
                        continue '_method94;
                    }
                });
            }
        }
        pub fn method95(
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
            '_method95: loop {
                break '_method95 ({
                    let v106: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method94(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    Documents::method87(length(v72.clone()) as i64, v72, 0_i64),
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
                            continue '_method95;
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
        pub fn method96(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method96: loop {
                break '_method96 (if (v1_1.get().clone()) >= (length(v0_1.get().clone())) {
                    v1_1.get().clone()
                } else {
                    if ' ' == (getCharAt(v0_1.get().clone(), v1_1.get().clone())) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method96;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method97(
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
            '_method97: loop {
                break '_method97 ({
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                            Documents::method87(length(v56.clone()) as i64, v56, 0_i64),
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
                            continue '_method97;
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
        pub fn method85(v0_1: string) -> Documents::US14 {
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
                    StringBuilder::_ctor__Z721C83C5(Documents::method86());
                fn v19(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US15 {
                    Documents::closure36((), arg10_0040)
                }
                fn v20(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US15 {
                    Documents::closure38((), arg10_0040_1)
                }
                let v24: Documents::US15 = Documents::method90(
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
                            if (Documents::method91(v50, 0_i64)) == false {
                                let v87: string = getSlice(
                                    v26.clone(),
                                    Some(1_i32),
                                    Some((length(v26.clone())) - 1_i32),
                                );
                                let v93: string = ofChar(v50);
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method88(
                                        Documents::method87(length(v93.clone()) as i64, v93, 0_i64),
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
                                Documents::US15::US15_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v50,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'']))),
                                                                         (v27.clone(),
                                                                          v28,
                                                                          v29)))
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
                                ) = Documents::method92(
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
                                let v174: Documents::US15 = Documents::method93(
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
                                        Documents::US15::US15_0(v174_0_0,
                                                                v174_0_1,
                                                                v174_0_2,
                                                                v174_0_3,
                                                                v174_0_4) =>
                                        Documents::US16::US16_0(v165_0_0.clone(),
                                                                v174_0_1.clone(),
                                                                v174_0_2.clone(),
                                                                v174_0_3.clone(),
                                                                v174_0_4.clone()),
                                        Documents::US15::US15_1(v174_1_0) =>
                                        Documents::US16::US16_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                         v174_1_0.clone(),
                                                                         (v10.clone(),
                                                                          v16.clone(),
                                                                          1_i32,
                                                                          1_i32),
                                                                         (v26.clone(),
                                                                          v27.clone(),
                                                                          v28,
                                                                          v29),
                                                                         (v167.clone(),
                                                                          v168.clone(),
                                                                          v169,
                                                                          v170))),
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
                            if (Documents::method94(v228, 0_i64)) == false {
                                let v265: string = getSlice(
                                    v10.clone(),
                                    Some(1_i32),
                                    Some((length(v10.clone())) - 1_i32),
                                );
                                let v271: string = ofChar(v228);
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method88(
                                        Documents::method87(
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
                                Documents::US15::US15_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                         v228,
                                                                         toArray(ofArray(new_array(&['\"',
                                                                                                     '\'',
                                                                                                     ' ']))),
                                                                         (v16.clone(),
                                                                          1_i32,
                                                                          1_i32)))
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
                                ) = Documents::method95(
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
                                                Some(Documents::method96(v365.clone(), 0_i32)),
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
                                    Documents::method88(
                                        Documents::method87(
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
                                Documents::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                            ' ',
                                                                                            v420,
                                                                                            v421,
                                                                                            v419.clone(),
                                                                                            getSlice(v418.clone(),
                                                                                                     Some(0_i32),
                                                                                                     Some((if -2_i32
                                                                                                                  ==
                                                                                                                  (v484)
                                                                                                              {
                                                                                                               (length(v418.clone()))
                                                                                                                   +
                                                                                                                   1_i32
                                                                                                           } else {
                                                                                                               (v484)
                                                                                                                   +
                                                                                                                   1_i32
                                                                                                           })
                                                                                                              -
                                                                                                              1_i32))),
                                                                                   string("\n"),
                                                                                   append(((Documents::method89((v421)
                                                                                                                    -
                                                                                                                    1_i32,
                                                                                                                0_i32))(string(""))),
                                                                                          string("^")),
                                                                                   string("\n")])))
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
                                        Documents::method88(
                                            Documents::method87(
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
                                        ) = Documents::method97(
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
        pub fn method100(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method100: loop {
                break '_method100 (if (v1_1.get().clone()) >= 4_i64 {
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
                        continue '_method100;
                    }
                });
            }
        }
        pub fn method101(
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
            '_method101: loop {
                break '_method101 ({
                    let v114: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v33: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method100(v33, 0_i64)) == false {
                            let v70: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v76: string = ofChar(v33);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    Documents::method87(length(v76.clone()) as i64, v76, 0_i64),
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
                            continue '_method101;
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
        pub fn method103(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method103: loop {
                break '_method103 (if (v1_1.get().clone()) >= 3_i64 {
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
                        continue '_method103;
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                        Documents::method87(length(v51.clone()) as i64, v51, 0_i64),
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
                            ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                            Documents::method87(length(v182.clone()) as i64, v182, 0_i64),
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                        Documents::method87(length(v51.clone()) as i64, v51, 0_i64),
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
                            ((Documents::method89((v3) - 1_i32, 0_i32))(string(""))),
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Documents::method88(
                            Documents::method87(length(v182.clone()) as i64, v182, 0_i64),
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
        pub fn method104(
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
            '_method104: loop {
                break '_method104 (match v4.get().clone().as_ref() {
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
                                continue '_method104;
                            }
                        }
                    }
                });
            }
        }
        pub fn method105(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method105: loop {
                break '_method105 (match v0_1.get().clone().as_ref() {
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
                        continue '_method105;
                    }
                });
            }
        }
        pub fn method102(
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
            '_method102: loop {
                break '_method102 ({
                    let v106: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method103(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    Documents::method87(length(v72.clone()) as i64, v72, 0_i64),
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
                        _ => Documents::method104(
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
                            continue '_method102;
                        }
                        _ => Documents::US23::US23_0(
                            Documents::method105(
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
        pub fn method106(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method106(
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
        pub fn method107(
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
            '_method107: loop {
                break '_method107 ({
                    let v106: Documents::US15 = if string("") == (v1_1.get().clone()) {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method103(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    Documents::method87(length(v72.clone()) as i64, v72, 0_i64),
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
                            continue '_method107;
                        }
                        _ => Documents::US23::US23_0(
                            Documents::method105(
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
                    let v5: bool = string("") == (v1_1.get().clone());
                    let v114: Documents::US15 = if v5 {
                        Documents::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v33: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method100(v33, 0_i64)) == false {
                            let v70: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v76: string = ofChar(v33);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method88(
                                    Documents::method87(length(v76.clone()) as i64, v76, 0_i64),
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
                                Documents::method101(
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
                                Documents::US15::US15_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                  '\"',
                                                                                  (v2.get().clone(),
                                                                                   v3.get().clone(),
                                                                                   v4.get().clone())))
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
                                        Documents::method88(
                                            Documents::method87(
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
                                    Documents::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                         '\"',
                                                                                                         v3.get().clone(),
                                                                                                         v4.get().clone(),
                                                                                                         v2.get().clone(),
                                                                                                         getSlice(v1_1.get().clone(),
                                                                                                                  Some(0_i32),
                                                                                                                  Some((if -2_i32
                                                                                                                               ==
                                                                                                                               (v202)
                                                                                                                           {
                                                                                                                            (length(v1_1.get().clone()))
                                                                                                                                +
                                                                                                                                1_i32
                                                                                                                        } else {
                                                                                                                            (v202)
                                                                                                                                +
                                                                                                                                1_i32
                                                                                                                        })
                                                                                                                           -
                                                                                                                           1_i32))),
                                                                                                string("\n"),
                                                                                                append(((Documents::method89((v4.get().clone())
                                                                                                                                 -
                                                                                                                                 1_i32,
                                                                                                                             0_i32))(string(""))),
                                                                                                       string("^")),
                                                                                                string("\n")])))
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
                                    let v268: Documents::US23 = Documents::method102(
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
                                            let v275: List<string> = Documents::method106(
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
                                                Documents::US15::US15_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                                      '\"',
                                                                                                      (v304.clone(),
                                                                                                       v305,
                                                                                                       v306)))
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
                                                    ) = Documents::method88(
                                                        Documents::method87(
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
                                                    Documents::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                             '\"',
                                                                                                                             v305,
                                                                                                                             v306,
                                                                                                                             v304.clone(),
                                                                                                                             getSlice(v303.clone(),
                                                                                                                                      Some(0_i32),
                                                                                                                                      Some((if -2_i32
                                                                                                                                                   ==
                                                                                                                                                   (v369)
                                                                                                                                               {
                                                                                                                                                (length(v303.clone()))
                                                                                                                                                    +
                                                                                                                                                    1_i32
                                                                                                                                            } else {
                                                                                                                                                (v369)
                                                                                                                                                    +
                                                                                                                                                    1_i32
                                                                                                                                            })
                                                                                                                                               -
                                                                                                                                               1_i32))),
                                                                                                                    string("\n"),
                                                                                                                    append(((Documents::method89((v306)
                                                                                                                                                     -
                                                                                                                                                     1_i32,
                                                                                                                                                 0_i32))(string(""))),
                                                                                                                           string("^")),
                                                                                                                    string("\n")])))
                                                }
                                            };
                                            match &v428 {
                                                                 Documents::US15::US15_0(v428_0_0,
                                                                                         v428_0_1,
                                                                                         v428_0_2,
                                                                                         v428_0_3,
                                                                                         v428_0_4)
                                                                 =>
                                                                 Documents::US16::US16_0(v301_0_0.clone(),
                                                                                         v428_0_1.clone(),
                                                                                         v428_0_2.clone(),
                                                                                         v428_0_3.clone(),
                                                                                         v428_0_4.clone()),
                                                                 Documents::US15::US15_1(v428_1_0)
                                                                 =>
                                                                 Documents::US16::US16_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                  v428_1_0.clone(),
                                                                                                  (v1_1.get().clone(),
                                                                                                   v2.get().clone(),
                                                                                                   v3.get().clone(),
                                                                                                   v4.get().clone()),
                                                                                                  (v263.clone(),
                                                                                                   v264.clone(),
                                                                                                   v265,
                                                                                                   v266),
                                                                                                  (v303.clone(),
                                                                                                   v304.clone(),
                                                                                                   v305,
                                                                                                   v306))),
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
                                                     Documents::method104(v1_1.get().clone(),
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
                                        ) => Documents::method107(
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
                                            let v492: List<string> = Documents::method106(
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
                            let v529: i32 = Documents::method96(v524.clone(), 0_i32);
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
                                    continue '_method99;
                                }
                                _ => Documents::US23::US23_0(
                                    Documents::method105(
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
                            Documents::method105(
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
        pub fn method98(v0_1: string) -> Documents::US22 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v22: Documents::US23 = Documents::method99(
                    LrcPtr::new(Documents::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Documents::method86()),
                    1_i32,
                    1_i32,
                );
                match &v22 {
                    Documents::US23::US23_0(v22_0_0, v22_0_1, v22_0_2, v22_0_3, v22_0_4) => {
                        Documents::US22::US22_0(toArray(Documents::method106(
                            v22_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US23::US23_1(v22_1_0) => Documents::US22::US22_1(v22_1_0.clone()),
                }
            }
        }
        pub fn method109(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v19: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v10.clone(), string("file_name"), ());
                ()
            };
            let v41: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v50: () = {
                Documents::closure8(v10.clone(), v0_1, ());
                ()
            };
            let v61: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v10.clone(), string("arguments"), ());
                ()
            };
            let v81: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v90: () = {
                Documents::closure8(v10.clone(), v1_1, ());
                ()
            };
            let v99: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v110: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v119: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v128: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v139: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v148: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v157: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v166: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v177: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v186: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v195: std::string::String = format!("{:#?}", v3);
            let v234: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v195),
                    (),
                );
                ()
            };
            let v243: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v254: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v263: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v276: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v285: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v296: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v305: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v314: std::string::String = format!("{:#?}", v5);
            let v353: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v314),
                    (),
                );
                ()
            };
            let v362: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v373: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v382: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v391: std::string::String = format!("{:#?}", v6);
            let v430: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v391),
                    (),
                );
                ()
            };
            let v439: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v450: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v459: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v471: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v480: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v491: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v500: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v509: std::string::String = format!("{:#?}", v8);
            let v548: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v509),
                    (),
                );
                ()
            };
            let v559: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v568: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method108(
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
            let v17: string = Documents::method109(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options"),
                v17
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
                let v13: () = {
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
                let v39: Option<i64> = patternInput.5.clone();
                let v38: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v37: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v36: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v35: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v34: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method108(
                    v34.clone(),
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                    v38.clone(),
                    v39.clone(),
                    Documents::method8(v34, v35, v36, v37, v38, v39),
                    Documents::method66(),
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
        pub fn method110() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure42((), v))
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US24 {
            Documents::US24::US24_0(v0_1)
        }
        pub fn method111(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US24>
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
        pub fn method112() -> Func1<std::string::String, Documents::US24> {
            Func1::new(move |v: std::string::String| Documents::closure44((), v))
        }
        pub fn method114(
            v0_1: std::string::String,
            v1_1: string,
            v2: string,
            v3: string,
            v4: Option<CancellationToken>,
            v5: Array<(string, string)>,
            v6: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v7: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v8: bool,
            v9: Option<string>,
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v20: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v31: () = {
                Documents::closure8(v11.clone(), string("error"), ());
                ()
            };
            let v42: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v51: std::string::String = format!("{:#?}", v0_1);
            let v90: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v51),
                    (),
                );
                ()
            };
            let v101: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v112: () = {
                Documents::closure8(v11.clone(), string("file_name"), ());
                ()
            };
            let v121: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v11.clone(), v1_1, ());
                ()
            };
            let v139: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v150: () = {
                Documents::closure8(v11.clone(), string("arguments"), ());
                ()
            };
            let v159: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v168: () = {
                Documents::closure8(v11.clone(), v2, ());
                ()
            };
            let v177: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v188: () = {
                Documents::closure8(v11.clone(), string("options"), ());
                ()
            };
            let v197: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v206: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v217: () = {
                Documents::closure8(v11.clone(), string("command"), ());
                ()
            };
            let v226: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v235: () = {
                Documents::closure8(v11.clone(), v3, ());
                ()
            };
            let v244: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v255: () = {
                Documents::closure8(v11.clone(), string("cancellation_token"), ());
                ()
            };
            let v264: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v273: std::string::String = format!("{:#?}", v4);
            let v312: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v273),
                    (),
                );
                ()
            };
            let v321: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v332: () = {
                Documents::closure8(v11.clone(), string("environment_variables"), ());
                ()
            };
            let v341: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v354: () = {
                Documents::closure8(v11.clone(), sprintf!("{:?}", v5), ());
                ()
            };
            let v363: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v374: () = {
                Documents::closure8(v11.clone(), string("on_line"), ());
                ()
            };
            let v383: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v392: std::string::String = format!("{:#?}", v6);
            let v431: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v392),
                    (),
                );
                ()
            };
            let v440: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v451: () = {
                Documents::closure8(v11.clone(), string("stdin"), ());
                ()
            };
            let v460: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v469: std::string::String = format!("{:#?}", v7);
            let v508: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v469),
                    (),
                );
                ()
            };
            let v517: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v528: () = {
                Documents::closure8(v11.clone(), string("trace"), ());
                ()
            };
            let v537: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v549: () = {
                Documents::closure8(
                    v11.clone(),
                    if v8 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v558: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v569: () = {
                Documents::closure8(v11.clone(), string("working_directory"), ());
                ()
            };
            let v578: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v587: std::string::String = format!("{:#?}", v9);
            let v626: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v587),
                    (),
                );
                ()
            };
            let v637: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v646: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            v11.l0.get().clone()
        }
        pub fn method113(
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
            let v18: string = Documents::method114(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / child error"),
                v18
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
                let v14: () = {
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
                let v40: Option<i64> = patternInput.5.clone();
                let v39: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v38: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v37: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v36: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v35: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method113(
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                    v38.clone(),
                    v39.clone(),
                    v40.clone(),
                    Documents::method8(v35, v36, v37, v38, v39, v40),
                    Documents::method76(),
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
        pub fn method115(
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
        pub fn method116(
        ) -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure46((), v))
        }
        pub fn closure47(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method117() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn method118() -> Func1<
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
        pub fn method119() -> Func1<
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
        pub fn method120() -> Func1<std::string::String, Documents::US26> {
            Func1::new(move |v: std::string::String| Documents::closure49((), v))
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Documents::US26 {
            Documents::US26::US26_1(v0_1)
        }
        pub fn method121() -> Func1<std::string::String, Documents::US26> {
            Func1::new(move |v: std::string::String| Documents::closure50((), v))
        }
        pub fn method123(v0_1: bool, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v23: () = {
                Documents::closure8(v3.clone(), string("trace\'"), ());
                ()
            };
            let v34: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v46: () = {
                Documents::closure8(
                    v3.clone(),
                    if v0_1 {
                        string("true")
                    } else {
                        string("false")
                    },
                    (),
                );
                ()
            };
            let v57: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v68: () = {
                Documents::closure8(v3.clone(), string("e"), ());
                ()
            };
            let v77: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v86: std::string::String = format!("{:#?}", v1_1);
            let v125: () = {
                Documents::closure8(v3.clone(), fable_library_rust::String_::fromString(v86), ());
                ()
            };
            let v136: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method122(
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
            let v10: string = Documents::method123(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.stdio_line"),
                v10
            ))
        }
        pub fn closure51(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v6: () = {
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
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method122(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method76(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method124() -> string {
            let v8: string = Documents::method13(getCharAt(toLower(string("Verbose")), 0_i32));
            let v15: &str = inline_colorization::color_bright_black;
            let v22: &str = &*v8;
            let v50: &str = inline_colorization::color_reset;
            let v52: std::string::String = format!("{}{}{}", v15, v22, v50);
            fable_library_rust::String_::fromString(v52)
        }
        pub fn method126() -> string {
            let v1_1: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method125(
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
            let v9: string = Documents::method126();
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v9
            ))
        }
        pub fn closure52(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v5: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method125(
                        v26.clone(),
                        v27.clone(),
                        v28.clone(),
                        v29.clone(),
                        v30.clone(),
                        v31.clone(),
                        Documents::method8(v26, v27, v28, v29, v30, v31),
                        Documents::method124(),
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
        pub fn method127(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure53((), v)
            })
        }
        pub fn method128(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure54(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US27 {
            Documents::US27::US27_0(v0_1)
        }
        pub fn method129() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US27,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure54((), v)
                },
            )
        }
        pub fn method130(
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
        pub fn method131(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US28>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure55((), v)
                },
            )
        }
        pub fn method132(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure56(unitVar: (), v0_1: std::process::Output) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method133() -> Func1<std::process::Output, Documents::US29> {
            Func1::new(move |v: std::process::Output| Documents::closure56((), v))
        }
        pub fn closure57(unitVar: (), v0_1: std::string::String) -> Documents::US29 {
            Documents::US29::US29_1(v0_1)
        }
        pub fn method134() -> Func1<std::string::String, Documents::US29> {
            Func1::new(move |v: std::string::String| Documents::closure57((), v))
        }
        pub fn method135(
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
            let v18: string = Documents::method114(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / output error"),
                v18
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
                let v14: () = {
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
                let v40: Option<i64> = patternInput.5.clone();
                let v39: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v38: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v37: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v36: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v35: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method135(
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                    v38.clone(),
                    v39.clone(),
                    v40.clone(),
                    Documents::method8(v35, v36, v37, v38, v39, v40),
                    Documents::method76(),
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
        pub fn method136() -> Func1<i32, Documents::US30> {
            Func1::new(move |v: i32| Documents::closure59((), v))
        }
        pub fn method137() -> string {
            string("\n")
        }
        pub fn method139(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v23: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v34: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v65: () = {
                Documents::closure8(v3.clone(), string("std_trace_length"), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method138(
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
            let v10: string = Documents::method139(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / result"),
                v10
            ))
        }
        pub fn closure60(v0_1: i32, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v6: () = {
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
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method138(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method124(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method143(
            v0_1: string,
            v1_1: Documents::US5,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v19: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v10.clone(), string("file_name"), ());
                ()
            };
            let v41: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v50: () = {
                Documents::closure8(v10.clone(), v0_1, ());
                ()
            };
            let v61: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v10.clone(), string("arguments"), ());
                ()
            };
            let v81: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v1_1), ());
                ()
            };
            let v103: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v123: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v143: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v152: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v161: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v170: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v181: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v190: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v199: std::string::String = format!("{:#?}", v3);
            let v238: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v199),
                    (),
                );
                ()
            };
            let v247: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v258: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v267: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v280: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v289: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v300: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v309: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v318: std::string::String = format!("{:#?}", v5);
            let v357: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v318),
                    (),
                );
                ()
            };
            let v366: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v377: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v386: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v395: std::string::String = format!("{:#?}", v6);
            let v434: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v395),
                    (),
                );
                ()
            };
            let v443: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v454: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v463: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v475: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v484: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v495: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v504: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v513: std::string::String = format!("{:#?}", v8);
            let v552: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v513),
                    (),
                );
                ()
            };
            let v563: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v572: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
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
            let v17: string = Documents::method143(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v17
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
                let v13: () = {
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
                let v39: Option<i64> = patternInput.5.clone();
                let v38: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v37: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v36: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v35: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v34: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method142(
                    v34.clone(),
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                    v38.clone(),
                    v39.clone(),
                    Documents::method8(v34, v35, v36, v37, v38, v39),
                    Documents::method66(),
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
        pub fn method144(
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
        pub fn method147(v0_1: bool) -> string {
            unbox::<string>(fable_library_rust::Native_::getZero())
        }
        pub fn closure63(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method148() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Documents::US31> {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Documents::closure63((), v)
            })
        }
        pub fn method149(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn closure64(v0_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_0) {
                let v5: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method125(
                        v26.clone(),
                        v27.clone(),
                        v28.clone(),
                        v29.clone(),
                        v30.clone(),
                        v31.clone(),
                        Documents::method8(v26, v27, v28, v29, v30, v31),
                        Documents::method124(),
                        v0_1,
                    )
                })
            };
        }
        pub fn method146(
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
        pub fn method145(
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
            Documents::method146(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
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
                Documents::method145(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
            fable_library_rust::Native_::getZero::<()>();
            ()
        }
        pub fn closure65(unitVar: (), v0_1: CancellationToken) -> Documents::US32 {
            Documents::US32::US32_0(v0_1)
        }
        pub fn method150() -> Func1<CancellationToken, Documents::US32> {
            Func1::new(move |v: CancellationToken| Documents::closure65((), v))
        }
        pub fn method151(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method152(v0_1: bool) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method153(v0_1: bool) {
            ();
        }
        pub fn closure66(v0_1: bool, unitVar: ()) {
            if (Documents::method152(v0_1)) == false {
                Documents::method153(v0_1);
            };
        }
        pub fn method156(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v2.clone(), string("ex"), ());
                ()
            };
            let v33: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v42: std::string::String = format!("{:#?}", v0_1);
            let v81: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v42), ());
                ()
            };
            let v92: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method155(
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
            let v9: string = Documents::method156(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async / WaitForExitAsync"),
                v9
            ))
        }
        pub fn closure67(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v5: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method155(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method35(),
                    v0_1,
                ))
            };
        }
        pub fn method154(
            v0_1: bool,
            v1_1: LrcPtr<ConcurrentStack_1<string>>,
            v2: CancellationToken,
        ) -> Arc<Async<i32>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method158(
            v0_1: i32,
            v1_1: i32,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v19: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v30: () = {
                Documents::closure8(v10.clone(), string("exit_code"), ());
                ()
            };
            let v41: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v50: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v61: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v10.clone(), string("output_length"), ());
                ()
            };
            let v81: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v90: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v99: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v110: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v119: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v128: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v139: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v148: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v157: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v166: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v177: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v186: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v195: std::string::String = format!("{:#?}", v3);
            let v234: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v195),
                    (),
                );
                ()
            };
            let v243: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v254: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v263: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v276: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v285: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v296: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v305: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v314: std::string::String = format!("{:#?}", v5);
            let v353: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v314),
                    (),
                );
                ()
            };
            let v362: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v373: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v382: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v391: std::string::String = format!("{:#?}", v6);
            let v430: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v391),
                    (),
                );
                ()
            };
            let v439: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v450: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v459: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v471: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v480: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v491: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v500: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v509: std::string::String = format!("{:#?}", v8);
            let v548: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v509),
                    (),
                );
                ()
            };
            let v559: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v568: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method157(
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
            let v17: string = Documents::method158(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v17
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
                let v13: () = {
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
                let v39: Option<i64> = patternInput.5.clone();
                let v38: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v37: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v36: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v35: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v34: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method157(
                    v34.clone(),
                    v35.clone(),
                    v36.clone(),
                    v37.clone(),
                    v38.clone(),
                    v39.clone(),
                    Documents::method8(v34, v35, v36, v37, v38, v39),
                    Documents::method66(),
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
        pub fn method141(
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
        pub fn method140(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            Documents::method141(v0_1, v1_1, v2, v3, v4, v5, v6)
        }
        pub fn method83(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v17: Documents::US14 = Documents::method85(Documents::method84(
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
            let v35: Documents::US22 = Documents::method98(match &v30 {
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
            let v123: () = {
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
            let _capture_v175: MutCell<Option<LrcPtr<(i32, string)>>> =
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
                        let v177: std::process::Command = std::process::Command::new(&*v29.clone());
                        let v179: bool = true;
                        let mut v177 = v177;
                        let v181: bool = true;
                        std::process::Command::args(&mut v177, &*v120.clone());
                        let v183: std::process::Command = v177;
                        let v185: std::process::Stdio = std::process::Stdio::piped();
                        let v187: bool = true;
                        let mut v183 = v183;
                        let v189: bool = true;
                        std::process::Command::stdout(&mut v183, std::process::Stdio::piped());
                        let v191: std::process::Command = v183;
                        let v193: std::process::Stdio = std::process::Stdio::piped();
                        let v195: bool = true;
                        let mut v191 = v191;
                        let v197: bool = true;
                        std::process::Command::stderr(&mut v191, std::process::Stdio::piped());
                        let v199: std::process::Command = v191;
                        let v201: std::process::Stdio = std::process::Stdio::piped();
                        let v203: bool = true;
                        let mut v199 = v199;
                        let v205: bool = true;
                        std::process::Command::stdin(&mut v199, std::process::Stdio::piped());
                        let v207: std::process::Command = v199;
                        let v232: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method6(), v6.clone()),
                        );
                        let v246: std::process::Command = match &v232 {
                            Documents::US5::US5_0(v232_0_0) => {
                                let v238: bool = true;
                                let mut v207 = v207;
                                let v240: bool = true;
                                std::process::Command::current_dir(
                                    &mut v207,
                                    &*match &v232 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v207
                            }
                            _ => v207,
                        };
                        let v268: std::process::Command = if (get_Count(v2.clone()) as u64) == 0_u64
                        {
                            v246
                        } else {
                            let v250: Vec<(string, string)> = v2.clone().to_vec();
                            let v252: bool = true;
                            let _vec_fold_ = v250.into_iter().fold(v246, |acc, x| {
                                //;
                                let v254: std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v259: bool = true;
                                let mut v254 = v254;
                                let v261: bool = true;
                                std::process::Command::env(
                                    &mut v254,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v263: std::process::Command = v254;
                                let v265: bool = true;
                                v263
                            });
                            _vec_fold_
                        };
                        let v270: bool = true;
                        let mut v268 = v268;
                        let v272: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v268);
                        let v273 = Documents::method69();
                        let v277: Result<std::process::Child, std::string::String> =
                            v272.map_err(|x| v273(x));
                        let v289 = Documents::method110();
                        let v291: bool = true;
                        let _result_map_ = v277.map(|x| {
                            //;
                            let v298: Option<std::process::Child> = v289(Some(x));
                            let v300: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v298);
                            let v302: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v300);
                            let v304: bool = true;
                            v302
                        });
                        let v306: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v307 = Documents::method111();
                        let v308 = Documents::method112();
                        let v310: Documents::US24 = match v306 {
                            Ok(x) => v307(x),
                            Err(e) => v308(e),
                        };
                        let patternInput_3: (i32, Documents::US6, Documents::US25) = match &v310 {
                            Documents::US24::US24_0(v310_0_0) => {
                                let v311: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v310_0_0.clone();
                                let v313: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v315: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v311.clone();
                                    let v317: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v315.lock();
                                    let v333: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method115(v317.unwrap());
                                    let v335: bool = true;
                                    let mut v333 = v333;
                                    let v337: &mut Option<std::process::Child> = &mut v333;
                                    let v339: Option<&mut std::process::Child> = v337.as_mut();
                                    let v341: &mut std::process::Child = v339.unwrap();
                                    let v343: &mut Option<std::process::ChildStdout> =
                                        &mut v341.stdout;
                                    let v345: Option<std::process::ChildStdout> =
                                        Option::take(v343);
                                    let v347: std::process::ChildStdout = v345.unwrap();
                                    let v349: bool = true;
                                    v347
                                })();
                                let v351: std::process::ChildStdout = _capture;
                                let v353: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v355: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v311.clone();
                                    let v357: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v355.lock();
                                    let v373: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method115(v357.unwrap());
                                    let v375: bool = true;
                                    let mut v373 = v373;
                                    let v377: &mut Option<std::process::Child> = &mut v373;
                                    let v379: Option<&mut std::process::Child> = v377.as_mut();
                                    let v381: &mut std::process::Child = v379.unwrap();
                                    let v383: &mut Option<std::process::ChildStderr> =
                                        &mut v381.stderr;
                                    let v385: Option<std::process::ChildStderr> =
                                        Option::take(v383);
                                    let v387: std::process::ChildStderr = v385.unwrap();
                                    let v389: bool = true;
                                    v387
                                })();
                                let v391: std::process::ChildStderr = _capture;
                                let v393: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v395: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v311.clone();
                                    let v397: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v395.lock();
                                    let v413: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method115(v397.unwrap());
                                    let v415: bool = true;
                                    let mut v413 = v413;
                                    let v417: &mut Option<std::process::Child> = &mut v413;
                                    let v419: Option<&mut std::process::Child> = v417.as_mut();
                                    let v421: &mut std::process::Child = v419.unwrap();
                                    let v423: &mut Option<std::process::ChildStdin> =
                                        &mut v421.stdin;
                                    let v425: Option<std::process::ChildStdin> = Option::take(v423);
                                    let v427: std::process::ChildStdin = v425.unwrap();
                                    let v433: Option<std::process::ChildStdin> =
                                        (Documents::method116())(Some(v427));
                                    let v435: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v433);
                                    let v437: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v435);
                                    let v439: bool = true;
                                    v437
                                })();
                                let v441: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v443: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v446: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method117())(v443.clone());
                                let v448: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v446);
                                let v450: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v448);
                                let v452: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method118())(v443);
                                let v454: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v452);
                                let v456: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v454);
                                let v458: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method119())(patternInput_2.1.clone());
                                let v460: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v458);
                                let v462: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v460);
                                let v464: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v466: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v351);
                                    let v468: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v466);
                                    let v470: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v468);
                                    let v472: bool = true;
                                    let mut v470 = v470;
                                    let _iter_try_for_each = v470.try_for_each(|x| {
                                        //;
                                        let v474: Result<std::string::String, std::io::Error> = x;
                                        let v476: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v450.clone();
                                        let v477 = Documents::method69();
                                        let v481: Result<std::string::String, std::string::String> =
                                            v474.map_err(|x| v477(x));
                                        let v493 = Documents::method120();
                                        let v494 = Documents::method121();
                                        let v496: Documents::US26 = match v481 {
                                            Ok(x) => v493(x),
                                            Err(e) => v494(e),
                                        };
                                        let v733: std::string::String = match &v496 {
                                            Documents::US26::US26_0(v496_0_0) => {
                                                let v499: string =
                                                    fable_library_rust::String_::fromString(
                                                        v496_0_0.clone(),
                                                    );
                                                let v501: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v503: std::borrow::Cow<[u8]> =
                                                    v501.encode(&*v499).0;
                                                let v505: &[u8] = v503.as_ref();
                                                let v507: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v505);
                                                let v511: &str = v507.unwrap();
                                                let v550: std::string::String = String::from(v511);
                                                let v558: string = concat(new_array(&[
                                                    string("> "),
                                                    fable_library_rust::String_::fromString(
                                                        v550.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v561: () = {
                                                        Documents::closure52(v558.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v613: () = {
                                                        Documents::closure11(v558, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v550
                                            }
                                            Documents::US26::US26_1(v496_1_0) => {
                                                let v615: std::string::String = v496_1_0.clone();
                                                let v618: () = {
                                                    Documents::closure51(v5, v615.clone(), ());
                                                    ()
                                                };
                                                let v665: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v615);
                                                let v672: &str = &*v665;
                                                String::from(v672)
                                            }
                                        };
                                        let v735: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v476;
                                        let v737: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v735.lock();
                                        let v741: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v737.unwrap();
                                        let v754: &std::sync::mpsc::Sender<std::string::String> =
                                            &v741;
                                        let v756: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v754.send(v733);
                                        let v757 = Documents::method127();
                                        let v761: Result<(), std::string::String> =
                                            v756.map_err(|x| v757(x));
                                        let v774: _ = v761;
                                        let v776: bool = true;
                                        v774
                                    }); //;
                                    let v779: Result<(), string> = Documents::method128(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v782: string = string("}");
                                    let v787: bool = true;
                                    let _fix_closure_v784 = v779;
                                    let v794: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v784 "),
                                                    (v782),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v795: bool = true;
                                    _fix_closure_v784
                                }); // rust.fix_closure';
                                let v797: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v799: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v801: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v391);
                                    let v803: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v801);
                                    let v805: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v803);
                                    let v807: bool = true;
                                    let mut v805 = v805;
                                    let _iter_try_for_each = v805.try_for_each(|x| {
                                        //;
                                        let v809: Result<std::string::String, std::io::Error> = x;
                                        let v811: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v456.clone();
                                        let v812 = Documents::method69();
                                        let v816: Result<std::string::String, std::string::String> =
                                            v809.map_err(|x| v812(x));
                                        let v828 = Documents::method120();
                                        let v829 = Documents::method121();
                                        let v831: Documents::US26 = match v816 {
                                            Ok(x) => v828(x),
                                            Err(e) => v829(e),
                                        };
                                        let v1134: std::string::String = match &v831 {
                                            Documents::US26::US26_0(v831_0_0) => {
                                                let v834: string =
                                                    fable_library_rust::String_::fromString(
                                                        v831_0_0.clone(),
                                                    );
                                                let v836: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v838: std::borrow::Cow<[u8]> =
                                                    v836.encode(&*v834).0;
                                                let v840: &[u8] = v838.as_ref();
                                                let v842: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v840);
                                                let v846: &str = v842.unwrap();
                                                let v885: std::string::String = String::from(v846);
                                                let v893: string = concat(new_array(&[
                                                    string("! "),
                                                    fable_library_rust::String_::fromString(
                                                        v885.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v896: () = {
                                                        Documents::closure52(v893.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v947: () = {
                                                        Documents::closure11(v893, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v949: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v885
                                                    );
                                                    let v956: &str = &*v949;
                                                    String::from(v956)
                                                }
                                            }
                                            Documents::US26::US26_1(v831_1_0) => {
                                                let v1016: std::string::String = v831_1_0.clone();
                                                let v1019: () = {
                                                    Documents::closure51(v5, v1016.clone(), ());
                                                    ()
                                                };
                                                let v1066: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v1016);
                                                let v1073: &str = &*v1066;
                                                String::from(v1073)
                                            }
                                        };
                                        let v1136: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v811;
                                        let v1138: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v1136.lock();
                                        let v1142: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v1138.unwrap();
                                        let v1155: &std::sync::mpsc::Sender<std::string::String> =
                                            &v1142;
                                        let v1157: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v1155.send(v1134);
                                        let v1158 = Documents::method127();
                                        let v1162: Result<(), std::string::String> =
                                            v1157.map_err(|x| v1158(x));
                                        let v1175: _ = v1162;
                                        let v1177: bool = true;
                                        v1175
                                    }); //;
                                    let v1180: Result<(), string> = Documents::method128(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v1181: string = string("}");
                                    let v1186: bool = true;
                                    let _fix_closure_v1183 = v1180;
                                    let v1193: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v1183 "),
                                                    (v1181),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v1194: bool = true;
                                    _fix_closure_v1183
                                }); // rust.fix_closure';
                                let v1196: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v1221: Documents::US27 = defaultValue(
                                    Documents::US27::US27_1,
                                    map(Documents::method129(), v4.clone()),
                                );
                                match &v1221 {
                                    Documents::US27::US27_0(v1221_0_0) => {
                                        let v1227: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v441.clone();
                                        let v1229: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v1227.lock();
                                        let v1245: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method130(v1229.unwrap());
                                        let v1247: bool = true;
                                        let mut v1245 = v1245;
                                        let v1249: &mut Option<std::process::ChildStdin> =
                                            &mut v1245;
                                        let v1251: Option<std::process::ChildStdin> =
                                            Option::take(v1249);
                                        let v1253: bool = true;
                                        let _optionm_map_ = v1251.map(|x| {
                                            //;
                                            let v1255: std::process::ChildStdin = x;
                                            let v1257: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v1255);
                                            let v1259: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v1257);
                                            let v1261: bool = true;
                                            v1259
                                        });
                                        let v1263: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v1288: Documents::US28 = defaultValue(
                                            Documents::US28::US28_1,
                                            map(Documents::method131(), v1263),
                                        );
                                        match &v1288 {
                                            Documents::US28::US28_0(v1288_0_0) => {
                                                let v1292: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v1288 {
                                                    Documents::US28::US28_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone();
                                                (match &v1221 {
                                                    Documents::US27::US27_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v1292.clone()
                                                );
                                                {
                                                    let v1294: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v1292;
                                                    let v1296: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v1294.lock();
                                                    let v1312: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method132(v1296.unwrap());
                                                    let v1314: bool = true;
                                                    let mut v1312 = v1312;
                                                    let v1316: bool = true;
                                                    std::io::Write::flush(&mut *v1312).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v1318: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v311;
                                    let v1320: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1318.lock();
                                    let v1336: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method115(v1320.unwrap());
                                    let v1338: bool = true;
                                    let mut v1336 = v1336;
                                    let v1340: &mut Option<std::process::Child> = &mut v1336;
                                    let v1342: Option<std::process::Child> = Option::take(v1340);
                                    let v1344: std::process::Child = v1342.unwrap();
                                    let v1346: Result<std::process::Output, std::io::Error> =
                                        v1344.wait_with_output();
                                    let v1347 = Documents::method69();
                                    let v1360: Result<std::process::Output, std::string::String> =
                                        v1346.map_err(|x| v1347(x));
                                    let v1370: string = string("vec![v797, v1196]");
                                    let v1371: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v797, v1196];
                                    let v1373: bool = true;
                                    v1371.into_iter().for_each(|x| {
                                        //;
                                        let v1375: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v1377: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v1375);
                                        let v1381: Result<(), string> = v1377.unwrap();
                                        v1381.unwrap();
                                        {
                                            let v1398: bool = true;
                                            let v1400: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v1401 = Documents::method133();
                                        let v1402 = Documents::method134();
                                        let v1404: Documents::US29 = match &v1360 {
                                            Err(v1360_1_0) => v1402(v1360_1_0.clone()),
                                            Ok(v1360_0_0) => v1401(v1360_0_0.clone()),
                                        };
                                        match &v1404 {
                                            Documents::US29::US29_0(v1404_0_0) => {
                                                let v1409: std::process::ExitStatus =
                                                    v1404_0_0.clone().status;
                                                let v1411: Option<i32> = v1409.code();
                                                let v1436: Documents::US30 = defaultValue(
                                                    Documents::US30::US30_1,
                                                    map(Documents::method136(), v1411),
                                                );
                                                match &v1436 {
                                                    Documents::US30::US30_0(v1436_0_0) => (
                                                        match &v1436 {
                                                            Documents::US30::US30_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US6::US6_1,
                                                        Documents::US25::US25_0(v462.clone()),
                                                    ),
                                                    _ => {
                                                        let v1450:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                        (
                                                            -1_i32,
                                                            Documents::US6::US6_0(String::from(
                                                                v1450,
                                                            )),
                                                            Documents::US25::US25_0(v462.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US29::US29_1(v1404_1_0) => {
                                                let v1518: std::string::String = v1404_1_0.clone();
                                                let v1521: () = {
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
                                                        v1518.clone(),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US6::US6_0(v1518),
                                                    Documents::US25::US25_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US24::US24_1(v310_1_0) => {
                                let v1580: std::string::String = v310_1_0.clone();
                                let v1583: () = {
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
                                        v1580.clone(),
                                        (),
                                    );
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US6::US6_0(v1580),
                                    Documents::US25::US25_1,
                                )
                            }
                        };
                        let v1641: Documents::US25 = patternInput_3.2.clone();
                        let v1640: Documents::US6 = patternInput_3.1.clone();
                        let v1639: i32 = patternInput_3.0.clone();
                        let v1652: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v1641 {
                            Documents::US25::US25_0(v1641_0_0) => Some(
                                match &v1641 {
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
                        let v1654: bool = true;
                        let _optionm_map_ = v1652.map(|x| {
                            //;
                            let v1656: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v1658: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v1656;
                            let v1660: Result<
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
                            > = v1658.lock();
                            let v1664: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v1660.unwrap();
                            let v1677 = v1664.iter();
                            let v1679: Vec<std::string::String> = v1677.collect::<Vec<_>>();
                            let v1681: bool = true;
                            let _vec_map: Vec<_> = v1679
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v1683: std::string::String = x;
                                    let v1685: string =
                                        fable_library_rust::String_::fromString(v1683);
                                    let v1687: bool = true;
                                    v1685
                                })
                                .collect::<Vec<_>>();
                            let v1689: Vec<string> = _vec_map;
                            let v1693: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                fable_library_rust::NativeArray_::array_from(v1689.clone()),
                            );
                            let v1701: string = join(Documents::method137(), toArray_1(v1693));
                            let v1706: bool = true;
                            v1701
                        });
                        let v1708: Option<string> = _optionm_map_;
                        let v1715: Documents::US5 = match &v1640 {
                            Documents::US6::US6_0(v1640_0_0) => {
                                Documents::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v1640 {
                                        Documents::US6::US6_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Documents::US5::US5_1,
                        };
                        let v1721: string = defaultValue(
                            match &v1715 {
                                Documents::US5::US5_0(v1715_0_0) => match &v1715 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => string(""),
                            },
                            v1708,
                        );
                        let v1726: () = {
                            Documents::closure60(v1639, v1721.clone(), ());
                            ()
                        };
                        LrcPtr::new((v1639, v1721))
                    }
                }))();
                _capture_v175.set(Some(x_5))
            }
            {
                let v1778: LrcPtr<(i32, string)> = match &_capture_v175.get().clone() {
                    None => panic!("{}", string("base.capture / _capture_v175=None"),),
                    Some(_capture_v175_0_0) => _capture_v175_0_0.clone(),
                };
                let _run_target_args__v15: (i32, string) = (v1778.0.clone(), v1778.1.clone());
                (
                    _run_target_args__v15.0.clone(),
                    _run_target_args__v15.1.clone(),
                )
            }
        }
        pub fn method159(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method28(v2, Documents::method47(v1_1.clone()));
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
        pub fn method160() -> string {
            string("")
        }
        pub fn closure69(unitVar: (), v0_1: string) -> Documents::US34 {
            Documents::US34::US34_0(v0_1)
        }
        pub fn method161() -> Func1<string, Documents::US34> {
            Func1::new(move |v: string| Documents::closure69((), v))
        }
        pub fn closure70(unitVar: (), v0_1: std::string::String) -> Documents::US34 {
            Documents::US34::US34_1(v0_1)
        }
        pub fn method162() -> Func1<std::string::String, Documents::US34> {
            Func1::new(move |v: std::string::String| Documents::closure70((), v))
        }
        pub fn method164(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: i32,
            v4: string,
            v5: i32,
            v6: string,
            v7: string,
            v8: Documents::US5,
            v9: string,
            v10: string,
        ) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v21: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v32: () = {
                Documents::closure8(v12.clone(), string("file"), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v52: () = {
                Documents::closure8(v12.clone(), v0_1, ());
                ()
            };
            let v63: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v12.clone(), string("real_path"), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v92: () = {
                Documents::closure8(v12.clone(), v1_1, ());
                ()
            };
            let v101: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v112: () = {
                Documents::closure8(v12.clone(), string("relative_path"), ());
                ()
            };
            let v121: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v12.clone(), v2, ());
                ()
            };
            let v139: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v150: () = {
                Documents::closure8(v12.clone(), string("origin_hash_exit_code"), ());
                ()
            };
            let v159: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v168: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v177: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v188: () = {
                Documents::closure8(v12.clone(), string("origin_hash"), ());
                ()
            };
            let v197: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v206: () = {
                Documents::closure8(v12.clone(), v4, ());
                ()
            };
            let v215: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v226: () = {
                Documents::closure8(v12.clone(), string("local_git_hash_exit_code"), ());
                ()
            };
            let v235: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v244: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v253: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v264: () = {
                Documents::closure8(v12.clone(), string("local_git_hash"), ());
                ()
            };
            let v273: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v282: () = {
                Documents::closure8(v12.clone(), v6, ());
                ()
            };
            let v291: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v302: () = {
                Documents::closure8(v12.clone(), string("hash1"), ());
                ()
            };
            let v311: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v320: () = {
                Documents::closure8(v12.clone(), v7, ());
                ()
            };
            let v329: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v340: () = {
                Documents::closure8(v12.clone(), string("hash2"), ());
                ()
            };
            let v349: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v362: () = {
                Documents::closure8(v12.clone(), sprintf!("{:?}", v8), ());
                ()
            };
            let v371: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v382: () = {
                Documents::closure8(v12.clone(), string("dist_path"), ());
                ()
            };
            let v391: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v400: () = {
                Documents::closure8(v12.clone(), v9, ());
                ()
            };
            let v409: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v420: () = {
                Documents::closure8(v12.clone(), string("cache_path"), ());
                ()
            };
            let v429: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v438: () = {
                Documents::closure8(v12.clone(), v10, ());
                ()
            };
            let v449: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            v12.l0.get().clone()
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
            let v20: string =
                Documents::method164(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v20
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
                let v15: () = {
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
                let v41: Option<i64> = patternInput.5.clone();
                let v40: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v39: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v38: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v37: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v36: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                let v60: string =
                    string("documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2");
                Documents::method19(if (v60.clone()) == string("") {
                    string("")
                } else {
                    Documents::method163(
                        v36.clone(),
                        v37.clone(),
                        v38.clone(),
                        v39.clone(),
                        v40.clone(),
                        v41.clone(),
                        Documents::method8(v36, v37, v38, v39, v40, v41),
                        Documents::method12(),
                        v60,
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
        pub fn method166() -> Func1<u64, Documents::US35> {
            Func1::new(move |v: u64| Documents::closure72((), v))
        }
        pub fn closure73(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_1(v0_1)
        }
        pub fn method167() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure73((), v))
        }
        pub fn method169(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v13: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v24: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v66: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v93: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), string("error"), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v122: std::string::String = format!("{:#?}", v2);
            let v161: () = {
                Documents::closure8(
                    v4.clone(),
                    fable_library_rust::String_::fromString(v122),
                    (),
                );
                ()
            };
            let v172: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method168(
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
            let v11: string = Documents::method169(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure74(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v7: () = {
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
                let v33: Option<i64> = patternInput.5.clone();
                let v32: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v31: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v30: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v29: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v28: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method168(
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    Documents::method8(v28, v29, v30, v31, v32, v33),
                    Documents::method35(),
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method171(v0_1: string, v1_1: string, v2: u64) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v13: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v24: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v66: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v93: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v133: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method170(
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
            let v11: string = Documents::method171(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.file_copy"),
                v11
            ))
        }
        pub fn closure75(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_1) {
                let v7: () = {
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
                let v33: Option<i64> = patternInput.5.clone();
                let v32: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v31: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v30: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v29: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v28: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method170(
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    Documents::method8(v28, v29, v30, v31, v32, v33),
                    Documents::method66(),
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn method165(v0_1: string, v1_1: string) {
            let v4: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v0_1.clone());
            let v5 = Documents::method69();
            let v18: Result<u64, std::string::String> = v4.map_err(|x| v5(x));
            let v21 = Documents::method166();
            let v22 = Documents::method167();
            let v24: Documents::US35 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v24 {
                Documents::US35::US35_0(v24_0_0) => {
                    let v30: () = {
                        Documents::closure75(v0_1.clone(), v1_1.clone(), v24_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US35::US35_1(v24_1_0) => {
                    let v80: () = {
                        Documents::closure74(v0_1.clone(), v1_1.clone(), v24_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ()
        }
        pub fn method173(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method174(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method175(v0_1: string) -> string {
            v0_1
        }
        pub fn method176(
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
            let v21: string = Documents::method175(v0_1);
            let v23: &[u8] = v21.as_bytes();
            let v24: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method176(v9);
            let v26: bool = true;
            let mut v24 = v24;
            let v28: bool = true;
            std::io::Write::write_all(&mut *v24, v23).unwrap();
            ()
        }
        pub fn method177(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method179(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v13: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v24: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v66: () = {
                Documents::closure8(v4.clone(), string("result_len"), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v93: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v133: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method178(
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
            let v11: string = Documents::method179(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.hangul"),
                v11
            ))
        }
        pub fn closure79(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v7: () = {
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
                let v33: Option<i64> = patternInput.5.clone();
                let v32: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v31: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v30: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v29: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v28: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method178(
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    Documents::method8(v28, v29, v30, v31, v32, v33),
                    Documents::method12(),
                    v1_1,
                    length(v2),
                    v0_1,
                ))
            };
        }
        pub fn method172(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US36 {
            let v15: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v60: Vec<u8> = Documents::method173(v15.unwrap());
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
            while Documents::method63(v118, v120.clone()) {
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
                while Documents::method174(v130, v132.clone()) {
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
                    while Documents::method63(v146, v148.clone()) {
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
                            join(Documents::method137(), toArray_1(_let__v157)),
                            string("\n\n"),
                        ]));
                        let patternInput: (i32, string) = Documents::method83(
                            concat(new_array(&[
                                Documents::method28(
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
                        let v235: i32 = patternInput.0.clone();
                        let v243: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v246: i32 = get_Count(v243.clone());
                        let v248: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method177(v130, v248.clone()) {
                            let v250: i32 = v248.l0.get().clone();
                            let matchValue: string = v248.l1.get().clone();
                            let matchValue_1: i32 = v248.l2.get().clone();
                            let v253: i32 = v248.l3.get().clone();
                            let v252: i32 = matchValue_1;
                            let v251: string = matchValue;
                            let v254: string = v119[v250].clone();
                            let patternInput_2: (string, i32, i32) = if (v254.clone()) == string("")
                            {
                                (
                                    concat(new_array(&[v251.clone(), string("\n")])),
                                    (v252) + 1_i32,
                                    (v253) + 1_i32,
                                )
                            } else {
                                let v259: i32 = (v252) - (v253);
                                (
                                    if (v259) >= (v246) {
                                        v251.clone()
                                    } else {
                                        let v262: string = v243[v259].clone();
                                        let v271: string = if contains(v262.clone(), string("://"))
                                        {
                                            v254
                                        } else {
                                            v262
                                        };
                                        if (v259) == ((v246) - 1_i32) {
                                            concat(new_array(&[v251.clone(), v271.clone()]))
                                        } else {
                                            concat(new_array(&[v251, v271, string("\n")]))
                                        }
                                    },
                                    (v252) + 1_i32,
                                    v253,
                                )
                            };
                            let v282: i32 = (v250) + 1_i32;
                            v248.l0.set(v282);
                            v248.l1.set(patternInput_2.0.clone());
                            v248.l2.set(patternInput_2.1.clone());
                            v248.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v248.l1.get().clone();
                            let matchValue_4: i32 = v248.l2.get().clone();
                            let matchValue_5: i32 = v248.l3.get().clone();
                            let v283: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v283.clone()).unwrap();
                            {
                                let v290: () = {
                                    Documents::closure79(v2, v235, v283.clone(), ());
                                    ()
                                };
                                Documents::US36::US36_0(v235, v283)
                            }
                        }
                    }
                }
            }
        }
        pub fn method181(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v23: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v34: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v65: () = {
                Documents::closure8(v3.clone(), string("result"), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method180(
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
            let v10: string = Documents::method181(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.files_fn / error"),
                v10
            ))
        }
        pub fn closure80(v0_1: string, v1_1: i32, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v6: () = {
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
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method180(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
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
            let patternInput: (string, string) = Documents::method159(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if if if (Documents::method30(v6.clone())) == false {
                true
            } else {
                (Documents::method30(v7.clone())) == false
            } {
                false
            } else {
                let v13: string = Documents::method38(v6.clone());
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
                            let v136: string = Documents::method160();
                            let v143: string = join(
                                if (v136.clone()) == string("\n") {
                                    Documents::method65(v136.clone())
                                } else {
                                    v136
                                },
                                toArray_1(_let__v127),
                            );
                            let v150 = Documents::method69();
                            let v154: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v143).map_err(|x| v150(x));
                            let v166 = Documents::method161();
                            let v167 = Documents::method162();
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
                            let v179: string = Documents::method38(v7.clone());
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
                                        let v302: string = Documents::method160();
                                        let v309: string = join(
                                            if (v302.clone()) == string("\n") {
                                                Documents::method65(v302.clone())
                                            } else {
                                                v302
                                            },
                                            toArray_1(_let__v293),
                                        );
                                        let v316 = Documents::method69();
                                        let v320: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v309).map_err(|x| v316(x));
                                        let v332 = Documents::method161();
                                        let v333 = Documents::method162();
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
                let v348: Documents::US36 = Documents::method172(v2, v3, v6.clone(), v4);
                match &v348 {
                    Documents::US36::US36_0(v348_0_0, v348_0_1) => {
                        let v350: string = v348_0_1.clone();
                        let v349: i32 = v348_0_0.clone();
                        if (v349) != 0_i32 {
                            let v357: () = {
                                Documents::closure80(v350.clone(), v349, ());
                                ()
                            };
                            Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v350)),
                            ))
                        } else {
                            if Documents::method30(v6.clone()) {
                                Documents::method165(v7.clone(), v6.clone())
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
        pub fn method184(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v13: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v24: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v66: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v84: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v93: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v104: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v122: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v133: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method183(
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
            let v11: string = Documents::method184(v8, v9, v10);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.crowbook / result contains ERROR"),
                v11
            ))
        }
        pub fn closure83(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_3) {
                let v7: () = {
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
                let v33: Option<i64> = patternInput.5.clone();
                let v32: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v31: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v30: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v29: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v28: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method183(
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    Documents::method8(v28, v29, v30, v31, v32, v33),
                    Documents::method35(),
                    v2,
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method182(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US36 {
            let v61: string = if string("html") == (v4.clone()) {
                string("--set html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
            } else {
                if string("pdf") == (v4.clone()) {
                    append((append(string("--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\""),
                                       (if (v0_1) == false {
                                            string("")
                                        } else {
                                            string(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13")
                                        }))),
                               string(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""))
                } else {
                    if string("epub") == (v4.clone()) {
                        string("--set epub.version 3 html.css.add \\\"\'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"")
                    } else {
                        string("")
                    }
                }
            };
            let patternInput: (i32, string) = Documents::method83(
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
                let v99: () = {
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
            let patternInput: (string, string) = Documents::method159(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if (Documents::method30(v5.clone())) == false {
                true
            } else {
                (Documents::method30(v6.clone())) == false
            } {
                false
            } else {
                let v12: string = Documents::method38(v5.clone());
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
                            let v135: string = Documents::method160();
                            let v142: string = join(
                                if (v135.clone()) == string("\n") {
                                    Documents::method65(v135.clone())
                                } else {
                                    v135
                                },
                                toArray_1(_let__v126),
                            );
                            let v149 = Documents::method69();
                            let v153: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v142).map_err(|x| v149(x));
                            let v165 = Documents::method161();
                            let v166 = Documents::method162();
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
                            let v178: string = Documents::method38(v6.clone());
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
                                        let v301: string = Documents::method160();
                                        let v308: string = join(
                                            if (v301.clone()) == string("\n") {
                                                Documents::method65(v301.clone())
                                            } else {
                                                v301
                                            },
                                            toArray_1(_let__v292),
                                        );
                                        let v315 = Documents::method69();
                                        let v319: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v308).map_err(|x| v315(x));
                                        let v331 = Documents::method161();
                                        let v332 = Documents::method162();
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
                let v347: Documents::US36 = Documents::method182(v2, v5.clone(), v3, v1_1, v4);
                match &v347 {
                    Documents::US36::US36_0(v347_0_0, v347_0_1) => {
                        let v349: string = v347_0_1.clone();
                        let v348: i32 = v347_0_0.clone();
                        if (v348) != 0_i32 {
                            let v356: () = {
                                Documents::closure80(v349.clone(), v348, ());
                                ()
                            };
                            Documents::US33::US33_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v349)),
                            ))
                        } else {
                            if Documents::method30(v5.clone()) {
                                Documents::method165(v6.clone(), v5.clone())
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
        pub fn method186(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v12: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v23: () = {
                Documents::closure8(v3.clone(), string("output_path"), ());
                ()
            };
            let v34: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v54: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v65: () = {
                Documents::closure8(v3.clone(), string("output_cache_path"), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v83: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method185(
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
            let v10: string = Documents::method186(v8, v9);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.run / par_map / files\' = [] / listm.iter"),
                v10
            ))
        }
        pub fn closure84(v0_1: string, v1_1: string, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_2) {
                let v6: () = {
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
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method185(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Documents::method8(v27, v28, v29, v30, v31, v32),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method187(
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
                    Documents::method187(
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
        pub fn method188(
        ) -> Func1<LrcPtr<Documents::UH5>, Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>>>
        {
            Func1::new(move |v: LrcPtr<Documents::UH5>| Documents::closure85((), v))
        }
        pub fn method190(
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
                    Documents::method190(
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
        pub fn method191(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method192(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method189(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            let v0_1: MutCell<LrcPtr<Documents::UH4>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>> =
                MutCell::new(v1_1.clone());
            '_method189: loop {
                break '_method189 (match v0_1.get().clone().as_ref() {
                    Documents::UH4::UH4_0 => v1_1.get().clone(),
                    Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => {
                        let v8 = toArray(Documents::method190(
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
                            Documents::method191(rayon::iter::ParallelIterator::collect(v17));
                        let v21: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method192(v1_1.get().clone());
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
                            continue '_method189;
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
            let v6: string = Documents::method61(v5);
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
                        Documents::method81(),
                    ),
                    string("\\"),
                    string("/"),
                ),
            ]));
            let v180: string = Documents::method38(v6);
            let v182: string = Documents::method82(Documents::method28(v2.clone(), v179.clone()));
            let patternInput: (i32, string) = Documents::method83(
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
            let v209: string = Documents::method82(Documents::method28(v3.clone(), v179.clone()));
            let patternInput_1: (i32, string) = Documents::method83(
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
            let v236: string = Documents::method82(Documents::method28(v4.clone(), v179.clone()));
            let v238: string =
                (Documents::method159(string("hangul.md"), v209.clone(), v4.clone()))
                    .0
                    .clone();
            let v747: LrcPtr<Documents::UH4> = if contains(v207.clone(), v234.clone()) {
                LrcPtr::new(Documents::UH4::UH4_0)
            } else {
                let v251: string = Documents::method38(v209.clone());
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
                            let v374: string = Documents::method160();
                            let v381: string = join(
                                if (v374.clone()) == string("\n") {
                                    Documents::method65(v374.clone())
                                } else {
                                    v374
                                },
                                toArray_1(_let__v365),
                            );
                            let v388 = Documents::method69();
                            let v392: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v381).map_err(|x| v388(x));
                            let v404 = Documents::method161();
                            let v405 = Documents::method162();
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
                            let v583: Documents::US5 = if (Documents::method30(v236.clone()))
                                == false
                            {
                                Documents::US5::US5_1
                            } else {
                                let v420: string = Documents::method38(v236.clone());
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
                                            let v543: string = Documents::method160();
                                            let v550: string = join(
                                                if (v543.clone()) == string("\n") {
                                                    Documents::method65(v543.clone())
                                                } else {
                                                    v543
                                                },
                                                toArray_1(_let__v534),
                                            );
                                            let v557 = Documents::method69();
                                            let v561: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v550)
                                                    .map_err(|x| v557(x));
                                            let v573 = Documents::method161();
                                            let v574 = Documents::method162();
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
                                    let v589: () = {
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
                                    Documents::method165(v236.clone(), v209.clone());
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
                                let v669: () = {
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
                                Documents::method165(v236, v209.clone());
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
            let v1178: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method187(
                if (if let Documents::UH4::UH4_0 = v747.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v747
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method159(string("epub"), v238.clone(), v4.clone());
                    let v752: string = patternInput_3.1.clone();
                    let v751: string = patternInput_3.0.clone();
                    let v811: LrcPtr<Documents::UH5> = if if Documents::method30(v751.clone()) {
                        true
                    } else {
                        if (Documents::method30(v752.clone())) == false {
                            true
                        } else {
                            let v758: () = {
                                Documents::closure84(v752.clone(), v751.clone(), ());
                                ()
                            };
                            Documents::method165(v751, v752);
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
                        Documents::method159(string("pdf"), v238.clone(), v4.clone());
                    let v814: string = patternInput_4.1.clone();
                    let v813: string = patternInput_4.0.clone();
                    let v871: LrcPtr<Documents::UH5> = if if Documents::method30(v813.clone()) {
                        true
                    } else {
                        if (Documents::method30(v814.clone())) == false {
                            true
                        } else {
                            let v820: () = {
                                Documents::closure84(v814.clone(), v813.clone(), ());
                                ()
                            };
                            Documents::method165(v813, v814);
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
                            v811.clone(),
                        ))
                    } else {
                        v811
                    };
                    let patternInput_5: (string, string) =
                        Documents::method159(string("html"), v238.clone(), v4.clone());
                    let v874: string = patternInput_5.1.clone();
                    let v873: string = patternInput_5.0.clone();
                    let v931: LrcPtr<Documents::UH5> = if if Documents::method30(v873.clone()) {
                        true
                    } else {
                        if (Documents::method30(v874.clone())) == false {
                            true
                        } else {
                            let v880: () = {
                                Documents::closure84(v874.clone(), v873.clone(), ());
                                ()
                            };
                            Documents::method165(v873, v874);
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
                            v871.clone(),
                        ))
                    } else {
                        v871
                    };
                    let patternInput_6: (string, string) =
                        Documents::method159(string("epub"), v209.clone(), v4.clone());
                    let v933: string = patternInput_6.1.clone();
                    let v932: string = patternInput_6.0.clone();
                    let v990: LrcPtr<Documents::UH5> = if if Documents::method30(v932.clone()) {
                        true
                    } else {
                        if (Documents::method30(v933.clone())) == false {
                            true
                        } else {
                            let v939: () = {
                                Documents::closure84(v933.clone(), v932.clone(), ());
                                ()
                            };
                            Documents::method165(v932, v933);
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
                            v931.clone(),
                        ))
                    } else {
                        v931
                    };
                    let patternInput_7: (string, string) =
                        Documents::method159(string("pdf"), v209.clone(), v4.clone());
                    let v992: string = patternInput_7.1.clone();
                    let v991: string = patternInput_7.0.clone();
                    let v1049: LrcPtr<Documents::UH5> = if if Documents::method30(v991.clone()) {
                        true
                    } else {
                        if (Documents::method30(v992.clone())) == false {
                            true
                        } else {
                            let v998: () = {
                                Documents::closure84(v992.clone(), v991.clone(), ());
                                ()
                            };
                            Documents::method165(v991, v992);
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
                            v990.clone(),
                        ))
                    } else {
                        v990
                    };
                    let patternInput_8: (string, string) =
                        Documents::method159(string("html"), v209.clone(), v4.clone());
                    let v1051: string = patternInput_8.1.clone();
                    let v1050: string = patternInput_8.0.clone();
                    let v1108: LrcPtr<Documents::UH5> = if if Documents::method30(v1050.clone()) {
                        true
                    } else {
                        if (Documents::method30(v1051.clone())) == false {
                            true
                        } else {
                            let v1057: () = {
                                Documents::closure84(v1051.clone(), v1050.clone(), ());
                                ()
                            };
                            Documents::method165(v1050, v1051);
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
                            v1049.clone(),
                        ))
                    } else {
                        v1049
                    };
                    let patternInput_9: (string, string) =
                        Documents::method159(string("hangul.md"), v209.clone(), v4.clone());
                    let v1110: string = patternInput_9.1.clone();
                    let v1109: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method30(v1109.clone()) {
                            true
                        } else {
                            if (Documents::method30(v1110.clone())) == false {
                                true
                            } else {
                                let v1116: () = {
                                    Documents::closure84(v1110.clone(), v1109.clone(), ());
                                    ()
                                };
                                Documents::method165(v1109, v1110);
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
                            v1108,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v1182: Vec<LrcPtr<Documents::UH5>> = v1178.to_vec();
            let v1185: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v1189: List<LrcPtr<Documents::UH5>> =
                ofArray(fable_library_rust::NativeArray_::array_from(v1182.clone()));
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((
                v180,
                Documents::method189(
                    foldBack(
                        Func2::new(
                            move |b0: LrcPtr<Documents::UH5>, b1: LrcPtr<Documents::UH4>| {
                                (Documents::method188())(b0)(b1)
                            },
                        ),
                        v1189,
                        LrcPtr::new(Documents::UH4::UH4_0),
                    ),
                    v1185,
                ),
            )))
        }
        pub fn method25(
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
            let v5: Documents::US5 = Documents::method27(Documents::method26());
            let v11: Documents::US5 = match &v5 {
                Documents::US5::US5_0(v5_0_0) => Documents::US5::US5_0(
                    match &v5 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method27(string(
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
                _ => Documents::method27(string("/workspaces")),
            };
            let v21: string = match &v17 {
                Documents::US5::US5_0(v17_0_0) => match &v17 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v36: string = Documents::method28(
                if string("deps") == (Documents::method47(v21.clone())) {
                    let v29: Documents::US5 =
                        Documents::method27(Documents::method33(v21.clone()).clone().unwrap());
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
            let v37: string = Documents::method61(v3);
            let v38: string = Documents::method61(v2);
            let v39: string = Documents::method61(v1_1);
            let v42: () = {
                Documents::closure24(v0_1.clone(), v37.clone(), v38.clone(), v39.clone(), ());
                ()
            };
            let v90: bool = true;
            let __future_init = Box::pin(
                /*;
                let v92: bool = */
                async move {
                    /*;
                    let v94: bool = */
                    ();
                    let v96: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v38.clone());
                    let v99: async_walkdir::WalkDir =
                        async_walkdir::WalkDir::filter(v96, move |x| {
                            Func1::new(move |v: async_walkdir::DirEntry| {
                                Documents::closure25((), v)
                            })(x)
                        });
                    let v100 = Documents::method72();
                    let v102 = futures::stream::StreamExt::filter_map(v99, |x| async { v100(x) });
                    let v104: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                        Box::pin(futures::stream::StreamExt::collect(v102));
                    let v106: Vec<string> = v104.await;
                    let v109: () = {
                        Documents::closure34(v106.clone(), ());
                        ()
                    };
                    let v159: rayon::vec::IntoIter<string> =
                        rayon::iter::IntoParallelIterator::into_par_iter(v106);
                    let v162: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                        rayon::iter::ParallelIterator::map(v159, |x| {
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
                    let v164: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = rayon::iter::ParallelIterator::collect(v162);
                    let v171: string = string("}");
                    let v176: bool = true;
                    let _fix_closure_v173 = Ok::<
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
                    >(v164);
                    let v183: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v173 "), (v171))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v184: bool = true;
                    _fix_closure_v173
                },
            ); // rust.fix_closure';
            let v186 = __future_init;
            v186
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
        pub fn method193() -> Func1<
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
        pub fn method194() -> Func1<std::string::String, Documents::US37> {
            Func1::new(move |v: std::string::String| Documents::closure89((), v))
        }
        pub fn method195(
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
            let v9: string = Documents::method78(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
            ))
        }
        pub fn closure90(v0_1: std::string::String, unitVar: ()) {
            if Documents::method7(Documents::US0::US0_4) {
                let v5: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method195(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method76(),
                    v0_1,
                ))
            };
        }
        pub fn method197(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v11: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Documents::closure8(v2.clone(), string("result_len"), ());
                ()
            };
            let v33: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v42: std::string::String = format!("{:#?}", v0_1);
            let v81: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v42), ());
                ()
            };
            let v92: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method196(
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
            let v9: string = Documents::method197(v8);
            Documents::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("documents.main"),
                v9
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
                let v5: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Documents::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Documents::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Documents::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Documents::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                Documents::method19(Documents::method196(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Documents::method8(v26, v27, v28, v29, v30, v31),
                    Documents::method12(),
                    v0_1.len(),
                ))
            };
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Documents::closure2((), ());
                ()
            };
            let v20: () = {
                Documents::closure5(v0_1, ());
                ()
            };
            let v67: clap::Command = Documents::method0();
            let v69: clap::ArgMatches = clap::Command::get_matches(v67);
            let v70: string = Documents::method20();
            let v77: &str = &*v70;
            let v105: Option<std::string::String> =
                clap::ArgMatches::get_one(&v69.clone(), v77).cloned();
            let v130: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v105));
            let v137: std::string::String = match &v130 {
                Documents::US6::US6_0(v130_0_0) => match &v130 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v139: string = fable_library_rust::String_::fromString(v137);
            let v140: string = Documents::method22();
            let v147: &str = &*v140;
            let v175: Option<std::string::String> =
                clap::ArgMatches::get_one(&v69.clone(), v147).cloned();
            let v200: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v175));
            let v207: std::string::String = match &v200 {
                Documents::US6::US6_0(v200_0_0) => match &v200 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v209: string = fable_library_rust::String_::fromString(v207);
            let v210: string = Documents::method23();
            let v217: &str = &*v210;
            let v245: Option<std::string::String> =
                clap::ArgMatches::get_one(&v69.clone(), v217).cloned();
            let v270: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v245));
            let v277: std::string::String = match &v270 {
                Documents::US6::US6_0(v270_0_0) => match &v270 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v279: string = fable_library_rust::String_::fromString(v277);
            let v280: string = Documents::method24();
            let v287: &str = &*v280;
            let v315: Option<std::string::String> = clap::ArgMatches::get_one(&v69, v287).cloned();
            let v340: Documents::US6 =
                defaultValue(Documents::US6::US6_1, map(Documents::method21(), v315));
            let v347: std::string::String = match &v340 {
                Documents::US6::US6_0(v340_0_0) => match &v340 {
                    Documents::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v350: std::pin::Pin<
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
            > = Documents::method25(
                fable_library_rust::String_::fromString(v347),
                v279,
                v209,
                v139,
            );
            let v352: Result<
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
            > = futures::executor::block_on(v350);
            let v353 = Documents::method193();
            let v354 = Documents::method194();
            let v356: Documents::US37 = match &v352 {
                Err(v352_1_0) => v354(v352_1_0.clone()),
                Ok(v352_0_0) => v353(v352_0_0.clone()),
            };
            match &v356 {
                Documents::US37::US37_0(v356_0_0) => {
                    let v362: () = {
                        Documents::closure91(v356_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US37::US37_1(v356_1_0) => {
                    let v414: () = {
                        Documents::closure90(v356_1_0.clone(), ());
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
