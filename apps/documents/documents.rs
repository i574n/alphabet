#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)] #![recursion_limit = "512"]
use std::cell::RefCell;
use std::rc::Rc;
fn spiral_trace_hold<T: Clone>(fresh: &std::rc::Rc<dyn Fn() -> T>) -> T {
    use std::sync::OnceLock;
    static SLOT: OnceLock<usize> = OnceLock::new();
    let raw = *SLOT.get_or_init(|| Box::into_raw(Box::new((*fresh)())) as usize);
    unsafe { (*(raw as *const T)).clone() }
}
struct SpiralDebug<T>(T);
trait SpiralDebugShow {
    fn show(&self) -> String;
}
impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> {
    fn show(&self) -> String { format!("{:?}", self.0) }
}
trait SpiralTypeShow {
    fn show(&self) -> String;
}
impl<T> SpiralTypeShow for &SpiralDebug<T> {
    fn show(&self) -> String { String::from(std::any::type_name::<T>()) }
}
#[cfg(target_arch = "wasm32")]
fn spiral_cfg_local_clock() -> Option<[i64; 3]> { None }
#[cfg(all(windows, not(target_arch = "wasm32")))]
fn spiral_cfg_local_clock() -> Option<[i64; 3]> {
    #[repr(C)] struct St([u16; 8]);
    unsafe extern "system" { fn GetLocalTime(t: *mut St); }
    let mut t = St([0; 8]);
    unsafe { GetLocalTime(&mut t) };
    Some([i64::from(t.0[4]), i64::from(t.0[5]), i64::from(t.0[6])])
}
#[cfg(all(unix, not(target_arch = "wasm32")))]
fn spiral_cfg_local_clock() -> Option<[i64; 3]> {
    #[repr(C, align(8))] struct Tm([i32; 16]);
    unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; }
    let now = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs());
    let secs = std::os::raw::c_long::try_from(now.unwrap_or(0)).unwrap_or(0);
    let mut tm = Tm([0; 16]);
    unsafe { localtime_r(&secs, &mut tm) };
    Some([i64::from(tm.0[2]), i64::from(tm.0[1]), i64::from(tm.0[0])])
}
#[cfg(not(any(windows, unix, target_arch = "wasm32")))]
fn spiral_cfg_local_clock() -> Option<[i64; 3]> { None }
#[cfg(target_arch = "wasm32")]
fn spiral_cfg_epoch_nanos() -> u64 { near_sdk::env::block_timestamp() }
#[cfg(not(target_arch = "wasm32"))]
fn spiral_cfg_epoch_nanos() -> u64 {
    let since = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH);
    since.map(|d| u64::try_from(d.as_nanos()).unwrap_or(0)).unwrap_or(0)
}
#[cfg(target_arch = "wasm32")]
fn spiral_trace_near_log(text: &str) {
    use std::sync::atomic::{AtomicUsize, Ordering};
    static LOGGED: AtomicUsize = AtomicUsize::new(0);
    let cs: Vec<char> = text.chars().collect();
    for c in cs.chunks(15000) {
        let s: String = c.iter().collect();
        let used = LOGGED.load(Ordering::Relaxed);
        let budget = 16000usize.saturating_sub(used);
        if budget < 13 {
            break;
        }
        let s = if s.len() <= budget {
            s
        } else {
            let mut end = budget - 12;
            while !s.is_char_boundary(end) {
                end -= 1;
            }
            format!("{} [truncated]", &s[..end])
        };
        LOGGED.store(used + s.len(), Ordering::Relaxed);
        near_sdk::env::log_str(&s);
    }
}
fn string_slice(value: &str, from: i64, to: i64) -> Rc<str> {
    let bytes = value.as_bytes();
    let length = bytes.len() as i64;
    if from < 0 || from > length || to < from - 1 || to >= length { std::process::abort(); }
    if to < from { return { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) }; }
    if (bytes[from as usize] & 0xC0) == 0x80 || (to + 1 < length && (bytes[(to + 1) as usize] & 0xC0) == 0x80) { std::process::exit(3); }
    let slice = &bytes[from as usize..(to + 1) as usize];
    match std::str::from_utf8(slice) { Ok(text) => Rc::<str>::from(text), Err(error) => Rc::<str>::from(std::str::from_utf8(&slice[..error.valid_up_to()]).unwrap_or("")) }
}
#[derive(Clone)]
enum UH0 {
    UH0_Nil,
    UH0_Cons(Rc<str>, Rc<UH0>),
}
#[derive(Clone)]
enum US0 {
    US0_Some(Rc<str>),
    US0_None,
}
struct Mut0 { l0: i64 }
struct Mut1 { l0: Rc<dyn Fn(Rc<str>) -> ()> }
struct Mut2 { l0: bool }
struct Mut3 { l0: Rc<str> }
#[derive(Clone)]
enum US1 {
    US1_Verbose,
    US1_Debug,
    US1_Info,
    US1_Warning,
    US1_Critical,
}
struct Mut4 { l0: US1 }
#[derive(Clone)]
enum US2 {
    US2_Some(US1),
    US2_None,
}
struct Mut5 { l0: i32, l1: US2 }
#[derive(Clone)]
enum US3 {
    US3_Some(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US3_None,
}
#[derive(Clone)]
enum US4 {
    US4_Some([i64; 3]),
    US4_None,
}
struct Mut6 { l0: u64 }
#[derive(Clone)]
enum US5 {
    US5_Some(std::string::String),
    US5_None,
}
#[derive(Clone)]
enum US6 {
    US6_Ok(std::path::PathBuf),
    US6_Error(Rc<str>),
}
#[derive(Clone)]
enum US7 {
    US7_Some(std::path::PathBuf),
    US7_None,
}
#[derive(Clone)]
enum US8 {
    US8_File,
    US8_Directory,
}
#[derive(Clone)]
enum US9 {
    US9_Ok(Rc<str>),
    US9_Error(Rc<str>),
}
struct Mut7 { l0: i32, l1: i32, l2: Rc<RefCell<Vec<Rc<str>>>> }
struct Mut8 { l0: i32 }
enum US10 {
    US10_Ok(Vec<std::string::String>),
    US10_Error(std::io::Error),
}
#[derive(Clone)]
enum US11 {
    US11_Ok(Rc<str>, US0),
    US11_Error(Rc<str>),
}
#[derive(Clone)]
enum US12 {
    US12_Ok(u8, i32, i32, i32, i32, i32),
    US12_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US13 {
    US13_Ok(Rc<str>, i32, i32, i32, i32, i32),
    US13_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US14 {
    US14_Ok(i32, i32, i32, i32, i32),
    US14_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US16 {
    US16_Some(Rc<dyn Fn() -> Rc<str>>),
    US16_None,
}
#[derive(Clone)]
enum US15 {
    US15_Ok(Rc<dyn Fn() -> Rc<str>>, Rc<dyn Fn() -> US16>, i32, i32, i32, i32, i32),
    US15_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US17 {
    US17_Ok(US16, i32, i32, i32, i32, i32),
    US17_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US18 {
    US18_Ok(Rc<dyn Fn() -> Rc<str>>, Rc<dyn Fn() -> US16>, Rc<str>, i32, i32, i32, i32),
    US18_Error(Rc<dyn Fn() -> Rc<str>>),
}
#[derive(Clone)]
enum US19 {
    US19_Ok(Rc<str>, US0),
    US19_Error(Rc<dyn Fn() -> Rc<str>>),
}
#[derive(Clone)]
enum US20 {
    US20_Ok(Rc<RefCell<Vec<Rc<str>>>>),
    US20_Error(Rc<str>),
}
#[derive(Clone)]
enum US21 {
    US21_Ok(Rc<UH0>, i32, i32, i32, i32, i32),
    US21_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US22 {
    US22_Ok(Rc<UH0>, Rc<str>, i32, i32, i32, i32),
    US22_Error(Rc<dyn Fn() -> Rc<str>>),
}
#[derive(Clone)]
enum US23 {
    US23_Ok(Rc<RefCell<Vec<Rc<str>>>>),
    US23_Error(Rc<dyn Fn() -> Rc<str>>),
}
#[derive(Clone)]
enum US24 {
    US24_Ok(std::string::String),
    US24_Error(std::string::String),
}
#[derive(Clone)]
enum US25 {
    US25_Some(i32),
    US25_None,
}
#[derive(Clone)]
enum US26 {
    US26_Some(Result<Rc<str>, (Rc<str>, Rc<str>)>),
    US26_None,
}
#[derive(Clone)]
enum UH2 {
    UH2_Nil,
    UH2_Cons(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>, Rc<UH2>),
}
#[derive(Clone)]
enum UH1 {
    UH1_Nil,
    UH1_Cons(Rc<UH2>, Rc<UH1>),
}
#[derive(Clone)]
enum US27 {
    US27_Ok(Rc<str>),
    US27_Error(std::string::String),
}
#[derive(Clone)]
enum US28 {
    US28_Ok(u64),
    US28_Error(std::string::String),
}
#[derive(Clone)]
enum US29 {
    US29_Ok(i32, Rc<str>),
    US29_Error(i32, Rc<str>),
}
struct Mut9 { l0: i32, l1: i32 }
struct Mut10 { l0: i32, l1: Rc<str>, l2: i32, l3: i32, l4: bool }
#[derive(Clone)]
enum US30 {
    US30_Ok(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>),
    US30_Error(std::string::String),
}
fn command_line_argument_count_1() -> i32 {
    let mut v0: usize = std::env::args().count();
    let mut v1: i32 = ((v0) as i32);
    let mut v2: i32 = v1.wrapping_sub(1i32);
    v2
}
fn command_line_argument_2(mut v0: i32) -> Rc<str> {
    let mut v1: i32 = v0.wrapping_add(1i32);
    let mut v2: usize = ((v1) as usize);
    let mut v3: Rc<str> = Rc::<str>::from(std::env::args().nth(v2).unwrap_or_default());
    v3
}
fn arguments_from_0(mut v0: i32) -> Rc<UH0> {
    let mut v1: bool = v0 >= 0i32;
    let mut v4: bool = if v1 {
        let mut v2: i32 = command_line_argument_count_1();
        let mut v3: bool = v0 < v2;
        v3
    } else {
        false
    };
    let mut v8: US0 = if v4 {
        let mut v5: Rc<str> = command_line_argument_2(v0);
        US0::US0_Some(v5)
    } else {
        US0::US0_None
    };
    match &v8 {
        US0::US0_None => {
            { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) }
        }
        US0::US0_Some(v10) => {
            let mut v10: Rc<str> = v10.clone();
            let mut v11: i32 = v0.wrapping_add(1i32);
            let mut v12: Rc<UH0> = arguments_from_0(v11);
            Rc::new(UH0::UH0_Cons(v10, v12))
        }
    }
}
fn method3(mut v0: Rc<RefCell<Vec<Rc<str>>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                v0.borrow_mut().push(v3);
                let mut v5: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v4.clone(), v5);
                continue;
            }
            UH0::UH0_Nil => {
                return v2;
            }
        }
    }
}
fn get_environment_variable_5(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = Rc::<str>::from(std::env::var(&*v0).unwrap_or_default());
    v1
}
fn method6(mut v0: Rc<RefCell<Mut5>>) -> bool {
    let mut v1: i32 = v0.borrow().l0;
    let mut v2: bool = v1 > 0i32;
    v2
}
fn closure1() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn new_trace_state_4(mut v0: US1) -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("TRACE_LEVEL"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = get_environment_variable_5(v1.clone());
    ;
    ;
    ;
    ;
    ;
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = Rc::<str>::from(v3.to_lowercase());
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<str> = Rc::<str>::from(v5.to_lowercase());
    let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = Rc::<str>::from(v7.to_lowercase());
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
    let mut v13: Rc<RefCell<Vec<(Rc<str>, US1)>>> = Rc::new(RefCell::new(Vec::new()));
    let mut v14: US1 = US1::US1_Verbose;
    v13.borrow_mut().push((v11.clone(), v14.clone()));
    let v15: US1 = US1::US1_Debug;
    v13.borrow_mut().push((v9.clone(), v15.clone()));
    let mut v16: US1 = US1::US1_Info;
    v13.borrow_mut().push((v7.clone(), v16.clone()));
    let mut v17: US1 = US1::US1_Warning;
    v13.borrow_mut().push((v5.clone(), v17.clone()));
    let v18: US1 = US1::US1_Critical;
    v13.borrow_mut().push((v3.clone(), v18.clone()));
    let v19: US1 = US1::US1_Verbose;
    v13.borrow_mut().push((v12.clone(), v19.clone()));
    let mut v20: US1 = US1::US1_Debug;
    v13.borrow_mut().push((v10.clone(), v20.clone()));
    let v21: US1 = US1::US1_Info;
    v13.borrow_mut().push((v8.clone(), v21.clone()));
    let mut v22: US1 = US1::US1_Warning;
    v13.borrow_mut().push((v6.clone(), v22.clone()));
    let v23: US1 = US1::US1_Critical;
    v13.borrow_mut().push((v4.clone(), v23.clone()));
    let v24: Rc<Vec<(Rc<str>, US1)>> = Rc::new(v13.borrow().clone());
    let mut v25: Rc<RefCell<Vec<(Rc<str>, US1)>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
    let mut v26: i32 = (v25.clone().borrow().len() as i32);
    let mut v27: US2 = US2::US2_None;
    let mut v28: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: v26, l1: v27.clone() }));
    while method6(v28.clone()) {
        let v30: i32 = v28.borrow().l0;
        let mut v31: i32 = v30.wrapping_sub(1i32);
        let mut v32: US2 = v28.borrow().l1.clone();
        let (mut v33, mut v34): (Rc<str>, US1) = v25.clone().borrow()[v31 as usize].clone();
        let v41: US2 = match &v32 {
            US2::US2_None => {
                let v36: bool = v33 == v2 ;
                if v36 {
                    US2::US2_Some(v34.clone())
                } else {
                    US2::US2_None
                }
            }
            US2::US2_Some(v35) => {
                let mut v35: US1 = v35.clone();
                v32.clone()
            }
        };
        v28.borrow_mut().l0 = v31;
        v28.borrow_mut().l1 = v41.clone();
        ()
    };
    let v42: US2 = v28.borrow().l1.clone();
    let v43: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let mut v44: Rc<dyn Fn(Rc<str>) -> ()> = closure1();
    let mut v45: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v44.clone() }));
    let mut v46: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v48: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v47.clone() }));
    let v51: US1 = match &v42 {
        US2::US2_None => {
            v0.clone()
        }
        US2::US2_Some(v49) => {
            let mut v49: US1 = v49.clone();
            v49.clone()
        }
    };
    let mut v52: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v51.clone() }));
    let v53: Option<i64> = None;
    (v43.clone(), v45.clone(), v46.clone(), v48.clone(), v52.clone(), v53.clone())
}
fn fresh_c0() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US1 = US1::US1_Info;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_4(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c2() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US1 = US1::US1_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_4(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c3() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US1 = US1::US1_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_4(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method8(mut v0: Option<[i64; 3]>) -> Option<[i64; 3]> {
    v0
}
fn closure4() -> Rc<dyn Fn(([i64; 3])) -> US4> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(([i64; 3])) -> US4> = Rc::new(move |mut v0: ([i64; 3])| -> US4 {
        let mut v1: [i64; 3] = (v0);
        US4::US4_Some(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method7(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let mut v6: Option<[i64; 3]> = spiral_cfg_local_clock();
    let mut v7: Option<[i64; 3]> = method8(v6.clone());
    let mut v8: Rc<dyn Fn(([i64; 3])) -> US4> = closure4();
    let mut v9: Option<US4> = v7.map(|x| v8(x));
    let mut v11: US4 = US4::US4_None;
    let mut v12: US4 = v11.clone();
    let mut v13: US4 = v9.unwrap_or(v12);
    let mut v27: u64 = match &v13 {
        US4::US4_None => {
            let v23: u64 = spiral_cfg_epoch_nanos();
            let v24: u64 = v23.wrapping_div(1000000000u64);
            let mut v25: u64 = v24.wrapping_rem(86400u64);
            v25
        }
        US4::US4_Some(v14) => {
            let mut v14: [i64; 3] = v14.clone();
            let v15: i64 = v14[0];
            let mut v16: i64 = v15.wrapping_mul(3600i64);
            let mut v17: i64 = v14[1];
            let v18: i64 = v17.wrapping_mul(60i64);
            let v19: i64 = v16.wrapping_add(v18);
            let mut v20: i64 = v14[2];
            let v21: i64 = v19.wrapping_add(v20);
            let mut v22: u64 = (v21 as u64);
            v22
        }
    };
    let mut v28: u64 = v27.wrapping_div(3600u64);
    let mut v29: u64 = v28.wrapping_rem(24u64);
    let v30: bool = v29 < 10u64;
    let mut v33: Rc<str> = if v30 {
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v31.clone()
    } else {
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v32.clone()
    };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v33, Rc::<str>::from(format!("{:?}", v29))));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v36));
    let mut v38: u64 = v27.wrapping_div(60u64);
    let v39: u64 = v38.wrapping_rem(60u64);
    let v40: bool = v39 < 10u64;
    let v43: Rc<str> = if v40 {
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v41.clone()
    } else {
        let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v42.clone()
    };
    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v37, Rc::<str>::from(format!("{}{}", v43, Rc::<str>::from(format!("{:?}", v39)))))), v36));
    let mut v48: u64 = v27.wrapping_rem(60u64);
    let mut v49: bool = v48 < 10u64;
    let mut v52: Rc<str> = if v49 {
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v50.clone()
    } else {
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v51.clone()
    };
    let v55: Rc<str> = Rc::<str>::from(format!("{}{}", v47, Rc::<str>::from(format!("{}{}", v52, Rc::<str>::from(format!("{:?}", v48))))));
    v55.clone()
}
fn method11(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3;
    ()
}
fn format_real_10(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method11(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method9() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[92m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_10(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method14(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v1;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v11: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'\t';
                if v6 {
                    true
                } else {
                    let mut v7: bool = v4 == b'\r';
                    if v7 {
                        true
                    } else {
                        let mut v8: bool = v4 == b'\n';
                        v8
                    }
                }
            };
            if v11 {
                let mut v12: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v1, v12);
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn method15(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 <= 0i32;
        if v2 {
            return -1i32;
        } else {
            let mut v3: i32 = v1.wrapping_sub(1i32);
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v7: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'/';
                v6
            };
            if v7 {
                (v0, v1) = (v0.clone(), v3);
                continue;
            } else {
                return v3;
            }
        }
    }
}
fn method13(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: i32 = 0i32;
    let mut v3: i32 = method14(v0.clone(), v1, v2);
    let mut v4: i32 = v1.wrapping_sub(1i32);
    let mut v5: Rc<str> = string_slice(&v0, v3 as i64, v4 as i64);
    let mut v6: i32 = (v5.clone().len() as i32);
    let mut v7: i32 = method15(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5, 0i32 as i64, v7 as i64);
    v8
}
fn format_real_16(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method11(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method18(mut v0: u64, mut v1: Rc<RefCell<Mut6>>) -> bool {
    let mut v2: u64 = v1.borrow().l0;
    let mut v3: bool = v2 < v0;
    v3
}
fn method17(mut v0: Rc<RefCell<Vec<Rc<str>>>>) -> Rc<str> {
    let mut v1: u64 = (v0.clone().borrow().len() as u64);
    let mut v2: u64 = 0u64;
    let mut v3: Rc<RefCell<Mut6>> = Rc::new(RefCell::new(Mut6 { l0: v2 }));
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    while method18(v1, v3.clone()) {
        let mut v7: u64 = v3.borrow().l0;
        let mut v8: Rc<str> = v0.clone().borrow()[v7 as usize].clone();
        let mut v9: bool = v7 == 0u64;
        let mut v14: Rc<str> = if v9 {
            v8.clone()
        } else {
            let mut v10: Rc<str> = v5.borrow().l0.clone();
            let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(", "); } LIT.with(|lit| lit.clone()) };
            let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v10, v11)), v8));
            v13.clone()
        };
        v5.borrow_mut().l0 = v14.clone();
        let v15: u64 = v7.wrapping_add(1u64);
        v3.borrow_mut().l0 = v15;
        ()
    };
    let mut v16: Rc<str> = v5.borrow().l0.clone();
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("["); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v16));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("]"); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    v20.clone()
}
fn method12(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<RefCell<Vec<Rc<str>>>>) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0;
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_16(v9);
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v11, v12)), v7)), v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.main"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("args"); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("args"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("args = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = method17(v8);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v27));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", v29, v30))));
    method13(v32)
}
fn closure5() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn get_command_19() -> clap::Command {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("command"); } LIT.with(|lit| lit.clone()) };
    let mut v1: &'static str = Box::leak(String::from(&*v0).into_boxed_str());
    let mut v3: clap::Command = clap::Command::new(v1);
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("source-dir"); } LIT.with(|lit| lit.clone()) };
    let mut v5: &'static str = Box::leak(String::from(&*v4).into_boxed_str());
    let mut v7: clap::Arg = clap::Arg::new(v5);
    let mut v9: clap::Arg = v7.short(b's' as char);
    let mut v10: &'static str = Box::leak(String::from(&*v4).into_boxed_str());
    let mut v12: clap::Arg = v9.long(v10);
    let mut v14: clap::Arg = v12.required(true);
    let mut v16: clap::Command = clap::Command::arg(v3, v14);
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist-dir"); } LIT.with(|lit| lit.clone()) };
    let v18: &'static str = Box::leak(String::from(&*v17).into_boxed_str());
    let mut v20: clap::Arg = clap::Arg::new(v18);
    let mut v22: clap::Arg = v20.short(b'd' as char);
    let v23: &'static str = Box::leak(String::from(&*v17).into_boxed_str());
    let mut v25: clap::Arg = v22.long(v23);
    let mut v27: clap::Arg = v25.required(true);
    let mut v29: clap::Command = clap::Command::arg(v16, v27);
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache-dir"); } LIT.with(|lit| lit.clone()) };
    let mut v31: &'static str = Box::leak(String::from(&*v30).into_boxed_str());
    let mut v33: clap::Arg = clap::Arg::new(v31);
    let mut v35: clap::Arg = v33.short(b'c' as char);
    let v36: &'static str = Box::leak(String::from(&*v30).into_boxed_str());
    let mut v38: clap::Arg = v35.long(v36);
    let v40: clap::Arg = v38.required(true);
    let v42: clap::Command = clap::Command::arg(v29, v40);
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul-spec"); } LIT.with(|lit| lit.clone()) };
    let mut v44: &'static str = Box::leak(String::from(&*v43).into_boxed_str());
    let mut v46: clap::Arg = clap::Arg::new(v44);
    let mut v48: clap::Arg = v46.short(b'H' as char);
    let mut v49: &'static str = Box::leak(String::from(&*v43).into_boxed_str());
    let v51: clap::Arg = v48.long(v49);
    let v53: clap::Command = clap::Command::arg(v42, v51);
    let v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("filter"); } LIT.with(|lit| lit.clone()) };
    let v55: &'static str = Box::leak(String::from(&*v54).into_boxed_str());
    let mut v57: clap::Arg = clap::Arg::new(v55);
    let mut v59: clap::Arg = v57.short(b'f' as char);
    let v60: &'static str = Box::leak(String::from(&*v54).into_boxed_str());
    let v62: clap::Arg = v59.long(v60);
    let v64: clap::Command = clap::Command::arg(v53, v62);
    let mut v65: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("transcribe-only"); } LIT.with(|lit| lit.clone()) };
    let v66: &'static str = Box::leak(String::from(&*v65).into_boxed_str());
    let mut v68: clap::Arg = clap::Arg::new(v66);
    let mut v70: clap::Arg = v68.short(b't' as char);
    let v71: &'static str = Box::leak(String::from(&*v65).into_boxed_str());
    let mut v73: clap::Arg = v70.long(v71);
    let v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("false"); } LIT.with(|lit| lit.clone()) };
    let mut v75: &str = (&*v74);
    let mut v77: clap::Arg = v73.default_value(&*Box::leak(String::from(v75).into_boxed_str()));
    let mut v79: clap::ArgAction = clap::ArgAction::SetTrue;
    let mut v81: clap::Arg = v77.action(v79);
    let mut v83: clap::Command = clap::Command::arg(v64, v81);
    v83
}
fn method20() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("source-dir"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method21(mut v0: Option<std::string::String>) -> Option<std::string::String> {
    v0
}
fn closure6() -> Rc<dyn Fn((std::string::String)) -> US5> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::string::String)) -> US5> = Rc::new(move |mut v0: (std::string::String)| -> US5 {
        let mut v1: std::string::String = (v0);
        US5::US5_Some(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method22() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist-dir"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method23() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache-dir"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method24() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul-spec"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method25() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("filter"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method26() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("transcribe-only"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method33(mut v0: Option<Rc<str>>) -> Option<Rc<str>> {
    v0
}
fn closure7() -> Rc<dyn Fn((Rc<str>)) -> US0> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((Rc<str>)) -> US0> = Rc::new(move |mut v0: (Rc<str>)| -> US0 {
        let mut v1: Rc<str> = (v0);
        US0::US0_Some(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn get_file_name_32(mut v0: Rc<str>) -> Rc<str> {
    let mut v2: &str = &*v0;
    let mut v4: std::string::String = String::from(v2);
    let mut v6: std::path::PathBuf = std::path::PathBuf::from(v4);
    let mut v8: Option<&std::ffi::OsStr> = v6.file_name();
    let mut v10: bool = true; let _optionm_map_ = v8.map(|x| { //;
    let mut v12: &std::ffi::OsStr = x;
    let mut v14: std::ffi::OsString = v12.to_os_string();
    let mut v16: Option<&str> = v14.to_str();
    let v18: &str = v16.unwrap();
    let mut v20: std::string::String = String::from(v18);
    let mut v22: Rc<str> = Rc::<str>::from(String::as_str(&v20));
    let v24: bool = true; v22 });
    let mut v26: Option<Rc<str>> = _optionm_map_;
    let mut v27: Option<Rc<str>> = method33(v26.clone());
    let mut v28: Rc<dyn Fn((Rc<str>)) -> US0> = closure7();
    let mut v29: Option<US0> = v27.map(|x| v28(x));
    let mut v31: US0 = US0::US0_None;
    let mut v32: US0 = v31.clone();
    let mut v33: US0 = v29.unwrap_or(v32);
    match &v33 {
        US0::US0_None => {
            let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v35.clone()
        }
        US0::US0_Some(v34) => {
            let mut v34: Rc<str> = v34.clone();
            v34.clone()
        }
    }
}
fn method35(mut v0: std::path::PathBuf) -> std::path::PathBuf {
    v0
}
fn directory_get_parent_34(mut v0: Rc<str>) -> Option<Rc<str>> {
    let mut v2: &str = &*v0;
    let mut v4: std::string::String = String::from(v2);
    let mut v6: std::path::PathBuf = std::path::PathBuf::from(v4);
    let mut v8: Option<std::path::PathBuf> = v6.parent().map(std::path::PathBuf::from);
    let mut v10: bool = true; let _optionm_map_ = v8.map(|x| { //;
    let mut v12: std::path::PathBuf = x;
    let mut v13: std::path::PathBuf = method35(v12.clone());
    let v15: std::path::Display = v13.display();
    let mut v17: std::string::String = format!("{}", v15);
    let v19: Rc<str> = Rc::<str>::from(String::as_str(&v17));
    let v21: bool = true; v19 });
    let v23: Option<Rc<str>> = _optionm_map_;
    v23.clone()
}
fn closure8() -> Rc<dyn Fn(std::io::Error) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::io::Error) -> Rc<str>> = Rc::new(move |mut v0: std::io::Error| -> Rc<str> {
        let mut v1: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::io::Error>") } } (&&W(&v0)).s() });
        v1.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method36() -> Rc<dyn Fn(std::io::Error) -> Rc<str>> {
    closure8()
}
fn ok_c9() -> Rc<dyn Fn(std::path::PathBuf) -> US6> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::path::PathBuf) -> US6> = Rc::new(move |mut v0: std::path::PathBuf| -> US6 {
        US6::US6_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method37() -> Rc<dyn Fn(std::path::PathBuf) -> US6> {
    ok_c9()
}
fn error_c10() -> Rc<dyn Fn(Rc<str>) -> US6> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> US6> = Rc::new(move |mut v0: Rc<str>| -> US6 {
        US6::US6_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method38() -> Rc<dyn Fn(Rc<str>) -> US6> {
    error_c10()
}
fn method39(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    let mut v3: &str = &*v0;
    let mut v5: std::string::String = String::from(v3);
    let mut v7: std::path::PathBuf = std::path::PathBuf::from(v5);
    let mut v9: &str = &*v1;
    let mut v11: std::string::String = String::from(v9);
    let mut v13: std::path::PathBuf = v7.join(v11);
    let mut v14: std::path::PathBuf = method35(v13);
    let mut v16: std::path::Display = v14.display();
    let v18: std::string::String = format!("{}", v16);
    let mut v20: Rc<str> = Rc::<str>::from(String::as_str(&v18));
    v20
}
fn run_31(mut v0: Rc<str>, mut v1: Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>>, mut v2: u8, mut v3: Rc<str>, mut v4: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v5: Rc<str> = get_file_name_32(v4.clone());
    let mut v6: Option<Rc<str>> = directory_get_parent_34(v4.clone());
    let mut v7: Option<Rc<str>> = method33(v6.clone());
    let mut v8: Rc<dyn Fn((Rc<str>)) -> US0> = closure7();
    let mut v9: Option<US0> = v7.map(|x| v8(x));
    let mut v11: US0 = US0::US0_None;
    let mut v12: US0 = v11.clone();
    let mut v13: US0 = v9.unwrap_or(v12);
    let mut v14: bool = v2 >= 11u8;
    if v14 {
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("path: {} / n: {} / path': {} / name: {}", v0, v2, v4, v5));
        let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
        let v19: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v17);
        let v21: Result<std::path::PathBuf, std::io::Error> = Err(v19);
        v21
    } else {
        match &v13 {
            US0::US0_Some(v22) => {
                let mut v22: Rc<str> = v22.clone();
                let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v24: bool = v4 != v23 ;
                if v24 {
                    let mut v25: u8 = v2.wrapping_add(1u8);
                    let mut v26: Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> = v1(v25);
                    let mut v27: Result<std::path::PathBuf, std::io::Error> = v26(v22.clone());
                    let mut v28: Rc<dyn Fn(std::io::Error) -> Rc<str>> = method36();
                    let v30: Result<std::path::PathBuf, Rc<str>> = v27.map_err(|x| v28(x));
                    let mut v31: Rc<dyn Fn(std::path::PathBuf) -> US6> = method37();
                    let mut v32: Rc<dyn Fn(Rc<str>) -> US6> = method38();
                    let mut v33: US6 = match v30 { Ok(x) => v31(x), Err(e) => v32(e) };
                    match &v33 {
                        US6::US6_Error(v48) => {
                            let mut v48: Rc<str> = v48.clone();
                            let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / "); } LIT.with(|lit| lit.clone()) };
                            let v50: Rc<str> = Rc::<str>::from(format!("error': {} / error: {} / name: {}", v48, v3, v5));
                            let v51: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v50));
                            let v53: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v51);
                            let v55: Result<std::path::PathBuf, std::io::Error> = Err(v53);
                            v55
                        }
                        US6::US6_Ok(v34) => {
                            let mut v34: std::path::PathBuf = v34.clone();
                            let mut v35: std::path::PathBuf = method35(v34.clone());
                            let v37: std::path::Display = v35.display();
                            let mut v38: Rc<str> = Rc::<str>::from(format!("{}", v37));
                            let v39: Rc<str> = method39(v38.clone(), v5.clone());
                            let v41: &str = &*v39;
                            let v43: std::string::String = String::from(v41);
                            let mut v45: std::path::PathBuf = std::path::PathBuf::from(v43);
                            let mut v47: Result<std::path::PathBuf, std::io::Error> = Ok(v45);
                            v47
                        }
                    }
                } else {
                    let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / run / The file or directory is not a reparse point. / "); } LIT.with(|lit| lit.clone()) };
                    let mut v59: Rc<str> = Rc::<str>::from(format!("path: {} / error: {} / path': {} / name: {}", v0, v3, v4, v5));
                    let v60: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v59));
                    let v62: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v60);
                    let v64: Result<std::path::PathBuf, std::io::Error> = Err(v62);
                    v64
                }
            }
            _ => {
                let v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / run / The file or directory is not a reparse point. / "); } LIT.with(|lit| lit.clone()) };
                let v67: Rc<str> = Rc::<str>::from(format!("path: {} / error: {} / path': {} / name: {}", v0, v3, v4, v5));
                let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v66, v67));
                let mut v70: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v68);
                let v72: Result<std::path::PathBuf, std::io::Error> = Err(v70);
                v72
            }
        }
    }
}
fn closure12(mut v0: Rc<str>, mut v1: u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> {
    Rc::new(move |mut v2: Rc<str>| -> Result<std::path::PathBuf, std::io::Error> {
        method30(v0.clone(), v1, v2.clone())
    })
}
fn closure11(mut v0: Rc<str>) -> Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>> {
    Rc::new(move |mut v1: u8| -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> {
        closure12(v0.clone(), v1)
    })
}
fn method30(mut v0: Rc<str>, mut v1: u8, mut v2: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v4: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2);
    let mut v5: Rc<dyn Fn(std::io::Error) -> Rc<str>> = method36();
    let mut v7: Result<std::path::PathBuf, Rc<str>> = v4.map_err(|x| v5(x));
    let mut v8: Rc<dyn Fn(std::path::PathBuf) -> US6> = method37();
    let mut v9: Rc<dyn Fn(Rc<str>) -> US6> = method38();
    let mut v10: US6 = match v7 { Ok(x) => v8(x), Err(e) => v9(e) };
    match &v10 {
        US6::US6_Error(v14) => {
            let mut v14: Rc<str> = v14.clone();
            let v15: Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>> = closure11(v0.clone());
            run_31(v0.clone(), v15.clone(), v1, v14.clone(), v2.clone())
        }
        US6::US6_Ok(v11) => {
            let mut v11: std::path::PathBuf = v11.clone();
            let mut v13: Result<std::path::PathBuf, std::io::Error> = Ok(v11);
            v13
        }
    }
}
fn directory_exists_40(mut v0: Rc<str>) -> bool {
    let mut v2: &str = &*v0;
    let mut v4: std::string::String = String::from(v2);
    let mut v6: std::path::PathBuf = std::path::PathBuf::from(v4);
    let mut v8: bool = v6.exists();
    if v8 {
        let mut v10: bool = v6.is_dir();
        v10
    } else {
        false
    }
}
fn read_link_29(mut v0: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v1: bool = directory_exists_40(v0.clone());
    if v1 {
        let mut v3: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0);
        v3
    } else {
        let mut v4: u8 = 0u8;
        method30(v0.clone(), v4, v0)
    }
}
fn method41(mut v0: Option<std::path::PathBuf>) -> Option<std::path::PathBuf> {
    v0
}
fn closure13() -> Rc<dyn Fn((std::path::PathBuf)) -> US7> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::path::PathBuf)) -> US7> = Rc::new(move |mut v0: (std::path::PathBuf)| -> US7 {
        let mut v1: std::path::PathBuf = (v0);
        US7::US7_Some(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn normalize_path_28(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: bool = &*v0 == "";
    if v1 {
        let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v2.clone()
    } else {
        let mut v3: Result<std::path::PathBuf, std::io::Error> = read_link_29(v0.clone());
        let mut v5: Option<std::path::PathBuf> = v3.ok();
        let mut v6: Option<std::path::PathBuf> = method41(v5.clone());
        let mut v7: Rc<dyn Fn((std::path::PathBuf)) -> US7> = closure13();
        let mut v8: Option<US7> = v6.map(|x| v7(x));
        let mut v10: US7 = US7::US7_None;
        let mut v11: US7 = v10.clone();
        let mut v12: US7 = v8.unwrap_or(v11);
        let v19: Rc<str> = match &v12 {
            US7::US7_None => {
                v0.clone()
            }
            US7::US7_Some(v13) => {
                let mut v13: std::path::PathBuf = v13.clone();
                let mut v14: std::path::PathBuf = method35(v13.clone());
                let mut v16: std::path::Display = v14.display();
                let mut v17: Rc<str> = Rc::<str>::from(format!("{}", v16));
                v17.clone()
            }
        };
        let mut v20: bool = &*v19 == "";
        let v21: Rc<str> = if v20 {
            v0.clone()
        } else {
            v19.clone()
        };
        let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\\\?\\"); } LIT.with(|lit| lit.clone()) };
        let v23: bool = v21.starts_with(&*v22);
        let v30: Rc<str> = if v23 {
            let v24: i32 = (v21.clone().len() as i32);
            let mut v25: i32 = v24.wrapping_sub(4i32);
            let mut v26: usize = ((4i32) as usize);
            let mut v27: i32 = 4i32.wrapping_add(v25);
            let mut v28: usize = ((v27) as usize);
            let mut v29: Rc<str> = Rc::<str>::from(&(v21)[v26..v28]);
            v29.clone()
        } else {
            v21.clone()
        };
        let mut v31: i32 = (v30.clone().len() as i32);
        let mut v32: bool = v31 < 2i32;
        if v32 {
            v0.clone()
        } else {
            let mut v33: Rc<str> = string_slice(&v30.clone(), 0i32 as i64, 0i32 as i64);
            let mut v34: Rc<str> = Rc::<str>::from(v33.to_lowercase());
            let mut v35: i32 = v31.wrapping_sub(1i32);
            let v36: Rc<str> = string_slice(&v30.clone(), 1i32 as i64, v35 as i64);
            let v37: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v36));
            let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let v40: Rc<str> = Rc::<str>::from(v37.replace(&*v38, &*v39));
            v40.clone()
        }
    }
}
fn get_current_directory_42() -> Rc<str> {
    let mut v1: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
    let mut v3: std::path::PathBuf = v1.unwrap();
    let mut v4: std::path::PathBuf = method35(v3);
    let mut v6: std::path::Display = v4.display();
    let mut v8: std::string::String = format!("{}", v6);
    let mut v10: Rc<str> = Rc::<str>::from(String::as_str(&v8));
    v10
}
fn method45(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<dyn Fn(Rc<str>) -> bool>, mut v4: Rc<str>) -> US9 {
    loop {
        let mut v5: Rc<str> = method39(v4.clone(), v0.clone());
        let mut v6: bool = v3(v5.clone());
        if v6 {
            return US9::US9_Ok(v4.clone());
        } else {
            let mut v8: Option<Rc<str>> = directory_get_parent_34(v4.clone());
            let mut v9: Option<Rc<str>> = method33(v8.clone());
            let mut v10: Rc<dyn Fn((Rc<str>)) -> US0> = closure7();
            let mut v11: Option<US0> = v9.map(|x| v10(x));
            let mut v13: US0 = US0::US0_None;
            let mut v14: US0 = v13.clone();
            let v15: US0 = v11.unwrap_or(v14);
            match &v15 {
                US0::US0_None => {
                    let mut v20: Rc<str> = if v2 {
                        let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
                        v18.clone()
                    } else {
                        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir"); } LIT.with(|lit| lit.clone()) };
                        v19.clone()
                    };
                    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.find_parent / No parent for "); } LIT.with(|lit| lit.clone()) };
                    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v20));
                    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" '"); } LIT.with(|lit| lit.clone()) };
                    let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v0));
                    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("' at '"); } LIT.with(|lit| lit.clone()) };
                    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v1));
                    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("' (until '"); } LIT.with(|lit| lit.clone()) };
                    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v4));
                    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("')"); } LIT.with(|lit| lit.clone()) };
                    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
                    return US9::US9_Error(v33.clone());
                }
                US0::US0_Some(v16) => {
                    let mut v16: Rc<str> = v16.clone();
                    (v0, v1, v2, v3, v4) = (v0.clone(), v1.clone(), v2, v3.clone(), v16.clone());
                    continue;
                }
            }
        }
    }
}
fn file_exists_46(mut v0: Rc<str>) -> bool {
    let mut v2: &str = &*v0;
    let mut v4: std::string::String = String::from(v2);
    let mut v6: std::path::PathBuf = std::path::PathBuf::from(v4);
    let mut v8: bool = v6.exists();
    if v8 {
        let mut v10: bool = v6.is_file();
        v10
    } else {
        false
    }
}
fn closure14() -> Rc<dyn Fn(Rc<str>) -> bool> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> bool> = Rc::new(move |mut v0: Rc<str>| -> bool {
        file_exists_46(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure15() -> Rc<dyn Fn(Rc<str>) -> bool> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> bool> = Rc::new(move |mut v0: Rc<str>| -> bool {
        directory_exists_40(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn find_parent_44(mut v0: US8, mut v1: Rc<str>, mut v2: Rc<str>) -> US9 {
    let mut v3: bool = match &v0 {
        US8::US8_File => {
            true
        }
        _ => {
            false
        }
    };
    let mut v6: Rc<dyn Fn(Rc<str>) -> bool> = if v3 {
        closure14()
    } else {
        closure15()
    };
    method45(v1, v2.clone(), v3, v6, v2)
}
fn method47() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[93m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_10(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method48(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0;
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_16(v10);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v7)), v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.get_workspace_root"); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v24, v25)), v8));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v25)), v9));
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v33));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v35, v36))));
    method13(v38)
}
fn run_43(mut v0: Rc<str>) -> US0 {
    let mut v1: US8 = US8::US8_Directory;
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("spiral"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("workspace"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = method39(v2, v3);
    let mut v5: US9 = find_parent_44(v1, v4, v0.clone());
    match &v5 {
        US9::US9_Error(v9) => {
            let mut v9: Rc<str> = v9.clone();
            let mut v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
            { let _ = spiral_trace_hold(&v11); };
            let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
            let mut v20: US1 = v18.borrow().l0.clone();
            let mut v25: i32 = match &v20 {
                US1::US1_Critical => {
                    50i32
                }
                US1::US1_Debug => {
                    20i32
                }
                US1::US1_Info => {
                    30i32
                }
                US1::US1_Verbose => {
                    10i32
                }
                US1::US1_Warning => {
                    40i32
                }
            };
            let mut v26: bool = v16.borrow().l0;
            let mut v27: bool = v26 == false;
            let mut v29: bool = if v27 {
                false
            } else {
                let mut v28: bool = 40i32 >= v25;
                v28
            };
            let v30: bool = v29 == false;
            let v78: US3 = if v30 {
                US3::US3_None
            } else {
                { let _ = spiral_trace_hold(&v11); };
                let (mut v34, mut v35, mut v36, mut v37, mut v38, mut v39): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                let v40: Rc<str> = method7(v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone());
                let v41: Rc<str> = method47();
                let v42: Rc<str> = method48(v34, v35, v36, v37, v38, v39, v40, v41, v0, v9);
                { let _ = spiral_trace_hold(&v11); };
                let (mut v45, mut v46, mut v47, mut v48, mut v49, mut v50): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v13);
                let v51: i64 = v45.borrow().l0;
                let mut v52: i64 = v51.wrapping_add(1i64);
                v45.borrow_mut().l0 = v52;
                let v53: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v54: bool = cfg!(target_arch = "wasm32");
                if v54 {
                    let v55: Rc<str> = v48.borrow().l0.clone();
                    let v56: bool = &*v55 == "";
                    let v64: Rc<str> = if v56 {
                        v42.clone()
                    } else {
                        let mut v57: bool = &*v42 == "";
                        if v57 {
                            let v58: Rc<str> = v48.borrow().l0.clone();
                            v58
                        } else {
                            let mut v59: Rc<str> = v48.borrow().l0.clone();
                            let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v62: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v59, v60)), v42));
                            v62
                        }
                    };
                    let v66: usize = v64.chars().count();
                    let v67: i32 = ((v66) as i32);
                    let mut v68: i32 = v67.wrapping_add(14999i32);
                    let v69: i32 = v68.wrapping_div(15000i32);
                    let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v71: bool = v42 != v70 ;
                    let mut v73: bool = if v71 {
                        let v72: bool = v69 <= 1i32;
                        v72
                    } else {
                        false
                    };
                    if v73 {
                        v48.borrow_mut().l0 = v64.clone();
                        ()
                    } else {
                        v48.borrow_mut().l0 = v70;
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v64); };
                        ()
                    }
                } else {
                    println!("{}", v42);
                    ()
                };
                let mut v76: Rc<dyn Fn(Rc<str>) -> ()> = v46.borrow().l0.clone();
                v76(v42);
                US3::US3_Some(v45, v46, v47, v48, v49, v50)
            };
            US0::US0_None
        }
        US9::US9_Ok(v6) => {
            let mut v6: Rc<str> = v6.clone();
            let mut v7: Rc<str> = normalize_path_28(v6);
            US0::US0_Some(v7)
        }
    }
}
fn method50(mut v0: Rc<RefCell<Mut7>>) -> bool {
    let mut v1: i32 = v0.borrow().l0;
    let mut v2: bool = v1 > 0i32;
    v2
}
fn method51(mut v0: i32, mut v1: Rc<RefCell<Mut8>>) -> bool {
    let mut v2: i32 = v1.borrow().l0;
    let mut v3: bool = v2 < v0;
    v3
}
fn directory_separator_char_52() -> u8 {
    let mut v0: u8 = (std::path::MAIN_SEPARATOR as u8);
    v0
}
fn get_full_path_49(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = get_current_directory_42();
    let mut v2: Rc<str> = method39(v1.clone(), v0.clone());
    let mut v3: Rc<str> = normalize_path_28(v2.clone());
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v3.split(&*v4).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let mut v6: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![]));
    let mut v7: i32 = (v5.clone().borrow().len() as i32);
    let mut v8: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: v7, l1: 0i32, l2: v6.clone() }));
    while method50(v8.clone()) {
        let mut v10: i32 = v8.borrow().l0;
        let mut v11: i32 = v10.wrapping_sub(1i32);
        let (mut v12, mut v13): (i32, Rc<RefCell<Vec<Rc<str>>>>) = (v8.borrow().l1, v8.borrow().l2.clone());
        let mut v14: Rc<str> = v5.clone().borrow()[v11 as usize].clone();
        let v15: bool = ".." == &*v14;
        let (mut v64, mut v65): (i32, Rc<RefCell<Vec<Rc<str>>>>) = if v15 {
            let mut v16: i32 = v12.wrapping_add(1i32);
            (v16, v13.clone())
        } else {
            let mut v17: bool = "." == &*v14;
            if v17 {
                (v12, v13.clone())
            } else {
                let v18: bool = 0i32 == v12;
                if v18 {
                    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
                    let mut v20: bool = v14.ends_with(&*v19);
                    if v20 {
                        let v21: Rc<str> = string_slice(&v1.clone(), 0i32 as i64, 0i32 as i64);
                        let mut v22: Rc<str> = string_slice(&v14.clone(), 0i32 as i64, 0i32 as i64);
                        let v23: Rc<str> = Rc::<str>::from(v22.to_lowercase());
                        let v24: Rc<str> = Rc::<str>::from(v21.to_lowercase());
                        let mut v25: bool = &*v23 == &*v24;
                        let mut v27: Rc<str> = if v25 {
                            v21.clone()
                        } else {
                            let mut v26: Rc<str> = Rc::<str>::from(v22.to_uppercase());
                            v26.clone()
                        };
                        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v19));
                        let mut v29: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![v28.clone()]));
                        let v30: i32 = (v29.clone().borrow().len() as i32);
                        let mut v31: i32 = (v13.clone().borrow().len() as i32);
                        let mut v32: i32 = v30.wrapping_add(v31);
                        let mut v33: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v32 as usize]));
                        let mut v34: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32 }));
                        while method51(v32, v34.clone()) {
                            let v36: i32 = v34.borrow().l0;
                            let v37: bool = v36 < v30;
                            let v41: Rc<str> = if v37 {
                                let mut v38: Rc<str> = v29.clone().borrow()[v36 as usize].clone();
                                v38.clone()
                            } else {
                                let v39: i32 = v36.wrapping_sub(v30);
                                let v40: Rc<str> = v13.clone().borrow()[v39 as usize].clone();
                                v40.clone()
                            };
                            v33.clone().borrow_mut()[v36 as usize] = v41.clone();
                            let v42: i32 = v36.wrapping_add(1i32);
                            v34.borrow_mut().l0 = v42;
                            ()
                        };
                        (0i32, v33.clone())
                    } else {
                        let v43: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![v14.clone()]));
                        let mut v44: i32 = (v43.clone().borrow().len() as i32);
                        let mut v45: i32 = (v13.clone().borrow().len() as i32);
                        let mut v46: i32 = v44.wrapping_add(v45);
                        let mut v47: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v46 as usize]));
                        let mut v48: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32 }));
                        while method51(v46, v48.clone()) {
                            let v50: i32 = v48.borrow().l0;
                            let v51: bool = v50 < v44;
                            let v55: Rc<str> = if v51 {
                                let mut v52: Rc<str> = v43.clone().borrow()[v50 as usize].clone();
                                v52.clone()
                            } else {
                                let v53: i32 = v50.wrapping_sub(v44);
                                let v54: Rc<str> = v13.clone().borrow()[v53 as usize].clone();
                                v54.clone()
                            };
                            v47.clone().borrow_mut()[v50 as usize] = v55.clone();
                            let v56: i32 = v50.wrapping_add(1i32);
                            v48.borrow_mut().l0 = v56;
                            ()
                        };
                        (0i32, v47.clone())
                    }
                } else {
                    let mut v59: i32 = v12.wrapping_sub(1i32);
                    (v59, v13.clone())
                }
            }
        };
        v8.borrow_mut().l0 = v11;
        v8.borrow_mut().l1 = v64;
        v8.borrow_mut().l2 = v65.clone();
        ()
    };
    let (mut v66, mut v67): (i32, Rc<RefCell<Vec<Rc<str>>>>) = (v8.borrow().l1, v8.borrow().l2.clone());
    let mut v68: Rc<Vec<Rc<str>>> = Rc::new(v67.borrow().clone());
    let v69: u8 = directory_separator_char_52();
    let mut v70: Rc<str> = Rc::<str>::from((v69 as char).encode_utf8(&mut [0u8; 4]) as &str);
    let v71: Rc<str> = Rc::<str>::from(v68.iter().map(|x| x.to_string()).collect::<Vec<_>>().join(&*v70));
    v71.clone()
}
fn method53() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_10(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method55(mut v0: US0) -> Rc<str> {
    match &v0 {
        US0::US0_None => {
            let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("None"); } LIT.with(|lit| lit.clone()) };
            v8
        }
        US0::US0_Some(v1) => {
            let mut v1: Rc<str> = v1.clone();
            let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Some"); } LIT.with(|lit| lit.clone()) };
            let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("("); } LIT.with(|lit| lit.clone()) };
            let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v2, v3)), v1));
            let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(")"); } LIT.with(|lit| lit.clone()) };
            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
            v7
        }
    }
}
fn format_real_56(mut v0: bool) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v5: Rc<str> = if v0 {
        let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("true"); } LIT.with(|lit| lit.clone()) };
        v3
    } else {
        let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("false"); } LIT.with(|lit| lit.clone()) };
        v4
    };
    method11(v2.clone(), v5);
    let mut v6: Rc<str> = v2.borrow().l0.clone();
    v6
}
fn method54(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>, mut v11: Rc<str>, mut v12: US0, mut v13: bool) -> Rc<str> {
    let mut v14: i64 = v0.borrow().l0;
    let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v15));
    let mut v17: Rc<str> = format_real_16(v14);
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v7)), v15));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run"); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v23));
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("source_dir"); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("source_dir"); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v8));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v31, v32));
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist_dir"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v29)), v9)), v32));
    let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache_dir"); } LIT.with(|lit| lit.clone()) };
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v29)), v10)), v32));
    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul_spec"); } LIT.with(|lit| lit.clone()) };
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v43, v44)), v29)), v11)), v32));
    let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("filter"); } LIT.with(|lit| lit.clone()) };
    let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v29));
    let mut v52: Rc<str> = method55(v12);
    let v54: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, v52)), v32));
    let v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("transcribe_only"); } LIT.with(|lit| lit.clone()) };
    let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v54, v55)), v29));
    let v58: Rc<str> = format_real_56(v13);
    let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v58));
    let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
    let v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v24, Rc::<str>::from(format!("{}{}", v61, v62))));
    method13(v64)
}
fn ok_c16() -> Rc<dyn Fn(Vec<std::string::String>) -> US10> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Vec<std::string::String>) -> US10> = Rc::new(move |mut v0: Vec<std::string::String>| -> US10 {
        US10::US10_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method58() -> Rc<dyn Fn(Vec<std::string::String>) -> US10> {
    ok_c16()
}
fn error_c17() -> Rc<dyn Fn(std::io::Error) -> US10> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::io::Error) -> US10> = Rc::new(move |mut v0: std::io::Error| -> US10 {
        US10::US10_Error(v0)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method59() -> Rc<dyn Fn(std::io::Error) -> US10> {
    error_c17()
}
fn walk_57(mut v0: US0, mut v1: Rc<UH0>, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                let mut v6: Result<Vec<std::string::String>, std::io::Error> = std::fs::read_dir(&*v3).map(|entries| entries.filter_map(|entry| entry.ok().map(|entry| entry.file_name().to_string_lossy().into_owned())).collect::<Vec<std::string::String>>());
                let mut v7: Rc<dyn Fn(Vec<std::string::String>) -> US10> = method58();
                let mut v8: Rc<dyn Fn(std::io::Error) -> US10> = method59();
                let mut v9: US10 = match v6 { Ok(x) => v7(x), Err(e) => v8(e) };
                match v9 {
                    US10::US10_Error(v45) => {
                        let mut v45: std::io::Error = v45;
                        (v0, v1, v2) = (v0.clone(), v4.clone(), v2.clone());
                        continue;
                    }
                    US10::US10_Ok(v10) => {
                        let mut v10: Vec<std::string::String> = v10.clone();
                        let mut v12: bool = true; let _vec_fold_ = v10.into_iter().fold((v4.clone(), v2.clone()), |acc, x| { //;
                        let (mut v14, mut v15): (Rc<UH0>, Rc<UH0>) = acc;
                        let mut v17: std::string::String = x;
                        let v19: Rc<str> = Rc::<str>::from(String::as_str(&v17));
                        let mut v20: Rc<str> = method39(v3.clone(), v19.clone());
                        let v21: bool = directory_exists_40(v20.clone());
                        let (mut v37, mut v38): (Rc<UH0>, Rc<UH0>) = if v21 {
                            let mut v22: Rc<UH0> = Rc::new(UH0::UH0_Cons(v20.clone(), v14.clone()));
                            (v22.clone(), v15.clone())
                        } else {
                            let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".md"); } LIT.with(|lit| lit.clone()) };
                            let v24: bool = v20.ends_with(&*v23);
                            let mut v28: bool = if v24 {
                                let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".hangul.md"); } LIT.with(|lit| lit.clone()) };
                                let mut v26: bool = v20.ends_with(&*v25);
                                let mut v27: bool = v26 == false;
                                v27
                            } else {
                                false
                            };
                            let mut v33: bool = if v28 {
                                match &v0 {
                                    US0::US0_None => {
                                        true
                                    }
                                    US0::US0_Some(v29) => {
                                        let mut v29: Rc<str> = v29.clone();
                                        let v30: bool = v20.contains(&*v29);
                                        v30
                                    }
                                }
                            } else {
                                false
                            };
                            if v33 {
                                let mut v34: Rc<UH0> = Rc::new(UH0::UH0_Cons(v20.clone(), v15.clone()));
                                (v14.clone(), v34.clone())
                            } else {
                                (v14.clone(), v15.clone())
                            }
                        };
                        let v40: bool = true; (v37, v38) });
                        let (mut v42, mut v43): (Rc<UH0>, Rc<UH0>) = _vec_fold_;
                        (v0, v1, v2) = (v0.clone(), v42.clone(), v43.clone());
                        continue;
                    }
                }
            }
            UH0::UH0_Nil => {
                return v2.clone();
            }
        }
    }
}
fn method61(mut v0: Rc<str>) -> Rc<str> {
    v0
}
fn method62(mut v0: Vec<Rc<str>>) -> Vec<Rc<str>> {
    v0
}
fn method60(mut v0: Rc<UH0>, mut v1: Vec<Rc<str>>) -> Vec<Rc<str>> {
    loop {
        match &*v0 {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: Rc<str> = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: Rc<str> = method61(v2.clone());
                let mut v5: Vec<Rc<str>> = method62(v1.clone());
                let mut v7: bool = true; let mut v5 = v5;
                let mut v9: bool = true; v5.push(v4);
                let mut v11: Vec<Rc<str>> = v5;
                (v0, v1) = (v3.clone(), v11.clone());
                continue;
            }
            UH0::UH0_Nil => {
                return v1.clone();
            }
        }
    }
}
fn method63(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: usize) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0;
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_16(v9);
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v11, v12)), v7)), v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("files_len"); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("files_len"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("files_len = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<usize>") } } (&&W(&v8)).s() });
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v27));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", v29, v30))));
    method13(v32)
}
fn method64(mut v0: Vec<Rc<str>>) -> Vec<Rc<str>> {
    v0
}
fn method66() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    v0
}
fn standardize_path_67(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = get_full_path_49(v0);
    normalize_path_28(v1)
}
fn method69(mut v0: Rc<str>, mut v1: Option<std::sync::Arc<std::sync::atomic::AtomicBool>>, mut v2: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>>, mut v3: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>>, mut v4: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>>, mut v5: bool, mut v6: Option<Rc<str>>, mut v7: bool) -> Rc<str> {
    v0
}
fn format_real_71(mut v0: i32) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method11(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn closure18() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: u8 = b'"';
        let mut v13: Rc<str> = format_real_10(v12);
        let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v13));
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v10));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v10));
        let v24: Rc<str> = format_real_71(v2);
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v15));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v10));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v10));
        let mut v34: Rc<str> = format_real_71(v3);
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v15));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v10));
        let v40: Rc<str> = format_real_71(v4);
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
        let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v43, v44)))), v15));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v47, v48)), v10));
        let v51: Rc<str> = format_real_71(v5);
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v50, v51)))), v44)))))), v44));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        v59.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method72(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v2;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v5: bool = b'\n' != v4;
            if v5 {
                let mut v6: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v1, v6);
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn closure20(mut v0: i32, mut v1: i32) -> Rc<dyn Fn(Rc<str>) -> Rc<str>> {
    Rc::new(move |mut v2: Rc<str>| -> Rc<str> {
        let mut v3: bool = v1 >= v0;
        if v3 {
            v2.clone()
        } else {
            let mut v4: i32 = v1.wrapping_add(1i32);
            let mut v5: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method73(v0, v4);
            let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v6));
            v5(v7.clone())
        }
    })
}
fn method73(mut v0: i32, mut v1: i32) -> Rc<dyn Fn(Rc<str>) -> Rc<str>> {
    closure20(v0, v1)
}
fn closure19() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method72(v0.clone(), v6, v1);
        let mut v8: i32 = v1.wrapping_add(80i32);
        let mut v9: bool = v7 < v8;
        let mut v10: i32 = if v9 {
            v7
        } else {
            v8
        };
        let mut v11: bool = v2 >= v10;
        let mut v16: Rc<str> = if v11 {
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v12.clone()
        } else {
            let mut v14: i32 = v10.wrapping_sub(1i32);
            let v15: Rc<str> = string_slice(&v0.clone(), v2 as i64, v14 as i64);
            v15.clone()
        };
        let mut v17: i32 = (v16.clone().len() as i32);
        let v18: bool = v17 > 0i32;
        let mut v22: bool = if v18 {
            let v19: i32 = v17.wrapping_sub(1i32);
            let mut v20: u8 = v16.clone().as_bytes()[v19 as usize];
            let v21: bool = v20 == b'\n';
            v21
        } else {
            false
        };
        let mut v25: Rc<str> = if v22 {
            let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v23.clone()
        } else {
            let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            v24.clone()
        };
        let mut v26: i32 = v4.wrapping_sub(1i32);
        let mut v27: i32 = 0i32;
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method73(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: u8 = b'"';
        let v39: Rc<str> = format_real_10(v38);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v39));
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v36));
        let mut v46: Rc<str> = format_real_71(v3);
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v41));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v36));
        let mut v52: Rc<str> = format_real_71(v4);
        let v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
        let v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v53));
        let v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v56));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v59, v60)), v16)), v25)), v32)), v60));
        v65.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure21() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: u8 = b'\'';
        let mut v13: Rc<str> = format_real_10(v12);
        let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v13));
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v10));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v10));
        let v24: Rc<str> = format_real_71(v2);
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v15));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v10));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v10));
        let mut v34: Rc<str> = format_real_71(v3);
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v15));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v10));
        let v40: Rc<str> = format_real_71(v4);
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
        let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v43, v44)))), v15));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v47, v48)), v10));
        let v51: Rc<str> = format_real_71(v5);
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v50, v51)))), v44)))))), v44));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        v59.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure22() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method72(v0.clone(), v6, v1);
        let mut v8: i32 = v1.wrapping_add(80i32);
        let mut v9: bool = v7 < v8;
        let mut v10: i32 = if v9 {
            v7
        } else {
            v8
        };
        let mut v11: bool = v2 >= v10;
        let mut v16: Rc<str> = if v11 {
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v12.clone()
        } else {
            let mut v14: i32 = v10.wrapping_sub(1i32);
            let v15: Rc<str> = string_slice(&v0.clone(), v2 as i64, v14 as i64);
            v15.clone()
        };
        let mut v17: i32 = (v16.clone().len() as i32);
        let v18: bool = v17 > 0i32;
        let mut v22: bool = if v18 {
            let v19: i32 = v17.wrapping_sub(1i32);
            let mut v20: u8 = v16.clone().as_bytes()[v19 as usize];
            let v21: bool = v20 == b'\n';
            v21
        } else {
            false
        };
        let mut v25: Rc<str> = if v22 {
            let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v23.clone()
        } else {
            let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            v24.clone()
        };
        let mut v26: i32 = v4.wrapping_sub(1i32);
        let mut v27: i32 = 0i32;
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method73(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: u8 = b'\'';
        let v39: Rc<str> = format_real_10(v38);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v39));
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v36));
        let mut v46: Rc<str> = format_real_71(v3);
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v41));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v36));
        let mut v52: Rc<str> = format_real_71(v4);
        let v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
        let v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v53));
        let v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v56));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v59, v60)), v16)), v25)), v32)), v60));
        v65.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure23() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.choice / no parsers succeeded"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method74(mut v0: Rc<RefCell<Vec<u8>>>) -> Rc<str> {
    let mut v1: u64 = (v0.clone().borrow().len() as u64);
    let mut v2: u64 = 0u64;
    let mut v3: Rc<RefCell<Mut6>> = Rc::new(RefCell::new(Mut6 { l0: v2 }));
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    while method18(v1, v3.clone()) {
        let mut v7: u64 = v3.borrow().l0;
        let mut v8: u8 = v0.clone().borrow()[v7 as usize].clone();
        let mut v9: Rc<str> = format_real_10(v8);
        let mut v10: bool = v7 == 0u64;
        let v15: Rc<str> = if v10 {
            v9.clone()
        } else {
            let mut v11: Rc<str> = v5.borrow().l0.clone();
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(", "); } LIT.with(|lit| lit.clone()) };
            let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v11, v12)), v9));
            v14.clone()
        };
        v5.borrow_mut().l0 = v15.clone();
        let mut v16: u64 = v7.wrapping_add(1u64);
        v3.borrow_mut().l0 = v16;
        ()
    };
    let mut v17: Rc<str> = v5.borrow().l0.clone();
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("["); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v17));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("]"); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    v21.clone()
}
fn closure24() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v6.borrow_mut().push(b'"');
        v6.borrow_mut().push(b'\'');
        let mut v7: Rc<Vec<u8>> = Rc::new(v6.borrow().clone());
        let mut v8: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
        let mut v9: Rc<str> = method74(v8.clone());
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v9));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v18, v19)), v14));
        let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v14));
        let mut v26: Rc<str> = format_real_71(v2);
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v17));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v14));
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = format_real_71(v3);
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v17));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v14));
        let v42: Rc<str> = format_real_71(v4);
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, Rc::<str>::from(format!("{}{}", v45, v46)))), v17));
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v14));
        let v53: Rc<str> = format_real_71(v5);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v52, v53)))), v46)))))), v46));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        v61.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure25() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        v7.borrow_mut().push(b'\'');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method74(v9.clone());
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char = "); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = format_real_10(v6);
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v15)), v10)), v19));
        let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v15));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v15));
        let mut v33: Rc<str> = format_real_71(v2);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v19));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v15));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v39, v40)), v15));
        let v43: Rc<str> = format_real_71(v3);
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v19));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v15));
        let mut v49: Rc<str> = format_real_71(v4);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, Rc::<str>::from(format!("{}{}", v52, v53)))), v19));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v56, v57)), v15));
        let v60: Rc<str> = format_real_71(v5);
        let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v59, v60)))), v53)))))), v53));
        let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v66));
        v68.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure26() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_chars / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method75(mut v0: i32, mut v1: Rc<str>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US13 {
    loop {
        let mut v7: bool = v2 >= v6;
        let mut v28: US12 = if v7 {
            let mut v8: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
            US12::US12_Error(v8.clone(), v2, v3, v4, v5, v6)
        } else {
            let mut v10: u8 = v1.clone().as_bytes()[v2 as usize];
            let mut v11: bool = v10 == b'"';
            let mut v13: bool = if v11 {
                true
            } else {
                let mut v12: bool = v10 == b'\'';
                v12
            };
            let mut v14: bool = v13 == false;
            if v14 {
                let v15: i32 = v2.wrapping_add(1i32);
                let mut v16: bool = b'\n' == v10;
                let (mut v20, mut v21, mut v22, mut v23): (i32, i32, i32, i32) = if v16 {
                    let mut v17: i32 = v3.wrapping_add(v5);
                    let v18: i32 = v4.wrapping_add(1i32);
                    (v17, v18, 1i32, v6)
                } else {
                    let v19: i32 = v5.wrapping_add(1i32);
                    (v3, v4, v19, v6)
                };
                US12::US12_Ok(v10, v15, v20, v21, v22, v23)
            } else {
                let mut v25: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25();
                US12::US12_Error(v25.clone(), v2, v3, v4, v5, v6)
            }
        };
        match &v28 {
            US12::US12_Error(v29, v30, v31, v32, v33, v34) => {
                let mut v29: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v29.clone();
                let v30: i32 = *v30;
                let mut v31: i32 = *v31;
                let mut v32: i32 = *v32;
                let mut v33: i32 = *v33;
                let mut v34: i32 = *v34;
                let mut v35: bool = v0 >= v2;
                let v40: Rc<str> = if v35 {
                    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v36.clone()
                } else {
                    let mut v38: i32 = v2.wrapping_sub(1i32);
                    let v39: Rc<str> = string_slice(&v1.clone(), v0 as i64, v38 as i64);
                    v39.clone()
                };
                return US13::US13_Ok(v40.clone(), v2, v3, v4, v5, v6);
            }
            US12::US12_Ok(v42, v43, v44, v45, v46, v47) => {
                let v42: u8 = *v42;
                let v43: i32 = *v43;
                let mut v44: i32 = *v44;
                let mut v45: i32 = *v45;
                let mut v46: i32 = *v46;
                let mut v47: i32 = *v47;
                let mut v48: bool = v43 != v2;
                if v48 {
                    (v0, v1, v2, v3, v4, v5, v6) = (v0, v1.clone(), v43, v44, v45, v46, v47);
                    continue;
                } else {
                    let v50: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure26();
                    return US13::US13_Error(v50.clone(), v2, v3, v4, v5, v6);
                }
            }
        }
    }
}
fn closure27() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = v1.wrapping_add(80i32);
        let mut v7: i32 = (v0.clone().len() as i32);
        let mut v8: bool = v7 < v6;
        let mut v9: i32 = if v8 {
            v7
        } else {
            v6
        };
        let mut v10: bool = v1 >= v9;
        let v15: Rc<str> = if v10 {
            let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v11.clone()
        } else {
            let mut v13: i32 = v9.wrapping_sub(1i32);
            let mut v14: Rc<str> = string_slice(&v0.clone(), v1 as i64, v13 as i64);
            v14.clone()
        };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest'"); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v19, v20)), v15));
        let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v22));
        let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.between / expected content or closing delimiter / "); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v26));
        v28.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn e_c29(mut v0: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0(v6.clone(), v1, v2, v3, v4, v5)
    })
}
fn format_real_76(mut v0: Rc<dyn Fn() -> Rc<str>>) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = v0();
    method11(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn closure28(mut v0: i32, mut v1: i32, mut v2: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32) -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    Rc::new(move |mut v8: Rc<str>, mut v9: i32, mut v10: i32, mut v11: i32, mut v12: i32, mut v13: i32| -> Rc<str> {
        let mut v14: i32 = (v8.clone().len() as i32);
        let v15: i32 = v0.wrapping_add(80i32);
        let mut v16: bool = v14 < v15;
        let mut v17: i32 = if v16 {
            v14
        } else {
            v15
        };
        let v18: i32 = v1.wrapping_add(80i32);
        let v19: bool = v14 < v18;
        let mut v20: i32 = if v19 {
            v14
        } else {
            v18
        };
        let v21: bool = v0 >= v17;
        let mut v26: Rc<str> = if v21 {
            let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v22.clone()
        } else {
            let v24: i32 = v17.wrapping_sub(1i32);
            let mut v25: Rc<str> = string_slice(&v8.clone(), v0 as i64, v24 as i64);
            v25.clone()
        };
        let mut v27: bool = v1 >= v20;
        let mut v32: Rc<str> = if v27 {
            let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v28.clone()
        } else {
            let v30: i32 = v20.wrapping_sub(1i32);
            let mut v31: Rc<str> = string_slice(&v8.clone(), v1 as i64, v30 as i64);
            v31.clone()
        };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e"); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e = "); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<dyn Fn() -> Rc<str>> = e_c29(v2.clone(), v3, v4, v5, v6, v7, v8.clone());
        let v40: Rc<str> = format_real_76(v39.clone());
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v40));
        let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("t"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v43, v44)), v37)), v8)), v42));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest'"); } LIT.with(|lit| lit.clone()) };
        let v53: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v37)), v26)), v42));
        let v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest''"); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v53, v54)), v37)), v32));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v59, v60));
        let v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.between / expected closing delimiter / "); } LIT.with(|lit| lit.clone()) };
        let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, v61));
        v63.clone()
    })
}
fn closure30() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v6.borrow_mut().push(b'"');
        v6.borrow_mut().push(b'\'');
        v6.borrow_mut().push(b' ');
        let mut v7: Rc<Vec<u8>> = Rc::new(v6.borrow().clone());
        let mut v8: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
        let mut v9: Rc<str> = method74(v8.clone());
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v9));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v18, v19)), v14));
        let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v14));
        let mut v26: Rc<str> = format_real_71(v2);
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v17));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v14));
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = format_real_71(v3);
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v17));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v14));
        let v42: Rc<str> = format_real_71(v4);
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, Rc::<str>::from(format!("{}{}", v45, v46)))), v17));
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v14));
        let v53: Rc<str> = format_real_71(v5);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v52, v53)))), v46)))))), v46));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        v61.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure31() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        v7.borrow_mut().push(b'\'');
        v7.borrow_mut().push(b' ');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method74(v9.clone());
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char = "); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = format_real_10(v6);
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v15)), v10)), v19));
        let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v15));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v15));
        let mut v33: Rc<str> = format_real_71(v2);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v19));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v15));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v39, v40)), v15));
        let v43: Rc<str> = format_real_71(v3);
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v19));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v15));
        let mut v49: Rc<str> = format_real_71(v4);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, Rc::<str>::from(format!("{}{}", v52, v53)))), v19));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v56, v57)), v15));
        let v60: Rc<str> = format_real_71(v5);
        let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v59, v60)))), v53)))))), v53));
        let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v66));
        v68.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method77(mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32) -> US13 {
    loop {
        let mut v6: bool = v1 >= v5;
        let mut v29: US12 = if v6 {
            let mut v7: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure30();
            US12::US12_Error(v7.clone(), v1, v2, v3, v4, v5)
        } else {
            let mut v9: u8 = v0.clone().as_bytes()[v1 as usize];
            let mut v10: bool = v9 == b'"';
            let mut v14: bool = if v10 {
                true
            } else {
                let mut v11: bool = v9 == b'\'';
                if v11 {
                    true
                } else {
                    let mut v12: bool = v9 == b' ';
                    v12
                }
            };
            let v15: bool = v14 == false;
            if v15 {
                let mut v16: i32 = v1.wrapping_add(1i32);
                let mut v17: bool = b'\n' == v9;
                let (mut v21, mut v22, mut v23, mut v24): (i32, i32, i32, i32) = if v17 {
                    let v18: i32 = v2.wrapping_add(v4);
                    let v19: i32 = v3.wrapping_add(1i32);
                    (v18, v19, 1i32, v5)
                } else {
                    let mut v20: i32 = v4.wrapping_add(1i32);
                    (v2, v3, v20, v5)
                };
                US12::US12_Ok(v9, v16, v21, v22, v23, v24)
            } else {
                let mut v26: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure31();
                US12::US12_Error(v26.clone(), v1, v2, v3, v4, v5)
            }
        };
        match &v29 {
            US12::US12_Error(v30, v31, v32, v33, v34, v35) => {
                let v30: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v30.clone();
                let mut v31: i32 = *v31;
                let mut v32: i32 = *v32;
                let mut v33: i32 = *v33;
                let mut v34: i32 = *v34;
                let mut v35: i32 = *v35;
                let v36: bool = 0i32 >= v1;
                let v41: Rc<str> = if v36 {
                    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v37.clone()
                } else {
                    let v39: i32 = v1.wrapping_sub(1i32);
                    let v40: Rc<str> = string_slice(&v0.clone(), 0i32 as i64, v39 as i64);
                    v40.clone()
                };
                return US13::US13_Ok(v41.clone(), v1, v2, v3, v4, v5);
            }
            US12::US12_Ok(v43, v44, v45, v46, v47, v48) => {
                let v43: u8 = *v43;
                let mut v44: i32 = *v44;
                let mut v45: i32 = *v45;
                let mut v46: i32 = *v46;
                let mut v47: i32 = *v47;
                let mut v48: i32 = *v48;
                let mut v49: bool = v44 != v1;
                if v49 {
                    (v0, v1, v2, v3, v4, v5) = (v0.clone(), v44, v45, v46, v47, v48);
                    continue;
                } else {
                    let v51: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure26();
                    return US13::US13_Error(v51.clone(), v1, v2, v3, v4, v5);
                }
            }
        }
    }
}
fn closure32() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: bool = v1 >= v5;
        let mut v11: Rc<str> = if v6 {
            let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v7.clone()
        } else {
            let mut v9: i32 = v5.wrapping_sub(1i32);
            let mut v10: Rc<str> = string_slice(&v0.clone(), v1 as i64, v9 as i64);
            v10.clone()
        };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest"); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v15, v16)), v11));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v18));
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
        let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.eof / expected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v22));
        v24.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method78(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v2;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v7: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'\t';
                v6
            };
            let mut v9: bool = if v7 {
                true
            } else {
                let mut v8: bool = v4 == b'\r';
                v8
            };
            if v9 {
                let mut v10: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v1, v10);
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn closure33() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = v1.wrapping_add(80i32);
        let mut v7: bool = v5 < v6;
        let mut v8: i32 = if v7 {
            v5
        } else {
            v6
        };
        let mut v9: bool = v1 >= v8;
        let mut v14: Rc<str> = if v9 {
            let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v10.clone()
        } else {
            let mut v12: i32 = v8.wrapping_sub(1i32);
            let mut v13: Rc<str> = string_slice(&v0.clone(), v1 as i64, v12 as i64);
            v13.clone()
        };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest"); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v18, v19)), v14));
        let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v21));
        let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v24));
        let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.spaces1 / expected at least one space / "); } LIT.with(|lit| lit.clone()) };
        let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v25));
        v27.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure34(mut v0: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0.clone()
    })
}
fn closure35(mut v0: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0.clone()
    })
}
fn closure36(mut v0: US16) -> Rc<dyn Fn() -> US16> {
    Rc::new(move || -> US16 {
        v0.clone()
    })
}
fn closure37(mut v0: Rc<str>, mut v1: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v1(v0.clone(), v2, v3, v4, v5, v6)
    })
}
fn split_command_70(mut v0: Rc<str>) -> US11 {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: bool = 0i32 >= v1;
    let mut v16: US12 = if v2 {
        let mut v3: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
        US12::US12_Error(v3, 0i32, 0i32, 1i32, 1i32, v1)
    } else {
        let mut v5: u8 = v0.clone().as_bytes()[0i32 as usize];
        let mut v6: bool = v5 == b'"';
        if v6 {
            let mut v7: bool = b'\n' == v5;
            let (mut v8, mut v9, mut v10, mut v11): (i32, i32, i32, i32) = if v7 {
                (1i32, 2i32, 1i32, v1)
            } else {
                (0i32, 1i32, 2i32, v1)
            };
            US12::US12_Ok(b'"', 1i32, v8, v9, v10, v11)
        } else {
            let mut v13: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
            US12::US12_Error(v13, 0i32, 0i32, 1i32, 1i32, v1)
        }
    };
    let v60: US12 = match &v16 {
        US12::US12_Error(v23, v24, v25, v26, v27, v28) => {
            let v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v23.clone();
            let v24: i32 = *v24;
            let mut v25: i32 = *v25;
            let mut v26: i32 = *v26;
            let mut v27: i32 = *v27;
            let mut v28: i32 = *v28;
            let v42: US12 = if v2 {
                let mut v29: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure21();
                US12::US12_Error(v29, 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let mut v31: u8 = v0.clone().as_bytes()[0i32 as usize];
                let mut v32: bool = v31 == b'\'';
                if v32 {
                    let mut v33: bool = b'\n' == v31;
                    let (mut v34, mut v35, mut v36, mut v37): (i32, i32, i32, i32) = if v33 {
                        (1i32, 2i32, 1i32, v1)
                    } else {
                        (0i32, 1i32, 2i32, v1)
                    };
                    US12::US12_Ok(b'\'', 1i32, v34, v35, v36, v37)
                } else {
                    let v39: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure22();
                    US12::US12_Error(v39, 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            match &v42 {
                US12::US12_Error(v49, v50, v51, v52, v53, v54) => {
                    let mut v49: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v49.clone();
                    let v50: i32 = *v50;
                    let v51: i32 = *v51;
                    let mut v52: i32 = *v52;
                    let v53: i32 = *v53;
                    let v54: i32 = *v54;
                    let v55: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                    US12::US12_Error(v55, 0i32, 0i32, 1i32, 1i32, v1)
                }
                US12::US12_Ok(v43, v44, v45, v46, v47, v48) => {
                    let v43: u8 = *v43;
                    let mut v44: i32 = *v44;
                    let mut v45: i32 = *v45;
                    let mut v46: i32 = *v46;
                    let mut v47: i32 = *v47;
                    let mut v48: i32 = *v48;
                    v42
                }
            }
        }
        US12::US12_Ok(v17, v18, v19, v20, v21, v22) => {
            let mut v17: u8 = *v17;
            let v18: i32 = *v18;
            let v19: i32 = *v19;
            let mut v20: i32 = *v20;
            let v21: i32 = *v21;
            let mut v22: i32 = *v22;
            v16
        }
    };
    let v312: US13 = match &v60 {
        US12::US12_Error(v304, v305, v306, v307, v308, v309) => {
            let v304: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v304.clone();
            let v305: i32 = *v305;
            let v306: i32 = *v306;
            let v307: i32 = *v307;
            let v308: i32 = *v308;
            let v309: i32 = *v309;
            US13::US13_Error(v304, v305, v306, v307, v308, v309)
        }
        US12::US12_Ok(v61, v62, v63, v64, v65, v66) => {
            let v61: u8 = *v61;
            let v62: i32 = *v62;
            let mut v63: i32 = *v63;
            let v64: i32 = *v64;
            let mut v65: i32 = *v65;
            let v66: i32 = *v66;
            let v67: bool = v62 >= v66;
            let mut v88: US12 = if v67 {
                let mut v68: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                US12::US12_Error(v68, v62, v63, v64, v65, v66)
            } else {
                let mut v70: u8 = v0.clone().as_bytes()[v62 as usize];
                let v71: bool = v70 == b'"';
                let mut v73: bool = if v71 {
                    true
                } else {
                    let v72: bool = v70 == b'\'';
                    v72
                };
                let v74: bool = v73 == false;
                if v74 {
                    let mut v75: i32 = v62.wrapping_add(1i32);
                    let mut v76: bool = b'\n' == v70;
                    let (mut v80, mut v81, mut v82, mut v83): (i32, i32, i32, i32) = if v76 {
                        let mut v77: i32 = v63.wrapping_add(v65);
                        let v78: i32 = v64.wrapping_add(1i32);
                        (v77, v78, 1i32, v66)
                    } else {
                        let mut v79: i32 = v65.wrapping_add(1i32);
                        (v63, v64, v79, v66)
                    };
                    US12::US12_Ok(v70, v75, v80, v81, v82, v83)
                } else {
                    let mut v85: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25();
                    US12::US12_Error(v85, v62, v63, v64, v65, v66)
                }
            };
            let mut v104: US13 = match &v88 {
                US12::US12_Error(v89, v90, v91, v92, v93, v94) => {
                    let v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v89.clone();
                    let v90: i32 = *v90;
                    let v91: i32 = *v91;
                    let v92: i32 = *v92;
                    let mut v93: i32 = *v93;
                    let v94: i32 = *v94;
                    US13::US13_Error(v89, v90, v91, v92, v93, v94)
                }
                US12::US12_Ok(v96, v97, v98, v99, v100, v101) => {
                    let v96: u8 = *v96;
                    let v97: i32 = *v97;
                    let mut v98: i32 = *v98;
                    let v99: i32 = *v99;
                    let v100: i32 = *v100;
                    let v101: i32 = *v101;
                    method75(v62, v0.clone(), v97, v98, v99, v100, v101)
                }
            };
            let mut v121: US13 = match &v104 {
                US13::US13_Error(v112, v113, v114, v115, v116, v117) => {
                    let mut v112: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v112.clone();
                    let mut v113: i32 = *v113;
                    let v114: i32 = *v114;
                    let mut v115: i32 = *v115;
                    let mut v116: i32 = *v116;
                    let v117: i32 = *v117;
                    let v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US13::US13_Ok(v118, v62, v63, v64, v65, v66)
                }
                US13::US13_Ok(v105, v106, v107, v108, v109, v110) => {
                    let mut v105: Rc<str> = v105.clone();
                    let v106: i32 = *v106;
                    let v107: i32 = *v107;
                    let mut v108: i32 = *v108;
                    let mut v109: i32 = *v109;
                    let mut v110: i32 = *v110;
                    US13::US13_Ok(v105, v106, v107, v108, v109, v110)
                }
            };
            match &v121 {
                US13::US13_Error(v212, v213, v214, v215, v216, v217) => {
                    let v212: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v212.clone();
                    let v213: i32 = *v213;
                    let v214: i32 = *v214;
                    let v215: i32 = *v215;
                    let v216: i32 = *v216;
                    let mut v217: i32 = *v217;
                    let mut v235: US12 = if v67 {
                        let mut v218: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                        US12::US12_Error(v218, v62, v63, v64, v65, v66)
                    } else {
                        let mut v220: u8 = v0.clone().as_bytes()[v62 as usize];
                        let mut v221: bool = v220 == b'"';
                        if v221 {
                            let mut v222: i32 = v62.wrapping_add(1i32);
                            let v223: bool = b'\n' == v220;
                            let (mut v227, mut v228, mut v229, mut v230): (i32, i32, i32, i32) = if v223 {
                                let v224: i32 = v63.wrapping_add(v65);
                                let v225: i32 = v64.wrapping_add(1i32);
                                (v224, v225, 1i32, v66)
                            } else {
                                let v226: i32 = v65.wrapping_add(1i32);
                                (v63, v64, v226, v66)
                            };
                            US12::US12_Ok(b'"', v222, v227, v228, v229, v230)
                        } else {
                            let mut v232: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                            US12::US12_Error(v232, v62, v63, v64, v65, v66)
                        }
                    };
                    let v283: US12 = match &v235 {
                        US12::US12_Error(v242, v243, v244, v245, v246, v247) => {
                            let v242: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v242.clone();
                            let v243: i32 = *v243;
                            let v244: i32 = *v244;
                            let v245: i32 = *v245;
                            let v246: i32 = *v246;
                            let v247: i32 = *v247;
                            let v265: US12 = if v67 {
                                let mut v248: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure21();
                                US12::US12_Error(v248, v62, v63, v64, v65, v66)
                            } else {
                                let mut v250: u8 = v0.clone().as_bytes()[v62 as usize];
                                let v251: bool = v250 == b'\'';
                                if v251 {
                                    let v252: i32 = v62.wrapping_add(1i32);
                                    let v253: bool = b'\n' == v250;
                                    let (mut v257, mut v258, mut v259, mut v260): (i32, i32, i32, i32) = if v253 {
                                        let v254: i32 = v63.wrapping_add(v65);
                                        let v255: i32 = v64.wrapping_add(1i32);
                                        (v254, v255, 1i32, v66)
                                    } else {
                                        let v256: i32 = v65.wrapping_add(1i32);
                                        (v63, v64, v256, v66)
                                    };
                                    US12::US12_Ok(b'\'', v252, v257, v258, v259, v260)
                                } else {
                                    let mut v262: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure22();
                                    US12::US12_Error(v262, v62, v63, v64, v65, v66)
                                }
                            };
                            match &v265 {
                                US12::US12_Error(v272, v273, v274, v275, v276, v277) => {
                                    let v272: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v272.clone();
                                    let v273: i32 = *v273;
                                    let mut v274: i32 = *v274;
                                    let v275: i32 = *v275;
                                    let v276: i32 = *v276;
                                    let v277: i32 = *v277;
                                    let v278: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                    US12::US12_Error(v278, v62, v63, v64, v65, v66)
                                }
                                US12::US12_Ok(v266, v267, v268, v269, v270, v271) => {
                                    let v266: u8 = *v266;
                                    let v267: i32 = *v267;
                                    let v268: i32 = *v268;
                                    let v269: i32 = *v269;
                                    let v270: i32 = *v270;
                                    let v271: i32 = *v271;
                                    v265
                                }
                            }
                        }
                        US12::US12_Ok(v236, v237, v238, v239, v240, v241) => {
                            let mut v236: u8 = *v236;
                            let v237: i32 = *v237;
                            let v238: i32 = *v238;
                            let v239: i32 = *v239;
                            let v240: i32 = *v240;
                            let v241: i32 = *v241;
                            v235
                        }
                    };
                    match &v283 {
                        US12::US12_Error(v292, v293, v294, v295, v296, v297) => {
                            let v292: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v292.clone();
                            let v293: i32 = *v293;
                            let mut v294: i32 = *v294;
                            let v295: i32 = *v295;
                            let v296: i32 = *v296;
                            let v297: i32 = *v297;
                            let v298: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                            US13::US13_Error(v298, v62, v63, v64, v65, v66)
                        }
                        US12::US12_Ok(v284, v285, v286, v287, v288, v289) => {
                            let v284: u8 = *v284;
                            let v285: i32 = *v285;
                            let v286: i32 = *v286;
                            let mut v287: i32 = *v287;
                            let v288: i32 = *v288;
                            let v289: i32 = *v289;
                            let mut v290: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US13::US13_Ok(v290, v285, v286, v287, v288, v289)
                        }
                    }
                }
                US13::US13_Ok(v122, v123, v124, v125, v126, v127) => {
                    let mut v122: Rc<str> = v122.clone();
                    let v123: i32 = *v123;
                    let mut v124: i32 = *v124;
                    let v125: i32 = *v125;
                    let v126: i32 = *v126;
                    let mut v127: i32 = *v127;
                    let v128: bool = v123 >= v127;
                    let v146: US12 = if v128 {
                        let v129: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                        US12::US12_Error(v129, v123, v124, v125, v126, v127)
                    } else {
                        let v131: u8 = v0.clone().as_bytes()[v123 as usize];
                        let v132: bool = v131 == b'"';
                        if v132 {
                            let v133: i32 = v123.wrapping_add(1i32);
                            let v134: bool = b'\n' == v131;
                            let (mut v138, mut v139, mut v140, mut v141): (i32, i32, i32, i32) = if v134 {
                                let v135: i32 = v124.wrapping_add(v126);
                                let v136: i32 = v125.wrapping_add(1i32);
                                (v135, v136, 1i32, v127)
                            } else {
                                let v137: i32 = v126.wrapping_add(1i32);
                                (v124, v125, v137, v127)
                            };
                            US12::US12_Ok(b'"', v133, v138, v139, v140, v141)
                        } else {
                            let v143: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                            US12::US12_Error(v143, v123, v124, v125, v126, v127)
                        }
                    };
                    let v194: US12 = match &v146 {
                        US12::US12_Error(v153, v154, v155, v156, v157, v158) => {
                            let v153: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v153.clone();
                            let v154: i32 = *v154;
                            let mut v155: i32 = *v155;
                            let v156: i32 = *v156;
                            let v157: i32 = *v157;
                            let v158: i32 = *v158;
                            let v176: US12 = if v128 {
                                let mut v159: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure21();
                                US12::US12_Error(v159, v123, v124, v125, v126, v127)
                            } else {
                                let mut v161: u8 = v0.clone().as_bytes()[v123 as usize];
                                let mut v162: bool = v161 == b'\'';
                                if v162 {
                                    let mut v163: i32 = v123.wrapping_add(1i32);
                                    let mut v164: bool = b'\n' == v161;
                                    let (mut v168, mut v169, mut v170, mut v171): (i32, i32, i32, i32) = if v164 {
                                        let mut v165: i32 = v124.wrapping_add(v126);
                                        let mut v166: i32 = v125.wrapping_add(1i32);
                                        (v165, v166, 1i32, v127)
                                    } else {
                                        let mut v167: i32 = v126.wrapping_add(1i32);
                                        (v124, v125, v167, v127)
                                    };
                                    US12::US12_Ok(b'\'', v163, v168, v169, v170, v171)
                                } else {
                                    let v173: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure22();
                                    US12::US12_Error(v173, v123, v124, v125, v126, v127)
                                }
                            };
                            match &v176 {
                                US12::US12_Error(v183, v184, v185, v186, v187, v188) => {
                                    let mut v183: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v183.clone();
                                    let v184: i32 = *v184;
                                    let v185: i32 = *v185;
                                    let v186: i32 = *v186;
                                    let v187: i32 = *v187;
                                    let v188: i32 = *v188;
                                    let mut v189: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                    US12::US12_Error(v189, v123, v124, v125, v126, v127)
                                }
                                US12::US12_Ok(v177, v178, v179, v180, v181, v182) => {
                                    let v177: u8 = *v177;
                                    let mut v178: i32 = *v178;
                                    let v179: i32 = *v179;
                                    let v180: i32 = *v180;
                                    let mut v181: i32 = *v181;
                                    let mut v182: i32 = *v182;
                                    v176
                                }
                            }
                        }
                        US12::US12_Ok(v147, v148, v149, v150, v151, v152) => {
                            let mut v147: u8 = *v147;
                            let mut v148: i32 = *v148;
                            let v149: i32 = *v149;
                            let mut v150: i32 = *v150;
                            let mut v151: i32 = *v151;
                            let mut v152: i32 = *v152;
                            v146
                        }
                    };
                    match &v194 {
                        US12::US12_Error(v202, v203, v204, v205, v206, v207) => {
                            let v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v202.clone();
                            let v203: i32 = *v203;
                            let v204: i32 = *v204;
                            let v205: i32 = *v205;
                            let v206: i32 = *v206;
                            let v207: i32 = *v207;
                            let v208: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28(v62, v123, v202, v203, v204, v205, v206, v207);
                            US13::US13_Error(v208, v123, v124, v125, v126, v127)
                        }
                        US12::US12_Ok(v195, v196, v197, v198, v199, v200) => {
                            let v195: u8 = *v195;
                            let v196: i32 = *v196;
                            let v197: i32 = *v197;
                            let v198: i32 = *v198;
                            let v199: i32 = *v199;
                            let v200: i32 = *v200;
                            US13::US13_Ok(v122, v196, v197, v198, v199, v200)
                        }
                    }
                }
            }
        }
    };
    let v331: US13 = match &v312 {
        US13::US13_Error(v323, v324, v325, v326, v327, v328) => {
            let v323: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v323.clone();
            let v324: i32 = *v324;
            let v325: i32 = *v325;
            let v326: i32 = *v326;
            let v327: i32 = *v327;
            let v328: i32 = *v328;
            US13::US13_Error(v323, v324, v325, v326, v327, v328)
        }
        US13::US13_Ok(v313, v314, v315, v316, v317, v318) => {
            let v313: Rc<str> = v313.clone();
            let v314: i32 = *v314;
            let v315: i32 = *v315;
            let v316: i32 = *v316;
            let v317: i32 = *v317;
            let mut v318: i32 = *v318;
            let v319: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let v320: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let v321: Rc<str> = Rc::<str>::from(v313.replace(&*v319, &*v320));
            US13::US13_Ok(v321, v314, v315, v316, v317, v318)
        }
    };
    let v399: US13 = match &v331 {
        US13::US13_Error(v338, v339, v340, v341, v342, v343) => {
            let v338: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v338.clone();
            let v339: i32 = *v339;
            let v340: i32 = *v340;
            let v341: i32 = *v341;
            let v342: i32 = *v342;
            let v343: i32 = *v343;
            let v362: US12 = if v2 {
                let v344: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure30();
                US12::US12_Error(v344, 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let v346: u8 = v0.clone().as_bytes()[0i32 as usize];
                let v347: bool = v346 == b'"';
                let v351: bool = if v347 {
                    true
                } else {
                    let v348: bool = v346 == b'\'';
                    if v348 {
                        true
                    } else {
                        let v349: bool = v346 == b' ';
                        v349
                    }
                };
                let v352: bool = v351 == false;
                if v352 {
                    let v353: bool = b'\n' == v346;
                    let (mut v354, mut v355, mut v356, mut v357): (i32, i32, i32, i32) = if v353 {
                        (1i32, 2i32, 1i32, v1)
                    } else {
                        (0i32, 1i32, 2i32, v1)
                    };
                    US12::US12_Ok(v346, 1i32, v354, v355, v356, v357)
                } else {
                    let mut v359: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure31();
                    US12::US12_Error(v359, 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            let v378: US13 = match &v362 {
                US12::US12_Error(v363, v364, v365, v366, v367, v368) => {
                    let v363: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v363.clone();
                    let v364: i32 = *v364;
                    let v365: i32 = *v365;
                    let v366: i32 = *v366;
                    let v367: i32 = *v367;
                    let v368: i32 = *v368;
                    US13::US13_Error(v363, v364, v365, v366, v367, v368)
                }
                US12::US12_Ok(v370, v371, v372, v373, v374, v375) => {
                    let v370: u8 = *v370;
                    let v371: i32 = *v371;
                    let v372: i32 = *v372;
                    let v373: i32 = *v373;
                    let v374: i32 = *v374;
                    let v375: i32 = *v375;
                    method77(v0.clone(), v371, v372, v373, v374, v375)
                }
            };
            match &v378 {
                US13::US13_Error(v389, v390, v391, v392, v393, v394) => {
                    let v389: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v389.clone();
                    let v390: i32 = *v390;
                    let mut v391: i32 = *v391;
                    let v392: i32 = *v392;
                    let v393: i32 = *v393;
                    let mut v394: i32 = *v394;
                    US13::US13_Error(v389, v390, v391, v392, v393, v394)
                }
                US13::US13_Ok(v379, v380, v381, v382, v383, v384) => {
                    let v379: Rc<str> = v379.clone();
                    let v380: i32 = *v380;
                    let v381: i32 = *v381;
                    let v382: i32 = *v382;
                    let v383: i32 = *v383;
                    let v384: i32 = *v384;
                    let v385: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
                    let v386: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
                    let v387: Rc<str> = Rc::<str>::from(v379.replace(&*v385, &*v386));
                    US13::US13_Ok(v387, v380, v381, v382, v383, v384)
                }
            }
        }
        US13::US13_Ok(v332, v333, v334, v335, v336, v337) => {
            let mut v332: Rc<str> = v332.clone();
            let v333: i32 = *v333;
            let v334: i32 = *v334;
            let v335: i32 = *v335;
            let v336: i32 = *v336;
            let v337: i32 = *v337;
            v331
        }
    };
    let v434: US13 = match &v399 {
        US13::US13_Error(v406, v407, v408, v409, v410, v411) => {
            let v406: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v406.clone();
            let v407: i32 = *v407;
            let v408: i32 = *v408;
            let v409: i32 = *v409;
            let v410: i32 = *v410;
            let v411: i32 = *v411;
            let v412: bool = v1 == 0i32;
            let v416: US14 = if v412 {
                US14::US14_Ok(0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let v414: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure32();
                US14::US14_Error(v414, 0i32, 0i32, 1i32, 1i32, v1)
            };
            match &v416 {
                US14::US14_Error(v424, v425, v426, v427, v428, v429) => {
                    let v424: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v424.clone();
                    let v425: i32 = *v425;
                    let v426: i32 = *v426;
                    let v427: i32 = *v427;
                    let v428: i32 = *v428;
                    let v429: i32 = *v429;
                    US13::US13_Error(v424, v425, v426, v427, v428, v429)
                }
                US14::US14_Ok(v417, v418, v419, v420, v421) => {
                    let v417: i32 = *v417;
                    let v418: i32 = *v418;
                    let v419: i32 = *v419;
                    let v420: i32 = *v420;
                    let v421: i32 = *v421;
                    let mut v422: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US13::US13_Ok(v422, v417, v418, v419, v420, v421)
                }
            }
        }
        US13::US13_Ok(v400, v401, v402, v403, v404, v405) => {
            let v400: Rc<str> = v400.clone();
            let v401: i32 = *v401;
            let v402: i32 = *v402;
            let v403: i32 = *v403;
            let v404: i32 = *v404;
            let v405: i32 = *v405;
            v399
        }
    };
    let v546: US15 = match &v434 {
        US13::US13_Error(v435, v436, v437, v438, v439, v440) => {
            let v435: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v435.clone();
            let v436: i32 = *v436;
            let v437: i32 = *v437;
            let v438: i32 = *v438;
            let v439: i32 = *v439;
            let v440: i32 = *v440;
            US15::US15_Error(v435, v436, v437, v438, v439, v440)
        }
        US13::US13_Ok(v442, v443, v444, v445, v446, v447) => {
            let v442: Rc<str> = v442.clone();
            let v443: i32 = *v443;
            let v444: i32 = *v444;
            let v445: i32 = *v445;
            let v446: i32 = *v446;
            let v447: i32 = *v447;
            let v448: bool = v443 >= v447;
            let (mut v460, mut v461, mut v462, mut v463, mut v464): (i32, i32, i32, i32, i32) = if v448 {
                (v443, v444, v445, v446, v447)
            } else {
                let v449: i32 = method78(v0.clone(), v1, v443);
                let v450: bool = v449 > v447;
                let v451: i32 = if v450 {
                    v447
                } else {
                    v449
                };
                let v452: i32 = v451.wrapping_sub(v443);
                let v453: bool = v452 == 0i32;
                if v453 {
                    (v443, v444, v445, v446, v447)
                } else {
                    let v454: i32 = v446.wrapping_add(v452);
                    (v451, v444, v445, v454, v447)
                }
            };
            let v465: bool = v460 != v443;
            let v469: US14 = if v465 {
                US14::US14_Ok(v460, v461, v462, v463, v464)
            } else {
                let v467: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure33();
                US14::US14_Error(v467, v443, v444, v445, v446, v447)
            };
            let v507: US13 = match &v469 {
                US14::US14_Error(v499, v500, v501, v502, v503, v504) => {
                    let v499: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v499.clone();
                    let v500: i32 = *v500;
                    let v501: i32 = *v501;
                    let v502: i32 = *v502;
                    let v503: i32 = *v503;
                    let v504: i32 = *v504;
                    US13::US13_Error(v499, v500, v501, v502, v503, v504)
                }
                US14::US14_Ok(v470, v471, v472, v473, v474) => {
                    let v470: i32 = *v470;
                    let v471: i32 = *v471;
                    let v472: i32 = *v472;
                    let v473: i32 = *v473;
                    let v474: i32 = *v474;
                    let v475: bool = v470 >= v474;
                    let (mut v487, mut v488, mut v489, mut v490, mut v491): (i32, i32, i32, i32, i32) = if v475 {
                        (v470, v471, v472, v473, v474)
                    } else {
                        let v476: i32 = method72(v0.clone(), v1, v470);
                        let v477: bool = v476 > v474;
                        let v478: i32 = if v477 {
                            v474
                        } else {
                            v476
                        };
                        let v479: i32 = v478.wrapping_sub(v470);
                        let v480: bool = v479 == 0i32;
                        if v480 {
                            (v470, v471, v472, v473, v474)
                        } else {
                            let v481: i32 = v473.wrapping_add(v479);
                            (v478, v471, v472, v481, v474)
                        }
                    };
                    let mut v492: bool = v470 >= v487;
                    let v497: Rc<str> = if v492 {
                        let v493: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v493
                    } else {
                        let mut v495: i32 = v487.wrapping_sub(1i32);
                        let v496: Rc<str> = string_slice(&v0.clone(), v470 as i64, v495 as i64);
                        v496
                    };
                    US13::US13_Ok(v497, v487, v488, v489, v490, v491)
                }
            };
            let v526: US17 = match &v507 {
                US13::US13_Error(v517, v518, v519, v520, v521, v522) => {
                    let v517: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v517.clone();
                    let v518: i32 = *v518;
                    let v519: i32 = *v519;
                    let v520: i32 = *v520;
                    let v521: i32 = *v521;
                    let v522: i32 = *v522;
                    let mut v523: US16 = US16::US16_None;
                    US17::US17_Ok(v523, v443, v444, v445, v446, v447)
                }
                US13::US13_Ok(v508, v509, v510, v511, v512, v513) => {
                    let v508: Rc<str> = v508.clone();
                    let v509: i32 = *v509;
                    let v510: i32 = *v510;
                    let v511: i32 = *v511;
                    let v512: i32 = *v512;
                    let v513: i32 = *v513;
                    let v514: Rc<dyn Fn() -> Rc<str>> = closure34(v508);
                    let v515: US16 = US16::US16_Some(v514);
                    US17::US17_Ok(v515, v509, v510, v511, v512, v513)
                }
            };
            match &v526 {
                US17::US17_Error(v536, v537, v538, v539, v540, v541) => {
                    let v536: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v536.clone();
                    let v537: i32 = *v537;
                    let v538: i32 = *v538;
                    let v539: i32 = *v539;
                    let v540: i32 = *v540;
                    let v541: i32 = *v541;
                    US15::US15_Error(v536, v537, v538, v539, v540, v541)
                }
                US17::US17_Ok(v527, v528, v529, v530, v531, v532) => {
                    let v527: US16 = v527.clone();
                    let v528: i32 = *v528;
                    let v529: i32 = *v529;
                    let v530: i32 = *v530;
                    let v531: i32 = *v531;
                    let v532: i32 = *v532;
                    let v533: Rc<dyn Fn() -> Rc<str>> = closure35(v442);
                    let v534: Rc<dyn Fn() -> US16> = closure36(v527);
                    US15::US15_Ok(v533, v534, v528, v529, v530, v531, v532)
                }
            }
        }
    };
    let v570: US18 = match &v546 {
        US15::US15_Error(v561, v562, v563, v564, v565, v566) => {
            let v561: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v561.clone();
            let v562: i32 = *v562;
            let v563: i32 = *v563;
            let v564: i32 = *v564;
            let v565: i32 = *v565;
            let v566: i32 = *v566;
            let v567: Rc<dyn Fn() -> Rc<str>> = closure37(v0.clone(), v561, v562, v563, v564, v565, v566);
            US18::US18_Error(v567)
        }
        US15::US15_Ok(v547, v548, v549, v550, v551, v552, v553) => {
            let v547: Rc<dyn Fn() -> Rc<str>> = v547.clone();
            let v548: Rc<dyn Fn() -> US16> = v548.clone();
            let v549: i32 = *v549;
            let v550: i32 = *v550;
            let v551: i32 = *v551;
            let v552: i32 = *v552;
            let v553: i32 = *v553;
            let v554: bool = v549 >= v553;
            let v559: Rc<str> = if v554 {
                let v555: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v555
            } else {
                let v557: i32 = v553.wrapping_sub(1i32);
                let v558: Rc<str> = string_slice(&v0, v549 as i64, v557 as i64);
                v558
            };
            US18::US18_Ok(v547, v548, v559, v550, v551, v552, v553)
        }
    };
    let v590: US19 = match &v570 {
        US18::US18_Error(v587) => {
            let v587: Rc<dyn Fn() -> Rc<str>> = v587.clone();
            US19::US19_Error(v587)
        }
        US18::US18_Ok(v571, v572, v573, v574, v575, v576, v577) => {
            let mut v571: Rc<dyn Fn() -> Rc<str>> = v571.clone();
            let mut v572: Rc<dyn Fn() -> US16> = v572.clone();
            let v573: Rc<str> = v573.clone();
            let mut v574: i32 = *v574;
            let v575: i32 = *v575;
            let v576: i32 = *v576;
            let mut v577: i32 = *v577;
            let v578: Rc<str> = v571();
            let v579: US16 = v572();
            let v585: US0 = match &v579 {
                US16::US16_None => {
                    US0::US0_None
                }
                US16::US16_Some(v580) => {
                    let mut v580: Rc<dyn Fn() -> Rc<str>> = v580.clone();
                    let v581: Rc<str> = v580();
                    US0::US0_Some(v581)
                }
            };
            US19::US19_Ok(v578, v585)
        }
    };
    match &v590 {
        US19::US19_Error(v594) => {
            let mut v594: Rc<dyn Fn() -> Rc<str>> = v594.clone();
            let v595: Rc<str> = v594();
            US11::US11_Error(v595)
        }
        US19::US19_Ok(v591, v592) => {
            let v591: Rc<str> = v591.clone();
            let v592: US0 = v592.clone();
            US11::US11_Ok(v591, v592)
        }
    }
}
fn closure38() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: u8 = b'\\';
        let mut v13: Rc<str> = format_real_10(v12);
        let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v13));
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v10));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v10));
        let v24: Rc<str> = format_real_71(v2);
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v15));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v10));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v10));
        let mut v34: Rc<str> = format_real_71(v3);
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v15));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v10));
        let v40: Rc<str> = format_real_71(v4);
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
        let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v43, v44)))), v15));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v47, v48)), v10));
        let v51: Rc<str> = format_real_71(v5);
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v50, v51)))), v44)))))), v44));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        v59.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure39() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method72(v0.clone(), v6, v1);
        let mut v8: i32 = v1.wrapping_add(80i32);
        let mut v9: bool = v7 < v8;
        let mut v10: i32 = if v9 {
            v7
        } else {
            v8
        };
        let mut v11: bool = v2 >= v10;
        let mut v16: Rc<str> = if v11 {
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v12.clone()
        } else {
            let mut v14: i32 = v10.wrapping_sub(1i32);
            let v15: Rc<str> = string_slice(&v0.clone(), v2 as i64, v14 as i64);
            v15.clone()
        };
        let mut v17: i32 = (v16.clone().len() as i32);
        let v18: bool = v17 > 0i32;
        let mut v22: bool = if v18 {
            let v19: i32 = v17.wrapping_sub(1i32);
            let mut v20: u8 = v16.clone().as_bytes()[v19 as usize];
            let v21: bool = v20 == b'\n';
            v21
        } else {
            false
        };
        let mut v25: Rc<str> = if v22 {
            let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v23.clone()
        } else {
            let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            v24.clone()
        };
        let mut v26: i32 = v4.wrapping_sub(1i32);
        let mut v27: i32 = 0i32;
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method73(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: u8 = b'\\';
        let v39: Rc<str> = format_real_10(v38);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v39));
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v36));
        let mut v46: Rc<str> = format_real_71(v3);
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v41));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v36));
        let mut v52: Rc<str> = format_real_71(v4);
        let v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
        let v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v53));
        let v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v56));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v59, v60)), v16)), v25)), v32)), v60));
        v65.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure40() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: u8 = b'`';
        let mut v13: Rc<str> = format_real_10(v12);
        let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v13));
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v10));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v10));
        let v24: Rc<str> = format_real_71(v2);
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v15));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v10));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v10));
        let mut v34: Rc<str> = format_real_71(v3);
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v15));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v10));
        let v40: Rc<str> = format_real_71(v4);
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
        let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v43, v44)))), v15));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v47, v48)), v10));
        let v51: Rc<str> = format_real_71(v5);
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v50, v51)))), v44)))))), v44));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        v59.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure41() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method72(v0.clone(), v6, v1);
        let mut v8: i32 = v1.wrapping_add(80i32);
        let mut v9: bool = v7 < v8;
        let mut v10: i32 = if v9 {
            v7
        } else {
            v8
        };
        let mut v11: bool = v2 >= v10;
        let mut v16: Rc<str> = if v11 {
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v12.clone()
        } else {
            let mut v14: i32 = v10.wrapping_sub(1i32);
            let v15: Rc<str> = string_slice(&v0.clone(), v2 as i64, v14 as i64);
            v15.clone()
        };
        let mut v17: i32 = (v16.clone().len() as i32);
        let v18: bool = v17 > 0i32;
        let mut v22: bool = if v18 {
            let v19: i32 = v17.wrapping_sub(1i32);
            let mut v20: u8 = v16.clone().as_bytes()[v19 as usize];
            let v21: bool = v20 == b'\n';
            v21
        } else {
            false
        };
        let mut v25: Rc<str> = if v22 {
            let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v23.clone()
        } else {
            let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            v24.clone()
        };
        let mut v26: i32 = v4.wrapping_sub(1i32);
        let mut v27: i32 = 0i32;
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method73(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: u8 = b'`';
        let v39: Rc<str> = format_real_10(v38);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v39));
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v36));
        let mut v46: Rc<str> = format_real_71(v3);
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v41));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v36));
        let mut v52: Rc<str> = format_real_71(v4);
        let v53: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v52));
        let v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54, v53));
        let v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v55, v56));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v59, v60)), v16)), v25)), v32)), v60));
        v65.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method80(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: Rc<str>, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> (i32, i32, i32, i32, i32) {
    loop {
        let mut v10: bool = v5 >= v3;
        if v10 {
            return (v5, v6, v7, v8, v9);
        } else {
            let mut v11: u8 = v4.clone().as_bytes()[v5 as usize];
            let mut v12: bool = v11 == b'\\';
            let mut v16: bool = if v12 {
                true
            } else {
                let mut v13: bool = v11 == b'`';
                if v13 {
                    true
                } else {
                    let mut v14: bool = v11 == b'"';
                    v14
                }
            };
            let mut v17: bool = v16 == false;
            if v17 {
                let v18: i32 = v5.wrapping_add(1i32);
                let v19: bool = b'\n' == v11;
                let (mut v23, mut v24, mut v25, mut v26): (i32, i32, i32, i32) = if v19 {
                    let mut v20: i32 = v6.wrapping_add(v8);
                    let v21: i32 = v7.wrapping_add(1i32);
                    (v20, v21, 1i32, v9)
                } else {
                    let mut v22: i32 = v8.wrapping_add(1i32);
                    (v6, v7, v22, v9)
                };
                (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0, v1, v2, v3, v4.clone(), v18, v23, v24, v25, v26);
                continue;
            } else {
                return (v5, v6, v7, v8, v9);
            }
        }
    }
}
fn closure42() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("i"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("i"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("i = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = format_real_71(v1);
        let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v15, v16)), v10));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v19, v20)), v10));
        let v23: Rc<str> = format_real_71(v2);
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v14));
        let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v10));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v10));
        let mut v33: Rc<str> = format_real_71(v3);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v10));
        let v39: Rc<str> = format_real_71(v4);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", v42, v43)))), v14));
        let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v46, v47)), v10));
        let v50: Rc<str> = format_real_71(v5);
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v41, Rc::<str>::from(format!("{}{}", v18, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v41, Rc::<str>::from(format!("{}{}", v49, v50)))), v43)))))), v43));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_satisfy / no matching char / "); } LIT.with(|lit| lit.clone()) };
        let v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v56));
        v58.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure43() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v6.borrow_mut().push(b'"');
        let mut v7: Rc<Vec<u8>> = Rc::new(v6.borrow().clone());
        let mut v8: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
        let mut v9: Rc<str> = method74(v8.clone());
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v9));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v18, v19)), v14));
        let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v14));
        let mut v26: Rc<str> = format_real_71(v2);
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v17));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v14));
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = format_real_71(v3);
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v17));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v14));
        let v42: Rc<str> = format_real_71(v4);
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, Rc::<str>::from(format!("{}{}", v45, v46)))), v17));
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v14));
        let v53: Rc<str> = format_real_71(v5);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v52, v53)))), v46)))))), v46));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        v61.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure44() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method74(v9.clone());
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char = "); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = format_real_10(v6);
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v15)), v10)), v19));
        let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v15));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v15));
        let mut v33: Rc<str> = format_real_71(v2);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v19));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v15));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v39, v40)), v15));
        let v43: Rc<str> = format_real_71(v3);
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v19));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v15));
        let mut v49: Rc<str> = format_real_71(v4);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, Rc::<str>::from(format!("{}{}", v52, v53)))), v19));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v56, v57)), v15));
        let v60: Rc<str> = format_real_71(v5);
        let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v59, v60)))), v53)))))), v53));
        let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v66));
        v68.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure45() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many_strings / first inner parser consumed no text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure46() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many_strings / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method81(mut v0: Rc<str>, mut v1: Rc<RefCell<std::string::String>>, mut v2: Rc<RefCell<std::string::String>>, mut v3: Rc<str>, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> US13 {
    loop {
        let (mut v10, mut v11, mut v12, mut v13, mut v14): (i32, i32, i32, i32, i32) = method80(v6, v7, v8, v9, v0.clone(), v5, v6, v7, v8, v9);
        let v15: bool = v10 > v5;
        let mut v25: US13 = if v15 {
            let mut v16: bool = v5 >= v10;
            let v21: Rc<str> = if v16 {
                let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v17.clone()
            } else {
                let v19: i32 = v10.wrapping_sub(1i32);
                let mut v20: Rc<str> = string_slice(&v0.clone(), v5 as i64, v19 as i64);
                v20.clone()
            };
            US13::US13_Ok(v21.clone(), v10, v11, v12, v13, v14)
        } else {
            let v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
            US13::US13_Error(v23.clone(), v5, v6, v7, v8, v9)
        };
        let mut v220: US13 = match &v25 {
            US13::US13_Error(v32, v33, v34, v35, v36, v37) => {
                let mut v32: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v32.clone();
                let mut v33: i32 = *v33;
                let mut v34: i32 = *v34;
                let mut v35: i32 = *v35;
                let v36: i32 = *v36;
                let v37: i32 = *v37;
                let mut v38: bool = v5 >= v9;
                let v56: US12 = if v38 {
                    let v39: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                    US12::US12_Error(v39.clone(), v5, v6, v7, v8, v9)
                } else {
                    let v41: u8 = v0.clone().as_bytes()[v5 as usize];
                    let v42: bool = v41 == b'\\';
                    if v42 {
                        let v43: i32 = v5.wrapping_add(1i32);
                        let mut v44: bool = b'\n' == v41;
                        let (mut v48, mut v49, mut v50, mut v51): (i32, i32, i32, i32) = if v44 {
                            let mut v45: i32 = v6.wrapping_add(v8);
                            let mut v46: i32 = v7.wrapping_add(1i32);
                            (v45, v46, 1i32, v9)
                        } else {
                            let mut v47: i32 = v8.wrapping_add(1i32);
                            (v6, v7, v47, v9)
                        };
                        US12::US12_Ok(b'\\', v43, v48, v49, v50, v51)
                    } else {
                        let v53: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                        US12::US12_Error(v53.clone(), v5, v6, v7, v8, v9)
                    }
                };
                let v91: US12 = match &v56 {
                    US12::US12_Error(v83, v84, v85, v86, v87, v88) => {
                        let mut v83: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v83.clone();
                        let mut v84: i32 = *v84;
                        let mut v85: i32 = *v85;
                        let mut v86: i32 = *v86;
                        let mut v87: i32 = *v87;
                        let mut v88: i32 = *v88;
                        US12::US12_Error(v83.clone(), v84, v85, v86, v87, v88)
                    }
                    US12::US12_Ok(v57, v58, v59, v60, v61, v62) => {
                        let mut v57: u8 = *v57;
                        let v58: i32 = *v58;
                        let mut v59: i32 = *v59;
                        let v60: i32 = *v60;
                        let v61: i32 = *v61;
                        let v62: i32 = *v62;
                        let mut v63: bool = v58 >= v62;
                        if v63 {
                            let v64: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                            US12::US12_Error(v64.clone(), v58, v59, v60, v61, v62)
                        } else {
                            let v66: u8 = v0.clone().as_bytes()[v58 as usize];
                            let v67: bool = v66 == b'"';
                            let mut v68: bool = v67 == false;
                            if v68 {
                                let v69: i32 = v58.wrapping_add(1i32);
                                let mut v70: bool = b'\n' == v66;
                                let (mut v74, mut v75, mut v76, mut v77): (i32, i32, i32, i32) = if v70 {
                                    let v71: i32 = v59.wrapping_add(v61);
                                    let v72: i32 = v60.wrapping_add(1i32);
                                    (v71, v72, 1i32, v62)
                                } else {
                                    let mut v73: i32 = v61.wrapping_add(1i32);
                                    (v59, v60, v73, v62)
                                };
                                US12::US12_Ok(v66, v69, v74, v75, v76, v77)
                            } else {
                                let mut v79: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                US12::US12_Error(v79.clone(), v58, v59, v60, v61, v62)
                            }
                        }
                    }
                };
                let mut v113: US13 = match &v91 {
                    US12::US12_Error(v105, v106, v107, v108, v109, v110) => {
                        let mut v105: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v105.clone();
                        let v106: i32 = *v106;
                        let v107: i32 = *v107;
                        let mut v108: i32 = *v108;
                        let mut v109: i32 = *v109;
                        let mut v110: i32 = *v110;
                        US13::US13_Error(v105.clone(), v106, v107, v108, v109, v110)
                    }
                    US12::US12_Ok(v92, v93, v94, v95, v96, v97) => {
                        let v92: u8 = *v92;
                        let mut v93: i32 = *v93;
                        let v94: i32 = *v94;
                        let v95: i32 = *v95;
                        let v96: i32 = *v96;
                        let v97: i32 = *v97;
                        let mut v98: bool = v5 >= v93;
                        let v103: Rc<str> = if v98 {
                            let v99: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v99.clone()
                        } else {
                            let v101: i32 = v93.wrapping_sub(1i32);
                            let mut v102: Rc<str> = string_slice(&v0.clone(), v5 as i64, v101 as i64);
                            v102.clone()
                        };
                        US13::US13_Ok(v103.clone(), v93, v94, v95, v96, v97)
                    }
                };
                match &v113 {
                    US13::US13_Error(v120, v121, v122, v123, v124, v125) => {
                        let v120: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v120.clone();
                        let mut v121: i32 = *v121;
                        let mut v122: i32 = *v122;
                        let v123: i32 = *v123;
                        let mut v124: i32 = *v124;
                        let v125: i32 = *v125;
                        let v143: US12 = if v38 {
                            let v126: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                            US12::US12_Error(v126.clone(), v5, v6, v7, v8, v9)
                        } else {
                            let v128: u8 = v0.clone().as_bytes()[v5 as usize];
                            let v129: bool = v128 == b'`';
                            if v129 {
                                let mut v130: i32 = v5.wrapping_add(1i32);
                                let v131: bool = b'\n' == v128;
                                let (mut v135, mut v136, mut v137, mut v138): (i32, i32, i32, i32) = if v131 {
                                    let v132: i32 = v6.wrapping_add(v8);
                                    let v133: i32 = v7.wrapping_add(1i32);
                                    (v132, v133, 1i32, v9)
                                } else {
                                    let v134: i32 = v8.wrapping_add(1i32);
                                    (v6, v7, v134, v9)
                                };
                                US12::US12_Ok(b'`', v130, v135, v136, v137, v138)
                            } else {
                                let v140: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                US12::US12_Error(v140.clone(), v5, v6, v7, v8, v9)
                            }
                        };
                        let mut v178: US12 = match &v143 {
                            US12::US12_Error(v170, v171, v172, v173, v174, v175) => {
                                let v170: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v170.clone();
                                let v171: i32 = *v171;
                                let mut v172: i32 = *v172;
                                let v173: i32 = *v173;
                                let v174: i32 = *v174;
                                let mut v175: i32 = *v175;
                                US12::US12_Error(v170.clone(), v171, v172, v173, v174, v175)
                            }
                            US12::US12_Ok(v144, v145, v146, v147, v148, v149) => {
                                let v144: u8 = *v144;
                                let v145: i32 = *v145;
                                let v146: i32 = *v146;
                                let mut v147: i32 = *v147;
                                let mut v148: i32 = *v148;
                                let v149: i32 = *v149;
                                let mut v150: bool = v145 >= v149;
                                if v150 {
                                    let mut v151: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                                    US12::US12_Error(v151.clone(), v145, v146, v147, v148, v149)
                                } else {
                                    let v153: u8 = v0.clone().as_bytes()[v145 as usize];
                                    let v154: bool = v153 == b'"';
                                    let mut v155: bool = v154 == false;
                                    if v155 {
                                        let v156: i32 = v145.wrapping_add(1i32);
                                        let v157: bool = b'\n' == v153;
                                        let (mut v161, mut v162, mut v163, mut v164): (i32, i32, i32, i32) = if v157 {
                                            let v158: i32 = v146.wrapping_add(v148);
                                            let mut v159: i32 = v147.wrapping_add(1i32);
                                            (v158, v159, 1i32, v149)
                                        } else {
                                            let v160: i32 = v148.wrapping_add(1i32);
                                            (v146, v147, v160, v149)
                                        };
                                        US12::US12_Ok(v153, v156, v161, v162, v163, v164)
                                    } else {
                                        let mut v166: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                        US12::US12_Error(v166.clone(), v145, v146, v147, v148, v149)
                                    }
                                }
                            }
                        };
                        let v200: US13 = match &v178 {
                            US12::US12_Error(v192, v193, v194, v195, v196, v197) => {
                                let v192: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v192.clone();
                                let v193: i32 = *v193;
                                let v194: i32 = *v194;
                                let v195: i32 = *v195;
                                let v196: i32 = *v196;
                                let v197: i32 = *v197;
                                US13::US13_Error(v192.clone(), v193, v194, v195, v196, v197)
                            }
                            US12::US12_Ok(v179, v180, v181, v182, v183, v184) => {
                                let v179: u8 = *v179;
                                let v180: i32 = *v180;
                                let mut v181: i32 = *v181;
                                let mut v182: i32 = *v182;
                                let mut v183: i32 = *v183;
                                let v184: i32 = *v184;
                                let v185: bool = v5 >= v180;
                                let mut v190: Rc<str> = if v185 {
                                    let v186: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v186.clone()
                                } else {
                                    let v188: i32 = v180.wrapping_sub(1i32);
                                    let mut v189: Rc<str> = string_slice(&v0.clone(), v5 as i64, v188 as i64);
                                    v189.clone()
                                };
                                US13::US13_Ok(v190.clone(), v180, v181, v182, v183, v184)
                            }
                        };
                        match &v200 {
                            US13::US13_Error(v207, v208, v209, v210, v211, v212) => {
                                let v207: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v207.clone();
                                let v208: i32 = *v208;
                                let v209: i32 = *v209;
                                let v210: i32 = *v210;
                                let v211: i32 = *v211;
                                let v212: i32 = *v212;
                                let v213: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                US13::US13_Error(v213.clone(), v5, v6, v7, v8, v9)
                            }
                            US13::US13_Ok(v201, v202, v203, v204, v205, v206) => {
                                let mut v201: Rc<str> = v201.clone();
                                let v202: i32 = *v202;
                                let v203: i32 = *v203;
                                let v204: i32 = *v204;
                                let v205: i32 = *v205;
                                let v206: i32 = *v206;
                                v200.clone()
                            }
                        }
                    }
                    US13::US13_Ok(v114, v115, v116, v117, v118, v119) => {
                        let v114: Rc<str> = v114.clone();
                        let mut v115: i32 = *v115;
                        let mut v116: i32 = *v116;
                        let v117: i32 = *v117;
                        let v118: i32 = *v118;
                        let mut v119: i32 = *v119;
                        v113.clone()
                    }
                }
            }
            US13::US13_Ok(v26, v27, v28, v29, v30, v31) => {
                let mut v26: Rc<str> = v26.clone();
                let mut v27: i32 = *v27;
                let mut v28: i32 = *v28;
                let mut v29: i32 = *v29;
                let v30: i32 = *v30;
                let mut v31: i32 = *v31;
                v25.clone()
            }
        };
        match &v220 {
            US13::US13_Error(v221, v222, v223, v224, v225, v226) => {
                let mut v221: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v221.clone();
                let mut v222: i32 = *v222;
                let v223: i32 = *v223;
                let v224: i32 = *v224;
                let v225: i32 = *v225;
                let v226: i32 = *v226;
                let mut v227: bool = v4 == 0i32;
                let v229: Rc<str> = if v227 {
                    v3.clone()
                } else {
                    let v228: Rc<str> = Rc::<str>::from(v1.borrow().as_str());
                    v228.clone()
                };
                return US13::US13_Ok(v229.clone(), v5, v6, v7, v8, v9);
            }
            US13::US13_Ok(v231, v232, v233, v234, v235, v236) => {
                let mut v231: Rc<str> = v231.clone();
                let mut v232: i32 = *v232;
                let v233: i32 = *v233;
                let v234: i32 = *v234;
                let mut v235: i32 = *v235;
                let mut v236: i32 = *v236;
                let v237: bool = v232 > v5;
                if v237 {
                    let v238: bool = v4 == 0i32;
                    if v238 {
                        v2.borrow_mut().push_str(&*v3);
                        ()
                    };
                    v2.borrow_mut().push_str(&*v231);
                    let v239: i32 = v4.wrapping_add(1i32);
                    (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v239, v232, v233, v234, v235, v236);
                    continue;
                } else {
                    let v241: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure46();
                    return US13::US13_Error(v241.clone(), v5, v6, v7, v8, v9);
                }
            }
        }
    }
}
fn closure47() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v10));
        let mut v16: Rc<str> = format_real_71(v2);
        let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
        let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v19, v20)), v10));
        let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v10));
        let mut v27: Rc<str> = format_real_71(v3);
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v18));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v10));
        let mut v33: Rc<str> = format_real_71(v4);
        let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, Rc::<str>::from(format!("{}{}", v36, v37)))), v18));
        let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v40, v41)), v10));
        let mut v44: Rc<str> = format_real_71(v5);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, Rc::<str>::from(format!("{}{}", v11, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, Rc::<str>::from(format!("{}{}", v43, v44)))), v37)))))), v37));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.any_char / unexpected end of t / "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        v52.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method82(mut v0: Rc<str>, mut v1: Rc<RefCell<std::string::String>>, mut v2: Rc<RefCell<std::string::String>>, mut v3: Rc<str>, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> US13 {
    loop {
        let (mut v10, mut v11, mut v12, mut v13, mut v14): (i32, i32, i32, i32, i32) = method80(v6, v7, v8, v9, v0.clone(), v5, v6, v7, v8, v9);
        let v15: bool = v10 > v5;
        let mut v25: US13 = if v15 {
            let mut v16: bool = v5 >= v10;
            let v21: Rc<str> = if v16 {
                let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v17.clone()
            } else {
                let v19: i32 = v10.wrapping_sub(1i32);
                let mut v20: Rc<str> = string_slice(&v0.clone(), v5 as i64, v19 as i64);
                v20.clone()
            };
            US13::US13_Ok(v21.clone(), v10, v11, v12, v13, v14)
        } else {
            let v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
            US13::US13_Error(v23.clone(), v5, v6, v7, v8, v9)
        };
        let v210: US13 = match &v25 {
            US13::US13_Error(v32, v33, v34, v35, v36, v37) => {
                let mut v32: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v32.clone();
                let mut v33: i32 = *v33;
                let mut v34: i32 = *v34;
                let mut v35: i32 = *v35;
                let v36: i32 = *v36;
                let v37: i32 = *v37;
                let mut v38: bool = v5 >= v9;
                let v56: US12 = if v38 {
                    let v39: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                    US12::US12_Error(v39.clone(), v5, v6, v7, v8, v9)
                } else {
                    let v41: u8 = v0.clone().as_bytes()[v5 as usize];
                    let v42: bool = v41 == b'\\';
                    if v42 {
                        let v43: i32 = v5.wrapping_add(1i32);
                        let mut v44: bool = b'\n' == v41;
                        let (mut v48, mut v49, mut v50, mut v51): (i32, i32, i32, i32) = if v44 {
                            let mut v45: i32 = v6.wrapping_add(v8);
                            let mut v46: i32 = v7.wrapping_add(1i32);
                            (v45, v46, 1i32, v9)
                        } else {
                            let mut v47: i32 = v8.wrapping_add(1i32);
                            (v6, v7, v47, v9)
                        };
                        US12::US12_Ok(b'\\', v43, v48, v49, v50, v51)
                    } else {
                        let v53: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                        US12::US12_Error(v53.clone(), v5, v6, v7, v8, v9)
                    }
                };
                let mut v86: US12 = match &v56 {
                    US12::US12_Error(v78, v79, v80, v81, v82, v83) => {
                        let v78: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v78.clone();
                        let mut v79: i32 = *v79;
                        let mut v80: i32 = *v80;
                        let mut v81: i32 = *v81;
                        let mut v82: i32 = *v82;
                        let mut v83: i32 = *v83;
                        US12::US12_Error(v78.clone(), v79, v80, v81, v82, v83)
                    }
                    US12::US12_Ok(v57, v58, v59, v60, v61, v62) => {
                        let mut v57: u8 = *v57;
                        let v58: i32 = *v58;
                        let mut v59: i32 = *v59;
                        let v60: i32 = *v60;
                        let v61: i32 = *v61;
                        let v62: i32 = *v62;
                        let mut v63: bool = v58 >= v62;
                        if v63 {
                            let v64: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                            US12::US12_Error(v64.clone(), v58, v59, v60, v61, v62)
                        } else {
                            let v66: u8 = v0.clone().as_bytes()[v58 as usize];
                            let v67: i32 = v58.wrapping_add(1i32);
                            let mut v68: bool = b'\n' == v66;
                            let (mut v72, mut v73, mut v74, mut v75): (i32, i32, i32, i32) = if v68 {
                                let v69: i32 = v59.wrapping_add(v61);
                                let mut v70: i32 = v60.wrapping_add(1i32);
                                (v69, v70, 1i32, v62)
                            } else {
                                let v71: i32 = v61.wrapping_add(1i32);
                                (v59, v60, v71, v62)
                            };
                            US12::US12_Ok(v66, v67, v72, v73, v74, v75)
                        }
                    }
                };
                let mut v108: US13 = match &v86 {
                    US12::US12_Error(v100, v101, v102, v103, v104, v105) => {
                        let v100: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v100.clone();
                        let v101: i32 = *v101;
                        let mut v102: i32 = *v102;
                        let v103: i32 = *v103;
                        let mut v104: i32 = *v104;
                        let mut v105: i32 = *v105;
                        US13::US13_Error(v100.clone(), v101, v102, v103, v104, v105)
                    }
                    US12::US12_Ok(v87, v88, v89, v90, v91, v92) => {
                        let mut v87: u8 = *v87;
                        let mut v88: i32 = *v88;
                        let v89: i32 = *v89;
                        let v90: i32 = *v90;
                        let v91: i32 = *v91;
                        let v92: i32 = *v92;
                        let mut v93: bool = v5 >= v88;
                        let mut v98: Rc<str> = if v93 {
                            let v94: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v94.clone()
                        } else {
                            let v96: i32 = v88.wrapping_sub(1i32);
                            let v97: Rc<str> = string_slice(&v0.clone(), v5 as i64, v96 as i64);
                            v97.clone()
                        };
                        US13::US13_Ok(v98.clone(), v88, v89, v90, v91, v92)
                    }
                };
                match &v108 {
                    US13::US13_Error(v115, v116, v117, v118, v119, v120) => {
                        let mut v115: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v115.clone();
                        let mut v116: i32 = *v116;
                        let v117: i32 = *v117;
                        let v118: i32 = *v118;
                        let mut v119: i32 = *v119;
                        let v120: i32 = *v120;
                        let v138: US12 = if v38 {
                            let mut v121: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                            US12::US12_Error(v121.clone(), v5, v6, v7, v8, v9)
                        } else {
                            let v123: u8 = v0.clone().as_bytes()[v5 as usize];
                            let mut v124: bool = v123 == b'`';
                            if v124 {
                                let v125: i32 = v5.wrapping_add(1i32);
                                let v126: bool = b'\n' == v123;
                                let (mut v130, mut v131, mut v132, mut v133): (i32, i32, i32, i32) = if v126 {
                                    let mut v127: i32 = v6.wrapping_add(v8);
                                    let v128: i32 = v7.wrapping_add(1i32);
                                    (v127, v128, 1i32, v9)
                                } else {
                                    let v129: i32 = v8.wrapping_add(1i32);
                                    (v6, v7, v129, v9)
                                };
                                US12::US12_Ok(b'`', v125, v130, v131, v132, v133)
                            } else {
                                let v135: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                US12::US12_Error(v135.clone(), v5, v6, v7, v8, v9)
                            }
                        };
                        let mut v168: US12 = match &v138 {
                            US12::US12_Error(v160, v161, v162, v163, v164, v165) => {
                                let v160: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v160.clone();
                                let mut v161: i32 = *v161;
                                let mut v162: i32 = *v162;
                                let mut v163: i32 = *v163;
                                let mut v164: i32 = *v164;
                                let mut v165: i32 = *v165;
                                US12::US12_Error(v160.clone(), v161, v162, v163, v164, v165)
                            }
                            US12::US12_Ok(v139, v140, v141, v142, v143, v144) => {
                                let mut v139: u8 = *v139;
                                let v140: i32 = *v140;
                                let v141: i32 = *v141;
                                let v142: i32 = *v142;
                                let v143: i32 = *v143;
                                let v144: i32 = *v144;
                                let v145: bool = v140 >= v144;
                                if v145 {
                                    let v146: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                                    US12::US12_Error(v146.clone(), v140, v141, v142, v143, v144)
                                } else {
                                    let mut v148: u8 = v0.clone().as_bytes()[v140 as usize];
                                    let v149: i32 = v140.wrapping_add(1i32);
                                    let mut v150: bool = b'\n' == v148;
                                    let (mut v154, mut v155, mut v156, mut v157): (i32, i32, i32, i32) = if v150 {
                                        let mut v151: i32 = v141.wrapping_add(v143);
                                        let mut v152: i32 = v142.wrapping_add(1i32);
                                        (v151, v152, 1i32, v144)
                                    } else {
                                        let v153: i32 = v143.wrapping_add(1i32);
                                        (v141, v142, v153, v144)
                                    };
                                    US12::US12_Ok(v148, v149, v154, v155, v156, v157)
                                }
                            }
                        };
                        let mut v190: US13 = match &v168 {
                            US12::US12_Error(v182, v183, v184, v185, v186, v187) => {
                                let mut v182: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v182.clone();
                                let mut v183: i32 = *v183;
                                let v184: i32 = *v184;
                                let v185: i32 = *v185;
                                let v186: i32 = *v186;
                                let v187: i32 = *v187;
                                US13::US13_Error(v182.clone(), v183, v184, v185, v186, v187)
                            }
                            US12::US12_Ok(v169, v170, v171, v172, v173, v174) => {
                                let v169: u8 = *v169;
                                let v170: i32 = *v170;
                                let v171: i32 = *v171;
                                let mut v172: i32 = *v172;
                                let v173: i32 = *v173;
                                let v174: i32 = *v174;
                                let mut v175: bool = v5 >= v170;
                                let v180: Rc<str> = if v175 {
                                    let v176: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v176.clone()
                                } else {
                                    let mut v178: i32 = v170.wrapping_sub(1i32);
                                    let v179: Rc<str> = string_slice(&v0.clone(), v5 as i64, v178 as i64);
                                    v179.clone()
                                };
                                US13::US13_Ok(v180.clone(), v170, v171, v172, v173, v174)
                            }
                        };
                        match &v190 {
                            US13::US13_Error(v197, v198, v199, v200, v201, v202) => {
                                let v197: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v197.clone();
                                let v198: i32 = *v198;
                                let v199: i32 = *v199;
                                let v200: i32 = *v200;
                                let mut v201: i32 = *v201;
                                let v202: i32 = *v202;
                                let v203: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                US13::US13_Error(v203.clone(), v5, v6, v7, v8, v9)
                            }
                            US13::US13_Ok(v191, v192, v193, v194, v195, v196) => {
                                let v191: Rc<str> = v191.clone();
                                let v192: i32 = *v192;
                                let v193: i32 = *v193;
                                let v194: i32 = *v194;
                                let v195: i32 = *v195;
                                let v196: i32 = *v196;
                                v190.clone()
                            }
                        }
                    }
                    US13::US13_Ok(v109, v110, v111, v112, v113, v114) => {
                        let mut v109: Rc<str> = v109.clone();
                        let mut v110: i32 = *v110;
                        let v111: i32 = *v111;
                        let mut v112: i32 = *v112;
                        let mut v113: i32 = *v113;
                        let v114: i32 = *v114;
                        v108.clone()
                    }
                }
            }
            US13::US13_Ok(v26, v27, v28, v29, v30, v31) => {
                let mut v26: Rc<str> = v26.clone();
                let mut v27: i32 = *v27;
                let mut v28: i32 = *v28;
                let mut v29: i32 = *v29;
                let v30: i32 = *v30;
                let mut v31: i32 = *v31;
                v25.clone()
            }
        };
        match &v210 {
            US13::US13_Error(v211, v212, v213, v214, v215, v216) => {
                let v211: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v211.clone();
                let v212: i32 = *v212;
                let v213: i32 = *v213;
                let v214: i32 = *v214;
                let v215: i32 = *v215;
                let v216: i32 = *v216;
                let mut v217: bool = v4 == 0i32;
                let mut v219: Rc<str> = if v217 {
                    v3.clone()
                } else {
                    let mut v218: Rc<str> = Rc::<str>::from(v1.borrow().as_str());
                    v218.clone()
                };
                return US13::US13_Ok(v219.clone(), v5, v6, v7, v8, v9);
            }
            US13::US13_Ok(v221, v222, v223, v224, v225, v226) => {
                let mut v221: Rc<str> = v221.clone();
                let mut v222: i32 = *v222;
                let v223: i32 = *v223;
                let v224: i32 = *v224;
                let v225: i32 = *v225;
                let v226: i32 = *v226;
                let mut v227: bool = v222 > v5;
                if v227 {
                    let v228: bool = v4 == 0i32;
                    if v228 {
                        v2.borrow_mut().push_str(&*v3);
                        ()
                    };
                    v2.borrow_mut().push_str(&*v221);
                    let v229: i32 = v4.wrapping_add(1i32);
                    (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v229, v222, v223, v224, v225, v226);
                    continue;
                } else {
                    let mut v231: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure46();
                    return US13::US13_Error(v231.clone(), v5, v6, v7, v8, v9);
                }
            }
        }
    }
}
fn method83(mut v0: i32, mut v1: Rc<str>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> (i32, i32, i32, i32, i32) {
    loop {
        let mut v7: bool = v2 >= v0;
        if v7 {
            return (v2, v3, v4, v5, v6);
        } else {
            let mut v8: u8 = v1.clone().as_bytes()[v2 as usize];
            let mut v9: bool = v8 == b'\\';
            let v15: bool = if v9 {
                true
            } else {
                let mut v10: bool = v8 == b'`';
                if v10 {
                    true
                } else {
                    let mut v11: bool = v8 == b'"';
                    if v11 {
                        true
                    } else {
                        let mut v12: bool = v8 == b' ';
                        v12
                    }
                }
            };
            let mut v16: bool = v15 == false;
            if v16 {
                let mut v17: i32 = v2.wrapping_add(1i32);
                let v18: bool = b'\n' == v8;
                let (mut v22, mut v23, mut v24, mut v25): (i32, i32, i32, i32) = if v18 {
                    let v19: i32 = v3.wrapping_add(v5);
                    let mut v20: i32 = v4.wrapping_add(1i32);
                    (v19, v20, 1i32, v6)
                } else {
                    let v21: i32 = v5.wrapping_add(1i32);
                    (v3, v4, v21, v6)
                };
                (v0, v1, v2, v3, v4, v5, v6) = (v0, v1.clone(), v17, v22, v23, v24, v25);
                continue;
            } else {
                return (v2, v3, v4, v5, v6);
            }
        }
    }
}
fn closure48() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v6.borrow_mut().push(b'\\');
        v6.borrow_mut().push(b'`');
        v6.borrow_mut().push(b'"');
        let mut v7: Rc<Vec<u8>> = Rc::new(v6.borrow().clone());
        let mut v8: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
        let mut v9: Rc<str> = method74(v8.clone());
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v9));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v18, v19)), v14));
        let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v14));
        let mut v26: Rc<str> = format_real_71(v2);
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v17));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v14));
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = format_real_71(v3);
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v17));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v14));
        let v42: Rc<str> = format_real_71(v4);
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, Rc::<str>::from(format!("{}{}", v45, v46)))), v17));
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v14));
        let v53: Rc<str> = format_real_71(v5);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v52, v53)))), v46)))))), v46));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        v61.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure49() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'\\');
        v7.borrow_mut().push(b'`');
        v7.borrow_mut().push(b'"');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method74(v9.clone());
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char = "); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = format_real_10(v6);
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v15)), v10)), v19));
        let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v15));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v15));
        let mut v33: Rc<str> = format_real_71(v2);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v19));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v15));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let v42: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v39, v40)), v15));
        let v43: Rc<str> = format_real_71(v3);
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v19));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v15));
        let mut v49: Rc<str> = format_real_71(v4);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, Rc::<str>::from(format!("{}{}", v52, v53)))), v19));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v56, v57)), v15));
        let v60: Rc<str> = format_real_71(v5);
        let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v59, v60)))), v53)))))), v53));
        let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v66));
        v68.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method85(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
    loop {
        match &*v0 {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: Rc<str> = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: Rc<UH0> = Rc::new(UH0::UH0_Cons(v2.clone(), v1.clone()));
                (v0, v1) = (v3.clone(), v4.clone());
                continue;
            }
            UH0::UH0_Nil => {
                return v1.clone();
            }
        }
    }
}
fn closure50() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method84(mut v0: Rc<str>, mut v1: Rc<UH0>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US21 {
    loop {
        let mut v7: bool = v2 >= v6;
        let mut v25: US12 = if v7 {
            let mut v8: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
            US12::US12_Error(v8.clone(), v2, v3, v4, v5, v6)
        } else {
            let mut v10: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v11: bool = v10 == b'\\';
            if v11 {
                let mut v12: i32 = v2.wrapping_add(1i32);
                let mut v13: bool = b'\n' == v10;
                let (mut v17, mut v18, mut v19, mut v20): (i32, i32, i32, i32) = if v13 {
                    let mut v14: i32 = v3.wrapping_add(v5);
                    let v15: i32 = v4.wrapping_add(1i32);
                    (v14, v15, 1i32, v6)
                } else {
                    let mut v16: i32 = v5.wrapping_add(1i32);
                    (v3, v4, v16, v6)
                };
                US12::US12_Ok(b'\\', v12, v17, v18, v19, v20)
            } else {
                let mut v22: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                US12::US12_Error(v22.clone(), v2, v3, v4, v5, v6)
            }
        };
        let v55: US12 = match &v25 {
            US12::US12_Error(v47, v48, v49, v50, v51, v52) => {
                let mut v47: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v47.clone();
                let mut v48: i32 = *v48;
                let mut v49: i32 = *v49;
                let v50: i32 = *v50;
                let v51: i32 = *v51;
                let mut v52: i32 = *v52;
                US12::US12_Error(v47.clone(), v48, v49, v50, v51, v52)
            }
            US12::US12_Ok(v26, v27, v28, v29, v30, v31) => {
                let mut v26: u8 = *v26;
                let mut v27: i32 = *v27;
                let mut v28: i32 = *v28;
                let mut v29: i32 = *v29;
                let v30: i32 = *v30;
                let mut v31: i32 = *v31;
                let mut v32: bool = v27 >= v31;
                if v32 {
                    let mut v33: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                    US12::US12_Error(v33.clone(), v27, v28, v29, v30, v31)
                } else {
                    let mut v35: u8 = v0.clone().as_bytes()[v27 as usize];
                    let v36: i32 = v27.wrapping_add(1i32);
                    let v37: bool = b'\n' == v35;
                    let (mut v41, mut v42, mut v43, mut v44): (i32, i32, i32, i32) = if v37 {
                        let mut v38: i32 = v28.wrapping_add(v30);
                        let v39: i32 = v29.wrapping_add(1i32);
                        (v38, v39, 1i32, v31)
                    } else {
                        let v40: i32 = v30.wrapping_add(1i32);
                        (v28, v29, v40, v31)
                    };
                    US12::US12_Ok(v35, v36, v41, v42, v43, v44)
                }
            }
        };
        let mut v77: US13 = match &v55 {
            US12::US12_Error(v69, v70, v71, v72, v73, v74) => {
                let v69: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v69.clone();
                let mut v70: i32 = *v70;
                let v71: i32 = *v71;
                let v72: i32 = *v72;
                let mut v73: i32 = *v73;
                let v74: i32 = *v74;
                US13::US13_Error(v69.clone(), v70, v71, v72, v73, v74)
            }
            US12::US12_Ok(v56, v57, v58, v59, v60, v61) => {
                let v56: u8 = *v56;
                let mut v57: i32 = *v57;
                let v58: i32 = *v58;
                let mut v59: i32 = *v59;
                let v60: i32 = *v60;
                let v61: i32 = *v61;
                let v62: bool = v2 >= v57;
                let v67: Rc<str> = if v62 {
                    let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v63.clone()
                } else {
                    let mut v65: i32 = v57.wrapping_sub(1i32);
                    let v66: Rc<str> = string_slice(&v0.clone(), v2 as i64, v65 as i64);
                    v66.clone()
                };
                US13::US13_Ok(v67.clone(), v57, v58, v59, v60, v61)
            }
        };
        let v177: US13 = match &v77 {
            US13::US13_Error(v84, v85, v86, v87, v88, v89) => {
                let mut v84: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v84.clone();
                let mut v85: i32 = *v85;
                let mut v86: i32 = *v86;
                let mut v87: i32 = *v87;
                let mut v88: i32 = *v88;
                let v89: i32 = *v89;
                let v107: US12 = if v7 {
                    let v90: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                    US12::US12_Error(v90.clone(), v2, v3, v4, v5, v6)
                } else {
                    let v92: u8 = v0.clone().as_bytes()[v2 as usize];
                    let mut v93: bool = v92 == b'`';
                    if v93 {
                        let v94: i32 = v2.wrapping_add(1i32);
                        let v95: bool = b'\n' == v92;
                        let (mut v99, mut v100, mut v101, mut v102): (i32, i32, i32, i32) = if v95 {
                            let v96: i32 = v3.wrapping_add(v5);
                            let v97: i32 = v4.wrapping_add(1i32);
                            (v96, v97, 1i32, v6)
                        } else {
                            let mut v98: i32 = v5.wrapping_add(1i32);
                            (v3, v4, v98, v6)
                        };
                        US12::US12_Ok(b'`', v94, v99, v100, v101, v102)
                    } else {
                        let mut v104: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                        US12::US12_Error(v104.clone(), v2, v3, v4, v5, v6)
                    }
                };
                let v137: US12 = match &v107 {
                    US12::US12_Error(v129, v130, v131, v132, v133, v134) => {
                        let v129: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v129.clone();
                        let mut v130: i32 = *v130;
                        let v131: i32 = *v131;
                        let v132: i32 = *v132;
                        let v133: i32 = *v133;
                        let v134: i32 = *v134;
                        US12::US12_Error(v129.clone(), v130, v131, v132, v133, v134)
                    }
                    US12::US12_Ok(v108, v109, v110, v111, v112, v113) => {
                        let mut v108: u8 = *v108;
                        let mut v109: i32 = *v109;
                        let mut v110: i32 = *v110;
                        let v111: i32 = *v111;
                        let mut v112: i32 = *v112;
                        let mut v113: i32 = *v113;
                        let v114: bool = v109 >= v113;
                        if v114 {
                            let mut v115: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                            US12::US12_Error(v115.clone(), v109, v110, v111, v112, v113)
                        } else {
                            let v117: u8 = v0.clone().as_bytes()[v109 as usize];
                            let v118: i32 = v109.wrapping_add(1i32);
                            let mut v119: bool = b'\n' == v117;
                            let (mut v123, mut v124, mut v125, mut v126): (i32, i32, i32, i32) = if v119 {
                                let v120: i32 = v110.wrapping_add(v112);
                                let mut v121: i32 = v111.wrapping_add(1i32);
                                (v120, v121, 1i32, v113)
                            } else {
                                let mut v122: i32 = v112.wrapping_add(1i32);
                                (v110, v111, v122, v113)
                            };
                            US12::US12_Ok(v117, v118, v123, v124, v125, v126)
                        }
                    }
                };
                let mut v159: US13 = match &v137 {
                    US12::US12_Error(v151, v152, v153, v154, v155, v156) => {
                        let mut v151: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v151.clone();
                        let mut v152: i32 = *v152;
                        let v153: i32 = *v153;
                        let v154: i32 = *v154;
                        let mut v155: i32 = *v155;
                        let v156: i32 = *v156;
                        US13::US13_Error(v151.clone(), v152, v153, v154, v155, v156)
                    }
                    US12::US12_Ok(v138, v139, v140, v141, v142, v143) => {
                        let v138: u8 = *v138;
                        let mut v139: i32 = *v139;
                        let v140: i32 = *v140;
                        let v141: i32 = *v141;
                        let v142: i32 = *v142;
                        let v143: i32 = *v143;
                        let v144: bool = v2 >= v139;
                        let v149: Rc<str> = if v144 {
                            let v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v145.clone()
                        } else {
                            let mut v147: i32 = v139.wrapping_sub(1i32);
                            let mut v148: Rc<str> = string_slice(&v0.clone(), v2 as i64, v147 as i64);
                            v148.clone()
                        };
                        US13::US13_Ok(v149.clone(), v139, v140, v141, v142, v143)
                    }
                };
                match &v159 {
                    US13::US13_Error(v166, v167, v168, v169, v170, v171) => {
                        let mut v166: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v166.clone();
                        let mut v167: i32 = *v167;
                        let mut v168: i32 = *v168;
                        let v169: i32 = *v169;
                        let v170: i32 = *v170;
                        let v171: i32 = *v171;
                        let mut v172: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                        US13::US13_Error(v172.clone(), v2, v3, v4, v5, v6)
                    }
                    US13::US13_Ok(v160, v161, v162, v163, v164, v165) => {
                        let v160: Rc<str> = v160.clone();
                        let mut v161: i32 = *v161;
                        let mut v162: i32 = *v162;
                        let mut v163: i32 = *v163;
                        let mut v164: i32 = *v164;
                        let mut v165: i32 = *v165;
                        v159.clone()
                    }
                }
            }
            US13::US13_Ok(v78, v79, v80, v81, v82, v83) => {
                let v78: Rc<str> = v78.clone();
                let mut v79: i32 = *v79;
                let mut v80: i32 = *v80;
                let mut v81: i32 = *v81;
                let mut v82: i32 = *v82;
                let mut v83: i32 = *v83;
                v77.clone()
            }
        };
        let v194: US13 = match &v177 {
            US13::US13_Error(v186, v187, v188, v189, v190, v191) => {
                let v186: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v186.clone();
                let v187: i32 = *v187;
                let v188: i32 = *v188;
                let mut v189: i32 = *v189;
                let mut v190: i32 = *v190;
                let v191: i32 = *v191;
                US13::US13_Error(v186.clone(), v187, v188, v189, v190, v191)
            }
            US13::US13_Ok(v178, v179, v180, v181, v182, v183) => {
                let mut v178: Rc<str> = v178.clone();
                let v179: i32 = *v179;
                let v180: i32 = *v180;
                let mut v181: i32 = *v181;
                let mut v182: i32 = *v182;
                let mut v183: i32 = *v183;
                let v184: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                US13::US13_Ok(v184.clone(), v179, v180, v181, v182, v183)
            }
        };
        let mut v250: US13 = match &v194 {
            US13::US13_Error(v242, v243, v244, v245, v246, v247) => {
                let v242: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v242.clone();
                let v243: i32 = *v243;
                let v244: i32 = *v244;
                let v245: i32 = *v245;
                let v246: i32 = *v246;
                let v247: i32 = *v247;
                US13::US13_Error(v242.clone(), v243, v244, v245, v246, v247)
            }
            US13::US13_Ok(v195, v196, v197, v198, v199, v200) => {
                let v195: Rc<str> = v195.clone();
                let v196: i32 = *v196;
                let v197: i32 = *v197;
                let v198: i32 = *v198;
                let v199: i32 = *v199;
                let v200: i32 = *v200;
                let mut v201: bool = v196 >= v200;
                let v224: US12 = if v201 {
                    let v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure48();
                    US12::US12_Error(v202.clone(), v196, v197, v198, v199, v200)
                } else {
                    let v204: u8 = v0.clone().as_bytes()[v196 as usize];
                    let v205: bool = v204 == b'\\';
                    let v209: bool = if v205 {
                        true
                    } else {
                        let v206: bool = v204 == b'`';
                        if v206 {
                            true
                        } else {
                            let v207: bool = v204 == b'"';
                            v207
                        }
                    };
                    let v210: bool = v209 == false;
                    if v210 {
                        let v211: i32 = v196.wrapping_add(1i32);
                        let v212: bool = b'\n' == v204;
                        let (mut v216, mut v217, mut v218, mut v219): (i32, i32, i32, i32) = if v212 {
                            let v213: i32 = v197.wrapping_add(v199);
                            let v214: i32 = v198.wrapping_add(1i32);
                            (v213, v214, 1i32, v200)
                        } else {
                            let v215: i32 = v199.wrapping_add(1i32);
                            (v197, v198, v215, v200)
                        };
                        US12::US12_Ok(v204, v211, v216, v217, v218, v219)
                    } else {
                        let mut v221: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure49();
                        US12::US12_Error(v221.clone(), v196, v197, v198, v199, v200)
                    }
                };
                match &v224 {
                    US12::US12_Error(v233, v234, v235, v236, v237, v238) => {
                        let v233: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v233.clone();
                        let v234: i32 = *v234;
                        let mut v235: i32 = *v235;
                        let mut v236: i32 = *v236;
                        let v237: i32 = *v237;
                        let v238: i32 = *v238;
                        US13::US13_Error(v233.clone(), v234, v235, v236, v237, v238)
                    }
                    US12::US12_Ok(v225, v226, v227, v228, v229, v230) => {
                        let v225: u8 = *v225;
                        let v226: i32 = *v226;
                        let mut v227: i32 = *v227;
                        let v228: i32 = *v228;
                        let v229: i32 = *v229;
                        let mut v230: i32 = *v230;
                        let mut v231: Rc<str> = Rc::<str>::from((v225 as char).encode_utf8(&mut [0u8; 4]) as &str);
                        US13::US13_Ok(v231.clone(), v226, v227, v228, v229, v230)
                    }
                }
            }
        };
        match &v250 {
            US13::US13_Error(v251, v252, v253, v254, v255, v256) => {
                let v251: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v251.clone();
                let v252: i32 = *v252;
                let v253: i32 = *v253;
                let v254: i32 = *v254;
                let v255: i32 = *v255;
                let v256: i32 = *v256;
                let mut v257: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                let v258: Rc<UH0> = method85(v1.clone(), v257.clone());
                return US21::US21_Ok(v258.clone(), v2, v3, v4, v5, v6);
            }
            US13::US13_Ok(v260, v261, v262, v263, v264, v265) => {
                let v260: Rc<str> = v260.clone();
                let mut v261: i32 = *v261;
                let mut v262: i32 = *v262;
                let v263: i32 = *v263;
                let v264: i32 = *v264;
                let v265: i32 = *v265;
                let v266: bool = v261 > v2;
                if v266 {
                    let v267: Rc<UH0> = Rc::new(UH0::UH0_Cons(v260.clone(), v1.clone()));
                    (v0, v1, v2, v3, v4, v5, v6) = (v0.clone(), v267.clone(), v261, v262, v263, v264, v265);
                    continue;
                } else {
                    let v269: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure50();
                    return US21::US21_Error(v269.clone(), v2, v3, v4, v5, v6);
                }
            }
        }
    }
}
fn closure51() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("process.split_args / segment zero-length success"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method87(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: Rc<str>, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> (i32, i32, i32, i32, i32) {
    loop {
        let mut v10: bool = v5 >= v3;
        if v10 {
            return (v5, v6, v7, v8, v9);
        } else {
            let mut v11: u8 = v4.clone().as_bytes()[v5 as usize];
            let mut v12: bool = v11 == b'\\';
            let v18: bool = if v12 {
                true
            } else {
                let mut v13: bool = v11 == b'`';
                if v13 {
                    true
                } else {
                    let mut v14: bool = v11 == b'"';
                    if v14 {
                        true
                    } else {
                        let v15: bool = v11 == b' ';
                        v15
                    }
                }
            };
            let v19: bool = v18 == false;
            if v19 {
                let mut v20: i32 = v5.wrapping_add(1i32);
                let v21: bool = b'\n' == v11;
                let (mut v25, mut v26, mut v27, mut v28): (i32, i32, i32, i32) = if v21 {
                    let mut v22: i32 = v6.wrapping_add(v8);
                    let v23: i32 = v7.wrapping_add(1i32);
                    (v22, v23, 1i32, v9)
                } else {
                    let v24: i32 = v8.wrapping_add(1i32);
                    (v6, v7, v24, v9)
                };
                (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0, v1, v2, v3, v4.clone(), v20, v25, v26, v27, v28);
                continue;
            } else {
                return (v5, v6, v7, v8, v9);
            }
        }
    }
}
fn method88(mut v0: Rc<UH0>, mut v1: i32) -> i32 {
    loop {
        match &*v0 {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: Rc<str> = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: i32 = (v2.clone().len() as i32);
                let mut v5: i32 = v1.wrapping_add(v4);
                (v0, v1) = (v3.clone(), v5);
                continue;
            }
            UH0::UH0_Nil => {
                return v1;
            }
        }
    }
}
fn method89(mut v0: Rc<RefCell<Vec<u8>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                let mut v5: i32 = (v3.clone().len() as i32);
                let mut v6: i32 = v2.wrapping_sub(v5);
                let mut v7: usize = ((v6) as usize);
                let mut v8: usize = ((v2) as usize);
                v0.borrow_mut()[v7..v8].copy_from_slice(v3.as_bytes());
                (v0, v1, v2) = (v0.clone(), v4.clone(), v6);
                continue;
            }
            UH0::UH0_Nil => {
                return v2;
            }
        }
    }
}
fn pass_91(mut v0: bool, mut v1: Rc<UH0>, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                match &*v4 {
                    UH0::UH0_Cons(v5, v6) => {
                        let mut v5: Rc<str> = v5.clone();
                        let mut v6: Rc<UH0> = v6.clone();
                        let mut v9: Rc<str> = if v0 {
                            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v3));
                            v7.clone()
                        } else {
                            let mut v8: Rc<str> = Rc::<str>::from(format!("{}{}", v3, v5));
                            v8.clone()
                        };
                        let mut v10: Rc<UH0> = Rc::new(UH0::UH0_Cons(v9.clone(), v2.clone()));
                        (v0, v1, v2) = (v0, v6.clone(), v10.clone());
                        continue;
                    }
                    UH0::UH0_Nil => {
                        return Rc::new(UH0::UH0_Cons(v3.clone(), v2.clone()));
                    }
                }
            }
            UH0::UH0_Nil => {
                return v2.clone();
            }
        }
    }
}
fn method90(mut v0: bool, mut v1: Rc<UH0>) -> Rc<str> {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                match &*v4 {
                    UH0::UH0_Nil => {
                        return v3.clone();
                    }
                    _ => {
                        let mut v5: bool = v0 == false;
                        let mut v6: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                        let mut v7: Rc<UH0> = pass_91(v0, v1.clone(), v6.clone());
                        (v0, v1) = (v5, v7.clone());
                        continue;
                    }
                }
            }
            UH0::UH0_Nil => {
                let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                return v2.clone();
            }
        }
    }
}
fn closure52() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_strings / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method86(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<UH0>, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32) -> US13 {
    loop {
        let mut v8: bool = v3 >= v7;
        let mut v26: US12 = if v8 {
            let mut v9: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
            US12::US12_Error(v9.clone(), v3, v4, v5, v6, v7)
        } else {
            let mut v11: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v12: bool = v11 == b'\\';
            if v12 {
                let mut v13: i32 = v3.wrapping_add(1i32);
                let mut v14: bool = b'\n' == v11;
                let (mut v18, mut v19, mut v20, mut v21): (i32, i32, i32, i32) = if v14 {
                    let v15: i32 = v4.wrapping_add(v6);
                    let mut v16: i32 = v5.wrapping_add(1i32);
                    (v15, v16, 1i32, v7)
                } else {
                    let mut v17: i32 = v6.wrapping_add(1i32);
                    (v4, v5, v17, v7)
                };
                US12::US12_Ok(b'\\', v13, v18, v19, v20, v21)
            } else {
                let v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                US12::US12_Error(v23.clone(), v3, v4, v5, v6, v7)
            }
        };
        let v60: US12 = match &v26 {
            US12::US12_Error(v52, v53, v54, v55, v56, v57) => {
                let mut v52: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v52.clone();
                let v53: i32 = *v53;
                let v54: i32 = *v54;
                let v55: i32 = *v55;
                let v56: i32 = *v56;
                let mut v57: i32 = *v57;
                US12::US12_Error(v52.clone(), v53, v54, v55, v56, v57)
            }
            US12::US12_Ok(v27, v28, v29, v30, v31, v32) => {
                let mut v27: u8 = *v27;
                let mut v28: i32 = *v28;
                let mut v29: i32 = *v29;
                let v30: i32 = *v30;
                let mut v31: i32 = *v31;
                let mut v32: i32 = *v32;
                let mut v33: bool = v28 >= v32;
                if v33 {
                    let mut v34: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                    US12::US12_Error(v34.clone(), v28, v29, v30, v31, v32)
                } else {
                    let v36: u8 = v0.clone().as_bytes()[v28 as usize];
                    let v37: bool = v36 == b'"';
                    if v37 {
                        let mut v38: i32 = v28.wrapping_add(1i32);
                        let v39: bool = b'\n' == v36;
                        let (mut v43, mut v44, mut v45, mut v46): (i32, i32, i32, i32) = if v39 {
                            let v40: i32 = v29.wrapping_add(v31);
                            let v41: i32 = v30.wrapping_add(1i32);
                            (v40, v41, 1i32, v32)
                        } else {
                            let v42: i32 = v31.wrapping_add(1i32);
                            (v29, v30, v42, v32)
                        };
                        US12::US12_Ok(b'"', v38, v43, v44, v45, v46)
                    } else {
                        let mut v48: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                        US12::US12_Error(v48.clone(), v28, v29, v30, v31, v32)
                    }
                }
            }
        };
        let mut v76: US12 = match &v60 {
            US12::US12_Error(v68, v69, v70, v71, v72, v73) => {
                let mut v68: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v68.clone();
                let v69: i32 = *v69;
                let mut v70: i32 = *v70;
                let v71: i32 = *v71;
                let v72: i32 = *v72;
                let mut v73: i32 = *v73;
                US12::US12_Error(v68.clone(), v69, v70, v71, v72, v73)
            }
            US12::US12_Ok(v61, v62, v63, v64, v65, v66) => {
                let v61: u8 = *v61;
                let v62: i32 = *v62;
                let mut v63: i32 = *v63;
                let v64: i32 = *v64;
                let mut v65: i32 = *v65;
                let v66: i32 = *v66;
                US12::US12_Ok(b'"', v62, v63, v64, v65, v66)
            }
        };
        let v174: US12 = match &v76 {
            US12::US12_Error(v83, v84, v85, v86, v87, v88) => {
                let mut v83: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v83.clone();
                let mut v84: i32 = *v84;
                let mut v85: i32 = *v85;
                let mut v86: i32 = *v86;
                let mut v87: i32 = *v87;
                let mut v88: i32 = *v88;
                let v106: US12 = if v8 {
                    let v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                    US12::US12_Error(v89.clone(), v3, v4, v5, v6, v7)
                } else {
                    let v91: u8 = v0.clone().as_bytes()[v3 as usize];
                    let v92: bool = v91 == b'`';
                    if v92 {
                        let mut v93: i32 = v3.wrapping_add(1i32);
                        let v94: bool = b'\n' == v91;
                        let (mut v98, mut v99, mut v100, mut v101): (i32, i32, i32, i32) = if v94 {
                            let v95: i32 = v4.wrapping_add(v6);
                            let v96: i32 = v5.wrapping_add(1i32);
                            (v95, v96, 1i32, v7)
                        } else {
                            let v97: i32 = v6.wrapping_add(1i32);
                            (v4, v5, v97, v7)
                        };
                        US12::US12_Ok(b'`', v93, v98, v99, v100, v101)
                    } else {
                        let v103: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                        US12::US12_Error(v103.clone(), v3, v4, v5, v6, v7)
                    }
                };
                let v140: US12 = match &v106 {
                    US12::US12_Error(v132, v133, v134, v135, v136, v137) => {
                        let v132: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v132.clone();
                        let v133: i32 = *v133;
                        let v134: i32 = *v134;
                        let v135: i32 = *v135;
                        let v136: i32 = *v136;
                        let v137: i32 = *v137;
                        US12::US12_Error(v132.clone(), v133, v134, v135, v136, v137)
                    }
                    US12::US12_Ok(v107, v108, v109, v110, v111, v112) => {
                        let v107: u8 = *v107;
                        let mut v108: i32 = *v108;
                        let mut v109: i32 = *v109;
                        let mut v110: i32 = *v110;
                        let v111: i32 = *v111;
                        let mut v112: i32 = *v112;
                        let mut v113: bool = v108 >= v112;
                        if v113 {
                            let v114: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                            US12::US12_Error(v114.clone(), v108, v109, v110, v111, v112)
                        } else {
                            let mut v116: u8 = v0.clone().as_bytes()[v108 as usize];
                            let v117: bool = v116 == b'"';
                            if v117 {
                                let v118: i32 = v108.wrapping_add(1i32);
                                let mut v119: bool = b'\n' == v116;
                                let (mut v123, mut v124, mut v125, mut v126): (i32, i32, i32, i32) = if v119 {
                                    let v120: i32 = v109.wrapping_add(v111);
                                    let mut v121: i32 = v110.wrapping_add(1i32);
                                    (v120, v121, 1i32, v112)
                                } else {
                                    let mut v122: i32 = v111.wrapping_add(1i32);
                                    (v109, v110, v122, v112)
                                };
                                US12::US12_Ok(b'"', v118, v123, v124, v125, v126)
                            } else {
                                let v128: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                US12::US12_Error(v128.clone(), v108, v109, v110, v111, v112)
                            }
                        }
                    }
                };
                let v156: US12 = match &v140 {
                    US12::US12_Error(v148, v149, v150, v151, v152, v153) => {
                        let mut v148: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v148.clone();
                        let v149: i32 = *v149;
                        let mut v150: i32 = *v150;
                        let mut v151: i32 = *v151;
                        let mut v152: i32 = *v152;
                        let v153: i32 = *v153;
                        US12::US12_Error(v148.clone(), v149, v150, v151, v152, v153)
                    }
                    US12::US12_Ok(v141, v142, v143, v144, v145, v146) => {
                        let v141: u8 = *v141;
                        let v142: i32 = *v142;
                        let v143: i32 = *v143;
                        let v144: i32 = *v144;
                        let v145: i32 = *v145;
                        let v146: i32 = *v146;
                        US12::US12_Ok(b'"', v142, v143, v144, v145, v146)
                    }
                };
                match &v156 {
                    US12::US12_Error(v163, v164, v165, v166, v167, v168) => {
                        let mut v163: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v163.clone();
                        let mut v164: i32 = *v164;
                        let mut v165: i32 = *v165;
                        let mut v166: i32 = *v166;
                        let mut v167: i32 = *v167;
                        let mut v168: i32 = *v168;
                        let v169: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                        US12::US12_Error(v169.clone(), v3, v4, v5, v6, v7)
                    }
                    US12::US12_Ok(v157, v158, v159, v160, v161, v162) => {
                        let v157: u8 = *v157;
                        let v158: i32 = *v158;
                        let mut v159: i32 = *v159;
                        let v160: i32 = *v160;
                        let mut v161: i32 = *v161;
                        let mut v162: i32 = *v162;
                        v156.clone()
                    }
                }
            }
            US12::US12_Ok(v77, v78, v79, v80, v81, v82) => {
                let mut v77: u8 = *v77;
                let v78: i32 = *v78;
                let mut v79: i32 = *v79;
                let mut v80: i32 = *v80;
                let mut v81: i32 = *v81;
                let mut v82: i32 = *v82;
                v76.clone()
            }
        };
        let v806: US13 = match &v174 {
            US12::US12_Error(v798, v799, v800, v801, v802, v803) => {
                let v798: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v798.clone();
                let v799: i32 = *v799;
                let v800: i32 = *v800;
                let v801: i32 = *v801;
                let v802: i32 = *v802;
                let v803: i32 = *v803;
                US13::US13_Error(v798.clone(), v799, v800, v801, v802, v803)
            }
            US12::US12_Ok(v175, v176, v177, v178, v179, v180) => {
                let mut v175: u8 = *v175;
                let v176: i32 = *v176;
                let v177: i32 = *v177;
                let mut v178: i32 = *v178;
                let v179: i32 = *v179;
                let v180: i32 = *v180;
                let (mut v181, mut v182, mut v183, mut v184, mut v185): (i32, i32, i32, i32, i32) = method80(v177, v178, v179, v180, v0.clone(), v176, v177, v178, v179, v180);
                let v186: bool = v181 > v176;
                let v196: US13 = if v186 {
                    let v187: bool = v176 >= v181;
                    let v192: Rc<str> = if v187 {
                        let v188: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v188.clone()
                    } else {
                        let mut v190: i32 = v181.wrapping_sub(1i32);
                        let v191: Rc<str> = string_slice(&v0.clone(), v176 as i64, v190 as i64);
                        v191.clone()
                    };
                    US13::US13_Ok(v192.clone(), v181, v182, v183, v184, v185)
                } else {
                    let v194: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                    US13::US13_Error(v194.clone(), v176, v177, v178, v179, v180)
                };
                let mut v391: US13 = match &v196 {
                    US13::US13_Error(v203, v204, v205, v206, v207, v208) => {
                        let v203: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v203.clone();
                        let v204: i32 = *v204;
                        let v205: i32 = *v205;
                        let v206: i32 = *v206;
                        let v207: i32 = *v207;
                        let v208: i32 = *v208;
                        let v209: bool = v176 >= v180;
                        let mut v227: US12 = if v209 {
                            let v210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                            US12::US12_Error(v210.clone(), v176, v177, v178, v179, v180)
                        } else {
                            let v212: u8 = v0.clone().as_bytes()[v176 as usize];
                            let v213: bool = v212 == b'\\';
                            if v213 {
                                let v214: i32 = v176.wrapping_add(1i32);
                                let v215: bool = b'\n' == v212;
                                let (mut v219, mut v220, mut v221, mut v222): (i32, i32, i32, i32) = if v215 {
                                    let v216: i32 = v177.wrapping_add(v179);
                                    let mut v217: i32 = v178.wrapping_add(1i32);
                                    (v216, v217, 1i32, v180)
                                } else {
                                    let mut v218: i32 = v179.wrapping_add(1i32);
                                    (v177, v178, v218, v180)
                                };
                                US12::US12_Ok(b'\\', v214, v219, v220, v221, v222)
                            } else {
                                let v224: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                US12::US12_Error(v224.clone(), v176, v177, v178, v179, v180)
                            }
                        };
                        let mut v262: US12 = match &v227 {
                            US12::US12_Error(v254, v255, v256, v257, v258, v259) => {
                                let v254: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v254.clone();
                                let v255: i32 = *v255;
                                let v256: i32 = *v256;
                                let mut v257: i32 = *v257;
                                let v258: i32 = *v258;
                                let v259: i32 = *v259;
                                US12::US12_Error(v254.clone(), v255, v256, v257, v258, v259)
                            }
                            US12::US12_Ok(v228, v229, v230, v231, v232, v233) => {
                                let v228: u8 = *v228;
                                let v229: i32 = *v229;
                                let mut v230: i32 = *v230;
                                let mut v231: i32 = *v231;
                                let mut v232: i32 = *v232;
                                let v233: i32 = *v233;
                                let v234: bool = v229 >= v233;
                                if v234 {
                                    let mut v235: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                                    US12::US12_Error(v235.clone(), v229, v230, v231, v232, v233)
                                } else {
                                    let v237: u8 = v0.clone().as_bytes()[v229 as usize];
                                    let v238: bool = v237 == b'"';
                                    let v239: bool = v238 == false;
                                    if v239 {
                                        let v240: i32 = v229.wrapping_add(1i32);
                                        let v241: bool = b'\n' == v237;
                                        let (mut v245, mut v246, mut v247, mut v248): (i32, i32, i32, i32) = if v241 {
                                            let v242: i32 = v230.wrapping_add(v232);
                                            let v243: i32 = v231.wrapping_add(1i32);
                                            (v242, v243, 1i32, v233)
                                        } else {
                                            let v244: i32 = v232.wrapping_add(1i32);
                                            (v230, v231, v244, v233)
                                        };
                                        US12::US12_Ok(v237, v240, v245, v246, v247, v248)
                                    } else {
                                        let mut v250: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                        US12::US12_Error(v250.clone(), v229, v230, v231, v232, v233)
                                    }
                                }
                            }
                        };
                        let v284: US13 = match &v262 {
                            US12::US12_Error(v276, v277, v278, v279, v280, v281) => {
                                let v276: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v276.clone();
                                let v277: i32 = *v277;
                                let v278: i32 = *v278;
                                let v279: i32 = *v279;
                                let v280: i32 = *v280;
                                let v281: i32 = *v281;
                                US13::US13_Error(v276.clone(), v277, v278, v279, v280, v281)
                            }
                            US12::US12_Ok(v263, v264, v265, v266, v267, v268) => {
                                let v263: u8 = *v263;
                                let v264: i32 = *v264;
                                let v265: i32 = *v265;
                                let v266: i32 = *v266;
                                let v267: i32 = *v267;
                                let v268: i32 = *v268;
                                let v269: bool = v176 >= v264;
                                let mut v274: Rc<str> = if v269 {
                                    let v270: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v270.clone()
                                } else {
                                    let v272: i32 = v264.wrapping_sub(1i32);
                                    let v273: Rc<str> = string_slice(&v0.clone(), v176 as i64, v272 as i64);
                                    v273.clone()
                                };
                                US13::US13_Ok(v274.clone(), v264, v265, v266, v267, v268)
                            }
                        };
                        match &v284 {
                            US13::US13_Error(v291, v292, v293, v294, v295, v296) => {
                                let mut v291: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v291.clone();
                                let v292: i32 = *v292;
                                let v293: i32 = *v293;
                                let mut v294: i32 = *v294;
                                let v295: i32 = *v295;
                                let v296: i32 = *v296;
                                let v314: US12 = if v209 {
                                    let v297: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                    US12::US12_Error(v297.clone(), v176, v177, v178, v179, v180)
                                } else {
                                    let v299: u8 = v0.clone().as_bytes()[v176 as usize];
                                    let v300: bool = v299 == b'`';
                                    if v300 {
                                        let v301: i32 = v176.wrapping_add(1i32);
                                        let v302: bool = b'\n' == v299;
                                        let (mut v306, mut v307, mut v308, mut v309): (i32, i32, i32, i32) = if v302 {
                                            let v303: i32 = v177.wrapping_add(v179);
                                            let v304: i32 = v178.wrapping_add(1i32);
                                            (v303, v304, 1i32, v180)
                                        } else {
                                            let v305: i32 = v179.wrapping_add(1i32);
                                            (v177, v178, v305, v180)
                                        };
                                        US12::US12_Ok(b'`', v301, v306, v307, v308, v309)
                                    } else {
                                        let v311: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                        US12::US12_Error(v311.clone(), v176, v177, v178, v179, v180)
                                    }
                                };
                                let v349: US12 = match &v314 {
                                    US12::US12_Error(v341, v342, v343, v344, v345, v346) => {
                                        let v341: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v341.clone();
                                        let v342: i32 = *v342;
                                        let v343: i32 = *v343;
                                        let v344: i32 = *v344;
                                        let v345: i32 = *v345;
                                        let v346: i32 = *v346;
                                        US12::US12_Error(v341.clone(), v342, v343, v344, v345, v346)
                                    }
                                    US12::US12_Ok(v315, v316, v317, v318, v319, v320) => {
                                        let v315: u8 = *v315;
                                        let v316: i32 = *v316;
                                        let v317: i32 = *v317;
                                        let mut v318: i32 = *v318;
                                        let v319: i32 = *v319;
                                        let v320: i32 = *v320;
                                        let v321: bool = v316 >= v320;
                                        if v321 {
                                            let mut v322: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                                            US12::US12_Error(v322.clone(), v316, v317, v318, v319, v320)
                                        } else {
                                            let v324: u8 = v0.clone().as_bytes()[v316 as usize];
                                            let v325: bool = v324 == b'"';
                                            let v326: bool = v325 == false;
                                            if v326 {
                                                let v327: i32 = v316.wrapping_add(1i32);
                                                let v328: bool = b'\n' == v324;
                                                let (mut v332, mut v333, mut v334, mut v335): (i32, i32, i32, i32) = if v328 {
                                                    let mut v329: i32 = v317.wrapping_add(v319);
                                                    let v330: i32 = v318.wrapping_add(1i32);
                                                    (v329, v330, 1i32, v320)
                                                } else {
                                                    let v331: i32 = v319.wrapping_add(1i32);
                                                    (v317, v318, v331, v320)
                                                };
                                                US12::US12_Ok(v324, v327, v332, v333, v334, v335)
                                            } else {
                                                let v337: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                US12::US12_Error(v337.clone(), v316, v317, v318, v319, v320)
                                            }
                                        }
                                    }
                                };
                                let v371: US13 = match &v349 {
                                    US12::US12_Error(v363, v364, v365, v366, v367, v368) => {
                                        let v363: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v363.clone();
                                        let v364: i32 = *v364;
                                        let v365: i32 = *v365;
                                        let v366: i32 = *v366;
                                        let v367: i32 = *v367;
                                        let v368: i32 = *v368;
                                        US13::US13_Error(v363.clone(), v364, v365, v366, v367, v368)
                                    }
                                    US12::US12_Ok(v350, v351, v352, v353, v354, v355) => {
                                        let v350: u8 = *v350;
                                        let v351: i32 = *v351;
                                        let v352: i32 = *v352;
                                        let v353: i32 = *v353;
                                        let v354: i32 = *v354;
                                        let v355: i32 = *v355;
                                        let v356: bool = v176 >= v351;
                                        let v361: Rc<str> = if v356 {
                                            let v357: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            v357.clone()
                                        } else {
                                            let mut v359: i32 = v351.wrapping_sub(1i32);
                                            let v360: Rc<str> = string_slice(&v0.clone(), v176 as i64, v359 as i64);
                                            v360.clone()
                                        };
                                        US13::US13_Ok(v361.clone(), v351, v352, v353, v354, v355)
                                    }
                                };
                                match &v371 {
                                    US13::US13_Error(v378, v379, v380, v381, v382, v383) => {
                                        let v378: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v378.clone();
                                        let v379: i32 = *v379;
                                        let v380: i32 = *v380;
                                        let v381: i32 = *v381;
                                        let v382: i32 = *v382;
                                        let v383: i32 = *v383;
                                        let v384: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                        US13::US13_Error(v384.clone(), v176, v177, v178, v179, v180)
                                    }
                                    US13::US13_Ok(v372, v373, v374, v375, v376, v377) => {
                                        let v372: Rc<str> = v372.clone();
                                        let v373: i32 = *v373;
                                        let v374: i32 = *v374;
                                        let v375: i32 = *v375;
                                        let v376: i32 = *v376;
                                        let v377: i32 = *v377;
                                        v371.clone()
                                    }
                                }
                            }
                            US13::US13_Ok(v285, v286, v287, v288, v289, v290) => {
                                let v285: Rc<str> = v285.clone();
                                let v286: i32 = *v286;
                                let mut v287: i32 = *v287;
                                let v288: i32 = *v288;
                                let v289: i32 = *v289;
                                let mut v290: i32 = *v290;
                                v284.clone()
                            }
                        }
                    }
                    US13::US13_Ok(v197, v198, v199, v200, v201, v202) => {
                        let v197: Rc<str> = v197.clone();
                        let v198: i32 = *v198;
                        let v199: i32 = *v199;
                        let v200: i32 = *v200;
                        let mut v201: i32 = *v201;
                        let v202: i32 = *v202;
                        v196.clone()
                    }
                };
                let v414: US13 = match &v391 {
                    US13::US13_Error(v392, v393, v394, v395, v396, v397) => {
                        let v392: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v392.clone();
                        let v393: i32 = *v393;
                        let mut v394: i32 = *v394;
                        let v395: i32 = *v395;
                        let v396: i32 = *v396;
                        let v397: i32 = *v397;
                        let v398: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        US13::US13_Ok(v398.clone(), v176, v177, v178, v179, v180)
                    }
                    US13::US13_Ok(v400, v401, v402, v403, v404, v405) => {
                        let v400: Rc<str> = v400.clone();
                        let v401: i32 = *v401;
                        let v402: i32 = *v402;
                        let v403: i32 = *v403;
                        let v404: i32 = *v404;
                        let v405: i32 = *v405;
                        let v406: bool = v401 == v176;
                        if v406 {
                            let v407: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure45();
                            US13::US13_Error(v407.clone(), v176, v177, v178, v179, v180)
                        } else {
                            let v409: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                            let v410: i32 = 0i32;
                            method81(v0.clone(), v409.clone(), v409.clone(), v400.clone(), v410, v401, v402, v403, v404, v405)
                        }
                    }
                };
                match &v414 {
                    US13::US13_Error(v605, v606, v607, v608, v609, v610) => {
                        let mut v605: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v605.clone();
                        let v606: i32 = *v606;
                        let v607: i32 = *v607;
                        let v608: i32 = *v608;
                        let v609: i32 = *v609;
                        let v610: i32 = *v610;
                        let v611: bool = v176 >= v180;
                        let v629: US12 = if v611 {
                            let v612: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                            US12::US12_Error(v612.clone(), v176, v177, v178, v179, v180)
                        } else {
                            let v614: u8 = v0.clone().as_bytes()[v176 as usize];
                            let v615: bool = v614 == b'\\';
                            if v615 {
                                let v616: i32 = v176.wrapping_add(1i32);
                                let v617: bool = b'\n' == v614;
                                let (mut v621, mut v622, mut v623, mut v624): (i32, i32, i32, i32) = if v617 {
                                    let v618: i32 = v177.wrapping_add(v179);
                                    let v619: i32 = v178.wrapping_add(1i32);
                                    (v618, v619, 1i32, v180)
                                } else {
                                    let v620: i32 = v179.wrapping_add(1i32);
                                    (v177, v178, v620, v180)
                                };
                                US12::US12_Ok(b'\\', v616, v621, v622, v623, v624)
                            } else {
                                let v626: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                US12::US12_Error(v626.clone(), v176, v177, v178, v179, v180)
                            }
                        };
                        let v663: US12 = match &v629 {
                            US12::US12_Error(v655, v656, v657, v658, v659, v660) => {
                                let v655: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v655.clone();
                                let v656: i32 = *v656;
                                let mut v657: i32 = *v657;
                                let v658: i32 = *v658;
                                let v659: i32 = *v659;
                                let v660: i32 = *v660;
                                US12::US12_Error(v655.clone(), v656, v657, v658, v659, v660)
                            }
                            US12::US12_Ok(v630, v631, v632, v633, v634, v635) => {
                                let v630: u8 = *v630;
                                let v631: i32 = *v631;
                                let v632: i32 = *v632;
                                let v633: i32 = *v633;
                                let v634: i32 = *v634;
                                let v635: i32 = *v635;
                                let v636: bool = v631 >= v635;
                                if v636 {
                                    let v637: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                    US12::US12_Error(v637.clone(), v631, v632, v633, v634, v635)
                                } else {
                                    let v639: u8 = v0.clone().as_bytes()[v631 as usize];
                                    let v640: bool = v639 == b'"';
                                    if v640 {
                                        let v641: i32 = v631.wrapping_add(1i32);
                                        let v642: bool = b'\n' == v639;
                                        let (mut v646, mut v647, mut v648, mut v649): (i32, i32, i32, i32) = if v642 {
                                            let v643: i32 = v632.wrapping_add(v634);
                                            let v644: i32 = v633.wrapping_add(1i32);
                                            (v643, v644, 1i32, v635)
                                        } else {
                                            let v645: i32 = v634.wrapping_add(1i32);
                                            (v632, v633, v645, v635)
                                        };
                                        US12::US12_Ok(b'"', v641, v646, v647, v648, v649)
                                    } else {
                                        let v651: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                        US12::US12_Error(v651.clone(), v631, v632, v633, v634, v635)
                                    }
                                }
                            }
                        };
                        let v679: US12 = match &v663 {
                            US12::US12_Error(v671, v672, v673, v674, v675, v676) => {
                                let v671: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v671.clone();
                                let v672: i32 = *v672;
                                let v673: i32 = *v673;
                                let v674: i32 = *v674;
                                let v675: i32 = *v675;
                                let v676: i32 = *v676;
                                US12::US12_Error(v671.clone(), v672, v673, v674, v675, v676)
                            }
                            US12::US12_Ok(v664, v665, v666, v667, v668, v669) => {
                                let v664: u8 = *v664;
                                let v665: i32 = *v665;
                                let v666: i32 = *v666;
                                let v667: i32 = *v667;
                                let v668: i32 = *v668;
                                let v669: i32 = *v669;
                                US12::US12_Ok(b'"', v665, v666, v667, v668, v669)
                            }
                        };
                        let v777: US12 = match &v679 {
                            US12::US12_Error(v686, v687, v688, v689, v690, v691) => {
                                let v686: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v686.clone();
                                let v687: i32 = *v687;
                                let v688: i32 = *v688;
                                let v689: i32 = *v689;
                                let v690: i32 = *v690;
                                let v691: i32 = *v691;
                                let v709: US12 = if v611 {
                                    let v692: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                    US12::US12_Error(v692.clone(), v176, v177, v178, v179, v180)
                                } else {
                                    let v694: u8 = v0.clone().as_bytes()[v176 as usize];
                                    let v695: bool = v694 == b'`';
                                    if v695 {
                                        let v696: i32 = v176.wrapping_add(1i32);
                                        let v697: bool = b'\n' == v694;
                                        let (mut v701, mut v702, mut v703, mut v704): (i32, i32, i32, i32) = if v697 {
                                            let v698: i32 = v177.wrapping_add(v179);
                                            let v699: i32 = v178.wrapping_add(1i32);
                                            (v698, v699, 1i32, v180)
                                        } else {
                                            let v700: i32 = v179.wrapping_add(1i32);
                                            (v177, v178, v700, v180)
                                        };
                                        US12::US12_Ok(b'`', v696, v701, v702, v703, v704)
                                    } else {
                                        let v706: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                        US12::US12_Error(v706.clone(), v176, v177, v178, v179, v180)
                                    }
                                };
                                let v743: US12 = match &v709 {
                                    US12::US12_Error(v735, v736, v737, v738, v739, v740) => {
                                        let v735: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v735.clone();
                                        let mut v736: i32 = *v736;
                                        let v737: i32 = *v737;
                                        let v738: i32 = *v738;
                                        let v739: i32 = *v739;
                                        let v740: i32 = *v740;
                                        US12::US12_Error(v735.clone(), v736, v737, v738, v739, v740)
                                    }
                                    US12::US12_Ok(v710, v711, v712, v713, v714, v715) => {
                                        let v710: u8 = *v710;
                                        let v711: i32 = *v711;
                                        let v712: i32 = *v712;
                                        let v713: i32 = *v713;
                                        let v714: i32 = *v714;
                                        let v715: i32 = *v715;
                                        let v716: bool = v711 >= v715;
                                        if v716 {
                                            let v717: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                            US12::US12_Error(v717.clone(), v711, v712, v713, v714, v715)
                                        } else {
                                            let v719: u8 = v0.clone().as_bytes()[v711 as usize];
                                            let v720: bool = v719 == b'"';
                                            if v720 {
                                                let v721: i32 = v711.wrapping_add(1i32);
                                                let v722: bool = b'\n' == v719;
                                                let (mut v726, mut v727, mut v728, mut v729): (i32, i32, i32, i32) = if v722 {
                                                    let v723: i32 = v712.wrapping_add(v714);
                                                    let v724: i32 = v713.wrapping_add(1i32);
                                                    (v723, v724, 1i32, v715)
                                                } else {
                                                    let v725: i32 = v714.wrapping_add(1i32);
                                                    (v712, v713, v725, v715)
                                                };
                                                US12::US12_Ok(b'"', v721, v726, v727, v728, v729)
                                            } else {
                                                let v731: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                                US12::US12_Error(v731.clone(), v711, v712, v713, v714, v715)
                                            }
                                        }
                                    }
                                };
                                let v759: US12 = match &v743 {
                                    US12::US12_Error(v751, v752, v753, v754, v755, v756) => {
                                        let v751: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v751.clone();
                                        let v752: i32 = *v752;
                                        let v753: i32 = *v753;
                                        let v754: i32 = *v754;
                                        let v755: i32 = *v755;
                                        let v756: i32 = *v756;
                                        US12::US12_Error(v751.clone(), v752, v753, v754, v755, v756)
                                    }
                                    US12::US12_Ok(v744, v745, v746, v747, v748, v749) => {
                                        let v744: u8 = *v744;
                                        let v745: i32 = *v745;
                                        let v746: i32 = *v746;
                                        let v747: i32 = *v747;
                                        let v748: i32 = *v748;
                                        let v749: i32 = *v749;
                                        US12::US12_Ok(b'"', v745, v746, v747, v748, v749)
                                    }
                                };
                                match &v759 {
                                    US12::US12_Error(v766, v767, v768, v769, v770, v771) => {
                                        let v766: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v766.clone();
                                        let v767: i32 = *v767;
                                        let v768: i32 = *v768;
                                        let v769: i32 = *v769;
                                        let v770: i32 = *v770;
                                        let v771: i32 = *v771;
                                        let v772: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                        US12::US12_Error(v772.clone(), v176, v177, v178, v179, v180)
                                    }
                                    US12::US12_Ok(v760, v761, v762, v763, v764, v765) => {
                                        let v760: u8 = *v760;
                                        let v761: i32 = *v761;
                                        let v762: i32 = *v762;
                                        let v763: i32 = *v763;
                                        let mut v764: i32 = *v764;
                                        let v765: i32 = *v765;
                                        v759.clone()
                                    }
                                }
                            }
                            US12::US12_Ok(v680, v681, v682, v683, v684, v685) => {
                                let v680: u8 = *v680;
                                let v681: i32 = *v681;
                                let v682: i32 = *v682;
                                let v683: i32 = *v683;
                                let v684: i32 = *v684;
                                let mut v685: i32 = *v685;
                                v679.clone()
                            }
                        };
                        match &v777 {
                            US12::US12_Error(v786, v787, v788, v789, v790, v791) => {
                                let v786: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v786.clone();
                                let v787: i32 = *v787;
                                let v788: i32 = *v788;
                                let v789: i32 = *v789;
                                let v790: i32 = *v790;
                                let v791: i32 = *v791;
                                let v792: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                                US13::US13_Error(v792.clone(), v176, v177, v178, v179, v180)
                            }
                            US12::US12_Ok(v778, v779, v780, v781, v782, v783) => {
                                let v778: u8 = *v778;
                                let v779: i32 = *v779;
                                let v780: i32 = *v780;
                                let v781: i32 = *v781;
                                let v782: i32 = *v782;
                                let v783: i32 = *v783;
                                let v784: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                US13::US13_Ok(v784.clone(), v779, v780, v781, v782, v783)
                            }
                        }
                    }
                    US13::US13_Ok(v415, v416, v417, v418, v419, v420) => {
                        let v415: Rc<str> = v415.clone();
                        let v416: i32 = *v416;
                        let v417: i32 = *v417;
                        let v418: i32 = *v418;
                        let v419: i32 = *v419;
                        let v420: i32 = *v420;
                        let v421: bool = v416 >= v420;
                        let v439: US12 = if v421 {
                            let mut v422: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                            US12::US12_Error(v422.clone(), v416, v417, v418, v419, v420)
                        } else {
                            let v424: u8 = v0.clone().as_bytes()[v416 as usize];
                            let v425: bool = v424 == b'\\';
                            if v425 {
                                let v426: i32 = v416.wrapping_add(1i32);
                                let v427: bool = b'\n' == v424;
                                let (mut v431, mut v432, mut v433, mut v434): (i32, i32, i32, i32) = if v427 {
                                    let v428: i32 = v417.wrapping_add(v419);
                                    let v429: i32 = v418.wrapping_add(1i32);
                                    (v428, v429, 1i32, v420)
                                } else {
                                    let v430: i32 = v419.wrapping_add(1i32);
                                    (v417, v418, v430, v420)
                                };
                                US12::US12_Ok(b'\\', v426, v431, v432, v433, v434)
                            } else {
                                let v436: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                US12::US12_Error(v436.clone(), v416, v417, v418, v419, v420)
                            }
                        };
                        let v473: US12 = match &v439 {
                            US12::US12_Error(v465, v466, v467, v468, v469, v470) => {
                                let v465: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v465.clone();
                                let v466: i32 = *v466;
                                let v467: i32 = *v467;
                                let v468: i32 = *v468;
                                let v469: i32 = *v469;
                                let v470: i32 = *v470;
                                US12::US12_Error(v465.clone(), v466, v467, v468, v469, v470)
                            }
                            US12::US12_Ok(v440, v441, v442, v443, v444, v445) => {
                                let v440: u8 = *v440;
                                let v441: i32 = *v441;
                                let v442: i32 = *v442;
                                let v443: i32 = *v443;
                                let v444: i32 = *v444;
                                let v445: i32 = *v445;
                                let v446: bool = v441 >= v445;
                                if v446 {
                                    let v447: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                    US12::US12_Error(v447.clone(), v441, v442, v443, v444, v445)
                                } else {
                                    let v449: u8 = v0.clone().as_bytes()[v441 as usize];
                                    let v450: bool = v449 == b'"';
                                    if v450 {
                                        let v451: i32 = v441.wrapping_add(1i32);
                                        let v452: bool = b'\n' == v449;
                                        let (mut v456, mut v457, mut v458, mut v459): (i32, i32, i32, i32) = if v452 {
                                            let v453: i32 = v442.wrapping_add(v444);
                                            let v454: i32 = v443.wrapping_add(1i32);
                                            (v453, v454, 1i32, v445)
                                        } else {
                                            let v455: i32 = v444.wrapping_add(1i32);
                                            (v442, v443, v455, v445)
                                        };
                                        US12::US12_Ok(b'"', v451, v456, v457, v458, v459)
                                    } else {
                                        let v461: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                        US12::US12_Error(v461.clone(), v441, v442, v443, v444, v445)
                                    }
                                }
                            }
                        };
                        let v489: US12 = match &v473 {
                            US12::US12_Error(v481, v482, v483, v484, v485, v486) => {
                                let v481: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v481.clone();
                                let v482: i32 = *v482;
                                let v483: i32 = *v483;
                                let v484: i32 = *v484;
                                let v485: i32 = *v485;
                                let v486: i32 = *v486;
                                US12::US12_Error(v481.clone(), v482, v483, v484, v485, v486)
                            }
                            US12::US12_Ok(v474, v475, v476, v477, v478, v479) => {
                                let v474: u8 = *v474;
                                let v475: i32 = *v475;
                                let v476: i32 = *v476;
                                let v477: i32 = *v477;
                                let v478: i32 = *v478;
                                let v479: i32 = *v479;
                                US12::US12_Ok(b'"', v475, v476, v477, v478, v479)
                            }
                        };
                        let v587: US12 = match &v489 {
                            US12::US12_Error(v496, v497, v498, v499, v500, v501) => {
                                let v496: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v496.clone();
                                let v497: i32 = *v497;
                                let v498: i32 = *v498;
                                let v499: i32 = *v499;
                                let v500: i32 = *v500;
                                let v501: i32 = *v501;
                                let v519: US12 = if v421 {
                                    let v502: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                    US12::US12_Error(v502.clone(), v416, v417, v418, v419, v420)
                                } else {
                                    let v504: u8 = v0.clone().as_bytes()[v416 as usize];
                                    let v505: bool = v504 == b'`';
                                    if v505 {
                                        let v506: i32 = v416.wrapping_add(1i32);
                                        let v507: bool = b'\n' == v504;
                                        let (mut v511, mut v512, mut v513, mut v514): (i32, i32, i32, i32) = if v507 {
                                            let v508: i32 = v417.wrapping_add(v419);
                                            let v509: i32 = v418.wrapping_add(1i32);
                                            (v508, v509, 1i32, v420)
                                        } else {
                                            let v510: i32 = v419.wrapping_add(1i32);
                                            (v417, v418, v510, v420)
                                        };
                                        US12::US12_Ok(b'`', v506, v511, v512, v513, v514)
                                    } else {
                                        let v516: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                        US12::US12_Error(v516.clone(), v416, v417, v418, v419, v420)
                                    }
                                };
                                let v553: US12 = match &v519 {
                                    US12::US12_Error(v545, v546, v547, v548, v549, v550) => {
                                        let v545: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v545.clone();
                                        let v546: i32 = *v546;
                                        let v547: i32 = *v547;
                                        let v548: i32 = *v548;
                                        let v549: i32 = *v549;
                                        let v550: i32 = *v550;
                                        US12::US12_Error(v545.clone(), v546, v547, v548, v549, v550)
                                    }
                                    US12::US12_Ok(v520, v521, v522, v523, v524, v525) => {
                                        let v520: u8 = *v520;
                                        let v521: i32 = *v521;
                                        let v522: i32 = *v522;
                                        let mut v523: i32 = *v523;
                                        let v524: i32 = *v524;
                                        let v525: i32 = *v525;
                                        let v526: bool = v521 >= v525;
                                        if v526 {
                                            let v527: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                            US12::US12_Error(v527.clone(), v521, v522, v523, v524, v525)
                                        } else {
                                            let v529: u8 = v0.clone().as_bytes()[v521 as usize];
                                            let v530: bool = v529 == b'"';
                                            if v530 {
                                                let v531: i32 = v521.wrapping_add(1i32);
                                                let v532: bool = b'\n' == v529;
                                                let (mut v536, mut v537, mut v538, mut v539): (i32, i32, i32, i32) = if v532 {
                                                    let v533: i32 = v522.wrapping_add(v524);
                                                    let v534: i32 = v523.wrapping_add(1i32);
                                                    (v533, v534, 1i32, v525)
                                                } else {
                                                    let v535: i32 = v524.wrapping_add(1i32);
                                                    (v522, v523, v535, v525)
                                                };
                                                US12::US12_Ok(b'"', v531, v536, v537, v538, v539)
                                            } else {
                                                let v541: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                                US12::US12_Error(v541.clone(), v521, v522, v523, v524, v525)
                                            }
                                        }
                                    }
                                };
                                let v569: US12 = match &v553 {
                                    US12::US12_Error(v561, v562, v563, v564, v565, v566) => {
                                        let v561: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v561.clone();
                                        let v562: i32 = *v562;
                                        let v563: i32 = *v563;
                                        let v564: i32 = *v564;
                                        let v565: i32 = *v565;
                                        let v566: i32 = *v566;
                                        US12::US12_Error(v561.clone(), v562, v563, v564, v565, v566)
                                    }
                                    US12::US12_Ok(v554, v555, v556, v557, v558, v559) => {
                                        let v554: u8 = *v554;
                                        let v555: i32 = *v555;
                                        let v556: i32 = *v556;
                                        let v557: i32 = *v557;
                                        let v558: i32 = *v558;
                                        let v559: i32 = *v559;
                                        US12::US12_Ok(b'"', v555, v556, v557, v558, v559)
                                    }
                                };
                                match &v569 {
                                    US12::US12_Error(v576, v577, v578, v579, v580, v581) => {
                                        let v576: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v576.clone();
                                        let mut v577: i32 = *v577;
                                        let v578: i32 = *v578;
                                        let v579: i32 = *v579;
                                        let mut v580: i32 = *v580;
                                        let v581: i32 = *v581;
                                        let v582: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                        US12::US12_Error(v582.clone(), v416, v417, v418, v419, v420)
                                    }
                                    US12::US12_Ok(v570, v571, v572, v573, v574, v575) => {
                                        let v570: u8 = *v570;
                                        let mut v571: i32 = *v571;
                                        let mut v572: i32 = *v572;
                                        let v573: i32 = *v573;
                                        let mut v574: i32 = *v574;
                                        let v575: i32 = *v575;
                                        v569.clone()
                                    }
                                }
                            }
                            US12::US12_Ok(v490, v491, v492, v493, v494, v495) => {
                                let v490: u8 = *v490;
                                let v491: i32 = *v491;
                                let mut v492: i32 = *v492;
                                let v493: i32 = *v493;
                                let v494: i32 = *v494;
                                let mut v495: i32 = *v495;
                                v489.clone()
                            }
                        };
                        match &v587 {
                            US12::US12_Error(v595, v596, v597, v598, v599, v600) => {
                                let v595: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v595.clone();
                                let v596: i32 = *v596;
                                let v597: i32 = *v597;
                                let v598: i32 = *v598;
                                let v599: i32 = *v599;
                                let v600: i32 = *v600;
                                let v601: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28(v176, v416, v595.clone(), v596, v597, v598, v599, v600);
                                US13::US13_Error(v601.clone(), v416, v417, v418, v419, v420)
                            }
                            US12::US12_Ok(v588, v589, v590, v591, v592, v593) => {
                                let v588: u8 = *v588;
                                let v589: i32 = *v589;
                                let v590: i32 = *v590;
                                let v591: i32 = *v591;
                                let v592: i32 = *v592;
                                let v593: i32 = *v593;
                                US13::US13_Ok(v415.clone(), v589, v590, v591, v592, v593)
                            }
                        }
                    }
                }
            }
        };
        let v1164: US13 = match &v806 {
            US13::US13_Error(v813, v814, v815, v816, v817, v818) => {
                let v813: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v813.clone();
                let v814: i32 = *v814;
                let mut v815: i32 = *v815;
                let v816: i32 = *v816;
                let v817: i32 = *v817;
                let v818: i32 = *v818;
                let v836: US12 = if v8 {
                    let v819: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                    US12::US12_Error(v819.clone(), v3, v4, v5, v6, v7)
                } else {
                    let v821: u8 = v0.clone().as_bytes()[v3 as usize];
                    let v822: bool = v821 == b'"';
                    if v822 {
                        let v823: i32 = v3.wrapping_add(1i32);
                        let v824: bool = b'\n' == v821;
                        let (mut v828, mut v829, mut v830, mut v831): (i32, i32, i32, i32) = if v824 {
                            let v825: i32 = v4.wrapping_add(v6);
                            let v826: i32 = v5.wrapping_add(1i32);
                            (v825, v826, 1i32, v7)
                        } else {
                            let v827: i32 = v6.wrapping_add(1i32);
                            (v4, v5, v827, v7)
                        };
                        US12::US12_Ok(b'"', v823, v828, v829, v830, v831)
                    } else {
                        let v833: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                        US12::US12_Error(v833.clone(), v3, v4, v5, v6, v7)
                    }
                };
                match &v836 {
                    US12::US12_Error(v1154, v1155, v1156, v1157, v1158, v1159) => {
                        let v1154: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1154.clone();
                        let v1155: i32 = *v1155;
                        let v1156: i32 = *v1156;
                        let v1157: i32 = *v1157;
                        let v1158: i32 = *v1158;
                        let v1159: i32 = *v1159;
                        US13::US13_Error(v1154.clone(), v1155, v1156, v1157, v1158, v1159)
                    }
                    US12::US12_Ok(v837, v838, v839, v840, v841, v842) => {
                        let v837: u8 = *v837;
                        let v838: i32 = *v838;
                        let v839: i32 = *v839;
                        let v840: i32 = *v840;
                        let v841: i32 = *v841;
                        let v842: i32 = *v842;
                        let (mut v843, mut v844, mut v845, mut v846, mut v847): (i32, i32, i32, i32, i32) = method80(v839, v840, v841, v842, v0.clone(), v838, v839, v840, v841, v842);
                        let v848: bool = v843 > v838;
                        let v858: US13 = if v848 {
                            let v849: bool = v838 >= v843;
                            let v854: Rc<str> = if v849 {
                                let v850: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                v850.clone()
                            } else {
                                let v852: i32 = v843.wrapping_sub(1i32);
                                let v853: Rc<str> = string_slice(&v0.clone(), v838 as i64, v852 as i64);
                                v853.clone()
                            };
                            US13::US13_Ok(v854.clone(), v843, v844, v845, v846, v847)
                        } else {
                            let v856: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                            US13::US13_Error(v856.clone(), v838, v839, v840, v841, v842)
                        };
                        let v1043: US13 = match &v858 {
                            US13::US13_Error(v865, v866, v867, v868, v869, v870) => {
                                let v865: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v865.clone();
                                let v866: i32 = *v866;
                                let v867: i32 = *v867;
                                let v868: i32 = *v868;
                                let v869: i32 = *v869;
                                let v870: i32 = *v870;
                                let v871: bool = v838 >= v842;
                                let v889: US12 = if v871 {
                                    let v872: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US12::US12_Error(v872.clone(), v838, v839, v840, v841, v842)
                                } else {
                                    let v874: u8 = v0.clone().as_bytes()[v838 as usize];
                                    let v875: bool = v874 == b'\\';
                                    if v875 {
                                        let v876: i32 = v838.wrapping_add(1i32);
                                        let v877: bool = b'\n' == v874;
                                        let (mut v881, mut v882, mut v883, mut v884): (i32, i32, i32, i32) = if v877 {
                                            let v878: i32 = v839.wrapping_add(v841);
                                            let v879: i32 = v840.wrapping_add(1i32);
                                            (v878, v879, 1i32, v842)
                                        } else {
                                            let v880: i32 = v841.wrapping_add(1i32);
                                            (v839, v840, v880, v842)
                                        };
                                        US12::US12_Ok(b'\\', v876, v881, v882, v883, v884)
                                    } else {
                                        let v886: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                        US12::US12_Error(v886.clone(), v838, v839, v840, v841, v842)
                                    }
                                };
                                let v919: US12 = match &v889 {
                                    US12::US12_Error(v911, v912, v913, v914, v915, v916) => {
                                        let v911: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v911.clone();
                                        let v912: i32 = *v912;
                                        let v913: i32 = *v913;
                                        let v914: i32 = *v914;
                                        let v915: i32 = *v915;
                                        let v916: i32 = *v916;
                                        US12::US12_Error(v911.clone(), v912, v913, v914, v915, v916)
                                    }
                                    US12::US12_Ok(v890, v891, v892, v893, v894, v895) => {
                                        let v890: u8 = *v890;
                                        let mut v891: i32 = *v891;
                                        let v892: i32 = *v892;
                                        let v893: i32 = *v893;
                                        let mut v894: i32 = *v894;
                                        let v895: i32 = *v895;
                                        let v896: bool = v891 >= v895;
                                        if v896 {
                                            let v897: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                                            US12::US12_Error(v897.clone(), v891, v892, v893, v894, v895)
                                        } else {
                                            let v899: u8 = v0.clone().as_bytes()[v891 as usize];
                                            let v900: i32 = v891.wrapping_add(1i32);
                                            let v901: bool = b'\n' == v899;
                                            let (mut v905, mut v906, mut v907, mut v908): (i32, i32, i32, i32) = if v901 {
                                                let v902: i32 = v892.wrapping_add(v894);
                                                let v903: i32 = v893.wrapping_add(1i32);
                                                (v902, v903, 1i32, v895)
                                            } else {
                                                let v904: i32 = v894.wrapping_add(1i32);
                                                (v892, v893, v904, v895)
                                            };
                                            US12::US12_Ok(v899, v900, v905, v906, v907, v908)
                                        }
                                    }
                                };
                                let v941: US13 = match &v919 {
                                    US12::US12_Error(v933, v934, v935, v936, v937, v938) => {
                                        let v933: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v933.clone();
                                        let v934: i32 = *v934;
                                        let v935: i32 = *v935;
                                        let v936: i32 = *v936;
                                        let v937: i32 = *v937;
                                        let v938: i32 = *v938;
                                        US13::US13_Error(v933.clone(), v934, v935, v936, v937, v938)
                                    }
                                    US12::US12_Ok(v920, v921, v922, v923, v924, v925) => {
                                        let v920: u8 = *v920;
                                        let v921: i32 = *v921;
                                        let mut v922: i32 = *v922;
                                        let v923: i32 = *v923;
                                        let v924: i32 = *v924;
                                        let v925: i32 = *v925;
                                        let v926: bool = v838 >= v921;
                                        let v931: Rc<str> = if v926 {
                                            let v927: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            v927.clone()
                                        } else {
                                            let v929: i32 = v921.wrapping_sub(1i32);
                                            let v930: Rc<str> = string_slice(&v0.clone(), v838 as i64, v929 as i64);
                                            v930.clone()
                                        };
                                        US13::US13_Ok(v931.clone(), v921, v922, v923, v924, v925)
                                    }
                                };
                                match &v941 {
                                    US13::US13_Error(v948, v949, v950, v951, v952, v953) => {
                                        let v948: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v948.clone();
                                        let v949: i32 = *v949;
                                        let v950: i32 = *v950;
                                        let v951: i32 = *v951;
                                        let v952: i32 = *v952;
                                        let v953: i32 = *v953;
                                        let v971: US12 = if v871 {
                                            let v954: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                            US12::US12_Error(v954.clone(), v838, v839, v840, v841, v842)
                                        } else {
                                            let v956: u8 = v0.clone().as_bytes()[v838 as usize];
                                            let v957: bool = v956 == b'`';
                                            if v957 {
                                                let v958: i32 = v838.wrapping_add(1i32);
                                                let v959: bool = b'\n' == v956;
                                                let (mut v963, mut v964, mut v965, mut v966): (i32, i32, i32, i32) = if v959 {
                                                    let v960: i32 = v839.wrapping_add(v841);
                                                    let v961: i32 = v840.wrapping_add(1i32);
                                                    (v960, v961, 1i32, v842)
                                                } else {
                                                    let v962: i32 = v841.wrapping_add(1i32);
                                                    (v839, v840, v962, v842)
                                                };
                                                US12::US12_Ok(b'`', v958, v963, v964, v965, v966)
                                            } else {
                                                let v968: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                US12::US12_Error(v968.clone(), v838, v839, v840, v841, v842)
                                            }
                                        };
                                        let mut v1001: US12 = match &v971 {
                                            US12::US12_Error(v993, v994, v995, v996, v997, v998) => {
                                                let v993: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v993.clone();
                                                let v994: i32 = *v994;
                                                let v995: i32 = *v995;
                                                let v996: i32 = *v996;
                                                let v997: i32 = *v997;
                                                let v998: i32 = *v998;
                                                US12::US12_Error(v993.clone(), v994, v995, v996, v997, v998)
                                            }
                                            US12::US12_Ok(v972, v973, v974, v975, v976, v977) => {
                                                let v972: u8 = *v972;
                                                let mut v973: i32 = *v973;
                                                let v974: i32 = *v974;
                                                let v975: i32 = *v975;
                                                let v976: i32 = *v976;
                                                let v977: i32 = *v977;
                                                let v978: bool = v973 >= v977;
                                                if v978 {
                                                    let v979: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                                                    US12::US12_Error(v979.clone(), v973, v974, v975, v976, v977)
                                                } else {
                                                    let v981: u8 = v0.clone().as_bytes()[v973 as usize];
                                                    let v982: i32 = v973.wrapping_add(1i32);
                                                    let v983: bool = b'\n' == v981;
                                                    let (mut v987, mut v988, mut v989, mut v990): (i32, i32, i32, i32) = if v983 {
                                                        let v984: i32 = v974.wrapping_add(v976);
                                                        let v985: i32 = v975.wrapping_add(1i32);
                                                        (v984, v985, 1i32, v977)
                                                    } else {
                                                        let v986: i32 = v976.wrapping_add(1i32);
                                                        (v974, v975, v986, v977)
                                                    };
                                                    US12::US12_Ok(v981, v982, v987, v988, v989, v990)
                                                }
                                            }
                                        };
                                        let v1023: US13 = match &v1001 {
                                            US12::US12_Error(v1015, v1016, v1017, v1018, v1019, v1020) => {
                                                let v1015: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1015.clone();
                                                let v1016: i32 = *v1016;
                                                let v1017: i32 = *v1017;
                                                let v1018: i32 = *v1018;
                                                let v1019: i32 = *v1019;
                                                let v1020: i32 = *v1020;
                                                US13::US13_Error(v1015.clone(), v1016, v1017, v1018, v1019, v1020)
                                            }
                                            US12::US12_Ok(v1002, v1003, v1004, v1005, v1006, v1007) => {
                                                let v1002: u8 = *v1002;
                                                let v1003: i32 = *v1003;
                                                let v1004: i32 = *v1004;
                                                let v1005: i32 = *v1005;
                                                let v1006: i32 = *v1006;
                                                let v1007: i32 = *v1007;
                                                let v1008: bool = v838 >= v1003;
                                                let v1013: Rc<str> = if v1008 {
                                                    let v1009: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                    v1009.clone()
                                                } else {
                                                    let v1011: i32 = v1003.wrapping_sub(1i32);
                                                    let v1012: Rc<str> = string_slice(&v0.clone(), v838 as i64, v1011 as i64);
                                                    v1012.clone()
                                                };
                                                US13::US13_Ok(v1013.clone(), v1003, v1004, v1005, v1006, v1007)
                                            }
                                        };
                                        match &v1023 {
                                            US13::US13_Error(v1030, v1031, v1032, v1033, v1034, v1035) => {
                                                let v1030: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1030.clone();
                                                let v1031: i32 = *v1031;
                                                let v1032: i32 = *v1032;
                                                let v1033: i32 = *v1033;
                                                let v1034: i32 = *v1034;
                                                let v1035: i32 = *v1035;
                                                let v1036: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                                US13::US13_Error(v1036.clone(), v838, v839, v840, v841, v842)
                                            }
                                            US13::US13_Ok(v1024, v1025, v1026, v1027, v1028, v1029) => {
                                                let v1024: Rc<str> = v1024.clone();
                                                let v1025: i32 = *v1025;
                                                let v1026: i32 = *v1026;
                                                let v1027: i32 = *v1027;
                                                let v1028: i32 = *v1028;
                                                let v1029: i32 = *v1029;
                                                v1023.clone()
                                            }
                                        }
                                    }
                                    US13::US13_Ok(v942, v943, v944, v945, v946, v947) => {
                                        let v942: Rc<str> = v942.clone();
                                        let v943: i32 = *v943;
                                        let v944: i32 = *v944;
                                        let v945: i32 = *v945;
                                        let v946: i32 = *v946;
                                        let v947: i32 = *v947;
                                        v941.clone()
                                    }
                                }
                            }
                            US13::US13_Ok(v859, v860, v861, v862, v863, v864) => {
                                let v859: Rc<str> = v859.clone();
                                let v860: i32 = *v860;
                                let v861: i32 = *v861;
                                let v862: i32 = *v862;
                                let v863: i32 = *v863;
                                let v864: i32 = *v864;
                                v858.clone()
                            }
                        };
                        let v1066: US13 = match &v1043 {
                            US13::US13_Error(v1044, v1045, v1046, v1047, v1048, v1049) => {
                                let v1044: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1044.clone();
                                let v1045: i32 = *v1045;
                                let v1046: i32 = *v1046;
                                let v1047: i32 = *v1047;
                                let v1048: i32 = *v1048;
                                let v1049: i32 = *v1049;
                                let v1050: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                US13::US13_Ok(v1050.clone(), v838, v839, v840, v841, v842)
                            }
                            US13::US13_Ok(v1052, v1053, v1054, v1055, v1056, v1057) => {
                                let v1052: Rc<str> = v1052.clone();
                                let v1053: i32 = *v1053;
                                let v1054: i32 = *v1054;
                                let v1055: i32 = *v1055;
                                let v1056: i32 = *v1056;
                                let v1057: i32 = *v1057;
                                let v1058: bool = v1053 == v838;
                                if v1058 {
                                    let v1059: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure45();
                                    US13::US13_Error(v1059.clone(), v838, v839, v840, v841, v842)
                                } else {
                                    let v1061: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                    let v1062: i32 = 0i32;
                                    method82(v0.clone(), v1061.clone(), v1061.clone(), v1052.clone(), v1062, v1053, v1054, v1055, v1056, v1057)
                                }
                            }
                        };
                        match &v1066 {
                            US13::US13_Error(v1109, v1110, v1111, v1112, v1113, v1114) => {
                                let v1109: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1109.clone();
                                let v1110: i32 = *v1110;
                                let v1111: i32 = *v1111;
                                let v1112: i32 = *v1112;
                                let v1113: i32 = *v1113;
                                let v1114: i32 = *v1114;
                                let v1115: bool = v838 >= v842;
                                let v1133: US12 = if v1115 {
                                    let v1116: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                    US12::US12_Error(v1116.clone(), v838, v839, v840, v841, v842)
                                } else {
                                    let v1118: u8 = v0.clone().as_bytes()[v838 as usize];
                                    let v1119: bool = v1118 == b'"';
                                    if v1119 {
                                        let v1120: i32 = v838.wrapping_add(1i32);
                                        let v1121: bool = b'\n' == v1118;
                                        let (mut v1125, mut v1126, mut v1127, mut v1128): (i32, i32, i32, i32) = if v1121 {
                                            let v1122: i32 = v839.wrapping_add(v841);
                                            let v1123: i32 = v840.wrapping_add(1i32);
                                            (v1122, v1123, 1i32, v842)
                                        } else {
                                            let v1124: i32 = v841.wrapping_add(1i32);
                                            (v839, v840, v1124, v842)
                                        };
                                        US12::US12_Ok(b'"', v1120, v1125, v1126, v1127, v1128)
                                    } else {
                                        let v1130: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                        US12::US12_Error(v1130.clone(), v838, v839, v840, v841, v842)
                                    }
                                };
                                match &v1133 {
                                    US12::US12_Error(v1142, v1143, v1144, v1145, v1146, v1147) => {
                                        let v1142: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1142.clone();
                                        let v1143: i32 = *v1143;
                                        let v1144: i32 = *v1144;
                                        let v1145: i32 = *v1145;
                                        let v1146: i32 = *v1146;
                                        let v1147: i32 = *v1147;
                                        let v1148: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                                        US13::US13_Error(v1148.clone(), v838, v839, v840, v841, v842)
                                    }
                                    US12::US12_Ok(v1134, v1135, v1136, v1137, v1138, v1139) => {
                                        let v1134: u8 = *v1134;
                                        let v1135: i32 = *v1135;
                                        let v1136: i32 = *v1136;
                                        let v1137: i32 = *v1137;
                                        let v1138: i32 = *v1138;
                                        let v1139: i32 = *v1139;
                                        let v1140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        US13::US13_Ok(v1140.clone(), v1135, v1136, v1137, v1138, v1139)
                                    }
                                }
                            }
                            US13::US13_Ok(v1067, v1068, v1069, v1070, v1071, v1072) => {
                                let v1067: Rc<str> = v1067.clone();
                                let v1068: i32 = *v1068;
                                let v1069: i32 = *v1069;
                                let v1070: i32 = *v1070;
                                let v1071: i32 = *v1071;
                                let v1072: i32 = *v1072;
                                let v1073: bool = v1068 >= v1072;
                                let v1091: US12 = if v1073 {
                                    let v1074: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                    US12::US12_Error(v1074.clone(), v1068, v1069, v1070, v1071, v1072)
                                } else {
                                    let v1076: u8 = v0.clone().as_bytes()[v1068 as usize];
                                    let v1077: bool = v1076 == b'"';
                                    if v1077 {
                                        let v1078: i32 = v1068.wrapping_add(1i32);
                                        let v1079: bool = b'\n' == v1076;
                                        let (mut v1083, mut v1084, mut v1085, mut v1086): (i32, i32, i32, i32) = if v1079 {
                                            let v1080: i32 = v1069.wrapping_add(v1071);
                                            let v1081: i32 = v1070.wrapping_add(1i32);
                                            (v1080, v1081, 1i32, v1072)
                                        } else {
                                            let v1082: i32 = v1071.wrapping_add(1i32);
                                            (v1069, v1070, v1082, v1072)
                                        };
                                        US12::US12_Ok(b'"', v1078, v1083, v1084, v1085, v1086)
                                    } else {
                                        let v1088: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                        US12::US12_Error(v1088.clone(), v1068, v1069, v1070, v1071, v1072)
                                    }
                                };
                                match &v1091 {
                                    US12::US12_Error(v1099, v1100, v1101, v1102, v1103, v1104) => {
                                        let v1099: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1099.clone();
                                        let v1100: i32 = *v1100;
                                        let v1101: i32 = *v1101;
                                        let v1102: i32 = *v1102;
                                        let v1103: i32 = *v1103;
                                        let v1104: i32 = *v1104;
                                        let v1105: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28(v838, v1068, v1099.clone(), v1100, v1101, v1102, v1103, v1104);
                                        US13::US13_Error(v1105.clone(), v1068, v1069, v1070, v1071, v1072)
                                    }
                                    US12::US12_Ok(v1092, v1093, v1094, v1095, v1096, v1097) => {
                                        let v1092: u8 = *v1092;
                                        let v1093: i32 = *v1093;
                                        let v1094: i32 = *v1094;
                                        let v1095: i32 = *v1095;
                                        let v1096: i32 = *v1096;
                                        let v1097: i32 = *v1097;
                                        US13::US13_Ok(v1067.clone(), v1093, v1094, v1095, v1096, v1097)
                                    }
                                }
                            }
                        }
                    }
                }
            }
            US13::US13_Ok(v807, v808, v809, v810, v811, v812) => {
                let v807: Rc<str> = v807.clone();
                let v808: i32 = *v808;
                let v809: i32 = *v809;
                let v810: i32 = *v810;
                let v811: i32 = *v811;
                let mut v812: i32 = *v812;
                v806.clone()
            }
        };
        let v1194: US13 = match &v1164 {
            US13::US13_Error(v1171, v1172, v1173, v1174, v1175, v1176) => {
                let v1171: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1171.clone();
                let v1172: i32 = *v1172;
                let v1173: i32 = *v1173;
                let v1174: i32 = *v1174;
                let v1175: i32 = *v1175;
                let v1176: i32 = *v1176;
                let (mut v1177, mut v1178, mut v1179, mut v1180, mut v1181): (i32, i32, i32, i32, i32) = method87(v4, v5, v6, v7, v0.clone(), v3, v4, v5, v6, v7);
                let v1182: bool = v1177 > v3;
                if v1182 {
                    let v1183: bool = v3 >= v1177;
                    let v1188: Rc<str> = if v1183 {
                        let v1184: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v1184.clone()
                    } else {
                        let v1186: i32 = v1177.wrapping_sub(1i32);
                        let v1187: Rc<str> = string_slice(&v0.clone(), v3 as i64, v1186 as i64);
                        v1187.clone()
                    };
                    US13::US13_Ok(v1188.clone(), v1177, v1178, v1179, v1180, v1181)
                } else {
                    let v1190: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                    US13::US13_Error(v1190.clone(), v3, v4, v5, v6, v7)
                }
            }
            US13::US13_Ok(v1165, v1166, v1167, v1168, v1169, v1170) => {
                let v1165: Rc<str> = v1165.clone();
                let v1166: i32 = *v1166;
                let v1167: i32 = *v1167;
                let v1168: i32 = *v1168;
                let v1169: i32 = *v1169;
                let v1170: i32 = *v1170;
                v1164.clone()
            }
        };
        let v1233: US13 = match &v1194 {
            US13::US13_Error(v1201, v1202, v1203, v1204, v1205, v1206) => {
                let v1201: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1201.clone();
                let v1202: i32 = *v1202;
                let v1203: i32 = *v1203;
                let v1204: i32 = *v1204;
                let v1205: i32 = *v1205;
                let v1206: i32 = *v1206;
                let v1207: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                let v1208: US21 = method84(v0.clone(), v1207.clone(), v3, v4, v5, v6, v7);
                match &v1208 {
                    US21::US21_Error(v1223, v1224, v1225, v1226, v1227, v1228) => {
                        let v1223: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1223.clone();
                        let v1224: i32 = *v1224;
                        let v1225: i32 = *v1225;
                        let v1226: i32 = *v1226;
                        let v1227: i32 = *v1227;
                        let v1228: i32 = *v1228;
                        US13::US13_Error(v1223.clone(), v1224, v1225, v1226, v1227, v1228)
                    }
                    US21::US21_Ok(v1209, v1210, v1211, v1212, v1213, v1214) => {
                        let v1209: Rc<UH0> = v1209.clone();
                        let v1210: i32 = *v1210;
                        let v1211: i32 = *v1211;
                        let v1212: i32 = *v1212;
                        let v1213: i32 = *v1213;
                        let v1214: i32 = *v1214;
                        let v1215: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
                        let v1216: i32 = 0i32;
                        let v1217: i32 = method3(v1215.clone(), v1209.clone(), v1216);
                        let v1218: Rc<Vec<Rc<str>>> = Rc::new(v1215.borrow().clone());
                        let v1219: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v1218).as_ref().clone()));
                        let v1220: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v1221: Rc<str> = Rc::<str>::from((*v1219.borrow()).join(&*v1220));
                        US13::US13_Ok(v1221.clone(), v1210, v1211, v1212, v1213, v1214)
                    }
                }
            }
            US13::US13_Ok(v1195, v1196, v1197, v1198, v1199, v1200) => {
                let v1195: Rc<str> = v1195.clone();
                let v1196: i32 = *v1196;
                let v1197: i32 = *v1197;
                let v1198: i32 = *v1198;
                let v1199: i32 = *v1199;
                let v1200: i32 = *v1200;
                v1194.clone()
            }
        };
        let v1244: US13 = match &v1233 {
            US13::US13_Ok(v1234, v1235, v1236, v1237, v1238, v1239) => {
                let v1234: Rc<str> = v1234.clone();
                let v1235: i32 = *v1235;
                let v1236: i32 = *v1236;
                let v1237: i32 = *v1237;
                let v1238: i32 = *v1238;
                let v1239: i32 = *v1239;
                let v1240: bool = v1235 == v3;
                if v1240 {
                    let v1241: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure51();
                    US13::US13_Error(v1241.clone(), v3, v4, v5, v6, v7)
                } else {
                    v1233.clone()
                }
            }
            _ => {
                v1233.clone()
            }
        };
        match &v1244 {
            US13::US13_Error(v1245, v1246, v1247, v1248, v1249, v1250) => {
                let v1245: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1245.clone();
                let v1246: i32 = *v1246;
                let v1247: i32 = *v1247;
                let v1248: i32 = *v1248;
                let v1249: i32 = *v1249;
                let v1250: i32 = *v1250;
                let v1271: Rc<str> = match &*v2 {
                    UH0::UH0_Nil => {
                        v1.clone()
                    }
                    _ => {
                        let v1269: Rc<str> = match &*v2 {
                            UH0::UH0_Cons(v1251, v1252) => {
                                let v1251: Rc<str> = v1251.clone();
                                let v1252: Rc<UH0> = v1252.clone();
                                match &*v1252 {
                                    UH0::UH0_Cons(v1253, v1254) => {
                                        let v1253: Rc<str> = v1253.clone();
                                        let v1254: Rc<UH0> = v1254.clone();
                                        match &*v1254 {
                                            UH0::UH0_Cons(v1255, v1256) => {
                                                let v1255: Rc<str> = v1255.clone();
                                                let v1256: Rc<UH0> = v1256.clone();
                                                let v1257: i32 = 0i32;
                                                let v1258: i32 = method88(v2.clone(), v1257);
                                                let v1259: usize = ((v1258) as usize);
                                                let v1260: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(vec![0u8; v1259]));
                                                let v1261: i32 = method89(v1260.clone(), v2.clone(), v1258);
                                                let v1262: Rc<str> = unsafe { Rc::<str>::from(std::str::from_utf8_unchecked(&v1260.borrow())) };
                                                v1262.clone()
                                            }
                                            _ => {
                                                let v1263: bool = true;
                                                method90(v1263, v2.clone())
                                            }
                                        }
                                    }
                                    _ => {
                                        let v1266: bool = true;
                                        method90(v1266, v2.clone())
                                    }
                                }
                            }
                            _ => unreachable!(),
                        };
                        let v1270: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v1269));
                        v1270.clone()
                    }
                };
                return US13::US13_Ok(v1271.clone(), v3, v4, v5, v6, v7);
            }
            US13::US13_Ok(v1273, v1274, v1275, v1276, v1277, v1278) => {
                let v1273: Rc<str> = v1273.clone();
                let v1274: i32 = *v1274;
                let v1275: i32 = *v1275;
                let v1276: i32 = *v1276;
                let v1277: i32 = *v1277;
                let v1278: i32 = *v1278;
                let v1279: bool = v1274 > v3;
                if v1279 {
                    let v1280: Rc<UH0> = Rc::new(UH0::UH0_Cons(v1273.clone(), v2.clone()));
                    (v0, v1, v2, v3, v4, v5, v6, v7) = (v0.clone(), v1.clone(), v1280.clone(), v1274, v1275, v1276, v1277, v1278);
                    continue;
                } else {
                    let v1282: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure52();
                    return US13::US13_Error(v1282.clone(), v3, v4, v5, v6, v7);
                }
            }
        }
    }
}
fn closure53() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.sep_by / separator consumed no text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method92(mut v0: Rc<str>, mut v1: Rc<UH0>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US21 {
    loop {
        let mut v7: bool = v2 >= v6;
        let (mut v20, mut v21, mut v22, mut v23, mut v24): (i32, i32, i32, i32, i32) = if v7 {
            (v2, v3, v4, v5, v6)
        } else {
            let mut v8: i32 = (v0.clone().len() as i32);
            let mut v9: i32 = method78(v0.clone(), v8, v2);
            let mut v10: bool = v9 > v6;
            let mut v11: i32 = if v10 {
                v6
            } else {
                v9
            };
            let mut v12: i32 = v11.wrapping_sub(v2);
            let mut v13: bool = v12 == 0i32;
            if v13 {
                (v2, v3, v4, v5, v6)
            } else {
                let mut v14: i32 = v5.wrapping_add(v12);
                (v11, v3, v4, v14, v6)
            }
        };
        let mut v25: bool = v20 != v2;
        let mut v29: US14 = if v25 {
            US14::US14_Ok(v20, v21, v22, v23, v24)
        } else {
            let mut v27: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure33();
            US14::US14_Error(v27.clone(), v2, v3, v4, v5, v6)
        };
        match &v29 {
            US14::US14_Error(v30, v31, v32, v33, v34, v35) => {
                let v30: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v30.clone();
                let mut v31: i32 = *v31;
                let mut v32: i32 = *v32;
                let mut v33: i32 = *v33;
                let mut v34: i32 = *v34;
                let mut v35: i32 = *v35;
                let v36: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                let v37: Rc<UH0> = method85(v1.clone(), v36.clone());
                return US21::US21_Ok(v37.clone(), v2, v3, v4, v5, v6);
            }
            US14::US14_Ok(v39, v40, v41, v42, v43) => {
                let v39: i32 = *v39;
                let v40: i32 = *v40;
                let v41: i32 = *v41;
                let v42: i32 = *v42;
                let v43: i32 = *v43;
                let mut v44: bool = v39 == v2;
                if v44 {
                    let mut v45: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure53();
                    return US21::US21_Error(v45.clone(), v2, v3, v4, v5, v6);
                } else {
                    let mut v47: bool = v39 >= v43;
                    let mut v65: US12 = if v47 {
                        let mut v48: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                        US12::US12_Error(v48.clone(), v39, v40, v41, v42, v43)
                    } else {
                        let v50: u8 = v0.clone().as_bytes()[v39 as usize];
                        let v51: bool = v50 == b'\\';
                        if v51 {
                            let mut v52: i32 = v39.wrapping_add(1i32);
                            let v53: bool = b'\n' == v50;
                            let (mut v57, mut v58, mut v59, mut v60): (i32, i32, i32, i32) = if v53 {
                                let v54: i32 = v40.wrapping_add(v42);
                                let v55: i32 = v41.wrapping_add(1i32);
                                (v54, v55, 1i32, v43)
                            } else {
                                let v56: i32 = v42.wrapping_add(1i32);
                                (v40, v41, v56, v43)
                            };
                            US12::US12_Ok(b'\\', v52, v57, v58, v59, v60)
                        } else {
                            let v62: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                            US12::US12_Error(v62.clone(), v39, v40, v41, v42, v43)
                        }
                    };
                    let v99: US12 = match &v65 {
                        US12::US12_Error(v91, v92, v93, v94, v95, v96) => {
                            let v91: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v91.clone();
                            let v92: i32 = *v92;
                            let mut v93: i32 = *v93;
                            let v94: i32 = *v94;
                            let v95: i32 = *v95;
                            let v96: i32 = *v96;
                            US12::US12_Error(v91.clone(), v92, v93, v94, v95, v96)
                        }
                        US12::US12_Ok(v66, v67, v68, v69, v70, v71) => {
                            let v66: u8 = *v66;
                            let v67: i32 = *v67;
                            let mut v68: i32 = *v68;
                            let v69: i32 = *v69;
                            let mut v70: i32 = *v70;
                            let v71: i32 = *v71;
                            let v72: bool = v67 >= v71;
                            if v72 {
                                let mut v73: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US12::US12_Error(v73.clone(), v67, v68, v69, v70, v71)
                            } else {
                                let mut v75: u8 = v0.clone().as_bytes()[v67 as usize];
                                let mut v76: bool = v75 == b'"';
                                if v76 {
                                    let mut v77: i32 = v67.wrapping_add(1i32);
                                    let v78: bool = b'\n' == v75;
                                    let (mut v82, mut v83, mut v84, mut v85): (i32, i32, i32, i32) = if v78 {
                                        let mut v79: i32 = v68.wrapping_add(v70);
                                        let mut v80: i32 = v69.wrapping_add(1i32);
                                        (v79, v80, 1i32, v71)
                                    } else {
                                        let mut v81: i32 = v70.wrapping_add(1i32);
                                        (v68, v69, v81, v71)
                                    };
                                    US12::US12_Ok(b'"', v77, v82, v83, v84, v85)
                                } else {
                                    let mut v87: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US12::US12_Error(v87.clone(), v67, v68, v69, v70, v71)
                                }
                            }
                        }
                    };
                    let mut v115: US12 = match &v99 {
                        US12::US12_Error(v107, v108, v109, v110, v111, v112) => {
                            let v107: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v107.clone();
                            let mut v108: i32 = *v108;
                            let mut v109: i32 = *v109;
                            let mut v110: i32 = *v110;
                            let v111: i32 = *v111;
                            let mut v112: i32 = *v112;
                            US12::US12_Error(v107.clone(), v108, v109, v110, v111, v112)
                        }
                        US12::US12_Ok(v100, v101, v102, v103, v104, v105) => {
                            let v100: u8 = *v100;
                            let v101: i32 = *v101;
                            let mut v102: i32 = *v102;
                            let v103: i32 = *v103;
                            let mut v104: i32 = *v104;
                            let mut v105: i32 = *v105;
                            US12::US12_Ok(b'"', v101, v102, v103, v104, v105)
                        }
                    };
                    let v213: US12 = match &v115 {
                        US12::US12_Error(v122, v123, v124, v125, v126, v127) => {
                            let mut v122: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v122.clone();
                            let v123: i32 = *v123;
                            let mut v124: i32 = *v124;
                            let v125: i32 = *v125;
                            let v126: i32 = *v126;
                            let mut v127: i32 = *v127;
                            let v145: US12 = if v47 {
                                let v128: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                US12::US12_Error(v128.clone(), v39, v40, v41, v42, v43)
                            } else {
                                let mut v130: u8 = v0.clone().as_bytes()[v39 as usize];
                                let v131: bool = v130 == b'`';
                                if v131 {
                                    let v132: i32 = v39.wrapping_add(1i32);
                                    let v133: bool = b'\n' == v130;
                                    let (mut v137, mut v138, mut v139, mut v140): (i32, i32, i32, i32) = if v133 {
                                        let v134: i32 = v40.wrapping_add(v42);
                                        let v135: i32 = v41.wrapping_add(1i32);
                                        (v134, v135, 1i32, v43)
                                    } else {
                                        let v136: i32 = v42.wrapping_add(1i32);
                                        (v40, v41, v136, v43)
                                    };
                                    US12::US12_Ok(b'`', v132, v137, v138, v139, v140)
                                } else {
                                    let v142: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                    US12::US12_Error(v142.clone(), v39, v40, v41, v42, v43)
                                }
                            };
                            let v179: US12 = match &v145 {
                                US12::US12_Error(v171, v172, v173, v174, v175, v176) => {
                                    let v171: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v171.clone();
                                    let mut v172: i32 = *v172;
                                    let v173: i32 = *v173;
                                    let v174: i32 = *v174;
                                    let mut v175: i32 = *v175;
                                    let v176: i32 = *v176;
                                    US12::US12_Error(v171.clone(), v172, v173, v174, v175, v176)
                                }
                                US12::US12_Ok(v146, v147, v148, v149, v150, v151) => {
                                    let v146: u8 = *v146;
                                    let mut v147: i32 = *v147;
                                    let mut v148: i32 = *v148;
                                    let v149: i32 = *v149;
                                    let mut v150: i32 = *v150;
                                    let mut v151: i32 = *v151;
                                    let mut v152: bool = v147 >= v151;
                                    if v152 {
                                        let v153: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                        US12::US12_Error(v153.clone(), v147, v148, v149, v150, v151)
                                    } else {
                                        let mut v155: u8 = v0.clone().as_bytes()[v147 as usize];
                                        let v156: bool = v155 == b'"';
                                        if v156 {
                                            let v157: i32 = v147.wrapping_add(1i32);
                                            let v158: bool = b'\n' == v155;
                                            let (mut v162, mut v163, mut v164, mut v165): (i32, i32, i32, i32) = if v158 {
                                                let mut v159: i32 = v148.wrapping_add(v150);
                                                let v160: i32 = v149.wrapping_add(1i32);
                                                (v159, v160, 1i32, v151)
                                            } else {
                                                let mut v161: i32 = v150.wrapping_add(1i32);
                                                (v148, v149, v161, v151)
                                            };
                                            US12::US12_Ok(b'"', v157, v162, v163, v164, v165)
                                        } else {
                                            let mut v167: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                            US12::US12_Error(v167.clone(), v147, v148, v149, v150, v151)
                                        }
                                    }
                                }
                            };
                            let v195: US12 = match &v179 {
                                US12::US12_Error(v187, v188, v189, v190, v191, v192) => {
                                    let v187: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v187.clone();
                                    let v188: i32 = *v188;
                                    let mut v189: i32 = *v189;
                                    let mut v190: i32 = *v190;
                                    let v191: i32 = *v191;
                                    let v192: i32 = *v192;
                                    US12::US12_Error(v187.clone(), v188, v189, v190, v191, v192)
                                }
                                US12::US12_Ok(v180, v181, v182, v183, v184, v185) => {
                                    let v180: u8 = *v180;
                                    let mut v181: i32 = *v181;
                                    let mut v182: i32 = *v182;
                                    let mut v183: i32 = *v183;
                                    let v184: i32 = *v184;
                                    let v185: i32 = *v185;
                                    US12::US12_Ok(b'"', v181, v182, v183, v184, v185)
                                }
                            };
                            match &v195 {
                                US12::US12_Error(v202, v203, v204, v205, v206, v207) => {
                                    let v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v202.clone();
                                    let v203: i32 = *v203;
                                    let v204: i32 = *v204;
                                    let v205: i32 = *v205;
                                    let v206: i32 = *v206;
                                    let v207: i32 = *v207;
                                    let v208: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                    US12::US12_Error(v208.clone(), v39, v40, v41, v42, v43)
                                }
                                US12::US12_Ok(v196, v197, v198, v199, v200, v201) => {
                                    let v196: u8 = *v196;
                                    let v197: i32 = *v197;
                                    let v198: i32 = *v198;
                                    let v199: i32 = *v199;
                                    let v200: i32 = *v200;
                                    let mut v201: i32 = *v201;
                                    v195.clone()
                                }
                            }
                        }
                        US12::US12_Ok(v116, v117, v118, v119, v120, v121) => {
                            let mut v116: u8 = *v116;
                            let v117: i32 = *v117;
                            let v118: i32 = *v118;
                            let mut v119: i32 = *v119;
                            let v120: i32 = *v120;
                            let mut v121: i32 = *v121;
                            v115.clone()
                        }
                    };
                    let v845: US13 = match &v213 {
                        US12::US12_Error(v837, v838, v839, v840, v841, v842) => {
                            let v837: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v837.clone();
                            let v838: i32 = *v838;
                            let v839: i32 = *v839;
                            let v840: i32 = *v840;
                            let v841: i32 = *v841;
                            let v842: i32 = *v842;
                            US13::US13_Error(v837.clone(), v838, v839, v840, v841, v842)
                        }
                        US12::US12_Ok(v214, v215, v216, v217, v218, v219) => {
                            let v214: u8 = *v214;
                            let v215: i32 = *v215;
                            let v216: i32 = *v216;
                            let mut v217: i32 = *v217;
                            let mut v218: i32 = *v218;
                            let mut v219: i32 = *v219;
                            let (mut v220, mut v221, mut v222, mut v223, mut v224): (i32, i32, i32, i32, i32) = method80(v216, v217, v218, v219, v0.clone(), v215, v216, v217, v218, v219);
                            let v225: bool = v220 > v215;
                            let mut v235: US13 = if v225 {
                                let v226: bool = v215 >= v220;
                                let mut v231: Rc<str> = if v226 {
                                    let mut v227: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v227.clone()
                                } else {
                                    let v229: i32 = v220.wrapping_sub(1i32);
                                    let mut v230: Rc<str> = string_slice(&v0.clone(), v215 as i64, v229 as i64);
                                    v230.clone()
                                };
                                US13::US13_Ok(v231.clone(), v220, v221, v222, v223, v224)
                            } else {
                                let v233: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                US13::US13_Error(v233.clone(), v215, v216, v217, v218, v219)
                            };
                            let v430: US13 = match &v235 {
                                US13::US13_Error(v242, v243, v244, v245, v246, v247) => {
                                    let v242: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v242.clone();
                                    let v243: i32 = *v243;
                                    let v244: i32 = *v244;
                                    let v245: i32 = *v245;
                                    let v246: i32 = *v246;
                                    let v247: i32 = *v247;
                                    let mut v248: bool = v215 >= v219;
                                    let v266: US12 = if v248 {
                                        let mut v249: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US12::US12_Error(v249.clone(), v215, v216, v217, v218, v219)
                                    } else {
                                        let v251: u8 = v0.clone().as_bytes()[v215 as usize];
                                        let v252: bool = v251 == b'\\';
                                        if v252 {
                                            let v253: i32 = v215.wrapping_add(1i32);
                                            let v254: bool = b'\n' == v251;
                                            let (mut v258, mut v259, mut v260, mut v261): (i32, i32, i32, i32) = if v254 {
                                                let v255: i32 = v216.wrapping_add(v218);
                                                let v256: i32 = v217.wrapping_add(1i32);
                                                (v255, v256, 1i32, v219)
                                            } else {
                                                let mut v257: i32 = v218.wrapping_add(1i32);
                                                (v216, v217, v257, v219)
                                            };
                                            US12::US12_Ok(b'\\', v253, v258, v259, v260, v261)
                                        } else {
                                            let v263: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                            US12::US12_Error(v263.clone(), v215, v216, v217, v218, v219)
                                        }
                                    };
                                    let v301: US12 = match &v266 {
                                        US12::US12_Error(v293, v294, v295, v296, v297, v298) => {
                                            let v293: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v293.clone();
                                            let mut v294: i32 = *v294;
                                            let v295: i32 = *v295;
                                            let v296: i32 = *v296;
                                            let v297: i32 = *v297;
                                            let v298: i32 = *v298;
                                            US12::US12_Error(v293.clone(), v294, v295, v296, v297, v298)
                                        }
                                        US12::US12_Ok(v267, v268, v269, v270, v271, v272) => {
                                            let v267: u8 = *v267;
                                            let v268: i32 = *v268;
                                            let v269: i32 = *v269;
                                            let v270: i32 = *v270;
                                            let v271: i32 = *v271;
                                            let v272: i32 = *v272;
                                            let v273: bool = v268 >= v272;
                                            if v273 {
                                                let mut v274: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                                                US12::US12_Error(v274.clone(), v268, v269, v270, v271, v272)
                                            } else {
                                                let v276: u8 = v0.clone().as_bytes()[v268 as usize];
                                                let v277: bool = v276 == b'"';
                                                let v278: bool = v277 == false;
                                                if v278 {
                                                    let v279: i32 = v268.wrapping_add(1i32);
                                                    let v280: bool = b'\n' == v276;
                                                    let (mut v284, mut v285, mut v286, mut v287): (i32, i32, i32, i32) = if v280 {
                                                        let v281: i32 = v269.wrapping_add(v271);
                                                        let v282: i32 = v270.wrapping_add(1i32);
                                                        (v281, v282, 1i32, v272)
                                                    } else {
                                                        let v283: i32 = v271.wrapping_add(1i32);
                                                        (v269, v270, v283, v272)
                                                    };
                                                    US12::US12_Ok(v276, v279, v284, v285, v286, v287)
                                                } else {
                                                    let v289: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                    US12::US12_Error(v289.clone(), v268, v269, v270, v271, v272)
                                                }
                                            }
                                        }
                                    };
                                    let v323: US13 = match &v301 {
                                        US12::US12_Error(v315, v316, v317, v318, v319, v320) => {
                                            let v315: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v315.clone();
                                            let v316: i32 = *v316;
                                            let v317: i32 = *v317;
                                            let mut v318: i32 = *v318;
                                            let v319: i32 = *v319;
                                            let v320: i32 = *v320;
                                            US13::US13_Error(v315.clone(), v316, v317, v318, v319, v320)
                                        }
                                        US12::US12_Ok(v302, v303, v304, v305, v306, v307) => {
                                            let v302: u8 = *v302;
                                            let v303: i32 = *v303;
                                            let v304: i32 = *v304;
                                            let v305: i32 = *v305;
                                            let v306: i32 = *v306;
                                            let v307: i32 = *v307;
                                            let v308: bool = v215 >= v303;
                                            let v313: Rc<str> = if v308 {
                                                let v309: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                v309.clone()
                                            } else {
                                                let v311: i32 = v303.wrapping_sub(1i32);
                                                let v312: Rc<str> = string_slice(&v0.clone(), v215 as i64, v311 as i64);
                                                v312.clone()
                                            };
                                            US13::US13_Ok(v313.clone(), v303, v304, v305, v306, v307)
                                        }
                                    };
                                    match &v323 {
                                        US13::US13_Error(v330, v331, v332, v333, v334, v335) => {
                                            let v330: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v330.clone();
                                            let v331: i32 = *v331;
                                            let mut v332: i32 = *v332;
                                            let v333: i32 = *v333;
                                            let v334: i32 = *v334;
                                            let v335: i32 = *v335;
                                            let v353: US12 = if v248 {
                                                let v336: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                                US12::US12_Error(v336.clone(), v215, v216, v217, v218, v219)
                                            } else {
                                                let v338: u8 = v0.clone().as_bytes()[v215 as usize];
                                                let v339: bool = v338 == b'`';
                                                if v339 {
                                                    let v340: i32 = v215.wrapping_add(1i32);
                                                    let v341: bool = b'\n' == v338;
                                                    let (mut v345, mut v346, mut v347, mut v348): (i32, i32, i32, i32) = if v341 {
                                                        let v342: i32 = v216.wrapping_add(v218);
                                                        let v343: i32 = v217.wrapping_add(1i32);
                                                        (v342, v343, 1i32, v219)
                                                    } else {
                                                        let v344: i32 = v218.wrapping_add(1i32);
                                                        (v216, v217, v344, v219)
                                                    };
                                                    US12::US12_Ok(b'`', v340, v345, v346, v347, v348)
                                                } else {
                                                    let v350: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                    US12::US12_Error(v350.clone(), v215, v216, v217, v218, v219)
                                                }
                                            };
                                            let v388: US12 = match &v353 {
                                                US12::US12_Error(v380, v381, v382, v383, v384, v385) => {
                                                    let v380: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v380.clone();
                                                    let v381: i32 = *v381;
                                                    let v382: i32 = *v382;
                                                    let v383: i32 = *v383;
                                                    let v384: i32 = *v384;
                                                    let v385: i32 = *v385;
                                                    US12::US12_Error(v380.clone(), v381, v382, v383, v384, v385)
                                                }
                                                US12::US12_Ok(v354, v355, v356, v357, v358, v359) => {
                                                    let v354: u8 = *v354;
                                                    let v355: i32 = *v355;
                                                    let v356: i32 = *v356;
                                                    let v357: i32 = *v357;
                                                    let v358: i32 = *v358;
                                                    let mut v359: i32 = *v359;
                                                    let v360: bool = v355 >= v359;
                                                    if v360 {
                                                        let v361: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                                                        US12::US12_Error(v361.clone(), v355, v356, v357, v358, v359)
                                                    } else {
                                                        let v363: u8 = v0.clone().as_bytes()[v355 as usize];
                                                        let v364: bool = v363 == b'"';
                                                        let v365: bool = v364 == false;
                                                        if v365 {
                                                            let v366: i32 = v355.wrapping_add(1i32);
                                                            let v367: bool = b'\n' == v363;
                                                            let (mut v371, mut v372, mut v373, mut v374): (i32, i32, i32, i32) = if v367 {
                                                                let v368: i32 = v356.wrapping_add(v358);
                                                                let v369: i32 = v357.wrapping_add(1i32);
                                                                (v368, v369, 1i32, v359)
                                                            } else {
                                                                let v370: i32 = v358.wrapping_add(1i32);
                                                                (v356, v357, v370, v359)
                                                            };
                                                            US12::US12_Ok(v363, v366, v371, v372, v373, v374)
                                                        } else {
                                                            let v376: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                            US12::US12_Error(v376.clone(), v355, v356, v357, v358, v359)
                                                        }
                                                    }
                                                }
                                            };
                                            let v410: US13 = match &v388 {
                                                US12::US12_Error(v402, v403, v404, v405, v406, v407) => {
                                                    let v402: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v402.clone();
                                                    let v403: i32 = *v403;
                                                    let v404: i32 = *v404;
                                                    let v405: i32 = *v405;
                                                    let v406: i32 = *v406;
                                                    let v407: i32 = *v407;
                                                    US13::US13_Error(v402.clone(), v403, v404, v405, v406, v407)
                                                }
                                                US12::US12_Ok(v389, v390, v391, v392, v393, v394) => {
                                                    let v389: u8 = *v389;
                                                    let v390: i32 = *v390;
                                                    let mut v391: i32 = *v391;
                                                    let v392: i32 = *v392;
                                                    let v393: i32 = *v393;
                                                    let mut v394: i32 = *v394;
                                                    let v395: bool = v215 >= v390;
                                                    let v400: Rc<str> = if v395 {
                                                        let v396: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                        v396.clone()
                                                    } else {
                                                        let v398: i32 = v390.wrapping_sub(1i32);
                                                        let v399: Rc<str> = string_slice(&v0.clone(), v215 as i64, v398 as i64);
                                                        v399.clone()
                                                    };
                                                    US13::US13_Ok(v400.clone(), v390, v391, v392, v393, v394)
                                                }
                                            };
                                            match &v410 {
                                                US13::US13_Error(v417, v418, v419, v420, v421, v422) => {
                                                    let v417: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v417.clone();
                                                    let v418: i32 = *v418;
                                                    let v419: i32 = *v419;
                                                    let v420: i32 = *v420;
                                                    let v421: i32 = *v421;
                                                    let mut v422: i32 = *v422;
                                                    let v423: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                                    US13::US13_Error(v423.clone(), v215, v216, v217, v218, v219)
                                                }
                                                US13::US13_Ok(v411, v412, v413, v414, v415, v416) => {
                                                    let v411: Rc<str> = v411.clone();
                                                    let v412: i32 = *v412;
                                                    let v413: i32 = *v413;
                                                    let v414: i32 = *v414;
                                                    let v415: i32 = *v415;
                                                    let v416: i32 = *v416;
                                                    v410.clone()
                                                }
                                            }
                                        }
                                        US13::US13_Ok(v324, v325, v326, v327, v328, v329) => {
                                            let v324: Rc<str> = v324.clone();
                                            let v325: i32 = *v325;
                                            let v326: i32 = *v326;
                                            let v327: i32 = *v327;
                                            let v328: i32 = *v328;
                                            let mut v329: i32 = *v329;
                                            v323.clone()
                                        }
                                    }
                                }
                                US13::US13_Ok(v236, v237, v238, v239, v240, v241) => {
                                    let mut v236: Rc<str> = v236.clone();
                                    let v237: i32 = *v237;
                                    let v238: i32 = *v238;
                                    let v239: i32 = *v239;
                                    let v240: i32 = *v240;
                                    let v241: i32 = *v241;
                                    v235.clone()
                                }
                            };
                            let v453: US13 = match &v430 {
                                US13::US13_Error(v431, v432, v433, v434, v435, v436) => {
                                    let v431: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v431.clone();
                                    let v432: i32 = *v432;
                                    let v433: i32 = *v433;
                                    let v434: i32 = *v434;
                                    let v435: i32 = *v435;
                                    let v436: i32 = *v436;
                                    let v437: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    US13::US13_Ok(v437.clone(), v215, v216, v217, v218, v219)
                                }
                                US13::US13_Ok(v439, v440, v441, v442, v443, v444) => {
                                    let v439: Rc<str> = v439.clone();
                                    let v440: i32 = *v440;
                                    let v441: i32 = *v441;
                                    let v442: i32 = *v442;
                                    let v443: i32 = *v443;
                                    let v444: i32 = *v444;
                                    let v445: bool = v440 == v215;
                                    if v445 {
                                        let v446: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure45();
                                        US13::US13_Error(v446.clone(), v215, v216, v217, v218, v219)
                                    } else {
                                        let v448: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                        let v449: i32 = 0i32;
                                        method81(v0.clone(), v448.clone(), v448.clone(), v439.clone(), v449, v440, v441, v442, v443, v444)
                                    }
                                }
                            };
                            match &v453 {
                                US13::US13_Error(v644, v645, v646, v647, v648, v649) => {
                                    let v644: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v644.clone();
                                    let v645: i32 = *v645;
                                    let v646: i32 = *v646;
                                    let v647: i32 = *v647;
                                    let v648: i32 = *v648;
                                    let v649: i32 = *v649;
                                    let v650: bool = v215 >= v219;
                                    let v668: US12 = if v650 {
                                        let v651: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US12::US12_Error(v651.clone(), v215, v216, v217, v218, v219)
                                    } else {
                                        let v653: u8 = v0.clone().as_bytes()[v215 as usize];
                                        let mut v654: bool = v653 == b'\\';
                                        if v654 {
                                            let v655: i32 = v215.wrapping_add(1i32);
                                            let v656: bool = b'\n' == v653;
                                            let (mut v660, mut v661, mut v662, mut v663): (i32, i32, i32, i32) = if v656 {
                                                let mut v657: i32 = v216.wrapping_add(v218);
                                                let v658: i32 = v217.wrapping_add(1i32);
                                                (v657, v658, 1i32, v219)
                                            } else {
                                                let v659: i32 = v218.wrapping_add(1i32);
                                                (v216, v217, v659, v219)
                                            };
                                            US12::US12_Ok(b'\\', v655, v660, v661, v662, v663)
                                        } else {
                                            let v665: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                            US12::US12_Error(v665.clone(), v215, v216, v217, v218, v219)
                                        }
                                    };
                                    let v702: US12 = match &v668 {
                                        US12::US12_Error(v694, v695, v696, v697, v698, v699) => {
                                            let v694: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v694.clone();
                                            let v695: i32 = *v695;
                                            let v696: i32 = *v696;
                                            let v697: i32 = *v697;
                                            let v698: i32 = *v698;
                                            let v699: i32 = *v699;
                                            US12::US12_Error(v694.clone(), v695, v696, v697, v698, v699)
                                        }
                                        US12::US12_Ok(v669, v670, v671, v672, v673, v674) => {
                                            let v669: u8 = *v669;
                                            let v670: i32 = *v670;
                                            let v671: i32 = *v671;
                                            let v672: i32 = *v672;
                                            let v673: i32 = *v673;
                                            let v674: i32 = *v674;
                                            let v675: bool = v670 >= v674;
                                            if v675 {
                                                let v676: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                                US12::US12_Error(v676.clone(), v670, v671, v672, v673, v674)
                                            } else {
                                                let v678: u8 = v0.clone().as_bytes()[v670 as usize];
                                                let v679: bool = v678 == b'"';
                                                if v679 {
                                                    let v680: i32 = v670.wrapping_add(1i32);
                                                    let v681: bool = b'\n' == v678;
                                                    let (mut v685, mut v686, mut v687, mut v688): (i32, i32, i32, i32) = if v681 {
                                                        let v682: i32 = v671.wrapping_add(v673);
                                                        let v683: i32 = v672.wrapping_add(1i32);
                                                        (v682, v683, 1i32, v674)
                                                    } else {
                                                        let v684: i32 = v673.wrapping_add(1i32);
                                                        (v671, v672, v684, v674)
                                                    };
                                                    US12::US12_Ok(b'"', v680, v685, v686, v687, v688)
                                                } else {
                                                    let v690: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                                    US12::US12_Error(v690.clone(), v670, v671, v672, v673, v674)
                                                }
                                            }
                                        }
                                    };
                                    let v718: US12 = match &v702 {
                                        US12::US12_Error(v710, v711, v712, v713, v714, v715) => {
                                            let v710: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v710.clone();
                                            let v711: i32 = *v711;
                                            let v712: i32 = *v712;
                                            let v713: i32 = *v713;
                                            let v714: i32 = *v714;
                                            let v715: i32 = *v715;
                                            US12::US12_Error(v710.clone(), v711, v712, v713, v714, v715)
                                        }
                                        US12::US12_Ok(v703, v704, v705, v706, v707, v708) => {
                                            let v703: u8 = *v703;
                                            let v704: i32 = *v704;
                                            let v705: i32 = *v705;
                                            let v706: i32 = *v706;
                                            let v707: i32 = *v707;
                                            let v708: i32 = *v708;
                                            US12::US12_Ok(b'"', v704, v705, v706, v707, v708)
                                        }
                                    };
                                    let v816: US12 = match &v718 {
                                        US12::US12_Error(v725, v726, v727, v728, v729, v730) => {
                                            let v725: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v725.clone();
                                            let v726: i32 = *v726;
                                            let v727: i32 = *v727;
                                            let v728: i32 = *v728;
                                            let v729: i32 = *v729;
                                            let v730: i32 = *v730;
                                            let v748: US12 = if v650 {
                                                let v731: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                                US12::US12_Error(v731.clone(), v215, v216, v217, v218, v219)
                                            } else {
                                                let mut v733: u8 = v0.clone().as_bytes()[v215 as usize];
                                                let v734: bool = v733 == b'`';
                                                if v734 {
                                                    let v735: i32 = v215.wrapping_add(1i32);
                                                    let mut v736: bool = b'\n' == v733;
                                                    let (mut v740, mut v741, mut v742, mut v743): (i32, i32, i32, i32) = if v736 {
                                                        let v737: i32 = v216.wrapping_add(v218);
                                                        let v738: i32 = v217.wrapping_add(1i32);
                                                        (v737, v738, 1i32, v219)
                                                    } else {
                                                        let v739: i32 = v218.wrapping_add(1i32);
                                                        (v216, v217, v739, v219)
                                                    };
                                                    US12::US12_Ok(b'`', v735, v740, v741, v742, v743)
                                                } else {
                                                    let v745: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                    US12::US12_Error(v745.clone(), v215, v216, v217, v218, v219)
                                                }
                                            };
                                            let v782: US12 = match &v748 {
                                                US12::US12_Error(v774, v775, v776, v777, v778, v779) => {
                                                    let v774: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v774.clone();
                                                    let v775: i32 = *v775;
                                                    let v776: i32 = *v776;
                                                    let v777: i32 = *v777;
                                                    let v778: i32 = *v778;
                                                    let v779: i32 = *v779;
                                                    US12::US12_Error(v774.clone(), v775, v776, v777, v778, v779)
                                                }
                                                US12::US12_Ok(v749, v750, v751, v752, v753, v754) => {
                                                    let v749: u8 = *v749;
                                                    let v750: i32 = *v750;
                                                    let v751: i32 = *v751;
                                                    let v752: i32 = *v752;
                                                    let v753: i32 = *v753;
                                                    let v754: i32 = *v754;
                                                    let v755: bool = v750 >= v754;
                                                    if v755 {
                                                        let v756: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                                        US12::US12_Error(v756.clone(), v750, v751, v752, v753, v754)
                                                    } else {
                                                        let v758: u8 = v0.clone().as_bytes()[v750 as usize];
                                                        let v759: bool = v758 == b'"';
                                                        if v759 {
                                                            let v760: i32 = v750.wrapping_add(1i32);
                                                            let v761: bool = b'\n' == v758;
                                                            let (mut v765, mut v766, mut v767, mut v768): (i32, i32, i32, i32) = if v761 {
                                                                let v762: i32 = v751.wrapping_add(v753);
                                                                let v763: i32 = v752.wrapping_add(1i32);
                                                                (v762, v763, 1i32, v754)
                                                            } else {
                                                                let mut v764: i32 = v753.wrapping_add(1i32);
                                                                (v751, v752, v764, v754)
                                                            };
                                                            US12::US12_Ok(b'"', v760, v765, v766, v767, v768)
                                                        } else {
                                                            let v770: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                                            US12::US12_Error(v770.clone(), v750, v751, v752, v753, v754)
                                                        }
                                                    }
                                                }
                                            };
                                            let v798: US12 = match &v782 {
                                                US12::US12_Error(v790, v791, v792, v793, v794, v795) => {
                                                    let v790: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v790.clone();
                                                    let v791: i32 = *v791;
                                                    let v792: i32 = *v792;
                                                    let v793: i32 = *v793;
                                                    let v794: i32 = *v794;
                                                    let v795: i32 = *v795;
                                                    US12::US12_Error(v790.clone(), v791, v792, v793, v794, v795)
                                                }
                                                US12::US12_Ok(v783, v784, v785, v786, v787, v788) => {
                                                    let v783: u8 = *v783;
                                                    let v784: i32 = *v784;
                                                    let v785: i32 = *v785;
                                                    let v786: i32 = *v786;
                                                    let v787: i32 = *v787;
                                                    let v788: i32 = *v788;
                                                    US12::US12_Ok(b'"', v784, v785, v786, v787, v788)
                                                }
                                            };
                                            match &v798 {
                                                US12::US12_Error(v805, v806, v807, v808, v809, v810) => {
                                                    let v805: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v805.clone();
                                                    let v806: i32 = *v806;
                                                    let v807: i32 = *v807;
                                                    let v808: i32 = *v808;
                                                    let v809: i32 = *v809;
                                                    let v810: i32 = *v810;
                                                    let v811: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                                    US12::US12_Error(v811.clone(), v215, v216, v217, v218, v219)
                                                }
                                                US12::US12_Ok(v799, v800, v801, v802, v803, v804) => {
                                                    let v799: u8 = *v799;
                                                    let v800: i32 = *v800;
                                                    let v801: i32 = *v801;
                                                    let v802: i32 = *v802;
                                                    let v803: i32 = *v803;
                                                    let v804: i32 = *v804;
                                                    v798.clone()
                                                }
                                            }
                                        }
                                        US12::US12_Ok(v719, v720, v721, v722, v723, v724) => {
                                            let v719: u8 = *v719;
                                            let v720: i32 = *v720;
                                            let v721: i32 = *v721;
                                            let v722: i32 = *v722;
                                            let v723: i32 = *v723;
                                            let v724: i32 = *v724;
                                            v718.clone()
                                        }
                                    };
                                    match &v816 {
                                        US12::US12_Error(v825, v826, v827, v828, v829, v830) => {
                                            let v825: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v825.clone();
                                            let v826: i32 = *v826;
                                            let v827: i32 = *v827;
                                            let v828: i32 = *v828;
                                            let v829: i32 = *v829;
                                            let v830: i32 = *v830;
                                            let v831: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                                            US13::US13_Error(v831.clone(), v215, v216, v217, v218, v219)
                                        }
                                        US12::US12_Ok(v817, v818, v819, v820, v821, v822) => {
                                            let v817: u8 = *v817;
                                            let v818: i32 = *v818;
                                            let v819: i32 = *v819;
                                            let v820: i32 = *v820;
                                            let v821: i32 = *v821;
                                            let v822: i32 = *v822;
                                            let v823: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            US13::US13_Ok(v823.clone(), v818, v819, v820, v821, v822)
                                        }
                                    }
                                }
                                US13::US13_Ok(v454, v455, v456, v457, v458, v459) => {
                                    let v454: Rc<str> = v454.clone();
                                    let v455: i32 = *v455;
                                    let v456: i32 = *v456;
                                    let v457: i32 = *v457;
                                    let v458: i32 = *v458;
                                    let v459: i32 = *v459;
                                    let v460: bool = v455 >= v459;
                                    let v478: US12 = if v460 {
                                        let v461: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US12::US12_Error(v461.clone(), v455, v456, v457, v458, v459)
                                    } else {
                                        let v463: u8 = v0.clone().as_bytes()[v455 as usize];
                                        let v464: bool = v463 == b'\\';
                                        if v464 {
                                            let v465: i32 = v455.wrapping_add(1i32);
                                            let v466: bool = b'\n' == v463;
                                            let (mut v470, mut v471, mut v472, mut v473): (i32, i32, i32, i32) = if v466 {
                                                let v467: i32 = v456.wrapping_add(v458);
                                                let v468: i32 = v457.wrapping_add(1i32);
                                                (v467, v468, 1i32, v459)
                                            } else {
                                                let v469: i32 = v458.wrapping_add(1i32);
                                                (v456, v457, v469, v459)
                                            };
                                            US12::US12_Ok(b'\\', v465, v470, v471, v472, v473)
                                        } else {
                                            let v475: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                            US12::US12_Error(v475.clone(), v455, v456, v457, v458, v459)
                                        }
                                    };
                                    let v512: US12 = match &v478 {
                                        US12::US12_Error(v504, v505, v506, v507, v508, v509) => {
                                            let v504: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v504.clone();
                                            let v505: i32 = *v505;
                                            let v506: i32 = *v506;
                                            let v507: i32 = *v507;
                                            let v508: i32 = *v508;
                                            let v509: i32 = *v509;
                                            US12::US12_Error(v504.clone(), v505, v506, v507, v508, v509)
                                        }
                                        US12::US12_Ok(v479, v480, v481, v482, v483, v484) => {
                                            let v479: u8 = *v479;
                                            let v480: i32 = *v480;
                                            let v481: i32 = *v481;
                                            let v482: i32 = *v482;
                                            let v483: i32 = *v483;
                                            let v484: i32 = *v484;
                                            let v485: bool = v480 >= v484;
                                            if v485 {
                                                let v486: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                                US12::US12_Error(v486.clone(), v480, v481, v482, v483, v484)
                                            } else {
                                                let v488: u8 = v0.clone().as_bytes()[v480 as usize];
                                                let v489: bool = v488 == b'"';
                                                if v489 {
                                                    let v490: i32 = v480.wrapping_add(1i32);
                                                    let v491: bool = b'\n' == v488;
                                                    let (mut v495, mut v496, mut v497, mut v498): (i32, i32, i32, i32) = if v491 {
                                                        let mut v492: i32 = v481.wrapping_add(v483);
                                                        let v493: i32 = v482.wrapping_add(1i32);
                                                        (v492, v493, 1i32, v484)
                                                    } else {
                                                        let v494: i32 = v483.wrapping_add(1i32);
                                                        (v481, v482, v494, v484)
                                                    };
                                                    US12::US12_Ok(b'"', v490, v495, v496, v497, v498)
                                                } else {
                                                    let v500: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                                    US12::US12_Error(v500.clone(), v480, v481, v482, v483, v484)
                                                }
                                            }
                                        }
                                    };
                                    let v528: US12 = match &v512 {
                                        US12::US12_Error(v520, v521, v522, v523, v524, v525) => {
                                            let v520: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v520.clone();
                                            let v521: i32 = *v521;
                                            let v522: i32 = *v522;
                                            let mut v523: i32 = *v523;
                                            let v524: i32 = *v524;
                                            let v525: i32 = *v525;
                                            US12::US12_Error(v520.clone(), v521, v522, v523, v524, v525)
                                        }
                                        US12::US12_Ok(v513, v514, v515, v516, v517, v518) => {
                                            let v513: u8 = *v513;
                                            let v514: i32 = *v514;
                                            let v515: i32 = *v515;
                                            let v516: i32 = *v516;
                                            let v517: i32 = *v517;
                                            let v518: i32 = *v518;
                                            US12::US12_Ok(b'"', v514, v515, v516, v517, v518)
                                        }
                                    };
                                    let v626: US12 = match &v528 {
                                        US12::US12_Error(v535, v536, v537, v538, v539, v540) => {
                                            let v535: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v535.clone();
                                            let v536: i32 = *v536;
                                            let v537: i32 = *v537;
                                            let v538: i32 = *v538;
                                            let v539: i32 = *v539;
                                            let v540: i32 = *v540;
                                            let v558: US12 = if v460 {
                                                let v541: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                                US12::US12_Error(v541.clone(), v455, v456, v457, v458, v459)
                                            } else {
                                                let v543: u8 = v0.clone().as_bytes()[v455 as usize];
                                                let v544: bool = v543 == b'`';
                                                if v544 {
                                                    let v545: i32 = v455.wrapping_add(1i32);
                                                    let v546: bool = b'\n' == v543;
                                                    let (mut v550, mut v551, mut v552, mut v553): (i32, i32, i32, i32) = if v546 {
                                                        let v547: i32 = v456.wrapping_add(v458);
                                                        let v548: i32 = v457.wrapping_add(1i32);
                                                        (v547, v548, 1i32, v459)
                                                    } else {
                                                        let v549: i32 = v458.wrapping_add(1i32);
                                                        (v456, v457, v549, v459)
                                                    };
                                                    US12::US12_Ok(b'`', v545, v550, v551, v552, v553)
                                                } else {
                                                    let v555: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                    US12::US12_Error(v555.clone(), v455, v456, v457, v458, v459)
                                                }
                                            };
                                            let v592: US12 = match &v558 {
                                                US12::US12_Error(v584, v585, v586, v587, v588, v589) => {
                                                    let v584: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v584.clone();
                                                    let v585: i32 = *v585;
                                                    let v586: i32 = *v586;
                                                    let v587: i32 = *v587;
                                                    let v588: i32 = *v588;
                                                    let v589: i32 = *v589;
                                                    US12::US12_Error(v584.clone(), v585, v586, v587, v588, v589)
                                                }
                                                US12::US12_Ok(v559, v560, v561, v562, v563, v564) => {
                                                    let v559: u8 = *v559;
                                                    let v560: i32 = *v560;
                                                    let v561: i32 = *v561;
                                                    let v562: i32 = *v562;
                                                    let v563: i32 = *v563;
                                                    let v564: i32 = *v564;
                                                    let v565: bool = v560 >= v564;
                                                    if v565 {
                                                        let v566: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                                        US12::US12_Error(v566.clone(), v560, v561, v562, v563, v564)
                                                    } else {
                                                        let v568: u8 = v0.clone().as_bytes()[v560 as usize];
                                                        let v569: bool = v568 == b'"';
                                                        if v569 {
                                                            let v570: i32 = v560.wrapping_add(1i32);
                                                            let mut v571: bool = b'\n' == v568;
                                                            let (mut v575, mut v576, mut v577, mut v578): (i32, i32, i32, i32) = if v571 {
                                                                let mut v572: i32 = v561.wrapping_add(v563);
                                                                let v573: i32 = v562.wrapping_add(1i32);
                                                                (v572, v573, 1i32, v564)
                                                            } else {
                                                                let mut v574: i32 = v563.wrapping_add(1i32);
                                                                (v561, v562, v574, v564)
                                                            };
                                                            US12::US12_Ok(b'"', v570, v575, v576, v577, v578)
                                                        } else {
                                                            let mut v580: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                                            US12::US12_Error(v580.clone(), v560, v561, v562, v563, v564)
                                                        }
                                                    }
                                                }
                                            };
                                            let v608: US12 = match &v592 {
                                                US12::US12_Error(v600, v601, v602, v603, v604, v605) => {
                                                    let v600: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v600.clone();
                                                    let v601: i32 = *v601;
                                                    let v602: i32 = *v602;
                                                    let v603: i32 = *v603;
                                                    let v604: i32 = *v604;
                                                    let mut v605: i32 = *v605;
                                                    US12::US12_Error(v600.clone(), v601, v602, v603, v604, v605)
                                                }
                                                US12::US12_Ok(v593, v594, v595, v596, v597, v598) => {
                                                    let v593: u8 = *v593;
                                                    let mut v594: i32 = *v594;
                                                    let v595: i32 = *v595;
                                                    let v596: i32 = *v596;
                                                    let v597: i32 = *v597;
                                                    let v598: i32 = *v598;
                                                    US12::US12_Ok(b'"', v594, v595, v596, v597, v598)
                                                }
                                            };
                                            match &v608 {
                                                US12::US12_Error(v615, v616, v617, v618, v619, v620) => {
                                                    let v615: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v615.clone();
                                                    let v616: i32 = *v616;
                                                    let v617: i32 = *v617;
                                                    let v618: i32 = *v618;
                                                    let v619: i32 = *v619;
                                                    let v620: i32 = *v620;
                                                    let v621: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                                    US12::US12_Error(v621.clone(), v455, v456, v457, v458, v459)
                                                }
                                                US12::US12_Ok(v609, v610, v611, v612, v613, v614) => {
                                                    let v609: u8 = *v609;
                                                    let v610: i32 = *v610;
                                                    let v611: i32 = *v611;
                                                    let v612: i32 = *v612;
                                                    let v613: i32 = *v613;
                                                    let v614: i32 = *v614;
                                                    v608.clone()
                                                }
                                            }
                                        }
                                        US12::US12_Ok(v529, v530, v531, v532, v533, v534) => {
                                            let v529: u8 = *v529;
                                            let v530: i32 = *v530;
                                            let v531: i32 = *v531;
                                            let v532: i32 = *v532;
                                            let v533: i32 = *v533;
                                            let v534: i32 = *v534;
                                            v528.clone()
                                        }
                                    };
                                    match &v626 {
                                        US12::US12_Error(v634, v635, v636, v637, v638, v639) => {
                                            let v634: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v634.clone();
                                            let v635: i32 = *v635;
                                            let v636: i32 = *v636;
                                            let v637: i32 = *v637;
                                            let v638: i32 = *v638;
                                            let v639: i32 = *v639;
                                            let v640: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28(v215, v455, v634.clone(), v635, v636, v637, v638, v639);
                                            US13::US13_Error(v640.clone(), v455, v456, v457, v458, v459)
                                        }
                                        US12::US12_Ok(v627, v628, v629, v630, v631, v632) => {
                                            let v627: u8 = *v627;
                                            let v628: i32 = *v628;
                                            let v629: i32 = *v629;
                                            let v630: i32 = *v630;
                                            let v631: i32 = *v631;
                                            let v632: i32 = *v632;
                                            US13::US13_Ok(v454.clone(), v628, v629, v630, v631, v632)
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v1203: US13 = match &v845 {
                        US13::US13_Error(v852, v853, v854, v855, v856, v857) => {
                            let v852: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v852.clone();
                            let v853: i32 = *v853;
                            let v854: i32 = *v854;
                            let v855: i32 = *v855;
                            let v856: i32 = *v856;
                            let v857: i32 = *v857;
                            let v875: US12 = if v47 {
                                let v858: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US12::US12_Error(v858.clone(), v39, v40, v41, v42, v43)
                            } else {
                                let v860: u8 = v0.clone().as_bytes()[v39 as usize];
                                let v861: bool = v860 == b'"';
                                if v861 {
                                    let v862: i32 = v39.wrapping_add(1i32);
                                    let v863: bool = b'\n' == v860;
                                    let (mut v867, mut v868, mut v869, mut v870): (i32, i32, i32, i32) = if v863 {
                                        let v864: i32 = v40.wrapping_add(v42);
                                        let v865: i32 = v41.wrapping_add(1i32);
                                        (v864, v865, 1i32, v43)
                                    } else {
                                        let v866: i32 = v42.wrapping_add(1i32);
                                        (v40, v41, v866, v43)
                                    };
                                    US12::US12_Ok(b'"', v862, v867, v868, v869, v870)
                                } else {
                                    let v872: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US12::US12_Error(v872.clone(), v39, v40, v41, v42, v43)
                                }
                            };
                            match &v875 {
                                US12::US12_Error(v1193, v1194, v1195, v1196, v1197, v1198) => {
                                    let v1193: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1193.clone();
                                    let v1194: i32 = *v1194;
                                    let v1195: i32 = *v1195;
                                    let v1196: i32 = *v1196;
                                    let v1197: i32 = *v1197;
                                    let v1198: i32 = *v1198;
                                    US13::US13_Error(v1193.clone(), v1194, v1195, v1196, v1197, v1198)
                                }
                                US12::US12_Ok(v876, v877, v878, v879, v880, v881) => {
                                    let v876: u8 = *v876;
                                    let v877: i32 = *v877;
                                    let v878: i32 = *v878;
                                    let v879: i32 = *v879;
                                    let v880: i32 = *v880;
                                    let v881: i32 = *v881;
                                    let (mut v882, mut v883, mut v884, mut v885, mut v886): (i32, i32, i32, i32, i32) = method80(v878, v879, v880, v881, v0.clone(), v877, v878, v879, v880, v881);
                                    let v887: bool = v882 > v877;
                                    let v897: US13 = if v887 {
                                        let v888: bool = v877 >= v882;
                                        let v893: Rc<str> = if v888 {
                                            let v889: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            v889.clone()
                                        } else {
                                            let mut v891: i32 = v882.wrapping_sub(1i32);
                                            let v892: Rc<str> = string_slice(&v0.clone(), v877 as i64, v891 as i64);
                                            v892.clone()
                                        };
                                        US13::US13_Ok(v893.clone(), v882, v883, v884, v885, v886)
                                    } else {
                                        let v895: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                        US13::US13_Error(v895.clone(), v877, v878, v879, v880, v881)
                                    };
                                    let v1082: US13 = match &v897 {
                                        US13::US13_Error(v904, v905, v906, v907, v908, v909) => {
                                            let v904: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v904.clone();
                                            let v905: i32 = *v905;
                                            let v906: i32 = *v906;
                                            let v907: i32 = *v907;
                                            let v908: i32 = *v908;
                                            let v909: i32 = *v909;
                                            let v910: bool = v877 >= v881;
                                            let v928: US12 = if v910 {
                                                let v911: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                US12::US12_Error(v911.clone(), v877, v878, v879, v880, v881)
                                            } else {
                                                let v913: u8 = v0.clone().as_bytes()[v877 as usize];
                                                let v914: bool = v913 == b'\\';
                                                if v914 {
                                                    let v915: i32 = v877.wrapping_add(1i32);
                                                    let v916: bool = b'\n' == v913;
                                                    let (mut v920, mut v921, mut v922, mut v923): (i32, i32, i32, i32) = if v916 {
                                                        let v917: i32 = v878.wrapping_add(v880);
                                                        let v918: i32 = v879.wrapping_add(1i32);
                                                        (v917, v918, 1i32, v881)
                                                    } else {
                                                        let v919: i32 = v880.wrapping_add(1i32);
                                                        (v878, v879, v919, v881)
                                                    };
                                                    US12::US12_Ok(b'\\', v915, v920, v921, v922, v923)
                                                } else {
                                                    let v925: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                                    US12::US12_Error(v925.clone(), v877, v878, v879, v880, v881)
                                                }
                                            };
                                            let v958: US12 = match &v928 {
                                                US12::US12_Error(v950, v951, v952, v953, v954, v955) => {
                                                    let v950: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v950.clone();
                                                    let v951: i32 = *v951;
                                                    let v952: i32 = *v952;
                                                    let v953: i32 = *v953;
                                                    let v954: i32 = *v954;
                                                    let v955: i32 = *v955;
                                                    US12::US12_Error(v950.clone(), v951, v952, v953, v954, v955)
                                                }
                                                US12::US12_Ok(v929, v930, v931, v932, v933, v934) => {
                                                    let v929: u8 = *v929;
                                                    let v930: i32 = *v930;
                                                    let v931: i32 = *v931;
                                                    let v932: i32 = *v932;
                                                    let v933: i32 = *v933;
                                                    let v934: i32 = *v934;
                                                    let v935: bool = v930 >= v934;
                                                    if v935 {
                                                        let v936: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                                                        US12::US12_Error(v936.clone(), v930, v931, v932, v933, v934)
                                                    } else {
                                                        let v938: u8 = v0.clone().as_bytes()[v930 as usize];
                                                        let v939: i32 = v930.wrapping_add(1i32);
                                                        let v940: bool = b'\n' == v938;
                                                        let (mut v944, mut v945, mut v946, mut v947): (i32, i32, i32, i32) = if v940 {
                                                            let v941: i32 = v931.wrapping_add(v933);
                                                            let v942: i32 = v932.wrapping_add(1i32);
                                                            (v941, v942, 1i32, v934)
                                                        } else {
                                                            let v943: i32 = v933.wrapping_add(1i32);
                                                            (v931, v932, v943, v934)
                                                        };
                                                        US12::US12_Ok(v938, v939, v944, v945, v946, v947)
                                                    }
                                                }
                                            };
                                            let v980: US13 = match &v958 {
                                                US12::US12_Error(v972, v973, v974, v975, v976, v977) => {
                                                    let v972: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v972.clone();
                                                    let mut v973: i32 = *v973;
                                                    let v974: i32 = *v974;
                                                    let v975: i32 = *v975;
                                                    let v976: i32 = *v976;
                                                    let v977: i32 = *v977;
                                                    US13::US13_Error(v972.clone(), v973, v974, v975, v976, v977)
                                                }
                                                US12::US12_Ok(v959, v960, v961, v962, v963, v964) => {
                                                    let v959: u8 = *v959;
                                                    let v960: i32 = *v960;
                                                    let v961: i32 = *v961;
                                                    let v962: i32 = *v962;
                                                    let v963: i32 = *v963;
                                                    let v964: i32 = *v964;
                                                    let v965: bool = v877 >= v960;
                                                    let mut v970: Rc<str> = if v965 {
                                                        let v966: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                        v966.clone()
                                                    } else {
                                                        let v968: i32 = v960.wrapping_sub(1i32);
                                                        let v969: Rc<str> = string_slice(&v0.clone(), v877 as i64, v968 as i64);
                                                        v969.clone()
                                                    };
                                                    US13::US13_Ok(v970.clone(), v960, v961, v962, v963, v964)
                                                }
                                            };
                                            match &v980 {
                                                US13::US13_Error(v987, v988, v989, v990, v991, v992) => {
                                                    let v987: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v987.clone();
                                                    let v988: i32 = *v988;
                                                    let v989: i32 = *v989;
                                                    let v990: i32 = *v990;
                                                    let v991: i32 = *v991;
                                                    let v992: i32 = *v992;
                                                    let v1010: US12 = if v910 {
                                                        let v993: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                                        US12::US12_Error(v993.clone(), v877, v878, v879, v880, v881)
                                                    } else {
                                                        let v995: u8 = v0.clone().as_bytes()[v877 as usize];
                                                        let v996: bool = v995 == b'`';
                                                        if v996 {
                                                            let v997: i32 = v877.wrapping_add(1i32);
                                                            let v998: bool = b'\n' == v995;
                                                            let (mut v1002, mut v1003, mut v1004, mut v1005): (i32, i32, i32, i32) = if v998 {
                                                                let v999: i32 = v878.wrapping_add(v880);
                                                                let v1000: i32 = v879.wrapping_add(1i32);
                                                                (v999, v1000, 1i32, v881)
                                                            } else {
                                                                let mut v1001: i32 = v880.wrapping_add(1i32);
                                                                (v878, v879, v1001, v881)
                                                            };
                                                            US12::US12_Ok(b'`', v997, v1002, v1003, v1004, v1005)
                                                        } else {
                                                            let v1007: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                            US12::US12_Error(v1007.clone(), v877, v878, v879, v880, v881)
                                                        }
                                                    };
                                                    let v1040: US12 = match &v1010 {
                                                        US12::US12_Error(v1032, v1033, v1034, v1035, v1036, v1037) => {
                                                            let v1032: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1032.clone();
                                                            let v1033: i32 = *v1033;
                                                            let v1034: i32 = *v1034;
                                                            let v1035: i32 = *v1035;
                                                            let v1036: i32 = *v1036;
                                                            let mut v1037: i32 = *v1037;
                                                            US12::US12_Error(v1032.clone(), v1033, v1034, v1035, v1036, v1037)
                                                        }
                                                        US12::US12_Ok(v1011, v1012, v1013, v1014, v1015, v1016) => {
                                                            let v1011: u8 = *v1011;
                                                            let v1012: i32 = *v1012;
                                                            let v1013: i32 = *v1013;
                                                            let v1014: i32 = *v1014;
                                                            let v1015: i32 = *v1015;
                                                            let v1016: i32 = *v1016;
                                                            let v1017: bool = v1012 >= v1016;
                                                            if v1017 {
                                                                let v1018: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                                                                US12::US12_Error(v1018.clone(), v1012, v1013, v1014, v1015, v1016)
                                                            } else {
                                                                let v1020: u8 = v0.clone().as_bytes()[v1012 as usize];
                                                                let v1021: i32 = v1012.wrapping_add(1i32);
                                                                let v1022: bool = b'\n' == v1020;
                                                                let (mut v1026, mut v1027, mut v1028, mut v1029): (i32, i32, i32, i32) = if v1022 {
                                                                    let v1023: i32 = v1013.wrapping_add(v1015);
                                                                    let v1024: i32 = v1014.wrapping_add(1i32);
                                                                    (v1023, v1024, 1i32, v1016)
                                                                } else {
                                                                    let v1025: i32 = v1015.wrapping_add(1i32);
                                                                    (v1013, v1014, v1025, v1016)
                                                                };
                                                                US12::US12_Ok(v1020, v1021, v1026, v1027, v1028, v1029)
                                                            }
                                                        }
                                                    };
                                                    let v1062: US13 = match &v1040 {
                                                        US12::US12_Error(v1054, v1055, v1056, v1057, v1058, v1059) => {
                                                            let v1054: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1054.clone();
                                                            let v1055: i32 = *v1055;
                                                            let v1056: i32 = *v1056;
                                                            let v1057: i32 = *v1057;
                                                            let v1058: i32 = *v1058;
                                                            let v1059: i32 = *v1059;
                                                            US13::US13_Error(v1054.clone(), v1055, v1056, v1057, v1058, v1059)
                                                        }
                                                        US12::US12_Ok(v1041, v1042, v1043, v1044, v1045, v1046) => {
                                                            let v1041: u8 = *v1041;
                                                            let v1042: i32 = *v1042;
                                                            let v1043: i32 = *v1043;
                                                            let v1044: i32 = *v1044;
                                                            let v1045: i32 = *v1045;
                                                            let v1046: i32 = *v1046;
                                                            let v1047: bool = v877 >= v1042;
                                                            let v1052: Rc<str> = if v1047 {
                                                                let v1048: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                                v1048.clone()
                                                            } else {
                                                                let v1050: i32 = v1042.wrapping_sub(1i32);
                                                                let v1051: Rc<str> = string_slice(&v0.clone(), v877 as i64, v1050 as i64);
                                                                v1051.clone()
                                                            };
                                                            US13::US13_Ok(v1052.clone(), v1042, v1043, v1044, v1045, v1046)
                                                        }
                                                    };
                                                    match &v1062 {
                                                        US13::US13_Error(v1069, v1070, v1071, v1072, v1073, v1074) => {
                                                            let v1069: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1069.clone();
                                                            let v1070: i32 = *v1070;
                                                            let v1071: i32 = *v1071;
                                                            let v1072: i32 = *v1072;
                                                            let v1073: i32 = *v1073;
                                                            let v1074: i32 = *v1074;
                                                            let v1075: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                                            US13::US13_Error(v1075.clone(), v877, v878, v879, v880, v881)
                                                        }
                                                        US13::US13_Ok(v1063, v1064, v1065, v1066, v1067, v1068) => {
                                                            let v1063: Rc<str> = v1063.clone();
                                                            let v1064: i32 = *v1064;
                                                            let v1065: i32 = *v1065;
                                                            let v1066: i32 = *v1066;
                                                            let v1067: i32 = *v1067;
                                                            let v1068: i32 = *v1068;
                                                            v1062.clone()
                                                        }
                                                    }
                                                }
                                                US13::US13_Ok(v981, v982, v983, v984, v985, v986) => {
                                                    let v981: Rc<str> = v981.clone();
                                                    let v982: i32 = *v982;
                                                    let v983: i32 = *v983;
                                                    let v984: i32 = *v984;
                                                    let v985: i32 = *v985;
                                                    let v986: i32 = *v986;
                                                    v980.clone()
                                                }
                                            }
                                        }
                                        US13::US13_Ok(v898, v899, v900, v901, v902, v903) => {
                                            let v898: Rc<str> = v898.clone();
                                            let v899: i32 = *v899;
                                            let v900: i32 = *v900;
                                            let v901: i32 = *v901;
                                            let v902: i32 = *v902;
                                            let v903: i32 = *v903;
                                            v897.clone()
                                        }
                                    };
                                    let v1105: US13 = match &v1082 {
                                        US13::US13_Error(v1083, v1084, v1085, v1086, v1087, v1088) => {
                                            let v1083: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1083.clone();
                                            let v1084: i32 = *v1084;
                                            let v1085: i32 = *v1085;
                                            let v1086: i32 = *v1086;
                                            let v1087: i32 = *v1087;
                                            let v1088: i32 = *v1088;
                                            let v1089: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            US13::US13_Ok(v1089.clone(), v877, v878, v879, v880, v881)
                                        }
                                        US13::US13_Ok(v1091, v1092, v1093, v1094, v1095, v1096) => {
                                            let v1091: Rc<str> = v1091.clone();
                                            let v1092: i32 = *v1092;
                                            let v1093: i32 = *v1093;
                                            let v1094: i32 = *v1094;
                                            let v1095: i32 = *v1095;
                                            let v1096: i32 = *v1096;
                                            let v1097: bool = v1092 == v877;
                                            if v1097 {
                                                let v1098: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure45();
                                                US13::US13_Error(v1098.clone(), v877, v878, v879, v880, v881)
                                            } else {
                                                let v1100: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                                let v1101: i32 = 0i32;
                                                method82(v0.clone(), v1100.clone(), v1100.clone(), v1091.clone(), v1101, v1092, v1093, v1094, v1095, v1096)
                                            }
                                        }
                                    };
                                    match &v1105 {
                                        US13::US13_Error(v1148, v1149, v1150, v1151, v1152, v1153) => {
                                            let v1148: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1148.clone();
                                            let v1149: i32 = *v1149;
                                            let v1150: i32 = *v1150;
                                            let v1151: i32 = *v1151;
                                            let v1152: i32 = *v1152;
                                            let v1153: i32 = *v1153;
                                            let v1154: bool = v877 >= v881;
                                            let v1172: US12 = if v1154 {
                                                let v1155: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                                US12::US12_Error(v1155.clone(), v877, v878, v879, v880, v881)
                                            } else {
                                                let v1157: u8 = v0.clone().as_bytes()[v877 as usize];
                                                let v1158: bool = v1157 == b'"';
                                                if v1158 {
                                                    let v1159: i32 = v877.wrapping_add(1i32);
                                                    let v1160: bool = b'\n' == v1157;
                                                    let (mut v1164, mut v1165, mut v1166, mut v1167): (i32, i32, i32, i32) = if v1160 {
                                                        let v1161: i32 = v878.wrapping_add(v880);
                                                        let v1162: i32 = v879.wrapping_add(1i32);
                                                        (v1161, v1162, 1i32, v881)
                                                    } else {
                                                        let v1163: i32 = v880.wrapping_add(1i32);
                                                        (v878, v879, v1163, v881)
                                                    };
                                                    US12::US12_Ok(b'"', v1159, v1164, v1165, v1166, v1167)
                                                } else {
                                                    let v1169: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                                    US12::US12_Error(v1169.clone(), v877, v878, v879, v880, v881)
                                                }
                                            };
                                            match &v1172 {
                                                US12::US12_Error(v1181, v1182, v1183, v1184, v1185, v1186) => {
                                                    let v1181: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1181.clone();
                                                    let v1182: i32 = *v1182;
                                                    let v1183: i32 = *v1183;
                                                    let v1184: i32 = *v1184;
                                                    let v1185: i32 = *v1185;
                                                    let v1186: i32 = *v1186;
                                                    let v1187: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                                                    US13::US13_Error(v1187.clone(), v877, v878, v879, v880, v881)
                                                }
                                                US12::US12_Ok(v1173, v1174, v1175, v1176, v1177, v1178) => {
                                                    let v1173: u8 = *v1173;
                                                    let v1174: i32 = *v1174;
                                                    let v1175: i32 = *v1175;
                                                    let v1176: i32 = *v1176;
                                                    let v1177: i32 = *v1177;
                                                    let v1178: i32 = *v1178;
                                                    let v1179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                    US13::US13_Ok(v1179.clone(), v1174, v1175, v1176, v1177, v1178)
                                                }
                                            }
                                        }
                                        US13::US13_Ok(v1106, v1107, v1108, v1109, v1110, v1111) => {
                                            let v1106: Rc<str> = v1106.clone();
                                            let v1107: i32 = *v1107;
                                            let v1108: i32 = *v1108;
                                            let v1109: i32 = *v1109;
                                            let v1110: i32 = *v1110;
                                            let v1111: i32 = *v1111;
                                            let v1112: bool = v1107 >= v1111;
                                            let v1130: US12 = if v1112 {
                                                let v1113: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                                US12::US12_Error(v1113.clone(), v1107, v1108, v1109, v1110, v1111)
                                            } else {
                                                let v1115: u8 = v0.clone().as_bytes()[v1107 as usize];
                                                let v1116: bool = v1115 == b'"';
                                                if v1116 {
                                                    let v1117: i32 = v1107.wrapping_add(1i32);
                                                    let v1118: bool = b'\n' == v1115;
                                                    let (mut v1122, mut v1123, mut v1124, mut v1125): (i32, i32, i32, i32) = if v1118 {
                                                        let v1119: i32 = v1108.wrapping_add(v1110);
                                                        let v1120: i32 = v1109.wrapping_add(1i32);
                                                        (v1119, v1120, 1i32, v1111)
                                                    } else {
                                                        let v1121: i32 = v1110.wrapping_add(1i32);
                                                        (v1108, v1109, v1121, v1111)
                                                    };
                                                    US12::US12_Ok(b'"', v1117, v1122, v1123, v1124, v1125)
                                                } else {
                                                    let v1127: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                                    US12::US12_Error(v1127.clone(), v1107, v1108, v1109, v1110, v1111)
                                                }
                                            };
                                            match &v1130 {
                                                US12::US12_Error(v1138, v1139, v1140, v1141, v1142, v1143) => {
                                                    let v1138: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1138.clone();
                                                    let v1139: i32 = *v1139;
                                                    let v1140: i32 = *v1140;
                                                    let v1141: i32 = *v1141;
                                                    let v1142: i32 = *v1142;
                                                    let v1143: i32 = *v1143;
                                                    let v1144: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28(v877, v1107, v1138.clone(), v1139, v1140, v1141, v1142, v1143);
                                                    US13::US13_Error(v1144.clone(), v1107, v1108, v1109, v1110, v1111)
                                                }
                                                US12::US12_Ok(v1131, v1132, v1133, v1134, v1135, v1136) => {
                                                    let v1131: u8 = *v1131;
                                                    let v1132: i32 = *v1132;
                                                    let v1133: i32 = *v1133;
                                                    let v1134: i32 = *v1134;
                                                    let v1135: i32 = *v1135;
                                                    let v1136: i32 = *v1136;
                                                    US13::US13_Ok(v1106.clone(), v1132, v1133, v1134, v1135, v1136)
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        US13::US13_Ok(v846, v847, v848, v849, v850, v851) => {
                            let v846: Rc<str> = v846.clone();
                            let v847: i32 = *v847;
                            let v848: i32 = *v848;
                            let v849: i32 = *v849;
                            let v850: i32 = *v850;
                            let v851: i32 = *v851;
                            v845.clone()
                        }
                    };
                    let v1233: US13 = match &v1203 {
                        US13::US13_Error(v1210, v1211, v1212, v1213, v1214, v1215) => {
                            let v1210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1210.clone();
                            let v1211: i32 = *v1211;
                            let v1212: i32 = *v1212;
                            let v1213: i32 = *v1213;
                            let v1214: i32 = *v1214;
                            let v1215: i32 = *v1215;
                            let (mut v1216, mut v1217, mut v1218, mut v1219, mut v1220): (i32, i32, i32, i32, i32) = method87(v40, v41, v42, v43, v0.clone(), v39, v40, v41, v42, v43);
                            let v1221: bool = v1216 > v39;
                            if v1221 {
                                let v1222: bool = v39 >= v1216;
                                let v1227: Rc<str> = if v1222 {
                                    let v1223: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v1223.clone()
                                } else {
                                    let v1225: i32 = v1216.wrapping_sub(1i32);
                                    let v1226: Rc<str> = string_slice(&v0.clone(), v39 as i64, v1225 as i64);
                                    v1226.clone()
                                };
                                US13::US13_Ok(v1227.clone(), v1216, v1217, v1218, v1219, v1220)
                            } else {
                                let v1229: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                US13::US13_Error(v1229.clone(), v39, v40, v41, v42, v43)
                            }
                        }
                        US13::US13_Ok(v1204, v1205, v1206, v1207, v1208, v1209) => {
                            let v1204: Rc<str> = v1204.clone();
                            let v1205: i32 = *v1205;
                            let v1206: i32 = *v1206;
                            let v1207: i32 = *v1207;
                            let v1208: i32 = *v1208;
                            let v1209: i32 = *v1209;
                            v1203.clone()
                        }
                    };
                    let v1272: US13 = match &v1233 {
                        US13::US13_Error(v1240, v1241, v1242, v1243, v1244, v1245) => {
                            let v1240: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1240.clone();
                            let v1241: i32 = *v1241;
                            let v1242: i32 = *v1242;
                            let v1243: i32 = *v1243;
                            let v1244: i32 = *v1244;
                            let v1245: i32 = *v1245;
                            let v1246: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                            let v1247: US21 = method84(v0.clone(), v1246.clone(), v39, v40, v41, v42, v43);
                            match &v1247 {
                                US21::US21_Error(v1262, v1263, v1264, v1265, v1266, v1267) => {
                                    let v1262: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1262.clone();
                                    let v1263: i32 = *v1263;
                                    let v1264: i32 = *v1264;
                                    let v1265: i32 = *v1265;
                                    let v1266: i32 = *v1266;
                                    let v1267: i32 = *v1267;
                                    US13::US13_Error(v1262.clone(), v1263, v1264, v1265, v1266, v1267)
                                }
                                US21::US21_Ok(v1248, v1249, v1250, v1251, v1252, v1253) => {
                                    let v1248: Rc<UH0> = v1248.clone();
                                    let v1249: i32 = *v1249;
                                    let v1250: i32 = *v1250;
                                    let v1251: i32 = *v1251;
                                    let v1252: i32 = *v1252;
                                    let v1253: i32 = *v1253;
                                    let v1254: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
                                    let v1255: i32 = 0i32;
                                    let v1256: i32 = method3(v1254.clone(), v1248.clone(), v1255);
                                    let v1257: Rc<Vec<Rc<str>>> = Rc::new(v1254.borrow().clone());
                                    let v1258: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v1257).as_ref().clone()));
                                    let v1259: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    let v1260: Rc<str> = Rc::<str>::from((*v1258.borrow()).join(&*v1259));
                                    US13::US13_Ok(v1260.clone(), v1249, v1250, v1251, v1252, v1253)
                                }
                            }
                        }
                        US13::US13_Ok(v1234, v1235, v1236, v1237, v1238, v1239) => {
                            let v1234: Rc<str> = v1234.clone();
                            let v1235: i32 = *v1235;
                            let v1236: i32 = *v1236;
                            let v1237: i32 = *v1237;
                            let v1238: i32 = *v1238;
                            let v1239: i32 = *v1239;
                            v1233.clone()
                        }
                    };
                    let v1283: US13 = match &v1272 {
                        US13::US13_Ok(v1273, v1274, v1275, v1276, v1277, v1278) => {
                            let v1273: Rc<str> = v1273.clone();
                            let v1274: i32 = *v1274;
                            let v1275: i32 = *v1275;
                            let v1276: i32 = *v1276;
                            let v1277: i32 = *v1277;
                            let v1278: i32 = *v1278;
                            let v1279: bool = v1274 == v39;
                            if v1279 {
                                let v1280: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure51();
                                US13::US13_Error(v1280.clone(), v39, v40, v41, v42, v43)
                            } else {
                                v1272.clone()
                            }
                        }
                        _ => {
                            v1272.clone()
                        }
                    };
                    let v1300: US13 = match &v1283 {
                        US13::US13_Error(v1284, v1285, v1286, v1287, v1288, v1289) => {
                            let v1284: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1284.clone();
                            let v1285: i32 = *v1285;
                            let v1286: i32 = *v1286;
                            let v1287: i32 = *v1287;
                            let v1288: i32 = *v1288;
                            let v1289: i32 = *v1289;
                            US13::US13_Error(v1284.clone(), v1285, v1286, v1287, v1288, v1289)
                        }
                        US13::US13_Ok(v1291, v1292, v1293, v1294, v1295, v1296) => {
                            let v1291: Rc<str> = v1291.clone();
                            let v1292: i32 = *v1292;
                            let v1293: i32 = *v1293;
                            let v1294: i32 = *v1294;
                            let v1295: i32 = *v1295;
                            let v1296: i32 = *v1296;
                            let v1297: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                            method86(v0.clone(), v1291.clone(), v1297.clone(), v1292, v1293, v1294, v1295, v1296)
                        }
                    };
                    match &v1300 {
                        US13::US13_Error(v1309, v1310, v1311, v1312, v1313, v1314) => {
                            let v1309: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1309.clone();
                            let v1310: i32 = *v1310;
                            let v1311: i32 = *v1311;
                            let v1312: i32 = *v1312;
                            let mut v1313: i32 = *v1313;
                            let v1314: i32 = *v1314;
                            let v1315: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                            let v1316: Rc<UH0> = method85(v1.clone(), v1315.clone());
                            return US21::US21_Ok(v1316.clone(), v2, v3, v4, v5, v6);
                        }
                        US13::US13_Ok(v1301, v1302, v1303, v1304, v1305, v1306) => {
                            let v1301: Rc<str> = v1301.clone();
                            let v1302: i32 = *v1302;
                            let v1303: i32 = *v1303;
                            let v1304: i32 = *v1304;
                            let v1305: i32 = *v1305;
                            let v1306: i32 = *v1306;
                            let v1307: Rc<UH0> = Rc::new(UH0::UH0_Cons(v1301.clone(), v1.clone()));
                            (v0, v1, v2, v3, v4, v5, v6) = (v0.clone(), v1307.clone(), v1302, v1303, v1304, v1305, v1306);
                            continue;
                        }
                    }
                }
            }
        }
    }
}
fn method93(mut v0: Rc<UH0>, mut v1: i32) -> i32 {
    loop {
        match &*v0 {
            UH0::UH0_Cons(v2, v3) => {
                let mut v2: Rc<str> = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: i32 = v1.wrapping_add(1i32);
                (v0, v1) = (v3.clone(), v4);
                continue;
            }
            UH0::UH0_Nil => {
                return v1;
            }
        }
    }
}
fn method94(mut v0: Rc<RefCell<Vec<Rc<str>>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                v0.borrow_mut().push(v3);
                let mut v5: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v4.clone(), v5);
                continue;
            }
            UH0::UH0_Nil => {
                return v2;
            }
        }
    }
}
fn split_args_79(mut v0: Rc<str>) -> US20 {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: bool = 0i32 >= v1;
    let mut v16: US12 = if v2 {
        let mut v3: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
        US12::US12_Error(v3, 0i32, 0i32, 1i32, 1i32, v1)
    } else {
        let mut v5: u8 = v0.clone().as_bytes()[0i32 as usize];
        let mut v6: bool = v5 == b'\\';
        if v6 {
            let mut v7: bool = b'\n' == v5;
            let (mut v8, mut v9, mut v10, mut v11): (i32, i32, i32, i32) = if v7 {
                (1i32, 2i32, 1i32, v1)
            } else {
                (0i32, 1i32, 2i32, v1)
            };
            US12::US12_Ok(b'\\', 1i32, v8, v9, v10, v11)
        } else {
            let mut v13: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
            US12::US12_Error(v13, 0i32, 0i32, 1i32, 1i32, v1)
        }
    };
    let v50: US12 = match &v16 {
        US12::US12_Error(v42, v43, v44, v45, v46, v47) => {
            let v42: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v42.clone();
            let v43: i32 = *v43;
            let mut v44: i32 = *v44;
            let mut v45: i32 = *v45;
            let mut v46: i32 = *v46;
            let mut v47: i32 = *v47;
            US12::US12_Error(v42, v43, v44, v45, v46, v47)
        }
        US12::US12_Ok(v17, v18, v19, v20, v21, v22) => {
            let mut v17: u8 = *v17;
            let v18: i32 = *v18;
            let v19: i32 = *v19;
            let mut v20: i32 = *v20;
            let v21: i32 = *v21;
            let mut v22: i32 = *v22;
            let v23: bool = v18 >= v22;
            if v23 {
                let v24: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                US12::US12_Error(v24, v18, v19, v20, v21, v22)
            } else {
                let mut v26: u8 = v0.clone().as_bytes()[v18 as usize];
                let mut v27: bool = v26 == b'"';
                if v27 {
                    let mut v28: i32 = v18.wrapping_add(1i32);
                    let mut v29: bool = b'\n' == v26;
                    let (mut v33, mut v34, mut v35, mut v36): (i32, i32, i32, i32) = if v29 {
                        let v30: i32 = v19.wrapping_add(v21);
                        let mut v31: i32 = v20.wrapping_add(1i32);
                        (v30, v31, 1i32, v22)
                    } else {
                        let mut v32: i32 = v21.wrapping_add(1i32);
                        (v19, v20, v32, v22)
                    };
                    US12::US12_Ok(b'"', v28, v33, v34, v35, v36)
                } else {
                    let mut v38: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                    US12::US12_Error(v38, v18, v19, v20, v21, v22)
                }
            }
        }
    };
    let v66: US12 = match &v50 {
        US12::US12_Error(v58, v59, v60, v61, v62, v63) => {
            let v58: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v58.clone();
            let mut v59: i32 = *v59;
            let v60: i32 = *v60;
            let v61: i32 = *v61;
            let v62: i32 = *v62;
            let mut v63: i32 = *v63;
            US12::US12_Error(v58, v59, v60, v61, v62, v63)
        }
        US12::US12_Ok(v51, v52, v53, v54, v55, v56) => {
            let v51: u8 = *v51;
            let mut v52: i32 = *v52;
            let v53: i32 = *v53;
            let v54: i32 = *v54;
            let v55: i32 = *v55;
            let v56: i32 = *v56;
            US12::US12_Ok(b'"', v52, v53, v54, v55, v56)
        }
    };
    let v160: US12 = match &v66 {
        US12::US12_Error(v73, v74, v75, v76, v77, v78) => {
            let mut v73: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v73.clone();
            let v74: i32 = *v74;
            let mut v75: i32 = *v75;
            let mut v76: i32 = *v76;
            let mut v77: i32 = *v77;
            let v78: i32 = *v78;
            let v92: US12 = if v2 {
                let mut v79: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                US12::US12_Error(v79, 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let mut v81: u8 = v0.clone().as_bytes()[0i32 as usize];
                let mut v82: bool = v81 == b'`';
                if v82 {
                    let mut v83: bool = b'\n' == v81;
                    let (mut v84, mut v85, mut v86, mut v87): (i32, i32, i32, i32) = if v83 {
                        (1i32, 2i32, 1i32, v1)
                    } else {
                        (0i32, 1i32, 2i32, v1)
                    };
                    US12::US12_Ok(b'`', 1i32, v84, v85, v86, v87)
                } else {
                    let v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                    US12::US12_Error(v89, 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            let v126: US12 = match &v92 {
                US12::US12_Error(v118, v119, v120, v121, v122, v123) => {
                    let v118: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v118.clone();
                    let mut v119: i32 = *v119;
                    let v120: i32 = *v120;
                    let mut v121: i32 = *v121;
                    let mut v122: i32 = *v122;
                    let v123: i32 = *v123;
                    US12::US12_Error(v118, v119, v120, v121, v122, v123)
                }
                US12::US12_Ok(v93, v94, v95, v96, v97, v98) => {
                    let mut v93: u8 = *v93;
                    let v94: i32 = *v94;
                    let v95: i32 = *v95;
                    let v96: i32 = *v96;
                    let v97: i32 = *v97;
                    let mut v98: i32 = *v98;
                    let v99: bool = v94 >= v98;
                    if v99 {
                        let v100: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                        US12::US12_Error(v100, v94, v95, v96, v97, v98)
                    } else {
                        let mut v102: u8 = v0.clone().as_bytes()[v94 as usize];
                        let v103: bool = v102 == b'"';
                        if v103 {
                            let mut v104: i32 = v94.wrapping_add(1i32);
                            let mut v105: bool = b'\n' == v102;
                            let (mut v109, mut v110, mut v111, mut v112): (i32, i32, i32, i32) = if v105 {
                                let v106: i32 = v95.wrapping_add(v97);
                                let v107: i32 = v96.wrapping_add(1i32);
                                (v106, v107, 1i32, v98)
                            } else {
                                let mut v108: i32 = v97.wrapping_add(1i32);
                                (v95, v96, v108, v98)
                            };
                            US12::US12_Ok(b'"', v104, v109, v110, v111, v112)
                        } else {
                            let v114: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                            US12::US12_Error(v114, v94, v95, v96, v97, v98)
                        }
                    }
                }
            };
            let v142: US12 = match &v126 {
                US12::US12_Error(v134, v135, v136, v137, v138, v139) => {
                    let v134: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v134.clone();
                    let v135: i32 = *v135;
                    let v136: i32 = *v136;
                    let v137: i32 = *v137;
                    let v138: i32 = *v138;
                    let mut v139: i32 = *v139;
                    US12::US12_Error(v134, v135, v136, v137, v138, v139)
                }
                US12::US12_Ok(v127, v128, v129, v130, v131, v132) => {
                    let mut v127: u8 = *v127;
                    let v128: i32 = *v128;
                    let v129: i32 = *v129;
                    let mut v130: i32 = *v130;
                    let v131: i32 = *v131;
                    let v132: i32 = *v132;
                    US12::US12_Ok(b'"', v128, v129, v130, v131, v132)
                }
            };
            match &v142 {
                US12::US12_Error(v149, v150, v151, v152, v153, v154) => {
                    let v149: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v149.clone();
                    let mut v150: i32 = *v150;
                    let mut v151: i32 = *v151;
                    let mut v152: i32 = *v152;
                    let v153: i32 = *v153;
                    let v154: i32 = *v154;
                    let mut v155: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                    US12::US12_Error(v155, 0i32, 0i32, 1i32, 1i32, v1)
                }
                US12::US12_Ok(v143, v144, v145, v146, v147, v148) => {
                    let v143: u8 = *v143;
                    let v144: i32 = *v144;
                    let v145: i32 = *v145;
                    let v146: i32 = *v146;
                    let mut v147: i32 = *v147;
                    let mut v148: i32 = *v148;
                    v142
                }
            }
        }
        US12::US12_Ok(v67, v68, v69, v70, v71, v72) => {
            let v67: u8 = *v67;
            let mut v68: i32 = *v68;
            let v69: i32 = *v69;
            let mut v70: i32 = *v70;
            let v71: i32 = *v71;
            let v72: i32 = *v72;
            v66
        }
    };
    let v792: US13 = match &v160 {
        US12::US12_Error(v784, v785, v786, v787, v788, v789) => {
            let v784: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v784.clone();
            let v785: i32 = *v785;
            let v786: i32 = *v786;
            let v787: i32 = *v787;
            let v788: i32 = *v788;
            let v789: i32 = *v789;
            US13::US13_Error(v784, v785, v786, v787, v788, v789)
        }
        US12::US12_Ok(v161, v162, v163, v164, v165, v166) => {
            let mut v161: u8 = *v161;
            let mut v162: i32 = *v162;
            let mut v163: i32 = *v163;
            let mut v164: i32 = *v164;
            let mut v165: i32 = *v165;
            let mut v166: i32 = *v166;
            let (mut v167, mut v168, mut v169, mut v170, mut v171): (i32, i32, i32, i32, i32) = method80(v163, v164, v165, v166, v0.clone(), v162, v163, v164, v165, v166);
            let mut v172: bool = v167 > v162;
            let mut v182: US13 = if v172 {
                let v173: bool = v162 >= v167;
                let mut v178: Rc<str> = if v173 {
                    let v174: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v174
                } else {
                    let v176: i32 = v167.wrapping_sub(1i32);
                    let v177: Rc<str> = string_slice(&v0.clone(), v162 as i64, v176 as i64);
                    v177
                };
                US13::US13_Ok(v178, v167, v168, v169, v170, v171)
            } else {
                let v180: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                US13::US13_Error(v180, v162, v163, v164, v165, v166)
            };
            let v377: US13 = match &v182 {
                US13::US13_Error(v189, v190, v191, v192, v193, v194) => {
                    let mut v189: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v189.clone();
                    let mut v190: i32 = *v190;
                    let v191: i32 = *v191;
                    let v192: i32 = *v192;
                    let v193: i32 = *v193;
                    let v194: i32 = *v194;
                    let v195: bool = v162 >= v166;
                    let v213: US12 = if v195 {
                        let v196: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                        US12::US12_Error(v196, v162, v163, v164, v165, v166)
                    } else {
                        let v198: u8 = v0.clone().as_bytes()[v162 as usize];
                        let v199: bool = v198 == b'\\';
                        if v199 {
                            let v200: i32 = v162.wrapping_add(1i32);
                            let mut v201: bool = b'\n' == v198;
                            let (mut v205, mut v206, mut v207, mut v208): (i32, i32, i32, i32) = if v201 {
                                let v202: i32 = v163.wrapping_add(v165);
                                let v203: i32 = v164.wrapping_add(1i32);
                                (v202, v203, 1i32, v166)
                            } else {
                                let v204: i32 = v165.wrapping_add(1i32);
                                (v163, v164, v204, v166)
                            };
                            US12::US12_Ok(b'\\', v200, v205, v206, v207, v208)
                        } else {
                            let v210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                            US12::US12_Error(v210, v162, v163, v164, v165, v166)
                        }
                    };
                    let mut v248: US12 = match &v213 {
                        US12::US12_Error(v240, v241, v242, v243, v244, v245) => {
                            let v240: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v240.clone();
                            let v241: i32 = *v241;
                            let v242: i32 = *v242;
                            let v243: i32 = *v243;
                            let v244: i32 = *v244;
                            let v245: i32 = *v245;
                            US12::US12_Error(v240, v241, v242, v243, v244, v245)
                        }
                        US12::US12_Ok(v214, v215, v216, v217, v218, v219) => {
                            let v214: u8 = *v214;
                            let v215: i32 = *v215;
                            let v216: i32 = *v216;
                            let mut v217: i32 = *v217;
                            let mut v218: i32 = *v218;
                            let mut v219: i32 = *v219;
                            let mut v220: bool = v215 >= v219;
                            if v220 {
                                let mut v221: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                                US12::US12_Error(v221, v215, v216, v217, v218, v219)
                            } else {
                                let v223: u8 = v0.clone().as_bytes()[v215 as usize];
                                let v224: bool = v223 == b'"';
                                let v225: bool = v224 == false;
                                if v225 {
                                    let v226: i32 = v215.wrapping_add(1i32);
                                    let mut v227: bool = b'\n' == v223;
                                    let (mut v231, mut v232, mut v233, mut v234): (i32, i32, i32, i32) = if v227 {
                                        let v228: i32 = v216.wrapping_add(v218);
                                        let v229: i32 = v217.wrapping_add(1i32);
                                        (v228, v229, 1i32, v219)
                                    } else {
                                        let mut v230: i32 = v218.wrapping_add(1i32);
                                        (v216, v217, v230, v219)
                                    };
                                    US12::US12_Ok(v223, v226, v231, v232, v233, v234)
                                } else {
                                    let mut v236: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                    US12::US12_Error(v236, v215, v216, v217, v218, v219)
                                }
                            }
                        }
                    };
                    let v270: US13 = match &v248 {
                        US12::US12_Error(v262, v263, v264, v265, v266, v267) => {
                            let mut v262: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v262.clone();
                            let v263: i32 = *v263;
                            let v264: i32 = *v264;
                            let v265: i32 = *v265;
                            let v266: i32 = *v266;
                            let v267: i32 = *v267;
                            US13::US13_Error(v262, v263, v264, v265, v266, v267)
                        }
                        US12::US12_Ok(v249, v250, v251, v252, v253, v254) => {
                            let mut v249: u8 = *v249;
                            let mut v250: i32 = *v250;
                            let v251: i32 = *v251;
                            let v252: i32 = *v252;
                            let v253: i32 = *v253;
                            let v254: i32 = *v254;
                            let v255: bool = v162 >= v250;
                            let v260: Rc<str> = if v255 {
                                let v256: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                v256
                            } else {
                                let v258: i32 = v250.wrapping_sub(1i32);
                                let v259: Rc<str> = string_slice(&v0.clone(), v162 as i64, v258 as i64);
                                v259
                            };
                            US13::US13_Ok(v260, v250, v251, v252, v253, v254)
                        }
                    };
                    match &v270 {
                        US13::US13_Error(v277, v278, v279, v280, v281, v282) => {
                            let v277: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v277.clone();
                            let v278: i32 = *v278;
                            let v279: i32 = *v279;
                            let v280: i32 = *v280;
                            let v281: i32 = *v281;
                            let v282: i32 = *v282;
                            let v300: US12 = if v195 {
                                let v283: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                US12::US12_Error(v283, v162, v163, v164, v165, v166)
                            } else {
                                let v285: u8 = v0.clone().as_bytes()[v162 as usize];
                                let v286: bool = v285 == b'`';
                                if v286 {
                                    let mut v287: i32 = v162.wrapping_add(1i32);
                                    let v288: bool = b'\n' == v285;
                                    let (mut v292, mut v293, mut v294, mut v295): (i32, i32, i32, i32) = if v288 {
                                        let v289: i32 = v163.wrapping_add(v165);
                                        let mut v290: i32 = v164.wrapping_add(1i32);
                                        (v289, v290, 1i32, v166)
                                    } else {
                                        let mut v291: i32 = v165.wrapping_add(1i32);
                                        (v163, v164, v291, v166)
                                    };
                                    US12::US12_Ok(b'`', v287, v292, v293, v294, v295)
                                } else {
                                    let v297: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                    US12::US12_Error(v297, v162, v163, v164, v165, v166)
                                }
                            };
                            let v335: US12 = match &v300 {
                                US12::US12_Error(v327, v328, v329, v330, v331, v332) => {
                                    let v327: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v327.clone();
                                    let v328: i32 = *v328;
                                    let mut v329: i32 = *v329;
                                    let v330: i32 = *v330;
                                    let v331: i32 = *v331;
                                    let mut v332: i32 = *v332;
                                    US12::US12_Error(v327, v328, v329, v330, v331, v332)
                                }
                                US12::US12_Ok(v301, v302, v303, v304, v305, v306) => {
                                    let v301: u8 = *v301;
                                    let v302: i32 = *v302;
                                    let v303: i32 = *v303;
                                    let v304: i32 = *v304;
                                    let v305: i32 = *v305;
                                    let v306: i32 = *v306;
                                    let v307: bool = v302 >= v306;
                                    if v307 {
                                        let v308: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                                        US12::US12_Error(v308, v302, v303, v304, v305, v306)
                                    } else {
                                        let v310: u8 = v0.clone().as_bytes()[v302 as usize];
                                        let v311: bool = v310 == b'"';
                                        let v312: bool = v311 == false;
                                        if v312 {
                                            let v313: i32 = v302.wrapping_add(1i32);
                                            let v314: bool = b'\n' == v310;
                                            let (mut v318, mut v319, mut v320, mut v321): (i32, i32, i32, i32) = if v314 {
                                                let v315: i32 = v303.wrapping_add(v305);
                                                let v316: i32 = v304.wrapping_add(1i32);
                                                (v315, v316, 1i32, v306)
                                            } else {
                                                let v317: i32 = v305.wrapping_add(1i32);
                                                (v303, v304, v317, v306)
                                            };
                                            US12::US12_Ok(v310, v313, v318, v319, v320, v321)
                                        } else {
                                            let v323: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                            US12::US12_Error(v323, v302, v303, v304, v305, v306)
                                        }
                                    }
                                }
                            };
                            let v357: US13 = match &v335 {
                                US12::US12_Error(v349, v350, v351, v352, v353, v354) => {
                                    let v349: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v349.clone();
                                    let v350: i32 = *v350;
                                    let v351: i32 = *v351;
                                    let v352: i32 = *v352;
                                    let v353: i32 = *v353;
                                    let v354: i32 = *v354;
                                    US13::US13_Error(v349, v350, v351, v352, v353, v354)
                                }
                                US12::US12_Ok(v336, v337, v338, v339, v340, v341) => {
                                    let v336: u8 = *v336;
                                    let v337: i32 = *v337;
                                    let v338: i32 = *v338;
                                    let v339: i32 = *v339;
                                    let v340: i32 = *v340;
                                    let v341: i32 = *v341;
                                    let v342: bool = v162 >= v337;
                                    let v347: Rc<str> = if v342 {
                                        let v343: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        v343
                                    } else {
                                        let v345: i32 = v337.wrapping_sub(1i32);
                                        let v346: Rc<str> = string_slice(&v0.clone(), v162 as i64, v345 as i64);
                                        v346
                                    };
                                    US13::US13_Ok(v347, v337, v338, v339, v340, v341)
                                }
                            };
                            match &v357 {
                                US13::US13_Error(v364, v365, v366, v367, v368, v369) => {
                                    let v364: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v364.clone();
                                    let v365: i32 = *v365;
                                    let v366: i32 = *v366;
                                    let v367: i32 = *v367;
                                    let v368: i32 = *v368;
                                    let v369: i32 = *v369;
                                    let v370: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                    US13::US13_Error(v370, v162, v163, v164, v165, v166)
                                }
                                US13::US13_Ok(v358, v359, v360, v361, v362, v363) => {
                                    let v358: Rc<str> = v358.clone();
                                    let mut v359: i32 = *v359;
                                    let v360: i32 = *v360;
                                    let v361: i32 = *v361;
                                    let v362: i32 = *v362;
                                    let v363: i32 = *v363;
                                    v357
                                }
                            }
                        }
                        US13::US13_Ok(v271, v272, v273, v274, v275, v276) => {
                            let v271: Rc<str> = v271.clone();
                            let v272: i32 = *v272;
                            let v273: i32 = *v273;
                            let mut v274: i32 = *v274;
                            let v275: i32 = *v275;
                            let v276: i32 = *v276;
                            v270
                        }
                    }
                }
                US13::US13_Ok(v183, v184, v185, v186, v187, v188) => {
                    let mut v183: Rc<str> = v183.clone();
                    let v184: i32 = *v184;
                    let v185: i32 = *v185;
                    let v186: i32 = *v186;
                    let v187: i32 = *v187;
                    let v188: i32 = *v188;
                    v182
                }
            };
            let v400: US13 = match &v377 {
                US13::US13_Error(v378, v379, v380, v381, v382, v383) => {
                    let v378: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v378.clone();
                    let v379: i32 = *v379;
                    let v380: i32 = *v380;
                    let v381: i32 = *v381;
                    let v382: i32 = *v382;
                    let v383: i32 = *v383;
                    let v384: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US13::US13_Ok(v384, v162, v163, v164, v165, v166)
                }
                US13::US13_Ok(v386, v387, v388, v389, v390, v391) => {
                    let v386: Rc<str> = v386.clone();
                    let v387: i32 = *v387;
                    let v388: i32 = *v388;
                    let v389: i32 = *v389;
                    let v390: i32 = *v390;
                    let mut v391: i32 = *v391;
                    let v392: bool = v387 == v162;
                    if v392 {
                        let v393: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure45();
                        US13::US13_Error(v393, v162, v163, v164, v165, v166)
                    } else {
                        let v395: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                        let v396: i32 = 0i32;
                        method81(v0.clone(), v395.clone(), v395, v386, v396, v387, v388, v389, v390, v391)
                    }
                }
            };
            match &v400 {
                US13::US13_Error(v591, v592, v593, v594, v595, v596) => {
                    let v591: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v591.clone();
                    let v592: i32 = *v592;
                    let v593: i32 = *v593;
                    let mut v594: i32 = *v594;
                    let v595: i32 = *v595;
                    let v596: i32 = *v596;
                    let v597: bool = v162 >= v166;
                    let v615: US12 = if v597 {
                        let v598: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                        US12::US12_Error(v598, v162, v163, v164, v165, v166)
                    } else {
                        let v600: u8 = v0.clone().as_bytes()[v162 as usize];
                        let v601: bool = v600 == b'\\';
                        if v601 {
                            let v602: i32 = v162.wrapping_add(1i32);
                            let v603: bool = b'\n' == v600;
                            let (mut v607, mut v608, mut v609, mut v610): (i32, i32, i32, i32) = if v603 {
                                let v604: i32 = v163.wrapping_add(v165);
                                let mut v605: i32 = v164.wrapping_add(1i32);
                                (v604, v605, 1i32, v166)
                            } else {
                                let v606: i32 = v165.wrapping_add(1i32);
                                (v163, v164, v606, v166)
                            };
                            US12::US12_Ok(b'\\', v602, v607, v608, v609, v610)
                        } else {
                            let v612: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                            US12::US12_Error(v612, v162, v163, v164, v165, v166)
                        }
                    };
                    let v649: US12 = match &v615 {
                        US12::US12_Error(v641, v642, v643, v644, v645, v646) => {
                            let v641: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v641.clone();
                            let v642: i32 = *v642;
                            let v643: i32 = *v643;
                            let v644: i32 = *v644;
                            let v645: i32 = *v645;
                            let v646: i32 = *v646;
                            US12::US12_Error(v641, v642, v643, v644, v645, v646)
                        }
                        US12::US12_Ok(v616, v617, v618, v619, v620, v621) => {
                            let v616: u8 = *v616;
                            let v617: i32 = *v617;
                            let v618: i32 = *v618;
                            let v619: i32 = *v619;
                            let v620: i32 = *v620;
                            let v621: i32 = *v621;
                            let v622: bool = v617 >= v621;
                            if v622 {
                                let v623: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US12::US12_Error(v623, v617, v618, v619, v620, v621)
                            } else {
                                let v625: u8 = v0.clone().as_bytes()[v617 as usize];
                                let v626: bool = v625 == b'"';
                                if v626 {
                                    let v627: i32 = v617.wrapping_add(1i32);
                                    let v628: bool = b'\n' == v625;
                                    let (mut v632, mut v633, mut v634, mut v635): (i32, i32, i32, i32) = if v628 {
                                        let v629: i32 = v618.wrapping_add(v620);
                                        let v630: i32 = v619.wrapping_add(1i32);
                                        (v629, v630, 1i32, v621)
                                    } else {
                                        let v631: i32 = v620.wrapping_add(1i32);
                                        (v618, v619, v631, v621)
                                    };
                                    US12::US12_Ok(b'"', v627, v632, v633, v634, v635)
                                } else {
                                    let v637: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US12::US12_Error(v637, v617, v618, v619, v620, v621)
                                }
                            }
                        }
                    };
                    let v665: US12 = match &v649 {
                        US12::US12_Error(v657, v658, v659, v660, v661, v662) => {
                            let mut v657: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v657.clone();
                            let v658: i32 = *v658;
                            let v659: i32 = *v659;
                            let v660: i32 = *v660;
                            let v661: i32 = *v661;
                            let v662: i32 = *v662;
                            US12::US12_Error(v657, v658, v659, v660, v661, v662)
                        }
                        US12::US12_Ok(v650, v651, v652, v653, v654, v655) => {
                            let v650: u8 = *v650;
                            let v651: i32 = *v651;
                            let v652: i32 = *v652;
                            let v653: i32 = *v653;
                            let mut v654: i32 = *v654;
                            let v655: i32 = *v655;
                            US12::US12_Ok(b'"', v651, v652, v653, v654, v655)
                        }
                    };
                    let v763: US12 = match &v665 {
                        US12::US12_Error(v672, v673, v674, v675, v676, v677) => {
                            let v672: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v672.clone();
                            let v673: i32 = *v673;
                            let v674: i32 = *v674;
                            let v675: i32 = *v675;
                            let v676: i32 = *v676;
                            let v677: i32 = *v677;
                            let v695: US12 = if v597 {
                                let v678: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                US12::US12_Error(v678, v162, v163, v164, v165, v166)
                            } else {
                                let v680: u8 = v0.clone().as_bytes()[v162 as usize];
                                let v681: bool = v680 == b'`';
                                if v681 {
                                    let v682: i32 = v162.wrapping_add(1i32);
                                    let v683: bool = b'\n' == v680;
                                    let (mut v687, mut v688, mut v689, mut v690): (i32, i32, i32, i32) = if v683 {
                                        let v684: i32 = v163.wrapping_add(v165);
                                        let mut v685: i32 = v164.wrapping_add(1i32);
                                        (v684, v685, 1i32, v166)
                                    } else {
                                        let v686: i32 = v165.wrapping_add(1i32);
                                        (v163, v164, v686, v166)
                                    };
                                    US12::US12_Ok(b'`', v682, v687, v688, v689, v690)
                                } else {
                                    let v692: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                    US12::US12_Error(v692, v162, v163, v164, v165, v166)
                                }
                            };
                            let v729: US12 = match &v695 {
                                US12::US12_Error(v721, v722, v723, v724, v725, v726) => {
                                    let v721: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v721.clone();
                                    let v722: i32 = *v722;
                                    let v723: i32 = *v723;
                                    let v724: i32 = *v724;
                                    let v725: i32 = *v725;
                                    let v726: i32 = *v726;
                                    US12::US12_Error(v721, v722, v723, v724, v725, v726)
                                }
                                US12::US12_Ok(v696, v697, v698, v699, v700, v701) => {
                                    let v696: u8 = *v696;
                                    let v697: i32 = *v697;
                                    let v698: i32 = *v698;
                                    let v699: i32 = *v699;
                                    let v700: i32 = *v700;
                                    let v701: i32 = *v701;
                                    let v702: bool = v697 >= v701;
                                    if v702 {
                                        let v703: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                        US12::US12_Error(v703, v697, v698, v699, v700, v701)
                                    } else {
                                        let v705: u8 = v0.clone().as_bytes()[v697 as usize];
                                        let v706: bool = v705 == b'"';
                                        if v706 {
                                            let v707: i32 = v697.wrapping_add(1i32);
                                            let v708: bool = b'\n' == v705;
                                            let (mut v712, mut v713, mut v714, mut v715): (i32, i32, i32, i32) = if v708 {
                                                let v709: i32 = v698.wrapping_add(v700);
                                                let v710: i32 = v699.wrapping_add(1i32);
                                                (v709, v710, 1i32, v701)
                                            } else {
                                                let v711: i32 = v700.wrapping_add(1i32);
                                                (v698, v699, v711, v701)
                                            };
                                            US12::US12_Ok(b'"', v707, v712, v713, v714, v715)
                                        } else {
                                            let v717: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                            US12::US12_Error(v717, v697, v698, v699, v700, v701)
                                        }
                                    }
                                }
                            };
                            let v745: US12 = match &v729 {
                                US12::US12_Error(v737, v738, v739, v740, v741, v742) => {
                                    let v737: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v737.clone();
                                    let v738: i32 = *v738;
                                    let v739: i32 = *v739;
                                    let v740: i32 = *v740;
                                    let v741: i32 = *v741;
                                    let v742: i32 = *v742;
                                    US12::US12_Error(v737, v738, v739, v740, v741, v742)
                                }
                                US12::US12_Ok(v730, v731, v732, v733, v734, v735) => {
                                    let v730: u8 = *v730;
                                    let v731: i32 = *v731;
                                    let v732: i32 = *v732;
                                    let mut v733: i32 = *v733;
                                    let v734: i32 = *v734;
                                    let v735: i32 = *v735;
                                    US12::US12_Ok(b'"', v731, v732, v733, v734, v735)
                                }
                            };
                            match &v745 {
                                US12::US12_Error(v752, v753, v754, v755, v756, v757) => {
                                    let v752: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v752.clone();
                                    let v753: i32 = *v753;
                                    let v754: i32 = *v754;
                                    let v755: i32 = *v755;
                                    let v756: i32 = *v756;
                                    let v757: i32 = *v757;
                                    let v758: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                    US12::US12_Error(v758, v162, v163, v164, v165, v166)
                                }
                                US12::US12_Ok(v746, v747, v748, v749, v750, v751) => {
                                    let v746: u8 = *v746;
                                    let v747: i32 = *v747;
                                    let v748: i32 = *v748;
                                    let v749: i32 = *v749;
                                    let v750: i32 = *v750;
                                    let v751: i32 = *v751;
                                    v745
                                }
                            }
                        }
                        US12::US12_Ok(v666, v667, v668, v669, v670, v671) => {
                            let v666: u8 = *v666;
                            let v667: i32 = *v667;
                            let v668: i32 = *v668;
                            let v669: i32 = *v669;
                            let v670: i32 = *v670;
                            let v671: i32 = *v671;
                            v665
                        }
                    };
                    match &v763 {
                        US12::US12_Error(v772, v773, v774, v775, v776, v777) => {
                            let v772: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v772.clone();
                            let v773: i32 = *v773;
                            let v774: i32 = *v774;
                            let v775: i32 = *v775;
                            let v776: i32 = *v776;
                            let v777: i32 = *v777;
                            let v778: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                            US13::US13_Error(v778, v162, v163, v164, v165, v166)
                        }
                        US12::US12_Ok(v764, v765, v766, v767, v768, v769) => {
                            let mut v764: u8 = *v764;
                            let v765: i32 = *v765;
                            let v766: i32 = *v766;
                            let v767: i32 = *v767;
                            let v768: i32 = *v768;
                            let v769: i32 = *v769;
                            let v770: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US13::US13_Ok(v770, v765, v766, v767, v768, v769)
                        }
                    }
                }
                US13::US13_Ok(v401, v402, v403, v404, v405, v406) => {
                    let v401: Rc<str> = v401.clone();
                    let v402: i32 = *v402;
                    let v403: i32 = *v403;
                    let v404: i32 = *v404;
                    let v405: i32 = *v405;
                    let v406: i32 = *v406;
                    let v407: bool = v402 >= v406;
                    let v425: US12 = if v407 {
                        let v408: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                        US12::US12_Error(v408, v402, v403, v404, v405, v406)
                    } else {
                        let v410: u8 = v0.clone().as_bytes()[v402 as usize];
                        let v411: bool = v410 == b'\\';
                        if v411 {
                            let v412: i32 = v402.wrapping_add(1i32);
                            let v413: bool = b'\n' == v410;
                            let (mut v417, mut v418, mut v419, mut v420): (i32, i32, i32, i32) = if v413 {
                                let v414: i32 = v403.wrapping_add(v405);
                                let v415: i32 = v404.wrapping_add(1i32);
                                (v414, v415, 1i32, v406)
                            } else {
                                let v416: i32 = v405.wrapping_add(1i32);
                                (v403, v404, v416, v406)
                            };
                            US12::US12_Ok(b'\\', v412, v417, v418, v419, v420)
                        } else {
                            let mut v422: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                            US12::US12_Error(v422, v402, v403, v404, v405, v406)
                        }
                    };
                    let v459: US12 = match &v425 {
                        US12::US12_Error(v451, v452, v453, v454, v455, v456) => {
                            let v451: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v451.clone();
                            let v452: i32 = *v452;
                            let v453: i32 = *v453;
                            let v454: i32 = *v454;
                            let v455: i32 = *v455;
                            let v456: i32 = *v456;
                            US12::US12_Error(v451, v452, v453, v454, v455, v456)
                        }
                        US12::US12_Ok(v426, v427, v428, v429, v430, v431) => {
                            let v426: u8 = *v426;
                            let v427: i32 = *v427;
                            let v428: i32 = *v428;
                            let v429: i32 = *v429;
                            let v430: i32 = *v430;
                            let v431: i32 = *v431;
                            let v432: bool = v427 >= v431;
                            if v432 {
                                let v433: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US12::US12_Error(v433, v427, v428, v429, v430, v431)
                            } else {
                                let v435: u8 = v0.clone().as_bytes()[v427 as usize];
                                let v436: bool = v435 == b'"';
                                if v436 {
                                    let v437: i32 = v427.wrapping_add(1i32);
                                    let v438: bool = b'\n' == v435;
                                    let (mut v442, mut v443, mut v444, mut v445): (i32, i32, i32, i32) = if v438 {
                                        let v439: i32 = v428.wrapping_add(v430);
                                        let v440: i32 = v429.wrapping_add(1i32);
                                        (v439, v440, 1i32, v431)
                                    } else {
                                        let v441: i32 = v430.wrapping_add(1i32);
                                        (v428, v429, v441, v431)
                                    };
                                    US12::US12_Ok(b'"', v437, v442, v443, v444, v445)
                                } else {
                                    let v447: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US12::US12_Error(v447, v427, v428, v429, v430, v431)
                                }
                            }
                        }
                    };
                    let v475: US12 = match &v459 {
                        US12::US12_Error(v467, v468, v469, v470, v471, v472) => {
                            let v467: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v467.clone();
                            let v468: i32 = *v468;
                            let v469: i32 = *v469;
                            let v470: i32 = *v470;
                            let v471: i32 = *v471;
                            let v472: i32 = *v472;
                            US12::US12_Error(v467, v468, v469, v470, v471, v472)
                        }
                        US12::US12_Ok(v460, v461, v462, v463, v464, v465) => {
                            let v460: u8 = *v460;
                            let v461: i32 = *v461;
                            let v462: i32 = *v462;
                            let v463: i32 = *v463;
                            let v464: i32 = *v464;
                            let v465: i32 = *v465;
                            US12::US12_Ok(b'"', v461, v462, v463, v464, v465)
                        }
                    };
                    let v573: US12 = match &v475 {
                        US12::US12_Error(v482, v483, v484, v485, v486, v487) => {
                            let v482: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v482.clone();
                            let v483: i32 = *v483;
                            let v484: i32 = *v484;
                            let v485: i32 = *v485;
                            let v486: i32 = *v486;
                            let v487: i32 = *v487;
                            let v505: US12 = if v407 {
                                let v488: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                US12::US12_Error(v488, v402, v403, v404, v405, v406)
                            } else {
                                let v490: u8 = v0.clone().as_bytes()[v402 as usize];
                                let v491: bool = v490 == b'`';
                                if v491 {
                                    let mut v492: i32 = v402.wrapping_add(1i32);
                                    let v493: bool = b'\n' == v490;
                                    let (mut v497, mut v498, mut v499, mut v500): (i32, i32, i32, i32) = if v493 {
                                        let v494: i32 = v403.wrapping_add(v405);
                                        let mut v495: i32 = v404.wrapping_add(1i32);
                                        (v494, v495, 1i32, v406)
                                    } else {
                                        let v496: i32 = v405.wrapping_add(1i32);
                                        (v403, v404, v496, v406)
                                    };
                                    US12::US12_Ok(b'`', v492, v497, v498, v499, v500)
                                } else {
                                    let v502: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                    US12::US12_Error(v502, v402, v403, v404, v405, v406)
                                }
                            };
                            let v539: US12 = match &v505 {
                                US12::US12_Error(v531, v532, v533, v534, v535, v536) => {
                                    let v531: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v531.clone();
                                    let v532: i32 = *v532;
                                    let v533: i32 = *v533;
                                    let v534: i32 = *v534;
                                    let v535: i32 = *v535;
                                    let v536: i32 = *v536;
                                    US12::US12_Error(v531, v532, v533, v534, v535, v536)
                                }
                                US12::US12_Ok(v506, v507, v508, v509, v510, v511) => {
                                    let v506: u8 = *v506;
                                    let v507: i32 = *v507;
                                    let v508: i32 = *v508;
                                    let v509: i32 = *v509;
                                    let v510: i32 = *v510;
                                    let v511: i32 = *v511;
                                    let v512: bool = v507 >= v511;
                                    if v512 {
                                        let v513: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                        US12::US12_Error(v513, v507, v508, v509, v510, v511)
                                    } else {
                                        let v515: u8 = v0.clone().as_bytes()[v507 as usize];
                                        let v516: bool = v515 == b'"';
                                        if v516 {
                                            let v517: i32 = v507.wrapping_add(1i32);
                                            let v518: bool = b'\n' == v515;
                                            let (mut v522, mut v523, mut v524, mut v525): (i32, i32, i32, i32) = if v518 {
                                                let v519: i32 = v508.wrapping_add(v510);
                                                let v520: i32 = v509.wrapping_add(1i32);
                                                (v519, v520, 1i32, v511)
                                            } else {
                                                let v521: i32 = v510.wrapping_add(1i32);
                                                (v508, v509, v521, v511)
                                            };
                                            US12::US12_Ok(b'"', v517, v522, v523, v524, v525)
                                        } else {
                                            let v527: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                            US12::US12_Error(v527, v507, v508, v509, v510, v511)
                                        }
                                    }
                                }
                            };
                            let v555: US12 = match &v539 {
                                US12::US12_Error(v547, v548, v549, v550, v551, v552) => {
                                    let v547: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v547.clone();
                                    let v548: i32 = *v548;
                                    let v549: i32 = *v549;
                                    let v550: i32 = *v550;
                                    let v551: i32 = *v551;
                                    let v552: i32 = *v552;
                                    US12::US12_Error(v547, v548, v549, v550, v551, v552)
                                }
                                US12::US12_Ok(v540, v541, v542, v543, v544, v545) => {
                                    let v540: u8 = *v540;
                                    let v541: i32 = *v541;
                                    let v542: i32 = *v542;
                                    let v543: i32 = *v543;
                                    let v544: i32 = *v544;
                                    let v545: i32 = *v545;
                                    US12::US12_Ok(b'"', v541, v542, v543, v544, v545)
                                }
                            };
                            match &v555 {
                                US12::US12_Error(v562, v563, v564, v565, v566, v567) => {
                                    let v562: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v562.clone();
                                    let v563: i32 = *v563;
                                    let v564: i32 = *v564;
                                    let v565: i32 = *v565;
                                    let v566: i32 = *v566;
                                    let v567: i32 = *v567;
                                    let v568: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                    US12::US12_Error(v568, v402, v403, v404, v405, v406)
                                }
                                US12::US12_Ok(v556, v557, v558, v559, v560, v561) => {
                                    let v556: u8 = *v556;
                                    let v557: i32 = *v557;
                                    let v558: i32 = *v558;
                                    let v559: i32 = *v559;
                                    let v560: i32 = *v560;
                                    let v561: i32 = *v561;
                                    v555
                                }
                            }
                        }
                        US12::US12_Ok(v476, v477, v478, v479, v480, v481) => {
                            let v476: u8 = *v476;
                            let v477: i32 = *v477;
                            let v478: i32 = *v478;
                            let v479: i32 = *v479;
                            let v480: i32 = *v480;
                            let v481: i32 = *v481;
                            v475
                        }
                    };
                    match &v573 {
                        US12::US12_Error(v581, v582, v583, v584, v585, v586) => {
                            let v581: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v581.clone();
                            let v582: i32 = *v582;
                            let v583: i32 = *v583;
                            let v584: i32 = *v584;
                            let v585: i32 = *v585;
                            let v586: i32 = *v586;
                            let v587: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28(v162, v402, v581, v582, v583, v584, v585, v586);
                            US13::US13_Error(v587, v402, v403, v404, v405, v406)
                        }
                        US12::US12_Ok(v574, v575, v576, v577, v578, v579) => {
                            let mut v574: u8 = *v574;
                            let v575: i32 = *v575;
                            let v576: i32 = *v576;
                            let mut v577: i32 = *v577;
                            let v578: i32 = *v578;
                            let v579: i32 = *v579;
                            US13::US13_Ok(v401, v575, v576, v577, v578, v579)
                        }
                    }
                }
            }
        }
    };
    let v1146: US13 = match &v792 {
        US13::US13_Error(v799, v800, v801, v802, v803, v804) => {
            let v799: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v799.clone();
            let v800: i32 = *v800;
            let v801: i32 = *v801;
            let v802: i32 = *v802;
            let v803: i32 = *v803;
            let v804: i32 = *v804;
            let v818: US12 = if v2 {
                let v805: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                US12::US12_Error(v805, 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let v807: u8 = v0.clone().as_bytes()[0i32 as usize];
                let v808: bool = v807 == b'"';
                if v808 {
                    let v809: bool = b'\n' == v807;
                    let (mut v810, mut v811, mut v812, mut v813): (i32, i32, i32, i32) = if v809 {
                        (1i32, 2i32, 1i32, v1)
                    } else {
                        (0i32, 1i32, 2i32, v1)
                    };
                    US12::US12_Ok(b'"', 1i32, v810, v811, v812, v813)
                } else {
                    let mut v815: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                    US12::US12_Error(v815, 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            match &v818 {
                US12::US12_Error(v1136, v1137, v1138, v1139, v1140, v1141) => {
                    let v1136: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1136.clone();
                    let v1137: i32 = *v1137;
                    let v1138: i32 = *v1138;
                    let v1139: i32 = *v1139;
                    let v1140: i32 = *v1140;
                    let v1141: i32 = *v1141;
                    US13::US13_Error(v1136, v1137, v1138, v1139, v1140, v1141)
                }
                US12::US12_Ok(v819, v820, v821, v822, v823, v824) => {
                    let v819: u8 = *v819;
                    let v820: i32 = *v820;
                    let v821: i32 = *v821;
                    let v822: i32 = *v822;
                    let v823: i32 = *v823;
                    let v824: i32 = *v824;
                    let (mut v825, mut v826, mut v827, mut v828, mut v829): (i32, i32, i32, i32, i32) = method80(v821, v822, v823, v824, v0.clone(), v820, v821, v822, v823, v824);
                    let v830: bool = v825 > v820;
                    let v840: US13 = if v830 {
                        let v831: bool = v820 >= v825;
                        let v836: Rc<str> = if v831 {
                            let v832: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v832
                        } else {
                            let v834: i32 = v825.wrapping_sub(1i32);
                            let v835: Rc<str> = string_slice(&v0.clone(), v820 as i64, v834 as i64);
                            v835
                        };
                        US13::US13_Ok(v836, v825, v826, v827, v828, v829)
                    } else {
                        let v838: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                        US13::US13_Error(v838, v820, v821, v822, v823, v824)
                    };
                    let v1025: US13 = match &v840 {
                        US13::US13_Error(v847, v848, v849, v850, v851, v852) => {
                            let v847: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v847.clone();
                            let v848: i32 = *v848;
                            let v849: i32 = *v849;
                            let v850: i32 = *v850;
                            let v851: i32 = *v851;
                            let v852: i32 = *v852;
                            let v853: bool = v820 >= v824;
                            let v871: US12 = if v853 {
                                let v854: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                US12::US12_Error(v854, v820, v821, v822, v823, v824)
                            } else {
                                let v856: u8 = v0.clone().as_bytes()[v820 as usize];
                                let v857: bool = v856 == b'\\';
                                if v857 {
                                    let v858: i32 = v820.wrapping_add(1i32);
                                    let v859: bool = b'\n' == v856;
                                    let (mut v863, mut v864, mut v865, mut v866): (i32, i32, i32, i32) = if v859 {
                                        let v860: i32 = v821.wrapping_add(v823);
                                        let v861: i32 = v822.wrapping_add(1i32);
                                        (v860, v861, 1i32, v824)
                                    } else {
                                        let v862: i32 = v823.wrapping_add(1i32);
                                        (v821, v822, v862, v824)
                                    };
                                    US12::US12_Ok(b'\\', v858, v863, v864, v865, v866)
                                } else {
                                    let v868: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                    US12::US12_Error(v868, v820, v821, v822, v823, v824)
                                }
                            };
                            let v901: US12 = match &v871 {
                                US12::US12_Error(v893, v894, v895, v896, v897, v898) => {
                                    let v893: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v893.clone();
                                    let mut v894: i32 = *v894;
                                    let v895: i32 = *v895;
                                    let v896: i32 = *v896;
                                    let v897: i32 = *v897;
                                    let v898: i32 = *v898;
                                    US12::US12_Error(v893, v894, v895, v896, v897, v898)
                                }
                                US12::US12_Ok(v872, v873, v874, v875, v876, v877) => {
                                    let v872: u8 = *v872;
                                    let v873: i32 = *v873;
                                    let v874: i32 = *v874;
                                    let v875: i32 = *v875;
                                    let v876: i32 = *v876;
                                    let v877: i32 = *v877;
                                    let v878: bool = v873 >= v877;
                                    if v878 {
                                        let v879: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                                        US12::US12_Error(v879, v873, v874, v875, v876, v877)
                                    } else {
                                        let v881: u8 = v0.clone().as_bytes()[v873 as usize];
                                        let v882: i32 = v873.wrapping_add(1i32);
                                        let v883: bool = b'\n' == v881;
                                        let (mut v887, mut v888, mut v889, mut v890): (i32, i32, i32, i32) = if v883 {
                                            let v884: i32 = v874.wrapping_add(v876);
                                            let v885: i32 = v875.wrapping_add(1i32);
                                            (v884, v885, 1i32, v877)
                                        } else {
                                            let v886: i32 = v876.wrapping_add(1i32);
                                            (v874, v875, v886, v877)
                                        };
                                        US12::US12_Ok(v881, v882, v887, v888, v889, v890)
                                    }
                                }
                            };
                            let v923: US13 = match &v901 {
                                US12::US12_Error(v915, v916, v917, v918, v919, v920) => {
                                    let v915: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v915.clone();
                                    let v916: i32 = *v916;
                                    let v917: i32 = *v917;
                                    let v918: i32 = *v918;
                                    let v919: i32 = *v919;
                                    let v920: i32 = *v920;
                                    US13::US13_Error(v915, v916, v917, v918, v919, v920)
                                }
                                US12::US12_Ok(v902, v903, v904, v905, v906, v907) => {
                                    let v902: u8 = *v902;
                                    let v903: i32 = *v903;
                                    let v904: i32 = *v904;
                                    let v905: i32 = *v905;
                                    let v906: i32 = *v906;
                                    let v907: i32 = *v907;
                                    let v908: bool = v820 >= v903;
                                    let v913: Rc<str> = if v908 {
                                        let v909: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        v909
                                    } else {
                                        let v911: i32 = v903.wrapping_sub(1i32);
                                        let v912: Rc<str> = string_slice(&v0.clone(), v820 as i64, v911 as i64);
                                        v912
                                    };
                                    US13::US13_Ok(v913, v903, v904, v905, v906, v907)
                                }
                            };
                            match &v923 {
                                US13::US13_Error(v930, v931, v932, v933, v934, v935) => {
                                    let v930: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v930.clone();
                                    let v931: i32 = *v931;
                                    let v932: i32 = *v932;
                                    let v933: i32 = *v933;
                                    let v934: i32 = *v934;
                                    let v935: i32 = *v935;
                                    let v953: US12 = if v853 {
                                        let v936: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                        US12::US12_Error(v936, v820, v821, v822, v823, v824)
                                    } else {
                                        let v938: u8 = v0.clone().as_bytes()[v820 as usize];
                                        let v939: bool = v938 == b'`';
                                        if v939 {
                                            let v940: i32 = v820.wrapping_add(1i32);
                                            let v941: bool = b'\n' == v938;
                                            let (mut v945, mut v946, mut v947, mut v948): (i32, i32, i32, i32) = if v941 {
                                                let v942: i32 = v821.wrapping_add(v823);
                                                let v943: i32 = v822.wrapping_add(1i32);
                                                (v942, v943, 1i32, v824)
                                            } else {
                                                let v944: i32 = v823.wrapping_add(1i32);
                                                (v821, v822, v944, v824)
                                            };
                                            US12::US12_Ok(b'`', v940, v945, v946, v947, v948)
                                        } else {
                                            let v950: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                            US12::US12_Error(v950, v820, v821, v822, v823, v824)
                                        }
                                    };
                                    let v983: US12 = match &v953 {
                                        US12::US12_Error(v975, v976, v977, v978, v979, v980) => {
                                            let v975: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v975.clone();
                                            let v976: i32 = *v976;
                                            let v977: i32 = *v977;
                                            let v978: i32 = *v978;
                                            let v979: i32 = *v979;
                                            let v980: i32 = *v980;
                                            US12::US12_Error(v975, v976, v977, v978, v979, v980)
                                        }
                                        US12::US12_Ok(v954, v955, v956, v957, v958, v959) => {
                                            let v954: u8 = *v954;
                                            let v955: i32 = *v955;
                                            let v956: i32 = *v956;
                                            let v957: i32 = *v957;
                                            let v958: i32 = *v958;
                                            let v959: i32 = *v959;
                                            let v960: bool = v955 >= v959;
                                            if v960 {
                                                let v961: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                                                US12::US12_Error(v961, v955, v956, v957, v958, v959)
                                            } else {
                                                let v963: u8 = v0.clone().as_bytes()[v955 as usize];
                                                let v964: i32 = v955.wrapping_add(1i32);
                                                let v965: bool = b'\n' == v963;
                                                let (mut v969, mut v970, mut v971, mut v972): (i32, i32, i32, i32) = if v965 {
                                                    let v966: i32 = v956.wrapping_add(v958);
                                                    let v967: i32 = v957.wrapping_add(1i32);
                                                    (v966, v967, 1i32, v959)
                                                } else {
                                                    let v968: i32 = v958.wrapping_add(1i32);
                                                    (v956, v957, v968, v959)
                                                };
                                                US12::US12_Ok(v963, v964, v969, v970, v971, v972)
                                            }
                                        }
                                    };
                                    let v1005: US13 = match &v983 {
                                        US12::US12_Error(v997, v998, v999, v1000, v1001, v1002) => {
                                            let v997: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v997.clone();
                                            let v998: i32 = *v998;
                                            let v999: i32 = *v999;
                                            let v1000: i32 = *v1000;
                                            let mut v1001: i32 = *v1001;
                                            let v1002: i32 = *v1002;
                                            US13::US13_Error(v997, v998, v999, v1000, v1001, v1002)
                                        }
                                        US12::US12_Ok(v984, v985, v986, v987, v988, v989) => {
                                            let v984: u8 = *v984;
                                            let v985: i32 = *v985;
                                            let v986: i32 = *v986;
                                            let v987: i32 = *v987;
                                            let v988: i32 = *v988;
                                            let v989: i32 = *v989;
                                            let v990: bool = v820 >= v985;
                                            let v995: Rc<str> = if v990 {
                                                let v991: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                v991
                                            } else {
                                                let v993: i32 = v985.wrapping_sub(1i32);
                                                let v994: Rc<str> = string_slice(&v0.clone(), v820 as i64, v993 as i64);
                                                v994
                                            };
                                            US13::US13_Ok(v995, v985, v986, v987, v988, v989)
                                        }
                                    };
                                    match &v1005 {
                                        US13::US13_Error(v1012, v1013, v1014, v1015, v1016, v1017) => {
                                            let v1012: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1012.clone();
                                            let v1013: i32 = *v1013;
                                            let v1014: i32 = *v1014;
                                            let v1015: i32 = *v1015;
                                            let v1016: i32 = *v1016;
                                            let v1017: i32 = *v1017;
                                            let v1018: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                                            US13::US13_Error(v1018, v820, v821, v822, v823, v824)
                                        }
                                        US13::US13_Ok(v1006, v1007, v1008, v1009, v1010, v1011) => {
                                            let v1006: Rc<str> = v1006.clone();
                                            let v1007: i32 = *v1007;
                                            let v1008: i32 = *v1008;
                                            let v1009: i32 = *v1009;
                                            let v1010: i32 = *v1010;
                                            let v1011: i32 = *v1011;
                                            v1005
                                        }
                                    }
                                }
                                US13::US13_Ok(v924, v925, v926, v927, v928, v929) => {
                                    let v924: Rc<str> = v924.clone();
                                    let v925: i32 = *v925;
                                    let v926: i32 = *v926;
                                    let v927: i32 = *v927;
                                    let v928: i32 = *v928;
                                    let v929: i32 = *v929;
                                    v923
                                }
                            }
                        }
                        US13::US13_Ok(v841, v842, v843, v844, v845, v846) => {
                            let v841: Rc<str> = v841.clone();
                            let v842: i32 = *v842;
                            let mut v843: i32 = *v843;
                            let v844: i32 = *v844;
                            let v845: i32 = *v845;
                            let v846: i32 = *v846;
                            v840
                        }
                    };
                    let v1048: US13 = match &v1025 {
                        US13::US13_Error(v1026, v1027, v1028, v1029, v1030, v1031) => {
                            let v1026: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1026.clone();
                            let v1027: i32 = *v1027;
                            let v1028: i32 = *v1028;
                            let v1029: i32 = *v1029;
                            let v1030: i32 = *v1030;
                            let v1031: i32 = *v1031;
                            let v1032: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US13::US13_Ok(v1032, v820, v821, v822, v823, v824)
                        }
                        US13::US13_Ok(v1034, v1035, v1036, v1037, v1038, v1039) => {
                            let v1034: Rc<str> = v1034.clone();
                            let v1035: i32 = *v1035;
                            let v1036: i32 = *v1036;
                            let mut v1037: i32 = *v1037;
                            let v1038: i32 = *v1038;
                            let v1039: i32 = *v1039;
                            let v1040: bool = v1035 == v820;
                            if v1040 {
                                let v1041: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure45();
                                US13::US13_Error(v1041, v820, v821, v822, v823, v824)
                            } else {
                                let v1043: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                let v1044: i32 = 0i32;
                                method82(v0.clone(), v1043.clone(), v1043, v1034, v1044, v1035, v1036, v1037, v1038, v1039)
                            }
                        }
                    };
                    match &v1048 {
                        US13::US13_Error(v1091, v1092, v1093, v1094, v1095, v1096) => {
                            let v1091: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1091.clone();
                            let v1092: i32 = *v1092;
                            let v1093: i32 = *v1093;
                            let v1094: i32 = *v1094;
                            let v1095: i32 = *v1095;
                            let v1096: i32 = *v1096;
                            let v1097: bool = v820 >= v824;
                            let v1115: US12 = if v1097 {
                                let v1098: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US12::US12_Error(v1098, v820, v821, v822, v823, v824)
                            } else {
                                let v1100: u8 = v0.clone().as_bytes()[v820 as usize];
                                let v1101: bool = v1100 == b'"';
                                if v1101 {
                                    let v1102: i32 = v820.wrapping_add(1i32);
                                    let v1103: bool = b'\n' == v1100;
                                    let (mut v1107, mut v1108, mut v1109, mut v1110): (i32, i32, i32, i32) = if v1103 {
                                        let v1104: i32 = v821.wrapping_add(v823);
                                        let v1105: i32 = v822.wrapping_add(1i32);
                                        (v1104, v1105, 1i32, v824)
                                    } else {
                                        let v1106: i32 = v823.wrapping_add(1i32);
                                        (v821, v822, v1106, v824)
                                    };
                                    US12::US12_Ok(b'"', v1102, v1107, v1108, v1109, v1110)
                                } else {
                                    let v1112: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US12::US12_Error(v1112, v820, v821, v822, v823, v824)
                                }
                            };
                            match &v1115 {
                                US12::US12_Error(v1124, v1125, v1126, v1127, v1128, v1129) => {
                                    let v1124: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1124.clone();
                                    let v1125: i32 = *v1125;
                                    let v1126: i32 = *v1126;
                                    let v1127: i32 = *v1127;
                                    let v1128: i32 = *v1128;
                                    let v1129: i32 = *v1129;
                                    let v1130: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                                    US13::US13_Error(v1130, v820, v821, v822, v823, v824)
                                }
                                US12::US12_Ok(v1116, v1117, v1118, v1119, v1120, v1121) => {
                                    let v1116: u8 = *v1116;
                                    let v1117: i32 = *v1117;
                                    let v1118: i32 = *v1118;
                                    let v1119: i32 = *v1119;
                                    let v1120: i32 = *v1120;
                                    let v1121: i32 = *v1121;
                                    let v1122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    US13::US13_Ok(v1122, v1117, v1118, v1119, v1120, v1121)
                                }
                            }
                        }
                        US13::US13_Ok(v1049, v1050, v1051, v1052, v1053, v1054) => {
                            let v1049: Rc<str> = v1049.clone();
                            let v1050: i32 = *v1050;
                            let v1051: i32 = *v1051;
                            let v1052: i32 = *v1052;
                            let v1053: i32 = *v1053;
                            let v1054: i32 = *v1054;
                            let v1055: bool = v1050 >= v1054;
                            let v1073: US12 = if v1055 {
                                let v1056: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US12::US12_Error(v1056, v1050, v1051, v1052, v1053, v1054)
                            } else {
                                let v1058: u8 = v0.clone().as_bytes()[v1050 as usize];
                                let v1059: bool = v1058 == b'"';
                                if v1059 {
                                    let v1060: i32 = v1050.wrapping_add(1i32);
                                    let v1061: bool = b'\n' == v1058;
                                    let (mut v1065, mut v1066, mut v1067, mut v1068): (i32, i32, i32, i32) = if v1061 {
                                        let v1062: i32 = v1051.wrapping_add(v1053);
                                        let v1063: i32 = v1052.wrapping_add(1i32);
                                        (v1062, v1063, 1i32, v1054)
                                    } else {
                                        let v1064: i32 = v1053.wrapping_add(1i32);
                                        (v1051, v1052, v1064, v1054)
                                    };
                                    US12::US12_Ok(b'"', v1060, v1065, v1066, v1067, v1068)
                                } else {
                                    let v1070: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US12::US12_Error(v1070, v1050, v1051, v1052, v1053, v1054)
                                }
                            };
                            match &v1073 {
                                US12::US12_Error(v1081, v1082, v1083, v1084, v1085, v1086) => {
                                    let v1081: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1081.clone();
                                    let v1082: i32 = *v1082;
                                    let v1083: i32 = *v1083;
                                    let v1084: i32 = *v1084;
                                    let v1085: i32 = *v1085;
                                    let v1086: i32 = *v1086;
                                    let v1087: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28(v820, v1050, v1081, v1082, v1083, v1084, v1085, v1086);
                                    US13::US13_Error(v1087, v1050, v1051, v1052, v1053, v1054)
                                }
                                US12::US12_Ok(v1074, v1075, v1076, v1077, v1078, v1079) => {
                                    let v1074: u8 = *v1074;
                                    let v1075: i32 = *v1075;
                                    let v1076: i32 = *v1076;
                                    let v1077: i32 = *v1077;
                                    let v1078: i32 = *v1078;
                                    let v1079: i32 = *v1079;
                                    US13::US13_Ok(v1049, v1075, v1076, v1077, v1078, v1079)
                                }
                            }
                        }
                    }
                }
            }
        }
        US13::US13_Ok(v793, v794, v795, v796, v797, v798) => {
            let v793: Rc<str> = v793.clone();
            let v794: i32 = *v794;
            let v795: i32 = *v795;
            let v796: i32 = *v796;
            let v797: i32 = *v797;
            let v798: i32 = *v798;
            v792
        }
    };
    let v1180: US13 = match &v1146 {
        US13::US13_Error(v1153, v1154, v1155, v1156, v1157, v1158) => {
            let v1153: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1153.clone();
            let v1154: i32 = *v1154;
            let v1155: i32 = *v1155;
            let v1156: i32 = *v1156;
            let v1157: i32 = *v1157;
            let v1158: i32 = *v1158;
            let v1159: i32 = 0i32;
            let v1160: i32 = 0i32;
            let v1161: i32 = 1i32;
            let v1162: i32 = 1i32;
            let (mut v1163, mut v1164, mut v1165, mut v1166, mut v1167): (i32, i32, i32, i32, i32) = method83(v1, v0.clone(), v1159, v1160, v1161, v1162, v1);
            let v1168: bool = v1163 > 0i32;
            if v1168 {
                let v1169: bool = 0i32 >= v1163;
                let v1174: Rc<str> = if v1169 {
                    let v1170: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v1170
                } else {
                    let v1172: i32 = v1163.wrapping_sub(1i32);
                    let v1173: Rc<str> = string_slice(&v0.clone(), 0i32 as i64, v1172 as i64);
                    v1173
                };
                US13::US13_Ok(v1174, v1163, v1164, v1165, v1166, v1167)
            } else {
                let v1176: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                US13::US13_Error(v1176, 0i32, 0i32, 1i32, 1i32, v1)
            }
        }
        US13::US13_Ok(v1147, v1148, v1149, v1150, v1151, v1152) => {
            let v1147: Rc<str> = v1147.clone();
            let v1148: i32 = *v1148;
            let v1149: i32 = *v1149;
            let v1150: i32 = *v1150;
            let v1151: i32 = *v1151;
            let v1152: i32 = *v1152;
            v1146
        }
    };
    let v1223: US13 = match &v1180 {
        US13::US13_Error(v1187, v1188, v1189, v1190, v1191, v1192) => {
            let v1187: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1187.clone();
            let v1188: i32 = *v1188;
            let v1189: i32 = *v1189;
            let v1190: i32 = *v1190;
            let v1191: i32 = *v1191;
            let v1192: i32 = *v1192;
            let v1193: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let v1194: i32 = 0i32;
            let v1195: i32 = 0i32;
            let v1196: i32 = 1i32;
            let v1197: i32 = 1i32;
            let v1198: US21 = method84(v0.clone(), v1193, v1194, v1195, v1196, v1197, v1);
            match &v1198 {
                US21::US21_Error(v1213, v1214, v1215, v1216, v1217, v1218) => {
                    let v1213: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1213.clone();
                    let v1214: i32 = *v1214;
                    let v1215: i32 = *v1215;
                    let v1216: i32 = *v1216;
                    let v1217: i32 = *v1217;
                    let v1218: i32 = *v1218;
                    US13::US13_Error(v1213, v1214, v1215, v1216, v1217, v1218)
                }
                US21::US21_Ok(v1199, v1200, v1201, v1202, v1203, v1204) => {
                    let v1199: Rc<UH0> = v1199.clone();
                    let v1200: i32 = *v1200;
                    let v1201: i32 = *v1201;
                    let v1202: i32 = *v1202;
                    let v1203: i32 = *v1203;
                    let v1204: i32 = *v1204;
                    let v1205: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
                    let v1206: i32 = 0i32;
                    let v1207: i32 = method3(v1205.clone(), v1199, v1206);
                    let v1208: Rc<Vec<Rc<str>>> = Rc::new(v1205.borrow().clone());
                    let v1209: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v1208).as_ref().clone()));
                    let v1210: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v1211: Rc<str> = Rc::<str>::from((*v1209.borrow()).join(&*v1210));
                    US13::US13_Ok(v1211, v1200, v1201, v1202, v1203, v1204)
                }
            }
        }
        US13::US13_Ok(v1181, v1182, v1183, v1184, v1185, v1186) => {
            let v1181: Rc<str> = v1181.clone();
            let v1182: i32 = *v1182;
            let v1183: i32 = *v1183;
            let v1184: i32 = *v1184;
            let v1185: i32 = *v1185;
            let v1186: i32 = *v1186;
            v1180
        }
    };
    let v1234: US13 = match &v1223 {
        US13::US13_Ok(v1224, v1225, v1226, v1227, v1228, v1229) => {
            let v1224: Rc<str> = v1224.clone();
            let v1225: i32 = *v1225;
            let v1226: i32 = *v1226;
            let v1227: i32 = *v1227;
            let v1228: i32 = *v1228;
            let v1229: i32 = *v1229;
            let v1230: bool = v1225 == 0i32;
            if v1230 {
                let v1231: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure51();
                US13::US13_Error(v1231, 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                v1223.clone()
            }
        }
        _ => {
            v1223
        }
    };
    let v1251: US13 = match &v1234 {
        US13::US13_Error(v1235, v1236, v1237, v1238, v1239, v1240) => {
            let v1235: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1235.clone();
            let v1236: i32 = *v1236;
            let v1237: i32 = *v1237;
            let v1238: i32 = *v1238;
            let v1239: i32 = *v1239;
            let v1240: i32 = *v1240;
            US13::US13_Error(v1235, v1236, v1237, v1238, v1239, v1240)
        }
        US13::US13_Ok(v1242, v1243, v1244, v1245, v1246, v1247) => {
            let v1242: Rc<str> = v1242.clone();
            let v1243: i32 = *v1243;
            let v1244: i32 = *v1244;
            let v1245: i32 = *v1245;
            let v1246: i32 = *v1246;
            let v1247: i32 = *v1247;
            let v1248: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            method86(v0.clone(), v1242, v1248, v1243, v1244, v1245, v1246, v1247)
        }
    };
    let v1270: US21 = match &v1251 {
        US13::US13_Error(v1252, v1253, v1254, v1255, v1256, v1257) => {
            let v1252: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1252.clone();
            let v1253: i32 = *v1253;
            let v1254: i32 = *v1254;
            let v1255: i32 = *v1255;
            let v1256: i32 = *v1256;
            let v1257: i32 = *v1257;
            let v1258: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            US21::US21_Ok(v1258, 0i32, 0i32, 1i32, 1i32, v1)
        }
        US13::US13_Ok(v1260, v1261, v1262, v1263, v1264, v1265) => {
            let v1260: Rc<str> = v1260.clone();
            let v1261: i32 = *v1261;
            let v1262: i32 = *v1262;
            let v1263: i32 = *v1263;
            let v1264: i32 = *v1264;
            let v1265: i32 = *v1265;
            let v1266: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let v1267: Rc<UH0> = Rc::new(UH0::UH0_Cons(v1260, v1266));
            method92(v0.clone(), v1267, v1261, v1262, v1263, v1264, v1265)
        }
    };
    let v1293: US22 = match &v1270 {
        US21::US21_Error(v1284, v1285, v1286, v1287, v1288, v1289) => {
            let v1284: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1284.clone();
            let v1285: i32 = *v1285;
            let v1286: i32 = *v1286;
            let v1287: i32 = *v1287;
            let v1288: i32 = *v1288;
            let v1289: i32 = *v1289;
            let v1290: Rc<dyn Fn() -> Rc<str>> = closure37(v0.clone(), v1284, v1285, v1286, v1287, v1288, v1289);
            US22::US22_Error(v1290)
        }
        US21::US21_Ok(v1271, v1272, v1273, v1274, v1275, v1276) => {
            let v1271: Rc<UH0> = v1271.clone();
            let v1272: i32 = *v1272;
            let v1273: i32 = *v1273;
            let v1274: i32 = *v1274;
            let v1275: i32 = *v1275;
            let v1276: i32 = *v1276;
            let v1277: bool = v1272 >= v1276;
            let v1282: Rc<str> = if v1277 {
                let v1278: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v1278
            } else {
                let v1280: i32 = v1276.wrapping_sub(1i32);
                let v1281: Rc<str> = string_slice(&v0, v1272 as i64, v1280 as i64);
                v1281
            };
            US22::US22_Ok(v1271, v1282, v1273, v1274, v1275, v1276)
        }
    };
    let v1310: US23 = match &v1293 {
        US22::US22_Error(v1307) => {
            let v1307: Rc<dyn Fn() -> Rc<str>> = v1307.clone();
            US23::US23_Error(v1307)
        }
        US22::US22_Ok(v1294, v1295, v1296, v1297, v1298, v1299) => {
            let v1294: Rc<UH0> = v1294.clone();
            let v1295: Rc<str> = v1295.clone();
            let v1296: i32 = *v1296;
            let v1297: i32 = *v1297;
            let v1298: i32 = *v1298;
            let v1299: i32 = *v1299;
            let v1300: i32 = 0i32;
            let v1301: i32 = method93(v1294.clone(), v1300);
            let v1302: usize = ((v1301) as usize);
            let v1303: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::with_capacity(v1302)));
            let v1304: i32 = 0i32;
            let v1305: i32 = method94(v1303.clone(), v1294, v1304);
            US23::US23_Ok(v1303)
        }
    };
    match &v1310 {
        US23::US23_Error(v1313) => {
            let mut v1313: Rc<dyn Fn() -> Rc<str>> = v1313.clone();
            let v1314: Rc<str> = v1313();
            US20::US20_Error(v1314)
        }
        US23::US23_Ok(v1311) => {
            let v1311: Rc<RefCell<Vec<Rc<str>>>> = v1311.clone();
            US20::US20_Ok(v1311)
        }
    }
}
fn closure54() -> Rc<dyn Fn((Rc<str>)) -> std::string::String> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((Rc<str>)) -> std::string::String> = Rc::new(move |mut v0: (Rc<str>)| -> std::string::String {
        let mut v1: Rc<str> = (v0);
        let mut v3: &str = &*v1;
        let mut v5: std::string::String = String::from(v3);
        v5.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method95(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0;
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_16(v10);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v7)), v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("process.execute_with_options"); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_name"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_name"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v24, v25)), v8));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("arguments"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v25)), v9));
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v33));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v35, v36))));
    method13(v38)
}
fn ok_c56() -> Rc<dyn Fn(std::string::String) -> US24> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US24> = Rc::new(move |mut v0: std::string::String| -> US24 {
        US24::US24_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method96() -> Rc<dyn Fn(std::string::String) -> US24> {
    ok_c56()
}
fn error_c57() -> Rc<dyn Fn(std::string::String) -> US24> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US24> = Rc::new(move |mut v0: std::string::String| -> US24 {
        US24::US24_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method97() -> Rc<dyn Fn(std::string::String) -> US24> {
    error_c57()
}
fn method98() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[91m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_10(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method99(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: bool, mut v9: std::string::String) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0;
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_16(v10);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v7)), v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("process.stdio_line"); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("trace'"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("trace'"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("trace' = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = format_real_56(v8);
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v27));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v25));
    let mut v34: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v9)).s() });
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v34));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v35));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v37, v38))));
    method13(v40)
}
fn method100() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[90m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_10(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn format_real_102() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v1: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v0 }));
    let mut v2: Rc<str> = v1.borrow().l0.clone();
    v2
}
fn method101(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0;
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_16(v9);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v11, v12)), v7)), v10)), v8));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = format_real_102();
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    method13(v20)
}
fn on_stdout_c55(mut v0: bool) -> Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> {
    Rc::new(move |mut v1: Result<std::string::String, std::string::String>| -> std::string::String {
        let mut v2: Rc<dyn Fn(std::string::String) -> US24> = method96();
        let mut v3: Rc<dyn Fn(std::string::String) -> US24> = method97();
        let mut v4: US24 = match v1 { Ok(x) => v2(x), Err(e) => v3(e) };
        match &v4 {
            US24::US24_Error(v83) => {
                let mut v83: std::string::String = v83.clone();
                let mut v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                { let _ = spiral_trace_hold(&v85); };
                let mut v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                let v94: US1 = v92.borrow().l0.clone();
                let v99: i32 = match &v94 {
                    US1::US1_Critical => {
                        50i32
                    }
                    US1::US1_Debug => {
                        20i32
                    }
                    US1::US1_Info => {
                        30i32
                    }
                    US1::US1_Verbose => {
                        10i32
                    }
                    US1::US1_Warning => {
                        40i32
                    }
                };
                let v100: bool = v90.borrow().l0;
                let v101: bool = v100 == false;
                let v103: bool = if v101 {
                    false
                } else {
                    let mut v102: bool = 50i32 >= v99;
                    v102
                };
                let mut v104: bool = v103 == false;
                let mut v152: US3 = if v104 {
                    US3::US3_None
                } else {
                    { let _ = spiral_trace_hold(&v85); };
                    let (mut v108, mut v109, mut v110, mut v111, mut v112, mut v113): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v114: Rc<str> = method7(v108.clone(), v109.clone(), v110.clone(), v111.clone(), v112.clone(), v113.clone());
                    let mut v115: Rc<str> = method98();
                    let mut v116: Rc<str> = method99(v108.clone(), v109.clone(), v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v0, v83.clone());
                    { let _ = spiral_trace_hold(&v85); };
                    let (mut v119, mut v120, mut v121, mut v122, mut v123, mut v124): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v87);
                    let v125: i64 = v119.borrow().l0;
                    let v126: i64 = v125.wrapping_add(1i64);
                    v119.borrow_mut().l0 = v126;
                    let mut v127: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                    let v128: bool = cfg!(target_arch = "wasm32");
                    if v128 {
                        let v129: Rc<str> = v122.borrow().l0.clone();
                        let mut v130: bool = &*v129 == "";
                        let v138: Rc<str> = if v130 {
                            v116.clone()
                        } else {
                            let v131: bool = &*v116 == "";
                            if v131 {
                                let v132: Rc<str> = v122.borrow().l0.clone();
                                v132.clone()
                            } else {
                                let v133: Rc<str> = v122.borrow().l0.clone();
                                let v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let v136: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v133, v134)), v116));
                                v136.clone()
                            }
                        };
                        let v140: usize = v138.chars().count();
                        let v141: i32 = ((v140) as i32);
                        let v142: i32 = v141.wrapping_add(14999i32);
                        let v143: i32 = v142.wrapping_div(15000i32);
                        let v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let v145: bool = v116 != v144 ;
                        let mut v147: bool = if v145 {
                            let v146: bool = v143 <= 1i32;
                            v146
                        } else {
                            false
                        };
                        if v147 {
                            v122.borrow_mut().l0 = v138.clone();
                            ()
                        } else {
                            v122.borrow_mut().l0 = v144.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v138); };
                            ()
                        }
                    } else {
                        println!("{}", v116);
                        ()
                    };
                    let mut v150: Rc<dyn Fn(Rc<str>) -> ()> = v120.borrow().l0.clone();
                    v150(v116.clone());
                    US3::US3_Some(v119.clone(), v120.clone(), v121.clone(), v122.clone(), v123.clone(), v124.clone())
                };
                let v153: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v83));
                let mut v155: &str = &*v153;
                let v157: std::string::String = String::from(v155);
                v157.clone()
            }
            US24::US24_Ok(v5) => {
                let mut v5: std::string::String = v5.clone();
                let mut v7: std::string::String = v5.clone();
                let mut v9: Rc<str> = Rc::<str>::from(String::as_str(&v7));
                let mut v10: Rc<str> = Rc::<str>::from(format!("> {}", v9));
                if v0 {
                    let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    { let _ = spiral_trace_hold(&v12); };
                    let mut v14: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                    let (mut v15, mut v16, mut v17, mut v18, mut v19, mut v20): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
                    let v21: US1 = v19.borrow().l0.clone();
                    let mut v26: i32 = match &v21 {
                        US1::US1_Critical => {
                            50i32
                        }
                        US1::US1_Debug => {
                            20i32
                        }
                        US1::US1_Info => {
                            30i32
                        }
                        US1::US1_Verbose => {
                            10i32
                        }
                        US1::US1_Warning => {
                            40i32
                        }
                    };
                    let mut v27: bool = v17.borrow().l0;
                    let mut v28: bool = v27 == false;
                    let v30: bool = if v28 {
                        false
                    } else {
                        let mut v29: bool = 10i32 >= v26;
                        v29
                    };
                    let mut v31: bool = v30 == false;
                    let mut v82: US3 = if v31 {
                        US3::US3_None
                    } else {
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v35, mut v36, mut v37, mut v38, mut v39, mut v40): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
                        let v41: Rc<str> = method7(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone());
                        let v42: Rc<str> = method100();
                        let v43: bool = &*v10 == "";
                        let mut v46: Rc<str> = if v43 {
                            let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v44.clone()
                        } else {
                            method101(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v10.clone())
                        };
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v49, mut v50, mut v51, mut v52, mut v53, mut v54): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
                        let v55: i64 = v49.borrow().l0;
                        let v56: i64 = v55.wrapping_add(1i64);
                        v49.borrow_mut().l0 = v56;
                        let mut v57: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                        let v58: bool = cfg!(target_arch = "wasm32");
                        if v58 {
                            let mut v59: Rc<str> = v52.borrow().l0.clone();
                            let v60: bool = &*v59 == "";
                            let mut v68: Rc<str> = if v60 {
                                v46.clone()
                            } else {
                                let v61: bool = &*v46 == "";
                                if v61 {
                                    let v62: Rc<str> = v52.borrow().l0.clone();
                                    v62.clone()
                                } else {
                                    let mut v63: Rc<str> = v52.borrow().l0.clone();
                                    let v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                    let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v63, v64)), v46));
                                    v66.clone()
                                }
                            };
                            let mut v70: usize = v68.chars().count();
                            let v71: i32 = ((v70) as i32);
                            let v72: i32 = v71.wrapping_add(14999i32);
                            let mut v73: i32 = v72.wrapping_div(15000i32);
                            let v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v75: bool = v46 != v74 ;
                            let mut v77: bool = if v75 {
                                let mut v76: bool = v73 <= 1i32;
                                v76
                            } else {
                                false
                            };
                            if v77 {
                                v52.borrow_mut().l0 = v68.clone();
                                ()
                            } else {
                                v52.borrow_mut().l0 = v74.clone();
                                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v68); };
                                ()
                            }
                        } else {
                            println!("{}", v46);
                            ()
                        };
                        let mut v80: Rc<dyn Fn(Rc<str>) -> ()> = v50.borrow().l0.clone();
                        v80(v46.clone());
                        US3::US3_Some(v49.clone(), v50.clone(), v51.clone(), v52.clone(), v53.clone(), v54.clone())
                    };
                    ()
                } else {
                    println!("{}", v10);
                    ()
                };
                v5.clone()
            }
        }
    })
}
fn on_stderr_c58(mut v0: bool) -> Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> {
    Rc::new(move |mut v1: Result<std::string::String, std::string::String>| -> std::string::String {
        let mut v2: Rc<dyn Fn(std::string::String) -> US24> = method96();
        let mut v3: Rc<dyn Fn(std::string::String) -> US24> = method97();
        let mut v4: US24 = match v1 { Ok(x) => v2(x), Err(e) => v3(e) };
        match &v4 {
            US24::US24_Error(v88) => {
                let mut v88: std::string::String = v88.clone();
                let v90: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                { let _ = spiral_trace_hold(&v90); };
                let v92: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                let (mut v93, mut v94, mut v95, mut v96, mut v97, mut v98): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v92);
                let v99: US1 = v97.borrow().l0.clone();
                let mut v104: i32 = match &v99 {
                    US1::US1_Critical => {
                        50i32
                    }
                    US1::US1_Debug => {
                        20i32
                    }
                    US1::US1_Info => {
                        30i32
                    }
                    US1::US1_Verbose => {
                        10i32
                    }
                    US1::US1_Warning => {
                        40i32
                    }
                };
                let mut v105: bool = v95.borrow().l0;
                let v106: bool = v105 == false;
                let mut v108: bool = if v106 {
                    false
                } else {
                    let v107: bool = 50i32 >= v104;
                    v107
                };
                let mut v109: bool = v108 == false;
                let v157: US3 = if v109 {
                    US3::US3_None
                } else {
                    { let _ = spiral_trace_hold(&v90); };
                    let (mut v113, mut v114, mut v115, mut v116, mut v117, mut v118): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v92);
                    let mut v119: Rc<str> = method7(v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone());
                    let v120: Rc<str> = method98();
                    let mut v121: Rc<str> = method99(v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone(), v119.clone(), v120.clone(), v0, v88.clone());
                    { let _ = spiral_trace_hold(&v90); };
                    let (mut v124, mut v125, mut v126, mut v127, mut v128, mut v129): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v92);
                    let mut v130: i64 = v124.borrow().l0;
                    let v131: i64 = v130.wrapping_add(1i64);
                    v124.borrow_mut().l0 = v131;
                    let v132: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                    let v133: bool = cfg!(target_arch = "wasm32");
                    if v133 {
                        let v134: Rc<str> = v127.borrow().l0.clone();
                        let v135: bool = &*v134 == "";
                        let v143: Rc<str> = if v135 {
                            v121.clone()
                        } else {
                            let v136: bool = &*v121 == "";
                            if v136 {
                                let v137: Rc<str> = v127.borrow().l0.clone();
                                v137.clone()
                            } else {
                                let v138: Rc<str> = v127.borrow().l0.clone();
                                let mut v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let v141: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v138, v139)), v121));
                                v141.clone()
                            }
                        };
                        let v145: usize = v143.chars().count();
                        let v146: i32 = ((v145) as i32);
                        let mut v147: i32 = v146.wrapping_add(14999i32);
                        let mut v148: i32 = v147.wrapping_div(15000i32);
                        let v149: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v150: bool = v121 != v149 ;
                        let mut v152: bool = if v150 {
                            let mut v151: bool = v148 <= 1i32;
                            v151
                        } else {
                            false
                        };
                        if v152 {
                            v127.borrow_mut().l0 = v143.clone();
                            ()
                        } else {
                            v127.borrow_mut().l0 = v149.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v143); };
                            ()
                        }
                    } else {
                        println!("{}", v121);
                        ()
                    };
                    let mut v155: Rc<dyn Fn(Rc<str>) -> ()> = v125.borrow().l0.clone();
                    v155(v121.clone());
                    US3::US3_Some(v124.clone(), v125.clone(), v126.clone(), v127.clone(), v128.clone(), v129.clone())
                };
                let v158: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v88));
                let v160: &str = &*v158;
                let mut v162: std::string::String = String::from(v160);
                v162.clone()
            }
            US24::US24_Ok(v5) => {
                let mut v5: std::string::String = v5.clone();
                let mut v7: std::string::String = v5.clone();
                let mut v9: Rc<str> = Rc::<str>::from(String::as_str(&v7));
                let mut v10: Rc<str> = Rc::<str>::from(format!("! {}", v9));
                if v0 {
                    let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    { let _ = spiral_trace_hold(&v12); };
                    let mut v14: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                    let (mut v15, mut v16, mut v17, mut v18, mut v19, mut v20): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
                    let v21: US1 = v19.borrow().l0.clone();
                    let mut v26: i32 = match &v21 {
                        US1::US1_Critical => {
                            50i32
                        }
                        US1::US1_Debug => {
                            20i32
                        }
                        US1::US1_Info => {
                            30i32
                        }
                        US1::US1_Verbose => {
                            10i32
                        }
                        US1::US1_Warning => {
                            40i32
                        }
                    };
                    let mut v27: bool = v17.borrow().l0;
                    let mut v28: bool = v27 == false;
                    let v30: bool = if v28 {
                        false
                    } else {
                        let mut v29: bool = 10i32 >= v26;
                        v29
                    };
                    let mut v31: bool = v30 == false;
                    let mut v82: US3 = if v31 {
                        US3::US3_None
                    } else {
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v35, mut v36, mut v37, mut v38, mut v39, mut v40): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
                        let v41: Rc<str> = method7(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone());
                        let v42: Rc<str> = method100();
                        let v43: bool = &*v10 == "";
                        let mut v46: Rc<str> = if v43 {
                            let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v44.clone()
                        } else {
                            method101(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v10.clone())
                        };
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v49, mut v50, mut v51, mut v52, mut v53, mut v54): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
                        let v55: i64 = v49.borrow().l0;
                        let v56: i64 = v55.wrapping_add(1i64);
                        v49.borrow_mut().l0 = v56;
                        let mut v57: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                        let v58: bool = cfg!(target_arch = "wasm32");
                        if v58 {
                            let mut v59: Rc<str> = v52.borrow().l0.clone();
                            let v60: bool = &*v59 == "";
                            let mut v68: Rc<str> = if v60 {
                                v46.clone()
                            } else {
                                let v61: bool = &*v46 == "";
                                if v61 {
                                    let v62: Rc<str> = v52.borrow().l0.clone();
                                    v62.clone()
                                } else {
                                    let mut v63: Rc<str> = v52.borrow().l0.clone();
                                    let v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                    let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v63, v64)), v46));
                                    v66.clone()
                                }
                            };
                            let mut v70: usize = v68.chars().count();
                            let v71: i32 = ((v70) as i32);
                            let v72: i32 = v71.wrapping_add(14999i32);
                            let mut v73: i32 = v72.wrapping_div(15000i32);
                            let v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v75: bool = v46 != v74 ;
                            let mut v77: bool = if v75 {
                                let mut v76: bool = v73 <= 1i32;
                                v76
                            } else {
                                false
                            };
                            if v77 {
                                v52.borrow_mut().l0 = v68.clone();
                                ()
                            } else {
                                v52.borrow_mut().l0 = v74.clone();
                                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v68); };
                                ()
                            }
                        } else {
                            println!("{}", v46);
                            ()
                        };
                        let mut v80: Rc<dyn Fn(Rc<str>) -> ()> = v50.borrow().l0.clone();
                        v80(v46.clone());
                        US3::US3_Some(v49.clone(), v50.clone(), v51.clone(), v52.clone(), v53.clone(), v54.clone())
                    };
                    ()
                } else {
                    println!("{}", v10);
                    ()
                };
                let mut v83: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v5));
                let mut v85: &str = &*v83;
                let mut v87: std::string::String = String::from(v85);
                v87.clone()
            }
        }
    })
}
fn method103(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_16(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("process.execute_with_options / child error"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v8));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_name"); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v26)), v9)), v29));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("arguments"); } LIT.with(|lit| lit.clone()) };
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v26)), v10));
    let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v39));
    let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v41, v42))));
    method13(v44)
}
fn method104(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_16(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("process.execute_with_options / output error"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v8));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_name"); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v26)), v9)), v29));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("arguments"); } LIT.with(|lit| lit.clone()) };
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v26)), v10));
    let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v39));
    let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v41, v42))));
    method13(v44)
}
fn method105(mut v0: Option<i32>) -> Option<i32> {
    v0
}
fn closure59() -> Rc<dyn Fn((i32)) -> US25> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((i32)) -> US25> = Rc::new(move |mut v0: (i32)| -> US25 {
        let mut v1: i32 = (v0);
        US25::US25_Some(v1)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure60() -> Rc<dyn Fn((std::string::String)) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::string::String)) -> Rc<str>> = Rc::new(move |mut v0: (std::string::String)| -> Rc<str> {
        let mut v1: std::string::String = (v0);
        let mut v3: Rc<str> = Rc::<str>::from(String::as_str(&v1));
        v3.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method106(mut v0: Vec<Rc<str>>) -> Vec<Rc<str>> {
    v0
}
fn method107(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 <= 0i32;
        if v2 {
            return -1i32;
        } else {
            let mut v3: i32 = v1.wrapping_sub(1i32);
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v11: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'\t';
                if v6 {
                    true
                } else {
                    let mut v7: bool = v4 == b'\r';
                    if v7 {
                        true
                    } else {
                        let mut v8: bool = v4 == b'\n';
                        v8
                    }
                }
            };
            if v11 {
                (v0, v1) = (v0.clone(), v3);
                continue;
            } else {
                return v3;
            }
        }
    }
}
fn method108(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: i32, mut v10: i32) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_16(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("process.execute_with_options / result"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_name"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_name"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v8));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v26));
    let mut v34: Rc<str> = format_real_71(v9);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v29));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("std_trace_len"); } LIT.with(|lit| lit.clone()) };
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v26));
    let v40: Rc<str> = format_real_71(v10);
    let v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
    let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v43, v44))));
    method13(v46)
}
fn execute_with_options_68(mut v0: Rc<str>, mut v1: Option<std::sync::Arc<std::sync::atomic::AtomicBool>>, mut v2: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>>, mut v3: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>>, mut v4: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>>, mut v5: bool, mut v6: Option<Rc<str>>, mut v7: bool) -> (i32, Rc<str>) {
    let mut v8: Rc<str> = method69(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6.clone(), v7);
    let mut v9: US11 = split_command_70(v8.clone());
    let (mut v19, mut v20): (Rc<str>, US0) = match &v9 {
        US11::US11_Error(v12) => {
            let mut v12: Rc<str> = v12.clone();
            let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("resultm.get / Error x: "); } LIT.with(|lit| lit.clone()) };
            let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, (&SpiralDebug(&v12)).show()));
            std::panic::panic_any::<std::string::String>(format!("{}", v14.clone()))
        }
        US11::US11_Ok(v10, v11) => {
            let mut v10: Rc<str> = v10.clone();
            let mut v11: US0 = v11.clone();
            (v10.clone(), v11.clone())
        }
    };
    let v24: Rc<str> = match &v20 {
        US0::US0_None => {
            let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v22.clone()
        }
        US0::US0_Some(v21) => {
            let v21: Rc<str> = v21.clone();
            v21.clone()
        }
    };
    let mut v25: US20 = split_args_79(v24.clone());
    let mut v32: Rc<RefCell<Vec<Rc<str>>>> = match &v25 {
        US20::US20_Error(v27) => {
            let mut v27: Rc<str> = v27.clone();
            let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("resultm.get / Error x: "); } LIT.with(|lit| lit.clone()) };
            let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, (&SpiralDebug(&v27)).show()));
            std::panic::panic_any::<std::string::String>(format!("{}", v29.clone()))
        }
        US20::US20_Ok(v26) => {
            let mut v26: Rc<RefCell<Vec<Rc<str>>>> = v26.clone();
            v26.clone()
        }
    };
    let mut v33: Vec<Rc<str>> = (v32).borrow().clone();
    let mut v35: Rc<dyn Fn((Rc<str>)) -> std::string::String> = closure54();
    let v36: Vec<std::string::String> = v33.iter().map(|x| v35(x.clone())).collect::<Vec<_>>();
    let mut v38: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    { let _ = spiral_trace_hold(&v38); };
    let v40: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
    let (mut v41, mut v42, mut v43, mut v44, mut v45, mut v46): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
    let mut v47: US1 = v45.borrow().l0.clone();
    let mut v52: i32 = match &v47 {
        US1::US1_Critical => {
            50i32
        }
        US1::US1_Debug => {
            20i32
        }
        US1::US1_Info => {
            30i32
        }
        US1::US1_Verbose => {
            10i32
        }
        US1::US1_Warning => {
            40i32
        }
    };
    let v53: bool = v43.borrow().l0;
    let v54: bool = v53 == false;
    let v56: bool = if v54 {
        false
    } else {
        let v55: bool = 20i32 >= v52;
        v55
    };
    let mut v57: bool = v56 == false;
    let v106: US3 = if v57 {
        US3::US3_None
    } else {
        { let _ = spiral_trace_hold(&v38); };
        let (mut v61, mut v62, mut v63, mut v64, mut v65, mut v66): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
        let v67: Rc<str> = method7(v61.clone(), v62.clone(), v63.clone(), v64.clone(), v65.clone(), v66.clone());
        let mut v68: Rc<str> = method53();
        let v69: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v36)).s() });
        let mut v70: Rc<str> = method95(v61.clone(), v62.clone(), v63.clone(), v64.clone(), v65.clone(), v66.clone(), v67.clone(), v68.clone(), v19.clone(), v69.clone());
        { let _ = spiral_trace_hold(&v38); };
        let (mut v73, mut v74, mut v75, mut v76, mut v77, mut v78): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
        let mut v79: i64 = v73.borrow().l0;
        let mut v80: i64 = v79.wrapping_add(1i64);
        v73.borrow_mut().l0 = v80;
        let mut v81: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
        let mut v82: bool = cfg!(target_arch = "wasm32");
        if v82 {
            let mut v83: Rc<str> = v76.borrow().l0.clone();
            let mut v84: bool = &*v83 == "";
            let v92: Rc<str> = if v84 {
                v70.clone()
            } else {
                let mut v85: bool = &*v70 == "";
                if v85 {
                    let mut v86: Rc<str> = v76.borrow().l0.clone();
                    v86.clone()
                } else {
                    let mut v87: Rc<str> = v76.borrow().l0.clone();
                    let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v90: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v87, v88)), v70));
                    v90.clone()
                }
            };
            let v94: usize = v92.chars().count();
            let v95: i32 = ((v94) as i32);
            let v96: i32 = v95.wrapping_add(14999i32);
            let v97: i32 = v96.wrapping_div(15000i32);
            let mut v98: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v99: bool = v70 != v98 ;
            let v101: bool = if v99 {
                let v100: bool = v97 <= 1i32;
                v100
            } else {
                false
            };
            if v101 {
                v76.borrow_mut().l0 = v92.clone();
                ()
            } else {
                v76.borrow_mut().l0 = v98.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v92); };
                ()
            }
        } else {
            println!("{}", v70);
            ()
        };
        let mut v104: Rc<dyn Fn(Rc<str>) -> ()> = v74.borrow().l0.clone();
        v104(v70.clone());
        US3::US3_Some(v73.clone(), v74.clone(), v75.clone(), v76.clone(), v77.clone(), v78.clone())
    };
    let mut v108: Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> = on_stdout_c55(v5);
    let mut v109: Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> = on_stderr_c58(v5);
    let (mut v110, mut v111, mut v112, mut v113): (i32, Option<i32>, Option<std::string::String>, Vec<std::string::String>) = { let wd: Option<std::rc::Rc<str>> = v6.clone(); let stdin_fn: Option<std::rc::Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>)>> = v4.clone(); let token: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = v1.clone(); let stderr_on: bool = v7; let mut c = std::process::Command::new(&*v19); c.args(&*v36); c.stdout(std::process::Stdio::piped()); c.stderr(std::process::Stdio::piped()); c.stdin(std::process::Stdio::piped()); if let Some(d) = &wd { c.current_dir(&**d); } for (k, v) in v2.borrow().iter() { c.env(&**k, &**v); } match c.spawn() { Err(e) => (1i32, None, Some(format!("{}", e)), Vec::new()), Ok(mut child) => { let out = child.stdout.take().unwrap(); let err = child.stderr.take().unwrap(); let (tx, rx) = std::sync::mpsc::channel::<(bool, Result<std::string::String, std::string::String>)>(); let tx2 = tx.clone(); let h1 = std::thread::spawn(move || { for l in std::io::BufRead::lines(std::io::BufReader::new(encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(out))) { if tx.send((false, l.map_err(|e| format!("{}", e)))).is_err() { break; } } }); let h2 = std::thread::spawn(move || { for l in std::io::BufRead::lines(std::io::BufReader::new(encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(err))) { if stderr_on && tx2.send((true, l.map_err(|e| format!("{}", e)))).is_err() { break; } } }); if let (Some(f), Some(s)) = (&stdin_fn, child.stdin.take()) { let a = std::sync::Arc::new(std::sync::Mutex::new(s)); f(a.clone()); let _ = std::io::Write::flush(&mut *a.lock().unwrap()); } let mut lines: Vec<std::string::String> = Vec::new(); let mut cancelled = false; loop { if let Some(t) = &token { if t.load(std::sync::atomic::Ordering::SeqCst) { let _ = child.kill(); cancelled = true; break; } } match rx.recv_timeout(std::time::Duration::from_millis(100)) { Ok((false, l)) => lines.push(v108(l)), Ok((true, l)) => lines.push(v109(l)), Err(std::sync::mpsc::RecvTimeoutError::Timeout) => {}, Err(std::sync::mpsc::RecvTimeoutError::Disconnected) => break } } if !cancelled { let _ = h1.join(); let _ = h2.join(); } match child.wait() { Ok(s) => (0i32, s.code(), None, lines), Err(e) => (2i32, None, Some(format!("{}", e)), lines) } } } };
    let v114: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v116: &str = &*v114;
    let v118: std::string::String = String::from(v116);
    let v120: std::string::String = v118.clone();
    let mut v121: std::string::String = v112.unwrap_or(v120);
    let v123: Rc<str> = Rc::<str>::from(String::as_str(&v121));
    let mut v124: bool = v110 == 1i32;
    let (mut v293, mut v294): (i32, Rc<str>) = if v124 {
        { let _ = spiral_trace_hold(&v38); };
        let (mut v127, mut v128, mut v129, mut v130, mut v131, mut v132): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
        let v133: US1 = v131.borrow().l0.clone();
        let v138: i32 = match &v133 {
            US1::US1_Critical => {
                50i32
            }
            US1::US1_Debug => {
                20i32
            }
            US1::US1_Info => {
                30i32
            }
            US1::US1_Verbose => {
                10i32
            }
            US1::US1_Warning => {
                40i32
            }
        };
        let mut v139: bool = v129.borrow().l0;
        let v140: bool = v139 == false;
        let v142: bool = if v140 {
            false
        } else {
            let v141: bool = 50i32 >= v138;
            v141
        };
        let v143: bool = v142 == false;
        let v191: US3 = if v143 {
            US3::US3_None
        } else {
            { let _ = spiral_trace_hold(&v38); };
            let (mut v147, mut v148, mut v149, mut v150, mut v151, mut v152): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
            let v153: Rc<str> = method7(v147.clone(), v148.clone(), v149.clone(), v150.clone(), v151.clone(), v152.clone());
            let v154: Rc<str> = method98();
            let mut v155: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v36)).s() });
            let v156: Rc<str> = method103(v147.clone(), v148.clone(), v149.clone(), v150.clone(), v151.clone(), v152.clone(), v153.clone(), v154.clone(), v123.clone(), v19.clone(), v155.clone());
            { let _ = spiral_trace_hold(&v38); };
            let (mut v159, mut v160, mut v161, mut v162, mut v163, mut v164): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
            let mut v165: i64 = v159.borrow().l0;
            let mut v166: i64 = v165.wrapping_add(1i64);
            v159.borrow_mut().l0 = v166;
            let mut v167: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v168: bool = cfg!(target_arch = "wasm32");
            if v168 {
                let v169: Rc<str> = v162.borrow().l0.clone();
                let v170: bool = &*v169 == "";
                let mut v178: Rc<str> = if v170 {
                    v156.clone()
                } else {
                    let v171: bool = &*v156 == "";
                    if v171 {
                        let mut v172: Rc<str> = v162.borrow().l0.clone();
                        v172.clone()
                    } else {
                        let v173: Rc<str> = v162.borrow().l0.clone();
                        let v174: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v176: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v173, v174)), v156));
                        v176.clone()
                    }
                };
                let v180: usize = v178.chars().count();
                let mut v181: i32 = ((v180) as i32);
                let mut v182: i32 = v181.wrapping_add(14999i32);
                let mut v183: i32 = v182.wrapping_div(15000i32);
                let v184: bool = v156 != v114 ;
                let v186: bool = if v184 {
                    let v185: bool = v183 <= 1i32;
                    v185
                } else {
                    false
                };
                if v186 {
                    v162.borrow_mut().l0 = v178.clone();
                    ()
                } else {
                    v162.borrow_mut().l0 = v114.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v178); };
                    ()
                }
            } else {
                println!("{}", v156);
                ()
            };
            let mut v189: Rc<dyn Fn(Rc<str>) -> ()> = v160.borrow().l0.clone();
            v189(v156.clone());
            US3::US3_Some(v159.clone(), v160.clone(), v161.clone(), v162.clone(), v163.clone(), v164.clone())
        };
        (-1i32, v123.clone())
    } else {
        let v192: bool = v110 == 2i32;
        if v192 {
            { let _ = spiral_trace_hold(&v38); };
            let (mut v195, mut v196, mut v197, mut v198, mut v199, mut v200): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
            let mut v201: US1 = v199.borrow().l0.clone();
            let v206: i32 = match &v201 {
                US1::US1_Critical => {
                    50i32
                }
                US1::US1_Debug => {
                    20i32
                }
                US1::US1_Info => {
                    30i32
                }
                US1::US1_Verbose => {
                    10i32
                }
                US1::US1_Warning => {
                    40i32
                }
            };
            let v207: bool = v197.borrow().l0;
            let v208: bool = v207 == false;
            let v210: bool = if v208 {
                false
            } else {
                let v209: bool = 50i32 >= v206;
                v209
            };
            let v211: bool = v210 == false;
            let v259: US3 = if v211 {
                US3::US3_None
            } else {
                { let _ = spiral_trace_hold(&v38); };
                let (mut v215, mut v216, mut v217, mut v218, mut v219, mut v220): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
                let mut v221: Rc<str> = method7(v215.clone(), v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone());
                let mut v222: Rc<str> = method98();
                let v223: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v36)).s() });
                let v224: Rc<str> = method104(v215.clone(), v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone(), v221.clone(), v222.clone(), v123.clone(), v19.clone(), v223.clone());
                { let _ = spiral_trace_hold(&v38); };
                let (mut v227, mut v228, mut v229, mut v230, mut v231, mut v232): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
                let v233: i64 = v227.borrow().l0;
                let v234: i64 = v233.wrapping_add(1i64);
                v227.borrow_mut().l0 = v234;
                let mut v235: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let mut v236: bool = cfg!(target_arch = "wasm32");
                if v236 {
                    let v237: Rc<str> = v230.borrow().l0.clone();
                    let v238: bool = &*v237 == "";
                    let v246: Rc<str> = if v238 {
                        v224.clone()
                    } else {
                        let v239: bool = &*v224 == "";
                        if v239 {
                            let v240: Rc<str> = v230.borrow().l0.clone();
                            v240.clone()
                        } else {
                            let v241: Rc<str> = v230.borrow().l0.clone();
                            let v242: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v244: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v241, v242)), v224));
                            v244.clone()
                        }
                    };
                    let mut v248: usize = v246.chars().count();
                    let mut v249: i32 = ((v248) as i32);
                    let mut v250: i32 = v249.wrapping_add(14999i32);
                    let v251: i32 = v250.wrapping_div(15000i32);
                    let v252: bool = v224 != v114 ;
                    let v254: bool = if v252 {
                        let v253: bool = v251 <= 1i32;
                        v253
                    } else {
                        false
                    };
                    if v254 {
                        v230.borrow_mut().l0 = v246.clone();
                        ()
                    } else {
                        v230.borrow_mut().l0 = v114.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v246); };
                        ()
                    }
                } else {
                    println!("{}", v224);
                    ()
                };
                let mut v257: Rc<dyn Fn(Rc<str>) -> ()> = v228.borrow().l0.clone();
                v257(v224.clone());
                US3::US3_Some(v227.clone(), v228.clone(), v229.clone(), v230.clone(), v231.clone(), v232.clone())
            };
            (-2i32, v123.clone())
        } else {
            let v260: Option<i32> = method105(v111.clone());
            let mut v261: Rc<dyn Fn((i32)) -> US25> = closure59();
            let mut v262: Option<US25> = v260.map(|x| v261(x));
            let v264: US25 = US25::US25_None;
            let v265: US25 = v264.clone();
            let v266: US25 = v262.unwrap_or(v265);
            let (mut v271, mut v272): (i32, Rc<str>) = match &v266 {
                US25::US25_None => {
                    let v268: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("process.execute_with_options / exit_code=None"); } LIT.with(|lit| lit.clone()) };
                    (-1i32, v268.clone())
                }
                US25::US25_Some(v267) => {
                    let v267: i32 = *v267;
                    (v267, v114.clone())
                }
            };
            let mut v274: Rc<dyn Fn((std::string::String)) -> Rc<str>> = closure60();
            let v275: Vec<Rc<str>> = v113.iter().map(|x| v274(x.clone())).collect::<Vec<_>>();
            let v276: Vec<Rc<str>> = method106(v275.clone());
            let v277: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v276));
            let v278: Rc<Vec<Rc<str>>> = Rc::new(v277.borrow().clone());
            let v279: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            let v280: Rc<str> = Rc::<str>::from(v278.iter().map(|x| x.to_string()).collect::<Vec<_>>().join(&*v279));
            let v281: i32 = (v280.clone().len() as i32);
            let v282: i32 = 0i32;
            let v283: i32 = method14(v280.clone(), v281, v282);
            let v284: i32 = v281.wrapping_sub(1i32);
            let v285: Rc<str> = string_slice(&v280.clone(), v283 as i64, v284 as i64);
            let v286: i32 = (v285.clone().len() as i32);
            let mut v287: i32 = method107(v285.clone(), v286);
            let v288: Rc<str> = string_slice(&v285.clone(), 0i32 as i64, v287 as i64);
            let v289: bool = &*v288 == "";
            let mut v290: Rc<str> = if v289 {
                v272.clone()
            } else {
                v288.clone()
            };
            (v271, v290.clone())
        }
    };
    { let _ = spiral_trace_hold(&v38); };
    let (mut v297, mut v298, mut v299, mut v300, mut v301, mut v302): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
    let v303: US1 = v301.borrow().l0.clone();
    let v308: i32 = match &v303 {
        US1::US1_Critical => {
            50i32
        }
        US1::US1_Debug => {
            20i32
        }
        US1::US1_Info => {
            30i32
        }
        US1::US1_Verbose => {
            10i32
        }
        US1::US1_Warning => {
            40i32
        }
    };
    let v309: bool = v299.borrow().l0;
    let v310: bool = v309 == false;
    let v312: bool = if v310 {
        false
    } else {
        let v311: bool = 10i32 >= v308;
        v311
    };
    let v313: bool = v312 == false;
    let v361: US3 = if v313 {
        US3::US3_None
    } else {
        { let _ = spiral_trace_hold(&v38); };
        let (mut v317, mut v318, mut v319, mut v320, mut v321, mut v322): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
        let v323: Rc<str> = method7(v317.clone(), v318.clone(), v319.clone(), v320.clone(), v321.clone(), v322.clone());
        let v324: Rc<str> = method100();
        let v325: i32 = (v294.clone().len() as i32);
        let v326: Rc<str> = method108(v317.clone(), v318.clone(), v319.clone(), v320.clone(), v321.clone(), v322.clone(), v323.clone(), v324.clone(), v19.clone(), v293, v325);
        { let _ = spiral_trace_hold(&v38); };
        let (mut v329, mut v330, mut v331, mut v332, mut v333, mut v334): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v40);
        let v335: i64 = v329.borrow().l0;
        let v336: i64 = v335.wrapping_add(1i64);
        v329.borrow_mut().l0 = v336;
        let v337: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
        let v338: bool = cfg!(target_arch = "wasm32");
        if v338 {
            let v339: Rc<str> = v332.borrow().l0.clone();
            let v340: bool = &*v339 == "";
            let v348: Rc<str> = if v340 {
                v326.clone()
            } else {
                let v341: bool = &*v326 == "";
                if v341 {
                    let v342: Rc<str> = v332.borrow().l0.clone();
                    v342.clone()
                } else {
                    let v343: Rc<str> = v332.borrow().l0.clone();
                    let v344: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v346: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v343, v344)), v326));
                    v346.clone()
                }
            };
            let v350: usize = v348.chars().count();
            let v351: i32 = ((v350) as i32);
            let v352: i32 = v351.wrapping_add(14999i32);
            let v353: i32 = v352.wrapping_div(15000i32);
            let v354: bool = v326 != v114 ;
            let v356: bool = if v354 {
                let v355: bool = v353 <= 1i32;
                v355
            } else {
                false
            };
            if v356 {
                v332.borrow_mut().l0 = v348.clone();
                ()
            } else {
                v332.borrow_mut().l0 = v114.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v348); };
                ()
            }
        } else {
            println!("{}", v326);
            ()
        };
        let mut v359: Rc<dyn Fn(Rc<str>) -> ()> = v330.borrow().l0.clone();
        v359(v326.clone());
        US3::US3_Some(v329.clone(), v330.clone(), v331.clone(), v332.clone(), v333.clone(), v334.clone())
    };
    (v293, v294.clone())
}
fn method110(mut v0: Option<usize>) -> Option<usize> {
    v0
}
fn closure61() -> Rc<dyn Fn((usize)) -> i32> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((usize)) -> i32> = Rc::new(move |mut v0: (usize)| -> i32 {
        let mut v1: usize = (v0);
        let mut v2: i32 = ((v1) as i32);
        v2
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fix_paths_109(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>) -> (Rc<str>, Rc<str>) {
    let mut v3: Rc<str> = get_file_name_32(v1.clone());
    let mut v4: Rc<str> = method39(v2.clone(), v3.clone());
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
    let mut v6: Option<usize> = v1.rfind(&*v5);
    let mut v7: Option<usize> = method110(v6.clone());
    let mut v8: Rc<dyn Fn((usize)) -> i32> = closure61();
    let mut v9: Option<i32> = v7.map(|x| v8(x));
    let mut v11: i32 = v9.unwrap_or(-1i32);
    let mut v12: i32 = v11.wrapping_sub(1i32);
    let mut v13: Rc<str> = string_slice(&v1.clone(), 0i32 as i64, v12 as i64);
    let mut v14: Option<usize> = v4.rfind(&*v5);
    let v15: Option<usize> = method110(v14.clone());
    let mut v16: Option<i32> = v15.map(|x| v8(x));
    let v18: i32 = v16.unwrap_or(-1i32);
    let v19: i32 = v18.wrapping_sub(1i32);
    let mut v20: Rc<str> = string_slice(&v4.clone(), 0i32 as i64, v19 as i64);
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".md"); } LIT.with(|lit| lit.clone()) };
    let mut v22: bool = v0.ends_with(&*v21);
    let v23: bool = v22 == false;
    let mut v28: Rc<str> = if v23 {
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v1, v5)), v0));
        v25.clone()
    } else {
        let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v5)), v0));
        v27.clone()
    };
    let mut v33: Rc<str> = if v23 {
        let v30: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v4, v5)), v0));
        v30.clone()
    } else {
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v5)), v0));
        v32.clone()
    };
    (v28.clone(), v33.clone())
}
fn closure62() -> Rc<dyn Fn((u8)) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((u8)) -> Rc<str>> = Rc::new(move |mut v0: (u8)| -> Rc<str> {
        let mut v1: u8 = (v0);
        let mut v3: std::string::String = format!("{:02x}", v1);
        let mut v5: Rc<str> = Rc::<str>::from(String::as_str(&v3));
        v5.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method111(mut v0: Rc<Vec<Rc<str>>>, mut v1: i32, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: usize = ((v1) as usize);
            let mut v5: Rc<str> = (v0)[v4].clone();
            let mut v6: i32 = v1.wrapping_sub(1i32);
            let mut v7: Rc<UH0> = Rc::new(UH0::UH0_Cons(v5.clone(), v2.clone()));
            (v0, v1, v2) = (v0.clone(), v6, v7.clone());
            continue;
        }
    }
}
fn method112() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    v0
}
fn closure63() -> Rc<dyn Fn(std::io::Error) -> std::string::String> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::io::Error) -> std::string::String> = Rc::new(move |mut v0: std::io::Error| -> std::string::String {
        let mut v2: std::string::String = format!("{}", v0);
        v2.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method113() -> Rc<dyn Fn(std::io::Error) -> std::string::String> {
    closure63()
}
fn ok_c64() -> Rc<dyn Fn(Rc<str>) -> US27> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> US27> = Rc::new(move |mut v0: Rc<str>| -> US27 {
        US27::US27_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method114() -> Rc<dyn Fn(Rc<str>) -> US27> {
    ok_c64()
}
fn error_c65() -> Rc<dyn Fn(std::string::String) -> US27> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US27> = Rc::new(move |mut v0: std::string::String| -> US27 {
        US27::US27_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method115() -> Rc<dyn Fn(std::string::String) -> US27> {
    error_c65()
}
fn method116(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>, mut v11: Rc<str>, mut v12: i32, mut v13: Rc<str>, mut v14: i32, mut v15: Rc<str>, mut v16: Rc<str>, mut v17: US0, mut v18: Rc<str>, mut v19: Rc<str>) -> Rc<str> {
    let mut v20: i64 = v0.borrow().l0;
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v21));
    let v23: Rc<str> = format_real_16(v20);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v7)), v21)), v8));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v9));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
    let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("real_path"); } LIT.with(|lit| lit.clone()) };
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v34)), v10)), v37));
    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("relative_path"); } LIT.with(|lit| lit.clone()) };
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v43, v44)), v34)), v11)), v37));
    let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("origin_hash_exit_code"); } LIT.with(|lit| lit.clone()) };
    let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v34));
    let mut v52: Rc<str> = format_real_71(v12);
    let v54: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, v52)), v37));
    let v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("origin_hash"); } LIT.with(|lit| lit.clone()) };
    let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v54, v55)), v34)), v13)), v37));
    let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("local_git_hash_exit_code"); } LIT.with(|lit| lit.clone()) };
    let v62: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v59, v60)), v34));
    let mut v63: Rc<str> = format_real_71(v14);
    let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v62, v63)), v37));
    let v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("local_git_hash"); } LIT.with(|lit| lit.clone()) };
    let mut v70: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v65, v66)), v34)), v15)), v37));
    let v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash1"); } LIT.with(|lit| lit.clone()) };
    let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v70, v71)), v34)), v16)), v37));
    let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash2"); } LIT.with(|lit| lit.clone()) };
    let v78: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v75, v76)), v34));
    let mut v79: Rc<str> = method55(v17);
    let mut v81: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v78, v79)), v37));
    let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist_path"); } LIT.with(|lit| lit.clone()) };
    let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v81, v82)), v34)), v18)), v37));
    let mut v87: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache_path"); } LIT.with(|lit| lit.clone()) };
    let v90: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v86, v87)), v34)), v19));
    let v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v92: Rc<str> = Rc::<str>::from(format!("{}{}", v91, v90));
    let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v95: Rc<str> = Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v92, v93))));
    method13(v95)
}
fn ok_c66() -> Rc<dyn Fn(u64) -> US28> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(u64) -> US28> = Rc::new(move |mut v0: u64| -> US28 {
        US28::US28_Ok(v0)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method118() -> Rc<dyn Fn(u64) -> US28> {
    ok_c66()
}
fn error_c67() -> Rc<dyn Fn(std::string::String) -> US28> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US28> = Rc::new(move |mut v0: std::string::String| -> US28 {
        US28::US28_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method119() -> Rc<dyn Fn(std::string::String) -> US28> {
    error_c67()
}
fn method120(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: std::string::String) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_16(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.file_copy"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("old_path"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("old_path"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v8));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("new_path"); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v26)), v9)), v29));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v26));
    let v39: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v10)).s() });
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method13(v45)
}
fn format_real_122(mut v0: u64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method11(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method121(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: u64) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_16(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.file_copy"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("old_path"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("old_path"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v8));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("new_path"); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v26)), v9)), v29));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v26));
    let v39: Rc<str> = format_real_122(v10);
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method13(v45)
}
fn file_copy_117(mut v0: Rc<str>, mut v1: Rc<str>) -> () {
    let mut v3: Result<u64, std::io::Error> = std::fs::copy(&*v1, &*v0);
    let mut v4: Rc<dyn Fn(std::io::Error) -> std::string::String> = method113();
    let mut v6: Result<u64, std::string::String> = v3.map_err(|x| v4(x));
    let mut v7: Rc<dyn Fn(u64) -> US28> = method118();
    let mut v8: Rc<dyn Fn(std::string::String) -> US28> = method119();
    let mut v9: US28 = match v6 { Ok(x) => v7(x), Err(e) => v8(e) };
    match &v9 {
        US28::US28_Error(v80) => {
            let mut v80: std::string::String = v80.clone();
            let mut v82: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
            { let _ = spiral_trace_hold(&v82); };
            let mut v84: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v85, mut v86, mut v87, mut v88, mut v89, mut v90): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v84);
            let v91: US1 = v89.borrow().l0.clone();
            let v96: i32 = match &v91 {
                US1::US1_Critical => {
                    50i32
                }
                US1::US1_Debug => {
                    20i32
                }
                US1::US1_Info => {
                    30i32
                }
                US1::US1_Verbose => {
                    10i32
                }
                US1::US1_Warning => {
                    40i32
                }
            };
            let v97: bool = v87.borrow().l0;
            let mut v98: bool = v97 == false;
            let v100: bool = if v98 {
                false
            } else {
                let v99: bool = 40i32 >= v96;
                v99
            };
            let v101: bool = v100 == false;
            let v149: US3 = if v101 {
                US3::US3_None
            } else {
                { let _ = spiral_trace_hold(&v82); };
                let (mut v105, mut v106, mut v107, mut v108, mut v109, mut v110): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v84);
                let v111: Rc<str> = method7(v105.clone(), v106.clone(), v107.clone(), v108.clone(), v109.clone(), v110.clone());
                let mut v112: Rc<str> = method47();
                let mut v113: Rc<str> = method120(v105.clone(), v106.clone(), v107.clone(), v108.clone(), v109.clone(), v110.clone(), v111.clone(), v112.clone(), v1.clone(), v0.clone(), v80.clone());
                { let _ = spiral_trace_hold(&v82); };
                let (mut v116, mut v117, mut v118, mut v119, mut v120, mut v121): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v84);
                let mut v122: i64 = v116.borrow().l0;
                let v123: i64 = v122.wrapping_add(1i64);
                v116.borrow_mut().l0 = v123;
                let mut v124: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v125: bool = cfg!(target_arch = "wasm32");
                if v125 {
                    let v126: Rc<str> = v119.borrow().l0.clone();
                    let mut v127: bool = &*v126 == "";
                    let v135: Rc<str> = if v127 {
                        v113.clone()
                    } else {
                        let v128: bool = &*v113 == "";
                        if v128 {
                            let v129: Rc<str> = v119.borrow().l0.clone();
                            v129.clone()
                        } else {
                            let mut v130: Rc<str> = v119.borrow().l0.clone();
                            let v131: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v133: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v130, v131)), v113));
                            v133.clone()
                        }
                    };
                    let v137: usize = v135.chars().count();
                    let v138: i32 = ((v137) as i32);
                    let mut v139: i32 = v138.wrapping_add(14999i32);
                    let v140: i32 = v139.wrapping_div(15000i32);
                    let v141: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v142: bool = v113 != v141 ;
                    let v144: bool = if v142 {
                        let v143: bool = v140 <= 1i32;
                        v143
                    } else {
                        false
                    };
                    if v144 {
                        v119.borrow_mut().l0 = v135.clone();
                        ()
                    } else {
                        v119.borrow_mut().l0 = v141.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v135); };
                        ()
                    }
                } else {
                    println!("{}", v113);
                    ()
                };
                let mut v147: Rc<dyn Fn(Rc<str>) -> ()> = v117.borrow().l0.clone();
                v147(v113.clone());
                US3::US3_Some(v116.clone(), v117.clone(), v118.clone(), v119.clone(), v120.clone(), v121.clone())
            };
            ()
        }
        US28::US28_Ok(v10) => {
            let mut v10: u64 = *v10;
            let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
            { let _ = spiral_trace_hold(&v12); };
            let mut v14: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v15, mut v16, mut v17, mut v18, mut v19, mut v20): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
            let v21: US1 = v19.borrow().l0.clone();
            let mut v26: i32 = match &v21 {
                US1::US1_Critical => {
                    50i32
                }
                US1::US1_Debug => {
                    20i32
                }
                US1::US1_Info => {
                    30i32
                }
                US1::US1_Verbose => {
                    10i32
                }
                US1::US1_Warning => {
                    40i32
                }
            };
            let mut v27: bool = v17.borrow().l0;
            let mut v28: bool = v27 == false;
            let v30: bool = if v28 {
                false
            } else {
                let mut v29: bool = 20i32 >= v26;
                v29
            };
            let mut v31: bool = v30 == false;
            let mut v79: US3 = if v31 {
                US3::US3_None
            } else {
                { let _ = spiral_trace_hold(&v12); };
                let (mut v35, mut v36, mut v37, mut v38, mut v39, mut v40): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
                let v41: Rc<str> = method7(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone());
                let v42: Rc<str> = method53();
                let v43: Rc<str> = method121(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v1.clone(), v0.clone(), v10);
                { let _ = spiral_trace_hold(&v12); };
                let (mut v46, mut v47, mut v48, mut v49, mut v50, mut v51): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v14);
                let mut v52: i64 = v46.borrow().l0;
                let v53: i64 = v52.wrapping_add(1i64);
                v46.borrow_mut().l0 = v53;
                let v54: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v55: bool = cfg!(target_arch = "wasm32");
                if v55 {
                    let v56: Rc<str> = v49.borrow().l0.clone();
                    let mut v57: bool = &*v56 == "";
                    let mut v65: Rc<str> = if v57 {
                        v43.clone()
                    } else {
                        let v58: bool = &*v43 == "";
                        if v58 {
                            let mut v59: Rc<str> = v49.borrow().l0.clone();
                            v59.clone()
                        } else {
                            let v60: Rc<str> = v49.borrow().l0.clone();
                            let v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v60, v61)), v43));
                            v63.clone()
                        }
                    };
                    let v67: usize = v65.chars().count();
                    let mut v68: i32 = ((v67) as i32);
                    let v69: i32 = v68.wrapping_add(14999i32);
                    let mut v70: i32 = v69.wrapping_div(15000i32);
                    let v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v72: bool = v43 != v71 ;
                    let v74: bool = if v72 {
                        let mut v73: bool = v70 <= 1i32;
                        v73
                    } else {
                        false
                    };
                    if v74 {
                        v49.borrow_mut().l0 = v65.clone();
                        ()
                    } else {
                        v49.borrow_mut().l0 = v71.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v65); };
                        ()
                    }
                } else {
                    println!("{}", v43);
                    ()
                };
                let mut v77: Rc<dyn Fn(Rc<str>) -> ()> = v47.borrow().l0.clone();
                v77(v43.clone());
                US3::US3_Some(v46.clone(), v47.clone(), v48.clone(), v49.clone(), v50.clone(), v51.clone())
            };
            ()
        }
    }
}
fn method124(mut v0: Vec<u8>) -> Vec<u8> {
    v0
}
fn method125(mut v0: i32, mut v1: Rc<RefCell<Mut9>>) -> bool {
    let mut v2: i32 = v1.borrow().l0;
    let mut v3: bool = v2 < v0;
    v3
}
fn method126(mut v0: Rc<str>) -> Rc<str> {
    v0
}
fn closure70(mut v0: Rc<str>) -> Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()> {
    Rc::new(move |mut v1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| -> () {
        let mut v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1;
        let mut v5: Result<std::sync::MutexGuard<std::process::ChildStdin>, std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> = v3.lock();
        let mut v7: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
        let mut v8: Rc<str> = method126(v0.clone());
        let mut v10: &[u8] = v8.as_bytes();
        let mut v12: bool = true; std::io::Write::write_all(&mut *v7, v10).unwrap();
        ()
    })
}
fn method127(mut v0: i32, mut v1: Rc<RefCell<Mut10>>) -> bool {
    let mut v2: i32 = v1.borrow().l0;
    let mut v3: bool = v2 < v0;
    v3
}
fn method128(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: i32, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_16(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.hangul"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_71(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result_len"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26));
    let mut v35: Rc<str> = format_real_71(v9);
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v34, v35)), v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v37, v38)), v26)), v10));
    let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
    let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v43, v44))));
    method13(v46)
}
fn hangul_123(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<str>, mut v4: Rc<str>) -> US29 {
    let mut v6: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v4);
    let mut v8: Vec<u8> = v6.unwrap();
    let mut v9: Vec<u8> = method124(v8.clone());
    let mut v11: Result<std::string::String, std::string::FromUtf8Error> = std::string::String::from_utf8(v9);
    let mut v13: std::string::String = v11.unwrap();
    let v15: Rc<str> = Rc::<str>::from(String::as_str(&v13));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v15.split(&*v16).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let v18: i32 = (v17.clone().borrow().len() as i32);
    let v19: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v18 as usize]));
    let mut v20: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32 }));
    while method51(v18, v20.clone()) {
        let mut v22: i32 = v20.borrow().l0;
        let v23: Rc<str> = v17.clone().borrow()[v22 as usize].clone();
        let v24: i32 = (v23.clone().len() as i32);
        let mut v25: i32 = 0i32;
        let mut v26: i32 = method14(v23.clone(), v24, v25);
        let mut v27: i32 = v24.wrapping_sub(1i32);
        let mut v28: Rc<str> = string_slice(&v23.clone(), v26 as i64, v27 as i64);
        let mut v29: i32 = (v28.clone().len() as i32);
        let v30: i32 = method107(v28.clone(), v29);
        let mut v31: Rc<str> = string_slice(&v28.clone(), 0i32 as i64, v30 as i64);
        v19.clone().borrow_mut()[v22 as usize] = v31.clone();
        let mut v32: i32 = v22.wrapping_add(1i32);
        v20.borrow_mut().l0 = v32;
        ()
    };
    let mut v33: i32 = (v19.clone().borrow().len() as i32);
    let mut v34: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v33 as usize]));
    let mut v35: Rc<RefCell<Mut9>> = Rc::new(RefCell::new(Mut9 { l0: 0i32, l1: 0i32 }));
    while method125(v33, v35.clone()) {
        let v37: i32 = v35.borrow().l0;
        let mut v38: i32 = v35.borrow().l1;
        let v39: Rc<str> = v19.clone().borrow()[v37 as usize].clone();
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v41: bool = v39 != v40 ;
        let v43: i32 = if v41 {
            v34.clone().borrow_mut()[v38 as usize] = v39.clone();
            let v42: i32 = v38.wrapping_add(1i32);
            v42
        } else {
            v38
        };
        let mut v44: i32 = v37.wrapping_add(1i32);
        v35.borrow_mut().l0 = v44;
        v35.borrow_mut().l1 = v43;
        ()
    };
    let mut v45: i32 = v35.borrow().l1;
    let mut v46: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v45 as usize]));
    let mut v47: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32 }));
    while method51(v45, v47.clone()) {
        let mut v49: i32 = v47.borrow().l0;
        let v50: Rc<str> = v34.clone().borrow()[v49 as usize].clone();
        v46.clone().borrow_mut()[v49 as usize] = v50.clone();
        let v51: i32 = v49.wrapping_add(1i32);
        v47.borrow_mut().l0 = v51;
        ()
    };
    let mut v52: Rc<Vec<Rc<str>>> = Rc::new(v46.borrow().clone());
    let v53: Rc<str> = Rc::<str>::from(v52.iter().map(|x| x.to_string()).collect::<Vec<_>>().join(&*v16));
    let v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n\n"); } LIT.with(|lit| lit.clone()) };
    let v55: Rc<str> = Rc::<str>::from(format!("{}{}", v53, v54));
    let v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" the "); } LIT.with(|lit| lit.clone()) };
    let mut v57: bool = v55.contains(&*v56);
    let v60: bool = if v57 {
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" and "); } LIT.with(|lit| lit.clone()) };
        let mut v59: bool = v55.contains(&*v58);
        v59
    } else {
        false
    };
    let v62: Rc<str> = if v60 {
        let v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("eng"); } LIT.with(|lit| lit.clone()) };
        v61.clone()
    } else {
        v1.clone()
    };
    let mut v63: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
    let v64: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
    let mut v65: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
    let v66: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
    let v67: Option<Rc<str>> = None;
    let mut v68: bool = cfg!(windows);
    let v71: Rc<str> = if v68 {
        let v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".exe"); } LIT.with(|lit| lit.clone()) };
        v69.clone()
    } else {
        let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v70.clone()
    };
    let v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("../alphabet/deps/hangulize/cmd/hangulize/hangulize"); } LIT.with(|lit| lit.clone()) };
    let mut v73: Rc<str> = Rc::<str>::from(format!("{}{}", v72, v71));
    let v74: Rc<str> = method39(v0.clone(), v73.clone());
    let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v77: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v74, v75)), v62));
    let v78: Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()> = closure70(v55.clone());
    let mut v79: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = Some(v78.clone());
    let mut v80: bool = true;
    let mut v81: bool = true;
    let (mut v82, mut v83): (i32, Rc<str>) = execute_with_options_68(v77.clone(), v63.clone(), v64.clone(), v65.clone(), v79.clone(), v80, v67.clone(), v81);
    let mut v84: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v83.split(&*v16).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let mut v85: i32 = (v84.clone().borrow().len() as i32);
    let mut v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v87: Rc<RefCell<Mut10>> = Rc::new(RefCell::new(Mut10 { l0: 0i32, l1: v86.clone(), l2: 0i32, l3: 0i32, l4: false }));
    while method127(v33, v87.clone()) {
        let v89: i32 = v87.borrow().l0;
        let (mut v90, mut v91, mut v92, mut v93): (Rc<str>, i32, i32, bool) = (v87.borrow().l1.clone(), v87.borrow().l2, v87.borrow().l3, v87.borrow().l4);
        let v94: Rc<str> = v19.clone().borrow()[v89 as usize].clone();
        let v95: bool = &*v94 == "";
        let (mut v126, mut v127, mut v128, mut v129): (Rc<str>, i32, i32, bool) = if v95 {
            let v96: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v16));
            let v97: i32 = v91.wrapping_add(1i32);
            let mut v98: i32 = v92.wrapping_add(1i32);
            (v96.clone(), v97, v98, v93)
        } else {
            let v99: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("```"); } LIT.with(|lit| lit.clone()) };
            let v100: bool = v94.starts_with(&*v99);
            let v101: i32 = v91.wrapping_sub(v92);
            let mut v102: bool = v101 >= v85;
            let mut v122: Rc<str> = if v102 {
                v90.clone()
            } else {
                let v103: bool = v100 || v93;
                if v103 {
                    let mut v104: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v94));
                    let mut v105: i32 = v85.wrapping_sub(1i32);
                    let v106: bool = v101 == v105;
                    if v106 {
                        v104.clone()
                    } else {
                        let v107: Rc<str> = Rc::<str>::from(format!("{}{}", v104, v16));
                        v107.clone()
                    }
                } else {
                    let mut v109: Rc<str> = v84.clone().borrow()[v101 as usize].clone();
                    let mut v110: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("://"); } LIT.with(|lit| lit.clone()) };
                    let v111: bool = v109.contains(&*v110);
                    let mut v112: Rc<str> = if v111 {
                        v94.clone()
                    } else {
                        v109.clone()
                    };
                    let mut v113: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v112));
                    let mut v116: Rc<str> = if v2 {
                        v113.clone()
                    } else {
                        let mut v115: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v113, v16)), v94));
                        v115.clone()
                    };
                    let v117: i32 = v85.wrapping_sub(1i32);
                    let v118: bool = v101 == v117;
                    if v118 {
                        v116.clone()
                    } else {
                        let mut v119: Rc<str> = Rc::<str>::from(format!("{}{}", v116, v16));
                        v119.clone()
                    }
                }
            };
            let v123: i32 = v91.wrapping_add(1i32);
            let v125: bool = if v100 {
                let mut v124: bool = v93 == false;
                v124
            } else {
                v93
            };
            (v122.clone(), v123, v92, v125)
        };
        let mut v130: i32 = v89.wrapping_add(1i32);
        v87.borrow_mut().l0 = v130;
        v87.borrow_mut().l1 = v126.clone();
        v87.borrow_mut().l2 = v127;
        v87.borrow_mut().l3 = v128;
        v87.borrow_mut().l4 = v129;
        ()
    };
    let (mut v131, mut v132, mut v133, mut v134): (Rc<str>, i32, i32, bool) = (v87.borrow().l1.clone(), v87.borrow().l2, v87.borrow().l3, v87.borrow().l4);
    std::fs::write(&*v3, &*v131).unwrap();
    let v137: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    { let _ = spiral_trace_hold(&v137); };
    let mut v139: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
    let (mut v140, mut v141, mut v142, mut v143, mut v144, mut v145): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v139);
    let v146: US1 = v144.borrow().l0.clone();
    let mut v151: i32 = match &v146 {
        US1::US1_Critical => {
            50i32
        }
        US1::US1_Debug => {
            20i32
        }
        US1::US1_Info => {
            30i32
        }
        US1::US1_Verbose => {
            10i32
        }
        US1::US1_Warning => {
            40i32
        }
    };
    let mut v152: bool = v142.borrow().l0;
    let v153: bool = v152 == false;
    let mut v155: bool = if v153 {
        false
    } else {
        let v154: bool = 30i32 >= v151;
        v154
    };
    let v156: bool = v155 == false;
    let v203: US3 = if v156 {
        US3::US3_None
    } else {
        { let _ = spiral_trace_hold(&v137); };
        let (mut v160, mut v161, mut v162, mut v163, mut v164, mut v165): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v139);
        let mut v166: Rc<str> = method7(v160.clone(), v161.clone(), v162.clone(), v163.clone(), v164.clone(), v165.clone());
        let mut v167: Rc<str> = method9();
        let mut v168: i32 = (v131.clone().len() as i32);
        let v169: Rc<str> = method128(v160.clone(), v161.clone(), v162.clone(), v163.clone(), v164.clone(), v165.clone(), v166.clone(), v167.clone(), v82, v168, v3.clone());
        { let _ = spiral_trace_hold(&v137); };
        let (mut v172, mut v173, mut v174, mut v175, mut v176, mut v177): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v139);
        let mut v178: i64 = v172.borrow().l0;
        let v179: i64 = v178.wrapping_add(1i64);
        v172.borrow_mut().l0 = v179;
        let v180: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
        let mut v181: bool = cfg!(target_arch = "wasm32");
        if v181 {
            let mut v182: Rc<str> = v175.borrow().l0.clone();
            let mut v183: bool = &*v182 == "";
            let mut v190: Rc<str> = if v183 {
                v169.clone()
            } else {
                let v184: bool = &*v169 == "";
                if v184 {
                    let v185: Rc<str> = v175.borrow().l0.clone();
                    v185.clone()
                } else {
                    let v186: Rc<str> = v175.borrow().l0.clone();
                    let v188: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v186, v16)), v169));
                    v188.clone()
                }
            };
            let v192: usize = v190.chars().count();
            let v193: i32 = ((v192) as i32);
            let v194: i32 = v193.wrapping_add(14999i32);
            let v195: i32 = v194.wrapping_div(15000i32);
            let v196: bool = v169 != v86 ;
            let v198: bool = if v196 {
                let v197: bool = v195 <= 1i32;
                v197
            } else {
                false
            };
            if v198 {
                v175.borrow_mut().l0 = v190.clone();
                ()
            } else {
                v175.borrow_mut().l0 = v86.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v190); };
                ()
            }
        } else {
            println!("{}", v169);
            ()
        };
        let mut v201: Rc<dyn Fn(Rc<str>) -> ()> = v173.borrow().l0.clone();
        v201(v169.clone());
        US3::US3_Some(v172.clone(), v173.clone(), v174.clone(), v175.clone(), v176.clone(), v177.clone())
    };
    US29::US29_Ok(v82, v131.clone())
}
fn method129(mut v0: Rc<str>, mut v1: Rc<str>) -> (Rc<str>, Rc<str>) {
    (v0, v1)
}
fn method130(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0;
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_16(v10);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v7)), v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.files_fn / error"); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = format_real_71(v8);
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v27));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v25)), v9));
    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v36, v37))));
    method13(v39)
}
fn closure69(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: bool, mut v5: Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26> {
    Rc::new(move |mut v6: Rc<str>| -> US26 {
        let (mut v7, mut v8): (Rc<str>, Rc<str>) = fix_paths_109(v6.clone(), v5.clone(), v0.clone());
        let mut v9: bool = file_exists_46(v7.clone());
        let mut v10: bool = v9 == false;
        let mut v13: bool = if v10 {
            true
        } else {
            let mut v11: bool = file_exists_46(v8.clone());
            let mut v12: bool = v11 == false;
            v12
        };
        let mut v178: bool = if v13 {
            false
        } else {
            let mut v14: Rc<str> = normalize_path_28(v7.clone());
            let mut v16: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v14);
            let v18: std::fs::File = v16.unwrap();
            let mut v20: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v18);
            let mut v22: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v20);
            let v24: bool = true; let mut v22 = v22;
            let mut v26: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v28: sha2::Sha256 = result;
            let v30: bool = true; let mut v28 = v28;
            let mut v31: usize = ((0i32) as usize);
            let mut v33: _ = [0u8; 1024i32 as usize];
            let mut v35: bool = true; loop { // rust.loop 1;
            let v37: bool = true; let mut v33 = v33;
            let v39: Result<usize, std::io::Error> = std::io::Read::read(&mut v22, &mut v33);
            let v41: usize = v39.unwrap();
            let v42: bool = v41 == v31 ;
            let mut v45: bool = if v42 {
                let mut v44: bool = true; break ();
                true
            } else {
                false
            };
            let mut v46: usize = ((v41) as usize);
            let mut v47: usize = (v46.clone());
            let mut v49: usize = v33.len();
            let v50: bool = v47 == v49 ;
            let v55: &_ = if v50 {
                let mut v52: &_ = &v33[v31..];
                v52.clone()
            } else {
                let v54: &_ = &v33[v31..v46];
                v54.clone()
            };
            let mut v57: bool = true; sha2::Digest::update(&mut v28, v55);
            let mut v59: bool = true; } // rust.loop 3;
            let v61: &[u8] = &sha2::Digest::finalize(v28);
            let mut v63: Vec<u8> = v61.iter().map(|x| *x).collect::<Vec<_>>();
            let mut v65: Rc<dyn Fn((u8)) -> Rc<str>> = closure62();
            let v66: Vec<Rc<str>> = v63.iter().map(|x| v65(x.clone())).collect::<Vec<_>>();
            let v67: Vec<Rc<str>> = method64(v66.clone());
            let mut v68: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v67));
            let v69: Rc<Vec<Rc<str>>> = Rc::new((v68).borrow().clone());
            let mut v70: usize = (v69).len();
            let v71: i32 = ((v70) as i32);
            let v72: i32 = v71.wrapping_sub(1i32);
            let mut v73: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let v74: Rc<UH0> = method111(v69.clone(), v72, v73.clone());
            let mut v75: Rc<str> = method112();
            let mut v76: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
            let mut v77: i32 = 0i32;
            let v78: i32 = method3(v76.clone(), v74.clone(), v77);
            let mut v79: Rc<Vec<Rc<str>>> = Rc::new(v76.borrow().clone());
            let mut v80: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v79).as_ref().clone()));
            let mut v81: Rc<str> = Rc::<str>::from((*v80.borrow()).join(&*v75));
            let mut v82: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v81);
            let mut v83: Rc<dyn Fn(std::io::Error) -> std::string::String> = method113();
            let mut v85: Result<Rc<str>, std::string::String> = v82.map_err(|x| v83(x));
            let mut v86: Rc<dyn Fn(Rc<str>) -> US27> = method114();
            let mut v87: Rc<dyn Fn(std::string::String) -> US27> = method115();
            let mut v88: US27 = match v85 { Ok(x) => v86(x), Err(e) => v87(e) };
            let v95: Rc<str> = match &v88 {
                US27::US27_Error(v90) => {
                    let v90: std::string::String = v90.clone();
                    let v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("resultm.get / Error x: "); } LIT.with(|lit| lit.clone()) };
                    let v92: Rc<str> = Rc::<str>::from(format!("{}{}", v91, (&SpiralDebug(&v90)).show()));
                    std::panic::panic_any::<std::string::String>(format!("{}", v92.clone()))
                }
                US27::US27_Ok(v89) => {
                    let v89: Rc<str> = v89.clone();
                    v89.clone()
                }
            };
            let v96: Rc<str> = normalize_path_28(v8.clone());
            let mut v98: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v96);
            let v100: std::fs::File = v98.unwrap();
            let mut v102: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v100);
            let mut v104: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v102);
            let v106: bool = true; let mut v104 = v104;
            let mut v108: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v110: sha2::Sha256 = result;
            let mut v112: bool = true; let mut v110 = v110;
            let mut v113: usize = ((0i32) as usize);
            let mut v115: _ = [0u8; 1024i32 as usize];
            let v117: bool = true; loop { // rust.loop 1;
            let mut v119: bool = true; let mut v115 = v115;
            let mut v121: Result<usize, std::io::Error> = std::io::Read::read(&mut v104, &mut v115);
            let v123: usize = v121.unwrap();
            let mut v124: bool = v123 == v113 ;
            let mut v127: bool = if v124 {
                let v126: bool = true; break ();
                true
            } else {
                false
            };
            let v128: usize = ((v123) as usize);
            let v129: usize = (v128.clone());
            let v131: usize = v115.len();
            let v132: bool = v129 == v131 ;
            let v137: &_ = if v132 {
                let v134: &_ = &v115[v113..];
                v134.clone()
            } else {
                let v136: &_ = &v115[v113..v128];
                v136.clone()
            };
            let mut v139: bool = true; sha2::Digest::update(&mut v110, v137);
            let v141: bool = true; } // rust.loop 3;
            let v143: &[u8] = &sha2::Digest::finalize(v110);
            let v145: Vec<u8> = v143.iter().map(|x| *x).collect::<Vec<_>>();
            let mut v147: Vec<Rc<str>> = v145.iter().map(|x| v65(x.clone())).collect::<Vec<_>>();
            let mut v148: Vec<Rc<str>> = method64(v147.clone());
            let v149: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v148));
            let mut v150: Rc<Vec<Rc<str>>> = Rc::new((v149).borrow().clone());
            let mut v151: usize = (v150).len();
            let mut v152: i32 = ((v151) as i32);
            let v153: i32 = v152.wrapping_sub(1i32);
            let v154: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let mut v155: Rc<UH0> = method111(v150.clone(), v153, v154.clone());
            let v156: Rc<str> = method112();
            let v157: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
            let v158: i32 = 0i32;
            let mut v159: i32 = method3(v157.clone(), v155.clone(), v158);
            let v160: Rc<Vec<Rc<str>>> = Rc::new(v157.borrow().clone());
            let mut v161: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v160).as_ref().clone()));
            let mut v162: Rc<str> = Rc::<str>::from((*v161.borrow()).join(&*v156));
            let mut v163: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v162);
            let mut v164: Rc<dyn Fn(std::io::Error) -> std::string::String> = method113();
            let mut v166: Result<Rc<str>, std::string::String> = v163.map_err(|x| v164(x));
            let mut v167: Rc<dyn Fn(Rc<str>) -> US27> = method114();
            let mut v168: Rc<dyn Fn(std::string::String) -> US27> = method115();
            let v169: US27 = match v166 { Ok(x) => v167(x), Err(e) => v168(e) };
            let v176: Rc<str> = match &v169 {
                US27::US27_Error(v171) => {
                    let v171: std::string::String = v171.clone();
                    let mut v172: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("resultm.get / Error x: "); } LIT.with(|lit| lit.clone()) };
                    let v173: Rc<str> = Rc::<str>::from(format!("{}{}", v172, (&SpiralDebug(&v171)).show()));
                    std::panic::panic_any::<std::string::String>(format!("{}", v173.clone()))
                }
                US27::US27_Ok(v170) => {
                    let v170: Rc<str> = v170.clone();
                    v170.clone()
                }
            };
            let v177: bool = &*v95 == &*v176;
            v177
        };
        if v178 {
            US26::US26_None
        } else {
            let v180: US29 = hangul_123(v2.clone(), v3.clone(), v4, v7.clone(), v5.clone());
            match &v180 {
                US29::US29_Error(v266, v267) => {
                    let v266: i32 = *v266;
                    let v267: Rc<str> = v267.clone();
                    let (mut v268, mut v269): (Rc<str>, Rc<str>) = method129(v7.clone(), v267.clone());
                    let v270: (Rc<str>, Rc<str>) = (v268, v269);
                    let v271: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v270);
                    US26::US26_Some(v271.clone())
                }
                US29::US29_Ok(v181, v182) => {
                    let mut v181: i32 = *v181;
                    let mut v182: Rc<str> = v182.clone();
                    let mut v183: bool = v181 != 0i32 ;
                    if v183 {
                        let v185: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v185); };
                        let v187: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v188, mut v189, mut v190, mut v191, mut v192, mut v193): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v187);
                        let v194: US1 = v192.borrow().l0.clone();
                        let v199: i32 = match &v194 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v200: bool = v190.borrow().l0;
                        let mut v201: bool = v200 == false;
                        let v203: bool = if v201 {
                            false
                        } else {
                            let v202: bool = 30i32 >= v199;
                            v202
                        };
                        let v204: bool = v203 == false;
                        let v252: US3 = if v204 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v185); };
                            let (mut v208, mut v209, mut v210, mut v211, mut v212, mut v213): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v187);
                            let v214: Rc<str> = method7(v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone(), v213.clone());
                            let v215: Rc<str> = method9();
                            let v216: Rc<str> = method130(v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone(), v213.clone(), v214.clone(), v215.clone(), v181, v182.clone());
                            { let _ = spiral_trace_hold(&v185); };
                            let (mut v219, mut v220, mut v221, mut v222, mut v223, mut v224): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v187);
                            let v225: i64 = v219.borrow().l0;
                            let v226: i64 = v225.wrapping_add(1i64);
                            v219.borrow_mut().l0 = v226;
                            let mut v227: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v228: bool = cfg!(target_arch = "wasm32");
                            if v228 {
                                let v229: Rc<str> = v222.borrow().l0.clone();
                                let mut v230: bool = &*v229 == "";
                                let v238: Rc<str> = if v230 {
                                    v216.clone()
                                } else {
                                    let mut v231: bool = &*v216 == "";
                                    if v231 {
                                        let mut v232: Rc<str> = v222.borrow().l0.clone();
                                        v232.clone()
                                    } else {
                                        let v233: Rc<str> = v222.borrow().l0.clone();
                                        let v234: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v236: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v233, v234)), v216));
                                        v236.clone()
                                    }
                                };
                                let v240: usize = v238.chars().count();
                                let v241: i32 = ((v240) as i32);
                                let v242: i32 = v241.wrapping_add(14999i32);
                                let v243: i32 = v242.wrapping_div(15000i32);
                                let v244: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v245: bool = v216 != v244 ;
                                let v247: bool = if v245 {
                                    let v246: bool = v243 <= 1i32;
                                    v246
                                } else {
                                    false
                                };
                                if v247 {
                                    v222.borrow_mut().l0 = v238.clone();
                                    ()
                                } else {
                                    v222.borrow_mut().l0 = v244.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v238); };
                                    ()
                                }
                            } else {
                                println!("{}", v216);
                                ()
                            };
                            let mut v250: Rc<dyn Fn(Rc<str>) -> ()> = v220.borrow().l0.clone();
                            v250(v216.clone());
                            US3::US3_Some(v219.clone(), v220.clone(), v221.clone(), v222.clone(), v223.clone(), v224.clone())
                        };
                        let (mut v253, mut v254): (Rc<str>, Rc<str>) = method129(v7.clone(), v182.clone());
                        let v255: (Rc<str>, Rc<str>) = (v253, v254);
                        let v256: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v255);
                        US26::US26_Some(v256.clone())
                    } else {
                        let v258: bool = file_exists_46(v7.clone());
                        if v258 {
                            file_copy_117(v8.clone(), v7.clone())
                        } else {
                            let v259: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.files_fn / "); } LIT.with(|lit| lit.clone()) };
                            let v260: Rc<str> = Rc::<str>::from(format!("{}{}", v259, v7));
                            let mut v261: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" should exist"); } LIT.with(|lit| lit.clone()) };
                            let mut v262: Rc<str> = Rc::<str>::from(format!("{}{}", v260, v261));
                            std::panic::panic_any::<std::string::String>(format!("{}", v262.clone()))
                        };
                        let v263: Result<Rc<str>, (Rc<str>, Rc<str>)> = Ok::<Rc<str>, (Rc<str>, Rc<str>)>(v7);
                        US26::US26_Some(v263.clone())
                    }
                }
            }
        }
    })
}
fn closure68(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: bool) -> Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> {
    Rc::new(move |mut v5: Rc<str>| -> Rc<dyn Fn(Rc<str>) -> US26> {
        closure69(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4, v5.clone())
    })
}
fn method132(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_16(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.crowbook / attempt error"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_71(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26)), v9)), v30));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v26)), v10));
    let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method13(v45)
}
fn method133(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0;
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_16(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.crowbook / result contains ERROR"); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code = "); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = format_real_71(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26)), v9)), v30));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v26)), v10));
    let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method13(v45)
}
fn crowbook_131(mut v0: bool, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>) -> US29 {
    let mut v5: bool = "html" == &*v4;
    let mut v63: Rc<str> = if v5 {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set"); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" html.css.add \\\"'"); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"'"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" body { color: #e8e6e3; background-color: #202324; }"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; }"); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" a { color: #989693; }"); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; }"); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" pre { background-color: #1b1b1b; padding: 10px; }"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; }"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" '\\\""); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } '\\\""); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6"); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v16, Rc::<str>::from(format!("{}{}", v17, v18))));
        v20
    } else {
        let v21: bool = "pdf" == &*v4;
        if v21 {
            let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set"); } LIT.with(|lit| lit.clone()) };
            let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.paper.size a4paper"); } LIT.with(|lit| lit.clone()) };
            let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set tex.paper.size a4paper"); } LIT.with(|lit| lit.clone()) };
            let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.command tectonic"); } LIT.with(|lit| lit.clone()) };
            let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set tex.paper.size a4paper tex.command tectonic"); } LIT.with(|lit| lit.clone()) };
            let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\pagenumbering{gobble}\""); } LIT.with(|lit| lit.clone()) };
            let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set tex.paper.size a4paper tex.command tectonic tex.template.add \"\\pagenumbering{gobble}\""); } LIT.with(|lit| lit.clone()) };
            let mut v29: bool = v0 == false;
            let mut v38: Rc<str> = if v29 {
                let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v30
            } else {
                let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\""); } LIT.with(|lit| lit.clone()) };
                let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\setmainlanguage{korean}\""); } LIT.with(|lit| lit.clone()) };
                let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\""); } LIT.with(|lit| lit.clone()) };
                let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\setmainfont{NanumGothicCoding}\""); } LIT.with(|lit| lit.clone()) };
                let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\""); } LIT.with(|lit| lit.clone()) };
                let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.font.size 13"); } LIT.with(|lit| lit.clone()) };
                let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13"); } LIT.with(|lit| lit.clone()) };
                v37
            };
            let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v38));
            let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6"); } LIT.with(|lit| lit.clone()) };
            let v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
            let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v39, Rc::<str>::from(format!("{}{}", v40, v41))));
            v43
        } else {
            let mut v44: bool = "epub" == &*v4;
            if v44 {
                let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set"); } LIT.with(|lit| lit.clone()) };
                let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" epub.version 3"); } LIT.with(|lit| lit.clone()) };
                let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3"); } LIT.with(|lit| lit.clone()) };
                let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" html.css.add \\\"' "); } LIT.with(|lit| lit.clone()) };
                let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"' "); } LIT.with(|lit| lit.clone()) };
                let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" body { color: #e8e6e3; background-color: #202324; } "); } LIT.with(|lit| lit.clone()) };
                let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"'  body { color: #e8e6e3; background-color: #202324; } "); } LIT.with(|lit| lit.clone()) };
                let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" a { color: #989693; } "); } LIT.with(|lit| lit.clone()) };
                let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; } "); } LIT.with(|lit| lit.clone()) };
                let v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" '\\\""); } LIT.with(|lit| lit.clone()) };
                let v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  '\\\""); } LIT.with(|lit| lit.clone()) };
                let v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6"); } LIT.with(|lit| lit.clone()) };
                let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
                let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v55, Rc::<str>::from(format!("{}{}", v56, v57))));
                v59
            } else {
                let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v60
            }
        }
    };
    let v64: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
    let mut v65: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
    let v66: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
    let v67: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
    let mut v68: Option<Rc<str>> = None;
    let v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("crowbook --verbose --to "); } LIT.with(|lit| lit.clone()) };
    let mut v70: Rc<str> = Rc::<str>::from(format!("{}{}", v69, v4));
    let v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" --single \""); } LIT.with(|lit| lit.clone()) };
    let mut v73: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v70, v71)), v2));
    let v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\" --output \""); } LIT.with(|lit| lit.clone()) };
    let mut v76: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v73, v74)), v1));
    let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\" "); } LIT.with(|lit| lit.clone()) };
    let mut v79: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v76, v77)), v63));
    let mut v80: Option<Rc<str>> = Some(v3.clone());
    let mut v81: bool = true;
    let mut v82: bool = true;
    let (mut v83, mut v84): (i32, Rc<str>) = execute_with_options_68(v79, v64, v65, v66, v67, v81, v80, v82);
    let mut v85: bool = v83 == 0i32;
    let (mut v177, mut v178): (i32, Rc<str>) = if v85 {
        (v83, v84.clone())
    } else {
        let mut v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        { let _ = spiral_trace_hold(&v87); };
        let v89: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v90, mut v91, mut v92, mut v93, mut v94, mut v95): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v89);
        let v96: US1 = v94.borrow().l0.clone();
        let v101: i32 = match &v96 {
            US1::US1_Critical => {
                50i32
            }
            US1::US1_Debug => {
                20i32
            }
            US1::US1_Info => {
                30i32
            }
            US1::US1_Verbose => {
                10i32
            }
            US1::US1_Warning => {
                40i32
            }
        };
        let mut v102: bool = v92.borrow().l0;
        let v103: bool = v102 == false;
        let mut v105: bool = if v103 {
            false
        } else {
            let mut v104: bool = 40i32 >= v101;
            v104
        };
        let v106: bool = v105 == false;
        let v154: US3 = if v106 {
            US3::US3_None
        } else {
            { let _ = spiral_trace_hold(&v87); };
            let (mut v110, mut v111, mut v112, mut v113, mut v114, mut v115): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v89);
            let mut v116: Rc<str> = method7(v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone());
            let v117: Rc<str> = method47();
            let v118: Rc<str> = method132(v110, v111, v112, v113, v114, v115, v116, v117, v83, v1.clone(), v84);
            { let _ = spiral_trace_hold(&v87); };
            let (mut v121, mut v122, mut v123, mut v124, mut v125, mut v126): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v89);
            let mut v127: i64 = v121.borrow().l0;
            let v128: i64 = v127.wrapping_add(1i64);
            v121.borrow_mut().l0 = v128;
            let v129: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v130: bool = cfg!(target_arch = "wasm32");
            if v130 {
                let v131: Rc<str> = v124.borrow().l0.clone();
                let v132: bool = &*v131 == "";
                let v140: Rc<str> = if v132 {
                    v118.clone()
                } else {
                    let v133: bool = &*v118 == "";
                    if v133 {
                        let v134: Rc<str> = v124.borrow().l0.clone();
                        v134
                    } else {
                        let v135: Rc<str> = v124.borrow().l0.clone();
                        let v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v138: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v135, v136)), v118));
                        v138
                    }
                };
                let v142: usize = v140.chars().count();
                let v143: i32 = ((v142) as i32);
                let v144: i32 = v143.wrapping_add(14999i32);
                let v145: i32 = v144.wrapping_div(15000i32);
                let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v147: bool = v118 != v146 ;
                let v149: bool = if v147 {
                    let mut v148: bool = v145 <= 1i32;
                    v148
                } else {
                    false
                };
                if v149 {
                    v124.borrow_mut().l0 = v140.clone();
                    ()
                } else {
                    v124.borrow_mut().l0 = v146;
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                    ()
                }
            } else {
                println!("{}", v118);
                ()
            };
            let mut v152: Rc<dyn Fn(Rc<str>) -> ()> = v122.borrow().l0.clone();
            v152(v118);
            US3::US3_Some(v121, v122, v123, v124, v125, v126)
        };
        let mut v155: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
        let v156: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
        let v157: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
        let v158: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
        let mut v159: Option<Rc<str>> = None;
        let mut v164: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v69, v4)), v71)), v2)), v74)), v1));
        let mut v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\""); } LIT.with(|lit| lit.clone()) };
        let mut v166: Rc<str> = Rc::<str>::from(format!("{}{}", v164, v165));
        let mut v167: bool = &*v4 == "pdf";
        let v170: Rc<str> = if v167 {
            let mut v168: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" --set tex.command tectonic"); } LIT.with(|lit| lit.clone()) };
            v168
        } else {
            let v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v169
        };
        let v171: Rc<str> = Rc::<str>::from(format!("{}{}", v166, v170));
        let mut v172: Option<Rc<str>> = Some(v3);
        let v173: bool = true;
        let v174: bool = true;
        execute_with_options_68(v171, v155, v156, v157, v158, v173, v172, v174)
    };
    let v179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("ERROR"); } LIT.with(|lit| lit.clone()) };
    let v180: bool = v178.contains(&*v179);
    let mut v181: bool = v180 == false;
    if v181 {
        US29::US29_Ok(v177, v178.clone())
    } else {
        let v184: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        { let _ = spiral_trace_hold(&v184); };
        let v186: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v187, mut v188, mut v189, mut v190, mut v191, mut v192): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v186);
        let v193: US1 = v191.borrow().l0.clone();
        let v198: i32 = match &v193 {
            US1::US1_Critical => {
                50i32
            }
            US1::US1_Debug => {
                20i32
            }
            US1::US1_Info => {
                30i32
            }
            US1::US1_Verbose => {
                10i32
            }
            US1::US1_Warning => {
                40i32
            }
        };
        let v199: bool = v189.borrow().l0;
        let v200: bool = v199 == false;
        let v202: bool = if v200 {
            false
        } else {
            let mut v201: bool = 40i32 >= v198;
            v201
        };
        let v203: bool = v202 == false;
        let v251: US3 = if v203 {
            US3::US3_None
        } else {
            { let _ = spiral_trace_hold(&v184); };
            let (mut v207, mut v208, mut v209, mut v210, mut v211, mut v212): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v186);
            let v213: Rc<str> = method7(v207.clone(), v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone());
            let v214: Rc<str> = method47();
            let v215: Rc<str> = method133(v207, v208, v209, v210, v211, v212, v213, v214, v177, v1, v178.clone());
            { let _ = spiral_trace_hold(&v184); };
            let (mut v218, mut v219, mut v220, mut v221, mut v222, mut v223): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v186);
            let v224: i64 = v218.borrow().l0;
            let v225: i64 = v224.wrapping_add(1i64);
            v218.borrow_mut().l0 = v225;
            let v226: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
            let mut v227: bool = cfg!(target_arch = "wasm32");
            if v227 {
                let v228: Rc<str> = v221.borrow().l0.clone();
                let v229: bool = &*v228 == "";
                let v237: Rc<str> = if v229 {
                    v215.clone()
                } else {
                    let mut v230: bool = &*v215 == "";
                    if v230 {
                        let mut v231: Rc<str> = v221.borrow().l0.clone();
                        v231
                    } else {
                        let mut v232: Rc<str> = v221.borrow().l0.clone();
                        let v233: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v235: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v232, v233)), v215));
                        v235
                    }
                };
                let v239: usize = v237.chars().count();
                let v240: i32 = ((v239) as i32);
                let v241: i32 = v240.wrapping_add(14999i32);
                let v242: i32 = v241.wrapping_div(15000i32);
                let v243: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v244: bool = v215 != v243 ;
                let v246: bool = if v244 {
                    let v245: bool = v242 <= 1i32;
                    v245
                } else {
                    false
                };
                if v246 {
                    v221.borrow_mut().l0 = v237.clone();
                    ()
                } else {
                    v221.borrow_mut().l0 = v243;
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v237); };
                    ()
                }
            } else {
                println!("{}", v215);
                ()
            };
            let mut v249: Rc<dyn Fn(Rc<str>) -> ()> = v219.borrow().l0.clone();
            v249(v215);
            US3::US3_Some(v218, v219, v220, v221, v222, v223)
        };
        US29::US29_Error(v177, v178)
    }
}
fn closure72(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26> {
    Rc::new(move |mut v4: Rc<str>| -> US26 {
        let (mut v5, mut v6): (Rc<str>, Rc<str>) = fix_paths_109(v4.clone(), v3.clone(), v0.clone());
        let mut v7: bool = file_exists_46(v5.clone());
        let mut v8: bool = v7 == false;
        let mut v11: bool = if v8 {
            true
        } else {
            let mut v9: bool = file_exists_46(v6.clone());
            let mut v10: bool = v9 == false;
            v10
        };
        let v176: bool = if v11 {
            false
        } else {
            let mut v12: Rc<str> = normalize_path_28(v5.clone());
            let mut v14: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v12);
            let mut v16: std::fs::File = v14.unwrap();
            let v18: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v16);
            let mut v20: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v18);
            let mut v22: bool = true; let mut v20 = v20;
            let v24: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v26: sha2::Sha256 = result;
            let mut v28: bool = true; let mut v26 = v26;
            let mut v29: usize = ((0i32) as usize);
            let mut v31: _ = [0u8; 1024i32 as usize];
            let mut v33: bool = true; loop { // rust.loop 1;
            let mut v35: bool = true; let mut v31 = v31;
            let v37: Result<usize, std::io::Error> = std::io::Read::read(&mut v20, &mut v31);
            let v39: usize = v37.unwrap();
            let v40: bool = v39 == v29 ;
            let v43: bool = if v40 {
                let v42: bool = true; break ();
                true
            } else {
                false
            };
            let mut v44: usize = ((v39) as usize);
            let mut v45: usize = (v44.clone());
            let mut v47: usize = v31.len();
            let mut v48: bool = v45 == v47 ;
            let v53: &_ = if v48 {
                let v50: &_ = &v31[v29..];
                v50.clone()
            } else {
                let mut v52: &_ = &v31[v29..v44];
                v52.clone()
            };
            let v55: bool = true; sha2::Digest::update(&mut v26, v53);
            let mut v57: bool = true; } // rust.loop 3;
            let mut v59: &[u8] = &sha2::Digest::finalize(v26);
            let v61: Vec<u8> = v59.iter().map(|x| *x).collect::<Vec<_>>();
            let mut v63: Rc<dyn Fn((u8)) -> Rc<str>> = closure62();
            let v64: Vec<Rc<str>> = v61.iter().map(|x| v63(x.clone())).collect::<Vec<_>>();
            let mut v65: Vec<Rc<str>> = method64(v64.clone());
            let v66: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v65));
            let v67: Rc<Vec<Rc<str>>> = Rc::new((v66).borrow().clone());
            let mut v68: usize = (v67).len();
            let v69: i32 = ((v68) as i32);
            let mut v70: i32 = v69.wrapping_sub(1i32);
            let v71: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let v72: Rc<UH0> = method111(v67.clone(), v70, v71.clone());
            let mut v73: Rc<str> = method112();
            let v74: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
            let mut v75: i32 = 0i32;
            let mut v76: i32 = method3(v74.clone(), v72.clone(), v75);
            let mut v77: Rc<Vec<Rc<str>>> = Rc::new(v74.borrow().clone());
            let v78: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v77).as_ref().clone()));
            let mut v79: Rc<str> = Rc::<str>::from((*v78.borrow()).join(&*v73));
            let mut v80: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v79);
            let mut v81: Rc<dyn Fn(std::io::Error) -> std::string::String> = method113();
            let mut v83: Result<Rc<str>, std::string::String> = v80.map_err(|x| v81(x));
            let mut v84: Rc<dyn Fn(Rc<str>) -> US27> = method114();
            let mut v85: Rc<dyn Fn(std::string::String) -> US27> = method115();
            let mut v86: US27 = match v83 { Ok(x) => v84(x), Err(e) => v85(e) };
            let mut v93: Rc<str> = match &v86 {
                US27::US27_Error(v88) => {
                    let mut v88: std::string::String = v88.clone();
                    let v89: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("resultm.get / Error x: "); } LIT.with(|lit| lit.clone()) };
                    let v90: Rc<str> = Rc::<str>::from(format!("{}{}", v89, (&SpiralDebug(&v88)).show()));
                    std::panic::panic_any::<std::string::String>(format!("{}", v90.clone()))
                }
                US27::US27_Ok(v87) => {
                    let mut v87: Rc<str> = v87.clone();
                    v87.clone()
                }
            };
            let v94: Rc<str> = normalize_path_28(v6.clone());
            let v96: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v94);
            let mut v98: std::fs::File = v96.unwrap();
            let v100: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v98);
            let mut v102: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v100);
            let mut v104: bool = true; let mut v102 = v102;
            let v106: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v108: sha2::Sha256 = result;
            let mut v110: bool = true; let mut v108 = v108;
            let v111: usize = ((0i32) as usize);
            let mut v113: _ = [0u8; 1024i32 as usize];
            let mut v115: bool = true; loop { // rust.loop 1;
            let v117: bool = true; let mut v113 = v113;
            let mut v119: Result<usize, std::io::Error> = std::io::Read::read(&mut v102, &mut v113);
            let mut v121: usize = v119.unwrap();
            let mut v122: bool = v121 == v111 ;
            let v125: bool = if v122 {
                let mut v124: bool = true; break ();
                true
            } else {
                false
            };
            let v126: usize = ((v121) as usize);
            let mut v127: usize = (v126.clone());
            let v129: usize = v113.len();
            let mut v130: bool = v127 == v129 ;
            let v135: &_ = if v130 {
                let v132: &_ = &v113[v111..];
                v132.clone()
            } else {
                let v134: &_ = &v113[v111..v126];
                v134.clone()
            };
            let v137: bool = true; sha2::Digest::update(&mut v108, v135);
            let mut v139: bool = true; } // rust.loop 3;
            let v141: &[u8] = &sha2::Digest::finalize(v108);
            let v143: Vec<u8> = v141.iter().map(|x| *x).collect::<Vec<_>>();
            let v145: Vec<Rc<str>> = v143.iter().map(|x| v63(x.clone())).collect::<Vec<_>>();
            let v146: Vec<Rc<str>> = method64(v145.clone());
            let mut v147: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v146));
            let mut v148: Rc<Vec<Rc<str>>> = Rc::new((v147).borrow().clone());
            let v149: usize = (v148).len();
            let mut v150: i32 = ((v149) as i32);
            let mut v151: i32 = v150.wrapping_sub(1i32);
            let mut v152: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let v153: Rc<UH0> = method111(v148.clone(), v151, v152.clone());
            let v154: Rc<str> = method112();
            let mut v155: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
            let v156: i32 = 0i32;
            let v157: i32 = method3(v155.clone(), v153.clone(), v156);
            let v158: Rc<Vec<Rc<str>>> = Rc::new(v155.borrow().clone());
            let mut v159: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v158).as_ref().clone()));
            let v160: Rc<str> = Rc::<str>::from((*v159.borrow()).join(&*v154));
            let mut v161: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v160);
            let mut v162: Rc<dyn Fn(std::io::Error) -> std::string::String> = method113();
            let mut v164: Result<Rc<str>, std::string::String> = v161.map_err(|x| v162(x));
            let mut v165: Rc<dyn Fn(Rc<str>) -> US27> = method114();
            let mut v166: Rc<dyn Fn(std::string::String) -> US27> = method115();
            let mut v167: US27 = match v164 { Ok(x) => v165(x), Err(e) => v166(e) };
            let v174: Rc<str> = match &v167 {
                US27::US27_Error(v169) => {
                    let v169: std::string::String = v169.clone();
                    let v170: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("resultm.get / Error x: "); } LIT.with(|lit| lit.clone()) };
                    let v171: Rc<str> = Rc::<str>::from(format!("{}{}", v170, (&SpiralDebug(&v169)).show()));
                    std::panic::panic_any::<std::string::String>(format!("{}", v171.clone()))
                }
                US27::US27_Ok(v168) => {
                    let mut v168: Rc<str> = v168.clone();
                    v168.clone()
                }
            };
            let mut v175: bool = &*v93 == &*v174;
            v175
        };
        if v176 {
            US26::US26_None
        } else {
            let mut v178: US29 = crowbook_131(v2, v5.clone(), v3.clone(), v1.clone(), v4.clone());
            match &v178 {
                US29::US29_Error(v264, v265) => {
                    let v264: i32 = *v264;
                    let v265: Rc<str> = v265.clone();
                    let (mut v266, mut v267): (Rc<str>, Rc<str>) = method129(v5.clone(), v265.clone());
                    let v268: (Rc<str>, Rc<str>) = (v266, v267);
                    let v269: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v268);
                    US26::US26_Some(v269.clone())
                }
                US29::US29_Ok(v179, v180) => {
                    let v179: i32 = *v179;
                    let v180: Rc<str> = v180.clone();
                    let mut v181: bool = v179 != 0i32 ;
                    if v181 {
                        let mut v183: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v183); };
                        let v185: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v186, mut v187, mut v188, mut v189, mut v190, mut v191): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v185);
                        let v192: US1 = v190.borrow().l0.clone();
                        let v197: i32 = match &v192 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v198: bool = v188.borrow().l0;
                        let v199: bool = v198 == false;
                        let mut v201: bool = if v199 {
                            false
                        } else {
                            let v200: bool = 30i32 >= v197;
                            v200
                        };
                        let v202: bool = v201 == false;
                        let mut v250: US3 = if v202 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v183); };
                            let (mut v206, mut v207, mut v208, mut v209, mut v210, mut v211): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v185);
                            let v212: Rc<str> = method7(v206.clone(), v207.clone(), v208.clone(), v209.clone(), v210.clone(), v211.clone());
                            let v213: Rc<str> = method9();
                            let v214: Rc<str> = method130(v206.clone(), v207.clone(), v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone(), v213.clone(), v179, v180.clone());
                            { let _ = spiral_trace_hold(&v183); };
                            let (mut v217, mut v218, mut v219, mut v220, mut v221, mut v222): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v185);
                            let v223: i64 = v217.borrow().l0;
                            let v224: i64 = v223.wrapping_add(1i64);
                            v217.borrow_mut().l0 = v224;
                            let v225: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v226: bool = cfg!(target_arch = "wasm32");
                            if v226 {
                                let mut v227: Rc<str> = v220.borrow().l0.clone();
                                let v228: bool = &*v227 == "";
                                let mut v236: Rc<str> = if v228 {
                                    v214.clone()
                                } else {
                                    let v229: bool = &*v214 == "";
                                    if v229 {
                                        let mut v230: Rc<str> = v220.borrow().l0.clone();
                                        v230.clone()
                                    } else {
                                        let mut v231: Rc<str> = v220.borrow().l0.clone();
                                        let mut v232: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v234: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v231, v232)), v214));
                                        v234.clone()
                                    }
                                };
                                let v238: usize = v236.chars().count();
                                let v239: i32 = ((v238) as i32);
                                let v240: i32 = v239.wrapping_add(14999i32);
                                let v241: i32 = v240.wrapping_div(15000i32);
                                let v242: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v243: bool = v214 != v242 ;
                                let v245: bool = if v243 {
                                    let v244: bool = v241 <= 1i32;
                                    v244
                                } else {
                                    false
                                };
                                if v245 {
                                    v220.borrow_mut().l0 = v236.clone();
                                    ()
                                } else {
                                    v220.borrow_mut().l0 = v242.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v236); };
                                    ()
                                }
                            } else {
                                println!("{}", v214);
                                ()
                            };
                            let mut v248: Rc<dyn Fn(Rc<str>) -> ()> = v218.borrow().l0.clone();
                            v248(v214.clone());
                            US3::US3_Some(v217.clone(), v218.clone(), v219.clone(), v220.clone(), v221.clone(), v222.clone())
                        };
                        let (mut v251, mut v252): (Rc<str>, Rc<str>) = method129(v5.clone(), v180.clone());
                        let v253: (Rc<str>, Rc<str>) = (v251, v252);
                        let v254: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v253);
                        US26::US26_Some(v254.clone())
                    } else {
                        let v256: bool = file_exists_46(v5.clone());
                        if v256 {
                            file_copy_117(v6.clone(), v5.clone())
                        } else {
                            let mut v257: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.files_fn / "); } LIT.with(|lit| lit.clone()) };
                            let v258: Rc<str> = Rc::<str>::from(format!("{}{}", v257, v5));
                            let v259: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" should exist"); } LIT.with(|lit| lit.clone()) };
                            let v260: Rc<str> = Rc::<str>::from(format!("{}{}", v258, v259));
                            std::panic::panic_any::<std::string::String>(format!("{}", v260.clone()))
                        };
                        let mut v261: Result<Rc<str>, (Rc<str>, Rc<str>)> = Ok::<Rc<str>, (Rc<str>, Rc<str>)>(v5);
                        US26::US26_Some(v261.clone())
                    }
                }
            }
        }
    })
}
fn closure71(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool) -> Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> {
    Rc::new(move |mut v3: Rc<str>| -> Rc<dyn Fn(Rc<str>) -> US26> {
        closure72(v0.clone(), v1.clone(), v2, v3.clone())
    })
}
fn method134(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0;
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_16(v10);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v7)), v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / files' = [] / listm.iter"); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v24, v25)), v8));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_cache_path"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v25)), v9));
    let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v33));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v35, v36))));
    method13(v38)
}
fn method135(mut v0: Rc<RefCell<Vec<Rc<UH2>>>>, mut v1: Rc<UH1>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH1::UH1_Cons(v3, v4) => {
                let mut v3: Rc<UH2> = v3.clone();
                let mut v4: Rc<UH1> = v4.clone();
                v0.borrow_mut().push(v3);
                let mut v5: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v4.clone(), v5);
                continue;
            }
            UH1::UH1_Nil => {
                return v2;
            }
        }
    }
}
fn method136(mut v0: Vec<Rc<UH2>>) -> Vec<Rc<UH2>> {
    v0
}
fn method137(mut v0: Rc<Vec<Rc<UH2>>>, mut v1: i32, mut v2: Rc<UH1>) -> Rc<UH1> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: usize = ((v1) as usize);
            let mut v5: Rc<UH2> = (v0)[v4].clone();
            let mut v6: i32 = v1.wrapping_sub(1i32);
            let mut v7: Rc<UH1> = Rc::new(UH1::UH1_Cons(v5.clone(), v2.clone()));
            (v0, v1, v2) = (v0.clone(), v6, v7.clone());
            continue;
        }
    }
}
fn method139(mut v0: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)>>>, mut v1: Rc<UH2>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH2::UH2_Cons(v3, v4, v5, v6) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<str> = v4.clone();
                let mut v5: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = v5.clone();
                let mut v6: Rc<UH2> = v6.clone();
                v0.borrow_mut().push((v3.clone(), v4.clone(), v5.clone()));
                let mut v7: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v6.clone(), v7);
                continue;
            }
            UH2::UH2_Nil => {
                return v2;
            }
        }
    }
}
fn method140(mut v0: Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)>) -> Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)> {
    v0
}
fn method142(mut v0: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>) -> Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> {
    v0
}
fn method143(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0
}
fn loop_141(mut v0: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)>>>, mut v1: i32, mut v2: i32, mut v3: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    loop {
        let mut v4: bool = v2 < v1;
        if v4 {
            let mut v5: i32 = v2.wrapping_add(1i32);
            let (mut v6, mut v7, mut v8): (Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>) = v0.clone().borrow()[v2 as usize].clone();
            let mut v9: Rc<dyn Fn(Rc<str>) -> US26> = v8(v7.clone());
            let mut v10: US26 = v9(v6.clone());
            let v15: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = match &v10 {
                US26::US26_None => {
                    let mut v13: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = None;
                    v13.clone()
                }
                US26::US26_Some(v11) => {
                    let mut v11: Result<Rc<str>, (Rc<str>, Rc<str>)> = v11.clone();
                    let mut v12: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = Some(v11.clone());
                    v12.clone()
                }
            };
            let mut v16: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = method142(v15.clone());
            let mut v17: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method143(v3.clone());
            let v19: bool = true; let mut v17 = v17;
            let v21: bool = true; v17.push(v16);
            let v23: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = v17;
            (v0, v1, v2, v3) = (v0.clone(), v1, v5, v23.clone());
            continue;
        } else {
            return v3.clone();
        }
    }
}
fn method144(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0
}
fn method145(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0
}
fn method146(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0
}
fn method138(mut v0: Rc<UH1>, mut v1: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    loop {
        match &*v0 {
            UH1::UH1_Cons(v2, v3) => {
                let mut v2: Rc<UH2> = v2.clone();
                let mut v3: Rc<UH1> = v3.clone();
                let mut v4: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)>>> = Rc::new(RefCell::new(Vec::new()));
                let mut v5: i32 = 0i32;
                let mut v6: i32 = method139(v4.clone(), v2.clone(), v5);
                let mut v7: Rc<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)>> = Rc::new(v4.borrow().clone());
                let mut v8: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
                let mut v9: Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)> = (v8).borrow().clone();
                let mut v10: Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)> = method140(v9.clone());
                let mut v11: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>>)>>> = Rc::new(RefCell::new(v10));
                let mut v12: i32 = (v11.borrow().len() as i32);
                let mut v13: i32 = 0i32;
                let mut v14: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = Vec::new();
                let v15: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = loop_141(v11.clone(), v12, v13, v14.clone());
                let mut v16: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method144(v15.clone());
                let mut v17: Rc<RefCell<Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>>> = Rc::new(RefCell::new(v16));
                let v18: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = (v17).borrow().clone();
                let v19: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method145(v18.clone());
                let mut v20: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method146(v1.clone());
                let mut v22: bool = true; let mut v20 = v20;
                let v24: bool = true; v20.extend(v19);
                let mut v26: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = v20;
                (v0, v1) = (v3.clone(), v26.clone());
                continue;
            }
            UH1::UH1_Nil => {
                return v1.clone();
            }
        }
    }
}
fn method147(mut v0: Rc<str>, mut v1: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) {
    (v0, v1)
}
fn method148(mut v0: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>) -> Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> {
    v0
}
fn method149(mut v0: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> {
    v0
}
fn loop_65(mut v0: bool, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>, mut v5: Rc<str>, mut v6: Rc<RefCell<Vec<Rc<str>>>>, mut v7: i32, mut v8: i32, mut v9: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> {
    loop {
        let mut v10: bool = v8 < v7;
        if v10 {
            let mut v11: i32 = v8.wrapping_add(1i32);
            let mut v12: Rc<str> = v6.clone().borrow()[v8 as usize].clone();
            let mut v13: Rc<str> = get_full_path_49(v12.clone());
            let v15: &str = &*v13;
            let mut v17: std::string::String = String::from(v15);
            let v19: std::path::PathBuf = std::path::PathBuf::from(v17);
            let mut v20: std::path::PathBuf = method35(v19.clone());
            let mut v22: std::path::Display = v20.display();
            let v24: std::string::String = format!("{}", v22);
            let mut v26: Rc<str> = Rc::<str>::from(String::as_str(&v24));
            let mut v27: Rc<str> = method66();
            let mut v28: Rc<str> = Rc::<str>::from(v26.replace(&*v4, &*v27));
            let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let mut v31: Rc<str> = Rc::<str>::from(v28.replace(&*v29, &*v30));
            let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
            let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v31));
            let mut v34: Rc<str> = normalize_path_28(v13.clone());
            let mut v35: Rc<str> = method39(v3.clone(), v33.clone());
            let v36: Rc<str> = standardize_path_67(v35.clone());
            let v37: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
            let mut v38: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
            let v39: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
            let v40: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
            let v41: Option<Rc<str>> = None;
            let v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("git ls-tree --format='%(objectname)' origin/gh-pages \""); } LIT.with(|lit| lit.clone()) };
            let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v36));
            let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\""); } LIT.with(|lit| lit.clone()) };
            let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v44));
            let mut v46: Option<Rc<str>> = Some(v3.clone());
            let mut v47: bool = true;
            let mut v48: bool = true;
            let (mut v49, mut v50): (i32, Rc<str>) = execute_with_options_68(v45.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v47, v46.clone(), v48);
            let v51: Rc<str> = method39(v4.clone(), v33.clone());
            let mut v52: Rc<str> = standardize_path_67(v51.clone());
            let v53: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
            let v54: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
            let v55: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
            let v56: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
            let mut v57: Option<Rc<str>> = None;
            let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("git hash-object \""); } LIT.with(|lit| lit.clone()) };
            let v60: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v58, v52)), v44));
            let v61: Option<Rc<str>> = Some(v4.clone());
            let v62: bool = true;
            let mut v63: bool = true;
            let (mut v64, mut v65): (i32, Rc<str>) = execute_with_options_68(v60.clone(), v53.clone(), v54.clone(), v55.clone(), v56.clone(), v62, v61.clone(), v63);
            let v66: Rc<str> = method39(v5.clone(), v33.clone());
            let v67: Rc<str> = standardize_path_67(v66.clone());
            let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul.md"); } LIT.with(|lit| lit.clone()) };
            let (mut v69, mut v70): (Rc<str>, Rc<str>) = fix_paths_109(v68.clone(), v52.clone(), v5.clone());
            let v71: bool = false;
            let v72: bool = false;
            let mut v73: bool = false;
            let v74: bool = true;
            let mut v75: bool = true;
            let mut v76: bool = true;
            let mut v77: bool = v50.contains(&*v65);
            let v448: Rc<UH1> = if v77 {
                { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) }
            } else {
                let mut v79: Rc<str> = normalize_path_28(v52.clone());
                let mut v81: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v79);
                let mut v83: std::fs::File = v81.unwrap();
                let mut v85: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v83);
                let mut v87: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v85);
                let v89: bool = true; let mut v87 = v87;
                let v91: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
                let mut v93: sha2::Sha256 = result;
                let v95: bool = true; let mut v93 = v93;
                let v96: usize = ((0i32) as usize);
                let mut v98: _ = [0u8; 1024i32 as usize];
                let v100: bool = true; loop { // rust.loop 1;
                let mut v102: bool = true; let mut v98 = v98;
                let mut v104: Result<usize, std::io::Error> = std::io::Read::read(&mut v87, &mut v98);
                let v106: usize = v104.unwrap();
                let v107: bool = v106 == v96 ;
                let mut v110: bool = if v107 {
                    let mut v109: bool = true; break ();
                    true
                } else {
                    false
                };
                let v111: usize = ((v106) as usize);
                let mut v112: usize = (v111.clone());
                let v114: usize = v98.len();
                let mut v115: bool = v112 == v114 ;
                let v120: &_ = if v115 {
                    let v117: &_ = &v98[v96..];
                    v117.clone()
                } else {
                    let mut v119: &_ = &v98[v96..v111];
                    v119.clone()
                };
                let mut v122: bool = true; sha2::Digest::update(&mut v93, v120);
                let mut v124: bool = true; } // rust.loop 3;
                let v126: &[u8] = &sha2::Digest::finalize(v93);
                let v128: Vec<u8> = v126.iter().map(|x| *x).collect::<Vec<_>>();
                let mut v130: Rc<dyn Fn((u8)) -> Rc<str>> = closure62();
                let v131: Vec<Rc<str>> = v128.iter().map(|x| v130(x.clone())).collect::<Vec<_>>();
                let v132: Vec<Rc<str>> = method64(v131.clone());
                let v133: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v132));
                let v134: Rc<Vec<Rc<str>>> = Rc::new((v133).borrow().clone());
                let v135: usize = (v134).len();
                let v136: i32 = ((v135) as i32);
                let v137: i32 = v136.wrapping_sub(1i32);
                let v138: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                let mut v139: Rc<UH0> = method111(v134.clone(), v137, v138.clone());
                let v140: Rc<str> = method112();
                let v141: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
                let v142: i32 = 0i32;
                let v143: i32 = method3(v141.clone(), v139.clone(), v142);
                let v144: Rc<Vec<Rc<str>>> = Rc::new(v141.borrow().clone());
                let v145: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v144).as_ref().clone()));
                let v146: Rc<str> = Rc::<str>::from((*v145.borrow()).join(&*v140));
                let mut v147: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v146);
                let mut v148: Rc<dyn Fn(std::io::Error) -> std::string::String> = method113();
                let mut v150: Result<Rc<str>, std::string::String> = v147.map_err(|x| v148(x));
                let mut v151: Rc<dyn Fn(Rc<str>) -> US27> = method114();
                let mut v152: Rc<dyn Fn(std::string::String) -> US27> = method115();
                let v153: US27 = match v150 { Ok(x) => v151(x), Err(e) => v152(e) };
                let v160: Rc<str> = match &v153 {
                    US27::US27_Error(v155) => {
                        let mut v155: std::string::String = v155.clone();
                        let v156: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("resultm.get / Error x: "); } LIT.with(|lit| lit.clone()) };
                        let v157: Rc<str> = Rc::<str>::from(format!("{}{}", v156, (&SpiralDebug(&v155)).show()));
                        std::panic::panic_any::<std::string::String>(format!("{}", v157.clone()))
                    }
                    US27::US27_Ok(v154) => {
                        let v154: Rc<str> = v154.clone();
                        v154.clone()
                    }
                };
                let mut v161: bool = file_exists_46(v67.clone());
                let mut v162: bool = v161 == false;
                let v244: US0 = if v162 {
                    US0::US0_None
                } else {
                    let mut v164: Rc<str> = normalize_path_28(v67.clone());
                    let mut v166: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v164);
                    let mut v168: std::fs::File = v166.unwrap();
                    let v170: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v168);
                    let mut v172: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v170);
                    let v174: bool = true; let mut v172 = v172;
                    let v176: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
                    let mut v178: sha2::Sha256 = result;
                    let v180: bool = true; let mut v178 = v178;
                    let mut v181: usize = ((0i32) as usize);
                    let mut v183: _ = [0u8; 1024i32 as usize];
                    let v185: bool = true; loop { // rust.loop 1;
                    let v187: bool = true; let mut v183 = v183;
                    let mut v189: Result<usize, std::io::Error> = std::io::Read::read(&mut v172, &mut v183);
                    let v191: usize = v189.unwrap();
                    let v192: bool = v191 == v181 ;
                    let v195: bool = if v192 {
                        let v194: bool = true; break ();
                        true
                    } else {
                        false
                    };
                    let v196: usize = ((v191) as usize);
                    let v197: usize = (v196.clone());
                    let v199: usize = v183.len();
                    let v200: bool = v197 == v199 ;
                    let v205: &_ = if v200 {
                        let v202: &_ = &v183[v181..];
                        v202.clone()
                    } else {
                        let v204: &_ = &v183[v181..v196];
                        v204.clone()
                    };
                    let v207: bool = true; sha2::Digest::update(&mut v178, v205);
                    let v209: bool = true; } // rust.loop 3;
                    let v211: &[u8] = &sha2::Digest::finalize(v178);
                    let v213: Vec<u8> = v211.iter().map(|x| *x).collect::<Vec<_>>();
                    let v215: Vec<Rc<str>> = v213.iter().map(|x| v130(x.clone())).collect::<Vec<_>>();
                    let v216: Vec<Rc<str>> = method64(v215.clone());
                    let mut v217: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v216));
                    let mut v218: Rc<Vec<Rc<str>>> = Rc::new((v217).borrow().clone());
                    let mut v219: usize = (v218).len();
                    let mut v220: i32 = ((v219) as i32);
                    let mut v221: i32 = v220.wrapping_sub(1i32);
                    let mut v222: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                    let v223: Rc<UH0> = method111(v218.clone(), v221, v222.clone());
                    let v224: Rc<str> = method112();
                    let v225: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
                    let v226: i32 = 0i32;
                    let mut v227: i32 = method3(v225.clone(), v223.clone(), v226);
                    let v228: Rc<Vec<Rc<str>>> = Rc::new(v225.borrow().clone());
                    let v229: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v228).as_ref().clone()));
                    let mut v230: Rc<str> = Rc::<str>::from((*v229.borrow()).join(&*v224));
                    let mut v231: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v230);
                    let mut v232: Rc<dyn Fn(std::io::Error) -> std::string::String> = method113();
                    let v234: Result<Rc<str>, std::string::String> = v231.map_err(|x| v232(x));
                    let mut v235: Rc<dyn Fn(Rc<str>) -> US27> = method114();
                    let mut v236: Rc<dyn Fn(std::string::String) -> US27> = method115();
                    let v237: US27 = match v234 { Ok(x) => v235(x), Err(e) => v236(e) };
                    match &v237 {
                        US27::US27_Error(v240) => {
                            let v240: std::string::String = v240.clone();
                            US0::US0_None
                        }
                        US27::US27_Ok(v238) => {
                            let v238: Rc<str> = v238.clone();
                            US0::US0_Some(v238.clone())
                        }
                    }
                };
                match &v244 {
                    US0::US0_Some(v245) => {
                        let v245: Rc<str> = v245.clone();
                        let v246: bool = &*v160 == &*v245;
                        if v246 {
                            { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) }
                        } else {
                            let mut v249: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                            { let _ = spiral_trace_hold(&v249); };
                            let v251: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                            let (mut v252, mut v253, mut v254, mut v255, mut v256, mut v257): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v251);
                            let v258: US1 = v256.borrow().l0.clone();
                            let v263: i32 = match &v258 {
                                US1::US1_Critical => {
                                    50i32
                                }
                                US1::US1_Debug => {
                                    20i32
                                }
                                US1::US1_Info => {
                                    30i32
                                }
                                US1::US1_Verbose => {
                                    10i32
                                }
                                US1::US1_Warning => {
                                    40i32
                                }
                            };
                            let v264: bool = v254.borrow().l0;
                            let v265: bool = v264 == false;
                            let v267: bool = if v265 {
                                false
                            } else {
                                let v266: bool = 30i32 >= v263;
                                v266
                            };
                            let v268: bool = v267 == false;
                            let v324: US3 = if v268 {
                                US3::US3_None
                            } else {
                                { let _ = spiral_trace_hold(&v249); };
                                let (mut v272, mut v273, mut v274, mut v275, mut v276, mut v277): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v251);
                                let v278: Rc<str> = method7(v272.clone(), v273.clone(), v274.clone(), v275.clone(), v276.clone(), v277.clone());
                                let v279: Rc<str> = method9();
                                let v280: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map"); } LIT.with(|lit| lit.clone()) };
                                let v281: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                                let v282: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                                let v283: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                                let v284: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                                let v285: bool = &*v284 == "";
                                let v288: Rc<str> = if v285 {
                                    let v286: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v286.clone()
                                } else {
                                    method116(v272.clone(), v273.clone(), v274.clone(), v275.clone(), v276.clone(), v277.clone(), v278.clone(), v279.clone(), v284.clone(), v34.clone(), v36.clone(), v33.clone(), v49, v50.clone(), v64, v65.clone(), v160.clone(), v244.clone(), v52.clone(), v67.clone())
                                };
                                { let _ = spiral_trace_hold(&v249); };
                                let (mut v291, mut v292, mut v293, mut v294, mut v295, mut v296): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v251);
                                let v297: i64 = v291.borrow().l0;
                                let v298: i64 = v297.wrapping_add(1i64);
                                v291.borrow_mut().l0 = v298;
                                let v299: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                                let v300: bool = cfg!(target_arch = "wasm32");
                                if v300 {
                                    let v301: Rc<str> = v294.borrow().l0.clone();
                                    let v302: bool = &*v301 == "";
                                    let v310: Rc<str> = if v302 {
                                        v288.clone()
                                    } else {
                                        let v303: bool = &*v288 == "";
                                        if v303 {
                                            let v304: Rc<str> = v294.borrow().l0.clone();
                                            v304.clone()
                                        } else {
                                            let v305: Rc<str> = v294.borrow().l0.clone();
                                            let v306: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                            let v308: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v305, v306)), v288));
                                            v308.clone()
                                        }
                                    };
                                    let v312: usize = v310.chars().count();
                                    let v313: i32 = ((v312) as i32);
                                    let v314: i32 = v313.wrapping_add(14999i32);
                                    let v315: i32 = v314.wrapping_div(15000i32);
                                    let v316: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    let v317: bool = v288 != v316 ;
                                    let v319: bool = if v317 {
                                        let mut v318: bool = v315 <= 1i32;
                                        v318
                                    } else {
                                        false
                                    };
                                    if v319 {
                                        v294.borrow_mut().l0 = v310.clone();
                                        ()
                                    } else {
                                        v294.borrow_mut().l0 = v316.clone();
                                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v310); };
                                        ()
                                    }
                                } else {
                                    println!("{}", v288);
                                    ()
                                };
                                let mut v322: Rc<dyn Fn(Rc<str>) -> ()> = v292.borrow().l0.clone();
                                v322(v288.clone());
                                US3::US3_Some(v291.clone(), v292.clone(), v293.clone(), v294.clone(), v295.clone(), v296.clone())
                            };
                            file_copy_117(v67.clone(), v52.clone());
                            let v325: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure68(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                            let v326: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                            let v327: Rc<UH2> = Rc::new(UH2::UH2_Cons(v68.clone(), v52.clone(), v325.clone(), v326.clone()));
                            let v328: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                            let mut v329: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v71);
                            let v330: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                            let v331: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v72);
                            let mut v332: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                            let v333: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v73);
                            let v334: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v74);
                            let v335: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v75);
                            let v336: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v76);
                            let v337: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                            let v338: Rc<UH2> = Rc::new(UH2::UH2_Cons(v332.clone(), v69.clone(), v336.clone(), v337.clone()));
                            let v339: Rc<UH2> = Rc::new(UH2::UH2_Cons(v330.clone(), v69.clone(), v335.clone(), v338.clone()));
                            let v340: Rc<UH2> = Rc::new(UH2::UH2_Cons(v328.clone(), v69.clone(), v334.clone(), v339.clone()));
                            let v341: Rc<UH2> = Rc::new(UH2::UH2_Cons(v332.clone(), v52.clone(), v333.clone(), v340.clone()));
                            let v342: Rc<UH2> = Rc::new(UH2::UH2_Cons(v330.clone(), v52.clone(), v331.clone(), v341.clone()));
                            let v343: Rc<UH2> = Rc::new(UH2::UH2_Cons(v328.clone(), v52.clone(), v329.clone(), v342.clone()));
                            let v344: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
                            let v345: Rc<UH1> = Rc::new(UH1::UH1_Cons(v343.clone(), v344.clone()));
                            Rc::new(UH1::UH1_Cons(v327.clone(), v345.clone()))
                        }
                    }
                    _ => {
                        let v349: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v349); };
                        let v351: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v352, mut v353, mut v354, mut v355, mut v356, mut v357): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v351);
                        let v358: US1 = v356.borrow().l0.clone();
                        let v363: i32 = match &v358 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v364: bool = v354.borrow().l0;
                        let v365: bool = v364 == false;
                        let v367: bool = if v365 {
                            false
                        } else {
                            let v366: bool = 30i32 >= v363;
                            v366
                        };
                        let v368: bool = v367 == false;
                        let v424: US3 = if v368 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v349); };
                            let (mut v372, mut v373, mut v374, mut v375, mut v376, mut v377): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v351);
                            let v378: Rc<str> = method7(v372.clone(), v373.clone(), v374.clone(), v375.clone(), v376.clone(), v377.clone());
                            let v379: Rc<str> = method9();
                            let v380: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map"); } LIT.with(|lit| lit.clone()) };
                            let v381: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                            let v382: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                            let v383: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                            let v384: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                            let v385: bool = &*v384 == "";
                            let v388: Rc<str> = if v385 {
                                let v386: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                v386.clone()
                            } else {
                                method116(v372.clone(), v373.clone(), v374.clone(), v375.clone(), v376.clone(), v377.clone(), v378.clone(), v379.clone(), v384.clone(), v34.clone(), v36.clone(), v33.clone(), v49, v50.clone(), v64, v65.clone(), v160.clone(), v244.clone(), v52.clone(), v67.clone())
                            };
                            { let _ = spiral_trace_hold(&v349); };
                            let (mut v391, mut v392, mut v393, mut v394, mut v395, mut v396): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v351);
                            let v397: i64 = v391.borrow().l0;
                            let v398: i64 = v397.wrapping_add(1i64);
                            v391.borrow_mut().l0 = v398;
                            let v399: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v400: bool = cfg!(target_arch = "wasm32");
                            if v400 {
                                let v401: Rc<str> = v394.borrow().l0.clone();
                                let v402: bool = &*v401 == "";
                                let v410: Rc<str> = if v402 {
                                    v388.clone()
                                } else {
                                    let v403: bool = &*v388 == "";
                                    if v403 {
                                        let v404: Rc<str> = v394.borrow().l0.clone();
                                        v404.clone()
                                    } else {
                                        let v405: Rc<str> = v394.borrow().l0.clone();
                                        let v406: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v408: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v405, v406)), v388));
                                        v408.clone()
                                    }
                                };
                                let v412: usize = v410.chars().count();
                                let v413: i32 = ((v412) as i32);
                                let v414: i32 = v413.wrapping_add(14999i32);
                                let v415: i32 = v414.wrapping_div(15000i32);
                                let v416: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v417: bool = v388 != v416 ;
                                let v419: bool = if v417 {
                                    let v418: bool = v415 <= 1i32;
                                    v418
                                } else {
                                    false
                                };
                                if v419 {
                                    v394.borrow_mut().l0 = v410.clone();
                                    ()
                                } else {
                                    v394.borrow_mut().l0 = v416.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v410); };
                                    ()
                                }
                            } else {
                                println!("{}", v388);
                                ()
                            };
                            let mut v422: Rc<dyn Fn(Rc<str>) -> ()> = v392.borrow().l0.clone();
                            v422(v388.clone());
                            US3::US3_Some(v391.clone(), v392.clone(), v393.clone(), v394.clone(), v395.clone(), v396.clone())
                        };
                        file_copy_117(v67.clone(), v52.clone());
                        let v425: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure68(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                        let v426: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                        let v427: Rc<UH2> = Rc::new(UH2::UH2_Cons(v68.clone(), v52.clone(), v425.clone(), v426.clone()));
                        let v428: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                        let v429: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v71);
                        let v430: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                        let v431: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v72);
                        let v432: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                        let v433: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v73);
                        let v434: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v74);
                        let v435: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v75);
                        let v436: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v76);
                        let v437: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                        let v438: Rc<UH2> = Rc::new(UH2::UH2_Cons(v432.clone(), v69.clone(), v436.clone(), v437.clone()));
                        let v439: Rc<UH2> = Rc::new(UH2::UH2_Cons(v430.clone(), v69.clone(), v435.clone(), v438.clone()));
                        let v440: Rc<UH2> = Rc::new(UH2::UH2_Cons(v428.clone(), v69.clone(), v434.clone(), v439.clone()));
                        let v441: Rc<UH2> = Rc::new(UH2::UH2_Cons(v432.clone(), v52.clone(), v433.clone(), v440.clone()));
                        let v442: Rc<UH2> = Rc::new(UH2::UH2_Cons(v430.clone(), v52.clone(), v431.clone(), v441.clone()));
                        let v443: Rc<UH2> = Rc::new(UH2::UH2_Cons(v428.clone(), v52.clone(), v429.clone(), v442.clone()));
                        let v444: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
                        let v445: Rc<UH1> = Rc::new(UH1::UH1_Cons(v443.clone(), v444.clone()));
                        Rc::new(UH1::UH1_Cons(v427.clone(), v445.clone()))
                    }
                }
            };
            let v449: bool = match &*v448 {
                UH1::UH1_Nil => {
                    true
                }
                _ => {
                    false
                }
            };
            let v450: bool = v449 != true;
            let v1014: Rc<UH1> = if v450 {
                v448.clone()
            } else {
                let v451: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                let (mut v452, mut v453): (Rc<str>, Rc<str>) = fix_paths_109(v451.clone(), v69.clone(), v5.clone());
                let v454: bool = file_exists_46(v452.clone());
                let v527: bool = if v454 {
                    true
                } else {
                    let v455: bool = file_exists_46(v453.clone());
                    let v456: bool = v455 == false;
                    if v456 {
                        true
                    } else {
                        let v458: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v458); };
                        let v460: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v461, mut v462, mut v463, mut v464, mut v465, mut v466): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v460);
                        let v467: US1 = v465.borrow().l0.clone();
                        let v472: i32 = match &v467 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v473: bool = v463.borrow().l0;
                        let v474: bool = v473 == false;
                        let v476: bool = if v474 {
                            false
                        } else {
                            let v475: bool = 30i32 >= v472;
                            v475
                        };
                        let v477: bool = v476 == false;
                        let v525: US3 = if v477 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v458); };
                            let (mut v481, mut v482, mut v483, mut v484, mut v485, mut v486): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v460);
                            let v487: Rc<str> = method7(v481.clone(), v482.clone(), v483.clone(), v484.clone(), v485.clone(), v486.clone());
                            let v488: Rc<str> = method9();
                            let v489: Rc<str> = method134(v481.clone(), v482.clone(), v483.clone(), v484.clone(), v485.clone(), v486.clone(), v487.clone(), v488.clone(), v452.clone(), v453.clone());
                            { let _ = spiral_trace_hold(&v458); };
                            let (mut v492, mut v493, mut v494, mut v495, mut v496, mut v497): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v460);
                            let v498: i64 = v492.borrow().l0;
                            let v499: i64 = v498.wrapping_add(1i64);
                            v492.borrow_mut().l0 = v499;
                            let v500: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v501: bool = cfg!(target_arch = "wasm32");
                            if v501 {
                                let v502: Rc<str> = v495.borrow().l0.clone();
                                let v503: bool = &*v502 == "";
                                let v511: Rc<str> = if v503 {
                                    v489.clone()
                                } else {
                                    let v504: bool = &*v489 == "";
                                    if v504 {
                                        let v505: Rc<str> = v495.borrow().l0.clone();
                                        v505.clone()
                                    } else {
                                        let v506: Rc<str> = v495.borrow().l0.clone();
                                        let v507: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v509: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v506, v507)), v489));
                                        v509.clone()
                                    }
                                };
                                let v513: usize = v511.chars().count();
                                let v514: i32 = ((v513) as i32);
                                let v515: i32 = v514.wrapping_add(14999i32);
                                let v516: i32 = v515.wrapping_div(15000i32);
                                let v517: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v518: bool = v489 != v517 ;
                                let v520: bool = if v518 {
                                    let v519: bool = v516 <= 1i32;
                                    v519
                                } else {
                                    false
                                };
                                if v520 {
                                    v495.borrow_mut().l0 = v511.clone();
                                    ()
                                } else {
                                    v495.borrow_mut().l0 = v517.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v511); };
                                    ()
                                }
                            } else {
                                println!("{}", v489);
                                ()
                            };
                            let mut v523: Rc<dyn Fn(Rc<str>) -> ()> = v493.borrow().l0.clone();
                            v523(v489.clone());
                            US3::US3_Some(v492.clone(), v493.clone(), v494.clone(), v495.clone(), v496.clone(), v497.clone())
                        };
                        file_copy_117(v452.clone(), v453.clone());
                        false
                    }
                };
                let v532: Rc<UH2> = if v527 {
                    let v528: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v76);
                    let v529: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                    Rc::new(UH2::UH2_Cons(v451.clone(), v69.clone(), v528.clone(), v529.clone()))
                } else {
                    { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) }
                };
                let v533: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                let (mut v534, mut v535): (Rc<str>, Rc<str>) = fix_paths_109(v533.clone(), v69.clone(), v5.clone());
                let v536: bool = file_exists_46(v534.clone());
                let v609: bool = if v536 {
                    true
                } else {
                    let v537: bool = file_exists_46(v535.clone());
                    let v538: bool = v537 == false;
                    if v538 {
                        true
                    } else {
                        let v540: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v540); };
                        let v542: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v543, mut v544, mut v545, mut v546, mut v547, mut v548): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v542);
                        let v549: US1 = v547.borrow().l0.clone();
                        let v554: i32 = match &v549 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v555: bool = v545.borrow().l0;
                        let v556: bool = v555 == false;
                        let v558: bool = if v556 {
                            false
                        } else {
                            let v557: bool = 30i32 >= v554;
                            v557
                        };
                        let v559: bool = v558 == false;
                        let v607: US3 = if v559 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v540); };
                            let (mut v563, mut v564, mut v565, mut v566, mut v567, mut v568): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v542);
                            let v569: Rc<str> = method7(v563.clone(), v564.clone(), v565.clone(), v566.clone(), v567.clone(), v568.clone());
                            let v570: Rc<str> = method9();
                            let mut v571: Rc<str> = method134(v563.clone(), v564.clone(), v565.clone(), v566.clone(), v567.clone(), v568.clone(), v569.clone(), v570.clone(), v534.clone(), v535.clone());
                            { let _ = spiral_trace_hold(&v540); };
                            let (mut v574, mut v575, mut v576, mut v577, mut v578, mut v579): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v542);
                            let mut v580: i64 = v574.borrow().l0;
                            let v581: i64 = v580.wrapping_add(1i64);
                            v574.borrow_mut().l0 = v581;
                            let v582: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v583: bool = cfg!(target_arch = "wasm32");
                            if v583 {
                                let v584: Rc<str> = v577.borrow().l0.clone();
                                let v585: bool = &*v584 == "";
                                let v593: Rc<str> = if v585 {
                                    v571.clone()
                                } else {
                                    let v586: bool = &*v571 == "";
                                    if v586 {
                                        let v587: Rc<str> = v577.borrow().l0.clone();
                                        v587.clone()
                                    } else {
                                        let v588: Rc<str> = v577.borrow().l0.clone();
                                        let v589: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v591: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v588, v589)), v571));
                                        v591.clone()
                                    }
                                };
                                let v595: usize = v593.chars().count();
                                let v596: i32 = ((v595) as i32);
                                let v597: i32 = v596.wrapping_add(14999i32);
                                let v598: i32 = v597.wrapping_div(15000i32);
                                let v599: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v600: bool = v571 != v599 ;
                                let v602: bool = if v600 {
                                    let v601: bool = v598 <= 1i32;
                                    v601
                                } else {
                                    false
                                };
                                if v602 {
                                    v577.borrow_mut().l0 = v593.clone();
                                    ()
                                } else {
                                    v577.borrow_mut().l0 = v599.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v593); };
                                    ()
                                }
                            } else {
                                println!("{}", v571);
                                ()
                            };
                            let mut v605: Rc<dyn Fn(Rc<str>) -> ()> = v575.borrow().l0.clone();
                            v605(v571.clone());
                            US3::US3_Some(v574.clone(), v575.clone(), v576.clone(), v577.clone(), v578.clone(), v579.clone())
                        };
                        file_copy_117(v534.clone(), v535.clone());
                        false
                    }
                };
                let v612: Rc<UH2> = if v609 {
                    let v610: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v75);
                    Rc::new(UH2::UH2_Cons(v533.clone(), v69.clone(), v610.clone(), v532.clone()))
                } else {
                    v532.clone()
                };
                let v613: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                let (mut v614, mut v615): (Rc<str>, Rc<str>) = fix_paths_109(v613.clone(), v69.clone(), v5.clone());
                let v616: bool = file_exists_46(v614.clone());
                let v689: bool = if v616 {
                    true
                } else {
                    let v617: bool = file_exists_46(v615.clone());
                    let v618: bool = v617 == false;
                    if v618 {
                        true
                    } else {
                        let v620: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v620); };
                        let v622: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v623, mut v624, mut v625, mut v626, mut v627, mut v628): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v622);
                        let v629: US1 = v627.borrow().l0.clone();
                        let v634: i32 = match &v629 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v635: bool = v625.borrow().l0;
                        let v636: bool = v635 == false;
                        let v638: bool = if v636 {
                            false
                        } else {
                            let v637: bool = 30i32 >= v634;
                            v637
                        };
                        let v639: bool = v638 == false;
                        let v687: US3 = if v639 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v620); };
                            let (mut v643, mut v644, mut v645, mut v646, mut v647, mut v648): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v622);
                            let v649: Rc<str> = method7(v643.clone(), v644.clone(), v645.clone(), v646.clone(), v647.clone(), v648.clone());
                            let v650: Rc<str> = method9();
                            let v651: Rc<str> = method134(v643.clone(), v644.clone(), v645.clone(), v646.clone(), v647.clone(), v648.clone(), v649.clone(), v650.clone(), v614.clone(), v615.clone());
                            { let _ = spiral_trace_hold(&v620); };
                            let (mut v654, mut v655, mut v656, mut v657, mut v658, mut v659): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v622);
                            let v660: i64 = v654.borrow().l0;
                            let v661: i64 = v660.wrapping_add(1i64);
                            v654.borrow_mut().l0 = v661;
                            let v662: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v663: bool = cfg!(target_arch = "wasm32");
                            if v663 {
                                let v664: Rc<str> = v657.borrow().l0.clone();
                                let v665: bool = &*v664 == "";
                                let v673: Rc<str> = if v665 {
                                    v651.clone()
                                } else {
                                    let v666: bool = &*v651 == "";
                                    if v666 {
                                        let v667: Rc<str> = v657.borrow().l0.clone();
                                        v667.clone()
                                    } else {
                                        let v668: Rc<str> = v657.borrow().l0.clone();
                                        let v669: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v671: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v668, v669)), v651));
                                        v671.clone()
                                    }
                                };
                                let v675: usize = v673.chars().count();
                                let v676: i32 = ((v675) as i32);
                                let v677: i32 = v676.wrapping_add(14999i32);
                                let v678: i32 = v677.wrapping_div(15000i32);
                                let v679: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v680: bool = v651 != v679 ;
                                let v682: bool = if v680 {
                                    let v681: bool = v678 <= 1i32;
                                    v681
                                } else {
                                    false
                                };
                                if v682 {
                                    v657.borrow_mut().l0 = v673.clone();
                                    ()
                                } else {
                                    v657.borrow_mut().l0 = v679.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v673); };
                                    ()
                                }
                            } else {
                                println!("{}", v651);
                                ()
                            };
                            let mut v685: Rc<dyn Fn(Rc<str>) -> ()> = v655.borrow().l0.clone();
                            v685(v651.clone());
                            US3::US3_Some(v654.clone(), v655.clone(), v656.clone(), v657.clone(), v658.clone(), v659.clone())
                        };
                        file_copy_117(v614.clone(), v615.clone());
                        false
                    }
                };
                let v692: Rc<UH2> = if v689 {
                    let v690: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v74);
                    Rc::new(UH2::UH2_Cons(v613.clone(), v69.clone(), v690.clone(), v612.clone()))
                } else {
                    v612.clone()
                };
                let (mut v693, mut v694): (Rc<str>, Rc<str>) = fix_paths_109(v451.clone(), v52.clone(), v5.clone());
                let v695: bool = file_exists_46(v693.clone());
                let v768: bool = if v695 {
                    true
                } else {
                    let v696: bool = file_exists_46(v694.clone());
                    let v697: bool = v696 == false;
                    if v697 {
                        true
                    } else {
                        let v699: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v699); };
                        let v701: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v702, mut v703, mut v704, mut v705, mut v706, mut v707): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v701);
                        let v708: US1 = v706.borrow().l0.clone();
                        let v713: i32 = match &v708 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v714: bool = v704.borrow().l0;
                        let v715: bool = v714 == false;
                        let v717: bool = if v715 {
                            false
                        } else {
                            let v716: bool = 30i32 >= v713;
                            v716
                        };
                        let v718: bool = v717 == false;
                        let v766: US3 = if v718 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v699); };
                            let (mut v722, mut v723, mut v724, mut v725, mut v726, mut v727): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v701);
                            let v728: Rc<str> = method7(v722.clone(), v723.clone(), v724.clone(), v725.clone(), v726.clone(), v727.clone());
                            let v729: Rc<str> = method9();
                            let v730: Rc<str> = method134(v722.clone(), v723.clone(), v724.clone(), v725.clone(), v726.clone(), v727.clone(), v728.clone(), v729.clone(), v693.clone(), v694.clone());
                            { let _ = spiral_trace_hold(&v699); };
                            let (mut v733, mut v734, mut v735, mut v736, mut v737, mut v738): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v701);
                            let v739: i64 = v733.borrow().l0;
                            let v740: i64 = v739.wrapping_add(1i64);
                            v733.borrow_mut().l0 = v740;
                            let v741: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v742: bool = cfg!(target_arch = "wasm32");
                            if v742 {
                                let v743: Rc<str> = v736.borrow().l0.clone();
                                let v744: bool = &*v743 == "";
                                let v752: Rc<str> = if v744 {
                                    v730.clone()
                                } else {
                                    let v745: bool = &*v730 == "";
                                    if v745 {
                                        let v746: Rc<str> = v736.borrow().l0.clone();
                                        v746.clone()
                                    } else {
                                        let v747: Rc<str> = v736.borrow().l0.clone();
                                        let v748: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v750: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v747, v748)), v730));
                                        v750.clone()
                                    }
                                };
                                let v754: usize = v752.chars().count();
                                let v755: i32 = ((v754) as i32);
                                let v756: i32 = v755.wrapping_add(14999i32);
                                let v757: i32 = v756.wrapping_div(15000i32);
                                let v758: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v759: bool = v730 != v758 ;
                                let v761: bool = if v759 {
                                    let v760: bool = v757 <= 1i32;
                                    v760
                                } else {
                                    false
                                };
                                if v761 {
                                    v736.borrow_mut().l0 = v752.clone();
                                    ()
                                } else {
                                    v736.borrow_mut().l0 = v758.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v752); };
                                    ()
                                }
                            } else {
                                println!("{}", v730);
                                ()
                            };
                            let mut v764: Rc<dyn Fn(Rc<str>) -> ()> = v734.borrow().l0.clone();
                            v764(v730.clone());
                            US3::US3_Some(v733.clone(), v734.clone(), v735.clone(), v736.clone(), v737.clone(), v738.clone())
                        };
                        file_copy_117(v693.clone(), v694.clone());
                        false
                    }
                };
                let v771: Rc<UH2> = if v768 {
                    let v769: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v73);
                    Rc::new(UH2::UH2_Cons(v451.clone(), v52.clone(), v769.clone(), v692.clone()))
                } else {
                    v692.clone()
                };
                let (mut v772, mut v773): (Rc<str>, Rc<str>) = fix_paths_109(v533.clone(), v52.clone(), v5.clone());
                let v774: bool = file_exists_46(v772.clone());
                let v847: bool = if v774 {
                    true
                } else {
                    let v775: bool = file_exists_46(v773.clone());
                    let v776: bool = v775 == false;
                    if v776 {
                        true
                    } else {
                        let v778: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v778); };
                        let v780: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v781, mut v782, mut v783, mut v784, mut v785, mut v786): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v780);
                        let v787: US1 = v785.borrow().l0.clone();
                        let v792: i32 = match &v787 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v793: bool = v783.borrow().l0;
                        let v794: bool = v793 == false;
                        let v796: bool = if v794 {
                            false
                        } else {
                            let v795: bool = 30i32 >= v792;
                            v795
                        };
                        let v797: bool = v796 == false;
                        let v845: US3 = if v797 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v778); };
                            let (mut v801, mut v802, mut v803, mut v804, mut v805, mut v806): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v780);
                            let v807: Rc<str> = method7(v801.clone(), v802.clone(), v803.clone(), v804.clone(), v805.clone(), v806.clone());
                            let v808: Rc<str> = method9();
                            let v809: Rc<str> = method134(v801.clone(), v802.clone(), v803.clone(), v804.clone(), v805.clone(), v806.clone(), v807.clone(), v808.clone(), v772.clone(), v773.clone());
                            { let _ = spiral_trace_hold(&v778); };
                            let (mut v812, mut v813, mut v814, mut v815, mut v816, mut v817): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v780);
                            let v818: i64 = v812.borrow().l0;
                            let v819: i64 = v818.wrapping_add(1i64);
                            v812.borrow_mut().l0 = v819;
                            let v820: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v821: bool = cfg!(target_arch = "wasm32");
                            if v821 {
                                let v822: Rc<str> = v815.borrow().l0.clone();
                                let v823: bool = &*v822 == "";
                                let v831: Rc<str> = if v823 {
                                    v809.clone()
                                } else {
                                    let v824: bool = &*v809 == "";
                                    if v824 {
                                        let v825: Rc<str> = v815.borrow().l0.clone();
                                        v825.clone()
                                    } else {
                                        let v826: Rc<str> = v815.borrow().l0.clone();
                                        let v827: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v829: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v826, v827)), v809));
                                        v829.clone()
                                    }
                                };
                                let v833: usize = v831.chars().count();
                                let v834: i32 = ((v833) as i32);
                                let v835: i32 = v834.wrapping_add(14999i32);
                                let v836: i32 = v835.wrapping_div(15000i32);
                                let v837: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v838: bool = v809 != v837 ;
                                let v840: bool = if v838 {
                                    let v839: bool = v836 <= 1i32;
                                    v839
                                } else {
                                    false
                                };
                                if v840 {
                                    v815.borrow_mut().l0 = v831.clone();
                                    ()
                                } else {
                                    v815.borrow_mut().l0 = v837.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v831); };
                                    ()
                                }
                            } else {
                                println!("{}", v809);
                                ()
                            };
                            let mut v843: Rc<dyn Fn(Rc<str>) -> ()> = v813.borrow().l0.clone();
                            v843(v809.clone());
                            US3::US3_Some(v812.clone(), v813.clone(), v814.clone(), v815.clone(), v816.clone(), v817.clone())
                        };
                        file_copy_117(v772.clone(), v773.clone());
                        false
                    }
                };
                let v850: Rc<UH2> = if v847 {
                    let v848: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v72);
                    Rc::new(UH2::UH2_Cons(v533.clone(), v52.clone(), v848.clone(), v771.clone()))
                } else {
                    v771.clone()
                };
                let (mut v851, mut v852): (Rc<str>, Rc<str>) = fix_paths_109(v613.clone(), v52.clone(), v5.clone());
                let v853: bool = file_exists_46(v851.clone());
                let v926: bool = if v853 {
                    true
                } else {
                    let v854: bool = file_exists_46(v852.clone());
                    let v855: bool = v854 == false;
                    if v855 {
                        true
                    } else {
                        let v857: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v857); };
                        let v859: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v860, mut v861, mut v862, mut v863, mut v864, mut v865): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v859);
                        let v866: US1 = v864.borrow().l0.clone();
                        let v871: i32 = match &v866 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v872: bool = v862.borrow().l0;
                        let v873: bool = v872 == false;
                        let v875: bool = if v873 {
                            false
                        } else {
                            let v874: bool = 30i32 >= v871;
                            v874
                        };
                        let v876: bool = v875 == false;
                        let v924: US3 = if v876 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v857); };
                            let (mut v880, mut v881, mut v882, mut v883, mut v884, mut v885): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v859);
                            let v886: Rc<str> = method7(v880.clone(), v881.clone(), v882.clone(), v883.clone(), v884.clone(), v885.clone());
                            let v887: Rc<str> = method9();
                            let v888: Rc<str> = method134(v880.clone(), v881.clone(), v882.clone(), v883.clone(), v884.clone(), v885.clone(), v886.clone(), v887.clone(), v851.clone(), v852.clone());
                            { let _ = spiral_trace_hold(&v857); };
                            let (mut v891, mut v892, mut v893, mut v894, mut v895, mut v896): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v859);
                            let v897: i64 = v891.borrow().l0;
                            let v898: i64 = v897.wrapping_add(1i64);
                            v891.borrow_mut().l0 = v898;
                            let v899: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v900: bool = cfg!(target_arch = "wasm32");
                            if v900 {
                                let v901: Rc<str> = v894.borrow().l0.clone();
                                let v902: bool = &*v901 == "";
                                let v910: Rc<str> = if v902 {
                                    v888.clone()
                                } else {
                                    let v903: bool = &*v888 == "";
                                    if v903 {
                                        let v904: Rc<str> = v894.borrow().l0.clone();
                                        v904.clone()
                                    } else {
                                        let v905: Rc<str> = v894.borrow().l0.clone();
                                        let v906: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v908: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v905, v906)), v888));
                                        v908.clone()
                                    }
                                };
                                let v912: usize = v910.chars().count();
                                let v913: i32 = ((v912) as i32);
                                let v914: i32 = v913.wrapping_add(14999i32);
                                let v915: i32 = v914.wrapping_div(15000i32);
                                let v916: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v917: bool = v888 != v916 ;
                                let v919: bool = if v917 {
                                    let v918: bool = v915 <= 1i32;
                                    v918
                                } else {
                                    false
                                };
                                if v919 {
                                    v894.borrow_mut().l0 = v910.clone();
                                    ()
                                } else {
                                    v894.borrow_mut().l0 = v916.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v910); };
                                    ()
                                }
                            } else {
                                println!("{}", v888);
                                ()
                            };
                            let mut v922: Rc<dyn Fn(Rc<str>) -> ()> = v892.borrow().l0.clone();
                            v922(v888.clone());
                            US3::US3_Some(v891.clone(), v892.clone(), v893.clone(), v894.clone(), v895.clone(), v896.clone())
                        };
                        file_copy_117(v851.clone(), v852.clone());
                        false
                    }
                };
                let v929: Rc<UH2> = if v926 {
                    let v927: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure71(v5.clone(), v4.clone(), v71);
                    Rc::new(UH2::UH2_Cons(v613.clone(), v52.clone(), v927.clone(), v850.clone()))
                } else {
                    v850.clone()
                };
                let (mut v930, mut v931): (Rc<str>, Rc<str>) = fix_paths_109(v68.clone(), v52.clone(), v5.clone());
                let v932: bool = file_exists_46(v930.clone());
                let v1005: bool = if v932 {
                    true
                } else {
                    let v933: bool = file_exists_46(v931.clone());
                    let v934: bool = v933 == false;
                    if v934 {
                        true
                    } else {
                        let v936: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v936); };
                        let v938: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v939, mut v940, mut v941, mut v942, mut v943, mut v944): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v938);
                        let v945: US1 = v943.borrow().l0.clone();
                        let v950: i32 = match &v945 {
                            US1::US1_Critical => {
                                50i32
                            }
                            US1::US1_Debug => {
                                20i32
                            }
                            US1::US1_Info => {
                                30i32
                            }
                            US1::US1_Verbose => {
                                10i32
                            }
                            US1::US1_Warning => {
                                40i32
                            }
                        };
                        let v951: bool = v941.borrow().l0;
                        let v952: bool = v951 == false;
                        let v954: bool = if v952 {
                            false
                        } else {
                            let v953: bool = 30i32 >= v950;
                            v953
                        };
                        let v955: bool = v954 == false;
                        let v1003: US3 = if v955 {
                            US3::US3_None
                        } else {
                            { let _ = spiral_trace_hold(&v936); };
                            let (mut v959, mut v960, mut v961, mut v962, mut v963, mut v964): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v938);
                            let v965: Rc<str> = method7(v959.clone(), v960.clone(), v961.clone(), v962.clone(), v963.clone(), v964.clone());
                            let v966: Rc<str> = method9();
                            let v967: Rc<str> = method134(v959.clone(), v960.clone(), v961.clone(), v962.clone(), v963.clone(), v964.clone(), v965.clone(), v966.clone(), v930.clone(), v931.clone());
                            { let _ = spiral_trace_hold(&v936); };
                            let (mut v970, mut v971, mut v972, mut v973, mut v974, mut v975): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v938);
                            let v976: i64 = v970.borrow().l0;
                            let v977: i64 = v976.wrapping_add(1i64);
                            v970.borrow_mut().l0 = v977;
                            let v978: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                            let v979: bool = cfg!(target_arch = "wasm32");
                            if v979 {
                                let v980: Rc<str> = v973.borrow().l0.clone();
                                let v981: bool = &*v980 == "";
                                let v989: Rc<str> = if v981 {
                                    v967.clone()
                                } else {
                                    let v982: bool = &*v967 == "";
                                    if v982 {
                                        let v983: Rc<str> = v973.borrow().l0.clone();
                                        v983.clone()
                                    } else {
                                        let v984: Rc<str> = v973.borrow().l0.clone();
                                        let v985: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v987: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v984, v985)), v967));
                                        v987.clone()
                                    }
                                };
                                let v991: usize = v989.chars().count();
                                let v992: i32 = ((v991) as i32);
                                let v993: i32 = v992.wrapping_add(14999i32);
                                let v994: i32 = v993.wrapping_div(15000i32);
                                let v995: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v996: bool = v967 != v995 ;
                                let v998: bool = if v996 {
                                    let v997: bool = v994 <= 1i32;
                                    v997
                                } else {
                                    false
                                };
                                if v998 {
                                    v973.borrow_mut().l0 = v989.clone();
                                    ()
                                } else {
                                    v973.borrow_mut().l0 = v995.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v989); };
                                    ()
                                }
                            } else {
                                println!("{}", v967);
                                ()
                            };
                            let mut v1001: Rc<dyn Fn(Rc<str>) -> ()> = v971.borrow().l0.clone();
                            v1001(v967.clone());
                            US3::US3_Some(v970.clone(), v971.clone(), v972.clone(), v973.clone(), v974.clone(), v975.clone())
                        };
                        file_copy_117(v930.clone(), v931.clone());
                        false
                    }
                };
                let v1010: Rc<UH2> = if v1005 {
                    let v1006: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US26>> = closure68(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                    let v1007: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                    Rc::new(UH2::UH2_Cons(v68.clone(), v52.clone(), v1006.clone(), v1007.clone()))
                } else {
                    { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) }
                };
                let v1011: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
                let v1012: Rc<UH1> = Rc::new(UH1::UH1_Cons(v929.clone(), v1011.clone()));
                Rc::new(UH1::UH1_Cons(v1010.clone(), v1012.clone()))
            };
            let v1015: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new(Vec::new()));
            let v1016: i32 = 0i32;
            let v1017: i32 = method135(v1015.clone(), v1014.clone(), v1016);
            let v1018: Rc<Vec<Rc<UH2>>> = Rc::new(v1015.borrow().clone());
            let v1019: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new((v1018).as_ref().clone()));
            let v1020: Vec<Rc<UH2>> = (v1019).borrow().clone();
            let v1021: Rc<RefCell<Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>>> = Rc::new(RefCell::new(vec![]));
            let v1022: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = (v1021).borrow().clone();
            let v1023: Vec<Rc<UH2>> = method136(v1020.clone());
            let v1024: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new(v1023));
            let v1025: Rc<Vec<Rc<UH2>>> = Rc::new((v1024).borrow().clone());
            let v1026: usize = (v1025).len();
            let v1027: i32 = ((v1026) as i32);
            let v1028: i32 = v1027.wrapping_sub(1i32);
            let v1029: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
            let v1030: Rc<UH1> = method137(v1025.clone(), v1028, v1029.clone());
            let v1031: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method138(v1030.clone(), v1022.clone());
            let (mut v1032, mut v1033): (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) = method147(v34.clone(), v1031.clone());
            let v1034: (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) = (v1032, v1033);
            let v1035: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> = Ok::<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>(v1034);
            let v1036: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> = method148(v1035.clone());
            let mut v1037: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = method149(v9.clone());
            let v1039: bool = true; let mut v1037 = v1037;
            let v1041: bool = true; v1037.push(v1036);
            let v1043: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = v1037;
            (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0, v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone(), v7, v11, v1043.clone());
            continue;
        } else {
            return v9.clone();
        }
    }
}
fn method150(mut v0: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> {
    v0
}
fn run_27(mut v0: bool, mut v1: US0, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>, mut v5: Rc<str>) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> {
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("SPIRAL_REPO_ROOT"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = get_environment_variable_5(v6);
    let mut v8: bool = &*v7 != "";
    let v40: Rc<str> = if v8 {
        normalize_path_28(v7)
    } else {
        let mut v10: Rc<str> = get_current_directory_42();
        let mut v11: US0 = run_43(v10);
        let mut v17: US0 = match &v11 {
            US0::US0_None => {
                let mut v14: Rc<str> = Rc::<str>::from(env!("CARGO_MANIFEST_DIR"));
                run_43(v14)
            }
            US0::US0_Some(v12) => {
                let mut v12: Rc<str> = v12.clone();
                US0::US0_Some(v12)
            }
        };
        let v23: US0 = match &v17 {
            US0::US0_None => {
                let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/workspaces"); } LIT.with(|lit| lit.clone()) };
                run_43(v20)
            }
            US0::US0_Some(v18) => {
                let v18: Rc<str> = v18.clone();
                US0::US0_Some(v18)
            }
        };
        let mut v27: Rc<str> = match &v23 {
            US0::US0_None => {
                std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
            }
            US0::US0_Some(v24) => {
                let v24: Rc<str> = v24.clone();
                v24
            }
        };
        let mut v28: Rc<str> = get_file_name_32(v27.clone());
        let mut v29: bool = "deps" == &*v28;
        let v37: Rc<str> = if v29 {
            let v30: Option<Rc<str>> = directory_get_parent_34(v27.clone());
            let mut v31: Rc<str> = v30.unwrap();
            let mut v32: US0 = run_43(v31);
            match &v32 {
                US0::US0_None => {
                    std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
                }
                US0::US0_Some(v33) => {
                    let mut v33: Rc<str> = v33.clone();
                    v33
                }
            }
        } else {
            v27
        };
        let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("spiral"); } LIT.with(|lit| lit.clone()) };
        method39(v37, v38)
    };
    let v41: Rc<str> = get_full_path_49(v5);
    let v42: Rc<str> = get_full_path_49(v4);
    let v43: Rc<str> = get_full_path_49(v3);
    let mut v45: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    { let _ = spiral_trace_hold(&v45); };
    let mut v47: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v47);
    let v54: US1 = v52.borrow().l0.clone();
    let mut v59: i32 = match &v54 {
        US1::US1_Critical => {
            50i32
        }
        US1::US1_Debug => {
            20i32
        }
        US1::US1_Info => {
            30i32
        }
        US1::US1_Verbose => {
            10i32
        }
        US1::US1_Warning => {
            40i32
        }
    };
    let v60: bool = v50.borrow().l0;
    let v61: bool = v60 == false;
    let mut v63: bool = if v61 {
        false
    } else {
        let v62: bool = 20i32 >= v59;
        v62
    };
    let v64: bool = v63 == false;
    let mut v112: US3 = if v64 {
        US3::US3_None
    } else {
        { let _ = spiral_trace_hold(&v45); };
        let (mut v68, mut v69, mut v70, mut v71, mut v72, mut v73): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v47);
        let v74: Rc<str> = method7(v68.clone(), v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone());
        let mut v75: Rc<str> = method53();
        let mut v76: Rc<str> = method54(v68, v69, v70, v71, v72, v73, v74, v75, v41.clone(), v42.clone(), v43.clone(), v2.clone(), v1.clone(), v0);
        { let _ = spiral_trace_hold(&v45); };
        let (mut v79, mut v80, mut v81, mut v82, mut v83, mut v84): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v47);
        let mut v85: i64 = v79.borrow().l0;
        let mut v86: i64 = v85.wrapping_add(1i64);
        v79.borrow_mut().l0 = v86;
        let mut v87: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
        let mut v88: bool = cfg!(target_arch = "wasm32");
        if v88 {
            let v89: Rc<str> = v82.borrow().l0.clone();
            let v90: bool = &*v89 == "";
            let mut v98: Rc<str> = if v90 {
                v76.clone()
            } else {
                let v91: bool = &*v76 == "";
                if v91 {
                    let v92: Rc<str> = v82.borrow().l0.clone();
                    v92
                } else {
                    let mut v93: Rc<str> = v82.borrow().l0.clone();
                    let v94: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v96: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v93, v94)), v76));
                    v96
                }
            };
            let v100: usize = v98.chars().count();
            let v101: i32 = ((v100) as i32);
            let mut v102: i32 = v101.wrapping_add(14999i32);
            let v103: i32 = v102.wrapping_div(15000i32);
            let mut v104: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v105: bool = v76 != v104 ;
            let v107: bool = if v105 {
                let v106: bool = v103 <= 1i32;
                v106
            } else {
                false
            };
            if v107 {
                v82.borrow_mut().l0 = v98.clone();
                ()
            } else {
                v82.borrow_mut().l0 = v104;
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v98); };
                ()
            }
        } else {
            println!("{}", v76);
            ()
        };
        let mut v110: Rc<dyn Fn(Rc<str>) -> ()> = v80.borrow().l0.clone();
        v110(v76);
        US3::US3_Some(v79, v80, v81, v82, v83, v84)
    };
    let v114: bool = true; let __future_init = Box::pin(/*;
    let mut v116: bool = */ async move { /*;
    let v118: bool = */ ();
    let mut v119: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let v120: Rc<UH0> = Rc::new(UH0::UH0_Cons(v42.clone(), v119));
    let mut v121: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let mut v122: Rc<UH0> = walk_57(v1, v120, v121);
    let v123: Vec<Rc<str>> = Vec::new();
    let mut v124: Vec<Rc<str>> = method60(v122, v123);
    { let _ = spiral_trace_hold(&v45); };
    let (mut v127, mut v128, mut v129, mut v130, mut v131, mut v132): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v47);
    let v133: US1 = v131.borrow().l0.clone();
    let v138: i32 = match &v133 {
        US1::US1_Critical => {
            50i32
        }
        US1::US1_Debug => {
            20i32
        }
        US1::US1_Info => {
            30i32
        }
        US1::US1_Verbose => {
            10i32
        }
        US1::US1_Warning => {
            40i32
        }
    };
    let mut v139: bool = v129.borrow().l0;
    let v140: bool = v139 == false;
    let v142: bool = if v140 {
        false
    } else {
        let v141: bool = 20i32 >= v138;
        v141
    };
    let v143: bool = v142 == false;
    let v192: US3 = if v143 {
        US3::US3_None
    } else {
        { let _ = spiral_trace_hold(&v45); };
        let (mut v147, mut v148, mut v149, mut v150, mut v151, mut v152): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v47);
        let v153: Rc<str> = method7(v147.clone(), v148.clone(), v149.clone(), v150.clone(), v151.clone(), v152.clone());
        let v154: Rc<str> = method53();
        let mut v155: usize = ((v124).len() as usize);
        let v156: Rc<str> = method63(v147, v148, v149, v150, v151, v152, v153, v154, v155);
        { let _ = spiral_trace_hold(&v45); };
        let (mut v159, mut v160, mut v161, mut v162, mut v163, mut v164): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v47);
        let mut v165: i64 = v159.borrow().l0;
        let mut v166: i64 = v165.wrapping_add(1i64);
        v159.borrow_mut().l0 = v166;
        let mut v167: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
        let mut v168: bool = cfg!(target_arch = "wasm32");
        if v168 {
            let v169: Rc<str> = v162.borrow().l0.clone();
            let v170: bool = &*v169 == "";
            let mut v178: Rc<str> = if v170 {
                v156.clone()
            } else {
                let v171: bool = &*v156 == "";
                if v171 {
                    let mut v172: Rc<str> = v162.borrow().l0.clone();
                    v172
                } else {
                    let v173: Rc<str> = v162.borrow().l0.clone();
                    let v174: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v176: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v173, v174)), v156));
                    v176
                }
            };
            let v180: usize = v178.chars().count();
            let mut v181: i32 = ((v180) as i32);
            let mut v182: i32 = v181.wrapping_add(14999i32);
            let mut v183: i32 = v182.wrapping_div(15000i32);
            let v184: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v185: bool = v156 != v184 ;
            let v187: bool = if v185 {
                let v186: bool = v183 <= 1i32;
                v186
            } else {
                false
            };
            if v187 {
                v162.borrow_mut().l0 = v178.clone();
                ()
            } else {
                v162.borrow_mut().l0 = v184;
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v178); };
                ()
            }
        } else {
            println!("{}", v156);
            ()
        };
        let mut v190: Rc<dyn Fn(Rc<str>) -> ()> = v160.borrow().l0.clone();
        v190(v156);
        US3::US3_Some(v159, v160, v161, v162, v163, v164)
    };
    let v193: Vec<Rc<str>> = method64(v124);
    let v194: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v193));
    let v195: i32 = (v194.borrow().len() as i32);
    let v196: i32 = 0i32;
    let v197: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = Vec::new();
    let v198: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = loop_65(v0, v2, v40, v41, v42, v43, v194, v195, v196, v197);
    let v199: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = method150(v198);
    let v200: Rc<RefCell<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>>> = Rc::new(RefCell::new(v199));
    let mut v201: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = (v200).borrow().clone();
    let v202: Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String> = Ok::<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>(v201);
    let v203: bool = true; (v202) }); //;
    let v205: _ = __future_init;
    let v207: std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> = v205;
    v207
}
fn ok_c73() -> Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US30> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US30> = Rc::new(move |mut v0: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>| -> US30 {
        US30::US30_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method151() -> Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US30> {
    ok_c73()
}
fn error_c74() -> Rc<dyn Fn(std::string::String) -> US30> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US30> = Rc::new(move |mut v0: std::string::String| -> US30 {
        US30::US30_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method152() -> Rc<dyn Fn(std::string::String) -> US30> {
    error_c74()
}
fn method153(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: std::string::String) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0;
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_16(v9);
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v11, v12)), v7)), v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.main"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v8)).s() });
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v27));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", v29, v30))));
    method13(v32)
}
fn method154(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: usize) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0;
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_16(v9);
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v11, v12)), v7)), v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.main"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result_len"); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result_len"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result_len = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<usize>") } } (&&W(&v8)).s() });
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v27));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", v29, v30))));
    method13(v32)
}
fn spiral_main() -> i32 {
    let mut v0: i32 = 0i32;
    let mut v1: Rc<UH0> = arguments_from_0(v0);
    let mut v2: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::new()));
    let mut v3: i32 = 0i32;
    let mut v4: i32 = method3(v2.clone(), v1.clone(), v3);
    let mut v5: Rc<Vec<Rc<str>>> = Rc::new(v2.borrow().clone());
    let mut v6: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new((v5).as_ref().clone()));
    let mut v8: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
    { let _ = spiral_trace_hold(&v8); };
    let mut v10: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    { let _ = spiral_trace_hold(&v10); };
    let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
    let (mut v13, mut v14, mut v15, mut v16, mut v17, mut v18): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
    let v19: US1 = v17.borrow().l0.clone();
    let v24: i32 = match &v19 {
        US1::US1_Critical => {
            50i32
        }
        US1::US1_Debug => {
            20i32
        }
        US1::US1_Info => {
            30i32
        }
        US1::US1_Verbose => {
            10i32
        }
        US1::US1_Warning => {
            40i32
        }
    };
    let mut v25: bool = v15.borrow().l0;
    let mut v26: bool = v25 == false;
    let mut v28: bool = if v26 {
        false
    } else {
        let mut v27: bool = 30i32 >= v24;
        v27
    };
    let mut v29: bool = v28 == false;
    let mut v77: US3 = if v29 {
        US3::US3_None
    } else {
        { let _ = spiral_trace_hold(&v10); };
        let (mut v33, mut v34, mut v35, mut v36, mut v37, mut v38): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
        let v39: Rc<str> = method7(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone());
        let v40: Rc<str> = method9();
        let v41: Rc<str> = method12(v33.clone(), v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v6.clone());
        { let _ = spiral_trace_hold(&v10); };
        let (mut v44, mut v45, mut v46, mut v47, mut v48, mut v49): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
        let v50: i64 = v44.borrow().l0;
        let v51: i64 = v50.wrapping_add(1i64);
        v44.borrow_mut().l0 = v51;
        let mut v52: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
        let v53: bool = cfg!(target_arch = "wasm32");
        if v53 {
            let v54: Rc<str> = v47.borrow().l0.clone();
            let v55: bool = &*v54 == "";
            let mut v63: Rc<str> = if v55 {
                v41.clone()
            } else {
                let v56: bool = &*v41 == "";
                if v56 {
                    let mut v57: Rc<str> = v47.borrow().l0.clone();
                    v57.clone()
                } else {
                    let v58: Rc<str> = v47.borrow().l0.clone();
                    let mut v59: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v61: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v58, v59)), v41));
                    v61.clone()
                }
            };
            let mut v65: usize = v63.chars().count();
            let v66: i32 = ((v65) as i32);
            let v67: i32 = v66.wrapping_add(14999i32);
            let mut v68: i32 = v67.wrapping_div(15000i32);
            let v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v70: bool = v41 != v69 ;
            let v72: bool = if v70 {
                let v71: bool = v68 <= 1i32;
                v71
            } else {
                false
            };
            if v72 {
                v47.borrow_mut().l0 = v63.clone();
                ()
            } else {
                v47.borrow_mut().l0 = v69.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v63); };
                ()
            }
        } else {
            println!("{}", v41);
            ()
        };
        let mut v75: Rc<dyn Fn(Rc<str>) -> ()> = v45.borrow().l0.clone();
        v75(v41.clone());
        US3::US3_Some(v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone())
    };
    let v78: clap::Command = get_command_19();
    let mut v80: clap::ArgMatches = clap::Command::get_matches(v78);
    let mut v81: Rc<str> = method20();
    let mut v83: &str = &*v81;
    let mut v85: Option<std::string::String> = clap::ArgMatches::get_one(&v80, v83).cloned();
    let mut v86: Option<std::string::String> = method21(v85.clone());
    let mut v87: Rc<dyn Fn((std::string::String)) -> US5> = closure6();
    let mut v88: Option<US5> = v86.map(|x| v87(x));
    let v90: US5 = US5::US5_None;
    let v91: US5 = v90.clone();
    let v92: US5 = v88.unwrap_or(v91);
    let v96: std::string::String = match &v92 {
        US5::US5_None => {
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US5::US5_Some(v93) => {
            let mut v93: std::string::String = v93.clone();
            v93.clone()
        }
    };
    let mut v98: Rc<str> = Rc::<str>::from(String::as_str(&v96));
    let v99: Rc<str> = method22();
    let v101: &str = &*v99;
    let v103: Option<std::string::String> = clap::ArgMatches::get_one(&v80, v101).cloned();
    let mut v104: Option<std::string::String> = method21(v103.clone());
    let mut v105: Option<US5> = v104.map(|x| v87(x));
    let v107: US5 = US5::US5_None;
    let mut v108: US5 = v107.clone();
    let mut v109: US5 = v105.unwrap_or(v108);
    let mut v113: std::string::String = match &v109 {
        US5::US5_None => {
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US5::US5_Some(v110) => {
            let mut v110: std::string::String = v110.clone();
            v110.clone()
        }
    };
    let mut v115: Rc<str> = Rc::<str>::from(String::as_str(&v113));
    let mut v116: Rc<str> = method23();
    let v118: &str = &*v116;
    let v120: Option<std::string::String> = clap::ArgMatches::get_one(&v80, v118).cloned();
    let mut v121: Option<std::string::String> = method21(v120.clone());
    let mut v122: Option<US5> = v121.map(|x| v87(x));
    let mut v124: US5 = US5::US5_None;
    let v125: US5 = v124.clone();
    let v126: US5 = v122.unwrap_or(v125);
    let mut v130: std::string::String = match &v126 {
        US5::US5_None => {
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US5::US5_Some(v127) => {
            let mut v127: std::string::String = v127.clone();
            v127.clone()
        }
    };
    let v132: Rc<str> = Rc::<str>::from(String::as_str(&v130));
    let v133: Rc<str> = method24();
    let v135: &str = &*v133;
    let v137: Option<std::string::String> = clap::ArgMatches::get_one(&v80, v135).cloned();
    let v138: Option<std::string::String> = method21(v137.clone());
    let mut v139: Option<US5> = v138.map(|x| v87(x));
    let v141: US5 = US5::US5_None;
    let v142: US5 = v141.clone();
    let v143: US5 = v139.unwrap_or(v142);
    let mut v150: US0 = match &v143 {
        US5::US5_None => {
            US0::US0_None
        }
        US5::US5_Some(v144) => {
            let v144: std::string::String = v144.clone();
            let v146: Rc<str> = Rc::<str>::from(String::as_str(&v144));
            US0::US0_Some(v146.clone())
        }
    };
    let v154: Rc<str> = match &v150 {
        US0::US0_None => {
            let mut v152: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("por-br"); } LIT.with(|lit| lit.clone()) };
            v152.clone()
        }
        US0::US0_Some(v151) => {
            let mut v151: Rc<str> = v151.clone();
            v151.clone()
        }
    };
    let mut v155: Rc<str> = method25();
    let v157: &str = &*v155;
    let mut v159: Option<std::string::String> = clap::ArgMatches::get_one(&v80, v157).cloned();
    let v160: Option<std::string::String> = method21(v159.clone());
    let mut v161: Option<US5> = v160.map(|x| v87(x));
    let mut v163: US5 = US5::US5_None;
    let mut v164: US5 = v163.clone();
    let mut v165: US5 = v161.unwrap_or(v164);
    let mut v172: US0 = match &v165 {
        US5::US5_None => {
            US0::US0_None
        }
        US5::US5_Some(v166) => {
            let mut v166: std::string::String = v166.clone();
            let mut v168: Rc<str> = Rc::<str>::from(String::as_str(&v166));
            US0::US0_Some(v168.clone())
        }
    };
    let v173: Rc<str> = method26();
    let mut v175: &str = &*v173;
    let v177: bool = clap::ArgMatches::get_flag(&v80, v175);
    let mut v178: std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> = run_27(v177, v172.clone(), v154.clone(), v132.clone(), v115.clone(), v98.clone());
    let v180: Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String> = futures::executor::block_on(v178);
    let mut v181: Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US30> = method151();
    let mut v182: Rc<dyn Fn(std::string::String) -> US30> = method152();
    let mut v183: US30 = match v180 { Ok(x) => v181(x), Err(e) => v182(e) };
    let mut v322: i32 = match &v183 {
        US30::US30_Error(v253) => {
            let v253: std::string::String = v253.clone();
            { let _ = spiral_trace_hold(&v10); };
            let (mut v256, mut v257, mut v258, mut v259, mut v260, mut v261): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
            let mut v262: US1 = v260.borrow().l0.clone();
            let v267: i32 = match &v262 {
                US1::US1_Critical => {
                    50i32
                }
                US1::US1_Debug => {
                    20i32
                }
                US1::US1_Info => {
                    30i32
                }
                US1::US1_Verbose => {
                    10i32
                }
                US1::US1_Warning => {
                    40i32
                }
            };
            let v268: bool = v258.borrow().l0;
            let v269: bool = v268 == false;
            let v271: bool = if v269 {
                false
            } else {
                let v270: bool = 50i32 >= v267;
                v270
            };
            let v272: bool = v271 == false;
            let v320: US3 = if v272 {
                US3::US3_None
            } else {
                { let _ = spiral_trace_hold(&v10); };
                let (mut v276, mut v277, mut v278, mut v279, mut v280, mut v281): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
                let v282: Rc<str> = method7(v276.clone(), v277.clone(), v278.clone(), v279.clone(), v280.clone(), v281.clone());
                let v283: Rc<str> = method98();
                let v284: Rc<str> = method153(v276.clone(), v277.clone(), v278.clone(), v279.clone(), v280.clone(), v281.clone(), v282.clone(), v283.clone(), v253.clone());
                { let _ = spiral_trace_hold(&v10); };
                let (mut v287, mut v288, mut v289, mut v290, mut v291, mut v292): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
                let v293: i64 = v287.borrow().l0;
                let mut v294: i64 = v293.wrapping_add(1i64);
                v287.borrow_mut().l0 = v294;
                let v295: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v296: bool = cfg!(target_arch = "wasm32");
                if v296 {
                    let v297: Rc<str> = v290.borrow().l0.clone();
                    let v298: bool = &*v297 == "";
                    let v306: Rc<str> = if v298 {
                        v284.clone()
                    } else {
                        let v299: bool = &*v284 == "";
                        if v299 {
                            let v300: Rc<str> = v290.borrow().l0.clone();
                            v300.clone()
                        } else {
                            let v301: Rc<str> = v290.borrow().l0.clone();
                            let v302: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v304: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v301, v302)), v284));
                            v304.clone()
                        }
                    };
                    let v308: usize = v306.chars().count();
                    let v309: i32 = ((v308) as i32);
                    let v310: i32 = v309.wrapping_add(14999i32);
                    let v311: i32 = v310.wrapping_div(15000i32);
                    let v312: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v313: bool = v284 != v312 ;
                    let v315: bool = if v313 {
                        let v314: bool = v311 <= 1i32;
                        v314
                    } else {
                        false
                    };
                    if v315 {
                        v290.borrow_mut().l0 = v306.clone();
                        ()
                    } else {
                        v290.borrow_mut().l0 = v312.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v306); };
                        ()
                    }
                } else {
                    println!("{}", v284);
                    ()
                };
                let mut v318: Rc<dyn Fn(Rc<str>) -> ()> = v288.borrow().l0.clone();
                v318(v284.clone());
                US3::US3_Some(v287.clone(), v288.clone(), v289.clone(), v290.clone(), v291.clone(), v292.clone())
            };
            1i32
        }
        US30::US30_Ok(v184) => {
            let v184: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = v184.clone();
            { let _ = spiral_trace_hold(&v10); };
            let (mut v187, mut v188, mut v189, mut v190, mut v191, mut v192): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
            let v193: US1 = v191.borrow().l0.clone();
            let v198: i32 = match &v193 {
                US1::US1_Critical => {
                    50i32
                }
                US1::US1_Debug => {
                    20i32
                }
                US1::US1_Info => {
                    30i32
                }
                US1::US1_Verbose => {
                    10i32
                }
                US1::US1_Warning => {
                    40i32
                }
            };
            let v199: bool = v189.borrow().l0;
            let v200: bool = v199 == false;
            let v202: bool = if v200 {
                false
            } else {
                let mut v201: bool = 30i32 >= v198;
                v201
            };
            let v203: bool = v202 == false;
            let v252: US3 = if v203 {
                US3::US3_None
            } else {
                { let _ = spiral_trace_hold(&v10); };
                let (mut v207, mut v208, mut v209, mut v210, mut v211, mut v212): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
                let v213: Rc<str> = method7(v207.clone(), v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone());
                let v214: Rc<str> = method9();
                let v215: usize = ((v184).len() as usize);
                let v216: Rc<str> = method154(v207.clone(), v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone(), v213.clone(), v214.clone(), v215.clone());
                { let _ = spiral_trace_hold(&v10); };
                let (mut v219, mut v220, mut v221, mut v222, mut v223, mut v224): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = spiral_trace_hold(&v12);
                let v225: i64 = v219.borrow().l0;
                let v226: i64 = v225.wrapping_add(1i64);
                v219.borrow_mut().l0 = v226;
                let mut v227: Rc<dyn Fn(Rc<str>) -> ()> = closure5();
                let v228: bool = cfg!(target_arch = "wasm32");
                if v228 {
                    let v229: Rc<str> = v222.borrow().l0.clone();
                    let mut v230: bool = &*v229 == "";
                    let v238: Rc<str> = if v230 {
                        v216.clone()
                    } else {
                        let mut v231: bool = &*v216 == "";
                        if v231 {
                            let mut v232: Rc<str> = v222.borrow().l0.clone();
                            v232.clone()
                        } else {
                            let v233: Rc<str> = v222.borrow().l0.clone();
                            let v234: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v236: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v233, v234)), v216));
                            v236.clone()
                        }
                    };
                    let v240: usize = v238.chars().count();
                    let v241: i32 = ((v240) as i32);
                    let v242: i32 = v241.wrapping_add(14999i32);
                    let v243: i32 = v242.wrapping_div(15000i32);
                    let v244: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v245: bool = v216 != v244 ;
                    let v247: bool = if v245 {
                        let v246: bool = v243 <= 1i32;
                        v246
                    } else {
                        false
                    };
                    if v247 {
                        v222.borrow_mut().l0 = v238.clone();
                        ()
                    } else {
                        v222.borrow_mut().l0 = v244.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v238); };
                        ()
                    }
                } else {
                    println!("{}", v216);
                    ()
                };
                let mut v250: Rc<dyn Fn(Rc<str>) -> ()> = v220.borrow().l0.clone();
                v250(v216.clone());
                US3::US3_Some(v219.clone(), v220.clone(), v221.clone(), v222.clone(), v223.clone(), v224.clone())
            };
            0i32
        }
    };
    let v323: bool = v322 != 0i32;
    if v323 {
        std::process::exit(v322);
        ()
    }
    0
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 1 });
}
