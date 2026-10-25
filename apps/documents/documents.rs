#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)] #![recursion_limit = "512"]
use std::cell::RefCell;
use std::rc::Rc;
fn spiral_trace_hold<T: Clone>(fresh: &std::rc::Rc<dyn Fn() -> T>) -> T {
    use std::sync::OnceLock;
    static SLOT: OnceLock<usize> = OnceLock::new();
    let raw = *SLOT.get_or_init(|| Box::into_raw(Box::new((*fresh)())) as usize);
    unsafe { (*(raw as *const T)).clone() }
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
struct Mut0 { l0: i64 }
struct Mut1 { l0: Rc<dyn Fn(Rc<str>) -> ()> }
struct Mut2 { l0: bool }
struct Mut3 { l0: Rc<str> }
#[derive(Clone)]
enum US0 {
    US0_Verbose,
    US0_Debug,
    US0_Info,
    US0_Warning,
    US0_Critical,
}
struct Mut4 { l0: US0 }
#[derive(Clone)]
enum US1 {
    US1_Some(US0),
    US1_None,
}
struct Mut5 { l0: i32, l1: US1 }
#[derive(Clone)]
enum US2 {
    US2_Some(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US2_None,
}
struct Mut6 { l0: u64 }
#[derive(Clone)]
enum US3 {
    US3_Some(std::string::String),
    US3_None,
}
#[derive(Clone)]
enum US4 {
    US4_Some(Rc<str>),
    US4_None,
}
#[derive(Clone)]
enum US5 {
    US5_Ok(std::path::PathBuf),
    US5_Error(Rc<str>),
}
#[derive(Clone)]
enum US6 {
    US6_Some(std::path::PathBuf),
    US6_None,
}
#[derive(Clone)]
enum US7 {
    US7_File,
    US7_Directory,
}
#[derive(Clone)]
enum US8 {
    US8_Ok(Rc<str>),
    US8_Error(Rc<str>),
}
struct Mut7 { l0: i32, l1: i32, l2: Rc<RefCell<Vec<Rc<str>>>> }
struct Mut8 { l0: i32 }
#[derive(Clone)]
enum US9 {
    US9_Ok(Rc<str>, US4),
    US9_Error(Rc<str>),
}
#[derive(Clone)]
enum US10 {
    US10_Ok(u8, i32, i32, i32, i32, i32),
    US10_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US11 {
    US11_Ok(Rc<str>, i32, i32, i32, i32, i32),
    US11_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US12 {
    US12_Ok(i32, i32, i32, i32, i32),
    US12_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US14 {
    US14_Some(Rc<dyn Fn() -> Rc<str>>),
    US14_None,
}
#[derive(Clone)]
enum US13 {
    US13_Ok(Rc<dyn Fn() -> Rc<str>>, Rc<dyn Fn() -> US14>, i32, i32, i32, i32, i32),
    US13_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US15 {
    US15_Ok(US14, i32, i32, i32, i32, i32),
    US15_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US16 {
    US16_Ok(Rc<dyn Fn() -> Rc<str>>, Rc<dyn Fn() -> US14>, Rc<str>, i32, i32, i32, i32),
    US16_Error(Rc<dyn Fn() -> Rc<str>>),
}
#[derive(Clone)]
enum US17 {
    US17_Ok(Rc<str>, US4),
    US17_Error(Rc<dyn Fn() -> Rc<str>>),
}
#[derive(Clone)]
enum US18 {
    US18_Ok(Rc<RefCell<Vec<Rc<str>>>>),
    US18_Error(Rc<str>),
}
#[derive(Clone)]
enum UH0 {
    UH0_Nil,
    UH0_Cons(Rc<str>, Rc<UH0>),
}
#[derive(Clone)]
enum US19 {
    US19_Ok(Rc<UH0>, i32, i32, i32, i32, i32),
    US19_Error(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
#[derive(Clone)]
enum US20 {
    US20_Ok(Rc<UH0>, Rc<str>, i32, i32, i32, i32),
    US20_Error(Rc<dyn Fn() -> Rc<str>>),
}
#[derive(Clone)]
enum US21 {
    US21_Ok(Rc<RefCell<Vec<Rc<str>>>>),
    US21_Error(Rc<dyn Fn() -> Rc<str>>),
}
#[derive(Clone)]
enum US22 {
    US22_Ok(std::string::String),
    US22_Error(std::string::String),
}
#[derive(Clone)]
enum US23 {
    US23_Some(i32),
    US23_None,
}
#[derive(Clone)]
enum US24 {
    US24_Some(Result<Rc<str>, (Rc<str>, Rc<str>)>),
    US24_None,
}
#[derive(Clone)]
enum UH2 {
    UH2_Nil,
    UH2_Cons(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>, Rc<UH2>),
}
#[derive(Clone)]
enum UH1 {
    UH1_Nil,
    UH1_Cons(Rc<UH2>, Rc<UH1>),
}
#[derive(Clone)]
enum US25 {
    US25_Ok(Rc<str>),
    US25_Error(std::string::String),
}
#[derive(Clone)]
enum US26 {
    US26_Ok(u64),
    US26_Error(std::string::String),
}
#[derive(Clone)]
enum US27 {
    US27_Ok(i32, Rc<str>),
    US27_Error(i32, Rc<str>),
}
struct Mut9 { l0: i32, l1: i32 }
struct Mut10 { l0: i32, l1: Rc<str>, l2: i32, l3: i32, l4: bool }
#[derive(Clone)]
enum US28 {
    US28_Ok(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>),
    US28_Error(std::string::String),
}
fn get_environment_variable_1(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = Rc::<str>::from(std::env::var(&*v0).unwrap_or_default());
    v1
}
fn method2(mut v0: Rc<RefCell<Mut5>>) -> bool {
    let mut v1: i32 = v0.borrow().l0.clone();
    let mut v2: bool = v1 > 0i32;
    v2
}
fn closure1() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn new_trace_state_0(mut v0: US0) -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("TRACE_LEVEL"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = get_environment_variable_1(v1.clone());
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
    let mut v13: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new(Vec::new()));
    let mut v14: US0 = US0::US0_Verbose;
    v13.borrow_mut().push((v11.clone(), v14.clone()));
    let v15: US0 = US0::US0_Debug;
    v13.borrow_mut().push((v9.clone(), v15.clone()));
    let mut v16: US0 = US0::US0_Info;
    v13.borrow_mut().push((v7.clone(), v16.clone()));
    let mut v17: US0 = US0::US0_Warning;
    v13.borrow_mut().push((v5.clone(), v17.clone()));
    let v18: US0 = US0::US0_Critical;
    v13.borrow_mut().push((v3.clone(), v18.clone()));
    let v19: US0 = US0::US0_Verbose;
    v13.borrow_mut().push((v12.clone(), v19.clone()));
    let mut v20: US0 = US0::US0_Debug;
    v13.borrow_mut().push((v10.clone(), v20.clone()));
    let v21: US0 = US0::US0_Info;
    v13.borrow_mut().push((v8.clone(), v21.clone()));
    let mut v22: US0 = US0::US0_Warning;
    v13.borrow_mut().push((v6.clone(), v22.clone()));
    let v23: US0 = US0::US0_Critical;
    v13.borrow_mut().push((v4.clone(), v23.clone()));
    let v24: Rc<Vec<(Rc<str>, US0)>> = Rc::new(v13.borrow().clone());
    let mut v25: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
    let mut v26: i32 = (v25.clone().borrow().len() as i32);
    let mut v27: US1 = US1::US1_None;
    let mut v28: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: v26, l1: v27.clone() }));
    while method2(v28.clone()) {
        let v30: i32 = v28.borrow().l0.clone();
        let mut v31: i32 = v30.wrapping_sub(1i32);
        let mut v32: US1 = v28.borrow().l1.clone();
        let (mut v33, mut v34): (Rc<str>, US0) = v25.clone().borrow()[v31 as usize].clone();
        let mut v41: US1 = match &v32 {
            US1::US1_None => {
                let v36: bool = v33 == v2 ;
                if v36 {
                    US1::US1_Some(v34.clone())
                } else {
                    US1::US1_None
                }
            }
            US1::US1_Some(v35) => {
                let mut v35: US0 = v35.clone();
                v32.clone()
            }
        };
        v28.borrow_mut().l0 = v31;
        v28.borrow_mut().l1 = v41.clone();
        ()
    };
    let mut v42: US1 = v28.borrow().l1.clone();
    let v43: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let v44: Rc<dyn Fn(Rc<str>) -> ()> = closure1();
    let mut v45: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v44.clone() }));
    let mut v46: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v48: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v47.clone() }));
    let v51: US0 = match &v42 {
        US1::US1_None => {
            v0.clone()
        }
        US1::US1_Some(v49) => {
            let mut v49: US0 = v49.clone();
            v49.clone()
        }
    };
    let mut v52: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v51.clone() }));
    let v53: Option<i64> = None;
    (v43.clone(), v45.clone(), v46.clone(), v48.clone(), v52.clone(), v53.clone())
}
fn fresh_c0() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Info;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c2() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fresh_c3() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_Verbose;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = new_trace_state_0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let mut v6: u64 = { #[cfg(target_arch = "wasm32")] let (h, m, s) = { let secs = near_sdk::env::block_timestamp() / 1_000_000_000; ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; #[cfg(all(windows, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C)] struct St([u16; 8]); unsafe extern "system" { fn GetLocalTime(t: *mut St); } let mut t = St([0; 8]); unsafe { GetLocalTime(&mut t) }; (t.0[4] as u64, t.0[5] as u64, t.0[6] as u64) }; #[cfg(all(unix, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C, align(8))] struct Tm([i32; 16]); unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; } let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0) as std::os::raw::c_long; let mut tm = Tm([0; 16]); unsafe { localtime_r(&secs, &mut tm) }; (tm.0[2] as u64, tm.0[1] as u64, tm.0[0] as u64) }; #[cfg(not(any(windows, unix, target_arch = "wasm32")))] let (h, m, s) = { let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0); ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; h * 3600 + m * 60 + s };
    let mut v7: u64 = v6.wrapping_div(3600u64);
    let mut v8: bool = v7 < 10u64;
    let mut v11: Rc<str> = if v8 {
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v9
    } else {
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v10
    };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, Rc::<str>::from(format!("{:?}", v7))));
    let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
    let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: u64 = v6.wrapping_div(60u64);
    let mut v17: u64 = v16.wrapping_rem(60u64);
    let v18: bool = v17 < 10u64;
    let v21: Rc<str> = if v18 {
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v19
    } else {
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v20
    };
    let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v15, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{:?}", v17)))))), v14));
    let mut v26: u64 = v6.wrapping_rem(60u64);
    let mut v27: bool = v26 < 10u64;
    let v30: Rc<str> = if v27 {
        let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v28
    } else {
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v29
    };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v25, Rc::<str>::from(format!("{}{}", v30, Rc::<str>::from(format!("{:?}", v26))))));
    v33
}
fn method6(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3;
    ()
}
fn format_real_5(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method4() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[92m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method9(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn method10(mut v0: Rc<str>, mut v1: i32) -> i32 {
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
fn method8(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: i32 = 0i32;
    let mut v3: i32 = method9(v0.clone(), v1, v2);
    let mut v4: i32 = v1.wrapping_sub(1i32);
    let mut v5: Rc<str> = string_slice(&v0, v3 as i64, v4 as i64);
    let mut v6: i32 = (v5.clone().len() as i32);
    let mut v7: i32 = method10(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5, 0i32 as i64, v7 as i64);
    v8
}
fn format_real_11(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method13(mut v0: u64, mut v1: Rc<RefCell<Mut6>>) -> bool {
    let mut v2: u64 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method12(mut v0: Rc<RefCell<Vec<Rc<str>>>>) -> Rc<str> {
    let mut v1: u64 = (v0.clone().borrow().len() as u64);
    let mut v2: u64 = 0u64;
    let mut v3: Rc<RefCell<Mut6>> = Rc::new(RefCell::new(Mut6 { l0: v2 }));
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    while method13(v1, v3.clone()) {
        let mut v7: u64 = v3.borrow().l0.clone();
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
fn method7(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<RefCell<Vec<Rc<str>>>>) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_11(v9);
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
    let mut v26: Rc<str> = method12(v8);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v26));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v27));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", v29, v30))));
    method8(v32)
}
fn closure4() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn get_command_14() -> clap::Command {
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
    let mut v42: clap::Command = clap::Command::arg(v29, v40);
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul-spec"); } LIT.with(|lit| lit.clone()) };
    let v44: &'static str = Box::leak(String::from(&*v43).into_boxed_str());
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
    let mut v71: &'static str = Box::leak(String::from(&*v65).into_boxed_str());
    let mut v73: clap::Arg = v70.long(v71);
    let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("false"); } LIT.with(|lit| lit.clone()) };
    let v75: &str = (&*v74);
    let mut v77: clap::Arg = v73.default_value(&*Box::leak(String::from(v75).into_boxed_str()));
    let mut v79: clap::ArgAction = clap::ArgAction::SetTrue;
    let mut v81: clap::Arg = v77.action(v79);
    let mut v83: clap::Command = clap::Command::arg(v64, v81);
    v83
}
fn method15() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("source-dir"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method16(mut v0: Option<std::string::String>) -> Option<std::string::String> {
    v0
}
fn closure5() -> Rc<dyn Fn((std::string::String)) -> US3> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::string::String)) -> US3> = Rc::new(move |mut v0: (std::string::String)| -> US3 {
        let mut v1: std::string::String = (v0);
        US3::US3_Some(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method17() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist-dir"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method18() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache-dir"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method19() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul-spec"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method20() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("filter"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method21() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("transcribe-only"); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method28(mut v0: Option<Rc<str>>) -> Option<Rc<str>> {
    v0
}
fn closure6() -> Rc<dyn Fn((Rc<str>)) -> US4> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((Rc<str>)) -> US4> = Rc::new(move |mut v0: (Rc<str>)| -> US4 {
        let mut v1: Rc<str> = (v0);
        US4::US4_Some(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn get_file_name_27(mut v0: Rc<str>) -> Rc<str> {
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
    let mut v27: Option<Rc<str>> = method28(v26);
    let mut v28: Rc<dyn Fn((Rc<str>)) -> US4> = closure6();
    let mut v29: Option<US4> = v27.map(|x| v28(x));
    let mut v31: US4 = US4::US4_None;
    let mut v32: US4 = v31;
    let mut v33: US4 = v29.unwrap_or(v32);
    match &v33 {
        US4::US4_None => {
            let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v35
        }
        US4::US4_Some(v34) => {
            let v34: Rc<str> = v34.clone();
            v34
        }
    }
}
fn method30(mut v0: std::path::PathBuf) -> std::path::PathBuf {
    v0
}
fn directory_get_parent_29(mut v0: Rc<str>) -> Option<Rc<str>> {
    let mut v2: &str = &*v0;
    let mut v4: std::string::String = String::from(v2);
    let mut v6: std::path::PathBuf = std::path::PathBuf::from(v4);
    let mut v8: Option<std::path::PathBuf> = v6.parent().map(std::path::PathBuf::from);
    let mut v10: bool = true; let _optionm_map_ = v8.map(|x| { //;
    let mut v12: std::path::PathBuf = x;
    let mut v13: std::path::PathBuf = method30(v12);
    let v15: std::path::Display = v13.display();
    let mut v17: std::string::String = format!("{}", v15);
    let v19: Rc<str> = Rc::<str>::from(String::as_str(&v17));
    let v21: bool = true; v19 });
    let v23: Option<Rc<str>> = _optionm_map_;
    v23
}
fn closure7() -> Rc<dyn Fn(std::io::Error) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::io::Error) -> Rc<str>> = Rc::new(move |mut v0: std::io::Error| -> Rc<str> {
        let mut v1: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::io::Error>") } } (&&W(&v0)).s() });
        v1.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method31() -> Rc<dyn Fn(std::io::Error) -> Rc<str>> {
    closure7()
}
fn ok_c8() -> Rc<dyn Fn(std::path::PathBuf) -> US5> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::path::PathBuf) -> US5> = Rc::new(move |mut v0: std::path::PathBuf| -> US5 {
        US5::US5_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method32() -> Rc<dyn Fn(std::path::PathBuf) -> US5> {
    ok_c8()
}
fn error_c9() -> Rc<dyn Fn(Rc<str>) -> US5> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> US5> = Rc::new(move |mut v0: Rc<str>| -> US5 {
        US5::US5_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method33() -> Rc<dyn Fn(Rc<str>) -> US5> {
    error_c9()
}
fn method34(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    let mut v3: &str = &*v0;
    let mut v5: std::string::String = String::from(v3);
    let mut v7: std::path::PathBuf = std::path::PathBuf::from(v5);
    let mut v9: &str = &*v1;
    let mut v11: std::string::String = String::from(v9);
    let mut v13: std::path::PathBuf = v7.join(v11);
    let mut v14: std::path::PathBuf = method30(v13);
    let mut v16: std::path::Display = v14.display();
    let v18: std::string::String = format!("{}", v16);
    let mut v20: Rc<str> = Rc::<str>::from(String::as_str(&v18));
    v20
}
fn run_26(mut v0: Rc<str>, mut v1: Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>>, mut v2: u8, mut v3: Rc<str>, mut v4: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v5: Rc<str> = get_file_name_27(v4.clone());
    let mut v6: Option<Rc<str>> = directory_get_parent_29(v4.clone());
    let mut v7: Option<Rc<str>> = method28(v6);
    let mut v8: Rc<dyn Fn((Rc<str>)) -> US4> = closure6();
    let mut v9: Option<US4> = v7.map(|x| v8(x));
    let mut v11: US4 = US4::US4_None;
    let mut v12: US4 = v11;
    let mut v13: US4 = v9.unwrap_or(v12);
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
            US4::US4_Some(v22) => {
                let mut v22: Rc<str> = v22.clone();
                let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let v24: bool = v4 != v23 ;
                if v24 {
                    let mut v25: u8 = v2.wrapping_add(1u8);
                    let mut v26: Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> = v1(v25);
                    let mut v27: Result<std::path::PathBuf, std::io::Error> = v26(v22);
                    let mut v28: Rc<dyn Fn(std::io::Error) -> Rc<str>> = method31();
                    let v30: Result<std::path::PathBuf, Rc<str>> = v27.map_err(|x| v28(x));
                    let mut v31: Rc<dyn Fn(std::path::PathBuf) -> US5> = method32();
                    let mut v32: Rc<dyn Fn(Rc<str>) -> US5> = method33();
                    let mut v33: US5 = match v30 { Ok(x) => v31(x), Err(e) => v32(e) };
                    match &v33 {
                        US5::US5_Error(v48) => {
                            let mut v48: Rc<str> = v48.clone();
                            let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / "); } LIT.with(|lit| lit.clone()) };
                            let v50: Rc<str> = Rc::<str>::from(format!("error': {} / error: {} / name: {}", v48, v3, v5));
                            let v51: Rc<str> = Rc::<str>::from(format!("{}{}", v49, v50));
                            let v53: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v51);
                            let v55: Result<std::path::PathBuf, std::io::Error> = Err(v53);
                            v55
                        }
                        US5::US5_Ok(v34) => {
                            let v34: std::path::PathBuf = v34.clone();
                            let mut v35: std::path::PathBuf = method30(v34);
                            let v37: std::path::Display = v35.display();
                            let mut v38: Rc<str> = Rc::<str>::from(format!("{}", v37));
                            let v39: Rc<str> = method34(v38, v5.clone());
                            let mut v41: &str = &*v39;
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
fn closure11(mut v0: Rc<str>, mut v1: u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> {
    Rc::new(move |mut v2: Rc<str>| -> Result<std::path::PathBuf, std::io::Error> {
        method25(v0.clone(), v1, v2.clone())
    })
}
fn closure10(mut v0: Rc<str>) -> Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>> {
    Rc::new(move |mut v1: u8| -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> {
        closure11(v0.clone(), v1)
    })
}
fn method25(mut v0: Rc<str>, mut v1: u8, mut v2: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v4: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2);
    let mut v5: Rc<dyn Fn(std::io::Error) -> Rc<str>> = method31();
    let mut v7: Result<std::path::PathBuf, Rc<str>> = v4.map_err(|x| v5(x));
    let mut v8: Rc<dyn Fn(std::path::PathBuf) -> US5> = method32();
    let mut v9: Rc<dyn Fn(Rc<str>) -> US5> = method33();
    let mut v10: US5 = match v7 { Ok(x) => v8(x), Err(e) => v9(e) };
    match &v10 {
        US5::US5_Error(v14) => {
            let mut v14: Rc<str> = v14.clone();
            let v15: Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>> = closure10(v0.clone());
            run_26(v0, v15, v1, v14, v2)
        }
        US5::US5_Ok(v11) => {
            let mut v11: std::path::PathBuf = v11.clone();
            let mut v13: Result<std::path::PathBuf, std::io::Error> = Ok(v11);
            v13
        }
    }
}
fn directory_exists_35(mut v0: Rc<str>) -> bool {
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
fn read_link_24(mut v0: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v1: bool = directory_exists_35(v0.clone());
    if v1 {
        let mut v3: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0);
        v3
    } else {
        let mut v4: u8 = 0u8;
        method25(v0.clone(), v4, v0)
    }
}
fn method36(mut v0: Option<std::path::PathBuf>) -> Option<std::path::PathBuf> {
    v0
}
fn closure12() -> Rc<dyn Fn((std::path::PathBuf)) -> US6> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::path::PathBuf)) -> US6> = Rc::new(move |mut v0: (std::path::PathBuf)| -> US6 {
        let mut v1: std::path::PathBuf = (v0);
        US6::US6_Some(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn normalize_path_23(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: bool = &*v0 == "";
    if v1 {
        let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v2
    } else {
        let mut v3: Result<std::path::PathBuf, std::io::Error> = read_link_24(v0.clone());
        let mut v5: Option<std::path::PathBuf> = v3.ok();
        let mut v6: Option<std::path::PathBuf> = method36(v5);
        let mut v7: Rc<dyn Fn((std::path::PathBuf)) -> US6> = closure12();
        let mut v8: Option<US6> = v6.map(|x| v7(x));
        let mut v10: US6 = US6::US6_None;
        let mut v11: US6 = v10;
        let mut v12: US6 = v8.unwrap_or(v11);
        let v19: Rc<str> = match &v12 {
            US6::US6_None => {
                v0.clone()
            }
            US6::US6_Some(v13) => {
                let mut v13: std::path::PathBuf = v13.clone();
                let mut v14: std::path::PathBuf = method30(v13);
                let mut v16: std::path::Display = v14.display();
                let mut v17: Rc<str> = Rc::<str>::from(format!("{}", v16));
                v17
            }
        };
        let mut v20: bool = &*v19 == "";
        let v21: Rc<str> = if v20 {
            v0.clone()
        } else {
            v19
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
            v29
        } else {
            v21
        };
        let mut v31: i32 = (v30.clone().len() as i32);
        let mut v32: bool = v31 < 2i32;
        if v32 {
            v0
        } else {
            let mut v33: Rc<str> = string_slice(&v30.clone(), 0i32 as i64, 0i32 as i64);
            let v34: Rc<str> = Rc::<str>::from(v33.to_lowercase());
            let mut v35: i32 = v31.wrapping_sub(1i32);
            let v36: Rc<str> = string_slice(&v30, 1i32 as i64, v35 as i64);
            let v37: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v36));
            let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let v40: Rc<str> = Rc::<str>::from(v37.replace(&*v38, &*v39));
            v40
        }
    }
}
fn get_current_directory_37() -> Rc<str> {
    let mut v1: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
    let mut v3: std::path::PathBuf = v1.unwrap();
    let mut v4: std::path::PathBuf = method30(v3);
    let mut v6: std::path::Display = v4.display();
    let mut v8: std::string::String = format!("{}", v6);
    let mut v10: Rc<str> = Rc::<str>::from(String::as_str(&v8));
    v10
}
fn method40(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<dyn Fn(Rc<str>) -> bool>, mut v4: Rc<str>) -> US8 {
    loop {
        let mut v5: Rc<str> = method34(v4.clone(), v0.clone());
        let mut v6: bool = v3(v5.clone());
        if v6 {
            return US8::US8_Ok(v4.clone());
        } else {
            let mut v8: Option<Rc<str>> = directory_get_parent_29(v4.clone());
            let mut v9: Option<Rc<str>> = method28(v8.clone());
            let mut v10: Rc<dyn Fn((Rc<str>)) -> US4> = closure6();
            let mut v11: Option<US4> = v9.map(|x| v10(x));
            let mut v13: US4 = US4::US4_None;
            let mut v14: US4 = v13.clone();
            let v15: US4 = v11.unwrap_or(v14);
            match &v15 {
                US4::US4_None => {
                    let mut v20: Rc<str> = if v2 {
                        let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
                        v18.clone()
                    } else {
                        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir"); } LIT.with(|lit| lit.clone()) };
                        v19.clone()
                    };
                    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.find_parent / No parent for "); } LIT.with(|lit| lit.clone()) };
                    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v20));
                    let v23: Rc<str> = Rc::<str>::from(format!(" '{}' at '{}' (until '{}')", v0, v1, v4));
                    let v24: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v23));
                    return US8::US8_Error(v24.clone());
                }
                US4::US4_Some(v16) => {
                    let mut v16: Rc<str> = v16.clone();
                    (v0, v1, v2, v3, v4) = (v0.clone(), v1.clone(), v2, v3.clone(), v16.clone());
                    continue;
                }
            }
        }
    }
}
fn file_exists_41(mut v0: Rc<str>) -> bool {
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
fn closure13() -> Rc<dyn Fn(Rc<str>) -> bool> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> bool> = Rc::new(move |mut v0: Rc<str>| -> bool {
        file_exists_41(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure14() -> Rc<dyn Fn(Rc<str>) -> bool> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> bool> = Rc::new(move |mut v0: Rc<str>| -> bool {
        directory_exists_35(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn find_parent_39(mut v0: US7, mut v1: Rc<str>, mut v2: Rc<str>) -> US8 {
    let mut v3: bool = match &v0 {
        US7::US7_File => {
            true
        }
        _ => {
            false
        }
    };
    let mut v6: Rc<dyn Fn(Rc<str>) -> bool> = if v3 {
        closure13()
    } else {
        closure14()
    };
    method40(v1, v2.clone(), v3, v6, v2)
}
fn method42() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[93m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method43(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
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
    let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v33));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v35, v36))));
    method8(v38)
}
fn run_38(mut v0: Rc<str>) -> US4 {
    let mut v1: US7 = US7::US7_Directory;
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("spiral"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("workspace"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = method34(v2, v3);
    let mut v5: US8 = find_parent_39(v1, v4, v0.clone());
    match &v5 {
        US8::US8_Error(v9) => {
            let mut v9: Rc<str> = v9.clone();
            let mut v11: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
            { let _ = spiral_trace_hold(&v11); };
            let mut v13: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v14, mut v15, mut v16, mut v17, mut v18, mut v19): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v13) };
            let mut v20: US0 = v18.borrow().l0.clone();
            let mut v25: i32 = match &v20 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let mut v26: bool = v16.borrow().l0.clone();
            let mut v27: bool = v26 == false;
            let mut v29: bool = if v27 {
                false
            } else {
                let mut v28: bool = 40i32 >= v25;
                v28
            };
            let v30: bool = v29 == false;
            let mut v78: US2 = if v30 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v11); };
                let (mut v34, mut v35, mut v36, mut v37, mut v38, mut v39): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v13) };
                let v40: Rc<str> = method3(v34.clone(), v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone());
                let mut v41: Rc<str> = method42();
                let mut v42: Rc<str> = method43(v34, v35, v36, v37, v38, v39, v40, v41, v0, v9);
                { let _ = spiral_trace_hold(&v11); };
                let (mut v45, mut v46, mut v47, mut v48, mut v49, mut v50): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v13) };
                let v51: i64 = v45.borrow().l0.clone();
                let mut v52: i64 = v51.wrapping_add(1i64);
                v45.borrow_mut().l0 = v52;
                let v53: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
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
                    let mut v69: i32 = v68.wrapping_div(15000i32);
                    let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v71: bool = v42 != v70 ;
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
                US2::US2_Some(v45, v46, v47, v48, v49, v50)
            };
            US4::US4_None
        }
        US8::US8_Ok(v6) => {
            let mut v6: Rc<str> = v6.clone();
            let mut v7: Rc<str> = normalize_path_23(v6);
            US4::US4_Some(v7)
        }
    }
}
fn method45(mut v0: Rc<RefCell<Mut7>>) -> bool {
    let mut v1: i32 = v0.borrow().l0.clone();
    let mut v2: bool = v1 > 0i32;
    v2
}
fn method46(mut v0: i32, mut v1: Rc<RefCell<Mut8>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn directory_separator_char_47() -> u8 {
    let mut v0: u8 = (std::path::MAIN_SEPARATOR as u8);
    v0
}
fn get_full_path_44(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = get_current_directory_37();
    let mut v2: Rc<str> = method34(v1.clone(), v0.clone());
    let mut v3: Rc<str> = normalize_path_23(v2.clone());
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v3.split(&*v4).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let mut v6: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![]));
    let mut v7: i32 = (v5.clone().borrow().len() as i32);
    let mut v8: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: v7, l1: 0i32, l2: v6.clone() }));
    while method45(v8.clone()) {
        let mut v10: i32 = v8.borrow().l0.clone();
        let mut v11: i32 = v10.wrapping_sub(1i32);
        let (mut v12, mut v13): (i32, Rc<RefCell<Vec<Rc<str>>>>) = (v8.borrow().l1.clone(), v8.borrow().l2.clone());
        let mut v14: Rc<str> = v5.clone().borrow()[v11 as usize].clone();
        let v15: bool = ".." == &*v14;
        let (mut v58, mut v59): (i32, Rc<RefCell<Vec<Rc<str>>>>) = if v15 {
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
                        let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v19));
                        let v23: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![v22.clone()]));
                        let v24: i32 = (v23.clone().borrow().len() as i32);
                        let mut v25: i32 = (v13.clone().borrow().len() as i32);
                        let mut v26: i32 = v24.wrapping_add(v25);
                        let mut v27: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v26 as usize]));
                        let mut v28: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32 }));
                        while method46(v26, v28.clone()) {
                            let v30: i32 = v28.borrow().l0.clone();
                            let mut v31: bool = v30 < v24;
                            let mut v35: Rc<str> = if v31 {
                                let mut v32: Rc<str> = v23.clone().borrow()[v30 as usize].clone();
                                v32.clone()
                            } else {
                                let mut v33: i32 = v30.wrapping_sub(v24);
                                let v34: Rc<str> = v13.clone().borrow()[v33 as usize].clone();
                                v34.clone()
                            };
                            v27.clone().borrow_mut()[v30 as usize] = v35.clone();
                            let v36: i32 = v30.wrapping_add(1i32);
                            v28.borrow_mut().l0 = v36;
                            ()
                        };
                        (0i32, v27.clone())
                    } else {
                        let v37: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![v14.clone()]));
                        let mut v38: i32 = (v37.clone().borrow().len() as i32);
                        let v39: i32 = (v13.clone().borrow().len() as i32);
                        let v40: i32 = v38.wrapping_add(v39);
                        let mut v41: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v40 as usize]));
                        let mut v42: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32 }));
                        while method46(v40, v42.clone()) {
                            let v44: i32 = v42.borrow().l0.clone();
                            let mut v45: bool = v44 < v38;
                            let mut v49: Rc<str> = if v45 {
                                let mut v46: Rc<str> = v37.clone().borrow()[v44 as usize].clone();
                                v46.clone()
                            } else {
                                let mut v47: i32 = v44.wrapping_sub(v38);
                                let mut v48: Rc<str> = v13.clone().borrow()[v47 as usize].clone();
                                v48.clone()
                            };
                            v41.clone().borrow_mut()[v44 as usize] = v49.clone();
                            let v50: i32 = v44.wrapping_add(1i32);
                            v42.borrow_mut().l0 = v50;
                            ()
                        };
                        (0i32, v41.clone())
                    }
                } else {
                    let v53: i32 = v12.wrapping_sub(1i32);
                    (v53, v13.clone())
                }
            }
        };
        v8.borrow_mut().l0 = v11;
        v8.borrow_mut().l1 = v58;
        v8.borrow_mut().l2 = v59.clone();
        ()
    };
    let (mut v60, mut v61): (i32, Rc<RefCell<Vec<Rc<str>>>>) = (v8.borrow().l1.clone(), v8.borrow().l2.clone());
    let v62: Rc<Vec<Rc<str>>> = Rc::new(v61.borrow().clone());
    let mut v63: u8 = directory_separator_char_47();
    let v64: Rc<str> = Rc::<str>::from((v63 as char).encode_utf8(&mut [0u8; 4]) as &str);
    let mut v65: Rc<str> = Rc::<str>::from(v62.iter().map(|x| x.to_string()).collect::<Vec<_>>().join(&*v64));
    v65.clone()
}
fn method48() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method50(mut v0: US4) -> Rc<str> {
    match &v0 {
        US4::US4_None => {
            let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("None"); } LIT.with(|lit| lit.clone()) };
            v8
        }
        US4::US4_Some(v1) => {
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
fn format_real_51(mut v0: bool) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v5: Rc<str> = if v0 {
        let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("true"); } LIT.with(|lit| lit.clone()) };
        v3
    } else {
        let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("false"); } LIT.with(|lit| lit.clone()) };
        v4
    };
    method6(v2.clone(), v5);
    let mut v6: Rc<str> = v2.borrow().l0.clone();
    v6
}
fn method49(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>, mut v11: Rc<str>, mut v12: US4, mut v13: bool) -> Rc<str> {
    let mut v14: i64 = v0.borrow().l0.clone();
    let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v15));
    let mut v17: Rc<str> = format_real_11(v14);
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
    let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist_dir"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v29)), v9)), v32));
    let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache_dir"); } LIT.with(|lit| lit.clone()) };
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v29)), v10)), v32));
    let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul_spec"); } LIT.with(|lit| lit.clone()) };
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v43, v44)), v29)), v11)), v32));
    let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("filter"); } LIT.with(|lit| lit.clone()) };
    let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v29));
    let mut v52: Rc<str> = method50(v12);
    let v54: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, v52)), v32));
    let v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("transcribe_only"); } LIT.with(|lit| lit.clone()) };
    let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v54, v55)), v29));
    let v58: Rc<str> = format_real_51(v13);
    let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v58));
    let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
    let v62: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v64: Rc<str> = Rc::<str>::from(format!("{}{}", v24, Rc::<str>::from(format!("{}{}", v61, v62))));
    method8(v64)
}
fn method52(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: usize) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_11(v9);
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
    method8(v32)
}
fn method53(mut v0: Vec<Rc<str>>) -> Vec<Rc<str>> {
    v0
}
fn method55() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    v0
}
fn standardize_path_56(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = get_full_path_44(v0);
    normalize_path_23(v1)
}
fn method58(mut v0: Rc<str>, mut v1: Option<std::sync::Arc<std::sync::atomic::AtomicBool>>, mut v2: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>>, mut v3: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>>, mut v4: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>>, mut v5: bool, mut v6: Option<Rc<str>>, mut v7: bool) -> Rc<str> {
    v0
}
fn format_real_60(mut v0: i32) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn closure15() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: u8 = b'"';
        let mut v13: Rc<str> = format_real_5(v12);
        let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v13));
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v10));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v10));
        let v24: Rc<str> = format_real_60(v2);
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v15));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v10));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v10));
        let v34: Rc<str> = format_real_60(v3);
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v15));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v10));
        let v40: Rc<str> = format_real_60(v4);
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
        let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v43, v44)))), v15));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v47, v48)), v10));
        let v51: Rc<str> = format_real_60(v5);
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v50, v51)))), v44)))))), v44));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        v59.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method61(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn closure17(mut v0: i32, mut v1: i32) -> Rc<dyn Fn(Rc<str>) -> Rc<str>> {
    Rc::new(move |mut v2: Rc<str>| -> Rc<str> {
        let mut v3: bool = v1 >= v0;
        if v3 {
            v2.clone()
        } else {
            let mut v4: i32 = v1.wrapping_add(1i32);
            let mut v5: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method62(v0, v4);
            let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v6));
            v5(v7.clone())
        }
    })
}
fn method62(mut v0: i32, mut v1: i32) -> Rc<dyn Fn(Rc<str>) -> Rc<str>> {
    closure17(v0, v1)
}
fn closure16() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method61(v0.clone(), v6, v1);
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
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method62(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: u8 = b'"';
        let v39: Rc<str> = format_real_5(v38);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v39));
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v36));
        let mut v46: Rc<str> = format_real_60(v3);
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v41));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v36));
        let mut v52: Rc<str> = format_real_60(v4);
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
fn closure18() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: u8 = b'\'';
        let mut v13: Rc<str> = format_real_5(v12);
        let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v13));
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v10));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v10));
        let v24: Rc<str> = format_real_60(v2);
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v15));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v10));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v10));
        let v34: Rc<str> = format_real_60(v3);
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v15));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v10));
        let v40: Rc<str> = format_real_60(v4);
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
        let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v43, v44)))), v15));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v47, v48)), v10));
        let v51: Rc<str> = format_real_60(v5);
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v50, v51)))), v44)))))), v44));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        v59.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure19() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method61(v0.clone(), v6, v1);
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
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method62(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: u8 = b'\'';
        let v39: Rc<str> = format_real_5(v38);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v39));
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v36));
        let mut v46: Rc<str> = format_real_60(v3);
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v41));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v36));
        let mut v52: Rc<str> = format_real_60(v4);
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
fn closure20() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.choice / no parsers succeeded"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method63(mut v0: Rc<RefCell<Vec<u8>>>) -> Rc<str> {
    let mut v1: u64 = (v0.clone().borrow().len() as u64);
    let mut v2: u64 = 0u64;
    let mut v3: Rc<RefCell<Mut6>> = Rc::new(RefCell::new(Mut6 { l0: v2 }));
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    while method13(v1, v3.clone()) {
        let mut v7: u64 = v3.borrow().l0.clone();
        let mut v8: u8 = v0.clone().borrow()[v7 as usize].clone();
        let mut v9: Rc<str> = format_real_5(v8);
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
fn closure21() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v6.borrow_mut().push(b'"');
        v6.borrow_mut().push(b'\'');
        let mut v7: Rc<Vec<u8>> = Rc::new(v6.borrow().clone());
        let mut v8: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
        let mut v9: Rc<str> = method63(v8.clone());
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
        let mut v26: Rc<str> = format_real_60(v2);
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v17));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v14));
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = format_real_60(v3);
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v17));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v14));
        let mut v42: Rc<str> = format_real_60(v4);
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, Rc::<str>::from(format!("{}{}", v45, v46)))), v17));
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v14));
        let v53: Rc<str> = format_real_60(v5);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v52, v53)))), v46)))))), v46));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        v61.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure22() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        v7.borrow_mut().push(b'\'');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method63(v9.clone());
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char = "); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = format_real_5(v6);
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
        let mut v33: Rc<str> = format_real_60(v2);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v19));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v15));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v39, v40)), v15));
        let v43: Rc<str> = format_real_60(v3);
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v19));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v15));
        let mut v49: Rc<str> = format_real_60(v4);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, Rc::<str>::from(format!("{}{}", v52, v53)))), v19));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v56, v57)), v15));
        let v60: Rc<str> = format_real_60(v5);
        let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v59, v60)))), v53)))))), v53));
        let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v66));
        v68.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure23() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_chars / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method64(mut v0: i32, mut v1: Rc<str>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US11 {
    loop {
        let mut v7: bool = v2 >= v6;
        let mut v28: US10 = if v7 {
            let mut v8: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure21();
            US10::US10_Error(v8.clone(), v2, v3, v4, v5, v6)
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
                US10::US10_Ok(v10, v15, v20, v21, v22, v23)
            } else {
                let mut v25: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure22();
                US10::US10_Error(v25.clone(), v2, v3, v4, v5, v6)
            }
        };
        match &v28 {
            US10::US10_Error(v29, v30, v31, v32, v33, v34) => {
                let mut v29: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v29.clone();
                let v30: i32 = *v30;
                let mut v31: i32 = *v31;
                let mut v32: i32 = *v32;
                let mut v33: i32 = *v33;
                let v34: i32 = *v34;
                let mut v35: bool = v0 >= v2;
                let v40: Rc<str> = if v35 {
                    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v36.clone()
                } else {
                    let mut v38: i32 = v2.wrapping_sub(1i32);
                    let v39: Rc<str> = string_slice(&v1.clone(), v0 as i64, v38 as i64);
                    v39.clone()
                };
                return US11::US11_Ok(v40.clone(), v2, v3, v4, v5, v6);
            }
            US10::US10_Ok(v42, v43, v44, v45, v46, v47) => {
                let mut v42: u8 = *v42;
                let v43: i32 = *v43;
                let v44: i32 = *v44;
                let mut v45: i32 = *v45;
                let mut v46: i32 = *v46;
                let mut v47: i32 = *v47;
                let mut v48: bool = v43 != v2;
                if v48 {
                    (v0, v1, v2, v3, v4, v5, v6) = (v0, v1.clone(), v43, v44, v45, v46, v47);
                    continue;
                } else {
                    let v50: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                    return US11::US11_Error(v50.clone(), v2, v3, v4, v5, v6);
                }
            }
        }
    }
}
fn closure24() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
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
fn e_c26(mut v0: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0(v6.clone(), v1, v2, v3, v4, v5)
    })
}
fn format_real_65(mut v0: Rc<dyn Fn() -> Rc<str>>) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = v0();
    method6(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn closure25(mut v0: i32, mut v1: i32, mut v2: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32) -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
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
        let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e"); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e = "); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<dyn Fn() -> Rc<str>> = e_c26(v2.clone(), v3, v4, v5, v6, v7, v8.clone());
        let v40: Rc<str> = format_real_65(v39.clone());
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v40));
        let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("t"); } LIT.with(|lit| lit.clone()) };
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
fn closure27() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v6.borrow_mut().push(b'"');
        v6.borrow_mut().push(b'\'');
        v6.borrow_mut().push(b' ');
        let mut v7: Rc<Vec<u8>> = Rc::new(v6.borrow().clone());
        let mut v8: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
        let mut v9: Rc<str> = method63(v8.clone());
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
        let mut v26: Rc<str> = format_real_60(v2);
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v17));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v14));
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = format_real_60(v3);
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v17));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v14));
        let mut v42: Rc<str> = format_real_60(v4);
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, Rc::<str>::from(format!("{}{}", v45, v46)))), v17));
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v14));
        let v53: Rc<str> = format_real_60(v5);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v52, v53)))), v46)))))), v46));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        v61.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure28() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        v7.borrow_mut().push(b'\'');
        v7.borrow_mut().push(b' ');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method63(v9.clone());
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char = "); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = format_real_5(v6);
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
        let mut v33: Rc<str> = format_real_60(v2);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v19));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v15));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v39, v40)), v15));
        let v43: Rc<str> = format_real_60(v3);
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v19));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v15));
        let mut v49: Rc<str> = format_real_60(v4);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, Rc::<str>::from(format!("{}{}", v52, v53)))), v19));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v56, v57)), v15));
        let v60: Rc<str> = format_real_60(v5);
        let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v59, v60)))), v53)))))), v53));
        let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v66));
        v68.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method66(mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32) -> US11 {
    loop {
        let mut v6: bool = v1 >= v5;
        let mut v29: US10 = if v6 {
            let mut v7: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
            US10::US10_Error(v7.clone(), v1, v2, v3, v4, v5)
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
                US10::US10_Ok(v9, v16, v21, v22, v23, v24)
            } else {
                let mut v26: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28();
                US10::US10_Error(v26.clone(), v1, v2, v3, v4, v5)
            }
        };
        match &v29 {
            US10::US10_Error(v30, v31, v32, v33, v34, v35) => {
                let v30: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v30.clone();
                let mut v31: i32 = *v31;
                let mut v32: i32 = *v32;
                let mut v33: i32 = *v33;
                let v34: i32 = *v34;
                let mut v35: i32 = *v35;
                let v36: bool = 0i32 >= v1;
                let mut v41: Rc<str> = if v36 {
                    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v37.clone()
                } else {
                    let v39: i32 = v1.wrapping_sub(1i32);
                    let v40: Rc<str> = string_slice(&v0.clone(), 0i32 as i64, v39 as i64);
                    v40.clone()
                };
                return US11::US11_Ok(v41.clone(), v1, v2, v3, v4, v5);
            }
            US10::US10_Ok(v43, v44, v45, v46, v47, v48) => {
                let v43: u8 = *v43;
                let v44: i32 = *v44;
                let mut v45: i32 = *v45;
                let mut v46: i32 = *v46;
                let mut v47: i32 = *v47;
                let mut v48: i32 = *v48;
                let mut v49: bool = v44 != v1;
                if v49 {
                    (v0, v1, v2, v3, v4, v5) = (v0.clone(), v44, v45, v46, v47, v48);
                    continue;
                } else {
                    let v51: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                    return US11::US11_Error(v51.clone(), v1, v2, v3, v4, v5);
                }
            }
        }
    }
}
fn closure29() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
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
fn method67(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn closure30() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
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
fn closure31(mut v0: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0.clone()
    })
}
fn closure32(mut v0: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0.clone()
    })
}
fn closure33(mut v0: US14) -> Rc<dyn Fn() -> US14> {
    Rc::new(move || -> US14 {
        v0.clone()
    })
}
fn closure34(mut v0: Rc<str>, mut v1: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v1(v0.clone(), v2, v3, v4, v5, v6)
    })
}
fn split_command_59(mut v0: Rc<str>) -> US9 {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: bool = 0i32 >= v1;
    let mut v16: US10 = if v2 {
        let mut v3: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
        US10::US10_Error(v3, 0i32, 0i32, 1i32, 1i32, v1)
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
            US10::US10_Ok(b'"', 1i32, v8, v9, v10, v11)
        } else {
            let mut v13: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
            US10::US10_Error(v13, 0i32, 0i32, 1i32, 1i32, v1)
        }
    };
    let v60: US10 = match &v16 {
        US10::US10_Error(v23, v24, v25, v26, v27, v28) => {
            let v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v23.clone();
            let v24: i32 = *v24;
            let mut v25: i32 = *v25;
            let mut v26: i32 = *v26;
            let mut v27: i32 = *v27;
            let mut v28: i32 = *v28;
            let mut v42: US10 = if v2 {
                let mut v29: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                US10::US10_Error(v29, 0i32, 0i32, 1i32, 1i32, v1)
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
                    US10::US10_Ok(b'\'', 1i32, v34, v35, v36, v37)
                } else {
                    let v39: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                    US10::US10_Error(v39, 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            match &v42 {
                US10::US10_Error(v49, v50, v51, v52, v53, v54) => {
                    let mut v49: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v49.clone();
                    let v50: i32 = *v50;
                    let v51: i32 = *v51;
                    let mut v52: i32 = *v52;
                    let v53: i32 = *v53;
                    let v54: i32 = *v54;
                    let v55: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                    US10::US10_Error(v55, 0i32, 0i32, 1i32, 1i32, v1)
                }
                US10::US10_Ok(v43, v44, v45, v46, v47, v48) => {
                    let v43: u8 = *v43;
                    let v44: i32 = *v44;
                    let mut v45: i32 = *v45;
                    let mut v46: i32 = *v46;
                    let mut v47: i32 = *v47;
                    let mut v48: i32 = *v48;
                    v42
                }
            }
        }
        US10::US10_Ok(v17, v18, v19, v20, v21, v22) => {
            let mut v17: u8 = *v17;
            let v18: i32 = *v18;
            let v19: i32 = *v19;
            let mut v20: i32 = *v20;
            let v21: i32 = *v21;
            let mut v22: i32 = *v22;
            v16
        }
    };
    let mut v312: US11 = match &v60 {
        US10::US10_Error(v304, v305, v306, v307, v308, v309) => {
            let v304: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v304.clone();
            let v305: i32 = *v305;
            let v306: i32 = *v306;
            let v307: i32 = *v307;
            let v308: i32 = *v308;
            let v309: i32 = *v309;
            US11::US11_Error(v304, v305, v306, v307, v308, v309)
        }
        US10::US10_Ok(v61, v62, v63, v64, v65, v66) => {
            let v61: u8 = *v61;
            let v62: i32 = *v62;
            let mut v63: i32 = *v63;
            let v64: i32 = *v64;
            let mut v65: i32 = *v65;
            let v66: i32 = *v66;
            let v67: bool = v62 >= v66;
            let v88: US10 = if v67 {
                let mut v68: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure21();
                US10::US10_Error(v68, v62, v63, v64, v65, v66)
            } else {
                let mut v70: u8 = v0.clone().as_bytes()[v62 as usize];
                let mut v71: bool = v70 == b'"';
                let mut v73: bool = if v71 {
                    true
                } else {
                    let v72: bool = v70 == b'\'';
                    v72
                };
                let mut v74: bool = v73 == false;
                if v74 {
                    let v75: i32 = v62.wrapping_add(1i32);
                    let mut v76: bool = b'\n' == v70;
                    let (mut v80, mut v81, mut v82, mut v83): (i32, i32, i32, i32) = if v76 {
                        let mut v77: i32 = v63.wrapping_add(v65);
                        let mut v78: i32 = v64.wrapping_add(1i32);
                        (v77, v78, 1i32, v66)
                    } else {
                        let mut v79: i32 = v65.wrapping_add(1i32);
                        (v63, v64, v79, v66)
                    };
                    US10::US10_Ok(v70, v75, v80, v81, v82, v83)
                } else {
                    let v85: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure22();
                    US10::US10_Error(v85, v62, v63, v64, v65, v66)
                }
            };
            let v104: US11 = match &v88 {
                US10::US10_Error(v89, v90, v91, v92, v93, v94) => {
                    let v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v89.clone();
                    let v90: i32 = *v90;
                    let v91: i32 = *v91;
                    let v92: i32 = *v92;
                    let mut v93: i32 = *v93;
                    let v94: i32 = *v94;
                    US11::US11_Error(v89, v90, v91, v92, v93, v94)
                }
                US10::US10_Ok(v96, v97, v98, v99, v100, v101) => {
                    let v96: u8 = *v96;
                    let mut v97: i32 = *v97;
                    let mut v98: i32 = *v98;
                    let mut v99: i32 = *v99;
                    let v100: i32 = *v100;
                    let v101: i32 = *v101;
                    method64(v62, v0.clone(), v97, v98, v99, v100, v101)
                }
            };
            let mut v121: US11 = match &v104 {
                US11::US11_Error(v112, v113, v114, v115, v116, v117) => {
                    let v112: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v112.clone();
                    let v113: i32 = *v113;
                    let v114: i32 = *v114;
                    let v115: i32 = *v115;
                    let mut v116: i32 = *v116;
                    let v117: i32 = *v117;
                    let v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US11::US11_Ok(v118, v62, v63, v64, v65, v66)
                }
                US11::US11_Ok(v105, v106, v107, v108, v109, v110) => {
                    let mut v105: Rc<str> = v105.clone();
                    let mut v106: i32 = *v106;
                    let mut v107: i32 = *v107;
                    let mut v108: i32 = *v108;
                    let v109: i32 = *v109;
                    let mut v110: i32 = *v110;
                    US11::US11_Ok(v105, v106, v107, v108, v109, v110)
                }
            };
            match &v121 {
                US11::US11_Error(v212, v213, v214, v215, v216, v217) => {
                    let v212: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v212.clone();
                    let mut v213: i32 = *v213;
                    let v214: i32 = *v214;
                    let v215: i32 = *v215;
                    let mut v216: i32 = *v216;
                    let v217: i32 = *v217;
                    let v235: US10 = if v67 {
                        let mut v218: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                        US10::US10_Error(v218, v62, v63, v64, v65, v66)
                    } else {
                        let v220: u8 = v0.clone().as_bytes()[v62 as usize];
                        let mut v221: bool = v220 == b'"';
                        if v221 {
                            let mut v222: i32 = v62.wrapping_add(1i32);
                            let v223: bool = b'\n' == v220;
                            let (mut v227, mut v228, mut v229, mut v230): (i32, i32, i32, i32) = if v223 {
                                let v224: i32 = v63.wrapping_add(v65);
                                let mut v225: i32 = v64.wrapping_add(1i32);
                                (v224, v225, 1i32, v66)
                            } else {
                                let mut v226: i32 = v65.wrapping_add(1i32);
                                (v63, v64, v226, v66)
                            };
                            US10::US10_Ok(b'"', v222, v227, v228, v229, v230)
                        } else {
                            let v232: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                            US10::US10_Error(v232, v62, v63, v64, v65, v66)
                        }
                    };
                    let mut v283: US10 = match &v235 {
                        US10::US10_Error(v242, v243, v244, v245, v246, v247) => {
                            let v242: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v242.clone();
                            let v243: i32 = *v243;
                            let mut v244: i32 = *v244;
                            let v245: i32 = *v245;
                            let v246: i32 = *v246;
                            let v247: i32 = *v247;
                            let v265: US10 = if v67 {
                                let v248: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US10::US10_Error(v248, v62, v63, v64, v65, v66)
                            } else {
                                let v250: u8 = v0.clone().as_bytes()[v62 as usize];
                                let v251: bool = v250 == b'\'';
                                if v251 {
                                    let v252: i32 = v62.wrapping_add(1i32);
                                    let v253: bool = b'\n' == v250;
                                    let (mut v257, mut v258, mut v259, mut v260): (i32, i32, i32, i32) = if v253 {
                                        let v254: i32 = v63.wrapping_add(v65);
                                        let mut v255: i32 = v64.wrapping_add(1i32);
                                        (v254, v255, 1i32, v66)
                                    } else {
                                        let v256: i32 = v65.wrapping_add(1i32);
                                        (v63, v64, v256, v66)
                                    };
                                    US10::US10_Ok(b'\'', v252, v257, v258, v259, v260)
                                } else {
                                    let v262: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US10::US10_Error(v262, v62, v63, v64, v65, v66)
                                }
                            };
                            match &v265 {
                                US10::US10_Error(v272, v273, v274, v275, v276, v277) => {
                                    let mut v272: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v272.clone();
                                    let v273: i32 = *v273;
                                    let v274: i32 = *v274;
                                    let v275: i32 = *v275;
                                    let v276: i32 = *v276;
                                    let v277: i32 = *v277;
                                    let v278: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_Error(v278, v62, v63, v64, v65, v66)
                                }
                                US10::US10_Ok(v266, v267, v268, v269, v270, v271) => {
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
                        US10::US10_Ok(v236, v237, v238, v239, v240, v241) => {
                            let v236: u8 = *v236;
                            let mut v237: i32 = *v237;
                            let v238: i32 = *v238;
                            let mut v239: i32 = *v239;
                            let v240: i32 = *v240;
                            let v241: i32 = *v241;
                            v235
                        }
                    };
                    match &v283 {
                        US10::US10_Error(v292, v293, v294, v295, v296, v297) => {
                            let v292: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v292.clone();
                            let v293: i32 = *v293;
                            let v294: i32 = *v294;
                            let v295: i32 = *v295;
                            let v296: i32 = *v296;
                            let v297: i32 = *v297;
                            let v298: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                            US11::US11_Error(v298, v62, v63, v64, v65, v66)
                        }
                        US10::US10_Ok(v284, v285, v286, v287, v288, v289) => {
                            let mut v284: u8 = *v284;
                            let v285: i32 = *v285;
                            let v286: i32 = *v286;
                            let v287: i32 = *v287;
                            let v288: i32 = *v288;
                            let v289: i32 = *v289;
                            let v290: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US11::US11_Ok(v290, v285, v286, v287, v288, v289)
                        }
                    }
                }
                US11::US11_Ok(v122, v123, v124, v125, v126, v127) => {
                    let mut v122: Rc<str> = v122.clone();
                    let v123: i32 = *v123;
                    let mut v124: i32 = *v124;
                    let v125: i32 = *v125;
                    let v126: i32 = *v126;
                    let mut v127: i32 = *v127;
                    let v128: bool = v123 >= v127;
                    let v146: US10 = if v128 {
                        let v129: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                        US10::US10_Error(v129, v123, v124, v125, v126, v127)
                    } else {
                        let v131: u8 = v0.clone().as_bytes()[v123 as usize];
                        let v132: bool = v131 == b'"';
                        if v132 {
                            let mut v133: i32 = v123.wrapping_add(1i32);
                            let v134: bool = b'\n' == v131;
                            let (mut v138, mut v139, mut v140, mut v141): (i32, i32, i32, i32) = if v134 {
                                let v135: i32 = v124.wrapping_add(v126);
                                let v136: i32 = v125.wrapping_add(1i32);
                                (v135, v136, 1i32, v127)
                            } else {
                                let v137: i32 = v126.wrapping_add(1i32);
                                (v124, v125, v137, v127)
                            };
                            US10::US10_Ok(b'"', v133, v138, v139, v140, v141)
                        } else {
                            let mut v143: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                            US10::US10_Error(v143, v123, v124, v125, v126, v127)
                        }
                    };
                    let v194: US10 = match &v146 {
                        US10::US10_Error(v153, v154, v155, v156, v157, v158) => {
                            let mut v153: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v153.clone();
                            let mut v154: i32 = *v154;
                            let mut v155: i32 = *v155;
                            let mut v156: i32 = *v156;
                            let mut v157: i32 = *v157;
                            let mut v158: i32 = *v158;
                            let mut v176: US10 = if v128 {
                                let v159: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US10::US10_Error(v159, v123, v124, v125, v126, v127)
                            } else {
                                let v161: u8 = v0.clone().as_bytes()[v123 as usize];
                                let v162: bool = v161 == b'\'';
                                if v162 {
                                    let mut v163: i32 = v123.wrapping_add(1i32);
                                    let v164: bool = b'\n' == v161;
                                    let (mut v168, mut v169, mut v170, mut v171): (i32, i32, i32, i32) = if v164 {
                                        let v165: i32 = v124.wrapping_add(v126);
                                        let v166: i32 = v125.wrapping_add(1i32);
                                        (v165, v166, 1i32, v127)
                                    } else {
                                        let mut v167: i32 = v126.wrapping_add(1i32);
                                        (v124, v125, v167, v127)
                                    };
                                    US10::US10_Ok(b'\'', v163, v168, v169, v170, v171)
                                } else {
                                    let mut v173: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US10::US10_Error(v173, v123, v124, v125, v126, v127)
                                }
                            };
                            match &v176 {
                                US10::US10_Error(v183, v184, v185, v186, v187, v188) => {
                                    let v183: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v183.clone();
                                    let v184: i32 = *v184;
                                    let v185: i32 = *v185;
                                    let v186: i32 = *v186;
                                    let mut v187: i32 = *v187;
                                    let v188: i32 = *v188;
                                    let v189: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_Error(v189, v123, v124, v125, v126, v127)
                                }
                                US10::US10_Ok(v177, v178, v179, v180, v181, v182) => {
                                    let v177: u8 = *v177;
                                    let mut v178: i32 = *v178;
                                    let v179: i32 = *v179;
                                    let v180: i32 = *v180;
                                    let v181: i32 = *v181;
                                    let v182: i32 = *v182;
                                    v176
                                }
                            }
                        }
                        US10::US10_Ok(v147, v148, v149, v150, v151, v152) => {
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
                        US10::US10_Error(v202, v203, v204, v205, v206, v207) => {
                            let v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v202.clone();
                            let v203: i32 = *v203;
                            let v204: i32 = *v204;
                            let v205: i32 = *v205;
                            let mut v206: i32 = *v206;
                            let v207: i32 = *v207;
                            let mut v208: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v62, v123, v202, v203, v204, v205, v206, v207);
                            US11::US11_Error(v208, v123, v124, v125, v126, v127)
                        }
                        US10::US10_Ok(v195, v196, v197, v198, v199, v200) => {
                            let v195: u8 = *v195;
                            let v196: i32 = *v196;
                            let v197: i32 = *v197;
                            let v198: i32 = *v198;
                            let v199: i32 = *v199;
                            let v200: i32 = *v200;
                            US11::US11_Ok(v122, v196, v197, v198, v199, v200)
                        }
                    }
                }
            }
        }
    };
    let v331: US11 = match &v312 {
        US11::US11_Error(v323, v324, v325, v326, v327, v328) => {
            let v323: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v323.clone();
            let v324: i32 = *v324;
            let v325: i32 = *v325;
            let v326: i32 = *v326;
            let mut v327: i32 = *v327;
            let v328: i32 = *v328;
            US11::US11_Error(v323, v324, v325, v326, v327, v328)
        }
        US11::US11_Ok(v313, v314, v315, v316, v317, v318) => {
            let v313: Rc<str> = v313.clone();
            let v314: i32 = *v314;
            let v315: i32 = *v315;
            let v316: i32 = *v316;
            let v317: i32 = *v317;
            let v318: i32 = *v318;
            let v319: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let v320: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let v321: Rc<str> = Rc::<str>::from(v313.replace(&*v319, &*v320));
            US11::US11_Ok(v321, v314, v315, v316, v317, v318)
        }
    };
    let v399: US11 = match &v331 {
        US11::US11_Error(v338, v339, v340, v341, v342, v343) => {
            let v338: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v338.clone();
            let v339: i32 = *v339;
            let v340: i32 = *v340;
            let v341: i32 = *v341;
            let v342: i32 = *v342;
            let v343: i32 = *v343;
            let v362: US10 = if v2 {
                let v344: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                US10::US10_Error(v344, 0i32, 0i32, 1i32, 1i32, v1)
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
                    US10::US10_Ok(v346, 1i32, v354, v355, v356, v357)
                } else {
                    let v359: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28();
                    US10::US10_Error(v359, 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            let mut v378: US11 = match &v362 {
                US10::US10_Error(v363, v364, v365, v366, v367, v368) => {
                    let v363: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v363.clone();
                    let v364: i32 = *v364;
                    let v365: i32 = *v365;
                    let v366: i32 = *v366;
                    let v367: i32 = *v367;
                    let v368: i32 = *v368;
                    US11::US11_Error(v363, v364, v365, v366, v367, v368)
                }
                US10::US10_Ok(v370, v371, v372, v373, v374, v375) => {
                    let v370: u8 = *v370;
                    let v371: i32 = *v371;
                    let v372: i32 = *v372;
                    let v373: i32 = *v373;
                    let v374: i32 = *v374;
                    let v375: i32 = *v375;
                    method66(v0.clone(), v371, v372, v373, v374, v375)
                }
            };
            match &v378 {
                US11::US11_Error(v389, v390, v391, v392, v393, v394) => {
                    let v389: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v389.clone();
                    let v390: i32 = *v390;
                    let v391: i32 = *v391;
                    let v392: i32 = *v392;
                    let v393: i32 = *v393;
                    let v394: i32 = *v394;
                    US11::US11_Error(v389, v390, v391, v392, v393, v394)
                }
                US11::US11_Ok(v379, v380, v381, v382, v383, v384) => {
                    let v379: Rc<str> = v379.clone();
                    let v380: i32 = *v380;
                    let mut v381: i32 = *v381;
                    let v382: i32 = *v382;
                    let v383: i32 = *v383;
                    let v384: i32 = *v384;
                    let v385: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
                    let v386: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
                    let v387: Rc<str> = Rc::<str>::from(v379.replace(&*v385, &*v386));
                    US11::US11_Ok(v387, v380, v381, v382, v383, v384)
                }
            }
        }
        US11::US11_Ok(v332, v333, v334, v335, v336, v337) => {
            let v332: Rc<str> = v332.clone();
            let v333: i32 = *v333;
            let v334: i32 = *v334;
            let v335: i32 = *v335;
            let v336: i32 = *v336;
            let v337: i32 = *v337;
            v331
        }
    };
    let v434: US11 = match &v399 {
        US11::US11_Error(v406, v407, v408, v409, v410, v411) => {
            let v406: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v406.clone();
            let v407: i32 = *v407;
            let mut v408: i32 = *v408;
            let v409: i32 = *v409;
            let v410: i32 = *v410;
            let v411: i32 = *v411;
            let v412: bool = v1 == 0i32;
            let v416: US12 = if v412 {
                US12::US12_Ok(0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let v414: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure29();
                US12::US12_Error(v414, 0i32, 0i32, 1i32, 1i32, v1)
            };
            match &v416 {
                US12::US12_Error(v424, v425, v426, v427, v428, v429) => {
                    let v424: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v424.clone();
                    let v425: i32 = *v425;
                    let v426: i32 = *v426;
                    let v427: i32 = *v427;
                    let v428: i32 = *v428;
                    let v429: i32 = *v429;
                    US11::US11_Error(v424, v425, v426, v427, v428, v429)
                }
                US12::US12_Ok(v417, v418, v419, v420, v421) => {
                    let v417: i32 = *v417;
                    let v418: i32 = *v418;
                    let v419: i32 = *v419;
                    let v420: i32 = *v420;
                    let v421: i32 = *v421;
                    let v422: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US11::US11_Ok(v422, v417, v418, v419, v420, v421)
                }
            }
        }
        US11::US11_Ok(v400, v401, v402, v403, v404, v405) => {
            let v400: Rc<str> = v400.clone();
            let v401: i32 = *v401;
            let v402: i32 = *v402;
            let v403: i32 = *v403;
            let v404: i32 = *v404;
            let v405: i32 = *v405;
            v399
        }
    };
    let v546: US13 = match &v434 {
        US11::US11_Error(v435, v436, v437, v438, v439, v440) => {
            let v435: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v435.clone();
            let v436: i32 = *v436;
            let v437: i32 = *v437;
            let v438: i32 = *v438;
            let v439: i32 = *v439;
            let v440: i32 = *v440;
            US13::US13_Error(v435, v436, v437, v438, v439, v440)
        }
        US11::US11_Ok(v442, v443, v444, v445, v446, v447) => {
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
                let v449: i32 = method67(v0.clone(), v1, v443);
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
            let v469: US12 = if v465 {
                US12::US12_Ok(v460, v461, v462, v463, v464)
            } else {
                let v467: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure30();
                US12::US12_Error(v467, v443, v444, v445, v446, v447)
            };
            let v507: US11 = match &v469 {
                US12::US12_Error(v499, v500, v501, v502, v503, v504) => {
                    let v499: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v499.clone();
                    let v500: i32 = *v500;
                    let v501: i32 = *v501;
                    let v502: i32 = *v502;
                    let v503: i32 = *v503;
                    let v504: i32 = *v504;
                    US11::US11_Error(v499, v500, v501, v502, v503, v504)
                }
                US12::US12_Ok(v470, v471, v472, v473, v474) => {
                    let v470: i32 = *v470;
                    let v471: i32 = *v471;
                    let v472: i32 = *v472;
                    let v473: i32 = *v473;
                    let v474: i32 = *v474;
                    let v475: bool = v470 >= v474;
                    let (mut v487, mut v488, mut v489, mut v490, mut v491): (i32, i32, i32, i32, i32) = if v475 {
                        (v470, v471, v472, v473, v474)
                    } else {
                        let v476: i32 = method61(v0.clone(), v1, v470);
                        let v477: bool = v476 > v474;
                        let mut v478: i32 = if v477 {
                            v474
                        } else {
                            v476
                        };
                        let v479: i32 = v478.wrapping_sub(v470);
                        let v480: bool = v479 == 0i32;
                        if v480 {
                            (v470, v471, v472, v473, v474)
                        } else {
                            let mut v481: i32 = v473.wrapping_add(v479);
                            (v478, v471, v472, v481, v474)
                        }
                    };
                    let v492: bool = v470 >= v487;
                    let v497: Rc<str> = if v492 {
                        let v493: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v493
                    } else {
                        let v495: i32 = v487.wrapping_sub(1i32);
                        let v496: Rc<str> = string_slice(&v0.clone(), v470 as i64, v495 as i64);
                        v496
                    };
                    US11::US11_Ok(v497, v487, v488, v489, v490, v491)
                }
            };
            let v526: US15 = match &v507 {
                US11::US11_Error(v517, v518, v519, v520, v521, v522) => {
                    let v517: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v517.clone();
                    let v518: i32 = *v518;
                    let v519: i32 = *v519;
                    let v520: i32 = *v520;
                    let v521: i32 = *v521;
                    let v522: i32 = *v522;
                    let v523: US14 = US14::US14_None;
                    US15::US15_Ok(v523, v443, v444, v445, v446, v447)
                }
                US11::US11_Ok(v508, v509, v510, v511, v512, v513) => {
                    let v508: Rc<str> = v508.clone();
                    let mut v509: i32 = *v509;
                    let v510: i32 = *v510;
                    let v511: i32 = *v511;
                    let v512: i32 = *v512;
                    let v513: i32 = *v513;
                    let v514: Rc<dyn Fn() -> Rc<str>> = closure31(v508);
                    let v515: US14 = US14::US14_Some(v514);
                    US15::US15_Ok(v515, v509, v510, v511, v512, v513)
                }
            };
            match &v526 {
                US15::US15_Error(v536, v537, v538, v539, v540, v541) => {
                    let v536: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v536.clone();
                    let v537: i32 = *v537;
                    let v538: i32 = *v538;
                    let v539: i32 = *v539;
                    let v540: i32 = *v540;
                    let v541: i32 = *v541;
                    US13::US13_Error(v536, v537, v538, v539, v540, v541)
                }
                US15::US15_Ok(v527, v528, v529, v530, v531, v532) => {
                    let v527: US14 = v527.clone();
                    let v528: i32 = *v528;
                    let v529: i32 = *v529;
                    let v530: i32 = *v530;
                    let v531: i32 = *v531;
                    let v532: i32 = *v532;
                    let v533: Rc<dyn Fn() -> Rc<str>> = closure32(v442);
                    let v534: Rc<dyn Fn() -> US14> = closure33(v527);
                    US13::US13_Ok(v533, v534, v528, v529, v530, v531, v532)
                }
            }
        }
    };
    let v570: US16 = match &v546 {
        US13::US13_Error(v561, v562, v563, v564, v565, v566) => {
            let v561: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v561.clone();
            let v562: i32 = *v562;
            let mut v563: i32 = *v563;
            let v564: i32 = *v564;
            let v565: i32 = *v565;
            let v566: i32 = *v566;
            let v567: Rc<dyn Fn() -> Rc<str>> = closure34(v0.clone(), v561, v562, v563, v564, v565, v566);
            US16::US16_Error(v567)
        }
        US13::US13_Ok(v547, v548, v549, v550, v551, v552, v553) => {
            let v547: Rc<dyn Fn() -> Rc<str>> = v547.clone();
            let v548: Rc<dyn Fn() -> US14> = v548.clone();
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
            US16::US16_Ok(v547, v548, v559, v550, v551, v552, v553)
        }
    };
    let v590: US17 = match &v570 {
        US16::US16_Error(v587) => {
            let v587: Rc<dyn Fn() -> Rc<str>> = v587.clone();
            US17::US17_Error(v587)
        }
        US16::US16_Ok(v571, v572, v573, v574, v575, v576, v577) => {
            let mut v571: Rc<dyn Fn() -> Rc<str>> = v571.clone();
            let mut v572: Rc<dyn Fn() -> US14> = v572.clone();
            let v573: Rc<str> = v573.clone();
            let v574: i32 = *v574;
            let v575: i32 = *v575;
            let v576: i32 = *v576;
            let v577: i32 = *v577;
            let v578: Rc<str> = v571();
            let v579: US14 = v572();
            let v585: US4 = match &v579 {
                US14::US14_None => {
                    US4::US4_None
                }
                US14::US14_Some(v580) => {
                    let mut v580: Rc<dyn Fn() -> Rc<str>> = v580.clone();
                    let v581: Rc<str> = v580();
                    US4::US4_Some(v581)
                }
            };
            US17::US17_Ok(v578, v585)
        }
    };
    match &v590 {
        US17::US17_Error(v594) => {
            let mut v594: Rc<dyn Fn() -> Rc<str>> = v594.clone();
            let v595: Rc<str> = v594();
            US9::US9_Error(v595)
        }
        US17::US17_Ok(v591, v592) => {
            let mut v591: Rc<str> = v591.clone();
            let v592: US4 = v592.clone();
            US9::US9_Ok(v591, v592)
        }
    }
}
fn closure35() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: u8 = b'\\';
        let mut v13: Rc<str> = format_real_5(v12);
        let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v13));
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v10));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v10));
        let v24: Rc<str> = format_real_60(v2);
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v15));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v10));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v10));
        let v34: Rc<str> = format_real_60(v3);
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v15));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v10));
        let v40: Rc<str> = format_real_60(v4);
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
        let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v43, v44)))), v15));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v47, v48)), v10));
        let v51: Rc<str> = format_real_60(v5);
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v50, v51)))), v44)))))), v44));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        v59.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure36() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method61(v0.clone(), v6, v1);
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
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method62(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: u8 = b'\\';
        let v39: Rc<str> = format_real_5(v38);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v39));
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v36));
        let mut v46: Rc<str> = format_real_60(v3);
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v41));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v36));
        let mut v52: Rc<str> = format_real_60(v4);
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
fn closure37() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: u8 = b'`';
        let mut v13: Rc<str> = format_real_5(v12);
        let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v13));
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v16, v17)), v10));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let v23: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v21)), v10));
        let v24: Rc<str> = format_real_60(v2);
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v15));
        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v10));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v10));
        let v34: Rc<str> = format_real_60(v3);
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v15));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v10));
        let v40: Rc<str> = format_real_60(v4);
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
        let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v43, v44)))), v15));
        let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v47, v48)), v10));
        let v51: Rc<str> = format_real_60(v5);
        let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v19, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, Rc::<str>::from(format!("{}{}", v50, v51)))), v44)))))), v44));
        let v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", v58, v57));
        v59.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure38() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method61(v0.clone(), v6, v1);
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
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method62(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected = "); } LIT.with(|lit| lit.clone()) };
        let mut v38: u8 = b'`';
        let v39: Rc<str> = format_real_5(v38);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v39));
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v36));
        let mut v46: Rc<str> = format_real_60(v3);
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v41));
        let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v36));
        let mut v52: Rc<str> = format_real_60(v4);
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
fn method69(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: Rc<str>, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> (i32, i32, i32, i32, i32) {
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
fn closure39() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("i"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("i"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("i = "); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = format_real_60(v1);
        let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
        let v18: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v15, v16)), v10));
        let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
        let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v19, v20)), v10));
        let v23: Rc<str> = format_real_60(v2);
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v14));
        let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v10));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v10));
        let mut v33: Rc<str> = format_real_60(v3);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v10));
        let v39: Rc<str> = format_real_60(v4);
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
        let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", v42, v43)))), v14));
        let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v46, v47)), v10));
        let v50: Rc<str> = format_real_60(v5);
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v41, Rc::<str>::from(format!("{}{}", v18, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v41, Rc::<str>::from(format!("{}{}", v49, v50)))), v43)))))), v43));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_satisfy / no matching char / "); } LIT.with(|lit| lit.clone()) };
        let v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57, v56));
        v58.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure40() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v6.borrow_mut().push(b'"');
        let mut v7: Rc<Vec<u8>> = Rc::new(v6.borrow().clone());
        let mut v8: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
        let mut v9: Rc<str> = method63(v8.clone());
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
        let mut v26: Rc<str> = format_real_60(v2);
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v17));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v14));
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = format_real_60(v3);
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v17));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v14));
        let mut v42: Rc<str> = format_real_60(v4);
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, Rc::<str>::from(format!("{}{}", v45, v46)))), v17));
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v14));
        let v53: Rc<str> = format_real_60(v5);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v52, v53)))), v46)))))), v46));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        v61.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure41() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method63(v9.clone());
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char = "); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = format_real_5(v6);
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
        let mut v33: Rc<str> = format_real_60(v2);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v19));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v15));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v39, v40)), v15));
        let v43: Rc<str> = format_real_60(v3);
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v19));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v15));
        let mut v49: Rc<str> = format_real_60(v4);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, Rc::<str>::from(format!("{}{}", v52, v53)))), v19));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v56, v57)), v15));
        let v60: Rc<str> = format_real_60(v5);
        let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v59, v60)))), v53)))))), v53));
        let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v66));
        v68.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure42() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many_strings / first inner parser consumed no text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure43() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many_strings / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method70(mut v0: Rc<str>, mut v1: Rc<RefCell<std::string::String>>, mut v2: Rc<RefCell<std::string::String>>, mut v3: Rc<str>, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> US11 {
    loop {
        let (mut v10, mut v11, mut v12, mut v13, mut v14): (i32, i32, i32, i32, i32) = method69(v6, v7, v8, v9, v0.clone(), v5, v6, v7, v8, v9);
        let v15: bool = v10 > v5;
        let mut v25: US11 = if v15 {
            let mut v16: bool = v5 >= v10;
            let v21: Rc<str> = if v16 {
                let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v17.clone()
            } else {
                let v19: i32 = v10.wrapping_sub(1i32);
                let mut v20: Rc<str> = string_slice(&v0.clone(), v5 as i64, v19 as i64);
                v20.clone()
            };
            US11::US11_Ok(v21.clone(), v10, v11, v12, v13, v14)
        } else {
            let v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
            US11::US11_Error(v23.clone(), v5, v6, v7, v8, v9)
        };
        let v220: US11 = match &v25 {
            US11::US11_Error(v32, v33, v34, v35, v36, v37) => {
                let mut v32: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v32.clone();
                let mut v33: i32 = *v33;
                let v34: i32 = *v34;
                let mut v35: i32 = *v35;
                let v36: i32 = *v36;
                let v37: i32 = *v37;
                let mut v38: bool = v5 >= v9;
                let v56: US10 = if v38 {
                    let v39: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                    US10::US10_Error(v39.clone(), v5, v6, v7, v8, v9)
                } else {
                    let mut v41: u8 = v0.clone().as_bytes()[v5 as usize];
                    let mut v42: bool = v41 == b'\\';
                    if v42 {
                        let v43: i32 = v5.wrapping_add(1i32);
                        let v44: bool = b'\n' == v41;
                        let (mut v48, mut v49, mut v50, mut v51): (i32, i32, i32, i32) = if v44 {
                            let mut v45: i32 = v6.wrapping_add(v8);
                            let mut v46: i32 = v7.wrapping_add(1i32);
                            (v45, v46, 1i32, v9)
                        } else {
                            let mut v47: i32 = v8.wrapping_add(1i32);
                            (v6, v7, v47, v9)
                        };
                        US10::US10_Ok(b'\\', v43, v48, v49, v50, v51)
                    } else {
                        let v53: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                        US10::US10_Error(v53.clone(), v5, v6, v7, v8, v9)
                    }
                };
                let v91: US10 = match &v56 {
                    US10::US10_Error(v83, v84, v85, v86, v87, v88) => {
                        let mut v83: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v83.clone();
                        let v84: i32 = *v84;
                        let v85: i32 = *v85;
                        let v86: i32 = *v86;
                        let mut v87: i32 = *v87;
                        let v88: i32 = *v88;
                        US10::US10_Error(v83.clone(), v84, v85, v86, v87, v88)
                    }
                    US10::US10_Ok(v57, v58, v59, v60, v61, v62) => {
                        let mut v57: u8 = *v57;
                        let v58: i32 = *v58;
                        let mut v59: i32 = *v59;
                        let v60: i32 = *v60;
                        let v61: i32 = *v61;
                        let v62: i32 = *v62;
                        let mut v63: bool = v58 >= v62;
                        if v63 {
                            let v64: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                            US10::US10_Error(v64.clone(), v58, v59, v60, v61, v62)
                        } else {
                            let v66: u8 = v0.clone().as_bytes()[v58 as usize];
                            let v67: bool = v66 == b'"';
                            let mut v68: bool = v67 == false;
                            if v68 {
                                let mut v69: i32 = v58.wrapping_add(1i32);
                                let mut v70: bool = b'\n' == v66;
                                let (mut v74, mut v75, mut v76, mut v77): (i32, i32, i32, i32) = if v70 {
                                    let mut v71: i32 = v59.wrapping_add(v61);
                                    let v72: i32 = v60.wrapping_add(1i32);
                                    (v71, v72, 1i32, v62)
                                } else {
                                    let mut v73: i32 = v61.wrapping_add(1i32);
                                    (v59, v60, v73, v62)
                                };
                                US10::US10_Ok(v66, v69, v74, v75, v76, v77)
                            } else {
                                let mut v79: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                US10::US10_Error(v79.clone(), v58, v59, v60, v61, v62)
                            }
                        }
                    }
                };
                let v113: US11 = match &v91 {
                    US10::US10_Error(v105, v106, v107, v108, v109, v110) => {
                        let mut v105: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v105.clone();
                        let mut v106: i32 = *v106;
                        let mut v107: i32 = *v107;
                        let mut v108: i32 = *v108;
                        let v109: i32 = *v109;
                        let mut v110: i32 = *v110;
                        US11::US11_Error(v105.clone(), v106, v107, v108, v109, v110)
                    }
                    US10::US10_Ok(v92, v93, v94, v95, v96, v97) => {
                        let v92: u8 = *v92;
                        let mut v93: i32 = *v93;
                        let v94: i32 = *v94;
                        let v95: i32 = *v95;
                        let v96: i32 = *v96;
                        let mut v97: i32 = *v97;
                        let mut v98: bool = v5 >= v93;
                        let mut v103: Rc<str> = if v98 {
                            let mut v99: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v99.clone()
                        } else {
                            let v101: i32 = v93.wrapping_sub(1i32);
                            let mut v102: Rc<str> = string_slice(&v0.clone(), v5 as i64, v101 as i64);
                            v102.clone()
                        };
                        US11::US11_Ok(v103.clone(), v93, v94, v95, v96, v97)
                    }
                };
                match &v113 {
                    US11::US11_Error(v120, v121, v122, v123, v124, v125) => {
                        let v120: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v120.clone();
                        let mut v121: i32 = *v121;
                        let mut v122: i32 = *v122;
                        let v123: i32 = *v123;
                        let mut v124: i32 = *v124;
                        let v125: i32 = *v125;
                        let mut v143: US10 = if v38 {
                            let v126: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                            US10::US10_Error(v126.clone(), v5, v6, v7, v8, v9)
                        } else {
                            let v128: u8 = v0.clone().as_bytes()[v5 as usize];
                            let v129: bool = v128 == b'`';
                            if v129 {
                                let mut v130: i32 = v5.wrapping_add(1i32);
                                let v131: bool = b'\n' == v128;
                                let (mut v135, mut v136, mut v137, mut v138): (i32, i32, i32, i32) = if v131 {
                                    let v132: i32 = v6.wrapping_add(v8);
                                    let mut v133: i32 = v7.wrapping_add(1i32);
                                    (v132, v133, 1i32, v9)
                                } else {
                                    let v134: i32 = v8.wrapping_add(1i32);
                                    (v6, v7, v134, v9)
                                };
                                US10::US10_Ok(b'`', v130, v135, v136, v137, v138)
                            } else {
                                let v140: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                US10::US10_Error(v140.clone(), v5, v6, v7, v8, v9)
                            }
                        };
                        let mut v178: US10 = match &v143 {
                            US10::US10_Error(v170, v171, v172, v173, v174, v175) => {
                                let v170: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v170.clone();
                                let v171: i32 = *v171;
                                let mut v172: i32 = *v172;
                                let mut v173: i32 = *v173;
                                let v174: i32 = *v174;
                                let mut v175: i32 = *v175;
                                US10::US10_Error(v170.clone(), v171, v172, v173, v174, v175)
                            }
                            US10::US10_Ok(v144, v145, v146, v147, v148, v149) => {
                                let mut v144: u8 = *v144;
                                let v145: i32 = *v145;
                                let v146: i32 = *v146;
                                let mut v147: i32 = *v147;
                                let mut v148: i32 = *v148;
                                let v149: i32 = *v149;
                                let mut v150: bool = v145 >= v149;
                                if v150 {
                                    let mut v151: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                    US10::US10_Error(v151.clone(), v145, v146, v147, v148, v149)
                                } else {
                                    let mut v153: u8 = v0.clone().as_bytes()[v145 as usize];
                                    let mut v154: bool = v153 == b'"';
                                    let mut v155: bool = v154 == false;
                                    if v155 {
                                        let mut v156: i32 = v145.wrapping_add(1i32);
                                        let mut v157: bool = b'\n' == v153;
                                        let (mut v161, mut v162, mut v163, mut v164): (i32, i32, i32, i32) = if v157 {
                                            let mut v158: i32 = v146.wrapping_add(v148);
                                            let v159: i32 = v147.wrapping_add(1i32);
                                            (v158, v159, 1i32, v149)
                                        } else {
                                            let mut v160: i32 = v148.wrapping_add(1i32);
                                            (v146, v147, v160, v149)
                                        };
                                        US10::US10_Ok(v153, v156, v161, v162, v163, v164)
                                    } else {
                                        let v166: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                        US10::US10_Error(v166.clone(), v145, v146, v147, v148, v149)
                                    }
                                }
                            }
                        };
                        let v200: US11 = match &v178 {
                            US10::US10_Error(v192, v193, v194, v195, v196, v197) => {
                                let v192: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v192.clone();
                                let v193: i32 = *v193;
                                let v194: i32 = *v194;
                                let v195: i32 = *v195;
                                let v196: i32 = *v196;
                                let v197: i32 = *v197;
                                US11::US11_Error(v192.clone(), v193, v194, v195, v196, v197)
                            }
                            US10::US10_Ok(v179, v180, v181, v182, v183, v184) => {
                                let v179: u8 = *v179;
                                let v180: i32 = *v180;
                                let v181: i32 = *v181;
                                let v182: i32 = *v182;
                                let v183: i32 = *v183;
                                let v184: i32 = *v184;
                                let v185: bool = v5 >= v180;
                                let v190: Rc<str> = if v185 {
                                    let v186: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v186.clone()
                                } else {
                                    let v188: i32 = v180.wrapping_sub(1i32);
                                    let v189: Rc<str> = string_slice(&v0.clone(), v5 as i64, v188 as i64);
                                    v189.clone()
                                };
                                US11::US11_Ok(v190.clone(), v180, v181, v182, v183, v184)
                            }
                        };
                        match &v200 {
                            US11::US11_Error(v207, v208, v209, v210, v211, v212) => {
                                let v207: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v207.clone();
                                let mut v208: i32 = *v208;
                                let mut v209: i32 = *v209;
                                let v210: i32 = *v210;
                                let mut v211: i32 = *v211;
                                let v212: i32 = *v212;
                                let mut v213: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                US11::US11_Error(v213.clone(), v5, v6, v7, v8, v9)
                            }
                            US11::US11_Ok(v201, v202, v203, v204, v205, v206) => {
                                let mut v201: Rc<str> = v201.clone();
                                let v202: i32 = *v202;
                                let v203: i32 = *v203;
                                let v204: i32 = *v204;
                                let v205: i32 = *v205;
                                let mut v206: i32 = *v206;
                                v200.clone()
                            }
                        }
                    }
                    US11::US11_Ok(v114, v115, v116, v117, v118, v119) => {
                        let v114: Rc<str> = v114.clone();
                        let v115: i32 = *v115;
                        let mut v116: i32 = *v116;
                        let v117: i32 = *v117;
                        let v118: i32 = *v118;
                        let mut v119: i32 = *v119;
                        v113.clone()
                    }
                }
            }
            US11::US11_Ok(v26, v27, v28, v29, v30, v31) => {
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
            US11::US11_Error(v221, v222, v223, v224, v225, v226) => {
                let mut v221: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v221.clone();
                let mut v222: i32 = *v222;
                let v223: i32 = *v223;
                let v224: i32 = *v224;
                let mut v225: i32 = *v225;
                let mut v226: i32 = *v226;
                let v227: bool = v4 == 0i32;
                let v229: Rc<str> = if v227 {
                    v3.clone()
                } else {
                    let mut v228: Rc<str> = Rc::<str>::from(v1.borrow().as_str());
                    v228.clone()
                };
                return US11::US11_Ok(v229.clone(), v5, v6, v7, v8, v9);
            }
            US11::US11_Ok(v231, v232, v233, v234, v235, v236) => {
                let v231: Rc<str> = v231.clone();
                let v232: i32 = *v232;
                let v233: i32 = *v233;
                let v234: i32 = *v234;
                let v235: i32 = *v235;
                let v236: i32 = *v236;
                let mut v237: bool = v232 > v5;
                if v237 {
                    let v238: bool = v4 == 0i32;
                    if v238 {
                        v2.borrow_mut().push_str(&*v3);
                        ()
                    };
                    v2.borrow_mut().push_str(&*v231);
                    let mut v239: i32 = v4.wrapping_add(1i32);
                    (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v239, v232, v233, v234, v235, v236);
                    continue;
                } else {
                    let v241: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                    return US11::US11_Error(v241.clone(), v5, v6, v7, v8, v9);
                }
            }
        }
    }
}
fn closure44() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
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
        let mut v16: Rc<str> = format_real_60(v2);
        let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
        let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
        let v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v19, v20)), v10));
        let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v23, v24)), v10));
        let mut v27: Rc<str> = format_real_60(v3);
        let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v26, v27)), v18));
        let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v29, v30)), v10));
        let mut v33: Rc<str> = format_real_60(v4);
        let v34: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v33));
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
        let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, Rc::<str>::from(format!("{}{}", v36, v37)))), v18));
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v40, v41)), v10));
        let v44: Rc<str> = format_real_60(v5);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, Rc::<str>::from(format!("{}{}", v11, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, Rc::<str>::from(format!("{}{}", v43, v44)))), v37)))))), v37));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.any_char / unexpected end of t / "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        v52.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method71(mut v0: Rc<str>, mut v1: Rc<RefCell<std::string::String>>, mut v2: Rc<RefCell<std::string::String>>, mut v3: Rc<str>, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> US11 {
    loop {
        let (mut v10, mut v11, mut v12, mut v13, mut v14): (i32, i32, i32, i32, i32) = method69(v6, v7, v8, v9, v0.clone(), v5, v6, v7, v8, v9);
        let v15: bool = v10 > v5;
        let mut v25: US11 = if v15 {
            let mut v16: bool = v5 >= v10;
            let v21: Rc<str> = if v16 {
                let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v17.clone()
            } else {
                let v19: i32 = v10.wrapping_sub(1i32);
                let mut v20: Rc<str> = string_slice(&v0.clone(), v5 as i64, v19 as i64);
                v20.clone()
            };
            US11::US11_Ok(v21.clone(), v10, v11, v12, v13, v14)
        } else {
            let v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
            US11::US11_Error(v23.clone(), v5, v6, v7, v8, v9)
        };
        let v210: US11 = match &v25 {
            US11::US11_Error(v32, v33, v34, v35, v36, v37) => {
                let mut v32: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v32.clone();
                let mut v33: i32 = *v33;
                let v34: i32 = *v34;
                let mut v35: i32 = *v35;
                let v36: i32 = *v36;
                let v37: i32 = *v37;
                let mut v38: bool = v5 >= v9;
                let v56: US10 = if v38 {
                    let v39: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                    US10::US10_Error(v39.clone(), v5, v6, v7, v8, v9)
                } else {
                    let mut v41: u8 = v0.clone().as_bytes()[v5 as usize];
                    let mut v42: bool = v41 == b'\\';
                    if v42 {
                        let v43: i32 = v5.wrapping_add(1i32);
                        let v44: bool = b'\n' == v41;
                        let (mut v48, mut v49, mut v50, mut v51): (i32, i32, i32, i32) = if v44 {
                            let mut v45: i32 = v6.wrapping_add(v8);
                            let mut v46: i32 = v7.wrapping_add(1i32);
                            (v45, v46, 1i32, v9)
                        } else {
                            let mut v47: i32 = v8.wrapping_add(1i32);
                            (v6, v7, v47, v9)
                        };
                        US10::US10_Ok(b'\\', v43, v48, v49, v50, v51)
                    } else {
                        let v53: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                        US10::US10_Error(v53.clone(), v5, v6, v7, v8, v9)
                    }
                };
                let v86: US10 = match &v56 {
                    US10::US10_Error(v78, v79, v80, v81, v82, v83) => {
                        let mut v78: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v78.clone();
                        let mut v79: i32 = *v79;
                        let mut v80: i32 = *v80;
                        let mut v81: i32 = *v81;
                        let mut v82: i32 = *v82;
                        let mut v83: i32 = *v83;
                        US10::US10_Error(v78.clone(), v79, v80, v81, v82, v83)
                    }
                    US10::US10_Ok(v57, v58, v59, v60, v61, v62) => {
                        let mut v57: u8 = *v57;
                        let v58: i32 = *v58;
                        let mut v59: i32 = *v59;
                        let v60: i32 = *v60;
                        let v61: i32 = *v61;
                        let v62: i32 = *v62;
                        let mut v63: bool = v58 >= v62;
                        if v63 {
                            let v64: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                            US10::US10_Error(v64.clone(), v58, v59, v60, v61, v62)
                        } else {
                            let v66: u8 = v0.clone().as_bytes()[v58 as usize];
                            let v67: i32 = v58.wrapping_add(1i32);
                            let mut v68: bool = b'\n' == v66;
                            let (mut v72, mut v73, mut v74, mut v75): (i32, i32, i32, i32) = if v68 {
                                let mut v69: i32 = v59.wrapping_add(v61);
                                let mut v70: i32 = v60.wrapping_add(1i32);
                                (v69, v70, 1i32, v62)
                            } else {
                                let mut v71: i32 = v61.wrapping_add(1i32);
                                (v59, v60, v71, v62)
                            };
                            US10::US10_Ok(v66, v67, v72, v73, v74, v75)
                        }
                    }
                };
                let mut v108: US11 = match &v86 {
                    US10::US10_Error(v100, v101, v102, v103, v104, v105) => {
                        let v100: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v100.clone();
                        let v101: i32 = *v101;
                        let mut v102: i32 = *v102;
                        let mut v103: i32 = *v103;
                        let v104: i32 = *v104;
                        let mut v105: i32 = *v105;
                        US11::US11_Error(v100.clone(), v101, v102, v103, v104, v105)
                    }
                    US10::US10_Ok(v87, v88, v89, v90, v91, v92) => {
                        let mut v87: u8 = *v87;
                        let v88: i32 = *v88;
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
                            let mut v97: Rc<str> = string_slice(&v0.clone(), v5 as i64, v96 as i64);
                            v97.clone()
                        };
                        US11::US11_Ok(v98.clone(), v88, v89, v90, v91, v92)
                    }
                };
                match &v108 {
                    US11::US11_Error(v115, v116, v117, v118, v119, v120) => {
                        let v115: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v115.clone();
                        let mut v116: i32 = *v116;
                        let v117: i32 = *v117;
                        let v118: i32 = *v118;
                        let mut v119: i32 = *v119;
                        let v120: i32 = *v120;
                        let v138: US10 = if v38 {
                            let mut v121: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                            US10::US10_Error(v121.clone(), v5, v6, v7, v8, v9)
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
                                US10::US10_Ok(b'`', v125, v130, v131, v132, v133)
                            } else {
                                let v135: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                US10::US10_Error(v135.clone(), v5, v6, v7, v8, v9)
                            }
                        };
                        let v168: US10 = match &v138 {
                            US10::US10_Error(v160, v161, v162, v163, v164, v165) => {
                                let mut v160: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v160.clone();
                                let v161: i32 = *v161;
                                let v162: i32 = *v162;
                                let mut v163: i32 = *v163;
                                let v164: i32 = *v164;
                                let v165: i32 = *v165;
                                US10::US10_Error(v160.clone(), v161, v162, v163, v164, v165)
                            }
                            US10::US10_Ok(v139, v140, v141, v142, v143, v144) => {
                                let v139: u8 = *v139;
                                let v140: i32 = *v140;
                                let v141: i32 = *v141;
                                let v142: i32 = *v142;
                                let mut v143: i32 = *v143;
                                let mut v144: i32 = *v144;
                                let v145: bool = v140 >= v144;
                                if v145 {
                                    let v146: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                    US10::US10_Error(v146.clone(), v140, v141, v142, v143, v144)
                                } else {
                                    let mut v148: u8 = v0.clone().as_bytes()[v140 as usize];
                                    let v149: i32 = v140.wrapping_add(1i32);
                                    let mut v150: bool = b'\n' == v148;
                                    let (mut v154, mut v155, mut v156, mut v157): (i32, i32, i32, i32) = if v150 {
                                        let mut v151: i32 = v141.wrapping_add(v143);
                                        let mut v152: i32 = v142.wrapping_add(1i32);
                                        (v151, v152, 1i32, v144)
                                    } else {
                                        let mut v153: i32 = v143.wrapping_add(1i32);
                                        (v141, v142, v153, v144)
                                    };
                                    US10::US10_Ok(v148, v149, v154, v155, v156, v157)
                                }
                            }
                        };
                        let v190: US11 = match &v168 {
                            US10::US10_Error(v182, v183, v184, v185, v186, v187) => {
                                let v182: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v182.clone();
                                let v183: i32 = *v183;
                                let v184: i32 = *v184;
                                let v185: i32 = *v185;
                                let v186: i32 = *v186;
                                let mut v187: i32 = *v187;
                                US11::US11_Error(v182.clone(), v183, v184, v185, v186, v187)
                            }
                            US10::US10_Ok(v169, v170, v171, v172, v173, v174) => {
                                let v169: u8 = *v169;
                                let v170: i32 = *v170;
                                let v171: i32 = *v171;
                                let mut v172: i32 = *v172;
                                let mut v173: i32 = *v173;
                                let v174: i32 = *v174;
                                let mut v175: bool = v5 >= v170;
                                let v180: Rc<str> = if v175 {
                                    let mut v176: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v176.clone()
                                } else {
                                    let mut v178: i32 = v170.wrapping_sub(1i32);
                                    let v179: Rc<str> = string_slice(&v0.clone(), v5 as i64, v178 as i64);
                                    v179.clone()
                                };
                                US11::US11_Ok(v180.clone(), v170, v171, v172, v173, v174)
                            }
                        };
                        match &v190 {
                            US11::US11_Error(v197, v198, v199, v200, v201, v202) => {
                                let v197: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v197.clone();
                                let v198: i32 = *v198;
                                let v199: i32 = *v199;
                                let v200: i32 = *v200;
                                let mut v201: i32 = *v201;
                                let v202: i32 = *v202;
                                let v203: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                US11::US11_Error(v203.clone(), v5, v6, v7, v8, v9)
                            }
                            US11::US11_Ok(v191, v192, v193, v194, v195, v196) => {
                                let mut v191: Rc<str> = v191.clone();
                                let v192: i32 = *v192;
                                let v193: i32 = *v193;
                                let v194: i32 = *v194;
                                let v195: i32 = *v195;
                                let v196: i32 = *v196;
                                v190.clone()
                            }
                        }
                    }
                    US11::US11_Ok(v109, v110, v111, v112, v113, v114) => {
                        let v109: Rc<str> = v109.clone();
                        let mut v110: i32 = *v110;
                        let v111: i32 = *v111;
                        let v112: i32 = *v112;
                        let v113: i32 = *v113;
                        let v114: i32 = *v114;
                        v108.clone()
                    }
                }
            }
            US11::US11_Ok(v26, v27, v28, v29, v30, v31) => {
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
            US11::US11_Error(v211, v212, v213, v214, v215, v216) => {
                let mut v211: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v211.clone();
                let v212: i32 = *v212;
                let mut v213: i32 = *v213;
                let v214: i32 = *v214;
                let v215: i32 = *v215;
                let mut v216: i32 = *v216;
                let v217: bool = v4 == 0i32;
                let v219: Rc<str> = if v217 {
                    v3.clone()
                } else {
                    let mut v218: Rc<str> = Rc::<str>::from(v1.borrow().as_str());
                    v218.clone()
                };
                return US11::US11_Ok(v219.clone(), v5, v6, v7, v8, v9);
            }
            US11::US11_Ok(v221, v222, v223, v224, v225, v226) => {
                let mut v221: Rc<str> = v221.clone();
                let mut v222: i32 = *v222;
                let v223: i32 = *v223;
                let v224: i32 = *v224;
                let mut v225: i32 = *v225;
                let mut v226: i32 = *v226;
                let v227: bool = v222 > v5;
                if v227 {
                    let mut v228: bool = v4 == 0i32;
                    if v228 {
                        v2.borrow_mut().push_str(&*v3);
                        ()
                    };
                    v2.borrow_mut().push_str(&*v221);
                    let v229: i32 = v4.wrapping_add(1i32);
                    (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0.clone(), v1.clone(), v2.clone(), v3.clone(), v229, v222, v223, v224, v225, v226);
                    continue;
                } else {
                    let v231: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                    return US11::US11_Error(v231.clone(), v5, v6, v7, v8, v9);
                }
            }
        }
    }
}
fn method72(mut v0: i32, mut v1: Rc<str>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> (i32, i32, i32, i32, i32) {
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
fn closure45() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v6.borrow_mut().push(b'\\');
        v6.borrow_mut().push(b'`');
        v6.borrow_mut().push(b'"');
        let mut v7: Rc<Vec<u8>> = Rc::new(v6.borrow().clone());
        let mut v8: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
        let mut v9: Rc<str> = method63(v8.clone());
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
        let mut v26: Rc<str> = format_real_60(v2);
        let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v25, v26)), v17));
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v28, v29)), v14));
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v14));
        let v36: Rc<str> = format_real_60(v3);
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v17));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v14));
        let mut v42: Rc<str> = format_real_60(v4);
        let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v42));
        let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v43));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, Rc::<str>::from(format!("{}{}", v45, v46)))), v17));
        let v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v49, v50)), v14));
        let v53: Rc<str> = format_real_60(v5);
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v44, Rc::<str>::from(format!("{}{}", v52, v53)))), v46)))))), v46));
        let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let v61: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v59));
        v61.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure46() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'\\');
        v7.borrow_mut().push(b'`');
        v7.borrow_mut().push(b'"');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method63(v9.clone());
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
        let v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char = "); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = format_real_5(v6);
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
        let mut v33: Rc<str> = format_real_60(v2);
        let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v32, v33)), v19));
        let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v35, v36)), v15));
        let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v39, v40)), v15));
        let v43: Rc<str> = format_real_60(v3);
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v42, v43)), v19));
        let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
        let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v45, v46)), v15));
        let mut v49: Rc<str> = format_real_60(v4);
        let v50: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v49));
        let v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
        let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51, v50));
        let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
        let v56: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, Rc::<str>::from(format!("{}{}", v52, v53)))), v19));
        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
        let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v56, v57)), v15));
        let v60: Rc<str> = format_real_60(v5);
        let v66: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v28, Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, Rc::<str>::from(format!("{}{}", v59, v60)))), v53)))))), v53));
        let v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v66));
        v68.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method74(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
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
fn closure47() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method73(mut v0: Rc<str>, mut v1: Rc<UH0>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US19 {
    loop {
        let mut v7: bool = v2 >= v6;
        let mut v25: US10 = if v7 {
            let mut v8: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
            US10::US10_Error(v8.clone(), v2, v3, v4, v5, v6)
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
                US10::US10_Ok(b'\\', v12, v17, v18, v19, v20)
            } else {
                let mut v22: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                US10::US10_Error(v22.clone(), v2, v3, v4, v5, v6)
            }
        };
        let v55: US10 = match &v25 {
            US10::US10_Error(v47, v48, v49, v50, v51, v52) => {
                let mut v47: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v47.clone();
                let mut v48: i32 = *v48;
                let mut v49: i32 = *v49;
                let v50: i32 = *v50;
                let v51: i32 = *v51;
                let mut v52: i32 = *v52;
                US10::US10_Error(v47.clone(), v48, v49, v50, v51, v52)
            }
            US10::US10_Ok(v26, v27, v28, v29, v30, v31) => {
                let mut v26: u8 = *v26;
                let mut v27: i32 = *v27;
                let mut v28: i32 = *v28;
                let mut v29: i32 = *v29;
                let v30: i32 = *v30;
                let mut v31: i32 = *v31;
                let mut v32: bool = v27 >= v31;
                if v32 {
                    let mut v33: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                    US10::US10_Error(v33.clone(), v27, v28, v29, v30, v31)
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
                    US10::US10_Ok(v35, v36, v41, v42, v43, v44)
                }
            }
        };
        let mut v77: US11 = match &v55 {
            US10::US10_Error(v69, v70, v71, v72, v73, v74) => {
                let mut v69: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v69.clone();
                let mut v70: i32 = *v70;
                let mut v71: i32 = *v71;
                let v72: i32 = *v72;
                let mut v73: i32 = *v73;
                let mut v74: i32 = *v74;
                US11::US11_Error(v69.clone(), v70, v71, v72, v73, v74)
            }
            US10::US10_Ok(v56, v57, v58, v59, v60, v61) => {
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
                US11::US11_Ok(v67.clone(), v57, v58, v59, v60, v61)
            }
        };
        let v177: US11 = match &v77 {
            US11::US11_Error(v84, v85, v86, v87, v88, v89) => {
                let v84: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v84.clone();
                let v85: i32 = *v85;
                let v86: i32 = *v86;
                let mut v87: i32 = *v87;
                let v88: i32 = *v88;
                let v89: i32 = *v89;
                let mut v107: US10 = if v7 {
                    let v90: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                    US10::US10_Error(v90.clone(), v2, v3, v4, v5, v6)
                } else {
                    let v92: u8 = v0.clone().as_bytes()[v2 as usize];
                    let mut v93: bool = v92 == b'`';
                    if v93 {
                        let v94: i32 = v2.wrapping_add(1i32);
                        let v95: bool = b'\n' == v92;
                        let (mut v99, mut v100, mut v101, mut v102): (i32, i32, i32, i32) = if v95 {
                            let v96: i32 = v3.wrapping_add(v5);
                            let mut v97: i32 = v4.wrapping_add(1i32);
                            (v96, v97, 1i32, v6)
                        } else {
                            let mut v98: i32 = v5.wrapping_add(1i32);
                            (v3, v4, v98, v6)
                        };
                        US10::US10_Ok(b'`', v94, v99, v100, v101, v102)
                    } else {
                        let v104: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                        US10::US10_Error(v104.clone(), v2, v3, v4, v5, v6)
                    }
                };
                let v137: US10 = match &v107 {
                    US10::US10_Error(v129, v130, v131, v132, v133, v134) => {
                        let v129: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v129.clone();
                        let mut v130: i32 = *v130;
                        let v131: i32 = *v131;
                        let v132: i32 = *v132;
                        let mut v133: i32 = *v133;
                        let v134: i32 = *v134;
                        US10::US10_Error(v129.clone(), v130, v131, v132, v133, v134)
                    }
                    US10::US10_Ok(v108, v109, v110, v111, v112, v113) => {
                        let mut v108: u8 = *v108;
                        let v109: i32 = *v109;
                        let mut v110: i32 = *v110;
                        let v111: i32 = *v111;
                        let v112: i32 = *v112;
                        let v113: i32 = *v113;
                        let v114: bool = v109 >= v113;
                        if v114 {
                            let v115: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                            US10::US10_Error(v115.clone(), v109, v110, v111, v112, v113)
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
                            US10::US10_Ok(v117, v118, v123, v124, v125, v126)
                        }
                    }
                };
                let v159: US11 = match &v137 {
                    US10::US10_Error(v151, v152, v153, v154, v155, v156) => {
                        let mut v151: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v151.clone();
                        let mut v152: i32 = *v152;
                        let mut v153: i32 = *v153;
                        let mut v154: i32 = *v154;
                        let mut v155: i32 = *v155;
                        let mut v156: i32 = *v156;
                        US11::US11_Error(v151.clone(), v152, v153, v154, v155, v156)
                    }
                    US10::US10_Ok(v138, v139, v140, v141, v142, v143) => {
                        let v138: u8 = *v138;
                        let v139: i32 = *v139;
                        let v140: i32 = *v140;
                        let v141: i32 = *v141;
                        let v142: i32 = *v142;
                        let mut v143: i32 = *v143;
                        let mut v144: bool = v2 >= v139;
                        let v149: Rc<str> = if v144 {
                            let v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v145.clone()
                        } else {
                            let mut v147: i32 = v139.wrapping_sub(1i32);
                            let mut v148: Rc<str> = string_slice(&v0.clone(), v2 as i64, v147 as i64);
                            v148.clone()
                        };
                        US11::US11_Ok(v149.clone(), v139, v140, v141, v142, v143)
                    }
                };
                match &v159 {
                    US11::US11_Error(v166, v167, v168, v169, v170, v171) => {
                        let v166: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v166.clone();
                        let mut v167: i32 = *v167;
                        let v168: i32 = *v168;
                        let v169: i32 = *v169;
                        let v170: i32 = *v170;
                        let v171: i32 = *v171;
                        let mut v172: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                        US11::US11_Error(v172.clone(), v2, v3, v4, v5, v6)
                    }
                    US11::US11_Ok(v160, v161, v162, v163, v164, v165) => {
                        let mut v160: Rc<str> = v160.clone();
                        let v161: i32 = *v161;
                        let v162: i32 = *v162;
                        let mut v163: i32 = *v163;
                        let v164: i32 = *v164;
                        let v165: i32 = *v165;
                        v159.clone()
                    }
                }
            }
            US11::US11_Ok(v78, v79, v80, v81, v82, v83) => {
                let mut v78: Rc<str> = v78.clone();
                let mut v79: i32 = *v79;
                let mut v80: i32 = *v80;
                let mut v81: i32 = *v81;
                let mut v82: i32 = *v82;
                let mut v83: i32 = *v83;
                v77.clone()
            }
        };
        let v194: US11 = match &v177 {
            US11::US11_Error(v186, v187, v188, v189, v190, v191) => {
                let v186: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v186.clone();
                let mut v187: i32 = *v187;
                let v188: i32 = *v188;
                let v189: i32 = *v189;
                let v190: i32 = *v190;
                let mut v191: i32 = *v191;
                US11::US11_Error(v186.clone(), v187, v188, v189, v190, v191)
            }
            US11::US11_Ok(v178, v179, v180, v181, v182, v183) => {
                let mut v178: Rc<str> = v178.clone();
                let v179: i32 = *v179;
                let v180: i32 = *v180;
                let v181: i32 = *v181;
                let v182: i32 = *v182;
                let v183: i32 = *v183;
                let v184: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                US11::US11_Ok(v184.clone(), v179, v180, v181, v182, v183)
            }
        };
        let v250: US11 = match &v194 {
            US11::US11_Error(v242, v243, v244, v245, v246, v247) => {
                let v242: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v242.clone();
                let v243: i32 = *v243;
                let mut v244: i32 = *v244;
                let v245: i32 = *v245;
                let v246: i32 = *v246;
                let v247: i32 = *v247;
                US11::US11_Error(v242.clone(), v243, v244, v245, v246, v247)
            }
            US11::US11_Ok(v195, v196, v197, v198, v199, v200) => {
                let v195: Rc<str> = v195.clone();
                let v196: i32 = *v196;
                let v197: i32 = *v197;
                let v198: i32 = *v198;
                let v199: i32 = *v199;
                let v200: i32 = *v200;
                let mut v201: bool = v196 >= v200;
                let v224: US10 = if v201 {
                    let v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure45();
                    US10::US10_Error(v202.clone(), v196, v197, v198, v199, v200)
                } else {
                    let v204: u8 = v0.clone().as_bytes()[v196 as usize];
                    let v205: bool = v204 == b'\\';
                    let mut v209: bool = if v205 {
                        true
                    } else {
                        let mut v206: bool = v204 == b'`';
                        if v206 {
                            true
                        } else {
                            let v207: bool = v204 == b'"';
                            v207
                        }
                    };
                    let v210: bool = v209 == false;
                    if v210 {
                        let mut v211: i32 = v196.wrapping_add(1i32);
                        let v212: bool = b'\n' == v204;
                        let (mut v216, mut v217, mut v218, mut v219): (i32, i32, i32, i32) = if v212 {
                            let mut v213: i32 = v197.wrapping_add(v199);
                            let v214: i32 = v198.wrapping_add(1i32);
                            (v213, v214, 1i32, v200)
                        } else {
                            let v215: i32 = v199.wrapping_add(1i32);
                            (v197, v198, v215, v200)
                        };
                        US10::US10_Ok(v204, v211, v216, v217, v218, v219)
                    } else {
                        let mut v221: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure46();
                        US10::US10_Error(v221.clone(), v196, v197, v198, v199, v200)
                    }
                };
                match &v224 {
                    US10::US10_Error(v233, v234, v235, v236, v237, v238) => {
                        let v233: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v233.clone();
                        let v234: i32 = *v234;
                        let v235: i32 = *v235;
                        let v236: i32 = *v236;
                        let mut v237: i32 = *v237;
                        let v238: i32 = *v238;
                        US11::US11_Error(v233.clone(), v234, v235, v236, v237, v238)
                    }
                    US10::US10_Ok(v225, v226, v227, v228, v229, v230) => {
                        let mut v225: u8 = *v225;
                        let mut v226: i32 = *v226;
                        let v227: i32 = *v227;
                        let mut v228: i32 = *v228;
                        let v229: i32 = *v229;
                        let v230: i32 = *v230;
                        let v231: Rc<str> = Rc::<str>::from((v225 as char).encode_utf8(&mut [0u8; 4]) as &str);
                        US11::US11_Ok(v231.clone(), v226, v227, v228, v229, v230)
                    }
                }
            }
        };
        match &v250 {
            US11::US11_Error(v251, v252, v253, v254, v255, v256) => {
                let v251: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v251.clone();
                let v252: i32 = *v252;
                let v253: i32 = *v253;
                let v254: i32 = *v254;
                let mut v255: i32 = *v255;
                let v256: i32 = *v256;
                let v257: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                let v258: Rc<UH0> = method74(v1.clone(), v257.clone());
                return US19::US19_Ok(v258.clone(), v2, v3, v4, v5, v6);
            }
            US11::US11_Ok(v260, v261, v262, v263, v264, v265) => {
                let mut v260: Rc<str> = v260.clone();
                let v261: i32 = *v261;
                let v262: i32 = *v262;
                let v263: i32 = *v263;
                let v264: i32 = *v264;
                let v265: i32 = *v265;
                let v266: bool = v261 > v2;
                if v266 {
                    let v267: Rc<UH0> = Rc::new(UH0::UH0_Cons(v260.clone(), v1.clone()));
                    (v0, v1, v2, v3, v4, v5, v6) = (v0.clone(), v267.clone(), v261, v262, v263, v264, v265);
                    continue;
                } else {
                    let v269: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                    return US19::US19_Error(v269.clone(), v2, v3, v4, v5, v6);
                }
            }
        }
    }
}
fn method75(mut v0: Rc<UH0>, mut v1: Rc<str>, mut v2: Rc<str>) -> (Rc<str>, Rc<str>) {
    let (mut v12, mut v13): (Rc<str>, Rc<str>) = match &*v0 {
        UH0::UH0_Cons(v3, v4) => {
            let mut v3: Rc<str> = v3.clone();
            let mut v4: Rc<UH0> = v4.clone();
            let (mut v5, mut v6): (Rc<str>, Rc<str>) = method75(v4, v1.clone(), v2.clone());
            let mut v8: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v3, v6)), v5));
            let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            (v8, v9)
        }
        _ => {
            let (mut v10, mut v11): (Rc<str>, Rc<str>) = match &*v0 {
                UH0::UH0_Nil => {
                    (v1, v2)
                }
                _ => unreachable!(),
            };
            (v10, v11)
        }
    };
    (v12, v13)
}
fn closure48() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.split_args / segment zero-length success"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method77(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: Rc<str>, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> (i32, i32, i32, i32, i32) {
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
fn method78(mut v0: Rc<UH0>, mut v1: i32) -> i32 {
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
fn method79(mut v0: Rc<RefCell<Vec<u8>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_Cons(v3, v4) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                let mut v5: i32 = (v3.clone().len() as i32);
                let mut v6: i32 = v2.wrapping_sub(v5);
                v0.borrow_mut()[v6 as usize..v2 as usize].copy_from_slice(v3.as_bytes());
                (v0, v1, v2) = (v0.clone(), v4.clone(), v6);
                continue;
            }
            UH0::UH0_Nil => {
                return v2;
            }
        }
    }
}
fn pass_81(mut v0: bool, mut v1: Rc<UH0>, mut v2: Rc<UH0>) -> Rc<UH0> {
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
fn method80(mut v0: bool, mut v1: Rc<UH0>) -> Rc<str> {
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
                        let mut v7: Rc<UH0> = pass_81(v0, v1.clone(), v6.clone());
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
fn closure49() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_strings / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method76(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<UH0>, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32) -> US11 {
    loop {
        let mut v8: bool = v3 >= v7;
        let mut v26: US10 = if v8 {
            let mut v9: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
            US10::US10_Error(v9.clone(), v3, v4, v5, v6, v7)
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
                US10::US10_Ok(b'\\', v13, v18, v19, v20, v21)
            } else {
                let v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                US10::US10_Error(v23.clone(), v3, v4, v5, v6, v7)
            }
        };
        let v60: US10 = match &v26 {
            US10::US10_Error(v52, v53, v54, v55, v56, v57) => {
                let mut v52: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v52.clone();
                let v53: i32 = *v53;
                let v54: i32 = *v54;
                let v55: i32 = *v55;
                let v56: i32 = *v56;
                let mut v57: i32 = *v57;
                US10::US10_Error(v52.clone(), v53, v54, v55, v56, v57)
            }
            US10::US10_Ok(v27, v28, v29, v30, v31, v32) => {
                let mut v27: u8 = *v27;
                let mut v28: i32 = *v28;
                let mut v29: i32 = *v29;
                let v30: i32 = *v30;
                let mut v31: i32 = *v31;
                let mut v32: i32 = *v32;
                let mut v33: bool = v28 >= v32;
                if v33 {
                    let v34: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                    US10::US10_Error(v34.clone(), v28, v29, v30, v31, v32)
                } else {
                    let v36: u8 = v0.clone().as_bytes()[v28 as usize];
                    let v37: bool = v36 == b'"';
                    if v37 {
                        let mut v38: i32 = v28.wrapping_add(1i32);
                        let v39: bool = b'\n' == v36;
                        let (mut v43, mut v44, mut v45, mut v46): (i32, i32, i32, i32) = if v39 {
                            let v40: i32 = v29.wrapping_add(v31);
                            let mut v41: i32 = v30.wrapping_add(1i32);
                            (v40, v41, 1i32, v32)
                        } else {
                            let mut v42: i32 = v31.wrapping_add(1i32);
                            (v29, v30, v42, v32)
                        };
                        US10::US10_Ok(b'"', v38, v43, v44, v45, v46)
                    } else {
                        let mut v48: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                        US10::US10_Error(v48.clone(), v28, v29, v30, v31, v32)
                    }
                }
            }
        };
        let mut v76: US10 = match &v60 {
            US10::US10_Error(v68, v69, v70, v71, v72, v73) => {
                let mut v68: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v68.clone();
                let mut v69: i32 = *v69;
                let mut v70: i32 = *v70;
                let mut v71: i32 = *v71;
                let v72: i32 = *v72;
                let mut v73: i32 = *v73;
                US10::US10_Error(v68.clone(), v69, v70, v71, v72, v73)
            }
            US10::US10_Ok(v61, v62, v63, v64, v65, v66) => {
                let v61: u8 = *v61;
                let v62: i32 = *v62;
                let mut v63: i32 = *v63;
                let v64: i32 = *v64;
                let mut v65: i32 = *v65;
                let v66: i32 = *v66;
                US10::US10_Ok(b'"', v62, v63, v64, v65, v66)
            }
        };
        let v174: US10 = match &v76 {
            US10::US10_Error(v83, v84, v85, v86, v87, v88) => {
                let mut v83: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v83.clone();
                let v84: i32 = *v84;
                let v85: i32 = *v85;
                let v86: i32 = *v86;
                let mut v87: i32 = *v87;
                let v88: i32 = *v88;
                let mut v106: US10 = if v8 {
                    let v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                    US10::US10_Error(v89.clone(), v3, v4, v5, v6, v7)
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
                            let mut v97: i32 = v6.wrapping_add(1i32);
                            (v4, v5, v97, v7)
                        };
                        US10::US10_Ok(b'`', v93, v98, v99, v100, v101)
                    } else {
                        let mut v103: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                        US10::US10_Error(v103.clone(), v3, v4, v5, v6, v7)
                    }
                };
                let v140: US10 = match &v106 {
                    US10::US10_Error(v132, v133, v134, v135, v136, v137) => {
                        let v132: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v132.clone();
                        let mut v133: i32 = *v133;
                        let v134: i32 = *v134;
                        let v135: i32 = *v135;
                        let v136: i32 = *v136;
                        let v137: i32 = *v137;
                        US10::US10_Error(v132.clone(), v133, v134, v135, v136, v137)
                    }
                    US10::US10_Ok(v107, v108, v109, v110, v111, v112) => {
                        let mut v107: u8 = *v107;
                        let mut v108: i32 = *v108;
                        let v109: i32 = *v109;
                        let mut v110: i32 = *v110;
                        let v111: i32 = *v111;
                        let v112: i32 = *v112;
                        let v113: bool = v108 >= v112;
                        if v113 {
                            let v114: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                            US10::US10_Error(v114.clone(), v108, v109, v110, v111, v112)
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
                                US10::US10_Ok(b'"', v118, v123, v124, v125, v126)
                            } else {
                                let v128: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                US10::US10_Error(v128.clone(), v108, v109, v110, v111, v112)
                            }
                        }
                    }
                };
                let mut v156: US10 = match &v140 {
                    US10::US10_Error(v148, v149, v150, v151, v152, v153) => {
                        let mut v148: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v148.clone();
                        let v149: i32 = *v149;
                        let mut v150: i32 = *v150;
                        let mut v151: i32 = *v151;
                        let mut v152: i32 = *v152;
                        let mut v153: i32 = *v153;
                        US10::US10_Error(v148.clone(), v149, v150, v151, v152, v153)
                    }
                    US10::US10_Ok(v141, v142, v143, v144, v145, v146) => {
                        let v141: u8 = *v141;
                        let v142: i32 = *v142;
                        let mut v143: i32 = *v143;
                        let mut v144: i32 = *v144;
                        let v145: i32 = *v145;
                        let v146: i32 = *v146;
                        US10::US10_Ok(b'"', v142, v143, v144, v145, v146)
                    }
                };
                match &v156 {
                    US10::US10_Error(v163, v164, v165, v166, v167, v168) => {
                        let mut v163: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v163.clone();
                        let v164: i32 = *v164;
                        let v165: i32 = *v165;
                        let v166: i32 = *v166;
                        let mut v167: i32 = *v167;
                        let v168: i32 = *v168;
                        let v169: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                        US10::US10_Error(v169.clone(), v3, v4, v5, v6, v7)
                    }
                    US10::US10_Ok(v157, v158, v159, v160, v161, v162) => {
                        let mut v157: u8 = *v157;
                        let mut v158: i32 = *v158;
                        let v159: i32 = *v159;
                        let mut v160: i32 = *v160;
                        let v161: i32 = *v161;
                        let v162: i32 = *v162;
                        v156.clone()
                    }
                }
            }
            US10::US10_Ok(v77, v78, v79, v80, v81, v82) => {
                let mut v77: u8 = *v77;
                let mut v78: i32 = *v78;
                let mut v79: i32 = *v79;
                let mut v80: i32 = *v80;
                let mut v81: i32 = *v81;
                let mut v82: i32 = *v82;
                v76.clone()
            }
        };
        let v806: US11 = match &v174 {
            US10::US10_Error(v798, v799, v800, v801, v802, v803) => {
                let mut v798: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v798.clone();
                let v799: i32 = *v799;
                let v800: i32 = *v800;
                let mut v801: i32 = *v801;
                let v802: i32 = *v802;
                let v803: i32 = *v803;
                US11::US11_Error(v798.clone(), v799, v800, v801, v802, v803)
            }
            US10::US10_Ok(v175, v176, v177, v178, v179, v180) => {
                let mut v175: u8 = *v175;
                let mut v176: i32 = *v176;
                let v177: i32 = *v177;
                let mut v178: i32 = *v178;
                let v179: i32 = *v179;
                let v180: i32 = *v180;
                let (mut v181, mut v182, mut v183, mut v184, mut v185): (i32, i32, i32, i32, i32) = method69(v177, v178, v179, v180, v0.clone(), v176, v177, v178, v179, v180);
                let v186: bool = v181 > v176;
                let v196: US11 = if v186 {
                    let mut v187: bool = v176 >= v181;
                    let v192: Rc<str> = if v187 {
                        let v188: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v188.clone()
                    } else {
                        let v190: i32 = v181.wrapping_sub(1i32);
                        let mut v191: Rc<str> = string_slice(&v0.clone(), v176 as i64, v190 as i64);
                        v191.clone()
                    };
                    US11::US11_Ok(v192.clone(), v181, v182, v183, v184, v185)
                } else {
                    let v194: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                    US11::US11_Error(v194.clone(), v176, v177, v178, v179, v180)
                };
                let v391: US11 = match &v196 {
                    US11::US11_Error(v203, v204, v205, v206, v207, v208) => {
                        let v203: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v203.clone();
                        let v204: i32 = *v204;
                        let v205: i32 = *v205;
                        let mut v206: i32 = *v206;
                        let v207: i32 = *v207;
                        let mut v208: i32 = *v208;
                        let mut v209: bool = v176 >= v180;
                        let v227: US10 = if v209 {
                            let v210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                            US10::US10_Error(v210.clone(), v176, v177, v178, v179, v180)
                        } else {
                            let v212: u8 = v0.clone().as_bytes()[v176 as usize];
                            let mut v213: bool = v212 == b'\\';
                            if v213 {
                                let v214: i32 = v176.wrapping_add(1i32);
                                let v215: bool = b'\n' == v212;
                                let (mut v219, mut v220, mut v221, mut v222): (i32, i32, i32, i32) = if v215 {
                                    let mut v216: i32 = v177.wrapping_add(v179);
                                    let v217: i32 = v178.wrapping_add(1i32);
                                    (v216, v217, 1i32, v180)
                                } else {
                                    let mut v218: i32 = v179.wrapping_add(1i32);
                                    (v177, v178, v218, v180)
                                };
                                US10::US10_Ok(b'\\', v214, v219, v220, v221, v222)
                            } else {
                                let v224: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                US10::US10_Error(v224.clone(), v176, v177, v178, v179, v180)
                            }
                        };
                        let v262: US10 = match &v227 {
                            US10::US10_Error(v254, v255, v256, v257, v258, v259) => {
                                let v254: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v254.clone();
                                let mut v255: i32 = *v255;
                                let v256: i32 = *v256;
                                let v257: i32 = *v257;
                                let v258: i32 = *v258;
                                let mut v259: i32 = *v259;
                                US10::US10_Error(v254.clone(), v255, v256, v257, v258, v259)
                            }
                            US10::US10_Ok(v228, v229, v230, v231, v232, v233) => {
                                let mut v228: u8 = *v228;
                                let v229: i32 = *v229;
                                let v230: i32 = *v230;
                                let v231: i32 = *v231;
                                let v232: i32 = *v232;
                                let v233: i32 = *v233;
                                let v234: bool = v229 >= v233;
                                if v234 {
                                    let v235: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                    US10::US10_Error(v235.clone(), v229, v230, v231, v232, v233)
                                } else {
                                    let mut v237: u8 = v0.clone().as_bytes()[v229 as usize];
                                    let v238: bool = v237 == b'"';
                                    let mut v239: bool = v238 == false;
                                    if v239 {
                                        let v240: i32 = v229.wrapping_add(1i32);
                                        let v241: bool = b'\n' == v237;
                                        let (mut v245, mut v246, mut v247, mut v248): (i32, i32, i32, i32) = if v241 {
                                            let v242: i32 = v230.wrapping_add(v232);
                                            let v243: i32 = v231.wrapping_add(1i32);
                                            (v242, v243, 1i32, v233)
                                        } else {
                                            let mut v244: i32 = v232.wrapping_add(1i32);
                                            (v230, v231, v244, v233)
                                        };
                                        US10::US10_Ok(v237, v240, v245, v246, v247, v248)
                                    } else {
                                        let v250: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                        US10::US10_Error(v250.clone(), v229, v230, v231, v232, v233)
                                    }
                                }
                            }
                        };
                        let mut v284: US11 = match &v262 {
                            US10::US10_Error(v276, v277, v278, v279, v280, v281) => {
                                let v276: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v276.clone();
                                let v277: i32 = *v277;
                                let v278: i32 = *v278;
                                let v279: i32 = *v279;
                                let mut v280: i32 = *v280;
                                let mut v281: i32 = *v281;
                                US11::US11_Error(v276.clone(), v277, v278, v279, v280, v281)
                            }
                            US10::US10_Ok(v263, v264, v265, v266, v267, v268) => {
                                let v263: u8 = *v263;
                                let v264: i32 = *v264;
                                let v265: i32 = *v265;
                                let v266: i32 = *v266;
                                let v267: i32 = *v267;
                                let v268: i32 = *v268;
                                let v269: bool = v176 >= v264;
                                let v274: Rc<str> = if v269 {
                                    let v270: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v270.clone()
                                } else {
                                    let mut v272: i32 = v264.wrapping_sub(1i32);
                                    let v273: Rc<str> = string_slice(&v0.clone(), v176 as i64, v272 as i64);
                                    v273.clone()
                                };
                                US11::US11_Ok(v274.clone(), v264, v265, v266, v267, v268)
                            }
                        };
                        match &v284 {
                            US11::US11_Error(v291, v292, v293, v294, v295, v296) => {
                                let v291: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v291.clone();
                                let v292: i32 = *v292;
                                let v293: i32 = *v293;
                                let v294: i32 = *v294;
                                let v295: i32 = *v295;
                                let v296: i32 = *v296;
                                let v314: US10 = if v209 {
                                    let v297: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                    US10::US10_Error(v297.clone(), v176, v177, v178, v179, v180)
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
                                        US10::US10_Ok(b'`', v301, v306, v307, v308, v309)
                                    } else {
                                        let v311: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US10::US10_Error(v311.clone(), v176, v177, v178, v179, v180)
                                    }
                                };
                                let v349: US10 = match &v314 {
                                    US10::US10_Error(v341, v342, v343, v344, v345, v346) => {
                                        let v341: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v341.clone();
                                        let v342: i32 = *v342;
                                        let v343: i32 = *v343;
                                        let v344: i32 = *v344;
                                        let v345: i32 = *v345;
                                        let v346: i32 = *v346;
                                        US10::US10_Error(v341.clone(), v342, v343, v344, v345, v346)
                                    }
                                    US10::US10_Ok(v315, v316, v317, v318, v319, v320) => {
                                        let v315: u8 = *v315;
                                        let v316: i32 = *v316;
                                        let v317: i32 = *v317;
                                        let v318: i32 = *v318;
                                        let v319: i32 = *v319;
                                        let v320: i32 = *v320;
                                        let v321: bool = v316 >= v320;
                                        if v321 {
                                            let v322: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                            US10::US10_Error(v322.clone(), v316, v317, v318, v319, v320)
                                        } else {
                                            let v324: u8 = v0.clone().as_bytes()[v316 as usize];
                                            let v325: bool = v324 == b'"';
                                            let v326: bool = v325 == false;
                                            if v326 {
                                                let mut v327: i32 = v316.wrapping_add(1i32);
                                                let v328: bool = b'\n' == v324;
                                                let (mut v332, mut v333, mut v334, mut v335): (i32, i32, i32, i32) = if v328 {
                                                    let v329: i32 = v317.wrapping_add(v319);
                                                    let mut v330: i32 = v318.wrapping_add(1i32);
                                                    (v329, v330, 1i32, v320)
                                                } else {
                                                    let v331: i32 = v319.wrapping_add(1i32);
                                                    (v317, v318, v331, v320)
                                                };
                                                US10::US10_Ok(v324, v327, v332, v333, v334, v335)
                                            } else {
                                                let v337: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                US10::US10_Error(v337.clone(), v316, v317, v318, v319, v320)
                                            }
                                        }
                                    }
                                };
                                let v371: US11 = match &v349 {
                                    US10::US10_Error(v363, v364, v365, v366, v367, v368) => {
                                        let v363: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v363.clone();
                                        let v364: i32 = *v364;
                                        let v365: i32 = *v365;
                                        let v366: i32 = *v366;
                                        let v367: i32 = *v367;
                                        let v368: i32 = *v368;
                                        US11::US11_Error(v363.clone(), v364, v365, v366, v367, v368)
                                    }
                                    US10::US10_Ok(v350, v351, v352, v353, v354, v355) => {
                                        let v350: u8 = *v350;
                                        let v351: i32 = *v351;
                                        let v352: i32 = *v352;
                                        let v353: i32 = *v353;
                                        let v354: i32 = *v354;
                                        let v355: i32 = *v355;
                                        let v356: bool = v176 >= v351;
                                        let v361: Rc<str> = if v356 {
                                            let mut v357: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            v357.clone()
                                        } else {
                                            let v359: i32 = v351.wrapping_sub(1i32);
                                            let v360: Rc<str> = string_slice(&v0.clone(), v176 as i64, v359 as i64);
                                            v360.clone()
                                        };
                                        US11::US11_Ok(v361.clone(), v351, v352, v353, v354, v355)
                                    }
                                };
                                match &v371 {
                                    US11::US11_Error(v378, v379, v380, v381, v382, v383) => {
                                        let mut v378: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v378.clone();
                                        let v379: i32 = *v379;
                                        let v380: i32 = *v380;
                                        let mut v381: i32 = *v381;
                                        let v382: i32 = *v382;
                                        let v383: i32 = *v383;
                                        let v384: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                        US11::US11_Error(v384.clone(), v176, v177, v178, v179, v180)
                                    }
                                    US11::US11_Ok(v372, v373, v374, v375, v376, v377) => {
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
                            US11::US11_Ok(v285, v286, v287, v288, v289, v290) => {
                                let v285: Rc<str> = v285.clone();
                                let v286: i32 = *v286;
                                let v287: i32 = *v287;
                                let v288: i32 = *v288;
                                let v289: i32 = *v289;
                                let v290: i32 = *v290;
                                v284.clone()
                            }
                        }
                    }
                    US11::US11_Ok(v197, v198, v199, v200, v201, v202) => {
                        let v197: Rc<str> = v197.clone();
                        let v198: i32 = *v198;
                        let v199: i32 = *v199;
                        let v200: i32 = *v200;
                        let mut v201: i32 = *v201;
                        let v202: i32 = *v202;
                        v196.clone()
                    }
                };
                let v414: US11 = match &v391 {
                    US11::US11_Error(v392, v393, v394, v395, v396, v397) => {
                        let v392: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v392.clone();
                        let v393: i32 = *v393;
                        let v394: i32 = *v394;
                        let v395: i32 = *v395;
                        let v396: i32 = *v396;
                        let v397: i32 = *v397;
                        let v398: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        US11::US11_Ok(v398.clone(), v176, v177, v178, v179, v180)
                    }
                    US11::US11_Ok(v400, v401, v402, v403, v404, v405) => {
                        let v400: Rc<str> = v400.clone();
                        let v401: i32 = *v401;
                        let v402: i32 = *v402;
                        let v403: i32 = *v403;
                        let v404: i32 = *v404;
                        let v405: i32 = *v405;
                        let v406: bool = v401 == v176;
                        if v406 {
                            let v407: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                            US11::US11_Error(v407.clone(), v176, v177, v178, v179, v180)
                        } else {
                            let v409: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                            let v410: i32 = 0i32;
                            method70(v0.clone(), v409.clone(), v409.clone(), v400.clone(), v410, v401, v402, v403, v404, v405)
                        }
                    }
                };
                match &v414 {
                    US11::US11_Error(v605, v606, v607, v608, v609, v610) => {
                        let v605: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v605.clone();
                        let v606: i32 = *v606;
                        let v607: i32 = *v607;
                        let v608: i32 = *v608;
                        let v609: i32 = *v609;
                        let v610: i32 = *v610;
                        let v611: bool = v176 >= v180;
                        let v629: US10 = if v611 {
                            let v612: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                            US10::US10_Error(v612.clone(), v176, v177, v178, v179, v180)
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
                                US10::US10_Ok(b'\\', v616, v621, v622, v623, v624)
                            } else {
                                let v626: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                US10::US10_Error(v626.clone(), v176, v177, v178, v179, v180)
                            }
                        };
                        let v663: US10 = match &v629 {
                            US10::US10_Error(v655, v656, v657, v658, v659, v660) => {
                                let v655: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v655.clone();
                                let v656: i32 = *v656;
                                let v657: i32 = *v657;
                                let v658: i32 = *v658;
                                let v659: i32 = *v659;
                                let v660: i32 = *v660;
                                US10::US10_Error(v655.clone(), v656, v657, v658, v659, v660)
                            }
                            US10::US10_Ok(v630, v631, v632, v633, v634, v635) => {
                                let v630: u8 = *v630;
                                let v631: i32 = *v631;
                                let v632: i32 = *v632;
                                let v633: i32 = *v633;
                                let v634: i32 = *v634;
                                let v635: i32 = *v635;
                                let v636: bool = v631 >= v635;
                                if v636 {
                                    let v637: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                    US10::US10_Error(v637.clone(), v631, v632, v633, v634, v635)
                                } else {
                                    let v639: u8 = v0.clone().as_bytes()[v631 as usize];
                                    let mut v640: bool = v639 == b'"';
                                    if v640 {
                                        let v641: i32 = v631.wrapping_add(1i32);
                                        let v642: bool = b'\n' == v639;
                                        let (mut v646, mut v647, mut v648, mut v649): (i32, i32, i32, i32) = if v642 {
                                            let mut v643: i32 = v632.wrapping_add(v634);
                                            let v644: i32 = v633.wrapping_add(1i32);
                                            (v643, v644, 1i32, v635)
                                        } else {
                                            let v645: i32 = v634.wrapping_add(1i32);
                                            (v632, v633, v645, v635)
                                        };
                                        US10::US10_Ok(b'"', v641, v646, v647, v648, v649)
                                    } else {
                                        let v651: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                        US10::US10_Error(v651.clone(), v631, v632, v633, v634, v635)
                                    }
                                }
                            }
                        };
                        let v679: US10 = match &v663 {
                            US10::US10_Error(v671, v672, v673, v674, v675, v676) => {
                                let mut v671: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v671.clone();
                                let v672: i32 = *v672;
                                let v673: i32 = *v673;
                                let v674: i32 = *v674;
                                let v675: i32 = *v675;
                                let v676: i32 = *v676;
                                US10::US10_Error(v671.clone(), v672, v673, v674, v675, v676)
                            }
                            US10::US10_Ok(v664, v665, v666, v667, v668, v669) => {
                                let v664: u8 = *v664;
                                let v665: i32 = *v665;
                                let v666: i32 = *v666;
                                let v667: i32 = *v667;
                                let v668: i32 = *v668;
                                let v669: i32 = *v669;
                                US10::US10_Ok(b'"', v665, v666, v667, v668, v669)
                            }
                        };
                        let v777: US10 = match &v679 {
                            US10::US10_Error(v686, v687, v688, v689, v690, v691) => {
                                let v686: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v686.clone();
                                let v687: i32 = *v687;
                                let v688: i32 = *v688;
                                let v689: i32 = *v689;
                                let v690: i32 = *v690;
                                let v691: i32 = *v691;
                                let v709: US10 = if v611 {
                                    let v692: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                    US10::US10_Error(v692.clone(), v176, v177, v178, v179, v180)
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
                                        US10::US10_Ok(b'`', v696, v701, v702, v703, v704)
                                    } else {
                                        let v706: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US10::US10_Error(v706.clone(), v176, v177, v178, v179, v180)
                                    }
                                };
                                let v743: US10 = match &v709 {
                                    US10::US10_Error(v735, v736, v737, v738, v739, v740) => {
                                        let v735: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v735.clone();
                                        let v736: i32 = *v736;
                                        let v737: i32 = *v737;
                                        let v738: i32 = *v738;
                                        let v739: i32 = *v739;
                                        let v740: i32 = *v740;
                                        US10::US10_Error(v735.clone(), v736, v737, v738, v739, v740)
                                    }
                                    US10::US10_Ok(v710, v711, v712, v713, v714, v715) => {
                                        let v710: u8 = *v710;
                                        let v711: i32 = *v711;
                                        let v712: i32 = *v712;
                                        let v713: i32 = *v713;
                                        let v714: i32 = *v714;
                                        let v715: i32 = *v715;
                                        let v716: bool = v711 >= v715;
                                        if v716 {
                                            let v717: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                            US10::US10_Error(v717.clone(), v711, v712, v713, v714, v715)
                                        } else {
                                            let mut v719: u8 = v0.clone().as_bytes()[v711 as usize];
                                            let v720: bool = v719 == b'"';
                                            if v720 {
                                                let v721: i32 = v711.wrapping_add(1i32);
                                                let mut v722: bool = b'\n' == v719;
                                                let (mut v726, mut v727, mut v728, mut v729): (i32, i32, i32, i32) = if v722 {
                                                    let v723: i32 = v712.wrapping_add(v714);
                                                    let v724: i32 = v713.wrapping_add(1i32);
                                                    (v723, v724, 1i32, v715)
                                                } else {
                                                    let v725: i32 = v714.wrapping_add(1i32);
                                                    (v712, v713, v725, v715)
                                                };
                                                US10::US10_Ok(b'"', v721, v726, v727, v728, v729)
                                            } else {
                                                let v731: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                US10::US10_Error(v731.clone(), v711, v712, v713, v714, v715)
                                            }
                                        }
                                    }
                                };
                                let v759: US10 = match &v743 {
                                    US10::US10_Error(v751, v752, v753, v754, v755, v756) => {
                                        let v751: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v751.clone();
                                        let v752: i32 = *v752;
                                        let v753: i32 = *v753;
                                        let v754: i32 = *v754;
                                        let v755: i32 = *v755;
                                        let v756: i32 = *v756;
                                        US10::US10_Error(v751.clone(), v752, v753, v754, v755, v756)
                                    }
                                    US10::US10_Ok(v744, v745, v746, v747, v748, v749) => {
                                        let v744: u8 = *v744;
                                        let v745: i32 = *v745;
                                        let v746: i32 = *v746;
                                        let v747: i32 = *v747;
                                        let v748: i32 = *v748;
                                        let v749: i32 = *v749;
                                        US10::US10_Ok(b'"', v745, v746, v747, v748, v749)
                                    }
                                };
                                match &v759 {
                                    US10::US10_Error(v766, v767, v768, v769, v770, v771) => {
                                        let v766: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v766.clone();
                                        let v767: i32 = *v767;
                                        let v768: i32 = *v768;
                                        let v769: i32 = *v769;
                                        let v770: i32 = *v770;
                                        let v771: i32 = *v771;
                                        let v772: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                        US10::US10_Error(v772.clone(), v176, v177, v178, v179, v180)
                                    }
                                    US10::US10_Ok(v760, v761, v762, v763, v764, v765) => {
                                        let v760: u8 = *v760;
                                        let v761: i32 = *v761;
                                        let v762: i32 = *v762;
                                        let v763: i32 = *v763;
                                        let v764: i32 = *v764;
                                        let v765: i32 = *v765;
                                        v759.clone()
                                    }
                                }
                            }
                            US10::US10_Ok(v680, v681, v682, v683, v684, v685) => {
                                let v680: u8 = *v680;
                                let v681: i32 = *v681;
                                let v682: i32 = *v682;
                                let v683: i32 = *v683;
                                let v684: i32 = *v684;
                                let v685: i32 = *v685;
                                v679.clone()
                            }
                        };
                        match &v777 {
                            US10::US10_Error(v786, v787, v788, v789, v790, v791) => {
                                let v786: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v786.clone();
                                let v787: i32 = *v787;
                                let v788: i32 = *v788;
                                let v789: i32 = *v789;
                                let v790: i32 = *v790;
                                let v791: i32 = *v791;
                                let v792: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                US11::US11_Error(v792.clone(), v176, v177, v178, v179, v180)
                            }
                            US10::US10_Ok(v778, v779, v780, v781, v782, v783) => {
                                let v778: u8 = *v778;
                                let v779: i32 = *v779;
                                let v780: i32 = *v780;
                                let v781: i32 = *v781;
                                let v782: i32 = *v782;
                                let v783: i32 = *v783;
                                let v784: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                US11::US11_Ok(v784.clone(), v779, v780, v781, v782, v783)
                            }
                        }
                    }
                    US11::US11_Ok(v415, v416, v417, v418, v419, v420) => {
                        let v415: Rc<str> = v415.clone();
                        let v416: i32 = *v416;
                        let v417: i32 = *v417;
                        let v418: i32 = *v418;
                        let v419: i32 = *v419;
                        let v420: i32 = *v420;
                        let v421: bool = v416 >= v420;
                        let v439: US10 = if v421 {
                            let v422: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                            US10::US10_Error(v422.clone(), v416, v417, v418, v419, v420)
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
                                US10::US10_Ok(b'\\', v426, v431, v432, v433, v434)
                            } else {
                                let v436: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                US10::US10_Error(v436.clone(), v416, v417, v418, v419, v420)
                            }
                        };
                        let v473: US10 = match &v439 {
                            US10::US10_Error(v465, v466, v467, v468, v469, v470) => {
                                let v465: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v465.clone();
                                let v466: i32 = *v466;
                                let v467: i32 = *v467;
                                let v468: i32 = *v468;
                                let v469: i32 = *v469;
                                let v470: i32 = *v470;
                                US10::US10_Error(v465.clone(), v466, v467, v468, v469, v470)
                            }
                            US10::US10_Ok(v440, v441, v442, v443, v444, v445) => {
                                let v440: u8 = *v440;
                                let v441: i32 = *v441;
                                let v442: i32 = *v442;
                                let v443: i32 = *v443;
                                let v444: i32 = *v444;
                                let v445: i32 = *v445;
                                let v446: bool = v441 >= v445;
                                if v446 {
                                    let v447: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                    US10::US10_Error(v447.clone(), v441, v442, v443, v444, v445)
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
                                        US10::US10_Ok(b'"', v451, v456, v457, v458, v459)
                                    } else {
                                        let v461: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                        US10::US10_Error(v461.clone(), v441, v442, v443, v444, v445)
                                    }
                                }
                            }
                        };
                        let v489: US10 = match &v473 {
                            US10::US10_Error(v481, v482, v483, v484, v485, v486) => {
                                let mut v481: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v481.clone();
                                let v482: i32 = *v482;
                                let v483: i32 = *v483;
                                let v484: i32 = *v484;
                                let v485: i32 = *v485;
                                let v486: i32 = *v486;
                                US10::US10_Error(v481.clone(), v482, v483, v484, v485, v486)
                            }
                            US10::US10_Ok(v474, v475, v476, v477, v478, v479) => {
                                let v474: u8 = *v474;
                                let v475: i32 = *v475;
                                let v476: i32 = *v476;
                                let v477: i32 = *v477;
                                let mut v478: i32 = *v478;
                                let v479: i32 = *v479;
                                US10::US10_Ok(b'"', v475, v476, v477, v478, v479)
                            }
                        };
                        let v587: US10 = match &v489 {
                            US10::US10_Error(v496, v497, v498, v499, v500, v501) => {
                                let v496: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v496.clone();
                                let v497: i32 = *v497;
                                let v498: i32 = *v498;
                                let v499: i32 = *v499;
                                let v500: i32 = *v500;
                                let v501: i32 = *v501;
                                let v519: US10 = if v421 {
                                    let v502: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                    US10::US10_Error(v502.clone(), v416, v417, v418, v419, v420)
                                } else {
                                    let v504: u8 = v0.clone().as_bytes()[v416 as usize];
                                    let v505: bool = v504 == b'`';
                                    if v505 {
                                        let v506: i32 = v416.wrapping_add(1i32);
                                        let v507: bool = b'\n' == v504;
                                        let (mut v511, mut v512, mut v513, mut v514): (i32, i32, i32, i32) = if v507 {
                                            let v508: i32 = v417.wrapping_add(v419);
                                            let mut v509: i32 = v418.wrapping_add(1i32);
                                            (v508, v509, 1i32, v420)
                                        } else {
                                            let v510: i32 = v419.wrapping_add(1i32);
                                            (v417, v418, v510, v420)
                                        };
                                        US10::US10_Ok(b'`', v506, v511, v512, v513, v514)
                                    } else {
                                        let v516: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US10::US10_Error(v516.clone(), v416, v417, v418, v419, v420)
                                    }
                                };
                                let v553: US10 = match &v519 {
                                    US10::US10_Error(v545, v546, v547, v548, v549, v550) => {
                                        let v545: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v545.clone();
                                        let v546: i32 = *v546;
                                        let v547: i32 = *v547;
                                        let v548: i32 = *v548;
                                        let v549: i32 = *v549;
                                        let v550: i32 = *v550;
                                        US10::US10_Error(v545.clone(), v546, v547, v548, v549, v550)
                                    }
                                    US10::US10_Ok(v520, v521, v522, v523, v524, v525) => {
                                        let v520: u8 = *v520;
                                        let v521: i32 = *v521;
                                        let v522: i32 = *v522;
                                        let v523: i32 = *v523;
                                        let v524: i32 = *v524;
                                        let v525: i32 = *v525;
                                        let v526: bool = v521 >= v525;
                                        if v526 {
                                            let v527: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                            US10::US10_Error(v527.clone(), v521, v522, v523, v524, v525)
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
                                                US10::US10_Ok(b'"', v531, v536, v537, v538, v539)
                                            } else {
                                                let v541: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                US10::US10_Error(v541.clone(), v521, v522, v523, v524, v525)
                                            }
                                        }
                                    }
                                };
                                let v569: US10 = match &v553 {
                                    US10::US10_Error(v561, v562, v563, v564, v565, v566) => {
                                        let v561: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v561.clone();
                                        let v562: i32 = *v562;
                                        let mut v563: i32 = *v563;
                                        let v564: i32 = *v564;
                                        let v565: i32 = *v565;
                                        let v566: i32 = *v566;
                                        US10::US10_Error(v561.clone(), v562, v563, v564, v565, v566)
                                    }
                                    US10::US10_Ok(v554, v555, v556, v557, v558, v559) => {
                                        let v554: u8 = *v554;
                                        let v555: i32 = *v555;
                                        let v556: i32 = *v556;
                                        let v557: i32 = *v557;
                                        let v558: i32 = *v558;
                                        let v559: i32 = *v559;
                                        US10::US10_Ok(b'"', v555, v556, v557, v558, v559)
                                    }
                                };
                                match &v569 {
                                    US10::US10_Error(v576, v577, v578, v579, v580, v581) => {
                                        let v576: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v576.clone();
                                        let v577: i32 = *v577;
                                        let v578: i32 = *v578;
                                        let v579: i32 = *v579;
                                        let mut v580: i32 = *v580;
                                        let v581: i32 = *v581;
                                        let v582: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                        US10::US10_Error(v582.clone(), v416, v417, v418, v419, v420)
                                    }
                                    US10::US10_Ok(v570, v571, v572, v573, v574, v575) => {
                                        let v570: u8 = *v570;
                                        let mut v571: i32 = *v571;
                                        let mut v572: i32 = *v572;
                                        let v573: i32 = *v573;
                                        let v574: i32 = *v574;
                                        let v575: i32 = *v575;
                                        v569.clone()
                                    }
                                }
                            }
                            US10::US10_Ok(v490, v491, v492, v493, v494, v495) => {
                                let v490: u8 = *v490;
                                let v491: i32 = *v491;
                                let v492: i32 = *v492;
                                let v493: i32 = *v493;
                                let v494: i32 = *v494;
                                let v495: i32 = *v495;
                                v489.clone()
                            }
                        };
                        match &v587 {
                            US10::US10_Error(v595, v596, v597, v598, v599, v600) => {
                                let v595: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v595.clone();
                                let v596: i32 = *v596;
                                let v597: i32 = *v597;
                                let v598: i32 = *v598;
                                let v599: i32 = *v599;
                                let v600: i32 = *v600;
                                let v601: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v176, v416, v595.clone(), v596, v597, v598, v599, v600);
                                US11::US11_Error(v601.clone(), v416, v417, v418, v419, v420)
                            }
                            US10::US10_Ok(v588, v589, v590, v591, v592, v593) => {
                                let v588: u8 = *v588;
                                let v589: i32 = *v589;
                                let v590: i32 = *v590;
                                let mut v591: i32 = *v591;
                                let v592: i32 = *v592;
                                let v593: i32 = *v593;
                                US11::US11_Ok(v415.clone(), v589, v590, v591, v592, v593)
                            }
                        }
                    }
                }
            }
        };
        let v1164: US11 = match &v806 {
            US11::US11_Error(v813, v814, v815, v816, v817, v818) => {
                let v813: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v813.clone();
                let v814: i32 = *v814;
                let v815: i32 = *v815;
                let v816: i32 = *v816;
                let v817: i32 = *v817;
                let v818: i32 = *v818;
                let v836: US10 = if v8 {
                    let v819: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                    US10::US10_Error(v819.clone(), v3, v4, v5, v6, v7)
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
                        US10::US10_Ok(b'"', v823, v828, v829, v830, v831)
                    } else {
                        let v833: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                        US10::US10_Error(v833.clone(), v3, v4, v5, v6, v7)
                    }
                };
                match &v836 {
                    US10::US10_Error(v1154, v1155, v1156, v1157, v1158, v1159) => {
                        let v1154: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1154.clone();
                        let v1155: i32 = *v1155;
                        let v1156: i32 = *v1156;
                        let v1157: i32 = *v1157;
                        let v1158: i32 = *v1158;
                        let v1159: i32 = *v1159;
                        US11::US11_Error(v1154.clone(), v1155, v1156, v1157, v1158, v1159)
                    }
                    US10::US10_Ok(v837, v838, v839, v840, v841, v842) => {
                        let v837: u8 = *v837;
                        let v838: i32 = *v838;
                        let v839: i32 = *v839;
                        let v840: i32 = *v840;
                        let v841: i32 = *v841;
                        let v842: i32 = *v842;
                        let (mut v843, mut v844, mut v845, mut v846, mut v847): (i32, i32, i32, i32, i32) = method69(v839, v840, v841, v842, v0.clone(), v838, v839, v840, v841, v842);
                        let v848: bool = v843 > v838;
                        let v858: US11 = if v848 {
                            let v849: bool = v838 >= v843;
                            let v854: Rc<str> = if v849 {
                                let v850: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                v850.clone()
                            } else {
                                let v852: i32 = v843.wrapping_sub(1i32);
                                let v853: Rc<str> = string_slice(&v0.clone(), v838 as i64, v852 as i64);
                                v853.clone()
                            };
                            US11::US11_Ok(v854.clone(), v843, v844, v845, v846, v847)
                        } else {
                            let v856: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                            US11::US11_Error(v856.clone(), v838, v839, v840, v841, v842)
                        };
                        let v1043: US11 = match &v858 {
                            US11::US11_Error(v865, v866, v867, v868, v869, v870) => {
                                let v865: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v865.clone();
                                let v866: i32 = *v866;
                                let v867: i32 = *v867;
                                let v868: i32 = *v868;
                                let v869: i32 = *v869;
                                let v870: i32 = *v870;
                                let v871: bool = v838 >= v842;
                                let v889: US10 = if v871 {
                                    let v872: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                    US10::US10_Error(v872.clone(), v838, v839, v840, v841, v842)
                                } else {
                                    let v874: u8 = v0.clone().as_bytes()[v838 as usize];
                                    let v875: bool = v874 == b'\\';
                                    if v875 {
                                        let v876: i32 = v838.wrapping_add(1i32);
                                        let mut v877: bool = b'\n' == v874;
                                        let (mut v881, mut v882, mut v883, mut v884): (i32, i32, i32, i32) = if v877 {
                                            let v878: i32 = v839.wrapping_add(v841);
                                            let v879: i32 = v840.wrapping_add(1i32);
                                            (v878, v879, 1i32, v842)
                                        } else {
                                            let mut v880: i32 = v841.wrapping_add(1i32);
                                            (v839, v840, v880, v842)
                                        };
                                        US10::US10_Ok(b'\\', v876, v881, v882, v883, v884)
                                    } else {
                                        let v886: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                        US10::US10_Error(v886.clone(), v838, v839, v840, v841, v842)
                                    }
                                };
                                let v919: US10 = match &v889 {
                                    US10::US10_Error(v911, v912, v913, v914, v915, v916) => {
                                        let v911: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v911.clone();
                                        let v912: i32 = *v912;
                                        let v913: i32 = *v913;
                                        let v914: i32 = *v914;
                                        let v915: i32 = *v915;
                                        let v916: i32 = *v916;
                                        US10::US10_Error(v911.clone(), v912, v913, v914, v915, v916)
                                    }
                                    US10::US10_Ok(v890, v891, v892, v893, v894, v895) => {
                                        let v890: u8 = *v890;
                                        let v891: i32 = *v891;
                                        let v892: i32 = *v892;
                                        let v893: i32 = *v893;
                                        let v894: i32 = *v894;
                                        let v895: i32 = *v895;
                                        let v896: bool = v891 >= v895;
                                        if v896 {
                                            let v897: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                            US10::US10_Error(v897.clone(), v891, v892, v893, v894, v895)
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
                                            US10::US10_Ok(v899, v900, v905, v906, v907, v908)
                                        }
                                    }
                                };
                                let v941: US11 = match &v919 {
                                    US10::US10_Error(v933, v934, v935, v936, v937, v938) => {
                                        let v933: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v933.clone();
                                        let v934: i32 = *v934;
                                        let v935: i32 = *v935;
                                        let v936: i32 = *v936;
                                        let v937: i32 = *v937;
                                        let v938: i32 = *v938;
                                        US11::US11_Error(v933.clone(), v934, v935, v936, v937, v938)
                                    }
                                    US10::US10_Ok(v920, v921, v922, v923, v924, v925) => {
                                        let v920: u8 = *v920;
                                        let v921: i32 = *v921;
                                        let v922: i32 = *v922;
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
                                        US11::US11_Ok(v931.clone(), v921, v922, v923, v924, v925)
                                    }
                                };
                                match &v941 {
                                    US11::US11_Error(v948, v949, v950, v951, v952, v953) => {
                                        let v948: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v948.clone();
                                        let v949: i32 = *v949;
                                        let v950: i32 = *v950;
                                        let v951: i32 = *v951;
                                        let v952: i32 = *v952;
                                        let v953: i32 = *v953;
                                        let v971: US10 = if v871 {
                                            let v954: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                            US10::US10_Error(v954.clone(), v838, v839, v840, v841, v842)
                                        } else {
                                            let mut v956: u8 = v0.clone().as_bytes()[v838 as usize];
                                            let v957: bool = v956 == b'`';
                                            if v957 {
                                                let v958: i32 = v838.wrapping_add(1i32);
                                                let mut v959: bool = b'\n' == v956;
                                                let (mut v963, mut v964, mut v965, mut v966): (i32, i32, i32, i32) = if v959 {
                                                    let v960: i32 = v839.wrapping_add(v841);
                                                    let v961: i32 = v840.wrapping_add(1i32);
                                                    (v960, v961, 1i32, v842)
                                                } else {
                                                    let v962: i32 = v841.wrapping_add(1i32);
                                                    (v839, v840, v962, v842)
                                                };
                                                US10::US10_Ok(b'`', v958, v963, v964, v965, v966)
                                            } else {
                                                let v968: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                US10::US10_Error(v968.clone(), v838, v839, v840, v841, v842)
                                            }
                                        };
                                        let v1001: US10 = match &v971 {
                                            US10::US10_Error(v993, v994, v995, v996, v997, v998) => {
                                                let v993: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v993.clone();
                                                let v994: i32 = *v994;
                                                let v995: i32 = *v995;
                                                let v996: i32 = *v996;
                                                let v997: i32 = *v997;
                                                let v998: i32 = *v998;
                                                US10::US10_Error(v993.clone(), v994, v995, v996, v997, v998)
                                            }
                                            US10::US10_Ok(v972, v973, v974, v975, v976, v977) => {
                                                let v972: u8 = *v972;
                                                let v973: i32 = *v973;
                                                let v974: i32 = *v974;
                                                let v975: i32 = *v975;
                                                let v976: i32 = *v976;
                                                let v977: i32 = *v977;
                                                let v978: bool = v973 >= v977;
                                                if v978 {
                                                    let v979: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                    US10::US10_Error(v979.clone(), v973, v974, v975, v976, v977)
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
                                                    US10::US10_Ok(v981, v982, v987, v988, v989, v990)
                                                }
                                            }
                                        };
                                        let v1023: US11 = match &v1001 {
                                            US10::US10_Error(v1015, v1016, v1017, v1018, v1019, v1020) => {
                                                let v1015: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1015.clone();
                                                let v1016: i32 = *v1016;
                                                let v1017: i32 = *v1017;
                                                let v1018: i32 = *v1018;
                                                let v1019: i32 = *v1019;
                                                let v1020: i32 = *v1020;
                                                US11::US11_Error(v1015.clone(), v1016, v1017, v1018, v1019, v1020)
                                            }
                                            US10::US10_Ok(v1002, v1003, v1004, v1005, v1006, v1007) => {
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
                                                US11::US11_Ok(v1013.clone(), v1003, v1004, v1005, v1006, v1007)
                                            }
                                        };
                                        match &v1023 {
                                            US11::US11_Error(v1030, v1031, v1032, v1033, v1034, v1035) => {
                                                let v1030: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1030.clone();
                                                let v1031: i32 = *v1031;
                                                let v1032: i32 = *v1032;
                                                let v1033: i32 = *v1033;
                                                let v1034: i32 = *v1034;
                                                let v1035: i32 = *v1035;
                                                let v1036: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                US11::US11_Error(v1036.clone(), v838, v839, v840, v841, v842)
                                            }
                                            US11::US11_Ok(v1024, v1025, v1026, v1027, v1028, v1029) => {
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
                                    US11::US11_Ok(v942, v943, v944, v945, v946, v947) => {
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
                            US11::US11_Ok(v859, v860, v861, v862, v863, v864) => {
                                let v859: Rc<str> = v859.clone();
                                let v860: i32 = *v860;
                                let v861: i32 = *v861;
                                let v862: i32 = *v862;
                                let v863: i32 = *v863;
                                let v864: i32 = *v864;
                                v858.clone()
                            }
                        };
                        let v1066: US11 = match &v1043 {
                            US11::US11_Error(v1044, v1045, v1046, v1047, v1048, v1049) => {
                                let v1044: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1044.clone();
                                let v1045: i32 = *v1045;
                                let v1046: i32 = *v1046;
                                let v1047: i32 = *v1047;
                                let v1048: i32 = *v1048;
                                let v1049: i32 = *v1049;
                                let v1050: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                US11::US11_Ok(v1050.clone(), v838, v839, v840, v841, v842)
                            }
                            US11::US11_Ok(v1052, v1053, v1054, v1055, v1056, v1057) => {
                                let v1052: Rc<str> = v1052.clone();
                                let v1053: i32 = *v1053;
                                let v1054: i32 = *v1054;
                                let v1055: i32 = *v1055;
                                let v1056: i32 = *v1056;
                                let v1057: i32 = *v1057;
                                let v1058: bool = v1053 == v838;
                                if v1058 {
                                    let v1059: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                    US11::US11_Error(v1059.clone(), v838, v839, v840, v841, v842)
                                } else {
                                    let v1061: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                    let v1062: i32 = 0i32;
                                    method71(v0.clone(), v1061.clone(), v1061.clone(), v1052.clone(), v1062, v1053, v1054, v1055, v1056, v1057)
                                }
                            }
                        };
                        match &v1066 {
                            US11::US11_Error(v1109, v1110, v1111, v1112, v1113, v1114) => {
                                let v1109: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1109.clone();
                                let v1110: i32 = *v1110;
                                let v1111: i32 = *v1111;
                                let v1112: i32 = *v1112;
                                let v1113: i32 = *v1113;
                                let v1114: i32 = *v1114;
                                let v1115: bool = v838 >= v842;
                                let v1133: US10 = if v1115 {
                                    let v1116: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                    US10::US10_Error(v1116.clone(), v838, v839, v840, v841, v842)
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
                                        US10::US10_Ok(b'"', v1120, v1125, v1126, v1127, v1128)
                                    } else {
                                        let v1130: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                        US10::US10_Error(v1130.clone(), v838, v839, v840, v841, v842)
                                    }
                                };
                                match &v1133 {
                                    US10::US10_Error(v1142, v1143, v1144, v1145, v1146, v1147) => {
                                        let v1142: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1142.clone();
                                        let v1143: i32 = *v1143;
                                        let v1144: i32 = *v1144;
                                        let v1145: i32 = *v1145;
                                        let v1146: i32 = *v1146;
                                        let v1147: i32 = *v1147;
                                        let v1148: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                        US11::US11_Error(v1148.clone(), v838, v839, v840, v841, v842)
                                    }
                                    US10::US10_Ok(v1134, v1135, v1136, v1137, v1138, v1139) => {
                                        let v1134: u8 = *v1134;
                                        let v1135: i32 = *v1135;
                                        let v1136: i32 = *v1136;
                                        let v1137: i32 = *v1137;
                                        let v1138: i32 = *v1138;
                                        let v1139: i32 = *v1139;
                                        let v1140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        US11::US11_Ok(v1140.clone(), v1135, v1136, v1137, v1138, v1139)
                                    }
                                }
                            }
                            US11::US11_Ok(v1067, v1068, v1069, v1070, v1071, v1072) => {
                                let v1067: Rc<str> = v1067.clone();
                                let v1068: i32 = *v1068;
                                let v1069: i32 = *v1069;
                                let v1070: i32 = *v1070;
                                let v1071: i32 = *v1071;
                                let v1072: i32 = *v1072;
                                let v1073: bool = v1068 >= v1072;
                                let v1091: US10 = if v1073 {
                                    let v1074: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                    US10::US10_Error(v1074.clone(), v1068, v1069, v1070, v1071, v1072)
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
                                        US10::US10_Ok(b'"', v1078, v1083, v1084, v1085, v1086)
                                    } else {
                                        let v1088: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                        US10::US10_Error(v1088.clone(), v1068, v1069, v1070, v1071, v1072)
                                    }
                                };
                                match &v1091 {
                                    US10::US10_Error(v1099, v1100, v1101, v1102, v1103, v1104) => {
                                        let v1099: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1099.clone();
                                        let v1100: i32 = *v1100;
                                        let v1101: i32 = *v1101;
                                        let v1102: i32 = *v1102;
                                        let v1103: i32 = *v1103;
                                        let v1104: i32 = *v1104;
                                        let v1105: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v838, v1068, v1099.clone(), v1100, v1101, v1102, v1103, v1104);
                                        US11::US11_Error(v1105.clone(), v1068, v1069, v1070, v1071, v1072)
                                    }
                                    US10::US10_Ok(v1092, v1093, v1094, v1095, v1096, v1097) => {
                                        let v1092: u8 = *v1092;
                                        let v1093: i32 = *v1093;
                                        let v1094: i32 = *v1094;
                                        let v1095: i32 = *v1095;
                                        let v1096: i32 = *v1096;
                                        let v1097: i32 = *v1097;
                                        US11::US11_Ok(v1067.clone(), v1093, v1094, v1095, v1096, v1097)
                                    }
                                }
                            }
                        }
                    }
                }
            }
            US11::US11_Ok(v807, v808, v809, v810, v811, v812) => {
                let v807: Rc<str> = v807.clone();
                let v808: i32 = *v808;
                let v809: i32 = *v809;
                let v810: i32 = *v810;
                let v811: i32 = *v811;
                let v812: i32 = *v812;
                v806.clone()
            }
        };
        let v1194: US11 = match &v1164 {
            US11::US11_Error(v1171, v1172, v1173, v1174, v1175, v1176) => {
                let v1171: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1171.clone();
                let v1172: i32 = *v1172;
                let v1173: i32 = *v1173;
                let v1174: i32 = *v1174;
                let v1175: i32 = *v1175;
                let v1176: i32 = *v1176;
                let (mut v1177, mut v1178, mut v1179, mut v1180, mut v1181): (i32, i32, i32, i32, i32) = method77(v4, v5, v6, v7, v0.clone(), v3, v4, v5, v6, v7);
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
                    US11::US11_Ok(v1188.clone(), v1177, v1178, v1179, v1180, v1181)
                } else {
                    let v1190: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                    US11::US11_Error(v1190.clone(), v3, v4, v5, v6, v7)
                }
            }
            US11::US11_Ok(v1165, v1166, v1167, v1168, v1169, v1170) => {
                let v1165: Rc<str> = v1165.clone();
                let v1166: i32 = *v1166;
                let v1167: i32 = *v1167;
                let v1168: i32 = *v1168;
                let v1169: i32 = *v1169;
                let v1170: i32 = *v1170;
                v1164.clone()
            }
        };
        let v1229: US11 = match &v1194 {
            US11::US11_Error(v1201, v1202, v1203, v1204, v1205, v1206) => {
                let v1201: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1201.clone();
                let v1202: i32 = *v1202;
                let v1203: i32 = *v1203;
                let v1204: i32 = *v1204;
                let v1205: i32 = *v1205;
                let v1206: i32 = *v1206;
                let v1207: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                let v1208: US19 = method73(v0.clone(), v1207.clone(), v3, v4, v5, v6, v7);
                match &v1208 {
                    US19::US19_Error(v1219, v1220, v1221, v1222, v1223, v1224) => {
                        let v1219: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1219.clone();
                        let v1220: i32 = *v1220;
                        let v1221: i32 = *v1221;
                        let v1222: i32 = *v1222;
                        let v1223: i32 = *v1223;
                        let v1224: i32 = *v1224;
                        US11::US11_Error(v1219.clone(), v1220, v1221, v1222, v1223, v1224)
                    }
                    US19::US19_Ok(v1209, v1210, v1211, v1212, v1213, v1214) => {
                        let v1209: Rc<UH0> = v1209.clone();
                        let v1210: i32 = *v1210;
                        let v1211: i32 = *v1211;
                        let v1212: i32 = *v1212;
                        let v1213: i32 = *v1213;
                        let v1214: i32 = *v1214;
                        let v1215: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let (mut v1216, mut v1217): (Rc<str>, Rc<str>) = method75(v1209.clone(), v1215.clone(), v1215.clone());
                        US11::US11_Ok(v1216.clone(), v1210, v1211, v1212, v1213, v1214)
                    }
                }
            }
            US11::US11_Ok(v1195, v1196, v1197, v1198, v1199, v1200) => {
                let v1195: Rc<str> = v1195.clone();
                let v1196: i32 = *v1196;
                let v1197: i32 = *v1197;
                let v1198: i32 = *v1198;
                let v1199: i32 = *v1199;
                let v1200: i32 = *v1200;
                v1194.clone()
            }
        };
        let v1240: US11 = match &v1229 {
            US11::US11_Ok(v1230, v1231, v1232, v1233, v1234, v1235) => {
                let v1230: Rc<str> = v1230.clone();
                let v1231: i32 = *v1231;
                let v1232: i32 = *v1232;
                let v1233: i32 = *v1233;
                let v1234: i32 = *v1234;
                let v1235: i32 = *v1235;
                let v1236: bool = v1231 == v3;
                if v1236 {
                    let v1237: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure48();
                    US11::US11_Error(v1237.clone(), v3, v4, v5, v6, v7)
                } else {
                    v1229.clone()
                }
            }
            _ => {
                v1229.clone()
            }
        };
        match &v1240 {
            US11::US11_Error(v1241, v1242, v1243, v1244, v1245, v1246) => {
                let v1241: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1241.clone();
                let v1242: i32 = *v1242;
                let v1243: i32 = *v1243;
                let v1244: i32 = *v1244;
                let v1245: i32 = *v1245;
                let v1246: i32 = *v1246;
                let v1266: Rc<str> = match &*v2 {
                    UH0::UH0_Nil => {
                        v1.clone()
                    }
                    _ => {
                        let v1264: Rc<str> = match &*v2 {
                            UH0::UH0_Cons(v1247, v1248) => {
                                let v1247: Rc<str> = v1247.clone();
                                let v1248: Rc<UH0> = v1248.clone();
                                match &*v1248 {
                                    UH0::UH0_Cons(v1249, v1250) => {
                                        let v1249: Rc<str> = v1249.clone();
                                        let v1250: Rc<UH0> = v1250.clone();
                                        match &*v1250 {
                                            UH0::UH0_Cons(v1251, v1252) => {
                                                let v1251: Rc<str> = v1251.clone();
                                                let v1252: Rc<UH0> = v1252.clone();
                                                let v1253: i32 = 0i32;
                                                let v1254: i32 = method78(v2.clone(), v1253);
                                                let v1255: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(vec![0u8; v1254 as usize]));
                                                let v1256: i32 = method79(v1255.clone(), v2.clone(), v1254);
                                                let v1257: Rc<str> = unsafe { Rc::<str>::from(std::str::from_utf8_unchecked(&v1255.borrow())) };
                                                v1257.clone()
                                            }
                                            _ => {
                                                let v1258: bool = true;
                                                method80(v1258, v2.clone())
                                            }
                                        }
                                    }
                                    _ => {
                                        let v1261: bool = true;
                                        method80(v1261, v2.clone())
                                    }
                                }
                            }
                            _ => unreachable!(),
                        };
                        let v1265: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v1264));
                        v1265.clone()
                    }
                };
                return US11::US11_Ok(v1266.clone(), v3, v4, v5, v6, v7);
            }
            US11::US11_Ok(v1268, v1269, v1270, v1271, v1272, v1273) => {
                let v1268: Rc<str> = v1268.clone();
                let v1269: i32 = *v1269;
                let v1270: i32 = *v1270;
                let v1271: i32 = *v1271;
                let v1272: i32 = *v1272;
                let v1273: i32 = *v1273;
                let v1274: bool = v1269 > v3;
                if v1274 {
                    let v1275: Rc<UH0> = Rc::new(UH0::UH0_Cons(v1268.clone(), v2.clone()));
                    (v0, v1, v2, v3, v4, v5, v6, v7) = (v0.clone(), v1.clone(), v1275.clone(), v1269, v1270, v1271, v1272, v1273);
                    continue;
                } else {
                    let v1277: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure49();
                    return US11::US11_Error(v1277.clone(), v3, v4, v5, v6, v7);
                }
            }
        }
    }
}
fn closure50() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.sep_by / separator consumed no text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method82(mut v0: Rc<str>, mut v1: Rc<UH0>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US19 {
    loop {
        let mut v7: bool = v2 >= v6;
        let (mut v20, mut v21, mut v22, mut v23, mut v24): (i32, i32, i32, i32, i32) = if v7 {
            (v2, v3, v4, v5, v6)
        } else {
            let mut v8: i32 = (v0.clone().len() as i32);
            let mut v9: i32 = method67(v0.clone(), v8, v2);
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
        let mut v29: US12 = if v25 {
            US12::US12_Ok(v20, v21, v22, v23, v24)
        } else {
            let mut v27: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure30();
            US12::US12_Error(v27.clone(), v2, v3, v4, v5, v6)
        };
        match &v29 {
            US12::US12_Error(v30, v31, v32, v33, v34, v35) => {
                let v30: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v30.clone();
                let mut v31: i32 = *v31;
                let mut v32: i32 = *v32;
                let mut v33: i32 = *v33;
                let v34: i32 = *v34;
                let mut v35: i32 = *v35;
                let v36: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                let v37: Rc<UH0> = method74(v1.clone(), v36.clone());
                return US19::US19_Ok(v37.clone(), v2, v3, v4, v5, v6);
            }
            US12::US12_Ok(v39, v40, v41, v42, v43) => {
                let v39: i32 = *v39;
                let v40: i32 = *v40;
                let mut v41: i32 = *v41;
                let mut v42: i32 = *v42;
                let v43: i32 = *v43;
                let v44: bool = v39 == v2;
                if v44 {
                    let mut v45: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure50();
                    return US19::US19_Error(v45.clone(), v2, v3, v4, v5, v6);
                } else {
                    let mut v47: bool = v39 >= v43;
                    let mut v65: US10 = if v47 {
                        let mut v48: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                        US10::US10_Error(v48.clone(), v39, v40, v41, v42, v43)
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
                            US10::US10_Ok(b'\\', v52, v57, v58, v59, v60)
                        } else {
                            let v62: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                            US10::US10_Error(v62.clone(), v39, v40, v41, v42, v43)
                        }
                    };
                    let mut v99: US10 = match &v65 {
                        US10::US10_Error(v91, v92, v93, v94, v95, v96) => {
                            let v91: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v91.clone();
                            let v92: i32 = *v92;
                            let mut v93: i32 = *v93;
                            let v94: i32 = *v94;
                            let v95: i32 = *v95;
                            let v96: i32 = *v96;
                            US10::US10_Error(v91.clone(), v92, v93, v94, v95, v96)
                        }
                        US10::US10_Ok(v66, v67, v68, v69, v70, v71) => {
                            let v66: u8 = *v66;
                            let v67: i32 = *v67;
                            let mut v68: i32 = *v68;
                            let mut v69: i32 = *v69;
                            let mut v70: i32 = *v70;
                            let mut v71: i32 = *v71;
                            let v72: bool = v67 >= v71;
                            if v72 {
                                let mut v73: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_Error(v73.clone(), v67, v68, v69, v70, v71)
                            } else {
                                let v75: u8 = v0.clone().as_bytes()[v67 as usize];
                                let mut v76: bool = v75 == b'"';
                                if v76 {
                                    let mut v77: i32 = v67.wrapping_add(1i32);
                                    let mut v78: bool = b'\n' == v75;
                                    let (mut v82, mut v83, mut v84, mut v85): (i32, i32, i32, i32) = if v78 {
                                        let mut v79: i32 = v68.wrapping_add(v70);
                                        let mut v80: i32 = v69.wrapping_add(1i32);
                                        (v79, v80, 1i32, v71)
                                    } else {
                                        let mut v81: i32 = v70.wrapping_add(1i32);
                                        (v68, v69, v81, v71)
                                    };
                                    US10::US10_Ok(b'"', v77, v82, v83, v84, v85)
                                } else {
                                    let mut v87: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_Error(v87.clone(), v67, v68, v69, v70, v71)
                                }
                            }
                        }
                    };
                    let v115: US10 = match &v99 {
                        US10::US10_Error(v107, v108, v109, v110, v111, v112) => {
                            let mut v107: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v107.clone();
                            let mut v108: i32 = *v108;
                            let v109: i32 = *v109;
                            let mut v110: i32 = *v110;
                            let v111: i32 = *v111;
                            let v112: i32 = *v112;
                            US10::US10_Error(v107.clone(), v108, v109, v110, v111, v112)
                        }
                        US10::US10_Ok(v100, v101, v102, v103, v104, v105) => {
                            let v100: u8 = *v100;
                            let v101: i32 = *v101;
                            let mut v102: i32 = *v102;
                            let mut v103: i32 = *v103;
                            let v104: i32 = *v104;
                            let mut v105: i32 = *v105;
                            US10::US10_Ok(b'"', v101, v102, v103, v104, v105)
                        }
                    };
                    let mut v213: US10 = match &v115 {
                        US10::US10_Error(v122, v123, v124, v125, v126, v127) => {
                            let mut v122: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v122.clone();
                            let v123: i32 = *v123;
                            let mut v124: i32 = *v124;
                            let v125: i32 = *v125;
                            let v126: i32 = *v126;
                            let mut v127: i32 = *v127;
                            let v145: US10 = if v47 {
                                let v128: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                US10::US10_Error(v128.clone(), v39, v40, v41, v42, v43)
                            } else {
                                let mut v130: u8 = v0.clone().as_bytes()[v39 as usize];
                                let v131: bool = v130 == b'`';
                                if v131 {
                                    let v132: i32 = v39.wrapping_add(1i32);
                                    let mut v133: bool = b'\n' == v130;
                                    let (mut v137, mut v138, mut v139, mut v140): (i32, i32, i32, i32) = if v133 {
                                        let v134: i32 = v40.wrapping_add(v42);
                                        let v135: i32 = v41.wrapping_add(1i32);
                                        (v134, v135, 1i32, v43)
                                    } else {
                                        let v136: i32 = v42.wrapping_add(1i32);
                                        (v40, v41, v136, v43)
                                    };
                                    US10::US10_Ok(b'`', v132, v137, v138, v139, v140)
                                } else {
                                    let v142: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US10::US10_Error(v142.clone(), v39, v40, v41, v42, v43)
                                }
                            };
                            let v179: US10 = match &v145 {
                                US10::US10_Error(v171, v172, v173, v174, v175, v176) => {
                                    let v171: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v171.clone();
                                    let mut v172: i32 = *v172;
                                    let mut v173: i32 = *v173;
                                    let v174: i32 = *v174;
                                    let mut v175: i32 = *v175;
                                    let mut v176: i32 = *v176;
                                    US10::US10_Error(v171.clone(), v172, v173, v174, v175, v176)
                                }
                                US10::US10_Ok(v146, v147, v148, v149, v150, v151) => {
                                    let v146: u8 = *v146;
                                    let mut v147: i32 = *v147;
                                    let mut v148: i32 = *v148;
                                    let v149: i32 = *v149;
                                    let mut v150: i32 = *v150;
                                    let mut v151: i32 = *v151;
                                    let mut v152: bool = v147 >= v151;
                                    if v152 {
                                        let mut v153: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                        US10::US10_Error(v153.clone(), v147, v148, v149, v150, v151)
                                    } else {
                                        let mut v155: u8 = v0.clone().as_bytes()[v147 as usize];
                                        let mut v156: bool = v155 == b'"';
                                        if v156 {
                                            let mut v157: i32 = v147.wrapping_add(1i32);
                                            let mut v158: bool = b'\n' == v155;
                                            let (mut v162, mut v163, mut v164, mut v165): (i32, i32, i32, i32) = if v158 {
                                                let v159: i32 = v148.wrapping_add(v150);
                                                let mut v160: i32 = v149.wrapping_add(1i32);
                                                (v159, v160, 1i32, v151)
                                            } else {
                                                let v161: i32 = v150.wrapping_add(1i32);
                                                (v148, v149, v161, v151)
                                            };
                                            US10::US10_Ok(b'"', v157, v162, v163, v164, v165)
                                        } else {
                                            let mut v167: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                            US10::US10_Error(v167.clone(), v147, v148, v149, v150, v151)
                                        }
                                    }
                                }
                            };
                            let v195: US10 = match &v179 {
                                US10::US10_Error(v187, v188, v189, v190, v191, v192) => {
                                    let mut v187: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v187.clone();
                                    let v188: i32 = *v188;
                                    let v189: i32 = *v189;
                                    let v190: i32 = *v190;
                                    let mut v191: i32 = *v191;
                                    let v192: i32 = *v192;
                                    US10::US10_Error(v187.clone(), v188, v189, v190, v191, v192)
                                }
                                US10::US10_Ok(v180, v181, v182, v183, v184, v185) => {
                                    let v180: u8 = *v180;
                                    let v181: i32 = *v181;
                                    let v182: i32 = *v182;
                                    let v183: i32 = *v183;
                                    let v184: i32 = *v184;
                                    let v185: i32 = *v185;
                                    US10::US10_Ok(b'"', v181, v182, v183, v184, v185)
                                }
                            };
                            match &v195 {
                                US10::US10_Error(v202, v203, v204, v205, v206, v207) => {
                                    let v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v202.clone();
                                    let v203: i32 = *v203;
                                    let v204: i32 = *v204;
                                    let v205: i32 = *v205;
                                    let mut v206: i32 = *v206;
                                    let v207: i32 = *v207;
                                    let mut v208: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_Error(v208.clone(), v39, v40, v41, v42, v43)
                                }
                                US10::US10_Ok(v196, v197, v198, v199, v200, v201) => {
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
                        US10::US10_Ok(v116, v117, v118, v119, v120, v121) => {
                            let mut v116: u8 = *v116;
                            let v117: i32 = *v117;
                            let v118: i32 = *v118;
                            let mut v119: i32 = *v119;
                            let v120: i32 = *v120;
                            let mut v121: i32 = *v121;
                            v115.clone()
                        }
                    };
                    let v845: US11 = match &v213 {
                        US10::US10_Error(v837, v838, v839, v840, v841, v842) => {
                            let v837: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v837.clone();
                            let v838: i32 = *v838;
                            let v839: i32 = *v839;
                            let v840: i32 = *v840;
                            let v841: i32 = *v841;
                            let v842: i32 = *v842;
                            US11::US11_Error(v837.clone(), v838, v839, v840, v841, v842)
                        }
                        US10::US10_Ok(v214, v215, v216, v217, v218, v219) => {
                            let v214: u8 = *v214;
                            let v215: i32 = *v215;
                            let mut v216: i32 = *v216;
                            let v217: i32 = *v217;
                            let mut v218: i32 = *v218;
                            let v219: i32 = *v219;
                            let (mut v220, mut v221, mut v222, mut v223, mut v224): (i32, i32, i32, i32, i32) = method69(v216, v217, v218, v219, v0.clone(), v215, v216, v217, v218, v219);
                            let mut v225: bool = v220 > v215;
                            let v235: US11 = if v225 {
                                let mut v226: bool = v215 >= v220;
                                let v231: Rc<str> = if v226 {
                                    let v227: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v227.clone()
                                } else {
                                    let v229: i32 = v220.wrapping_sub(1i32);
                                    let v230: Rc<str> = string_slice(&v0.clone(), v215 as i64, v229 as i64);
                                    v230.clone()
                                };
                                US11::US11_Ok(v231.clone(), v220, v221, v222, v223, v224)
                            } else {
                                let v233: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                US11::US11_Error(v233.clone(), v215, v216, v217, v218, v219)
                            };
                            let v430: US11 = match &v235 {
                                US11::US11_Error(v242, v243, v244, v245, v246, v247) => {
                                    let v242: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v242.clone();
                                    let v243: i32 = *v243;
                                    let mut v244: i32 = *v244;
                                    let v245: i32 = *v245;
                                    let v246: i32 = *v246;
                                    let v247: i32 = *v247;
                                    let v248: bool = v215 >= v219;
                                    let v266: US10 = if v248 {
                                        let mut v249: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                        US10::US10_Error(v249.clone(), v215, v216, v217, v218, v219)
                                    } else {
                                        let v251: u8 = v0.clone().as_bytes()[v215 as usize];
                                        let v252: bool = v251 == b'\\';
                                        if v252 {
                                            let v253: i32 = v215.wrapping_add(1i32);
                                            let v254: bool = b'\n' == v251;
                                            let (mut v258, mut v259, mut v260, mut v261): (i32, i32, i32, i32) = if v254 {
                                                let mut v255: i32 = v216.wrapping_add(v218);
                                                let v256: i32 = v217.wrapping_add(1i32);
                                                (v255, v256, 1i32, v219)
                                            } else {
                                                let v257: i32 = v218.wrapping_add(1i32);
                                                (v216, v217, v257, v219)
                                            };
                                            US10::US10_Ok(b'\\', v253, v258, v259, v260, v261)
                                        } else {
                                            let v263: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                            US10::US10_Error(v263.clone(), v215, v216, v217, v218, v219)
                                        }
                                    };
                                    let v301: US10 = match &v266 {
                                        US10::US10_Error(v293, v294, v295, v296, v297, v298) => {
                                            let v293: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v293.clone();
                                            let v294: i32 = *v294;
                                            let v295: i32 = *v295;
                                            let v296: i32 = *v296;
                                            let v297: i32 = *v297;
                                            let v298: i32 = *v298;
                                            US10::US10_Error(v293.clone(), v294, v295, v296, v297, v298)
                                        }
                                        US10::US10_Ok(v267, v268, v269, v270, v271, v272) => {
                                            let v267: u8 = *v267;
                                            let v268: i32 = *v268;
                                            let v269: i32 = *v269;
                                            let v270: i32 = *v270;
                                            let v271: i32 = *v271;
                                            let mut v272: i32 = *v272;
                                            let v273: bool = v268 >= v272;
                                            if v273 {
                                                let v274: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                                US10::US10_Error(v274.clone(), v268, v269, v270, v271, v272)
                                            } else {
                                                let v276: u8 = v0.clone().as_bytes()[v268 as usize];
                                                let v277: bool = v276 == b'"';
                                                let v278: bool = v277 == false;
                                                if v278 {
                                                    let v279: i32 = v268.wrapping_add(1i32);
                                                    let mut v280: bool = b'\n' == v276;
                                                    let (mut v284, mut v285, mut v286, mut v287): (i32, i32, i32, i32) = if v280 {
                                                        let mut v281: i32 = v269.wrapping_add(v271);
                                                        let v282: i32 = v270.wrapping_add(1i32);
                                                        (v281, v282, 1i32, v272)
                                                    } else {
                                                        let mut v283: i32 = v271.wrapping_add(1i32);
                                                        (v269, v270, v283, v272)
                                                    };
                                                    US10::US10_Ok(v276, v279, v284, v285, v286, v287)
                                                } else {
                                                    let v289: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                    US10::US10_Error(v289.clone(), v268, v269, v270, v271, v272)
                                                }
                                            }
                                        }
                                    };
                                    let v323: US11 = match &v301 {
                                        US10::US10_Error(v315, v316, v317, v318, v319, v320) => {
                                            let v315: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v315.clone();
                                            let v316: i32 = *v316;
                                            let v317: i32 = *v317;
                                            let v318: i32 = *v318;
                                            let v319: i32 = *v319;
                                            let v320: i32 = *v320;
                                            US11::US11_Error(v315.clone(), v316, v317, v318, v319, v320)
                                        }
                                        US10::US10_Ok(v302, v303, v304, v305, v306, v307) => {
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
                                                let mut v312: Rc<str> = string_slice(&v0.clone(), v215 as i64, v311 as i64);
                                                v312.clone()
                                            };
                                            US11::US11_Ok(v313.clone(), v303, v304, v305, v306, v307)
                                        }
                                    };
                                    match &v323 {
                                        US11::US11_Error(v330, v331, v332, v333, v334, v335) => {
                                            let mut v330: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v330.clone();
                                            let v331: i32 = *v331;
                                            let v332: i32 = *v332;
                                            let v333: i32 = *v333;
                                            let v334: i32 = *v334;
                                            let v335: i32 = *v335;
                                            let v353: US10 = if v248 {
                                                let v336: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                                US10::US10_Error(v336.clone(), v215, v216, v217, v218, v219)
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
                                                    US10::US10_Ok(b'`', v340, v345, v346, v347, v348)
                                                } else {
                                                    let v350: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                    US10::US10_Error(v350.clone(), v215, v216, v217, v218, v219)
                                                }
                                            };
                                            let v388: US10 = match &v353 {
                                                US10::US10_Error(v380, v381, v382, v383, v384, v385) => {
                                                    let v380: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v380.clone();
                                                    let mut v381: i32 = *v381;
                                                    let v382: i32 = *v382;
                                                    let v383: i32 = *v383;
                                                    let v384: i32 = *v384;
                                                    let v385: i32 = *v385;
                                                    US10::US10_Error(v380.clone(), v381, v382, v383, v384, v385)
                                                }
                                                US10::US10_Ok(v354, v355, v356, v357, v358, v359) => {
                                                    let v354: u8 = *v354;
                                                    let v355: i32 = *v355;
                                                    let v356: i32 = *v356;
                                                    let mut v357: i32 = *v357;
                                                    let v358: i32 = *v358;
                                                    let v359: i32 = *v359;
                                                    let v360: bool = v355 >= v359;
                                                    if v360 {
                                                        let v361: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                                        US10::US10_Error(v361.clone(), v355, v356, v357, v358, v359)
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
                                                            US10::US10_Ok(v363, v366, v371, v372, v373, v374)
                                                        } else {
                                                            let v376: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                            US10::US10_Error(v376.clone(), v355, v356, v357, v358, v359)
                                                        }
                                                    }
                                                }
                                            };
                                            let v410: US11 = match &v388 {
                                                US10::US10_Error(v402, v403, v404, v405, v406, v407) => {
                                                    let v402: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v402.clone();
                                                    let v403: i32 = *v403;
                                                    let v404: i32 = *v404;
                                                    let v405: i32 = *v405;
                                                    let v406: i32 = *v406;
                                                    let v407: i32 = *v407;
                                                    US11::US11_Error(v402.clone(), v403, v404, v405, v406, v407)
                                                }
                                                US10::US10_Ok(v389, v390, v391, v392, v393, v394) => {
                                                    let v389: u8 = *v389;
                                                    let v390: i32 = *v390;
                                                    let v391: i32 = *v391;
                                                    let v392: i32 = *v392;
                                                    let v393: i32 = *v393;
                                                    let v394: i32 = *v394;
                                                    let v395: bool = v215 >= v390;
                                                    let v400: Rc<str> = if v395 {
                                                        let v396: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                        v396.clone()
                                                    } else {
                                                        let v398: i32 = v390.wrapping_sub(1i32);
                                                        let v399: Rc<str> = string_slice(&v0.clone(), v215 as i64, v398 as i64);
                                                        v399.clone()
                                                    };
                                                    US11::US11_Ok(v400.clone(), v390, v391, v392, v393, v394)
                                                }
                                            };
                                            match &v410 {
                                                US11::US11_Error(v417, v418, v419, v420, v421, v422) => {
                                                    let v417: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v417.clone();
                                                    let v418: i32 = *v418;
                                                    let v419: i32 = *v419;
                                                    let v420: i32 = *v420;
                                                    let v421: i32 = *v421;
                                                    let v422: i32 = *v422;
                                                    let v423: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                    US11::US11_Error(v423.clone(), v215, v216, v217, v218, v219)
                                                }
                                                US11::US11_Ok(v411, v412, v413, v414, v415, v416) => {
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
                                        US11::US11_Ok(v324, v325, v326, v327, v328, v329) => {
                                            let v324: Rc<str> = v324.clone();
                                            let v325: i32 = *v325;
                                            let v326: i32 = *v326;
                                            let mut v327: i32 = *v327;
                                            let v328: i32 = *v328;
                                            let v329: i32 = *v329;
                                            v323.clone()
                                        }
                                    }
                                }
                                US11::US11_Ok(v236, v237, v238, v239, v240, v241) => {
                                    let v236: Rc<str> = v236.clone();
                                    let mut v237: i32 = *v237;
                                    let v238: i32 = *v238;
                                    let mut v239: i32 = *v239;
                                    let v240: i32 = *v240;
                                    let v241: i32 = *v241;
                                    v235.clone()
                                }
                            };
                            let v453: US11 = match &v430 {
                                US11::US11_Error(v431, v432, v433, v434, v435, v436) => {
                                    let v431: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v431.clone();
                                    let v432: i32 = *v432;
                                    let v433: i32 = *v433;
                                    let v434: i32 = *v434;
                                    let v435: i32 = *v435;
                                    let v436: i32 = *v436;
                                    let v437: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    US11::US11_Ok(v437.clone(), v215, v216, v217, v218, v219)
                                }
                                US11::US11_Ok(v439, v440, v441, v442, v443, v444) => {
                                    let v439: Rc<str> = v439.clone();
                                    let v440: i32 = *v440;
                                    let v441: i32 = *v441;
                                    let v442: i32 = *v442;
                                    let v443: i32 = *v443;
                                    let v444: i32 = *v444;
                                    let v445: bool = v440 == v215;
                                    if v445 {
                                        let v446: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                        US11::US11_Error(v446.clone(), v215, v216, v217, v218, v219)
                                    } else {
                                        let v448: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                        let v449: i32 = 0i32;
                                        method70(v0.clone(), v448.clone(), v448.clone(), v439.clone(), v449, v440, v441, v442, v443, v444)
                                    }
                                }
                            };
                            match &v453 {
                                US11::US11_Error(v644, v645, v646, v647, v648, v649) => {
                                    let v644: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v644.clone();
                                    let v645: i32 = *v645;
                                    let v646: i32 = *v646;
                                    let v647: i32 = *v647;
                                    let v648: i32 = *v648;
                                    let v649: i32 = *v649;
                                    let v650: bool = v215 >= v219;
                                    let v668: US10 = if v650 {
                                        let v651: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                        US10::US10_Error(v651.clone(), v215, v216, v217, v218, v219)
                                    } else {
                                        let v653: u8 = v0.clone().as_bytes()[v215 as usize];
                                        let v654: bool = v653 == b'\\';
                                        if v654 {
                                            let v655: i32 = v215.wrapping_add(1i32);
                                            let v656: bool = b'\n' == v653;
                                            let (mut v660, mut v661, mut v662, mut v663): (i32, i32, i32, i32) = if v656 {
                                                let v657: i32 = v216.wrapping_add(v218);
                                                let v658: i32 = v217.wrapping_add(1i32);
                                                (v657, v658, 1i32, v219)
                                            } else {
                                                let v659: i32 = v218.wrapping_add(1i32);
                                                (v216, v217, v659, v219)
                                            };
                                            US10::US10_Ok(b'\\', v655, v660, v661, v662, v663)
                                        } else {
                                            let v665: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                            US10::US10_Error(v665.clone(), v215, v216, v217, v218, v219)
                                        }
                                    };
                                    let v702: US10 = match &v668 {
                                        US10::US10_Error(v694, v695, v696, v697, v698, v699) => {
                                            let v694: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v694.clone();
                                            let v695: i32 = *v695;
                                            let v696: i32 = *v696;
                                            let v697: i32 = *v697;
                                            let v698: i32 = *v698;
                                            let v699: i32 = *v699;
                                            US10::US10_Error(v694.clone(), v695, v696, v697, v698, v699)
                                        }
                                        US10::US10_Ok(v669, v670, v671, v672, v673, v674) => {
                                            let v669: u8 = *v669;
                                            let v670: i32 = *v670;
                                            let mut v671: i32 = *v671;
                                            let v672: i32 = *v672;
                                            let v673: i32 = *v673;
                                            let v674: i32 = *v674;
                                            let v675: bool = v670 >= v674;
                                            if v675 {
                                                let v676: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                US10::US10_Error(v676.clone(), v670, v671, v672, v673, v674)
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
                                                    US10::US10_Ok(b'"', v680, v685, v686, v687, v688)
                                                } else {
                                                    let v690: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                    US10::US10_Error(v690.clone(), v670, v671, v672, v673, v674)
                                                }
                                            }
                                        }
                                    };
                                    let v718: US10 = match &v702 {
                                        US10::US10_Error(v710, v711, v712, v713, v714, v715) => {
                                            let v710: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v710.clone();
                                            let v711: i32 = *v711;
                                            let v712: i32 = *v712;
                                            let v713: i32 = *v713;
                                            let v714: i32 = *v714;
                                            let v715: i32 = *v715;
                                            US10::US10_Error(v710.clone(), v711, v712, v713, v714, v715)
                                        }
                                        US10::US10_Ok(v703, v704, v705, v706, v707, v708) => {
                                            let v703: u8 = *v703;
                                            let v704: i32 = *v704;
                                            let v705: i32 = *v705;
                                            let v706: i32 = *v706;
                                            let v707: i32 = *v707;
                                            let v708: i32 = *v708;
                                            US10::US10_Ok(b'"', v704, v705, v706, v707, v708)
                                        }
                                    };
                                    let v816: US10 = match &v718 {
                                        US10::US10_Error(v725, v726, v727, v728, v729, v730) => {
                                            let v725: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v725.clone();
                                            let v726: i32 = *v726;
                                            let v727: i32 = *v727;
                                            let v728: i32 = *v728;
                                            let v729: i32 = *v729;
                                            let v730: i32 = *v730;
                                            let v748: US10 = if v650 {
                                                let v731: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                                US10::US10_Error(v731.clone(), v215, v216, v217, v218, v219)
                                            } else {
                                                let v733: u8 = v0.clone().as_bytes()[v215 as usize];
                                                let v734: bool = v733 == b'`';
                                                if v734 {
                                                    let v735: i32 = v215.wrapping_add(1i32);
                                                    let v736: bool = b'\n' == v733;
                                                    let (mut v740, mut v741, mut v742, mut v743): (i32, i32, i32, i32) = if v736 {
                                                        let v737: i32 = v216.wrapping_add(v218);
                                                        let v738: i32 = v217.wrapping_add(1i32);
                                                        (v737, v738, 1i32, v219)
                                                    } else {
                                                        let v739: i32 = v218.wrapping_add(1i32);
                                                        (v216, v217, v739, v219)
                                                    };
                                                    US10::US10_Ok(b'`', v735, v740, v741, v742, v743)
                                                } else {
                                                    let v745: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                    US10::US10_Error(v745.clone(), v215, v216, v217, v218, v219)
                                                }
                                            };
                                            let v782: US10 = match &v748 {
                                                US10::US10_Error(v774, v775, v776, v777, v778, v779) => {
                                                    let v774: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v774.clone();
                                                    let v775: i32 = *v775;
                                                    let v776: i32 = *v776;
                                                    let v777: i32 = *v777;
                                                    let v778: i32 = *v778;
                                                    let v779: i32 = *v779;
                                                    US10::US10_Error(v774.clone(), v775, v776, v777, v778, v779)
                                                }
                                                US10::US10_Ok(v749, v750, v751, v752, v753, v754) => {
                                                    let v749: u8 = *v749;
                                                    let mut v750: i32 = *v750;
                                                    let v751: i32 = *v751;
                                                    let v752: i32 = *v752;
                                                    let v753: i32 = *v753;
                                                    let v754: i32 = *v754;
                                                    let v755: bool = v750 >= v754;
                                                    if v755 {
                                                        let v756: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                        US10::US10_Error(v756.clone(), v750, v751, v752, v753, v754)
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
                                                                let v764: i32 = v753.wrapping_add(1i32);
                                                                (v751, v752, v764, v754)
                                                            };
                                                            US10::US10_Ok(b'"', v760, v765, v766, v767, v768)
                                                        } else {
                                                            let v770: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                            US10::US10_Error(v770.clone(), v750, v751, v752, v753, v754)
                                                        }
                                                    }
                                                }
                                            };
                                            let mut v798: US10 = match &v782 {
                                                US10::US10_Error(v790, v791, v792, v793, v794, v795) => {
                                                    let v790: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v790.clone();
                                                    let v791: i32 = *v791;
                                                    let v792: i32 = *v792;
                                                    let v793: i32 = *v793;
                                                    let v794: i32 = *v794;
                                                    let v795: i32 = *v795;
                                                    US10::US10_Error(v790.clone(), v791, v792, v793, v794, v795)
                                                }
                                                US10::US10_Ok(v783, v784, v785, v786, v787, v788) => {
                                                    let v783: u8 = *v783;
                                                    let v784: i32 = *v784;
                                                    let v785: i32 = *v785;
                                                    let v786: i32 = *v786;
                                                    let v787: i32 = *v787;
                                                    let v788: i32 = *v788;
                                                    US10::US10_Ok(b'"', v784, v785, v786, v787, v788)
                                                }
                                            };
                                            match &v798 {
                                                US10::US10_Error(v805, v806, v807, v808, v809, v810) => {
                                                    let v805: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v805.clone();
                                                    let v806: i32 = *v806;
                                                    let v807: i32 = *v807;
                                                    let v808: i32 = *v808;
                                                    let v809: i32 = *v809;
                                                    let v810: i32 = *v810;
                                                    let v811: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                    US10::US10_Error(v811.clone(), v215, v216, v217, v218, v219)
                                                }
                                                US10::US10_Ok(v799, v800, v801, v802, v803, v804) => {
                                                    let v799: u8 = *v799;
                                                    let v800: i32 = *v800;
                                                    let mut v801: i32 = *v801;
                                                    let v802: i32 = *v802;
                                                    let v803: i32 = *v803;
                                                    let v804: i32 = *v804;
                                                    v798.clone()
                                                }
                                            }
                                        }
                                        US10::US10_Ok(v719, v720, v721, v722, v723, v724) => {
                                            let mut v719: u8 = *v719;
                                            let v720: i32 = *v720;
                                            let v721: i32 = *v721;
                                            let mut v722: i32 = *v722;
                                            let v723: i32 = *v723;
                                            let v724: i32 = *v724;
                                            v718.clone()
                                        }
                                    };
                                    match &v816 {
                                        US10::US10_Error(v825, v826, v827, v828, v829, v830) => {
                                            let v825: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v825.clone();
                                            let v826: i32 = *v826;
                                            let v827: i32 = *v827;
                                            let v828: i32 = *v828;
                                            let mut v829: i32 = *v829;
                                            let v830: i32 = *v830;
                                            let v831: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                            US11::US11_Error(v831.clone(), v215, v216, v217, v218, v219)
                                        }
                                        US10::US10_Ok(v817, v818, v819, v820, v821, v822) => {
                                            let v817: u8 = *v817;
                                            let v818: i32 = *v818;
                                            let v819: i32 = *v819;
                                            let v820: i32 = *v820;
                                            let v821: i32 = *v821;
                                            let v822: i32 = *v822;
                                            let v823: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            US11::US11_Ok(v823.clone(), v818, v819, v820, v821, v822)
                                        }
                                    }
                                }
                                US11::US11_Ok(v454, v455, v456, v457, v458, v459) => {
                                    let v454: Rc<str> = v454.clone();
                                    let v455: i32 = *v455;
                                    let v456: i32 = *v456;
                                    let v457: i32 = *v457;
                                    let v458: i32 = *v458;
                                    let v459: i32 = *v459;
                                    let v460: bool = v455 >= v459;
                                    let mut v478: US10 = if v460 {
                                        let v461: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                        US10::US10_Error(v461.clone(), v455, v456, v457, v458, v459)
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
                                            US10::US10_Ok(b'\\', v465, v470, v471, v472, v473)
                                        } else {
                                            let v475: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                            US10::US10_Error(v475.clone(), v455, v456, v457, v458, v459)
                                        }
                                    };
                                    let v512: US10 = match &v478 {
                                        US10::US10_Error(v504, v505, v506, v507, v508, v509) => {
                                            let v504: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v504.clone();
                                            let v505: i32 = *v505;
                                            let v506: i32 = *v506;
                                            let v507: i32 = *v507;
                                            let v508: i32 = *v508;
                                            let mut v509: i32 = *v509;
                                            US10::US10_Error(v504.clone(), v505, v506, v507, v508, v509)
                                        }
                                        US10::US10_Ok(v479, v480, v481, v482, v483, v484) => {
                                            let v479: u8 = *v479;
                                            let v480: i32 = *v480;
                                            let mut v481: i32 = *v481;
                                            let v482: i32 = *v482;
                                            let v483: i32 = *v483;
                                            let v484: i32 = *v484;
                                            let v485: bool = v480 >= v484;
                                            if v485 {
                                                let v486: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                US10::US10_Error(v486.clone(), v480, v481, v482, v483, v484)
                                            } else {
                                                let v488: u8 = v0.clone().as_bytes()[v480 as usize];
                                                let v489: bool = v488 == b'"';
                                                if v489 {
                                                    let v490: i32 = v480.wrapping_add(1i32);
                                                    let v491: bool = b'\n' == v488;
                                                    let (mut v495, mut v496, mut v497, mut v498): (i32, i32, i32, i32) = if v491 {
                                                        let v492: i32 = v481.wrapping_add(v483);
                                                        let v493: i32 = v482.wrapping_add(1i32);
                                                        (v492, v493, 1i32, v484)
                                                    } else {
                                                        let v494: i32 = v483.wrapping_add(1i32);
                                                        (v481, v482, v494, v484)
                                                    };
                                                    US10::US10_Ok(b'"', v490, v495, v496, v497, v498)
                                                } else {
                                                    let v500: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                    US10::US10_Error(v500.clone(), v480, v481, v482, v483, v484)
                                                }
                                            }
                                        }
                                    };
                                    let v528: US10 = match &v512 {
                                        US10::US10_Error(v520, v521, v522, v523, v524, v525) => {
                                            let v520: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v520.clone();
                                            let v521: i32 = *v521;
                                            let v522: i32 = *v522;
                                            let v523: i32 = *v523;
                                            let v524: i32 = *v524;
                                            let v525: i32 = *v525;
                                            US10::US10_Error(v520.clone(), v521, v522, v523, v524, v525)
                                        }
                                        US10::US10_Ok(v513, v514, v515, v516, v517, v518) => {
                                            let v513: u8 = *v513;
                                            let v514: i32 = *v514;
                                            let v515: i32 = *v515;
                                            let v516: i32 = *v516;
                                            let v517: i32 = *v517;
                                            let v518: i32 = *v518;
                                            US10::US10_Ok(b'"', v514, v515, v516, v517, v518)
                                        }
                                    };
                                    let v626: US10 = match &v528 {
                                        US10::US10_Error(v535, v536, v537, v538, v539, v540) => {
                                            let v535: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v535.clone();
                                            let v536: i32 = *v536;
                                            let v537: i32 = *v537;
                                            let v538: i32 = *v538;
                                            let v539: i32 = *v539;
                                            let v540: i32 = *v540;
                                            let v558: US10 = if v460 {
                                                let v541: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                                US10::US10_Error(v541.clone(), v455, v456, v457, v458, v459)
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
                                                    US10::US10_Ok(b'`', v545, v550, v551, v552, v553)
                                                } else {
                                                    let v555: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                    US10::US10_Error(v555.clone(), v455, v456, v457, v458, v459)
                                                }
                                            };
                                            let v592: US10 = match &v558 {
                                                US10::US10_Error(v584, v585, v586, v587, v588, v589) => {
                                                    let v584: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v584.clone();
                                                    let v585: i32 = *v585;
                                                    let v586: i32 = *v586;
                                                    let v587: i32 = *v587;
                                                    let v588: i32 = *v588;
                                                    let v589: i32 = *v589;
                                                    US10::US10_Error(v584.clone(), v585, v586, v587, v588, v589)
                                                }
                                                US10::US10_Ok(v559, v560, v561, v562, v563, v564) => {
                                                    let v559: u8 = *v559;
                                                    let mut v560: i32 = *v560;
                                                    let v561: i32 = *v561;
                                                    let v562: i32 = *v562;
                                                    let mut v563: i32 = *v563;
                                                    let v564: i32 = *v564;
                                                    let v565: bool = v560 >= v564;
                                                    if v565 {
                                                        let v566: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                        US10::US10_Error(v566.clone(), v560, v561, v562, v563, v564)
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
                                                                let v574: i32 = v563.wrapping_add(1i32);
                                                                (v561, v562, v574, v564)
                                                            };
                                                            US10::US10_Ok(b'"', v570, v575, v576, v577, v578)
                                                        } else {
                                                            let mut v580: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                            US10::US10_Error(v580.clone(), v560, v561, v562, v563, v564)
                                                        }
                                                    }
                                                }
                                            };
                                            let v608: US10 = match &v592 {
                                                US10::US10_Error(v600, v601, v602, v603, v604, v605) => {
                                                    let v600: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v600.clone();
                                                    let v601: i32 = *v601;
                                                    let v602: i32 = *v602;
                                                    let v603: i32 = *v603;
                                                    let v604: i32 = *v604;
                                                    let v605: i32 = *v605;
                                                    US10::US10_Error(v600.clone(), v601, v602, v603, v604, v605)
                                                }
                                                US10::US10_Ok(v593, v594, v595, v596, v597, v598) => {
                                                    let v593: u8 = *v593;
                                                    let mut v594: i32 = *v594;
                                                    let v595: i32 = *v595;
                                                    let v596: i32 = *v596;
                                                    let v597: i32 = *v597;
                                                    let v598: i32 = *v598;
                                                    US10::US10_Ok(b'"', v594, v595, v596, v597, v598)
                                                }
                                            };
                                            match &v608 {
                                                US10::US10_Error(v615, v616, v617, v618, v619, v620) => {
                                                    let v615: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v615.clone();
                                                    let v616: i32 = *v616;
                                                    let v617: i32 = *v617;
                                                    let v618: i32 = *v618;
                                                    let v619: i32 = *v619;
                                                    let v620: i32 = *v620;
                                                    let v621: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                    US10::US10_Error(v621.clone(), v455, v456, v457, v458, v459)
                                                }
                                                US10::US10_Ok(v609, v610, v611, v612, v613, v614) => {
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
                                        US10::US10_Ok(v529, v530, v531, v532, v533, v534) => {
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
                                        US10::US10_Error(v634, v635, v636, v637, v638, v639) => {
                                            let v634: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v634.clone();
                                            let v635: i32 = *v635;
                                            let v636: i32 = *v636;
                                            let v637: i32 = *v637;
                                            let v638: i32 = *v638;
                                            let v639: i32 = *v639;
                                            let mut v640: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v215, v455, v634.clone(), v635, v636, v637, v638, v639);
                                            US11::US11_Error(v640.clone(), v455, v456, v457, v458, v459)
                                        }
                                        US10::US10_Ok(v627, v628, v629, v630, v631, v632) => {
                                            let v627: u8 = *v627;
                                            let v628: i32 = *v628;
                                            let v629: i32 = *v629;
                                            let v630: i32 = *v630;
                                            let v631: i32 = *v631;
                                            let v632: i32 = *v632;
                                            US11::US11_Ok(v454.clone(), v628, v629, v630, v631, v632)
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v1203: US11 = match &v845 {
                        US11::US11_Error(v852, v853, v854, v855, v856, v857) => {
                            let v852: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v852.clone();
                            let v853: i32 = *v853;
                            let v854: i32 = *v854;
                            let v855: i32 = *v855;
                            let v856: i32 = *v856;
                            let v857: i32 = *v857;
                            let v875: US10 = if v47 {
                                let v858: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_Error(v858.clone(), v39, v40, v41, v42, v43)
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
                                    US10::US10_Ok(b'"', v862, v867, v868, v869, v870)
                                } else {
                                    let v872: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_Error(v872.clone(), v39, v40, v41, v42, v43)
                                }
                            };
                            match &v875 {
                                US10::US10_Error(v1193, v1194, v1195, v1196, v1197, v1198) => {
                                    let v1193: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1193.clone();
                                    let v1194: i32 = *v1194;
                                    let v1195: i32 = *v1195;
                                    let v1196: i32 = *v1196;
                                    let v1197: i32 = *v1197;
                                    let v1198: i32 = *v1198;
                                    US11::US11_Error(v1193.clone(), v1194, v1195, v1196, v1197, v1198)
                                }
                                US10::US10_Ok(v876, v877, v878, v879, v880, v881) => {
                                    let v876: u8 = *v876;
                                    let mut v877: i32 = *v877;
                                    let v878: i32 = *v878;
                                    let v879: i32 = *v879;
                                    let mut v880: i32 = *v880;
                                    let v881: i32 = *v881;
                                    let (mut v882, mut v883, mut v884, mut v885, mut v886): (i32, i32, i32, i32, i32) = method69(v878, v879, v880, v881, v0.clone(), v877, v878, v879, v880, v881);
                                    let v887: bool = v882 > v877;
                                    let v897: US11 = if v887 {
                                        let v888: bool = v877 >= v882;
                                        let v893: Rc<str> = if v888 {
                                            let v889: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            v889.clone()
                                        } else {
                                            let v891: i32 = v882.wrapping_sub(1i32);
                                            let v892: Rc<str> = string_slice(&v0.clone(), v877 as i64, v891 as i64);
                                            v892.clone()
                                        };
                                        US11::US11_Ok(v893.clone(), v882, v883, v884, v885, v886)
                                    } else {
                                        let v895: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                        US11::US11_Error(v895.clone(), v877, v878, v879, v880, v881)
                                    };
                                    let v1082: US11 = match &v897 {
                                        US11::US11_Error(v904, v905, v906, v907, v908, v909) => {
                                            let v904: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v904.clone();
                                            let v905: i32 = *v905;
                                            let v906: i32 = *v906;
                                            let v907: i32 = *v907;
                                            let mut v908: i32 = *v908;
                                            let v909: i32 = *v909;
                                            let v910: bool = v877 >= v881;
                                            let v928: US10 = if v910 {
                                                let v911: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                                US10::US10_Error(v911.clone(), v877, v878, v879, v880, v881)
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
                                                    US10::US10_Ok(b'\\', v915, v920, v921, v922, v923)
                                                } else {
                                                    let v925: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                                    US10::US10_Error(v925.clone(), v877, v878, v879, v880, v881)
                                                }
                                            };
                                            let v958: US10 = match &v928 {
                                                US10::US10_Error(v950, v951, v952, v953, v954, v955) => {
                                                    let v950: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v950.clone();
                                                    let v951: i32 = *v951;
                                                    let v952: i32 = *v952;
                                                    let v953: i32 = *v953;
                                                    let v954: i32 = *v954;
                                                    let v955: i32 = *v955;
                                                    US10::US10_Error(v950.clone(), v951, v952, v953, v954, v955)
                                                }
                                                US10::US10_Ok(v929, v930, v931, v932, v933, v934) => {
                                                    let v929: u8 = *v929;
                                                    let v930: i32 = *v930;
                                                    let v931: i32 = *v931;
                                                    let v932: i32 = *v932;
                                                    let v933: i32 = *v933;
                                                    let v934: i32 = *v934;
                                                    let v935: bool = v930 >= v934;
                                                    if v935 {
                                                        let v936: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                        US10::US10_Error(v936.clone(), v930, v931, v932, v933, v934)
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
                                                        US10::US10_Ok(v938, v939, v944, v945, v946, v947)
                                                    }
                                                }
                                            };
                                            let v980: US11 = match &v958 {
                                                US10::US10_Error(v972, v973, v974, v975, v976, v977) => {
                                                    let v972: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v972.clone();
                                                    let v973: i32 = *v973;
                                                    let v974: i32 = *v974;
                                                    let v975: i32 = *v975;
                                                    let v976: i32 = *v976;
                                                    let v977: i32 = *v977;
                                                    US11::US11_Error(v972.clone(), v973, v974, v975, v976, v977)
                                                }
                                                US10::US10_Ok(v959, v960, v961, v962, v963, v964) => {
                                                    let mut v959: u8 = *v959;
                                                    let v960: i32 = *v960;
                                                    let v961: i32 = *v961;
                                                    let v962: i32 = *v962;
                                                    let v963: i32 = *v963;
                                                    let v964: i32 = *v964;
                                                    let v965: bool = v877 >= v960;
                                                    let v970: Rc<str> = if v965 {
                                                        let v966: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                        v966.clone()
                                                    } else {
                                                        let v968: i32 = v960.wrapping_sub(1i32);
                                                        let v969: Rc<str> = string_slice(&v0.clone(), v877 as i64, v968 as i64);
                                                        v969.clone()
                                                    };
                                                    US11::US11_Ok(v970.clone(), v960, v961, v962, v963, v964)
                                                }
                                            };
                                            match &v980 {
                                                US11::US11_Error(v987, v988, v989, v990, v991, v992) => {
                                                    let mut v987: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v987.clone();
                                                    let v988: i32 = *v988;
                                                    let v989: i32 = *v989;
                                                    let v990: i32 = *v990;
                                                    let v991: i32 = *v991;
                                                    let v992: i32 = *v992;
                                                    let v1010: US10 = if v910 {
                                                        let v993: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                                        US10::US10_Error(v993.clone(), v877, v878, v879, v880, v881)
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
                                                                let v1001: i32 = v880.wrapping_add(1i32);
                                                                (v878, v879, v1001, v881)
                                                            };
                                                            US10::US10_Ok(b'`', v997, v1002, v1003, v1004, v1005)
                                                        } else {
                                                            let v1007: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                            US10::US10_Error(v1007.clone(), v877, v878, v879, v880, v881)
                                                        }
                                                    };
                                                    let v1040: US10 = match &v1010 {
                                                        US10::US10_Error(v1032, v1033, v1034, v1035, v1036, v1037) => {
                                                            let v1032: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1032.clone();
                                                            let v1033: i32 = *v1033;
                                                            let v1034: i32 = *v1034;
                                                            let v1035: i32 = *v1035;
                                                            let v1036: i32 = *v1036;
                                                            let v1037: i32 = *v1037;
                                                            US10::US10_Error(v1032.clone(), v1033, v1034, v1035, v1036, v1037)
                                                        }
                                                        US10::US10_Ok(v1011, v1012, v1013, v1014, v1015, v1016) => {
                                                            let v1011: u8 = *v1011;
                                                            let v1012: i32 = *v1012;
                                                            let v1013: i32 = *v1013;
                                                            let v1014: i32 = *v1014;
                                                            let v1015: i32 = *v1015;
                                                            let v1016: i32 = *v1016;
                                                            let v1017: bool = v1012 >= v1016;
                                                            if v1017 {
                                                                let v1018: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                                US10::US10_Error(v1018.clone(), v1012, v1013, v1014, v1015, v1016)
                                                            } else {
                                                                let v1020: u8 = v0.clone().as_bytes()[v1012 as usize];
                                                                let v1021: i32 = v1012.wrapping_add(1i32);
                                                                let mut v1022: bool = b'\n' == v1020;
                                                                let (mut v1026, mut v1027, mut v1028, mut v1029): (i32, i32, i32, i32) = if v1022 {
                                                                    let v1023: i32 = v1013.wrapping_add(v1015);
                                                                    let v1024: i32 = v1014.wrapping_add(1i32);
                                                                    (v1023, v1024, 1i32, v1016)
                                                                } else {
                                                                    let v1025: i32 = v1015.wrapping_add(1i32);
                                                                    (v1013, v1014, v1025, v1016)
                                                                };
                                                                US10::US10_Ok(v1020, v1021, v1026, v1027, v1028, v1029)
                                                            }
                                                        }
                                                    };
                                                    let v1062: US11 = match &v1040 {
                                                        US10::US10_Error(v1054, v1055, v1056, v1057, v1058, v1059) => {
                                                            let v1054: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1054.clone();
                                                            let v1055: i32 = *v1055;
                                                            let v1056: i32 = *v1056;
                                                            let v1057: i32 = *v1057;
                                                            let v1058: i32 = *v1058;
                                                            let v1059: i32 = *v1059;
                                                            US11::US11_Error(v1054.clone(), v1055, v1056, v1057, v1058, v1059)
                                                        }
                                                        US10::US10_Ok(v1041, v1042, v1043, v1044, v1045, v1046) => {
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
                                                            US11::US11_Ok(v1052.clone(), v1042, v1043, v1044, v1045, v1046)
                                                        }
                                                    };
                                                    match &v1062 {
                                                        US11::US11_Error(v1069, v1070, v1071, v1072, v1073, v1074) => {
                                                            let v1069: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1069.clone();
                                                            let v1070: i32 = *v1070;
                                                            let v1071: i32 = *v1071;
                                                            let v1072: i32 = *v1072;
                                                            let v1073: i32 = *v1073;
                                                            let v1074: i32 = *v1074;
                                                            let v1075: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                            US11::US11_Error(v1075.clone(), v877, v878, v879, v880, v881)
                                                        }
                                                        US11::US11_Ok(v1063, v1064, v1065, v1066, v1067, v1068) => {
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
                                                US11::US11_Ok(v981, v982, v983, v984, v985, v986) => {
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
                                        US11::US11_Ok(v898, v899, v900, v901, v902, v903) => {
                                            let v898: Rc<str> = v898.clone();
                                            let v899: i32 = *v899;
                                            let v900: i32 = *v900;
                                            let v901: i32 = *v901;
                                            let v902: i32 = *v902;
                                            let v903: i32 = *v903;
                                            v897.clone()
                                        }
                                    };
                                    let v1105: US11 = match &v1082 {
                                        US11::US11_Error(v1083, v1084, v1085, v1086, v1087, v1088) => {
                                            let v1083: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1083.clone();
                                            let v1084: i32 = *v1084;
                                            let v1085: i32 = *v1085;
                                            let v1086: i32 = *v1086;
                                            let v1087: i32 = *v1087;
                                            let v1088: i32 = *v1088;
                                            let v1089: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            US11::US11_Ok(v1089.clone(), v877, v878, v879, v880, v881)
                                        }
                                        US11::US11_Ok(v1091, v1092, v1093, v1094, v1095, v1096) => {
                                            let v1091: Rc<str> = v1091.clone();
                                            let v1092: i32 = *v1092;
                                            let v1093: i32 = *v1093;
                                            let v1094: i32 = *v1094;
                                            let v1095: i32 = *v1095;
                                            let v1096: i32 = *v1096;
                                            let v1097: bool = v1092 == v877;
                                            if v1097 {
                                                let v1098: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                                US11::US11_Error(v1098.clone(), v877, v878, v879, v880, v881)
                                            } else {
                                                let v1100: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                                let v1101: i32 = 0i32;
                                                method71(v0.clone(), v1100.clone(), v1100.clone(), v1091.clone(), v1101, v1092, v1093, v1094, v1095, v1096)
                                            }
                                        }
                                    };
                                    match &v1105 {
                                        US11::US11_Error(v1148, v1149, v1150, v1151, v1152, v1153) => {
                                            let v1148: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1148.clone();
                                            let v1149: i32 = *v1149;
                                            let v1150: i32 = *v1150;
                                            let v1151: i32 = *v1151;
                                            let v1152: i32 = *v1152;
                                            let v1153: i32 = *v1153;
                                            let v1154: bool = v877 >= v881;
                                            let v1172: US10 = if v1154 {
                                                let v1155: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                US10::US10_Error(v1155.clone(), v877, v878, v879, v880, v881)
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
                                                    US10::US10_Ok(b'"', v1159, v1164, v1165, v1166, v1167)
                                                } else {
                                                    let v1169: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                    US10::US10_Error(v1169.clone(), v877, v878, v879, v880, v881)
                                                }
                                            };
                                            match &v1172 {
                                                US10::US10_Error(v1181, v1182, v1183, v1184, v1185, v1186) => {
                                                    let v1181: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1181.clone();
                                                    let v1182: i32 = *v1182;
                                                    let v1183: i32 = *v1183;
                                                    let v1184: i32 = *v1184;
                                                    let v1185: i32 = *v1185;
                                                    let v1186: i32 = *v1186;
                                                    let v1187: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                                    US11::US11_Error(v1187.clone(), v877, v878, v879, v880, v881)
                                                }
                                                US10::US10_Ok(v1173, v1174, v1175, v1176, v1177, v1178) => {
                                                    let v1173: u8 = *v1173;
                                                    let v1174: i32 = *v1174;
                                                    let v1175: i32 = *v1175;
                                                    let v1176: i32 = *v1176;
                                                    let v1177: i32 = *v1177;
                                                    let v1178: i32 = *v1178;
                                                    let v1179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                    US11::US11_Ok(v1179.clone(), v1174, v1175, v1176, v1177, v1178)
                                                }
                                            }
                                        }
                                        US11::US11_Ok(v1106, v1107, v1108, v1109, v1110, v1111) => {
                                            let v1106: Rc<str> = v1106.clone();
                                            let v1107: i32 = *v1107;
                                            let v1108: i32 = *v1108;
                                            let v1109: i32 = *v1109;
                                            let v1110: i32 = *v1110;
                                            let v1111: i32 = *v1111;
                                            let v1112: bool = v1107 >= v1111;
                                            let v1130: US10 = if v1112 {
                                                let v1113: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                US10::US10_Error(v1113.clone(), v1107, v1108, v1109, v1110, v1111)
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
                                                    US10::US10_Ok(b'"', v1117, v1122, v1123, v1124, v1125)
                                                } else {
                                                    let v1127: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                    US10::US10_Error(v1127.clone(), v1107, v1108, v1109, v1110, v1111)
                                                }
                                            };
                                            match &v1130 {
                                                US10::US10_Error(v1138, v1139, v1140, v1141, v1142, v1143) => {
                                                    let v1138: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1138.clone();
                                                    let v1139: i32 = *v1139;
                                                    let v1140: i32 = *v1140;
                                                    let v1141: i32 = *v1141;
                                                    let v1142: i32 = *v1142;
                                                    let v1143: i32 = *v1143;
                                                    let v1144: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v877, v1107, v1138.clone(), v1139, v1140, v1141, v1142, v1143);
                                                    US11::US11_Error(v1144.clone(), v1107, v1108, v1109, v1110, v1111)
                                                }
                                                US10::US10_Ok(v1131, v1132, v1133, v1134, v1135, v1136) => {
                                                    let v1131: u8 = *v1131;
                                                    let v1132: i32 = *v1132;
                                                    let v1133: i32 = *v1133;
                                                    let v1134: i32 = *v1134;
                                                    let v1135: i32 = *v1135;
                                                    let v1136: i32 = *v1136;
                                                    US11::US11_Ok(v1106.clone(), v1132, v1133, v1134, v1135, v1136)
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        US11::US11_Ok(v846, v847, v848, v849, v850, v851) => {
                            let v846: Rc<str> = v846.clone();
                            let v847: i32 = *v847;
                            let v848: i32 = *v848;
                            let v849: i32 = *v849;
                            let v850: i32 = *v850;
                            let v851: i32 = *v851;
                            v845.clone()
                        }
                    };
                    let v1233: US11 = match &v1203 {
                        US11::US11_Error(v1210, v1211, v1212, v1213, v1214, v1215) => {
                            let v1210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1210.clone();
                            let v1211: i32 = *v1211;
                            let v1212: i32 = *v1212;
                            let v1213: i32 = *v1213;
                            let v1214: i32 = *v1214;
                            let v1215: i32 = *v1215;
                            let (mut v1216, mut v1217, mut v1218, mut v1219, mut v1220): (i32, i32, i32, i32, i32) = method77(v40, v41, v42, v43, v0.clone(), v39, v40, v41, v42, v43);
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
                                US11::US11_Ok(v1227.clone(), v1216, v1217, v1218, v1219, v1220)
                            } else {
                                let v1229: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                US11::US11_Error(v1229.clone(), v39, v40, v41, v42, v43)
                            }
                        }
                        US11::US11_Ok(v1204, v1205, v1206, v1207, v1208, v1209) => {
                            let v1204: Rc<str> = v1204.clone();
                            let v1205: i32 = *v1205;
                            let v1206: i32 = *v1206;
                            let v1207: i32 = *v1207;
                            let v1208: i32 = *v1208;
                            let v1209: i32 = *v1209;
                            v1203.clone()
                        }
                    };
                    let v1268: US11 = match &v1233 {
                        US11::US11_Error(v1240, v1241, v1242, v1243, v1244, v1245) => {
                            let v1240: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1240.clone();
                            let v1241: i32 = *v1241;
                            let v1242: i32 = *v1242;
                            let v1243: i32 = *v1243;
                            let v1244: i32 = *v1244;
                            let v1245: i32 = *v1245;
                            let v1246: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                            let v1247: US19 = method73(v0.clone(), v1246.clone(), v39, v40, v41, v42, v43);
                            match &v1247 {
                                US19::US19_Error(v1258, v1259, v1260, v1261, v1262, v1263) => {
                                    let v1258: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1258.clone();
                                    let v1259: i32 = *v1259;
                                    let v1260: i32 = *v1260;
                                    let v1261: i32 = *v1261;
                                    let v1262: i32 = *v1262;
                                    let v1263: i32 = *v1263;
                                    US11::US11_Error(v1258.clone(), v1259, v1260, v1261, v1262, v1263)
                                }
                                US19::US19_Ok(v1248, v1249, v1250, v1251, v1252, v1253) => {
                                    let v1248: Rc<UH0> = v1248.clone();
                                    let v1249: i32 = *v1249;
                                    let v1250: i32 = *v1250;
                                    let v1251: i32 = *v1251;
                                    let v1252: i32 = *v1252;
                                    let v1253: i32 = *v1253;
                                    let v1254: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    let (mut v1255, mut v1256): (Rc<str>, Rc<str>) = method75(v1248.clone(), v1254.clone(), v1254.clone());
                                    US11::US11_Ok(v1255.clone(), v1249, v1250, v1251, v1252, v1253)
                                }
                            }
                        }
                        US11::US11_Ok(v1234, v1235, v1236, v1237, v1238, v1239) => {
                            let v1234: Rc<str> = v1234.clone();
                            let v1235: i32 = *v1235;
                            let v1236: i32 = *v1236;
                            let v1237: i32 = *v1237;
                            let v1238: i32 = *v1238;
                            let v1239: i32 = *v1239;
                            v1233.clone()
                        }
                    };
                    let v1279: US11 = match &v1268 {
                        US11::US11_Ok(v1269, v1270, v1271, v1272, v1273, v1274) => {
                            let v1269: Rc<str> = v1269.clone();
                            let v1270: i32 = *v1270;
                            let v1271: i32 = *v1271;
                            let v1272: i32 = *v1272;
                            let v1273: i32 = *v1273;
                            let v1274: i32 = *v1274;
                            let v1275: bool = v1270 == v39;
                            if v1275 {
                                let v1276: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure48();
                                US11::US11_Error(v1276.clone(), v39, v40, v41, v42, v43)
                            } else {
                                v1268.clone()
                            }
                        }
                        _ => {
                            v1268.clone()
                        }
                    };
                    let v1296: US11 = match &v1279 {
                        US11::US11_Error(v1280, v1281, v1282, v1283, v1284, v1285) => {
                            let v1280: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1280.clone();
                            let v1281: i32 = *v1281;
                            let v1282: i32 = *v1282;
                            let v1283: i32 = *v1283;
                            let v1284: i32 = *v1284;
                            let v1285: i32 = *v1285;
                            US11::US11_Error(v1280.clone(), v1281, v1282, v1283, v1284, v1285)
                        }
                        US11::US11_Ok(v1287, v1288, v1289, v1290, v1291, v1292) => {
                            let v1287: Rc<str> = v1287.clone();
                            let v1288: i32 = *v1288;
                            let v1289: i32 = *v1289;
                            let v1290: i32 = *v1290;
                            let v1291: i32 = *v1291;
                            let v1292: i32 = *v1292;
                            let v1293: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                            method76(v0.clone(), v1287.clone(), v1293.clone(), v1288, v1289, v1290, v1291, v1292)
                        }
                    };
                    match &v1296 {
                        US11::US11_Error(v1305, v1306, v1307, v1308, v1309, v1310) => {
                            let v1305: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1305.clone();
                            let v1306: i32 = *v1306;
                            let v1307: i32 = *v1307;
                            let mut v1308: i32 = *v1308;
                            let v1309: i32 = *v1309;
                            let v1310: i32 = *v1310;
                            let v1311: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                            let v1312: Rc<UH0> = method74(v1.clone(), v1311.clone());
                            return US19::US19_Ok(v1312.clone(), v2, v3, v4, v5, v6);
                        }
                        US11::US11_Ok(v1297, v1298, v1299, v1300, v1301, v1302) => {
                            let v1297: Rc<str> = v1297.clone();
                            let v1298: i32 = *v1298;
                            let v1299: i32 = *v1299;
                            let v1300: i32 = *v1300;
                            let v1301: i32 = *v1301;
                            let v1302: i32 = *v1302;
                            let v1303: Rc<UH0> = Rc::new(UH0::UH0_Cons(v1297.clone(), v1.clone()));
                            (v0, v1, v2, v3, v4, v5, v6) = (v0.clone(), v1303.clone(), v1298, v1299, v1300, v1301, v1302);
                            continue;
                        }
                    }
                }
            }
        }
    }
}
fn method83(mut v0: Rc<UH0>, mut v1: i32) -> i32 {
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
fn method84(mut v0: Rc<RefCell<Vec<Rc<str>>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
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
fn split_args_68(mut v0: Rc<str>) -> US18 {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: bool = 0i32 >= v1;
    let mut v16: US10 = if v2 {
        let mut v3: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
        US10::US10_Error(v3, 0i32, 0i32, 1i32, 1i32, v1)
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
            US10::US10_Ok(b'\\', 1i32, v8, v9, v10, v11)
        } else {
            let mut v13: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
            US10::US10_Error(v13, 0i32, 0i32, 1i32, 1i32, v1)
        }
    };
    let v50: US10 = match &v16 {
        US10::US10_Error(v42, v43, v44, v45, v46, v47) => {
            let mut v42: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v42.clone();
            let v43: i32 = *v43;
            let v44: i32 = *v44;
            let mut v45: i32 = *v45;
            let mut v46: i32 = *v46;
            let mut v47: i32 = *v47;
            US10::US10_Error(v42, v43, v44, v45, v46, v47)
        }
        US10::US10_Ok(v17, v18, v19, v20, v21, v22) => {
            let mut v17: u8 = *v17;
            let v18: i32 = *v18;
            let v19: i32 = *v19;
            let mut v20: i32 = *v20;
            let v21: i32 = *v21;
            let mut v22: i32 = *v22;
            let v23: bool = v18 >= v22;
            if v23 {
                let v24: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                US10::US10_Error(v24, v18, v19, v20, v21, v22)
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
                    US10::US10_Ok(b'"', v28, v33, v34, v35, v36)
                } else {
                    let mut v38: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                    US10::US10_Error(v38, v18, v19, v20, v21, v22)
                }
            }
        }
    };
    let v66: US10 = match &v50 {
        US10::US10_Error(v58, v59, v60, v61, v62, v63) => {
            let v58: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v58.clone();
            let mut v59: i32 = *v59;
            let v60: i32 = *v60;
            let v61: i32 = *v61;
            let v62: i32 = *v62;
            let mut v63: i32 = *v63;
            US10::US10_Error(v58, v59, v60, v61, v62, v63)
        }
        US10::US10_Ok(v51, v52, v53, v54, v55, v56) => {
            let v51: u8 = *v51;
            let mut v52: i32 = *v52;
            let v53: i32 = *v53;
            let v54: i32 = *v54;
            let v55: i32 = *v55;
            let v56: i32 = *v56;
            US10::US10_Ok(b'"', v52, v53, v54, v55, v56)
        }
    };
    let mut v160: US10 = match &v66 {
        US10::US10_Error(v73, v74, v75, v76, v77, v78) => {
            let mut v73: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v73.clone();
            let mut v74: i32 = *v74;
            let v75: i32 = *v75;
            let mut v76: i32 = *v76;
            let mut v77: i32 = *v77;
            let mut v78: i32 = *v78;
            let v92: US10 = if v2 {
                let mut v79: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                US10::US10_Error(v79, 0i32, 0i32, 1i32, 1i32, v1)
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
                    US10::US10_Ok(b'`', 1i32, v84, v85, v86, v87)
                } else {
                    let v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                    US10::US10_Error(v89, 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            let v126: US10 = match &v92 {
                US10::US10_Error(v118, v119, v120, v121, v122, v123) => {
                    let v118: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v118.clone();
                    let mut v119: i32 = *v119;
                    let v120: i32 = *v120;
                    let mut v121: i32 = *v121;
                    let mut v122: i32 = *v122;
                    let v123: i32 = *v123;
                    US10::US10_Error(v118, v119, v120, v121, v122, v123)
                }
                US10::US10_Ok(v93, v94, v95, v96, v97, v98) => {
                    let mut v93: u8 = *v93;
                    let v94: i32 = *v94;
                    let v95: i32 = *v95;
                    let v96: i32 = *v96;
                    let mut v97: i32 = *v97;
                    let mut v98: i32 = *v98;
                    let mut v99: bool = v94 >= v98;
                    if v99 {
                        let v100: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                        US10::US10_Error(v100, v94, v95, v96, v97, v98)
                    } else {
                        let mut v102: u8 = v0.clone().as_bytes()[v94 as usize];
                        let mut v103: bool = v102 == b'"';
                        if v103 {
                            let v104: i32 = v94.wrapping_add(1i32);
                            let mut v105: bool = b'\n' == v102;
                            let (mut v109, mut v110, mut v111, mut v112): (i32, i32, i32, i32) = if v105 {
                                let mut v106: i32 = v95.wrapping_add(v97);
                                let mut v107: i32 = v96.wrapping_add(1i32);
                                (v106, v107, 1i32, v98)
                            } else {
                                let mut v108: i32 = v97.wrapping_add(1i32);
                                (v95, v96, v108, v98)
                            };
                            US10::US10_Ok(b'"', v104, v109, v110, v111, v112)
                        } else {
                            let v114: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                            US10::US10_Error(v114, v94, v95, v96, v97, v98)
                        }
                    }
                }
            };
            let v142: US10 = match &v126 {
                US10::US10_Error(v134, v135, v136, v137, v138, v139) => {
                    let v134: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v134.clone();
                    let v135: i32 = *v135;
                    let v136: i32 = *v136;
                    let v137: i32 = *v137;
                    let v138: i32 = *v138;
                    let v139: i32 = *v139;
                    US10::US10_Error(v134, v135, v136, v137, v138, v139)
                }
                US10::US10_Ok(v127, v128, v129, v130, v131, v132) => {
                    let mut v127: u8 = *v127;
                    let v128: i32 = *v128;
                    let v129: i32 = *v129;
                    let mut v130: i32 = *v130;
                    let v131: i32 = *v131;
                    let v132: i32 = *v132;
                    US10::US10_Ok(b'"', v128, v129, v130, v131, v132)
                }
            };
            match &v142 {
                US10::US10_Error(v149, v150, v151, v152, v153, v154) => {
                    let v149: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v149.clone();
                    let mut v150: i32 = *v150;
                    let mut v151: i32 = *v151;
                    let mut v152: i32 = *v152;
                    let mut v153: i32 = *v153;
                    let mut v154: i32 = *v154;
                    let mut v155: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                    US10::US10_Error(v155, 0i32, 0i32, 1i32, 1i32, v1)
                }
                US10::US10_Ok(v143, v144, v145, v146, v147, v148) => {
                    let mut v143: u8 = *v143;
                    let mut v144: i32 = *v144;
                    let v145: i32 = *v145;
                    let v146: i32 = *v146;
                    let mut v147: i32 = *v147;
                    let mut v148: i32 = *v148;
                    v142
                }
            }
        }
        US10::US10_Ok(v67, v68, v69, v70, v71, v72) => {
            let v67: u8 = *v67;
            let mut v68: i32 = *v68;
            let mut v69: i32 = *v69;
            let mut v70: i32 = *v70;
            let mut v71: i32 = *v71;
            let v72: i32 = *v72;
            v66
        }
    };
    let v792: US11 = match &v160 {
        US10::US10_Error(v784, v785, v786, v787, v788, v789) => {
            let v784: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v784.clone();
            let v785: i32 = *v785;
            let v786: i32 = *v786;
            let v787: i32 = *v787;
            let v788: i32 = *v788;
            let v789: i32 = *v789;
            US11::US11_Error(v784, v785, v786, v787, v788, v789)
        }
        US10::US10_Ok(v161, v162, v163, v164, v165, v166) => {
            let v161: u8 = *v161;
            let v162: i32 = *v162;
            let mut v163: i32 = *v163;
            let v164: i32 = *v164;
            let v165: i32 = *v165;
            let v166: i32 = *v166;
            let (mut v167, mut v168, mut v169, mut v170, mut v171): (i32, i32, i32, i32, i32) = method69(v163, v164, v165, v166, v0.clone(), v162, v163, v164, v165, v166);
            let mut v172: bool = v167 > v162;
            let v182: US11 = if v172 {
                let mut v173: bool = v162 >= v167;
                let mut v178: Rc<str> = if v173 {
                    let v174: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v174
                } else {
                    let mut v176: i32 = v167.wrapping_sub(1i32);
                    let v177: Rc<str> = string_slice(&v0.clone(), v162 as i64, v176 as i64);
                    v177
                };
                US11::US11_Ok(v178, v167, v168, v169, v170, v171)
            } else {
                let v180: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                US11::US11_Error(v180, v162, v163, v164, v165, v166)
            };
            let v377: US11 = match &v182 {
                US11::US11_Error(v189, v190, v191, v192, v193, v194) => {
                    let v189: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v189.clone();
                    let v190: i32 = *v190;
                    let mut v191: i32 = *v191;
                    let v192: i32 = *v192;
                    let v193: i32 = *v193;
                    let v194: i32 = *v194;
                    let v195: bool = v162 >= v166;
                    let mut v213: US10 = if v195 {
                        let v196: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                        US10::US10_Error(v196, v162, v163, v164, v165, v166)
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
                            US10::US10_Ok(b'\\', v200, v205, v206, v207, v208)
                        } else {
                            let v210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                            US10::US10_Error(v210, v162, v163, v164, v165, v166)
                        }
                    };
                    let v248: US10 = match &v213 {
                        US10::US10_Error(v240, v241, v242, v243, v244, v245) => {
                            let v240: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v240.clone();
                            let v241: i32 = *v241;
                            let v242: i32 = *v242;
                            let v243: i32 = *v243;
                            let mut v244: i32 = *v244;
                            let v245: i32 = *v245;
                            US10::US10_Error(v240, v241, v242, v243, v244, v245)
                        }
                        US10::US10_Ok(v214, v215, v216, v217, v218, v219) => {
                            let v214: u8 = *v214;
                            let v215: i32 = *v215;
                            let mut v216: i32 = *v216;
                            let v217: i32 = *v217;
                            let mut v218: i32 = *v218;
                            let v219: i32 = *v219;
                            let v220: bool = v215 >= v219;
                            if v220 {
                                let mut v221: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                US10::US10_Error(v221, v215, v216, v217, v218, v219)
                            } else {
                                let v223: u8 = v0.clone().as_bytes()[v215 as usize];
                                let v224: bool = v223 == b'"';
                                let mut v225: bool = v224 == false;
                                if v225 {
                                    let mut v226: i32 = v215.wrapping_add(1i32);
                                    let v227: bool = b'\n' == v223;
                                    let (mut v231, mut v232, mut v233, mut v234): (i32, i32, i32, i32) = if v227 {
                                        let mut v228: i32 = v216.wrapping_add(v218);
                                        let v229: i32 = v217.wrapping_add(1i32);
                                        (v228, v229, 1i32, v219)
                                    } else {
                                        let v230: i32 = v218.wrapping_add(1i32);
                                        (v216, v217, v230, v219)
                                    };
                                    US10::US10_Ok(v223, v226, v231, v232, v233, v234)
                                } else {
                                    let v236: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                    US10::US10_Error(v236, v215, v216, v217, v218, v219)
                                }
                            }
                        }
                    };
                    let v270: US11 = match &v248 {
                        US10::US10_Error(v262, v263, v264, v265, v266, v267) => {
                            let v262: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v262.clone();
                            let v263: i32 = *v263;
                            let v264: i32 = *v264;
                            let v265: i32 = *v265;
                            let v266: i32 = *v266;
                            let v267: i32 = *v267;
                            US11::US11_Error(v262, v263, v264, v265, v266, v267)
                        }
                        US10::US10_Ok(v249, v250, v251, v252, v253, v254) => {
                            let mut v249: u8 = *v249;
                            let v250: i32 = *v250;
                            let v251: i32 = *v251;
                            let v252: i32 = *v252;
                            let v253: i32 = *v253;
                            let v254: i32 = *v254;
                            let mut v255: bool = v162 >= v250;
                            let mut v260: Rc<str> = if v255 {
                                let v256: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                v256
                            } else {
                                let v258: i32 = v250.wrapping_sub(1i32);
                                let mut v259: Rc<str> = string_slice(&v0.clone(), v162 as i64, v258 as i64);
                                v259
                            };
                            US11::US11_Ok(v260, v250, v251, v252, v253, v254)
                        }
                    };
                    match &v270 {
                        US11::US11_Error(v277, v278, v279, v280, v281, v282) => {
                            let v277: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v277.clone();
                            let v278: i32 = *v278;
                            let v279: i32 = *v279;
                            let mut v280: i32 = *v280;
                            let mut v281: i32 = *v281;
                            let v282: i32 = *v282;
                            let v300: US10 = if v195 {
                                let mut v283: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                US10::US10_Error(v283, v162, v163, v164, v165, v166)
                            } else {
                                let v285: u8 = v0.clone().as_bytes()[v162 as usize];
                                let v286: bool = v285 == b'`';
                                if v286 {
                                    let v287: i32 = v162.wrapping_add(1i32);
                                    let v288: bool = b'\n' == v285;
                                    let (mut v292, mut v293, mut v294, mut v295): (i32, i32, i32, i32) = if v288 {
                                        let v289: i32 = v163.wrapping_add(v165);
                                        let v290: i32 = v164.wrapping_add(1i32);
                                        (v289, v290, 1i32, v166)
                                    } else {
                                        let v291: i32 = v165.wrapping_add(1i32);
                                        (v163, v164, v291, v166)
                                    };
                                    US10::US10_Ok(b'`', v287, v292, v293, v294, v295)
                                } else {
                                    let v297: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US10::US10_Error(v297, v162, v163, v164, v165, v166)
                                }
                            };
                            let v335: US10 = match &v300 {
                                US10::US10_Error(v327, v328, v329, v330, v331, v332) => {
                                    let mut v327: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v327.clone();
                                    let v328: i32 = *v328;
                                    let v329: i32 = *v329;
                                    let mut v330: i32 = *v330;
                                    let v331: i32 = *v331;
                                    let v332: i32 = *v332;
                                    US10::US10_Error(v327, v328, v329, v330, v331, v332)
                                }
                                US10::US10_Ok(v301, v302, v303, v304, v305, v306) => {
                                    let v301: u8 = *v301;
                                    let v302: i32 = *v302;
                                    let v303: i32 = *v303;
                                    let v304: i32 = *v304;
                                    let v305: i32 = *v305;
                                    let v306: i32 = *v306;
                                    let v307: bool = v302 >= v306;
                                    if v307 {
                                        let v308: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                        US10::US10_Error(v308, v302, v303, v304, v305, v306)
                                    } else {
                                        let mut v310: u8 = v0.clone().as_bytes()[v302 as usize];
                                        let v311: bool = v310 == b'"';
                                        let mut v312: bool = v311 == false;
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
                                            US10::US10_Ok(v310, v313, v318, v319, v320, v321)
                                        } else {
                                            let v323: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                            US10::US10_Error(v323, v302, v303, v304, v305, v306)
                                        }
                                    }
                                }
                            };
                            let mut v357: US11 = match &v335 {
                                US10::US10_Error(v349, v350, v351, v352, v353, v354) => {
                                    let v349: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v349.clone();
                                    let v350: i32 = *v350;
                                    let v351: i32 = *v351;
                                    let v352: i32 = *v352;
                                    let v353: i32 = *v353;
                                    let v354: i32 = *v354;
                                    US11::US11_Error(v349, v350, v351, v352, v353, v354)
                                }
                                US10::US10_Ok(v336, v337, v338, v339, v340, v341) => {
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
                                    US11::US11_Ok(v347, v337, v338, v339, v340, v341)
                                }
                            };
                            match &v357 {
                                US11::US11_Error(v364, v365, v366, v367, v368, v369) => {
                                    let v364: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v364.clone();
                                    let v365: i32 = *v365;
                                    let v366: i32 = *v366;
                                    let v367: i32 = *v367;
                                    let v368: i32 = *v368;
                                    let v369: i32 = *v369;
                                    let v370: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US11::US11_Error(v370, v162, v163, v164, v165, v166)
                                }
                                US11::US11_Ok(v358, v359, v360, v361, v362, v363) => {
                                    let v358: Rc<str> = v358.clone();
                                    let v359: i32 = *v359;
                                    let v360: i32 = *v360;
                                    let v361: i32 = *v361;
                                    let v362: i32 = *v362;
                                    let v363: i32 = *v363;
                                    v357
                                }
                            }
                        }
                        US11::US11_Ok(v271, v272, v273, v274, v275, v276) => {
                            let v271: Rc<str> = v271.clone();
                            let mut v272: i32 = *v272;
                            let v273: i32 = *v273;
                            let v274: i32 = *v274;
                            let v275: i32 = *v275;
                            let v276: i32 = *v276;
                            v270
                        }
                    }
                }
                US11::US11_Ok(v183, v184, v185, v186, v187, v188) => {
                    let v183: Rc<str> = v183.clone();
                    let v184: i32 = *v184;
                    let v185: i32 = *v185;
                    let v186: i32 = *v186;
                    let mut v187: i32 = *v187;
                    let v188: i32 = *v188;
                    v182
                }
            };
            let v400: US11 = match &v377 {
                US11::US11_Error(v378, v379, v380, v381, v382, v383) => {
                    let mut v378: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v378.clone();
                    let v379: i32 = *v379;
                    let v380: i32 = *v380;
                    let mut v381: i32 = *v381;
                    let v382: i32 = *v382;
                    let v383: i32 = *v383;
                    let v384: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US11::US11_Ok(v384, v162, v163, v164, v165, v166)
                }
                US11::US11_Ok(v386, v387, v388, v389, v390, v391) => {
                    let v386: Rc<str> = v386.clone();
                    let v387: i32 = *v387;
                    let v388: i32 = *v388;
                    let v389: i32 = *v389;
                    let v390: i32 = *v390;
                    let v391: i32 = *v391;
                    let v392: bool = v387 == v162;
                    if v392 {
                        let v393: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                        US11::US11_Error(v393, v162, v163, v164, v165, v166)
                    } else {
                        let v395: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                        let v396: i32 = 0i32;
                        method70(v0.clone(), v395.clone(), v395, v386, v396, v387, v388, v389, v390, v391)
                    }
                }
            };
            match &v400 {
                US11::US11_Error(v591, v592, v593, v594, v595, v596) => {
                    let mut v591: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v591.clone();
                    let v592: i32 = *v592;
                    let v593: i32 = *v593;
                    let mut v594: i32 = *v594;
                    let v595: i32 = *v595;
                    let v596: i32 = *v596;
                    let v597: bool = v162 >= v166;
                    let v615: US10 = if v597 {
                        let v598: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                        US10::US10_Error(v598, v162, v163, v164, v165, v166)
                    } else {
                        let v600: u8 = v0.clone().as_bytes()[v162 as usize];
                        let v601: bool = v600 == b'\\';
                        if v601 {
                            let v602: i32 = v162.wrapping_add(1i32);
                            let v603: bool = b'\n' == v600;
                            let (mut v607, mut v608, mut v609, mut v610): (i32, i32, i32, i32) = if v603 {
                                let v604: i32 = v163.wrapping_add(v165);
                                let v605: i32 = v164.wrapping_add(1i32);
                                (v604, v605, 1i32, v166)
                            } else {
                                let v606: i32 = v165.wrapping_add(1i32);
                                (v163, v164, v606, v166)
                            };
                            US10::US10_Ok(b'\\', v602, v607, v608, v609, v610)
                        } else {
                            let v612: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                            US10::US10_Error(v612, v162, v163, v164, v165, v166)
                        }
                    };
                    let v649: US10 = match &v615 {
                        US10::US10_Error(v641, v642, v643, v644, v645, v646) => {
                            let v641: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v641.clone();
                            let v642: i32 = *v642;
                            let mut v643: i32 = *v643;
                            let v644: i32 = *v644;
                            let v645: i32 = *v645;
                            let v646: i32 = *v646;
                            US10::US10_Error(v641, v642, v643, v644, v645, v646)
                        }
                        US10::US10_Ok(v616, v617, v618, v619, v620, v621) => {
                            let v616: u8 = *v616;
                            let v617: i32 = *v617;
                            let v618: i32 = *v618;
                            let v619: i32 = *v619;
                            let v620: i32 = *v620;
                            let v621: i32 = *v621;
                            let v622: bool = v617 >= v621;
                            if v622 {
                                let v623: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_Error(v623, v617, v618, v619, v620, v621)
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
                                    US10::US10_Ok(b'"', v627, v632, v633, v634, v635)
                                } else {
                                    let v637: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_Error(v637, v617, v618, v619, v620, v621)
                                }
                            }
                        }
                    };
                    let v665: US10 = match &v649 {
                        US10::US10_Error(v657, v658, v659, v660, v661, v662) => {
                            let v657: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v657.clone();
                            let v658: i32 = *v658;
                            let v659: i32 = *v659;
                            let v660: i32 = *v660;
                            let v661: i32 = *v661;
                            let v662: i32 = *v662;
                            US10::US10_Error(v657, v658, v659, v660, v661, v662)
                        }
                        US10::US10_Ok(v650, v651, v652, v653, v654, v655) => {
                            let v650: u8 = *v650;
                            let v651: i32 = *v651;
                            let v652: i32 = *v652;
                            let v653: i32 = *v653;
                            let v654: i32 = *v654;
                            let v655: i32 = *v655;
                            US10::US10_Ok(b'"', v651, v652, v653, v654, v655)
                        }
                    };
                    let v763: US10 = match &v665 {
                        US10::US10_Error(v672, v673, v674, v675, v676, v677) => {
                            let v672: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v672.clone();
                            let v673: i32 = *v673;
                            let v674: i32 = *v674;
                            let v675: i32 = *v675;
                            let v676: i32 = *v676;
                            let v677: i32 = *v677;
                            let v695: US10 = if v597 {
                                let v678: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                US10::US10_Error(v678, v162, v163, v164, v165, v166)
                            } else {
                                let v680: u8 = v0.clone().as_bytes()[v162 as usize];
                                let v681: bool = v680 == b'`';
                                if v681 {
                                    let v682: i32 = v162.wrapping_add(1i32);
                                    let v683: bool = b'\n' == v680;
                                    let (mut v687, mut v688, mut v689, mut v690): (i32, i32, i32, i32) = if v683 {
                                        let v684: i32 = v163.wrapping_add(v165);
                                        let v685: i32 = v164.wrapping_add(1i32);
                                        (v684, v685, 1i32, v166)
                                    } else {
                                        let v686: i32 = v165.wrapping_add(1i32);
                                        (v163, v164, v686, v166)
                                    };
                                    US10::US10_Ok(b'`', v682, v687, v688, v689, v690)
                                } else {
                                    let v692: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US10::US10_Error(v692, v162, v163, v164, v165, v166)
                                }
                            };
                            let v729: US10 = match &v695 {
                                US10::US10_Error(v721, v722, v723, v724, v725, v726) => {
                                    let v721: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v721.clone();
                                    let mut v722: i32 = *v722;
                                    let v723: i32 = *v723;
                                    let v724: i32 = *v724;
                                    let v725: i32 = *v725;
                                    let v726: i32 = *v726;
                                    US10::US10_Error(v721, v722, v723, v724, v725, v726)
                                }
                                US10::US10_Ok(v696, v697, v698, v699, v700, v701) => {
                                    let v696: u8 = *v696;
                                    let v697: i32 = *v697;
                                    let v698: i32 = *v698;
                                    let v699: i32 = *v699;
                                    let v700: i32 = *v700;
                                    let v701: i32 = *v701;
                                    let v702: bool = v697 >= v701;
                                    if v702 {
                                        let v703: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                        US10::US10_Error(v703, v697, v698, v699, v700, v701)
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
                                            US10::US10_Ok(b'"', v707, v712, v713, v714, v715)
                                        } else {
                                            let v717: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                            US10::US10_Error(v717, v697, v698, v699, v700, v701)
                                        }
                                    }
                                }
                            };
                            let v745: US10 = match &v729 {
                                US10::US10_Error(v737, v738, v739, v740, v741, v742) => {
                                    let v737: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v737.clone();
                                    let v738: i32 = *v738;
                                    let v739: i32 = *v739;
                                    let v740: i32 = *v740;
                                    let v741: i32 = *v741;
                                    let v742: i32 = *v742;
                                    US10::US10_Error(v737, v738, v739, v740, v741, v742)
                                }
                                US10::US10_Ok(v730, v731, v732, v733, v734, v735) => {
                                    let v730: u8 = *v730;
                                    let v731: i32 = *v731;
                                    let v732: i32 = *v732;
                                    let v733: i32 = *v733;
                                    let v734: i32 = *v734;
                                    let v735: i32 = *v735;
                                    US10::US10_Ok(b'"', v731, v732, v733, v734, v735)
                                }
                            };
                            match &v745 {
                                US10::US10_Error(v752, v753, v754, v755, v756, v757) => {
                                    let v752: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v752.clone();
                                    let v753: i32 = *v753;
                                    let v754: i32 = *v754;
                                    let v755: i32 = *v755;
                                    let v756: i32 = *v756;
                                    let v757: i32 = *v757;
                                    let v758: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_Error(v758, v162, v163, v164, v165, v166)
                                }
                                US10::US10_Ok(v746, v747, v748, v749, v750, v751) => {
                                    let v746: u8 = *v746;
                                    let v747: i32 = *v747;
                                    let v748: i32 = *v748;
                                    let v749: i32 = *v749;
                                    let mut v750: i32 = *v750;
                                    let v751: i32 = *v751;
                                    v745
                                }
                            }
                        }
                        US10::US10_Ok(v666, v667, v668, v669, v670, v671) => {
                            let v666: u8 = *v666;
                            let v667: i32 = *v667;
                            let v668: i32 = *v668;
                            let v669: i32 = *v669;
                            let v670: i32 = *v670;
                            let mut v671: i32 = *v671;
                            v665
                        }
                    };
                    match &v763 {
                        US10::US10_Error(v772, v773, v774, v775, v776, v777) => {
                            let v772: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v772.clone();
                            let v773: i32 = *v773;
                            let v774: i32 = *v774;
                            let v775: i32 = *v775;
                            let v776: i32 = *v776;
                            let v777: i32 = *v777;
                            let v778: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                            US11::US11_Error(v778, v162, v163, v164, v165, v166)
                        }
                        US10::US10_Ok(v764, v765, v766, v767, v768, v769) => {
                            let v764: u8 = *v764;
                            let v765: i32 = *v765;
                            let v766: i32 = *v766;
                            let v767: i32 = *v767;
                            let v768: i32 = *v768;
                            let v769: i32 = *v769;
                            let v770: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US11::US11_Ok(v770, v765, v766, v767, v768, v769)
                        }
                    }
                }
                US11::US11_Ok(v401, v402, v403, v404, v405, v406) => {
                    let v401: Rc<str> = v401.clone();
                    let v402: i32 = *v402;
                    let v403: i32 = *v403;
                    let v404: i32 = *v404;
                    let v405: i32 = *v405;
                    let v406: i32 = *v406;
                    let v407: bool = v402 >= v406;
                    let v425: US10 = if v407 {
                        let mut v408: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                        US10::US10_Error(v408, v402, v403, v404, v405, v406)
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
                            US10::US10_Ok(b'\\', v412, v417, v418, v419, v420)
                        } else {
                            let v422: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                            US10::US10_Error(v422, v402, v403, v404, v405, v406)
                        }
                    };
                    let v459: US10 = match &v425 {
                        US10::US10_Error(v451, v452, v453, v454, v455, v456) => {
                            let v451: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v451.clone();
                            let v452: i32 = *v452;
                            let v453: i32 = *v453;
                            let v454: i32 = *v454;
                            let v455: i32 = *v455;
                            let v456: i32 = *v456;
                            US10::US10_Error(v451, v452, v453, v454, v455, v456)
                        }
                        US10::US10_Ok(v426, v427, v428, v429, v430, v431) => {
                            let v426: u8 = *v426;
                            let v427: i32 = *v427;
                            let v428: i32 = *v428;
                            let v429: i32 = *v429;
                            let v430: i32 = *v430;
                            let v431: i32 = *v431;
                            let v432: bool = v427 >= v431;
                            if v432 {
                                let v433: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_Error(v433, v427, v428, v429, v430, v431)
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
                                    US10::US10_Ok(b'"', v437, v442, v443, v444, v445)
                                } else {
                                    let v447: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_Error(v447, v427, v428, v429, v430, v431)
                                }
                            }
                        }
                    };
                    let v475: US10 = match &v459 {
                        US10::US10_Error(v467, v468, v469, v470, v471, v472) => {
                            let v467: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v467.clone();
                            let v468: i32 = *v468;
                            let v469: i32 = *v469;
                            let v470: i32 = *v470;
                            let v471: i32 = *v471;
                            let v472: i32 = *v472;
                            US10::US10_Error(v467, v468, v469, v470, v471, v472)
                        }
                        US10::US10_Ok(v460, v461, v462, v463, v464, v465) => {
                            let v460: u8 = *v460;
                            let v461: i32 = *v461;
                            let v462: i32 = *v462;
                            let v463: i32 = *v463;
                            let v464: i32 = *v464;
                            let v465: i32 = *v465;
                            US10::US10_Ok(b'"', v461, v462, v463, v464, v465)
                        }
                    };
                    let v573: US10 = match &v475 {
                        US10::US10_Error(v482, v483, v484, v485, v486, v487) => {
                            let v482: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v482.clone();
                            let v483: i32 = *v483;
                            let v484: i32 = *v484;
                            let v485: i32 = *v485;
                            let v486: i32 = *v486;
                            let v487: i32 = *v487;
                            let v505: US10 = if v407 {
                                let v488: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                US10::US10_Error(v488, v402, v403, v404, v405, v406)
                            } else {
                                let v490: u8 = v0.clone().as_bytes()[v402 as usize];
                                let v491: bool = v490 == b'`';
                                if v491 {
                                    let v492: i32 = v402.wrapping_add(1i32);
                                    let v493: bool = b'\n' == v490;
                                    let (mut v497, mut v498, mut v499, mut v500): (i32, i32, i32, i32) = if v493 {
                                        let v494: i32 = v403.wrapping_add(v405);
                                        let v495: i32 = v404.wrapping_add(1i32);
                                        (v494, v495, 1i32, v406)
                                    } else {
                                        let v496: i32 = v405.wrapping_add(1i32);
                                        (v403, v404, v496, v406)
                                    };
                                    US10::US10_Ok(b'`', v492, v497, v498, v499, v500)
                                } else {
                                    let v502: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US10::US10_Error(v502, v402, v403, v404, v405, v406)
                                }
                            };
                            let v539: US10 = match &v505 {
                                US10::US10_Error(v531, v532, v533, v534, v535, v536) => {
                                    let v531: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v531.clone();
                                    let v532: i32 = *v532;
                                    let v533: i32 = *v533;
                                    let v534: i32 = *v534;
                                    let v535: i32 = *v535;
                                    let v536: i32 = *v536;
                                    US10::US10_Error(v531, v532, v533, v534, v535, v536)
                                }
                                US10::US10_Ok(v506, v507, v508, v509, v510, v511) => {
                                    let v506: u8 = *v506;
                                    let v507: i32 = *v507;
                                    let v508: i32 = *v508;
                                    let mut v509: i32 = *v509;
                                    let v510: i32 = *v510;
                                    let v511: i32 = *v511;
                                    let v512: bool = v507 >= v511;
                                    if v512 {
                                        let v513: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                        US10::US10_Error(v513, v507, v508, v509, v510, v511)
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
                                            US10::US10_Ok(b'"', v517, v522, v523, v524, v525)
                                        } else {
                                            let v527: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                            US10::US10_Error(v527, v507, v508, v509, v510, v511)
                                        }
                                    }
                                }
                            };
                            let v555: US10 = match &v539 {
                                US10::US10_Error(v547, v548, v549, v550, v551, v552) => {
                                    let v547: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v547.clone();
                                    let v548: i32 = *v548;
                                    let v549: i32 = *v549;
                                    let v550: i32 = *v550;
                                    let v551: i32 = *v551;
                                    let v552: i32 = *v552;
                                    US10::US10_Error(v547, v548, v549, v550, v551, v552)
                                }
                                US10::US10_Ok(v540, v541, v542, v543, v544, v545) => {
                                    let v540: u8 = *v540;
                                    let v541: i32 = *v541;
                                    let v542: i32 = *v542;
                                    let v543: i32 = *v543;
                                    let v544: i32 = *v544;
                                    let v545: i32 = *v545;
                                    US10::US10_Ok(b'"', v541, v542, v543, v544, v545)
                                }
                            };
                            match &v555 {
                                US10::US10_Error(v562, v563, v564, v565, v566, v567) => {
                                    let v562: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v562.clone();
                                    let mut v563: i32 = *v563;
                                    let v564: i32 = *v564;
                                    let v565: i32 = *v565;
                                    let v566: i32 = *v566;
                                    let v567: i32 = *v567;
                                    let v568: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_Error(v568, v402, v403, v404, v405, v406)
                                }
                                US10::US10_Ok(v556, v557, v558, v559, v560, v561) => {
                                    let v556: u8 = *v556;
                                    let v557: i32 = *v557;
                                    let v558: i32 = *v558;
                                    let v559: i32 = *v559;
                                    let mut v560: i32 = *v560;
                                    let v561: i32 = *v561;
                                    v555
                                }
                            }
                        }
                        US10::US10_Ok(v476, v477, v478, v479, v480, v481) => {
                            let v476: u8 = *v476;
                            let v477: i32 = *v477;
                            let mut v478: i32 = *v478;
                            let v479: i32 = *v479;
                            let v480: i32 = *v480;
                            let mut v481: i32 = *v481;
                            v475
                        }
                    };
                    match &v573 {
                        US10::US10_Error(v581, v582, v583, v584, v585, v586) => {
                            let v581: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v581.clone();
                            let v582: i32 = *v582;
                            let v583: i32 = *v583;
                            let v584: i32 = *v584;
                            let v585: i32 = *v585;
                            let v586: i32 = *v586;
                            let v587: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v162, v402, v581, v582, v583, v584, v585, v586);
                            US11::US11_Error(v587, v402, v403, v404, v405, v406)
                        }
                        US10::US10_Ok(v574, v575, v576, v577, v578, v579) => {
                            let v574: u8 = *v574;
                            let v575: i32 = *v575;
                            let v576: i32 = *v576;
                            let v577: i32 = *v577;
                            let v578: i32 = *v578;
                            let v579: i32 = *v579;
                            US11::US11_Ok(v401, v575, v576, v577, v578, v579)
                        }
                    }
                }
            }
        }
    };
    let v1146: US11 = match &v792 {
        US11::US11_Error(v799, v800, v801, v802, v803, v804) => {
            let v799: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v799.clone();
            let v800: i32 = *v800;
            let mut v801: i32 = *v801;
            let v802: i32 = *v802;
            let v803: i32 = *v803;
            let v804: i32 = *v804;
            let v818: US10 = if v2 {
                let v805: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                US10::US10_Error(v805, 0i32, 0i32, 1i32, 1i32, v1)
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
                    US10::US10_Ok(b'"', 1i32, v810, v811, v812, v813)
                } else {
                    let v815: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                    US10::US10_Error(v815, 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            match &v818 {
                US10::US10_Error(v1136, v1137, v1138, v1139, v1140, v1141) => {
                    let v1136: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1136.clone();
                    let v1137: i32 = *v1137;
                    let v1138: i32 = *v1138;
                    let v1139: i32 = *v1139;
                    let v1140: i32 = *v1140;
                    let v1141: i32 = *v1141;
                    US11::US11_Error(v1136, v1137, v1138, v1139, v1140, v1141)
                }
                US10::US10_Ok(v819, v820, v821, v822, v823, v824) => {
                    let v819: u8 = *v819;
                    let v820: i32 = *v820;
                    let v821: i32 = *v821;
                    let v822: i32 = *v822;
                    let v823: i32 = *v823;
                    let v824: i32 = *v824;
                    let (mut v825, mut v826, mut v827, mut v828, mut v829): (i32, i32, i32, i32, i32) = method69(v821, v822, v823, v824, v0.clone(), v820, v821, v822, v823, v824);
                    let v830: bool = v825 > v820;
                    let v840: US11 = if v830 {
                        let v831: bool = v820 >= v825;
                        let v836: Rc<str> = if v831 {
                            let v832: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v832
                        } else {
                            let v834: i32 = v825.wrapping_sub(1i32);
                            let v835: Rc<str> = string_slice(&v0.clone(), v820 as i64, v834 as i64);
                            v835
                        };
                        US11::US11_Ok(v836, v825, v826, v827, v828, v829)
                    } else {
                        let v838: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                        US11::US11_Error(v838, v820, v821, v822, v823, v824)
                    };
                    let v1025: US11 = match &v840 {
                        US11::US11_Error(v847, v848, v849, v850, v851, v852) => {
                            let v847: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v847.clone();
                            let v848: i32 = *v848;
                            let v849: i32 = *v849;
                            let v850: i32 = *v850;
                            let v851: i32 = *v851;
                            let v852: i32 = *v852;
                            let v853: bool = v820 >= v824;
                            let v871: US10 = if v853 {
                                let v854: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                US10::US10_Error(v854, v820, v821, v822, v823, v824)
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
                                    US10::US10_Ok(b'\\', v858, v863, v864, v865, v866)
                                } else {
                                    let v868: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                    US10::US10_Error(v868, v820, v821, v822, v823, v824)
                                }
                            };
                            let v901: US10 = match &v871 {
                                US10::US10_Error(v893, v894, v895, v896, v897, v898) => {
                                    let v893: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v893.clone();
                                    let v894: i32 = *v894;
                                    let v895: i32 = *v895;
                                    let v896: i32 = *v896;
                                    let v897: i32 = *v897;
                                    let v898: i32 = *v898;
                                    US10::US10_Error(v893, v894, v895, v896, v897, v898)
                                }
                                US10::US10_Ok(v872, v873, v874, v875, v876, v877) => {
                                    let v872: u8 = *v872;
                                    let v873: i32 = *v873;
                                    let v874: i32 = *v874;
                                    let v875: i32 = *v875;
                                    let v876: i32 = *v876;
                                    let mut v877: i32 = *v877;
                                    let v878: bool = v873 >= v877;
                                    if v878 {
                                        let v879: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                        US10::US10_Error(v879, v873, v874, v875, v876, v877)
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
                                        US10::US10_Ok(v881, v882, v887, v888, v889, v890)
                                    }
                                }
                            };
                            let v923: US11 = match &v901 {
                                US10::US10_Error(v915, v916, v917, v918, v919, v920) => {
                                    let v915: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v915.clone();
                                    let v916: i32 = *v916;
                                    let v917: i32 = *v917;
                                    let v918: i32 = *v918;
                                    let v919: i32 = *v919;
                                    let v920: i32 = *v920;
                                    US11::US11_Error(v915, v916, v917, v918, v919, v920)
                                }
                                US10::US10_Ok(v902, v903, v904, v905, v906, v907) => {
                                    let v902: u8 = *v902;
                                    let v903: i32 = *v903;
                                    let v904: i32 = *v904;
                                    let v905: i32 = *v905;
                                    let v906: i32 = *v906;
                                    let v907: i32 = *v907;
                                    let mut v908: bool = v820 >= v903;
                                    let v913: Rc<str> = if v908 {
                                        let v909: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        v909
                                    } else {
                                        let v911: i32 = v903.wrapping_sub(1i32);
                                        let v912: Rc<str> = string_slice(&v0.clone(), v820 as i64, v911 as i64);
                                        v912
                                    };
                                    US11::US11_Ok(v913, v903, v904, v905, v906, v907)
                                }
                            };
                            match &v923 {
                                US11::US11_Error(v930, v931, v932, v933, v934, v935) => {
                                    let v930: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v930.clone();
                                    let v931: i32 = *v931;
                                    let v932: i32 = *v932;
                                    let v933: i32 = *v933;
                                    let v934: i32 = *v934;
                                    let v935: i32 = *v935;
                                    let v953: US10 = if v853 {
                                        let v936: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                        US10::US10_Error(v936, v820, v821, v822, v823, v824)
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
                                            US10::US10_Ok(b'`', v940, v945, v946, v947, v948)
                                        } else {
                                            let v950: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                            US10::US10_Error(v950, v820, v821, v822, v823, v824)
                                        }
                                    };
                                    let v983: US10 = match &v953 {
                                        US10::US10_Error(v975, v976, v977, v978, v979, v980) => {
                                            let v975: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v975.clone();
                                            let v976: i32 = *v976;
                                            let v977: i32 = *v977;
                                            let v978: i32 = *v978;
                                            let v979: i32 = *v979;
                                            let v980: i32 = *v980;
                                            US10::US10_Error(v975, v976, v977, v978, v979, v980)
                                        }
                                        US10::US10_Ok(v954, v955, v956, v957, v958, v959) => {
                                            let v954: u8 = *v954;
                                            let v955: i32 = *v955;
                                            let mut v956: i32 = *v956;
                                            let v957: i32 = *v957;
                                            let v958: i32 = *v958;
                                            let mut v959: i32 = *v959;
                                            let v960: bool = v955 >= v959;
                                            if v960 {
                                                let v961: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                US10::US10_Error(v961, v955, v956, v957, v958, v959)
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
                                                US10::US10_Ok(v963, v964, v969, v970, v971, v972)
                                            }
                                        }
                                    };
                                    let v1005: US11 = match &v983 {
                                        US10::US10_Error(v997, v998, v999, v1000, v1001, v1002) => {
                                            let v997: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v997.clone();
                                            let v998: i32 = *v998;
                                            let v999: i32 = *v999;
                                            let v1000: i32 = *v1000;
                                            let v1001: i32 = *v1001;
                                            let v1002: i32 = *v1002;
                                            US11::US11_Error(v997, v998, v999, v1000, v1001, v1002)
                                        }
                                        US10::US10_Ok(v984, v985, v986, v987, v988, v989) => {
                                            let v984: u8 = *v984;
                                            let v985: i32 = *v985;
                                            let v986: i32 = *v986;
                                            let mut v987: i32 = *v987;
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
                                            US11::US11_Ok(v995, v985, v986, v987, v988, v989)
                                        }
                                    };
                                    match &v1005 {
                                        US11::US11_Error(v1012, v1013, v1014, v1015, v1016, v1017) => {
                                            let v1012: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1012.clone();
                                            let v1013: i32 = *v1013;
                                            let v1014: i32 = *v1014;
                                            let v1015: i32 = *v1015;
                                            let v1016: i32 = *v1016;
                                            let v1017: i32 = *v1017;
                                            let v1018: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                            US11::US11_Error(v1018, v820, v821, v822, v823, v824)
                                        }
                                        US11::US11_Ok(v1006, v1007, v1008, v1009, v1010, v1011) => {
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
                                US11::US11_Ok(v924, v925, v926, v927, v928, v929) => {
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
                        US11::US11_Ok(v841, v842, v843, v844, v845, v846) => {
                            let v841: Rc<str> = v841.clone();
                            let v842: i32 = *v842;
                            let v843: i32 = *v843;
                            let v844: i32 = *v844;
                            let v845: i32 = *v845;
                            let v846: i32 = *v846;
                            v840
                        }
                    };
                    let v1048: US11 = match &v1025 {
                        US11::US11_Error(v1026, v1027, v1028, v1029, v1030, v1031) => {
                            let v1026: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1026.clone();
                            let v1027: i32 = *v1027;
                            let v1028: i32 = *v1028;
                            let v1029: i32 = *v1029;
                            let v1030: i32 = *v1030;
                            let v1031: i32 = *v1031;
                            let v1032: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US11::US11_Ok(v1032, v820, v821, v822, v823, v824)
                        }
                        US11::US11_Ok(v1034, v1035, v1036, v1037, v1038, v1039) => {
                            let v1034: Rc<str> = v1034.clone();
                            let v1035: i32 = *v1035;
                            let v1036: i32 = *v1036;
                            let v1037: i32 = *v1037;
                            let v1038: i32 = *v1038;
                            let v1039: i32 = *v1039;
                            let v1040: bool = v1035 == v820;
                            if v1040 {
                                let v1041: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                US11::US11_Error(v1041, v820, v821, v822, v823, v824)
                            } else {
                                let v1043: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                let v1044: i32 = 0i32;
                                method71(v0.clone(), v1043.clone(), v1043, v1034, v1044, v1035, v1036, v1037, v1038, v1039)
                            }
                        }
                    };
                    match &v1048 {
                        US11::US11_Error(v1091, v1092, v1093, v1094, v1095, v1096) => {
                            let v1091: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1091.clone();
                            let v1092: i32 = *v1092;
                            let v1093: i32 = *v1093;
                            let v1094: i32 = *v1094;
                            let v1095: i32 = *v1095;
                            let v1096: i32 = *v1096;
                            let v1097: bool = v820 >= v824;
                            let v1115: US10 = if v1097 {
                                let v1098: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_Error(v1098, v820, v821, v822, v823, v824)
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
                                    US10::US10_Ok(b'"', v1102, v1107, v1108, v1109, v1110)
                                } else {
                                    let v1112: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_Error(v1112, v820, v821, v822, v823, v824)
                                }
                            };
                            match &v1115 {
                                US10::US10_Error(v1124, v1125, v1126, v1127, v1128, v1129) => {
                                    let v1124: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1124.clone();
                                    let v1125: i32 = *v1125;
                                    let v1126: i32 = *v1126;
                                    let v1127: i32 = *v1127;
                                    let v1128: i32 = *v1128;
                                    let v1129: i32 = *v1129;
                                    let v1130: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                    US11::US11_Error(v1130, v820, v821, v822, v823, v824)
                                }
                                US10::US10_Ok(v1116, v1117, v1118, v1119, v1120, v1121) => {
                                    let v1116: u8 = *v1116;
                                    let v1117: i32 = *v1117;
                                    let v1118: i32 = *v1118;
                                    let v1119: i32 = *v1119;
                                    let v1120: i32 = *v1120;
                                    let v1121: i32 = *v1121;
                                    let v1122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    US11::US11_Ok(v1122, v1117, v1118, v1119, v1120, v1121)
                                }
                            }
                        }
                        US11::US11_Ok(v1049, v1050, v1051, v1052, v1053, v1054) => {
                            let v1049: Rc<str> = v1049.clone();
                            let v1050: i32 = *v1050;
                            let v1051: i32 = *v1051;
                            let v1052: i32 = *v1052;
                            let v1053: i32 = *v1053;
                            let v1054: i32 = *v1054;
                            let v1055: bool = v1050 >= v1054;
                            let v1073: US10 = if v1055 {
                                let v1056: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_Error(v1056, v1050, v1051, v1052, v1053, v1054)
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
                                    US10::US10_Ok(b'"', v1060, v1065, v1066, v1067, v1068)
                                } else {
                                    let v1070: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_Error(v1070, v1050, v1051, v1052, v1053, v1054)
                                }
                            };
                            match &v1073 {
                                US10::US10_Error(v1081, v1082, v1083, v1084, v1085, v1086) => {
                                    let v1081: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1081.clone();
                                    let v1082: i32 = *v1082;
                                    let v1083: i32 = *v1083;
                                    let v1084: i32 = *v1084;
                                    let v1085: i32 = *v1085;
                                    let v1086: i32 = *v1086;
                                    let v1087: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v820, v1050, v1081, v1082, v1083, v1084, v1085, v1086);
                                    US11::US11_Error(v1087, v1050, v1051, v1052, v1053, v1054)
                                }
                                US10::US10_Ok(v1074, v1075, v1076, v1077, v1078, v1079) => {
                                    let v1074: u8 = *v1074;
                                    let v1075: i32 = *v1075;
                                    let v1076: i32 = *v1076;
                                    let v1077: i32 = *v1077;
                                    let v1078: i32 = *v1078;
                                    let v1079: i32 = *v1079;
                                    US11::US11_Ok(v1049, v1075, v1076, v1077, v1078, v1079)
                                }
                            }
                        }
                    }
                }
            }
        }
        US11::US11_Ok(v793, v794, v795, v796, v797, v798) => {
            let v793: Rc<str> = v793.clone();
            let v794: i32 = *v794;
            let v795: i32 = *v795;
            let v796: i32 = *v796;
            let v797: i32 = *v797;
            let mut v798: i32 = *v798;
            v792
        }
    };
    let v1180: US11 = match &v1146 {
        US11::US11_Error(v1153, v1154, v1155, v1156, v1157, v1158) => {
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
            let (mut v1163, mut v1164, mut v1165, mut v1166, mut v1167): (i32, i32, i32, i32, i32) = method72(v1, v0.clone(), v1159, v1160, v1161, v1162, v1);
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
                US11::US11_Ok(v1174, v1163, v1164, v1165, v1166, v1167)
            } else {
                let v1176: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                US11::US11_Error(v1176, 0i32, 0i32, 1i32, 1i32, v1)
            }
        }
        US11::US11_Ok(v1147, v1148, v1149, v1150, v1151, v1152) => {
            let v1147: Rc<str> = v1147.clone();
            let v1148: i32 = *v1148;
            let v1149: i32 = *v1149;
            let v1150: i32 = *v1150;
            let v1151: i32 = *v1151;
            let v1152: i32 = *v1152;
            v1146
        }
    };
    let v1219: US11 = match &v1180 {
        US11::US11_Error(v1187, v1188, v1189, v1190, v1191, v1192) => {
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
            let v1198: US19 = method73(v0.clone(), v1193, v1194, v1195, v1196, v1197, v1);
            match &v1198 {
                US19::US19_Error(v1209, v1210, v1211, v1212, v1213, v1214) => {
                    let v1209: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1209.clone();
                    let v1210: i32 = *v1210;
                    let v1211: i32 = *v1211;
                    let v1212: i32 = *v1212;
                    let v1213: i32 = *v1213;
                    let v1214: i32 = *v1214;
                    US11::US11_Error(v1209, v1210, v1211, v1212, v1213, v1214)
                }
                US19::US19_Ok(v1199, v1200, v1201, v1202, v1203, v1204) => {
                    let v1199: Rc<UH0> = v1199.clone();
                    let v1200: i32 = *v1200;
                    let v1201: i32 = *v1201;
                    let v1202: i32 = *v1202;
                    let v1203: i32 = *v1203;
                    let v1204: i32 = *v1204;
                    let v1205: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let (mut v1206, mut v1207): (Rc<str>, Rc<str>) = method75(v1199, v1205.clone(), v1205);
                    US11::US11_Ok(v1206, v1200, v1201, v1202, v1203, v1204)
                }
            }
        }
        US11::US11_Ok(v1181, v1182, v1183, v1184, v1185, v1186) => {
            let v1181: Rc<str> = v1181.clone();
            let v1182: i32 = *v1182;
            let v1183: i32 = *v1183;
            let v1184: i32 = *v1184;
            let v1185: i32 = *v1185;
            let v1186: i32 = *v1186;
            v1180
        }
    };
    let v1230: US11 = match &v1219 {
        US11::US11_Ok(v1220, v1221, v1222, v1223, v1224, v1225) => {
            let v1220: Rc<str> = v1220.clone();
            let v1221: i32 = *v1221;
            let v1222: i32 = *v1222;
            let v1223: i32 = *v1223;
            let v1224: i32 = *v1224;
            let v1225: i32 = *v1225;
            let v1226: bool = v1221 == 0i32;
            if v1226 {
                let v1227: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure48();
                US11::US11_Error(v1227, 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                v1219.clone()
            }
        }
        _ => {
            v1219
        }
    };
    let v1247: US11 = match &v1230 {
        US11::US11_Error(v1231, v1232, v1233, v1234, v1235, v1236) => {
            let v1231: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1231.clone();
            let v1232: i32 = *v1232;
            let v1233: i32 = *v1233;
            let v1234: i32 = *v1234;
            let v1235: i32 = *v1235;
            let v1236: i32 = *v1236;
            US11::US11_Error(v1231, v1232, v1233, v1234, v1235, v1236)
        }
        US11::US11_Ok(v1238, v1239, v1240, v1241, v1242, v1243) => {
            let v1238: Rc<str> = v1238.clone();
            let v1239: i32 = *v1239;
            let v1240: i32 = *v1240;
            let v1241: i32 = *v1241;
            let v1242: i32 = *v1242;
            let v1243: i32 = *v1243;
            let v1244: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            method76(v0.clone(), v1238, v1244, v1239, v1240, v1241, v1242, v1243)
        }
    };
    let v1266: US19 = match &v1247 {
        US11::US11_Error(v1248, v1249, v1250, v1251, v1252, v1253) => {
            let v1248: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1248.clone();
            let v1249: i32 = *v1249;
            let v1250: i32 = *v1250;
            let v1251: i32 = *v1251;
            let v1252: i32 = *v1252;
            let v1253: i32 = *v1253;
            let v1254: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            US19::US19_Ok(v1254, 0i32, 0i32, 1i32, 1i32, v1)
        }
        US11::US11_Ok(v1256, v1257, v1258, v1259, v1260, v1261) => {
            let v1256: Rc<str> = v1256.clone();
            let v1257: i32 = *v1257;
            let v1258: i32 = *v1258;
            let v1259: i32 = *v1259;
            let v1260: i32 = *v1260;
            let v1261: i32 = *v1261;
            let v1262: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let v1263: Rc<UH0> = Rc::new(UH0::UH0_Cons(v1256, v1262));
            method82(v0.clone(), v1263, v1257, v1258, v1259, v1260, v1261)
        }
    };
    let v1289: US20 = match &v1266 {
        US19::US19_Error(v1280, v1281, v1282, v1283, v1284, v1285) => {
            let v1280: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1280.clone();
            let v1281: i32 = *v1281;
            let v1282: i32 = *v1282;
            let v1283: i32 = *v1283;
            let v1284: i32 = *v1284;
            let v1285: i32 = *v1285;
            let v1286: Rc<dyn Fn() -> Rc<str>> = closure34(v0.clone(), v1280, v1281, v1282, v1283, v1284, v1285);
            US20::US20_Error(v1286)
        }
        US19::US19_Ok(v1267, v1268, v1269, v1270, v1271, v1272) => {
            let v1267: Rc<UH0> = v1267.clone();
            let v1268: i32 = *v1268;
            let v1269: i32 = *v1269;
            let v1270: i32 = *v1270;
            let v1271: i32 = *v1271;
            let v1272: i32 = *v1272;
            let v1273: bool = v1268 >= v1272;
            let v1278: Rc<str> = if v1273 {
                let v1274: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v1274
            } else {
                let v1276: i32 = v1272.wrapping_sub(1i32);
                let v1277: Rc<str> = string_slice(&v0, v1268 as i64, v1276 as i64);
                v1277
            };
            US20::US20_Ok(v1267, v1278, v1269, v1270, v1271, v1272)
        }
    };
    let v1305: US21 = match &v1289 {
        US20::US20_Error(v1302) => {
            let v1302: Rc<dyn Fn() -> Rc<str>> = v1302.clone();
            US21::US21_Error(v1302)
        }
        US20::US20_Ok(v1290, v1291, v1292, v1293, v1294, v1295) => {
            let v1290: Rc<UH0> = v1290.clone();
            let v1291: Rc<str> = v1291.clone();
            let v1292: i32 = *v1292;
            let v1293: i32 = *v1293;
            let v1294: i32 = *v1294;
            let v1295: i32 = *v1295;
            let v1296: i32 = 0i32;
            let v1297: i32 = method83(v1290.clone(), v1296);
            let v1298: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::with_capacity(v1297 as usize)));
            let v1299: i32 = 0i32;
            let v1300: i32 = method84(v1298.clone(), v1290, v1299);
            US21::US21_Ok(v1298)
        }
    };
    match &v1305 {
        US21::US21_Error(v1308) => {
            let mut v1308: Rc<dyn Fn() -> Rc<str>> = v1308.clone();
            let v1309: Rc<str> = v1308();
            US18::US18_Error(v1309)
        }
        US21::US21_Ok(v1306) => {
            let v1306: Rc<RefCell<Vec<Rc<str>>>> = v1306.clone();
            US18::US18_Ok(v1306)
        }
    }
}
fn closure51() -> Rc<dyn Fn((Rc<str>)) -> std::string::String> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((Rc<str>)) -> std::string::String> = Rc::new(move |mut v0: (Rc<str>)| -> std::string::String {
        let mut v1: Rc<str> = (v0);
        let mut v3: &str = &*v1;
        let mut v5: std::string::String = String::from(v3);
        v5.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method85(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v7)), v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options"); } LIT.with(|lit| lit.clone()) };
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
    let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v33));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v35, v36))));
    method8(v38)
}
fn ok_c53() -> Rc<dyn Fn(std::string::String) -> US22> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US22> = Rc::new(move |mut v0: std::string::String| -> US22 {
        US22::US22_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method86() -> Rc<dyn Fn(std::string::String) -> US22> {
    ok_c53()
}
fn error_c54() -> Rc<dyn Fn(std::string::String) -> US22> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US22> = Rc::new(move |mut v0: std::string::String| -> US22 {
        US22::US22_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method87() -> Rc<dyn Fn(std::string::String) -> US22> {
    error_c54()
}
fn method88() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[91m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn method89(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: bool, mut v9: std::string::String) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v12, v13)), v7)), v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.stdio_line"); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("trace'"); } LIT.with(|lit| lit.clone()) };
    let v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("trace'"); } LIT.with(|lit| lit.clone()) };
    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("trace' = "); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = format_real_51(v8);
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v27));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v25));
    let v34: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v9)).s() });
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v34));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v35));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v37, v38))));
    method8(v40)
}
fn method90() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[90m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = format_real_5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7
}
fn format_real_92() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v1: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v0 }));
    let mut v2: Rc<str> = v1.borrow().l0.clone();
    v2
}
fn method91(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_11(v9);
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v11, v12)), v7)), v10)), v8));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let v19: Rc<str> = format_real_92();
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    method8(v20)
}
fn on_stdout_c52(mut v0: bool) -> Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> {
    Rc::new(move |mut v1: Result<std::string::String, std::string::String>| -> std::string::String {
        let mut v2: Rc<dyn Fn(std::string::String) -> US22> = method86();
        let mut v3: Rc<dyn Fn(std::string::String) -> US22> = method87();
        let mut v4: US22 = match v1 { Ok(x) => v2(x), Err(e) => v3(e) };
        match &v4 {
            US22::US22_Error(v83) => {
                let mut v83: std::string::String = v83.clone();
                let v85: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                { let _ = spiral_trace_hold(&v85); };
                let mut v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                let (mut v88, mut v89, mut v90, mut v91, mut v92, mut v93): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v87) };
                let v94: US0 = v92.borrow().l0.clone();
                let mut v99: i32 = match &v94 {
                    US0::US0_Critical => {
                        50i32
                    }
                    US0::US0_Debug => {
                        20i32
                    }
                    US0::US0_Info => {
                        30i32
                    }
                    US0::US0_Verbose => {
                        10i32
                    }
                    US0::US0_Warning => {
                        40i32
                    }
                };
                let v100: bool = v90.borrow().l0.clone();
                let v101: bool = v100 == false;
                let mut v103: bool = if v101 {
                    false
                } else {
                    let mut v102: bool = 50i32 >= v99;
                    v102
                };
                let v104: bool = v103 == false;
                let mut v152: US2 = if v104 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v85); };
                    let (mut v108, mut v109, mut v110, mut v111, mut v112, mut v113): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v87) };
                    let v114: Rc<str> = method3(v108.clone(), v109.clone(), v110.clone(), v111.clone(), v112.clone(), v113.clone());
                    let v115: Rc<str> = method88();
                    let mut v116: Rc<str> = method89(v108.clone(), v109.clone(), v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v0, v83.clone());
                    { let _ = spiral_trace_hold(&v85); };
                    let (mut v119, mut v120, mut v121, mut v122, mut v123, mut v124): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v87) };
                    let v125: i64 = v119.borrow().l0.clone();
                    let v126: i64 = v125.wrapping_add(1i64);
                    v119.borrow_mut().l0 = v126;
                    let mut v127: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
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
                                let mut v133: Rc<str> = v122.borrow().l0.clone();
                                let v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let v136: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v133, v134)), v116));
                                v136.clone()
                            }
                        };
                        let v140: usize = v138.chars().count();
                        let v141: i32 = ((v140) as i32);
                        let v142: i32 = v141.wrapping_add(14999i32);
                        let mut v143: i32 = v142.wrapping_div(15000i32);
                        let mut v144: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
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
                    US2::US2_Some(v119.clone(), v120.clone(), v121.clone(), v122.clone(), v123.clone(), v124.clone())
                };
                let mut v153: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v83));
                let mut v155: &str = &*v153;
                let mut v157: std::string::String = String::from(v155);
                v157.clone()
            }
            US22::US22_Ok(v5) => {
                let mut v5: std::string::String = v5.clone();
                let mut v7: std::string::String = v5.clone();
                let mut v9: Rc<str> = Rc::<str>::from(String::as_str(&v7));
                let mut v10: Rc<str> = Rc::<str>::from(format!("> {}", v9));
                if v0 {
                    let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    { let _ = spiral_trace_hold(&v12); };
                    let mut v14: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                    let (mut v15, mut v16, mut v17, mut v18, mut v19, mut v20): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                    let v21: US0 = v19.borrow().l0.clone();
                    let mut v26: i32 = match &v21 {
                        US0::US0_Critical => {
                            50i32
                        }
                        US0::US0_Debug => {
                            20i32
                        }
                        US0::US0_Info => {
                            30i32
                        }
                        US0::US0_Verbose => {
                            10i32
                        }
                        US0::US0_Warning => {
                            40i32
                        }
                    };
                    let mut v27: bool = v17.borrow().l0.clone();
                    let mut v28: bool = v27 == false;
                    let v30: bool = if v28 {
                        false
                    } else {
                        let mut v29: bool = 10i32 >= v26;
                        v29
                    };
                    let mut v31: bool = v30 == false;
                    let mut v82: US2 = if v31 {
                        US2::US2_None
                    } else {
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v35, mut v36, mut v37, mut v38, mut v39, mut v40): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                        let mut v41: Rc<str> = method3(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone());
                        let mut v42: Rc<str> = method90();
                        let v43: bool = &*v10 == "";
                        let mut v46: Rc<str> = if v43 {
                            let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v44.clone()
                        } else {
                            method91(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v10.clone())
                        };
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v49, mut v50, mut v51, mut v52, mut v53, mut v54): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                        let v55: i64 = v49.borrow().l0.clone();
                        let v56: i64 = v55.wrapping_add(1i64);
                        v49.borrow_mut().l0 = v56;
                        let mut v57: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
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
                            let mut v71: i32 = ((v70) as i32);
                            let v72: i32 = v71.wrapping_add(14999i32);
                            let mut v73: i32 = v72.wrapping_div(15000i32);
                            let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let v75: bool = v46 != v74 ;
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
                        US2::US2_Some(v49.clone(), v50.clone(), v51.clone(), v52.clone(), v53.clone(), v54.clone())
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
fn on_stderr_c55(mut v0: bool) -> Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> {
    Rc::new(move |mut v1: Result<std::string::String, std::string::String>| -> std::string::String {
        let mut v2: Rc<dyn Fn(std::string::String) -> US22> = method86();
        let mut v3: Rc<dyn Fn(std::string::String) -> US22> = method87();
        let mut v4: US22 = match v1 { Ok(x) => v2(x), Err(e) => v3(e) };
        match &v4 {
            US22::US22_Error(v88) => {
                let v88: std::string::String = v88.clone();
                let v90: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                { let _ = spiral_trace_hold(&v90); };
                let v92: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                let (mut v93, mut v94, mut v95, mut v96, mut v97, mut v98): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v92) };
                let mut v99: US0 = v97.borrow().l0.clone();
                let v104: i32 = match &v99 {
                    US0::US0_Critical => {
                        50i32
                    }
                    US0::US0_Debug => {
                        20i32
                    }
                    US0::US0_Info => {
                        30i32
                    }
                    US0::US0_Verbose => {
                        10i32
                    }
                    US0::US0_Warning => {
                        40i32
                    }
                };
                let mut v105: bool = v95.borrow().l0.clone();
                let mut v106: bool = v105 == false;
                let mut v108: bool = if v106 {
                    false
                } else {
                    let mut v107: bool = 50i32 >= v104;
                    v107
                };
                let v109: bool = v108 == false;
                let mut v157: US2 = if v109 {
                    US2::US2_None
                } else {
                    { let _ = spiral_trace_hold(&v90); };
                    let (mut v113, mut v114, mut v115, mut v116, mut v117, mut v118): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v92) };
                    let mut v119: Rc<str> = method3(v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone());
                    let v120: Rc<str> = method88();
                    let mut v121: Rc<str> = method89(v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone(), v119.clone(), v120.clone(), v0, v88.clone());
                    { let _ = spiral_trace_hold(&v90); };
                    let (mut v124, mut v125, mut v126, mut v127, mut v128, mut v129): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v92) };
                    let mut v130: i64 = v124.borrow().l0.clone();
                    let v131: i64 = v130.wrapping_add(1i64);
                    v124.borrow_mut().l0 = v131;
                    let v132: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let mut v133: bool = cfg!(target_arch = "wasm32");
                    if v133 {
                        let v134: Rc<str> = v127.borrow().l0.clone();
                        let v135: bool = &*v134 == "";
                        let mut v143: Rc<str> = if v135 {
                            v121.clone()
                        } else {
                            let v136: bool = &*v121 == "";
                            if v136 {
                                let v137: Rc<str> = v127.borrow().l0.clone();
                                v137.clone()
                            } else {
                                let v138: Rc<str> = v127.borrow().l0.clone();
                                let v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
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
                    US2::US2_Some(v124.clone(), v125.clone(), v126.clone(), v127.clone(), v128.clone(), v129.clone())
                };
                let mut v158: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v88));
                let mut v160: &str = &*v158;
                let v162: std::string::String = String::from(v160);
                v162.clone()
            }
            US22::US22_Ok(v5) => {
                let mut v5: std::string::String = v5.clone();
                let mut v7: std::string::String = v5.clone();
                let mut v9: Rc<str> = Rc::<str>::from(String::as_str(&v7));
                let mut v10: Rc<str> = Rc::<str>::from(format!("! {}", v9));
                if v0 {
                    let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                    { let _ = spiral_trace_hold(&v12); };
                    let mut v14: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                    let (mut v15, mut v16, mut v17, mut v18, mut v19, mut v20): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                    let v21: US0 = v19.borrow().l0.clone();
                    let mut v26: i32 = match &v21 {
                        US0::US0_Critical => {
                            50i32
                        }
                        US0::US0_Debug => {
                            20i32
                        }
                        US0::US0_Info => {
                            30i32
                        }
                        US0::US0_Verbose => {
                            10i32
                        }
                        US0::US0_Warning => {
                            40i32
                        }
                    };
                    let mut v27: bool = v17.borrow().l0.clone();
                    let mut v28: bool = v27 == false;
                    let v30: bool = if v28 {
                        false
                    } else {
                        let mut v29: bool = 10i32 >= v26;
                        v29
                    };
                    let mut v31: bool = v30 == false;
                    let mut v82: US2 = if v31 {
                        US2::US2_None
                    } else {
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v35, mut v36, mut v37, mut v38, mut v39, mut v40): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                        let mut v41: Rc<str> = method3(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone());
                        let mut v42: Rc<str> = method90();
                        let v43: bool = &*v10 == "";
                        let mut v46: Rc<str> = if v43 {
                            let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v44.clone()
                        } else {
                            method91(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v10.clone())
                        };
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v49, mut v50, mut v51, mut v52, mut v53, mut v54): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                        let v55: i64 = v49.borrow().l0.clone();
                        let v56: i64 = v55.wrapping_add(1i64);
                        v49.borrow_mut().l0 = v56;
                        let mut v57: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
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
                            let mut v71: i32 = ((v70) as i32);
                            let v72: i32 = v71.wrapping_add(14999i32);
                            let mut v73: i32 = v72.wrapping_div(15000i32);
                            let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let v75: bool = v46 != v74 ;
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
                        US2::US2_Some(v49.clone(), v50.clone(), v51.clone(), v52.clone(), v53.clone(), v54.clone())
                    };
                    ()
                } else {
                    println!("{}", v10);
                    ()
                };
                let mut v83: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v5));
                let v85: &str = &*v83;
                let mut v87: std::string::String = String::from(v85);
                v87.clone()
            }
        }
    })
}
fn method93(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options / child error"); } LIT.with(|lit| lit.clone()) };
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
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v39));
    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v44: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v41, v42))));
    method8(v44)
}
fn method94(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options / output error"); } LIT.with(|lit| lit.clone()) };
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
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v39));
    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v44: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v41, v42))));
    method8(v44)
}
fn method95(mut v0: Option<i32>) -> Option<i32> {
    v0
}
fn closure56() -> Rc<dyn Fn((i32)) -> US23> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((i32)) -> US23> = Rc::new(move |mut v0: (i32)| -> US23 {
        let mut v1: i32 = (v0);
        US23::US23_Some(v1)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure57() -> Rc<dyn Fn((std::string::String)) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::string::String)) -> Rc<str>> = Rc::new(move |mut v0: (std::string::String)| -> Rc<str> {
        let mut v1: std::string::String = (v0);
        let mut v3: Rc<str> = Rc::<str>::from(String::as_str(&v1));
        v3.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method96(mut v0: Vec<Rc<str>>) -> Vec<Rc<str>> {
    v0
}
fn method97(mut v0: Rc<str>, mut v1: i32) -> i32 {
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
fn method98(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: i32, mut v10: i32) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v14)), v7)), v12));
    let v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options / result"); } LIT.with(|lit| lit.clone()) };
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
    let v34: Rc<str> = format_real_60(v9);
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v29));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("std_trace_len"); } LIT.with(|lit| lit.clone()) };
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v26));
    let v40: Rc<str> = format_real_60(v10);
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v40));
    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
    let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v43, v44))));
    method8(v46)
}
fn execute_with_options_57(mut v0: Rc<str>, mut v1: Option<std::sync::Arc<std::sync::atomic::AtomicBool>>, mut v2: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>>, mut v3: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>>, mut v4: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>>, mut v5: bool, mut v6: Option<Rc<str>>, mut v7: bool) -> (i32, Rc<str>) {
    let mut v8: Rc<str> = method58(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6.clone(), v7);
    let mut v9: US9 = split_command_59(v8.clone());
    let (mut v18, mut v19): (Rc<str>, US4) = match &v9 {
        US9::US9_Error(v12) => {
            let mut v12: Rc<str> = v12.clone();
            let mut v13: Rc<str> = Rc::<str>::from({ struct SpiralDebug<T>(T); trait SpiralDebugShow { fn show(&self) -> String; } impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> { fn show(&self) -> String { format!("{:?}", self.0) } } trait SpiralTypeShow { fn show(&self) -> String; } impl<T> SpiralTypeShow for &SpiralDebug<T> { fn show(&self) -> String { String::from(std::any::type_name::<T>()) } } format!("resultm.get / Error x: {}", (&SpiralDebug(&v12)).show()) });
            std::panic::panic_any::<std::string::String>(format!("{}", v13.clone()))
        }
        US9::US9_Ok(v10, v11) => {
            let mut v10: Rc<str> = v10.clone();
            let mut v11: US4 = v11.clone();
            (v10.clone(), v11.clone())
        }
    };
    let v23: Rc<str> = match &v19 {
        US4::US4_None => {
            let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v21.clone()
        }
        US4::US4_Some(v20) => {
            let mut v20: Rc<str> = v20.clone();
            v20.clone()
        }
    };
    let v24: US18 = split_args_68(v23.clone());
    let v30: Rc<RefCell<Vec<Rc<str>>>> = match &v24 {
        US18::US18_Error(v26) => {
            let mut v26: Rc<str> = v26.clone();
            let mut v27: Rc<str> = Rc::<str>::from({ struct SpiralDebug<T>(T); trait SpiralDebugShow { fn show(&self) -> String; } impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> { fn show(&self) -> String { format!("{:?}", self.0) } } trait SpiralTypeShow { fn show(&self) -> String; } impl<T> SpiralTypeShow for &SpiralDebug<T> { fn show(&self) -> String { String::from(std::any::type_name::<T>()) } } format!("resultm.get / Error x: {}", (&SpiralDebug(&v26)).show()) });
            std::panic::panic_any::<std::string::String>(format!("{}", v27.clone()))
        }
        US18::US18_Ok(v25) => {
            let mut v25: Rc<RefCell<Vec<Rc<str>>>> = v25.clone();
            v25.clone()
        }
    };
    let mut v31: Vec<Rc<str>> = (v30).borrow().clone();
    let mut v33: Rc<dyn Fn((Rc<str>)) -> std::string::String> = closure51();
    let v34: Vec<std::string::String> = v31.iter().map(|x| v33(x.clone())).collect::<Vec<_>>();
    let v36: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    { let _ = spiral_trace_hold(&v36); };
    let mut v38: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
    let (mut v39, mut v40, mut v41, mut v42, mut v43, mut v44): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
    let mut v45: US0 = v43.borrow().l0.clone();
    let v50: i32 = match &v45 {
        US0::US0_Critical => {
            50i32
        }
        US0::US0_Debug => {
            20i32
        }
        US0::US0_Info => {
            30i32
        }
        US0::US0_Verbose => {
            10i32
        }
        US0::US0_Warning => {
            40i32
        }
    };
    let v51: bool = v41.borrow().l0.clone();
    let mut v52: bool = v51 == false;
    let v54: bool = if v52 {
        false
    } else {
        let v53: bool = 20i32 >= v50;
        v53
    };
    let v55: bool = v54 == false;
    let v104: US2 = if v55 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v36); };
        let (mut v59, mut v60, mut v61, mut v62, mut v63, mut v64): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
        let mut v65: Rc<str> = method3(v59.clone(), v60.clone(), v61.clone(), v62.clone(), v63.clone(), v64.clone());
        let v66: Rc<str> = method48();
        let v67: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v34)).s() });
        let mut v68: Rc<str> = method85(v59.clone(), v60.clone(), v61.clone(), v62.clone(), v63.clone(), v64.clone(), v65.clone(), v66.clone(), v18.clone(), v67.clone());
        { let _ = spiral_trace_hold(&v36); };
        let (mut v71, mut v72, mut v73, mut v74, mut v75, mut v76): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
        let mut v77: i64 = v71.borrow().l0.clone();
        let mut v78: i64 = v77.wrapping_add(1i64);
        v71.borrow_mut().l0 = v78;
        let mut v79: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v80: bool = cfg!(target_arch = "wasm32");
        if v80 {
            let mut v81: Rc<str> = v74.borrow().l0.clone();
            let mut v82: bool = &*v81 == "";
            let v90: Rc<str> = if v82 {
                v68.clone()
            } else {
                let mut v83: bool = &*v68 == "";
                if v83 {
                    let v84: Rc<str> = v74.borrow().l0.clone();
                    v84.clone()
                } else {
                    let v85: Rc<str> = v74.borrow().l0.clone();
                    let v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v88: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v85, v86)), v68));
                    v88.clone()
                }
            };
            let v92: usize = v90.chars().count();
            let mut v93: i32 = ((v92) as i32);
            let v94: i32 = v93.wrapping_add(14999i32);
            let v95: i32 = v94.wrapping_div(15000i32);
            let v96: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v97: bool = v68 != v96 ;
            let mut v99: bool = if v97 {
                let mut v98: bool = v95 <= 1i32;
                v98
            } else {
                false
            };
            if v99 {
                v74.borrow_mut().l0 = v90.clone();
                ()
            } else {
                v74.borrow_mut().l0 = v96.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v90); };
                ()
            }
        } else {
            println!("{}", v68);
            ()
        };
        let mut v102: Rc<dyn Fn(Rc<str>) -> ()> = v72.borrow().l0.clone();
        v102(v68.clone());
        US2::US2_Some(v71.clone(), v72.clone(), v73.clone(), v74.clone(), v75.clone(), v76.clone())
    };
    let mut v106: Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> = on_stdout_c52(v5);
    let mut v107: Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> = on_stderr_c55(v5);
    let (mut v108, mut v109, mut v110, mut v111): (i32, Option<i32>, Option<std::string::String>, Vec<std::string::String>) = { let wd: Option<std::rc::Rc<str>> = v6.clone(); let stdin_fn: Option<std::rc::Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>)>> = v4.clone(); let token: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = v1.clone(); let stderr_on: bool = v7; let mut c = std::process::Command::new(&*v18); c.args(&*v34); c.stdout(std::process::Stdio::piped()); c.stderr(std::process::Stdio::piped()); c.stdin(std::process::Stdio::piped()); if let Some(d) = &wd { c.current_dir(&**d); } for (k, v) in v2.borrow().iter() { c.env(&**k, &**v); } match c.spawn() { Err(e) => (1i32, None, Some(format!("{}", e)), Vec::new()), Ok(mut child) => { let out = child.stdout.take().unwrap(); let err = child.stderr.take().unwrap(); let (tx, rx) = std::sync::mpsc::channel::<(bool, Result<std::string::String, std::string::String>)>(); let tx2 = tx.clone(); let h1 = std::thread::spawn(move || { for l in std::io::BufRead::lines(std::io::BufReader::new(encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(out))) { if tx.send((false, l.map_err(|e| format!("{}", e)))).is_err() { break; } } }); let h2 = std::thread::spawn(move || { for l in std::io::BufRead::lines(std::io::BufReader::new(encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(err))) { if stderr_on && tx2.send((true, l.map_err(|e| format!("{}", e)))).is_err() { break; } } }); if let (Some(f), Some(s)) = (&stdin_fn, child.stdin.take()) { let a = std::sync::Arc::new(std::sync::Mutex::new(s)); f(a.clone()); let _ = std::io::Write::flush(&mut *a.lock().unwrap()); } let mut lines: Vec<std::string::String> = Vec::new(); let mut cancelled = false; loop { if let Some(t) = &token { if t.load(std::sync::atomic::Ordering::SeqCst) { let _ = child.kill(); cancelled = true; break; } } match rx.recv_timeout(std::time::Duration::from_millis(100)) { Ok((false, l)) => lines.push(v106(l)), Ok((true, l)) => lines.push(v107(l)), Err(std::sync::mpsc::RecvTimeoutError::Timeout) => {}, Err(std::sync::mpsc::RecvTimeoutError::Disconnected) => break } } if !cancelled { let _ = h1.join(); let _ = h2.join(); } match child.wait() { Ok(s) => (0i32, s.code(), None, lines), Err(e) => (2i32, None, Some(format!("{}", e)), lines) } } } };
    let v112: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let v114: &str = &*v112;
    let mut v116: std::string::String = String::from(v114);
    let v118: std::string::String = v116.clone();
    let mut v119: std::string::String = v110.unwrap_or(v118);
    let mut v121: Rc<str> = Rc::<str>::from(String::as_str(&v119));
    let mut v122: bool = v108 == 1i32;
    let (mut v291, mut v292): (i32, Rc<str>) = if v122 {
        { let _ = spiral_trace_hold(&v36); };
        let (mut v125, mut v126, mut v127, mut v128, mut v129, mut v130): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
        let v131: US0 = v129.borrow().l0.clone();
        let v136: i32 = match &v131 {
            US0::US0_Critical => {
                50i32
            }
            US0::US0_Debug => {
                20i32
            }
            US0::US0_Info => {
                30i32
            }
            US0::US0_Verbose => {
                10i32
            }
            US0::US0_Warning => {
                40i32
            }
        };
        let v137: bool = v127.borrow().l0.clone();
        let v138: bool = v137 == false;
        let v140: bool = if v138 {
            false
        } else {
            let v139: bool = 50i32 >= v136;
            v139
        };
        let v141: bool = v140 == false;
        let v189: US2 = if v141 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v36); };
            let (mut v145, mut v146, mut v147, mut v148, mut v149, mut v150): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
            let mut v151: Rc<str> = method3(v145.clone(), v146.clone(), v147.clone(), v148.clone(), v149.clone(), v150.clone());
            let mut v152: Rc<str> = method88();
            let mut v153: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v34)).s() });
            let mut v154: Rc<str> = method93(v145.clone(), v146.clone(), v147.clone(), v148.clone(), v149.clone(), v150.clone(), v151.clone(), v152.clone(), v121.clone(), v18.clone(), v153.clone());
            { let _ = spiral_trace_hold(&v36); };
            let (mut v157, mut v158, mut v159, mut v160, mut v161, mut v162): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
            let mut v163: i64 = v157.borrow().l0.clone();
            let v164: i64 = v163.wrapping_add(1i64);
            v157.borrow_mut().l0 = v164;
            let v165: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
            let v166: bool = cfg!(target_arch = "wasm32");
            if v166 {
                let mut v167: Rc<str> = v160.borrow().l0.clone();
                let v168: bool = &*v167 == "";
                let mut v176: Rc<str> = if v168 {
                    v154.clone()
                } else {
                    let v169: bool = &*v154 == "";
                    if v169 {
                        let v170: Rc<str> = v160.borrow().l0.clone();
                        v170.clone()
                    } else {
                        let v171: Rc<str> = v160.borrow().l0.clone();
                        let mut v172: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v174: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v171, v172)), v154));
                        v174.clone()
                    }
                };
                let mut v178: usize = v176.chars().count();
                let v179: i32 = ((v178) as i32);
                let v180: i32 = v179.wrapping_add(14999i32);
                let v181: i32 = v180.wrapping_div(15000i32);
                let v182: bool = v154 != v112 ;
                let v184: bool = if v182 {
                    let v183: bool = v181 <= 1i32;
                    v183
                } else {
                    false
                };
                if v184 {
                    v160.borrow_mut().l0 = v176.clone();
                    ()
                } else {
                    v160.borrow_mut().l0 = v112.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v176); };
                    ()
                }
            } else {
                println!("{}", v154);
                ()
            };
            let mut v187: Rc<dyn Fn(Rc<str>) -> ()> = v158.borrow().l0.clone();
            v187(v154.clone());
            US2::US2_Some(v157.clone(), v158.clone(), v159.clone(), v160.clone(), v161.clone(), v162.clone())
        };
        (-1i32, v121.clone())
    } else {
        let v190: bool = v108 == 2i32;
        if v190 {
            { let _ = spiral_trace_hold(&v36); };
            let (mut v193, mut v194, mut v195, mut v196, mut v197, mut v198): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
            let v199: US0 = v197.borrow().l0.clone();
            let v204: i32 = match &v199 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let v205: bool = v195.borrow().l0.clone();
            let mut v206: bool = v205 == false;
            let mut v208: bool = if v206 {
                false
            } else {
                let v207: bool = 50i32 >= v204;
                v207
            };
            let mut v209: bool = v208 == false;
            let v257: US2 = if v209 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v36); };
                let (mut v213, mut v214, mut v215, mut v216, mut v217, mut v218): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
                let v219: Rc<str> = method3(v213.clone(), v214.clone(), v215.clone(), v216.clone(), v217.clone(), v218.clone());
                let v220: Rc<str> = method88();
                let mut v221: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v34)).s() });
                let mut v222: Rc<str> = method94(v213.clone(), v214.clone(), v215.clone(), v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone(), v121.clone(), v18.clone(), v221.clone());
                { let _ = spiral_trace_hold(&v36); };
                let (mut v225, mut v226, mut v227, mut v228, mut v229, mut v230): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
                let v231: i64 = v225.borrow().l0.clone();
                let v232: i64 = v231.wrapping_add(1i64);
                v225.borrow_mut().l0 = v232;
                let v233: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let v234: bool = cfg!(target_arch = "wasm32");
                if v234 {
                    let v235: Rc<str> = v228.borrow().l0.clone();
                    let v236: bool = &*v235 == "";
                    let mut v244: Rc<str> = if v236 {
                        v222.clone()
                    } else {
                        let mut v237: bool = &*v222 == "";
                        if v237 {
                            let v238: Rc<str> = v228.borrow().l0.clone();
                            v238.clone()
                        } else {
                            let mut v239: Rc<str> = v228.borrow().l0.clone();
                            let v240: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v242: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v239, v240)), v222));
                            v242.clone()
                        }
                    };
                    let v246: usize = v244.chars().count();
                    let v247: i32 = ((v246) as i32);
                    let v248: i32 = v247.wrapping_add(14999i32);
                    let mut v249: i32 = v248.wrapping_div(15000i32);
                    let v250: bool = v222 != v112 ;
                    let v252: bool = if v250 {
                        let v251: bool = v249 <= 1i32;
                        v251
                    } else {
                        false
                    };
                    if v252 {
                        v228.borrow_mut().l0 = v244.clone();
                        ()
                    } else {
                        v228.borrow_mut().l0 = v112.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v244); };
                        ()
                    }
                } else {
                    println!("{}", v222);
                    ()
                };
                let mut v255: Rc<dyn Fn(Rc<str>) -> ()> = v226.borrow().l0.clone();
                v255(v222.clone());
                US2::US2_Some(v225.clone(), v226.clone(), v227.clone(), v228.clone(), v229.clone(), v230.clone())
            };
            (-2i32, v121.clone())
        } else {
            let v258: Option<i32> = method95(v109.clone());
            let mut v259: Rc<dyn Fn((i32)) -> US23> = closure56();
            let mut v260: Option<US23> = v258.map(|x| v259(x));
            let v262: US23 = US23::US23_None;
            let v263: US23 = v262.clone();
            let v264: US23 = v260.unwrap_or(v263);
            let (mut v269, mut v270): (i32, Rc<str>) = match &v264 {
                US23::US23_None => {
                    let v266: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options / exit_code=None"); } LIT.with(|lit| lit.clone()) };
                    (-1i32, v266.clone())
                }
                US23::US23_Some(v265) => {
                    let v265: i32 = *v265;
                    (v265, v112.clone())
                }
            };
            let mut v272: Rc<dyn Fn((std::string::String)) -> Rc<str>> = closure57();
            let v273: Vec<Rc<str>> = v111.iter().map(|x| v272(x.clone())).collect::<Vec<_>>();
            let v274: Vec<Rc<str>> = method96(v273.clone());
            let v275: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v274));
            let v276: Rc<Vec<Rc<str>>> = Rc::new(v275.borrow().clone());
            let v277: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            let v278: Rc<str> = Rc::<str>::from(v276.iter().map(|x| x.to_string()).collect::<Vec<_>>().join(&*v277));
            let v279: i32 = (v278.clone().len() as i32);
            let mut v280: i32 = 0i32;
            let mut v281: i32 = method9(v278.clone(), v279, v280);
            let v282: i32 = v279.wrapping_sub(1i32);
            let mut v283: Rc<str> = string_slice(&v278.clone(), v281 as i64, v282 as i64);
            let mut v284: i32 = (v283.clone().len() as i32);
            let v285: i32 = method97(v283.clone(), v284);
            let v286: Rc<str> = string_slice(&v283.clone(), 0i32 as i64, v285 as i64);
            let v287: bool = &*v286 == "";
            let v288: Rc<str> = if v287 {
                v270.clone()
            } else {
                v286.clone()
            };
            (v269, v288.clone())
        }
    };
    { let _ = spiral_trace_hold(&v36); };
    let (mut v295, mut v296, mut v297, mut v298, mut v299, mut v300): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
    let v301: US0 = v299.borrow().l0.clone();
    let v306: i32 = match &v301 {
        US0::US0_Critical => {
            50i32
        }
        US0::US0_Debug => {
            20i32
        }
        US0::US0_Info => {
            30i32
        }
        US0::US0_Verbose => {
            10i32
        }
        US0::US0_Warning => {
            40i32
        }
    };
    let v307: bool = v297.borrow().l0.clone();
    let v308: bool = v307 == false;
    let mut v310: bool = if v308 {
        false
    } else {
        let v309: bool = 10i32 >= v306;
        v309
    };
    let v311: bool = v310 == false;
    let v359: US2 = if v311 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v36); };
        let (mut v315, mut v316, mut v317, mut v318, mut v319, mut v320): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
        let v321: Rc<str> = method3(v315.clone(), v316.clone(), v317.clone(), v318.clone(), v319.clone(), v320.clone());
        let v322: Rc<str> = method90();
        let v323: i32 = (v292.clone().len() as i32);
        let v324: Rc<str> = method98(v315.clone(), v316.clone(), v317.clone(), v318.clone(), v319.clone(), v320.clone(), v321.clone(), v322.clone(), v18.clone(), v291, v323);
        { let _ = spiral_trace_hold(&v36); };
        let (mut v327, mut v328, mut v329, mut v330, mut v331, mut v332): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v38) };
        let v333: i64 = v327.borrow().l0.clone();
        let v334: i64 = v333.wrapping_add(1i64);
        v327.borrow_mut().l0 = v334;
        let v335: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let v336: bool = cfg!(target_arch = "wasm32");
        if v336 {
            let v337: Rc<str> = v330.borrow().l0.clone();
            let v338: bool = &*v337 == "";
            let v346: Rc<str> = if v338 {
                v324.clone()
            } else {
                let v339: bool = &*v324 == "";
                if v339 {
                    let v340: Rc<str> = v330.borrow().l0.clone();
                    v340.clone()
                } else {
                    let v341: Rc<str> = v330.borrow().l0.clone();
                    let v342: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v344: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v341, v342)), v324));
                    v344.clone()
                }
            };
            let v348: usize = v346.chars().count();
            let v349: i32 = ((v348) as i32);
            let v350: i32 = v349.wrapping_add(14999i32);
            let v351: i32 = v350.wrapping_div(15000i32);
            let v352: bool = v324 != v112 ;
            let v354: bool = if v352 {
                let v353: bool = v351 <= 1i32;
                v353
            } else {
                false
            };
            if v354 {
                v330.borrow_mut().l0 = v346.clone();
                ()
            } else {
                v330.borrow_mut().l0 = v112.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v346); };
                ()
            }
        } else {
            println!("{}", v324);
            ()
        };
        let mut v357: Rc<dyn Fn(Rc<str>) -> ()> = v328.borrow().l0.clone();
        v357(v324.clone());
        US2::US2_Some(v327.clone(), v328.clone(), v329.clone(), v330.clone(), v331.clone(), v332.clone())
    };
    (v291, v292.clone())
}
fn method100(mut v0: Option<usize>) -> Option<usize> {
    v0
}
fn closure58() -> Rc<dyn Fn((usize)) -> i32> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((usize)) -> i32> = Rc::new(move |mut v0: (usize)| -> i32 {
        let mut v1: usize = (v0);
        let mut v2: i32 = ((v1) as i32);
        v2
    }); } CLOSURE.with(|closure| closure.clone())
}
fn fix_paths_99(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>) -> (Rc<str>, Rc<str>) {
    let mut v3: Rc<str> = get_file_name_27(v1.clone());
    let mut v4: Rc<str> = method34(v2, v3);
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
    let mut v6: Option<usize> = v1.rfind(&*v5);
    let mut v7: Option<usize> = method100(v6);
    let mut v8: Rc<dyn Fn((usize)) -> i32> = closure58();
    let mut v9: Option<i32> = v7.map(|x| v8(x));
    let mut v11: i32 = v9.unwrap_or(-1i32);
    let mut v12: i32 = v11.wrapping_sub(1i32);
    let mut v13: Rc<str> = string_slice(&v1.clone(), 0i32 as i64, v12 as i64);
    let mut v14: Option<usize> = v4.rfind(&*v5);
    let v15: Option<usize> = method100(v14);
    let mut v16: Option<i32> = v15.map(|x| v8(x));
    let v18: i32 = v16.unwrap_or(-1i32);
    let v19: i32 = v18.wrapping_sub(1i32);
    let mut v20: Rc<str> = string_slice(&v4.clone(), 0i32 as i64, v19 as i64);
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".md"); } LIT.with(|lit| lit.clone()) };
    let mut v22: bool = v0.ends_with(&*v21);
    let v23: bool = v22 == false;
    let mut v28: Rc<str> = if v23 {
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v1, v5)), v0));
        v25
    } else {
        let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v13, v5)), v0));
        v27
    };
    let mut v33: Rc<str> = if v23 {
        let v30: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v4, v5)), v0));
        v30
    } else {
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v20, v5)), v0));
        v32
    };
    (v28, v33)
}
fn closure59() -> Rc<dyn Fn((u8)) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((u8)) -> Rc<str>> = Rc::new(move |mut v0: (u8)| -> Rc<str> {
        let mut v1: u8 = (v0);
        let mut v3: std::string::String = format!("{:02x}", v1);
        let mut v5: Rc<str> = Rc::<str>::from(String::as_str(&v3));
        v5.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method101(mut v0: Rc<Vec<Rc<str>>>, mut v1: i32, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: Rc<str> = (v0)[v1 as usize].clone();
            let mut v5: i32 = v1.wrapping_sub(1i32);
            let mut v6: Rc<UH0> = Rc::new(UH0::UH0_Cons(v4.clone(), v2.clone()));
            (v0, v1, v2) = (v0.clone(), v5, v6.clone());
            continue;
        }
    }
}
fn method102() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    v0
}
fn method103(mut v0: Rc<str>, mut v1: Rc<UH0>, mut v2: Rc<str>, mut v3: Rc<str>) -> (Rc<str>, Rc<str>) {
    let (mut v12, mut v13): (Rc<str>, Rc<str>) = match &*v1 {
        UH0::UH0_Cons(v4, v5) => {
            let mut v4: Rc<str> = v4.clone();
            let mut v5: Rc<UH0> = v5.clone();
            let (mut v6, mut v7): (Rc<str>, Rc<str>) = method103(v0.clone(), v5, v2.clone(), v3.clone());
            let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v4, v7)), v6));
            (v9, v0)
        }
        _ => {
            let (mut v10, mut v11): (Rc<str>, Rc<str>) = match &*v1 {
                UH0::UH0_Nil => {
                    (v2, v3)
                }
                _ => unreachable!(),
            };
            (v10, v11)
        }
    };
    (v12, v13)
}
fn closure60() -> Rc<dyn Fn(std::io::Error) -> std::string::String> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::io::Error) -> std::string::String> = Rc::new(move |mut v0: std::io::Error| -> std::string::String {
        let mut v2: std::string::String = format!("{}", v0);
        v2.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method104() -> Rc<dyn Fn(std::io::Error) -> std::string::String> {
    closure60()
}
fn ok_c61() -> Rc<dyn Fn(Rc<str>) -> US25> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> US25> = Rc::new(move |mut v0: Rc<str>| -> US25 {
        US25::US25_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method105() -> Rc<dyn Fn(Rc<str>) -> US25> {
    ok_c61()
}
fn error_c62() -> Rc<dyn Fn(std::string::String) -> US25> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US25> = Rc::new(move |mut v0: std::string::String| -> US25 {
        US25::US25_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method106() -> Rc<dyn Fn(std::string::String) -> US25> {
    error_c62()
}
fn method107(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>, mut v11: Rc<str>, mut v12: i32, mut v13: Rc<str>, mut v14: i32, mut v15: Rc<str>, mut v16: Rc<str>, mut v17: US4, mut v18: Rc<str>, mut v19: Rc<str>) -> Rc<str> {
    let mut v20: i64 = v0.borrow().l0.clone();
    let v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v21));
    let v23: Rc<str> = format_real_11(v20);
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v22, v23)), v7)), v21)), v8));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
    let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v33, v34)), v9));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
    let v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("real_path"); } LIT.with(|lit| lit.clone()) };
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v38, v39)), v34)), v10)), v37));
    let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("relative_path"); } LIT.with(|lit| lit.clone()) };
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v43, v44)), v34)), v11)), v37));
    let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("origin_hash_exit_code"); } LIT.with(|lit| lit.clone()) };
    let v51: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v48, v49)), v34));
    let mut v52: Rc<str> = format_real_60(v12);
    let v54: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v51, v52)), v37));
    let v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("origin_hash"); } LIT.with(|lit| lit.clone()) };
    let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v54, v55)), v34)), v13)), v37));
    let v60: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("local_git_hash_exit_code"); } LIT.with(|lit| lit.clone()) };
    let v62: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v59, v60)), v34));
    let mut v63: Rc<str> = format_real_60(v14);
    let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v62, v63)), v37));
    let v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("local_git_hash"); } LIT.with(|lit| lit.clone()) };
    let mut v70: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v65, v66)), v34)), v15)), v37));
    let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash1"); } LIT.with(|lit| lit.clone()) };
    let v75: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v70, v71)), v34)), v16)), v37));
    let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash2"); } LIT.with(|lit| lit.clone()) };
    let mut v78: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v75, v76)), v34));
    let mut v79: Rc<str> = method50(v17);
    let mut v81: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v78, v79)), v37));
    let mut v82: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist_path"); } LIT.with(|lit| lit.clone()) };
    let v86: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v81, v82)), v34)), v18)), v37));
    let mut v87: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache_path"); } LIT.with(|lit| lit.clone()) };
    let v90: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v86, v87)), v34)), v19));
    let v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v92: Rc<str> = Rc::<str>::from(format!("{}{}", v91, v90));
    let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v95: Rc<str> = Rc::<str>::from(format!("{}{}", v29, Rc::<str>::from(format!("{}{}", v92, v93))));
    method8(v95)
}
fn ok_c63() -> Rc<dyn Fn(u64) -> US26> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(u64) -> US26> = Rc::new(move |mut v0: u64| -> US26 {
        US26::US26_Ok(v0)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method109() -> Rc<dyn Fn(u64) -> US26> {
    ok_c63()
}
fn error_c64() -> Rc<dyn Fn(std::string::String) -> US26> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US26> = Rc::new(move |mut v0: std::string::String| -> US26 {
        US26::US26_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method110() -> Rc<dyn Fn(std::string::String) -> US26> {
    error_c64()
}
fn method111(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: std::string::String) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
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
    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method8(v45)
}
fn format_real_113(mut v0: u64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1 }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3);
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4
}
fn method112(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: u64) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
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
    let v39: Rc<str> = format_real_113(v10);
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v39));
    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method8(v45)
}
fn file_copy_108(mut v0: Rc<str>, mut v1: Rc<str>) -> () {
    let mut v3: Result<u64, std::io::Error> = std::fs::copy(&*v1, &*v0);
    let mut v4: Rc<dyn Fn(std::io::Error) -> std::string::String> = method104();
    let mut v6: Result<u64, std::string::String> = v3.map_err(|x| v4(x));
    let mut v7: Rc<dyn Fn(u64) -> US26> = method109();
    let mut v8: Rc<dyn Fn(std::string::String) -> US26> = method110();
    let mut v9: US26 = match v6 { Ok(x) => v7(x), Err(e) => v8(e) };
    match &v9 {
        US26::US26_Error(v80) => {
            let mut v80: std::string::String = v80.clone();
            let mut v82: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
            { let _ = spiral_trace_hold(&v82); };
            let v84: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v85, mut v86, mut v87, mut v88, mut v89, mut v90): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v84) };
            let v91: US0 = v89.borrow().l0.clone();
            let v96: i32 = match &v91 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let mut v97: bool = v87.borrow().l0.clone();
            let mut v98: bool = v97 == false;
            let v100: bool = if v98 {
                false
            } else {
                let mut v99: bool = 40i32 >= v96;
                v99
            };
            let v101: bool = v100 == false;
            let v149: US2 = if v101 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v82); };
                let (mut v105, mut v106, mut v107, mut v108, mut v109, mut v110): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v84) };
                let v111: Rc<str> = method3(v105.clone(), v106.clone(), v107.clone(), v108.clone(), v109.clone(), v110.clone());
                let v112: Rc<str> = method42();
                let v113: Rc<str> = method111(v105, v106, v107, v108, v109, v110, v111, v112, v1.clone(), v0.clone(), v80);
                { let _ = spiral_trace_hold(&v82); };
                let (mut v116, mut v117, mut v118, mut v119, mut v120, mut v121): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v84) };
                let mut v122: i64 = v116.borrow().l0.clone();
                let v123: i64 = v122.wrapping_add(1i64);
                v116.borrow_mut().l0 = v123;
                let mut v124: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
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
                            v129
                        } else {
                            let mut v130: Rc<str> = v119.borrow().l0.clone();
                            let v131: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v133: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v130, v131)), v113));
                            v133
                        }
                    };
                    let v137: usize = v135.chars().count();
                    let v138: i32 = ((v137) as i32);
                    let v139: i32 = v138.wrapping_add(14999i32);
                    let v140: i32 = v139.wrapping_div(15000i32);
                    let v141: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v142: bool = v113 != v141 ;
                    let mut v144: bool = if v142 {
                        let mut v143: bool = v140 <= 1i32;
                        v143
                    } else {
                        false
                    };
                    if v144 {
                        v119.borrow_mut().l0 = v135.clone();
                        ()
                    } else {
                        v119.borrow_mut().l0 = v141;
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v135); };
                        ()
                    }
                } else {
                    println!("{}", v113);
                    ()
                };
                let mut v147: Rc<dyn Fn(Rc<str>) -> ()> = v117.borrow().l0.clone();
                v147(v113);
                US2::US2_Some(v116, v117, v118, v119, v120, v121)
            };
            ()
        }
        US26::US26_Ok(v10) => {
            let mut v10: u64 = *v10;
            let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
            { let _ = spiral_trace_hold(&v12); };
            let mut v14: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
            let (mut v15, mut v16, mut v17, mut v18, mut v19, mut v20): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
            let v21: US0 = v19.borrow().l0.clone();
            let mut v26: i32 = match &v21 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let mut v27: bool = v17.borrow().l0.clone();
            let mut v28: bool = v27 == false;
            let v30: bool = if v28 {
                false
            } else {
                let mut v29: bool = 20i32 >= v26;
                v29
            };
            let mut v31: bool = v30 == false;
            let mut v79: US2 = if v31 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v12); };
                let (mut v35, mut v36, mut v37, mut v38, mut v39, mut v40): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                let mut v41: Rc<str> = method3(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone());
                let mut v42: Rc<str> = method48();
                let v43: Rc<str> = method112(v35, v36, v37, v38, v39, v40, v41, v42, v1, v0, v10);
                { let _ = spiral_trace_hold(&v12); };
                let (mut v46, mut v47, mut v48, mut v49, mut v50, mut v51): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                let mut v52: i64 = v46.borrow().l0.clone();
                let v53: i64 = v52.wrapping_add(1i64);
                v46.borrow_mut().l0 = v53;
                let v54: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
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
                            v59
                        } else {
                            let v60: Rc<str> = v49.borrow().l0.clone();
                            let v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v60, v61)), v43));
                            v63
                        }
                    };
                    let v67: usize = v65.chars().count();
                    let mut v68: i32 = ((v67) as i32);
                    let mut v69: i32 = v68.wrapping_add(14999i32);
                    let mut v70: i32 = v69.wrapping_div(15000i32);
                    let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v72: bool = v43 != v71 ;
                    let mut v74: bool = if v72 {
                        let mut v73: bool = v70 <= 1i32;
                        v73
                    } else {
                        false
                    };
                    if v74 {
                        v49.borrow_mut().l0 = v65.clone();
                        ()
                    } else {
                        v49.borrow_mut().l0 = v71;
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v65); };
                        ()
                    }
                } else {
                    println!("{}", v43);
                    ()
                };
                let mut v77: Rc<dyn Fn(Rc<str>) -> ()> = v47.borrow().l0.clone();
                v77(v43);
                US2::US2_Some(v46, v47, v48, v49, v50, v51)
            };
            ()
        }
    }
}
fn method115(mut v0: Vec<u8>) -> Vec<u8> {
    v0
}
fn method116(mut v0: i32, mut v1: Rc<RefCell<Mut9>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method117(mut v0: Rc<str>) -> Rc<str> {
    v0
}
fn closure67(mut v0: Rc<str>) -> Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()> {
    Rc::new(move |mut v1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| -> () {
        let mut v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1;
        let mut v5: Result<std::sync::MutexGuard<std::process::ChildStdin>, std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> = v3.lock();
        let mut v7: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
        let mut v8: Rc<str> = method117(v0.clone());
        let mut v10: &[u8] = v8.as_bytes();
        let mut v12: bool = true; std::io::Write::write_all(&mut *v7, v10).unwrap();
        ()
    })
}
fn method118(mut v0: i32, mut v1: Rc<RefCell<Mut10>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method119(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: i32, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
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
    let mut v28: Rc<str> = format_real_60(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result_len"); } LIT.with(|lit| lit.clone()) };
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26));
    let mut v35: Rc<str> = format_real_60(v9);
    let v37: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v34, v35)), v30));
    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v37, v38)), v26)), v10));
    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v41));
    let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v43, v44))));
    method8(v46)
}
fn hangul_114(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<str>, mut v4: Rc<str>) -> US27 {
    let mut v6: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v4);
    let mut v8: Vec<u8> = v6.unwrap();
    let mut v9: Vec<u8> = method115(v8.clone());
    let mut v11: Result<std::string::String, std::string::FromUtf8Error> = std::string::String::from_utf8(v9);
    let mut v13: std::string::String = v11.unwrap();
    let v15: Rc<str> = Rc::<str>::from(String::as_str(&v13));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v15.split(&*v16).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let v18: i32 = (v17.clone().borrow().len() as i32);
    let v19: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v18 as usize]));
    let mut v20: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32 }));
    while method46(v18, v20.clone()) {
        let mut v22: i32 = v20.borrow().l0.clone();
        let v23: Rc<str> = v17.clone().borrow()[v22 as usize].clone();
        let v24: i32 = (v23.clone().len() as i32);
        let mut v25: i32 = 0i32;
        let mut v26: i32 = method9(v23.clone(), v24, v25);
        let mut v27: i32 = v24.wrapping_sub(1i32);
        let mut v28: Rc<str> = string_slice(&v23.clone(), v26 as i64, v27 as i64);
        let mut v29: i32 = (v28.clone().len() as i32);
        let v30: i32 = method97(v28.clone(), v29);
        let mut v31: Rc<str> = string_slice(&v28.clone(), 0i32 as i64, v30 as i64);
        v19.clone().borrow_mut()[v22 as usize] = v31.clone();
        let mut v32: i32 = v22.wrapping_add(1i32);
        v20.borrow_mut().l0 = v32;
        ()
    };
    let mut v33: i32 = (v19.clone().borrow().len() as i32);
    let v34: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v33 as usize]));
    let mut v35: Rc<RefCell<Mut9>> = Rc::new(RefCell::new(Mut9 { l0: 0i32, l1: 0i32 }));
    while method116(v33, v35.clone()) {
        let v37: i32 = v35.borrow().l0.clone();
        let mut v38: i32 = v35.borrow().l1.clone();
        let v39: Rc<str> = v19.clone().borrow()[v37 as usize].clone();
        let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v41: bool = v39 != v40 ;
        let v43: i32 = if v41 {
            v34.clone().borrow_mut()[v38 as usize] = v39.clone();
            let mut v42: i32 = v38.wrapping_add(1i32);
            v42
        } else {
            v38
        };
        let v44: i32 = v37.wrapping_add(1i32);
        v35.borrow_mut().l0 = v44;
        v35.borrow_mut().l1 = v43;
        ()
    };
    let mut v45: i32 = v35.borrow().l1.clone();
    let mut v46: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v45 as usize]));
    let mut v47: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32 }));
    while method46(v45, v47.clone()) {
        let mut v49: i32 = v47.borrow().l0.clone();
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
    let mut v71: Rc<str> = if v68 {
        let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".exe"); } LIT.with(|lit| lit.clone()) };
        v69.clone()
    } else {
        let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v70.clone()
    };
    let v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("../alphabet/deps/hangulize/cmd/hangulize/hangulize"); } LIT.with(|lit| lit.clone()) };
    let mut v73: Rc<str> = Rc::<str>::from(format!("{}{}", v72, v71));
    let mut v74: Rc<str> = method34(v0.clone(), v73.clone());
    let v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v77: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v74, v75)), v62));
    let mut v78: Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()> = closure67(v55.clone());
    let mut v79: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = Some(v78.clone());
    let mut v80: bool = true;
    let mut v81: bool = true;
    let (mut v82, mut v83): (i32, Rc<str>) = execute_with_options_57(v77.clone(), v63.clone(), v64.clone(), v65.clone(), v79.clone(), v80, v67.clone(), v81);
    let v84: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v83.split(&*v16).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let v85: i32 = (v84.clone().borrow().len() as i32);
    let v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v87: Rc<RefCell<Mut10>> = Rc::new(RefCell::new(Mut10 { l0: 0i32, l1: v86.clone(), l2: 0i32, l3: 0i32, l4: false }));
    while method118(v33, v87.clone()) {
        let v89: i32 = v87.borrow().l0.clone();
        let (mut v90, mut v91, mut v92, mut v93): (Rc<str>, i32, i32, bool) = (v87.borrow().l1.clone(), v87.borrow().l2.clone(), v87.borrow().l3.clone(), v87.borrow().l4.clone());
        let v94: Rc<str> = v19.clone().borrow()[v89 as usize].clone();
        let v95: bool = &*v94 == "";
        let (mut v126, mut v127, mut v128, mut v129): (Rc<str>, i32, i32, bool) = if v95 {
            let v96: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v16));
            let mut v97: i32 = v91.wrapping_add(1i32);
            let mut v98: i32 = v92.wrapping_add(1i32);
            (v96.clone(), v97, v98, v93)
        } else {
            let mut v99: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("```"); } LIT.with(|lit| lit.clone()) };
            let v100: bool = v94.starts_with(&*v99);
            let v101: i32 = v91.wrapping_sub(v92);
            let mut v102: bool = v101 >= v85;
            let mut v122: Rc<str> = if v102 {
                v90.clone()
            } else {
                let mut v103: bool = v100 || v93;
                if v103 {
                    let v104: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v94));
                    let mut v105: i32 = v85.wrapping_sub(1i32);
                    let mut v106: bool = v101 == v105;
                    if v106 {
                        v104.clone()
                    } else {
                        let mut v107: Rc<str> = Rc::<str>::from(format!("{}{}", v104, v16));
                        v107.clone()
                    }
                } else {
                    let v109: Rc<str> = v84.clone().borrow()[v101 as usize].clone();
                    let mut v110: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("://"); } LIT.with(|lit| lit.clone()) };
                    let v111: bool = v109.contains(&*v110);
                    let v112: Rc<str> = if v111 {
                        v94.clone()
                    } else {
                        v109.clone()
                    };
                    let v113: Rc<str> = Rc::<str>::from(format!("{}{}", v90, v112));
                    let mut v116: Rc<str> = if v2 {
                        v113.clone()
                    } else {
                        let v115: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v113, v16)), v94));
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
    let (mut v131, mut v132, mut v133, mut v134): (Rc<str>, i32, i32, bool) = (v87.borrow().l1.clone(), v87.borrow().l2.clone(), v87.borrow().l3.clone(), v87.borrow().l4.clone());
    std::fs::write(&*v3, &*v131).unwrap();
    let v137: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    { let _ = spiral_trace_hold(&v137); };
    let v139: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
    let (mut v140, mut v141, mut v142, mut v143, mut v144, mut v145): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v139) };
    let v146: US0 = v144.borrow().l0.clone();
    let mut v151: i32 = match &v146 {
        US0::US0_Critical => {
            50i32
        }
        US0::US0_Debug => {
            20i32
        }
        US0::US0_Info => {
            30i32
        }
        US0::US0_Verbose => {
            10i32
        }
        US0::US0_Warning => {
            40i32
        }
    };
    let mut v152: bool = v142.borrow().l0.clone();
    let mut v153: bool = v152 == false;
    let mut v155: bool = if v153 {
        false
    } else {
        let mut v154: bool = 30i32 >= v151;
        v154
    };
    let mut v156: bool = v155 == false;
    let v203: US2 = if v156 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v137); };
        let (mut v160, mut v161, mut v162, mut v163, mut v164, mut v165): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v139) };
        let v166: Rc<str> = method3(v160.clone(), v161.clone(), v162.clone(), v163.clone(), v164.clone(), v165.clone());
        let mut v167: Rc<str> = method4();
        let v168: i32 = (v131.clone().len() as i32);
        let v169: Rc<str> = method119(v160.clone(), v161.clone(), v162.clone(), v163.clone(), v164.clone(), v165.clone(), v166.clone(), v167.clone(), v82, v168, v3.clone());
        { let _ = spiral_trace_hold(&v137); };
        let (mut v172, mut v173, mut v174, mut v175, mut v176, mut v177): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v139) };
        let mut v178: i64 = v172.borrow().l0.clone();
        let v179: i64 = v178.wrapping_add(1i64);
        v172.borrow_mut().l0 = v179;
        let v180: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let v181: bool = cfg!(target_arch = "wasm32");
        if v181 {
            let v182: Rc<str> = v175.borrow().l0.clone();
            let v183: bool = &*v182 == "";
            let v190: Rc<str> = if v183 {
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
        US2::US2_Some(v172.clone(), v173.clone(), v174.clone(), v175.clone(), v176.clone(), v177.clone())
    };
    US27::US27_Ok(v82, v131.clone())
}
fn method120(mut v0: Rc<str>, mut v1: Rc<str>) -> (Rc<str>, Rc<str>) {
    (v0, v1)
}
fn method121(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
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
    let mut v27: Rc<str> = format_real_60(v8);
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v27));
    let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let v30: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v29));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let v34: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v30, v31)), v25)), v9));
    let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v36, v37))));
    method8(v39)
}
fn closure66(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: bool, mut v5: Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24> {
    Rc::new(move |mut v6: Rc<str>| -> US24 {
        let (mut v7, mut v8): (Rc<str>, Rc<str>) = fix_paths_99(v6.clone(), v5.clone(), v0.clone());
        let mut v9: bool = file_exists_41(v7.clone());
        let mut v10: bool = v9 == false;
        let mut v13: bool = if v10 {
            true
        } else {
            let mut v11: bool = file_exists_41(v8.clone());
            let mut v12: bool = v11 == false;
            v12
        };
        let mut v167: bool = if v13 {
            false
        } else {
            let mut v14: Rc<str> = normalize_path_23(v7.clone());
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
            let mut v41: usize = v39.unwrap();
            let mut v42: bool = v41 == v31 ;
            let mut v45: bool = if v42 {
                let v44: bool = true; break ();
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
            let mut v65: Rc<dyn Fn((u8)) -> Rc<str>> = closure59();
            let v66: Vec<Rc<str>> = v63.iter().map(|x| v65(x.clone())).collect::<Vec<_>>();
            let v67: Vec<Rc<str>> = method53(v66.clone());
            let mut v68: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v67));
            let mut v69: Rc<Vec<Rc<str>>> = Rc::new((v68).borrow().clone());
            let mut v70: i32 = (v69).len() as i32;
            let mut v71: i32 = v70.wrapping_sub(1i32);
            let v72: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let mut v73: Rc<UH0> = method101(v69.clone(), v71, v72.clone());
            let mut v74: Rc<str> = method102();
            let v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let (mut v76, mut v77): (Rc<str>, Rc<str>) = method103(v74.clone(), v73.clone(), v75.clone(), v75.clone());
            let mut v78: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v76);
            let mut v79: Rc<dyn Fn(std::io::Error) -> std::string::String> = method104();
            let mut v81: Result<Rc<str>, std::string::String> = v78.map_err(|x| v79(x));
            let mut v82: Rc<dyn Fn(Rc<str>) -> US25> = method105();
            let mut v83: Rc<dyn Fn(std::string::String) -> US25> = method106();
            let v84: US25 = match v81 { Ok(x) => v82(x), Err(e) => v83(e) };
            let v90: Rc<str> = match &v84 {
                US25::US25_Error(v86) => {
                    let v86: std::string::String = v86.clone();
                    let mut v87: Rc<str> = Rc::<str>::from({ struct SpiralDebug<T>(T); trait SpiralDebugShow { fn show(&self) -> String; } impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> { fn show(&self) -> String { format!("{:?}", self.0) } } trait SpiralTypeShow { fn show(&self) -> String; } impl<T> SpiralTypeShow for &SpiralDebug<T> { fn show(&self) -> String { String::from(std::any::type_name::<T>()) } } format!("resultm.get / Error x: {}", (&SpiralDebug(&v86)).show()) });
                    std::panic::panic_any::<std::string::String>(format!("{}", v87.clone()))
                }
                US25::US25_Ok(v85) => {
                    let v85: Rc<str> = v85.clone();
                    v85.clone()
                }
            };
            let v91: Rc<str> = normalize_path_23(v8.clone());
            let mut v93: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v91);
            let v95: std::fs::File = v93.unwrap();
            let mut v97: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v95);
            let mut v99: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v97);
            let v101: bool = true; let mut v99 = v99;
            let mut v103: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v105: sha2::Sha256 = result;
            let mut v107: bool = true; let mut v105 = v105;
            let mut v108: usize = ((0i32) as usize);
            let mut v110: _ = [0u8; 1024i32 as usize];
            let v112: bool = true; loop { // rust.loop 1;
            let v114: bool = true; let mut v110 = v110;
            let mut v116: Result<usize, std::io::Error> = std::io::Read::read(&mut v99, &mut v110);
            let v118: usize = v116.unwrap();
            let mut v119: bool = v118 == v108 ;
            let mut v122: bool = if v119 {
                let mut v121: bool = true; break ();
                true
            } else {
                false
            };
            let v123: usize = ((v118) as usize);
            let mut v124: usize = (v123.clone());
            let v126: usize = v110.len();
            let mut v127: bool = v124 == v126 ;
            let v132: &_ = if v127 {
                let v129: &_ = &v110[v108..];
                v129.clone()
            } else {
                let v131: &_ = &v110[v108..v123];
                v131.clone()
            };
            let v134: bool = true; sha2::Digest::update(&mut v105, v132);
            let v136: bool = true; } // rust.loop 3;
            let v138: &[u8] = &sha2::Digest::finalize(v105);
            let v140: Vec<u8> = v138.iter().map(|x| *x).collect::<Vec<_>>();
            let v142: Vec<Rc<str>> = v140.iter().map(|x| v65(x.clone())).collect::<Vec<_>>();
            let mut v143: Vec<Rc<str>> = method53(v142.clone());
            let mut v144: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v143));
            let v145: Rc<Vec<Rc<str>>> = Rc::new((v144).borrow().clone());
            let v146: i32 = (v145).len() as i32;
            let mut v147: i32 = v146.wrapping_sub(1i32);
            let mut v148: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let v149: Rc<UH0> = method101(v145.clone(), v147, v148.clone());
            let mut v150: Rc<str> = method102();
            let (mut v151, mut v152): (Rc<str>, Rc<str>) = method103(v150.clone(), v149.clone(), v75.clone(), v75.clone());
            let mut v153: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v151);
            let mut v154: Rc<dyn Fn(std::io::Error) -> std::string::String> = method104();
            let mut v156: Result<Rc<str>, std::string::String> = v153.map_err(|x| v154(x));
            let mut v157: Rc<dyn Fn(Rc<str>) -> US25> = method105();
            let mut v158: Rc<dyn Fn(std::string::String) -> US25> = method106();
            let v159: US25 = match v156 { Ok(x) => v157(x), Err(e) => v158(e) };
            let v165: Rc<str> = match &v159 {
                US25::US25_Error(v161) => {
                    let v161: std::string::String = v161.clone();
                    let v162: Rc<str> = Rc::<str>::from({ struct SpiralDebug<T>(T); trait SpiralDebugShow { fn show(&self) -> String; } impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> { fn show(&self) -> String { format!("{:?}", self.0) } } trait SpiralTypeShow { fn show(&self) -> String; } impl<T> SpiralTypeShow for &SpiralDebug<T> { fn show(&self) -> String { String::from(std::any::type_name::<T>()) } } format!("resultm.get / Error x: {}", (&SpiralDebug(&v161)).show()) });
                    std::panic::panic_any::<std::string::String>(format!("{}", v162.clone()))
                }
                US25::US25_Ok(v160) => {
                    let mut v160: Rc<str> = v160.clone();
                    v160.clone()
                }
            };
            let v166: bool = &*v90 == &*v165;
            v166
        };
        if v167 {
            US24::US24_None
        } else {
            let v169: US27 = hangul_114(v2.clone(), v3.clone(), v4, v7.clone(), v5.clone());
            match &v169 {
                US27::US27_Error(v255, v256) => {
                    let mut v255: i32 = *v255;
                    let v256: Rc<str> = v256.clone();
                    let (mut v257, mut v258): (Rc<str>, Rc<str>) = method120(v7.clone(), v256.clone());
                    let mut v259: (Rc<str>, Rc<str>) = (v257, v258);
                    let mut v260: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v259);
                    US24::US24_Some(v260.clone())
                }
                US27::US27_Ok(v170, v171) => {
                    let v170: i32 = *v170;
                    let v171: Rc<str> = v171.clone();
                    let mut v172: bool = v170 != 0i32 ;
                    if v172 {
                        let v174: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v174); };
                        let mut v176: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v177, mut v178, mut v179, mut v180, mut v181, mut v182): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v176) };
                        let v183: US0 = v181.borrow().l0.clone();
                        let v188: i32 = match &v183 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v189: bool = v179.borrow().l0.clone();
                        let v190: bool = v189 == false;
                        let v192: bool = if v190 {
                            false
                        } else {
                            let mut v191: bool = 30i32 >= v188;
                            v191
                        };
                        let v193: bool = v192 == false;
                        let v241: US2 = if v193 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v174); };
                            let (mut v197, mut v198, mut v199, mut v200, mut v201, mut v202): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v176) };
                            let v203: Rc<str> = method3(v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone(), v202.clone());
                            let v204: Rc<str> = method4();
                            let v205: Rc<str> = method121(v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone(), v202.clone(), v203.clone(), v204.clone(), v170, v171.clone());
                            { let _ = spiral_trace_hold(&v174); };
                            let (mut v208, mut v209, mut v210, mut v211, mut v212, mut v213): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v176) };
                            let v214: i64 = v208.borrow().l0.clone();
                            let v215: i64 = v214.wrapping_add(1i64);
                            v208.borrow_mut().l0 = v215;
                            let mut v216: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v217: bool = cfg!(target_arch = "wasm32");
                            if v217 {
                                let mut v218: Rc<str> = v211.borrow().l0.clone();
                                let v219: bool = &*v218 == "";
                                let v227: Rc<str> = if v219 {
                                    v205.clone()
                                } else {
                                    let v220: bool = &*v205 == "";
                                    if v220 {
                                        let mut v221: Rc<str> = v211.borrow().l0.clone();
                                        v221.clone()
                                    } else {
                                        let mut v222: Rc<str> = v211.borrow().l0.clone();
                                        let v223: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v225: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v222, v223)), v205));
                                        v225.clone()
                                    }
                                };
                                let v229: usize = v227.chars().count();
                                let v230: i32 = ((v229) as i32);
                                let v231: i32 = v230.wrapping_add(14999i32);
                                let v232: i32 = v231.wrapping_div(15000i32);
                                let v233: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v234: bool = v205 != v233 ;
                                let v236: bool = if v234 {
                                    let v235: bool = v232 <= 1i32;
                                    v235
                                } else {
                                    false
                                };
                                if v236 {
                                    v211.borrow_mut().l0 = v227.clone();
                                    ()
                                } else {
                                    v211.borrow_mut().l0 = v233.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v227); };
                                    ()
                                }
                            } else {
                                println!("{}", v205);
                                ()
                            };
                            let mut v239: Rc<dyn Fn(Rc<str>) -> ()> = v209.borrow().l0.clone();
                            v239(v205.clone());
                            US2::US2_Some(v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone(), v213.clone())
                        };
                        let (mut v242, mut v243): (Rc<str>, Rc<str>) = method120(v7.clone(), v171.clone());
                        let mut v244: (Rc<str>, Rc<str>) = (v242, v243);
                        let v245: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v244);
                        US24::US24_Some(v245.clone())
                    } else {
                        let v247: bool = file_exists_41(v7.clone());
                        if v247 {
                            file_copy_108(v8.clone(), v7.clone())
                        } else {
                            let v248: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.files_fn / "); } LIT.with(|lit| lit.clone()) };
                            let mut v249: Rc<str> = Rc::<str>::from(format!("{}{}", v248, v7));
                            let v250: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" should exist"); } LIT.with(|lit| lit.clone()) };
                            let v251: Rc<str> = Rc::<str>::from(format!("{}{}", v249, v250));
                            std::panic::panic_any::<std::string::String>(format!("{}", v251.clone()))
                        };
                        let v252: Result<Rc<str>, (Rc<str>, Rc<str>)> = Ok::<Rc<str>, (Rc<str>, Rc<str>)>(v7);
                        US24::US24_Some(v252.clone())
                    }
                }
            }
        }
    })
}
fn closure65(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: bool) -> Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> {
    Rc::new(move |mut v5: Rc<str>| -> Rc<dyn Fn(Rc<str>) -> US24> {
        closure66(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4, v5.clone())
    })
}
fn method123(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
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
    let mut v28: Rc<str> = format_real_60(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26)), v9)), v30));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v26)), v10));
    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method8(v45)
}
fn method124(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = format_real_11(v11);
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
    let mut v28: Rc<str> = format_real_60(v8);
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let v36: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v31, v32)), v26)), v9)), v30));
    let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v36, v37)), v26)), v10));
    let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v40));
    let v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v21, Rc::<str>::from(format!("{}{}", v42, v43))));
    method8(v45)
}
fn crowbook_122(mut v0: bool, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>) -> US27 {
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
                let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\setmainfont{NanumGothicCoding}\""); } LIT.with(|lit| lit.clone()) };
                let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\""); } LIT.with(|lit| lit.clone()) };
                let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.font.size 13"); } LIT.with(|lit| lit.clone()) };
                let v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13"); } LIT.with(|lit| lit.clone()) };
                v37
            };
            let v39: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v38));
            let v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6"); } LIT.with(|lit| lit.clone()) };
            let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
            let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v39, Rc::<str>::from(format!("{}{}", v40, v41))));
            v43
        } else {
            let v44: bool = "epub" == &*v4;
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
    let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("crowbook --verbose --to "); } LIT.with(|lit| lit.clone()) };
    let mut v70: Rc<str> = Rc::<str>::from(format!("{}{}", v69, v4));
    let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" --single \""); } LIT.with(|lit| lit.clone()) };
    let mut v73: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v70, v71)), v2));
    let mut v74: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\" --output \""); } LIT.with(|lit| lit.clone()) };
    let mut v76: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v73, v74)), v1));
    let mut v77: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\" "); } LIT.with(|lit| lit.clone()) };
    let mut v79: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v76, v77)), v63));
    let mut v80: Option<Rc<str>> = Some(v3.clone());
    let mut v81: bool = true;
    let mut v82: bool = true;
    let (mut v83, mut v84): (i32, Rc<str>) = execute_with_options_57(v79, v64, v65, v66, v67, v81, v80, v82);
    let v85: bool = v83 == 0i32;
    let (mut v177, mut v178): (i32, Rc<str>) = if v85 {
        (v83, v84.clone())
    } else {
        let mut v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        { let _ = spiral_trace_hold(&v87); };
        let v89: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v90, mut v91, mut v92, mut v93, mut v94, mut v95): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v89) };
        let v96: US0 = v94.borrow().l0.clone();
        let v101: i32 = match &v96 {
            US0::US0_Critical => {
                50i32
            }
            US0::US0_Debug => {
                20i32
            }
            US0::US0_Info => {
                30i32
            }
            US0::US0_Verbose => {
                10i32
            }
            US0::US0_Warning => {
                40i32
            }
        };
        let mut v102: bool = v92.borrow().l0.clone();
        let mut v103: bool = v102 == false;
        let mut v105: bool = if v103 {
            false
        } else {
            let v104: bool = 40i32 >= v101;
            v104
        };
        let mut v106: bool = v105 == false;
        let mut v154: US2 = if v106 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v87); };
            let (mut v110, mut v111, mut v112, mut v113, mut v114, mut v115): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v89) };
            let mut v116: Rc<str> = method3(v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone());
            let v117: Rc<str> = method42();
            let v118: Rc<str> = method123(v110, v111, v112, v113, v114, v115, v116, v117, v83, v1.clone(), v84);
            { let _ = spiral_trace_hold(&v87); };
            let (mut v121, mut v122, mut v123, mut v124, mut v125, mut v126): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v89) };
            let mut v127: i64 = v121.borrow().l0.clone();
            let v128: i64 = v127.wrapping_add(1i64);
            v121.borrow_mut().l0 = v128;
            let v129: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
            let mut v130: bool = cfg!(target_arch = "wasm32");
            if v130 {
                let v131: Rc<str> = v124.borrow().l0.clone();
                let v132: bool = &*v131 == "";
                let v140: Rc<str> = if v132 {
                    v118.clone()
                } else {
                    let mut v133: bool = &*v118 == "";
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
                let mut v143: i32 = ((v142) as i32);
                let mut v144: i32 = v143.wrapping_add(14999i32);
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
            US2::US2_Some(v121, v122, v123, v124, v125, v126)
        };
        let mut v155: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
        let mut v156: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
        let mut v157: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
        let mut v158: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
        let v159: Option<Rc<str>> = None;
        let v164: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v69, v4)), v71)), v2)), v74)), v1));
        let v165: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\""); } LIT.with(|lit| lit.clone()) };
        let v166: Rc<str> = Rc::<str>::from(format!("{}{}", v164, v165));
        let mut v167: bool = &*v4 == "pdf";
        let v170: Rc<str> = if v167 {
            let v168: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" --set tex.command tectonic"); } LIT.with(|lit| lit.clone()) };
            v168
        } else {
            let v169: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v169
        };
        let v171: Rc<str> = Rc::<str>::from(format!("{}{}", v166, v170));
        let mut v172: Option<Rc<str>> = Some(v3);
        let mut v173: bool = true;
        let v174: bool = true;
        execute_with_options_57(v171, v155, v156, v157, v158, v173, v172, v174)
    };
    let v179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("ERROR"); } LIT.with(|lit| lit.clone()) };
    let v180: bool = v178.contains(&*v179);
    let v181: bool = v180 == false;
    if v181 {
        US27::US27_Ok(v177, v178.clone())
    } else {
        let v184: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
        { let _ = spiral_trace_hold(&v184); };
        let v186: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
        let (mut v187, mut v188, mut v189, mut v190, mut v191, mut v192): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v186) };
        let v193: US0 = v191.borrow().l0.clone();
        let v198: i32 = match &v193 {
            US0::US0_Critical => {
                50i32
            }
            US0::US0_Debug => {
                20i32
            }
            US0::US0_Info => {
                30i32
            }
            US0::US0_Verbose => {
                10i32
            }
            US0::US0_Warning => {
                40i32
            }
        };
        let v199: bool = v189.borrow().l0.clone();
        let v200: bool = v199 == false;
        let v202: bool = if v200 {
            false
        } else {
            let mut v201: bool = 40i32 >= v198;
            v201
        };
        let v203: bool = v202 == false;
        let v251: US2 = if v203 {
            US2::US2_None
        } else {
            { let _ = spiral_trace_hold(&v184); };
            let (mut v207, mut v208, mut v209, mut v210, mut v211, mut v212): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v186) };
            let mut v213: Rc<str> = method3(v207.clone(), v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone());
            let v214: Rc<str> = method42();
            let v215: Rc<str> = method124(v207, v208, v209, v210, v211, v212, v213, v214, v177, v1, v178.clone());
            { let _ = spiral_trace_hold(&v184); };
            let (mut v218, mut v219, mut v220, mut v221, mut v222, mut v223): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v186) };
            let v224: i64 = v218.borrow().l0.clone();
            let mut v225: i64 = v224.wrapping_add(1i64);
            v218.borrow_mut().l0 = v225;
            let mut v226: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
            let v227: bool = cfg!(target_arch = "wasm32");
            if v227 {
                let mut v228: Rc<str> = v221.borrow().l0.clone();
                let v229: bool = &*v228 == "";
                let mut v237: Rc<str> = if v229 {
                    v215.clone()
                } else {
                    let v230: bool = &*v215 == "";
                    if v230 {
                        let v231: Rc<str> = v221.borrow().l0.clone();
                        v231
                    } else {
                        let v232: Rc<str> = v221.borrow().l0.clone();
                        let v233: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let v235: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v232, v233)), v215));
                        v235
                    }
                };
                let mut v239: usize = v237.chars().count();
                let v240: i32 = ((v239) as i32);
                let v241: i32 = v240.wrapping_add(14999i32);
                let v242: i32 = v241.wrapping_div(15000i32);
                let v243: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v244: bool = v215 != v243 ;
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
            US2::US2_Some(v218, v219, v220, v221, v222, v223)
        };
        US27::US27_Error(v177, v178)
    }
}
fn closure69(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24> {
    Rc::new(move |mut v4: Rc<str>| -> US24 {
        let (mut v5, mut v6): (Rc<str>, Rc<str>) = fix_paths_99(v4.clone(), v3.clone(), v0.clone());
        let mut v7: bool = file_exists_41(v5.clone());
        let mut v8: bool = v7 == false;
        let mut v11: bool = if v8 {
            true
        } else {
            let mut v9: bool = file_exists_41(v6.clone());
            let mut v10: bool = v9 == false;
            v10
        };
        let v165: bool = if v11 {
            false
        } else {
            let mut v12: Rc<str> = normalize_path_23(v5.clone());
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
                let mut v42: bool = true; break ();
                true
            } else {
                false
            };
            let v44: usize = ((v39) as usize);
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
            let mut v63: Rc<dyn Fn((u8)) -> Rc<str>> = closure59();
            let v64: Vec<Rc<str>> = v61.iter().map(|x| v63(x.clone())).collect::<Vec<_>>();
            let mut v65: Vec<Rc<str>> = method53(v64.clone());
            let v66: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v65));
            let v67: Rc<Vec<Rc<str>>> = Rc::new((v66).borrow().clone());
            let mut v68: i32 = (v67).len() as i32;
            let mut v69: i32 = v68.wrapping_sub(1i32);
            let mut v70: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let mut v71: Rc<UH0> = method101(v67.clone(), v69, v70.clone());
            let v72: Rc<str> = method102();
            let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let (mut v74, mut v75): (Rc<str>, Rc<str>) = method103(v72.clone(), v71.clone(), v73.clone(), v73.clone());
            let mut v76: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v74);
            let mut v77: Rc<dyn Fn(std::io::Error) -> std::string::String> = method104();
            let mut v79: Result<Rc<str>, std::string::String> = v76.map_err(|x| v77(x));
            let mut v80: Rc<dyn Fn(Rc<str>) -> US25> = method105();
            let mut v81: Rc<dyn Fn(std::string::String) -> US25> = method106();
            let mut v82: US25 = match v79 { Ok(x) => v80(x), Err(e) => v81(e) };
            let v88: Rc<str> = match &v82 {
                US25::US25_Error(v84) => {
                    let v84: std::string::String = v84.clone();
                    let v85: Rc<str> = Rc::<str>::from({ struct SpiralDebug<T>(T); trait SpiralDebugShow { fn show(&self) -> String; } impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> { fn show(&self) -> String { format!("{:?}", self.0) } } trait SpiralTypeShow { fn show(&self) -> String; } impl<T> SpiralTypeShow for &SpiralDebug<T> { fn show(&self) -> String { String::from(std::any::type_name::<T>()) } } format!("resultm.get / Error x: {}", (&SpiralDebug(&v84)).show()) });
                    std::panic::panic_any::<std::string::String>(format!("{}", v85.clone()))
                }
                US25::US25_Ok(v83) => {
                    let mut v83: Rc<str> = v83.clone();
                    v83.clone()
                }
            };
            let v89: Rc<str> = normalize_path_23(v6.clone());
            let v91: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v89);
            let mut v93: std::fs::File = v91.unwrap();
            let v95: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v93);
            let mut v97: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v95);
            let mut v99: bool = true; let mut v97 = v97;
            let v101: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v103: sha2::Sha256 = result;
            let mut v105: bool = true; let mut v103 = v103;
            let mut v106: usize = ((0i32) as usize);
            let mut v108: _ = [0u8; 1024i32 as usize];
            let mut v110: bool = true; loop { // rust.loop 1;
            let v112: bool = true; let mut v108 = v108;
            let v114: Result<usize, std::io::Error> = std::io::Read::read(&mut v97, &mut v108);
            let mut v116: usize = v114.unwrap();
            let v117: bool = v116 == v106 ;
            let v120: bool = if v117 {
                let mut v119: bool = true; break ();
                true
            } else {
                false
            };
            let mut v121: usize = ((v116) as usize);
            let mut v122: usize = (v121.clone());
            let mut v124: usize = v108.len();
            let v125: bool = v122 == v124 ;
            let mut v130: &_ = if v125 {
                let mut v127: &_ = &v108[v106..];
                v127.clone()
            } else {
                let v129: &_ = &v108[v106..v121];
                v129.clone()
            };
            let v132: bool = true; sha2::Digest::update(&mut v103, v130);
            let v134: bool = true; } // rust.loop 3;
            let v136: &[u8] = &sha2::Digest::finalize(v103);
            let v138: Vec<u8> = v136.iter().map(|x| *x).collect::<Vec<_>>();
            let v140: Vec<Rc<str>> = v138.iter().map(|x| v63(x.clone())).collect::<Vec<_>>();
            let v141: Vec<Rc<str>> = method53(v140.clone());
            let v142: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v141));
            let mut v143: Rc<Vec<Rc<str>>> = Rc::new((v142).borrow().clone());
            let mut v144: i32 = (v143).len() as i32;
            let v145: i32 = v144.wrapping_sub(1i32);
            let v146: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
            let mut v147: Rc<UH0> = method101(v143.clone(), v145, v146.clone());
            let mut v148: Rc<str> = method102();
            let (mut v149, mut v150): (Rc<str>, Rc<str>) = method103(v148.clone(), v147.clone(), v73.clone(), v73.clone());
            let mut v151: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v149);
            let mut v152: Rc<dyn Fn(std::io::Error) -> std::string::String> = method104();
            let mut v154: Result<Rc<str>, std::string::String> = v151.map_err(|x| v152(x));
            let mut v155: Rc<dyn Fn(Rc<str>) -> US25> = method105();
            let mut v156: Rc<dyn Fn(std::string::String) -> US25> = method106();
            let mut v157: US25 = match v154 { Ok(x) => v155(x), Err(e) => v156(e) };
            let mut v163: Rc<str> = match &v157 {
                US25::US25_Error(v159) => {
                    let v159: std::string::String = v159.clone();
                    let mut v160: Rc<str> = Rc::<str>::from({ struct SpiralDebug<T>(T); trait SpiralDebugShow { fn show(&self) -> String; } impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> { fn show(&self) -> String { format!("{:?}", self.0) } } trait SpiralTypeShow { fn show(&self) -> String; } impl<T> SpiralTypeShow for &SpiralDebug<T> { fn show(&self) -> String { String::from(std::any::type_name::<T>()) } } format!("resultm.get / Error x: {}", (&SpiralDebug(&v159)).show()) });
                    std::panic::panic_any::<std::string::String>(format!("{}", v160.clone()))
                }
                US25::US25_Ok(v158) => {
                    let mut v158: Rc<str> = v158.clone();
                    v158.clone()
                }
            };
            let v164: bool = &*v88 == &*v163;
            v164
        };
        if v165 {
            US24::US24_None
        } else {
            let mut v167: US27 = crowbook_122(v2, v5.clone(), v3.clone(), v1.clone(), v4.clone());
            match &v167 {
                US27::US27_Error(v253, v254) => {
                    let v253: i32 = *v253;
                    let v254: Rc<str> = v254.clone();
                    let (mut v255, mut v256): (Rc<str>, Rc<str>) = method120(v5.clone(), v254.clone());
                    let v257: (Rc<str>, Rc<str>) = (v255, v256);
                    let v258: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v257);
                    US24::US24_Some(v258.clone())
                }
                US27::US27_Ok(v168, v169) => {
                    let v168: i32 = *v168;
                    let v169: Rc<str> = v169.clone();
                    let v170: bool = v168 != 0i32 ;
                    if v170 {
                        let mut v172: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v172); };
                        let v174: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v175, mut v176, mut v177, mut v178, mut v179, mut v180): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v174) };
                        let v181: US0 = v179.borrow().l0.clone();
                        let v186: i32 = match &v181 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let mut v187: bool = v177.borrow().l0.clone();
                        let v188: bool = v187 == false;
                        let v190: bool = if v188 {
                            false
                        } else {
                            let v189: bool = 30i32 >= v186;
                            v189
                        };
                        let mut v191: bool = v190 == false;
                        let mut v239: US2 = if v191 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v172); };
                            let (mut v195, mut v196, mut v197, mut v198, mut v199, mut v200): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v174) };
                            let mut v201: Rc<str> = method3(v195.clone(), v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone());
                            let v202: Rc<str> = method4();
                            let v203: Rc<str> = method121(v195.clone(), v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone(), v202.clone(), v168, v169.clone());
                            { let _ = spiral_trace_hold(&v172); };
                            let (mut v206, mut v207, mut v208, mut v209, mut v210, mut v211): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v174) };
                            let v212: i64 = v206.borrow().l0.clone();
                            let mut v213: i64 = v212.wrapping_add(1i64);
                            v206.borrow_mut().l0 = v213;
                            let v214: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v215: bool = cfg!(target_arch = "wasm32");
                            if v215 {
                                let mut v216: Rc<str> = v209.borrow().l0.clone();
                                let v217: bool = &*v216 == "";
                                let mut v225: Rc<str> = if v217 {
                                    v203.clone()
                                } else {
                                    let mut v218: bool = &*v203 == "";
                                    if v218 {
                                        let v219: Rc<str> = v209.borrow().l0.clone();
                                        v219.clone()
                                    } else {
                                        let v220: Rc<str> = v209.borrow().l0.clone();
                                        let mut v221: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v223: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v220, v221)), v203));
                                        v223.clone()
                                    }
                                };
                                let v227: usize = v225.chars().count();
                                let mut v228: i32 = ((v227) as i32);
                                let v229: i32 = v228.wrapping_add(14999i32);
                                let v230: i32 = v229.wrapping_div(15000i32);
                                let v231: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v232: bool = v203 != v231 ;
                                let v234: bool = if v232 {
                                    let v233: bool = v230 <= 1i32;
                                    v233
                                } else {
                                    false
                                };
                                if v234 {
                                    v209.borrow_mut().l0 = v225.clone();
                                    ()
                                } else {
                                    v209.borrow_mut().l0 = v231.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v225); };
                                    ()
                                }
                            } else {
                                println!("{}", v203);
                                ()
                            };
                            let mut v237: Rc<dyn Fn(Rc<str>) -> ()> = v207.borrow().l0.clone();
                            v237(v203.clone());
                            US2::US2_Some(v206.clone(), v207.clone(), v208.clone(), v209.clone(), v210.clone(), v211.clone())
                        };
                        let (mut v240, mut v241): (Rc<str>, Rc<str>) = method120(v5.clone(), v169.clone());
                        let v242: (Rc<str>, Rc<str>) = (v240, v241);
                        let v243: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v242);
                        US24::US24_Some(v243.clone())
                    } else {
                        let v245: bool = file_exists_41(v5.clone());
                        if v245 {
                            file_copy_108(v6.clone(), v5.clone())
                        } else {
                            let v246: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.files_fn / "); } LIT.with(|lit| lit.clone()) };
                            let v247: Rc<str> = Rc::<str>::from(format!("{}{}", v246, v5));
                            let v248: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" should exist"); } LIT.with(|lit| lit.clone()) };
                            let mut v249: Rc<str> = Rc::<str>::from(format!("{}{}", v247, v248));
                            std::panic::panic_any::<std::string::String>(format!("{}", v249.clone()))
                        };
                        let v250: Result<Rc<str>, (Rc<str>, Rc<str>)> = Ok::<Rc<str>, (Rc<str>, Rc<str>)>(v5);
                        US24::US24_Some(v250.clone())
                    }
                }
            }
        }
    })
}
fn closure68(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool) -> Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> {
    Rc::new(move |mut v3: Rc<str>| -> Rc<dyn Fn(Rc<str>) -> US24> {
        closure69(v0.clone(), v1.clone(), v2, v3.clone())
    })
}
fn method125(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = format_real_11(v10);
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
    let v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v33));
    let v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v20, Rc::<str>::from(format!("{}{}", v35, v36))));
    method8(v38)
}
fn method126(mut v0: Rc<RefCell<Vec<Rc<UH2>>>>, mut v1: Rc<UH1>, mut v2: i32) -> i32 {
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
fn method127(mut v0: Vec<Rc<UH2>>) -> Vec<Rc<UH2>> {
    v0
}
fn method128(mut v0: Rc<Vec<Rc<UH2>>>, mut v1: i32, mut v2: Rc<UH1>) -> Rc<UH1> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: Rc<UH2> = (v0)[v1 as usize].clone();
            let mut v5: i32 = v1.wrapping_sub(1i32);
            let mut v6: Rc<UH1> = Rc::new(UH1::UH1_Cons(v4.clone(), v2.clone()));
            (v0, v1, v2) = (v0.clone(), v5, v6.clone());
            continue;
        }
    }
}
fn method130(mut v0: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>>, mut v1: Rc<UH2>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH2::UH2_Cons(v3, v4, v5, v6) => {
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<str> = v4.clone();
                let mut v5: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = v5.clone();
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
fn method131(mut v0: Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>) -> Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)> {
    v0
}
fn method133(mut v0: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>) -> Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> {
    v0
}
fn method134(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0
}
fn loop_132(mut v0: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>>, mut v1: i32, mut v2: i32, mut v3: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    loop {
        let mut v4: bool = v2 < v1;
        if v4 {
            let mut v5: i32 = v2.wrapping_add(1i32);
            let (mut v6, mut v7, mut v8): (Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>) = v0.clone().borrow()[v2 as usize].clone();
            let mut v9: Rc<dyn Fn(Rc<str>) -> US24> = v8(v7.clone());
            let mut v10: US24 = v9(v6.clone());
            let v15: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = match &v10 {
                US24::US24_None => {
                    let mut v13: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = None;
                    v13.clone()
                }
                US24::US24_Some(v11) => {
                    let mut v11: Result<Rc<str>, (Rc<str>, Rc<str>)> = v11.clone();
                    let mut v12: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = Some(v11.clone());
                    v12.clone()
                }
            };
            let mut v16: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = method133(v15.clone());
            let mut v17: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method134(v3.clone());
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
fn method135(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0
}
fn method136(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0
}
fn method137(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0
}
fn method129(mut v0: Rc<UH1>, mut v1: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    loop {
        match &*v0 {
            UH1::UH1_Cons(v2, v3) => {
                let mut v2: Rc<UH2> = v2.clone();
                let mut v3: Rc<UH1> = v3.clone();
                let mut v4: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>> = Rc::new(RefCell::new(Vec::new()));
                let mut v5: i32 = 0i32;
                let mut v6: i32 = method130(v4.clone(), v2.clone(), v5);
                let mut v7: Rc<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>> = Rc::new(v4.borrow().clone());
                let mut v8: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>> = Rc::new(RefCell::new((v7).as_ref().clone()));
                let mut v9: Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)> = (v8).borrow().clone();
                let mut v10: Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)> = method131(v9.clone());
                let mut v11: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>> = Rc::new(RefCell::new(v10));
                let mut v12: i32 = (v11.borrow().len() as i32);
                let mut v13: i32 = 0i32;
                let mut v14: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = Vec::new();
                let v15: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = loop_132(v11.clone(), v12, v13, v14.clone());
                let mut v16: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method135(v15.clone());
                let mut v17: Rc<RefCell<Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>>> = Rc::new(RefCell::new(v16));
                let v18: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = (v17).borrow().clone();
                let v19: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method136(v18.clone());
                let mut v20: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method137(v1.clone());
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
fn method138(mut v0: Rc<str>, mut v1: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) {
    (v0, v1)
}
fn method139(mut v0: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>) -> Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> {
    v0
}
fn method140(mut v0: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> {
    v0
}
fn loop_54(mut v0: bool, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>, mut v5: Rc<str>, mut v6: Rc<RefCell<Vec<Rc<str>>>>, mut v7: i32, mut v8: i32, mut v9: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> {
    loop {
        let mut v10: bool = v8 < v7;
        if v10 {
            let mut v11: i32 = v8.wrapping_add(1i32);
            let mut v12: Rc<str> = v6.clone().borrow()[v8 as usize].clone();
            let mut v13: Rc<str> = get_full_path_44(v12.clone());
            let v15: &str = &*v13;
            let mut v17: std::string::String = String::from(v15);
            let v19: std::path::PathBuf = std::path::PathBuf::from(v17);
            let mut v20: std::path::PathBuf = method30(v19.clone());
            let mut v22: std::path::Display = v20.display();
            let v24: std::string::String = format!("{}", v22);
            let mut v26: Rc<str> = Rc::<str>::from(String::as_str(&v24));
            let mut v27: Rc<str> = method55();
            let mut v28: Rc<str> = Rc::<str>::from(v26.replace(&*v4, &*v27));
            let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let mut v31: Rc<str> = Rc::<str>::from(v28.replace(&*v29, &*v30));
            let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
            let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v31));
            let v34: Rc<str> = normalize_path_23(v13.clone());
            let mut v35: Rc<str> = method34(v3.clone(), v33.clone());
            let v36: Rc<str> = standardize_path_56(v35.clone());
            let v37: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
            let mut v38: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
            let v39: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
            let v40: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
            let mut v41: Option<Rc<str>> = None;
            let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("git ls-tree --format='%(objectname)' origin/gh-pages \""); } LIT.with(|lit| lit.clone()) };
            let v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v36));
            let v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\""); } LIT.with(|lit| lit.clone()) };
            let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v44));
            let mut v46: Option<Rc<str>> = Some(v3.clone());
            let mut v47: bool = true;
            let mut v48: bool = true;
            let (mut v49, mut v50): (i32, Rc<str>) = execute_with_options_57(v45.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v47, v46.clone(), v48);
            let v51: Rc<str> = method34(v4.clone(), v33.clone());
            let mut v52: Rc<str> = standardize_path_56(v51.clone());
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
            let (mut v64, mut v65): (i32, Rc<str>) = execute_with_options_57(v60.clone(), v53.clone(), v54.clone(), v55.clone(), v56.clone(), v62, v61.clone(), v63);
            let v66: Rc<str> = method34(v5.clone(), v33.clone());
            let v67: Rc<str> = standardize_path_56(v66.clone());
            let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul.md"); } LIT.with(|lit| lit.clone()) };
            let (mut v69, mut v70): (Rc<str>, Rc<str>) = fix_paths_99(v68.clone(), v52.clone(), v5.clone());
            let mut v71: bool = false;
            let v72: bool = false;
            let mut v73: bool = false;
            let mut v74: bool = true;
            let v75: bool = true;
            let mut v76: bool = true;
            let mut v77: bool = v50.contains(&*v65);
            let v434: Rc<UH1> = if v77 {
                { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) }
            } else {
                let mut v79: Rc<str> = normalize_path_23(v52.clone());
                let mut v81: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v79);
                let mut v83: std::fs::File = v81.unwrap();
                let v85: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v83);
                let mut v87: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v85);
                let v89: bool = true; let mut v87 = v87;
                let v91: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
                let mut v93: sha2::Sha256 = result;
                let v95: bool = true; let mut v93 = v93;
                let v96: usize = ((0i32) as usize);
                let mut v98: _ = [0u8; 1024i32 as usize];
                let v100: bool = true; loop { // rust.loop 1;
                let mut v102: bool = true; let mut v98 = v98;
                let v104: Result<usize, std::io::Error> = std::io::Read::read(&mut v87, &mut v98);
                let mut v106: usize = v104.unwrap();
                let mut v107: bool = v106 == v96 ;
                let mut v110: bool = if v107 {
                    let v109: bool = true; break ();
                    true
                } else {
                    false
                };
                let v111: usize = ((v106) as usize);
                let v112: usize = (v111.clone());
                let v114: usize = v98.len();
                let v115: bool = v112 == v114 ;
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
                let mut v130: Rc<dyn Fn((u8)) -> Rc<str>> = closure59();
                let v131: Vec<Rc<str>> = v128.iter().map(|x| v130(x.clone())).collect::<Vec<_>>();
                let v132: Vec<Rc<str>> = method53(v131.clone());
                let mut v133: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v132));
                let v134: Rc<Vec<Rc<str>>> = Rc::new((v133).borrow().clone());
                let v135: i32 = (v134).len() as i32;
                let v136: i32 = v135.wrapping_sub(1i32);
                let v137: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                let v138: Rc<UH0> = method101(v134.clone(), v136, v137.clone());
                let v139: Rc<str> = method102();
                let v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let (mut v141, mut v142): (Rc<str>, Rc<str>) = method103(v139.clone(), v138.clone(), v140.clone(), v140.clone());
                let mut v143: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v141);
                let mut v144: Rc<dyn Fn(std::io::Error) -> std::string::String> = method104();
                let v146: Result<Rc<str>, std::string::String> = v143.map_err(|x| v144(x));
                let mut v147: Rc<dyn Fn(Rc<str>) -> US25> = method105();
                let mut v148: Rc<dyn Fn(std::string::String) -> US25> = method106();
                let v149: US25 = match v146 { Ok(x) => v147(x), Err(e) => v148(e) };
                let mut v155: Rc<str> = match &v149 {
                    US25::US25_Error(v151) => {
                        let mut v151: std::string::String = v151.clone();
                        let mut v152: Rc<str> = Rc::<str>::from({ struct SpiralDebug<T>(T); trait SpiralDebugShow { fn show(&self) -> String; } impl<T: std::fmt::Debug> SpiralDebugShow for SpiralDebug<T> { fn show(&self) -> String { format!("{:?}", self.0) } } trait SpiralTypeShow { fn show(&self) -> String; } impl<T> SpiralTypeShow for &SpiralDebug<T> { fn show(&self) -> String { String::from(std::any::type_name::<T>()) } } format!("resultm.get / Error x: {}", (&SpiralDebug(&v151)).show()) });
                        std::panic::panic_any::<std::string::String>(format!("{}", v152.clone()))
                    }
                    US25::US25_Ok(v150) => {
                        let mut v150: Rc<str> = v150.clone();
                        v150.clone()
                    }
                };
                let mut v156: bool = file_exists_41(v67.clone());
                let mut v157: bool = v156 == false;
                let v234: US4 = if v157 {
                    US4::US4_None
                } else {
                    let v159: Rc<str> = normalize_path_23(v67.clone());
                    let v161: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v159);
                    let mut v163: std::fs::File = v161.unwrap();
                    let v165: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v163);
                    let mut v167: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v165);
                    let v169: bool = true; let mut v167 = v167;
                    let v171: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
                    let mut v173: sha2::Sha256 = result;
                    let mut v175: bool = true; let mut v173 = v173;
                    let mut v176: usize = ((0i32) as usize);
                    let mut v178: _ = [0u8; 1024i32 as usize];
                    let v180: bool = true; loop { // rust.loop 1;
                    let v182: bool = true; let mut v178 = v178;
                    let v184: Result<usize, std::io::Error> = std::io::Read::read(&mut v167, &mut v178);
                    let v186: usize = v184.unwrap();
                    let mut v187: bool = v186 == v176 ;
                    let v190: bool = if v187 {
                        let v189: bool = true; break ();
                        true
                    } else {
                        false
                    };
                    let mut v191: usize = ((v186) as usize);
                    let v192: usize = (v191.clone());
                    let v194: usize = v178.len();
                    let v195: bool = v192 == v194 ;
                    let v200: &_ = if v195 {
                        let v197: &_ = &v178[v176..];
                        v197.clone()
                    } else {
                        let v199: &_ = &v178[v176..v191];
                        v199.clone()
                    };
                    let v202: bool = true; sha2::Digest::update(&mut v173, v200);
                    let v204: bool = true; } // rust.loop 3;
                    let mut v206: &[u8] = &sha2::Digest::finalize(v173);
                    let mut v208: Vec<u8> = v206.iter().map(|x| *x).collect::<Vec<_>>();
                    let v210: Vec<Rc<str>> = v208.iter().map(|x| v130(x.clone())).collect::<Vec<_>>();
                    let mut v211: Vec<Rc<str>> = method53(v210.clone());
                    let v212: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v211));
                    let mut v213: Rc<Vec<Rc<str>>> = Rc::new((v212).borrow().clone());
                    let v214: i32 = (v213).len() as i32;
                    let v215: i32 = v214.wrapping_sub(1i32);
                    let mut v216: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
                    let v217: Rc<UH0> = method101(v213.clone(), v215, v216.clone());
                    let mut v218: Rc<str> = method102();
                    let (mut v219, mut v220): (Rc<str>, Rc<str>) = method103(v218.clone(), v217.clone(), v140.clone(), v140.clone());
                    let mut v221: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v219);
                    let mut v222: Rc<dyn Fn(std::io::Error) -> std::string::String> = method104();
                    let v224: Result<Rc<str>, std::string::String> = v221.map_err(|x| v222(x));
                    let mut v225: Rc<dyn Fn(Rc<str>) -> US25> = method105();
                    let mut v226: Rc<dyn Fn(std::string::String) -> US25> = method106();
                    let v227: US25 = match v224 { Ok(x) => v225(x), Err(e) => v226(e) };
                    match &v227 {
                        US25::US25_Error(v230) => {
                            let v230: std::string::String = v230.clone();
                            US4::US4_None
                        }
                        US25::US25_Ok(v228) => {
                            let mut v228: Rc<str> = v228.clone();
                            US4::US4_Some(v228.clone())
                        }
                    }
                };
                match &v234 {
                    US4::US4_Some(v235) => {
                        let v235: Rc<str> = v235.clone();
                        let v236: bool = &*v155 == &*v235;
                        if v236 {
                            { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) }
                        } else {
                            let mut v239: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                            { let _ = spiral_trace_hold(&v239); };
                            let v241: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                            let (mut v242, mut v243, mut v244, mut v245, mut v246, mut v247): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v241) };
                            let v248: US0 = v246.borrow().l0.clone();
                            let v253: i32 = match &v248 {
                                US0::US0_Critical => {
                                    50i32
                                }
                                US0::US0_Debug => {
                                    20i32
                                }
                                US0::US0_Info => {
                                    30i32
                                }
                                US0::US0_Verbose => {
                                    10i32
                                }
                                US0::US0_Warning => {
                                    40i32
                                }
                            };
                            let v254: bool = v244.borrow().l0.clone();
                            let mut v255: bool = v254 == false;
                            let v257: bool = if v255 {
                                false
                            } else {
                                let v256: bool = 30i32 >= v253;
                                v256
                            };
                            let v258: bool = v257 == false;
                            let mut v312: US2 = if v258 {
                                US2::US2_None
                            } else {
                                { let _ = spiral_trace_hold(&v239); };
                                let (mut v262, mut v263, mut v264, mut v265, mut v266, mut v267): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v241) };
                                let v268: Rc<str> = method3(v262.clone(), v263.clone(), v264.clone(), v265.clone(), v266.clone(), v267.clone());
                                let v269: Rc<str> = method4();
                                let v270: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map"); } LIT.with(|lit| lit.clone()) };
                                let v271: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                                let mut v272: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                                let v273: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                                let v274: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                                let v275: bool = &*v274 == "";
                                let v277: Rc<str> = if v275 {
                                    v140.clone()
                                } else {
                                    method107(v262.clone(), v263.clone(), v264.clone(), v265.clone(), v266.clone(), v267.clone(), v268.clone(), v269.clone(), v274.clone(), v34.clone(), v36.clone(), v33.clone(), v49, v50.clone(), v64, v65.clone(), v155.clone(), v234.clone(), v52.clone(), v67.clone())
                                };
                                { let _ = spiral_trace_hold(&v239); };
                                let (mut v280, mut v281, mut v282, mut v283, mut v284, mut v285): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v241) };
                                let v286: i64 = v280.borrow().l0.clone();
                                let v287: i64 = v286.wrapping_add(1i64);
                                v280.borrow_mut().l0 = v287;
                                let v288: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                                let v289: bool = cfg!(target_arch = "wasm32");
                                if v289 {
                                    let v290: Rc<str> = v283.borrow().l0.clone();
                                    let v291: bool = &*v290 == "";
                                    let v299: Rc<str> = if v291 {
                                        v277.clone()
                                    } else {
                                        let v292: bool = &*v277 == "";
                                        if v292 {
                                            let v293: Rc<str> = v283.borrow().l0.clone();
                                            v293.clone()
                                        } else {
                                            let v294: Rc<str> = v283.borrow().l0.clone();
                                            let v295: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                            let v297: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v294, v295)), v277));
                                            v297.clone()
                                        }
                                    };
                                    let v301: usize = v299.chars().count();
                                    let v302: i32 = ((v301) as i32);
                                    let v303: i32 = v302.wrapping_add(14999i32);
                                    let v304: i32 = v303.wrapping_div(15000i32);
                                    let v305: bool = v277 != v140 ;
                                    let v307: bool = if v305 {
                                        let v306: bool = v304 <= 1i32;
                                        v306
                                    } else {
                                        false
                                    };
                                    if v307 {
                                        v283.borrow_mut().l0 = v299.clone();
                                        ()
                                    } else {
                                        v283.borrow_mut().l0 = v140.clone();
                                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v299); };
                                        ()
                                    }
                                } else {
                                    println!("{}", v277);
                                    ()
                                };
                                let mut v310: Rc<dyn Fn(Rc<str>) -> ()> = v281.borrow().l0.clone();
                                v310(v277.clone());
                                US2::US2_Some(v280.clone(), v281.clone(), v282.clone(), v283.clone(), v284.clone(), v285.clone())
                            };
                            file_copy_108(v67.clone(), v52.clone());
                            let v313: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure65(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                            let v314: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                            let v315: Rc<UH2> = Rc::new(UH2::UH2_Cons(v68.clone(), v52.clone(), v313.clone(), v314.clone()));
                            let v316: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                            let v317: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v71);
                            let v318: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                            let v319: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v72);
                            let v320: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                            let v321: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v73);
                            let v322: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v74);
                            let v323: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v75);
                            let v324: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v76);
                            let v325: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                            let v326: Rc<UH2> = Rc::new(UH2::UH2_Cons(v320.clone(), v69.clone(), v324.clone(), v325.clone()));
                            let mut v327: Rc<UH2> = Rc::new(UH2::UH2_Cons(v318.clone(), v69.clone(), v323.clone(), v326.clone()));
                            let v328: Rc<UH2> = Rc::new(UH2::UH2_Cons(v316.clone(), v69.clone(), v322.clone(), v327.clone()));
                            let v329: Rc<UH2> = Rc::new(UH2::UH2_Cons(v320.clone(), v52.clone(), v321.clone(), v328.clone()));
                            let mut v330: Rc<UH2> = Rc::new(UH2::UH2_Cons(v318.clone(), v52.clone(), v319.clone(), v329.clone()));
                            let v331: Rc<UH2> = Rc::new(UH2::UH2_Cons(v316.clone(), v52.clone(), v317.clone(), v330.clone()));
                            let v332: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
                            let v333: Rc<UH1> = Rc::new(UH1::UH1_Cons(v331.clone(), v332.clone()));
                            Rc::new(UH1::UH1_Cons(v315.clone(), v333.clone()))
                        }
                    }
                    _ => {
                        let v337: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v337); };
                        let v339: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v340, mut v341, mut v342, mut v343, mut v344, mut v345): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v339) };
                        let v346: US0 = v344.borrow().l0.clone();
                        let v351: i32 = match &v346 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v352: bool = v342.borrow().l0.clone();
                        let v353: bool = v352 == false;
                        let v355: bool = if v353 {
                            false
                        } else {
                            let v354: bool = 30i32 >= v351;
                            v354
                        };
                        let v356: bool = v355 == false;
                        let v410: US2 = if v356 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v337); };
                            let (mut v360, mut v361, mut v362, mut v363, mut v364, mut v365): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v339) };
                            let v366: Rc<str> = method3(v360.clone(), v361.clone(), v362.clone(), v363.clone(), v364.clone(), v365.clone());
                            let v367: Rc<str> = method4();
                            let v368: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map"); } LIT.with(|lit| lit.clone()) };
                            let v369: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                            let v370: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                            let v371: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                            let v372: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                            let v373: bool = &*v372 == "";
                            let v375: Rc<str> = if v373 {
                                v140.clone()
                            } else {
                                method107(v360.clone(), v361.clone(), v362.clone(), v363.clone(), v364.clone(), v365.clone(), v366.clone(), v367.clone(), v372.clone(), v34.clone(), v36.clone(), v33.clone(), v49, v50.clone(), v64, v65.clone(), v155.clone(), v234.clone(), v52.clone(), v67.clone())
                            };
                            { let _ = spiral_trace_hold(&v337); };
                            let (mut v378, mut v379, mut v380, mut v381, mut v382, mut v383): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v339) };
                            let v384: i64 = v378.borrow().l0.clone();
                            let v385: i64 = v384.wrapping_add(1i64);
                            v378.borrow_mut().l0 = v385;
                            let v386: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v387: bool = cfg!(target_arch = "wasm32");
                            if v387 {
                                let v388: Rc<str> = v381.borrow().l0.clone();
                                let v389: bool = &*v388 == "";
                                let v397: Rc<str> = if v389 {
                                    v375.clone()
                                } else {
                                    let v390: bool = &*v375 == "";
                                    if v390 {
                                        let v391: Rc<str> = v381.borrow().l0.clone();
                                        v391.clone()
                                    } else {
                                        let v392: Rc<str> = v381.borrow().l0.clone();
                                        let v393: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v395: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v392, v393)), v375));
                                        v395.clone()
                                    }
                                };
                                let v399: usize = v397.chars().count();
                                let v400: i32 = ((v399) as i32);
                                let v401: i32 = v400.wrapping_add(14999i32);
                                let v402: i32 = v401.wrapping_div(15000i32);
                                let v403: bool = v375 != v140 ;
                                let v405: bool = if v403 {
                                    let v404: bool = v402 <= 1i32;
                                    v404
                                } else {
                                    false
                                };
                                if v405 {
                                    v381.borrow_mut().l0 = v397.clone();
                                    ()
                                } else {
                                    v381.borrow_mut().l0 = v140.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v397); };
                                    ()
                                }
                            } else {
                                println!("{}", v375);
                                ()
                            };
                            let mut v408: Rc<dyn Fn(Rc<str>) -> ()> = v379.borrow().l0.clone();
                            v408(v375.clone());
                            US2::US2_Some(v378.clone(), v379.clone(), v380.clone(), v381.clone(), v382.clone(), v383.clone())
                        };
                        file_copy_108(v67.clone(), v52.clone());
                        let v411: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure65(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                        let v412: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                        let v413: Rc<UH2> = Rc::new(UH2::UH2_Cons(v68.clone(), v52.clone(), v411.clone(), v412.clone()));
                        let v414: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                        let v415: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v71);
                        let v416: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                        let v417: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v72);
                        let v418: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                        let v419: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v73);
                        let v420: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v74);
                        let v421: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v75);
                        let v422: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v76);
                        let v423: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                        let v424: Rc<UH2> = Rc::new(UH2::UH2_Cons(v418.clone(), v69.clone(), v422.clone(), v423.clone()));
                        let v425: Rc<UH2> = Rc::new(UH2::UH2_Cons(v416.clone(), v69.clone(), v421.clone(), v424.clone()));
                        let v426: Rc<UH2> = Rc::new(UH2::UH2_Cons(v414.clone(), v69.clone(), v420.clone(), v425.clone()));
                        let v427: Rc<UH2> = Rc::new(UH2::UH2_Cons(v418.clone(), v52.clone(), v419.clone(), v426.clone()));
                        let v428: Rc<UH2> = Rc::new(UH2::UH2_Cons(v416.clone(), v52.clone(), v417.clone(), v427.clone()));
                        let v429: Rc<UH2> = Rc::new(UH2::UH2_Cons(v414.clone(), v52.clone(), v415.clone(), v428.clone()));
                        let v430: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
                        let v431: Rc<UH1> = Rc::new(UH1::UH1_Cons(v429.clone(), v430.clone()));
                        Rc::new(UH1::UH1_Cons(v413.clone(), v431.clone()))
                    }
                }
            };
            let v435: bool = match &*v434 {
                UH1::UH1_Nil => {
                    true
                }
                _ => {
                    false
                }
            };
            let v436: bool = v435 != true;
            let v1000: Rc<UH1> = if v436 {
                v434.clone()
            } else {
                let v437: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                let (mut v438, mut v439): (Rc<str>, Rc<str>) = fix_paths_99(v437.clone(), v69.clone(), v5.clone());
                let v440: bool = file_exists_41(v438.clone());
                let v513: bool = if v440 {
                    true
                } else {
                    let v441: bool = file_exists_41(v439.clone());
                    let v442: bool = v441 == false;
                    if v442 {
                        true
                    } else {
                        let v444: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v444); };
                        let v446: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v447, mut v448, mut v449, mut v450, mut v451, mut v452): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v446) };
                        let v453: US0 = v451.borrow().l0.clone();
                        let v458: i32 = match &v453 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v459: bool = v449.borrow().l0.clone();
                        let v460: bool = v459 == false;
                        let v462: bool = if v460 {
                            false
                        } else {
                            let v461: bool = 30i32 >= v458;
                            v461
                        };
                        let v463: bool = v462 == false;
                        let v511: US2 = if v463 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v444); };
                            let (mut v467, mut v468, mut v469, mut v470, mut v471, mut v472): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v446) };
                            let v473: Rc<str> = method3(v467.clone(), v468.clone(), v469.clone(), v470.clone(), v471.clone(), v472.clone());
                            let v474: Rc<str> = method4();
                            let v475: Rc<str> = method125(v467.clone(), v468.clone(), v469.clone(), v470.clone(), v471.clone(), v472.clone(), v473.clone(), v474.clone(), v438.clone(), v439.clone());
                            { let _ = spiral_trace_hold(&v444); };
                            let (mut v478, mut v479, mut v480, mut v481, mut v482, mut v483): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v446) };
                            let v484: i64 = v478.borrow().l0.clone();
                            let v485: i64 = v484.wrapping_add(1i64);
                            v478.borrow_mut().l0 = v485;
                            let v486: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v487: bool = cfg!(target_arch = "wasm32");
                            if v487 {
                                let v488: Rc<str> = v481.borrow().l0.clone();
                                let v489: bool = &*v488 == "";
                                let v497: Rc<str> = if v489 {
                                    v475.clone()
                                } else {
                                    let v490: bool = &*v475 == "";
                                    if v490 {
                                        let v491: Rc<str> = v481.borrow().l0.clone();
                                        v491.clone()
                                    } else {
                                        let v492: Rc<str> = v481.borrow().l0.clone();
                                        let v493: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v495: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v492, v493)), v475));
                                        v495.clone()
                                    }
                                };
                                let v499: usize = v497.chars().count();
                                let v500: i32 = ((v499) as i32);
                                let v501: i32 = v500.wrapping_add(14999i32);
                                let v502: i32 = v501.wrapping_div(15000i32);
                                let v503: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v504: bool = v475 != v503 ;
                                let v506: bool = if v504 {
                                    let v505: bool = v502 <= 1i32;
                                    v505
                                } else {
                                    false
                                };
                                if v506 {
                                    v481.borrow_mut().l0 = v497.clone();
                                    ()
                                } else {
                                    v481.borrow_mut().l0 = v503.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v497); };
                                    ()
                                }
                            } else {
                                println!("{}", v475);
                                ()
                            };
                            let mut v509: Rc<dyn Fn(Rc<str>) -> ()> = v479.borrow().l0.clone();
                            v509(v475.clone());
                            US2::US2_Some(v478.clone(), v479.clone(), v480.clone(), v481.clone(), v482.clone(), v483.clone())
                        };
                        file_copy_108(v438.clone(), v439.clone());
                        false
                    }
                };
                let v518: Rc<UH2> = if v513 {
                    let v514: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v76);
                    let v515: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                    Rc::new(UH2::UH2_Cons(v437.clone(), v69.clone(), v514.clone(), v515.clone()))
                } else {
                    { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) }
                };
                let v519: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                let (mut v520, mut v521): (Rc<str>, Rc<str>) = fix_paths_99(v519.clone(), v69.clone(), v5.clone());
                let v522: bool = file_exists_41(v520.clone());
                let v595: bool = if v522 {
                    true
                } else {
                    let v523: bool = file_exists_41(v521.clone());
                    let v524: bool = v523 == false;
                    if v524 {
                        true
                    } else {
                        let v526: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v526); };
                        let v528: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v529, mut v530, mut v531, mut v532, mut v533, mut v534): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v528) };
                        let v535: US0 = v533.borrow().l0.clone();
                        let v540: i32 = match &v535 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v541: bool = v531.borrow().l0.clone();
                        let v542: bool = v541 == false;
                        let v544: bool = if v542 {
                            false
                        } else {
                            let v543: bool = 30i32 >= v540;
                            v543
                        };
                        let v545: bool = v544 == false;
                        let v593: US2 = if v545 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v526); };
                            let (mut v549, mut v550, mut v551, mut v552, mut v553, mut v554): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v528) };
                            let v555: Rc<str> = method3(v549.clone(), v550.clone(), v551.clone(), v552.clone(), v553.clone(), v554.clone());
                            let v556: Rc<str> = method4();
                            let v557: Rc<str> = method125(v549.clone(), v550.clone(), v551.clone(), v552.clone(), v553.clone(), v554.clone(), v555.clone(), v556.clone(), v520.clone(), v521.clone());
                            { let _ = spiral_trace_hold(&v526); };
                            let (mut v560, mut v561, mut v562, mut v563, mut v564, mut v565): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v528) };
                            let v566: i64 = v560.borrow().l0.clone();
                            let v567: i64 = v566.wrapping_add(1i64);
                            v560.borrow_mut().l0 = v567;
                            let v568: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v569: bool = cfg!(target_arch = "wasm32");
                            if v569 {
                                let v570: Rc<str> = v563.borrow().l0.clone();
                                let mut v571: bool = &*v570 == "";
                                let v579: Rc<str> = if v571 {
                                    v557.clone()
                                } else {
                                    let mut v572: bool = &*v557 == "";
                                    if v572 {
                                        let v573: Rc<str> = v563.borrow().l0.clone();
                                        v573.clone()
                                    } else {
                                        let v574: Rc<str> = v563.borrow().l0.clone();
                                        let v575: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v577: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v574, v575)), v557));
                                        v577.clone()
                                    }
                                };
                                let v581: usize = v579.chars().count();
                                let v582: i32 = ((v581) as i32);
                                let v583: i32 = v582.wrapping_add(14999i32);
                                let v584: i32 = v583.wrapping_div(15000i32);
                                let v585: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v586: bool = v557 != v585 ;
                                let v588: bool = if v586 {
                                    let v587: bool = v584 <= 1i32;
                                    v587
                                } else {
                                    false
                                };
                                if v588 {
                                    v563.borrow_mut().l0 = v579.clone();
                                    ()
                                } else {
                                    v563.borrow_mut().l0 = v585.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v579); };
                                    ()
                                }
                            } else {
                                println!("{}", v557);
                                ()
                            };
                            let mut v591: Rc<dyn Fn(Rc<str>) -> ()> = v561.borrow().l0.clone();
                            v591(v557.clone());
                            US2::US2_Some(v560.clone(), v561.clone(), v562.clone(), v563.clone(), v564.clone(), v565.clone())
                        };
                        file_copy_108(v520.clone(), v521.clone());
                        false
                    }
                };
                let v598: Rc<UH2> = if v595 {
                    let v596: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v75);
                    Rc::new(UH2::UH2_Cons(v519.clone(), v69.clone(), v596.clone(), v518.clone()))
                } else {
                    v518.clone()
                };
                let v599: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                let (mut v600, mut v601): (Rc<str>, Rc<str>) = fix_paths_99(v599.clone(), v69.clone(), v5.clone());
                let v602: bool = file_exists_41(v600.clone());
                let v675: bool = if v602 {
                    true
                } else {
                    let v603: bool = file_exists_41(v601.clone());
                    let v604: bool = v603 == false;
                    if v604 {
                        true
                    } else {
                        let v606: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v606); };
                        let v608: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v609, mut v610, mut v611, mut v612, mut v613, mut v614): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v608) };
                        let v615: US0 = v613.borrow().l0.clone();
                        let v620: i32 = match &v615 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v621: bool = v611.borrow().l0.clone();
                        let v622: bool = v621 == false;
                        let v624: bool = if v622 {
                            false
                        } else {
                            let v623: bool = 30i32 >= v620;
                            v623
                        };
                        let v625: bool = v624 == false;
                        let v673: US2 = if v625 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v606); };
                            let (mut v629, mut v630, mut v631, mut v632, mut v633, mut v634): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v608) };
                            let v635: Rc<str> = method3(v629.clone(), v630.clone(), v631.clone(), v632.clone(), v633.clone(), v634.clone());
                            let v636: Rc<str> = method4();
                            let v637: Rc<str> = method125(v629.clone(), v630.clone(), v631.clone(), v632.clone(), v633.clone(), v634.clone(), v635.clone(), v636.clone(), v600.clone(), v601.clone());
                            { let _ = spiral_trace_hold(&v606); };
                            let (mut v640, mut v641, mut v642, mut v643, mut v644, mut v645): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v608) };
                            let v646: i64 = v640.borrow().l0.clone();
                            let v647: i64 = v646.wrapping_add(1i64);
                            v640.borrow_mut().l0 = v647;
                            let v648: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v649: bool = cfg!(target_arch = "wasm32");
                            if v649 {
                                let v650: Rc<str> = v643.borrow().l0.clone();
                                let v651: bool = &*v650 == "";
                                let v659: Rc<str> = if v651 {
                                    v637.clone()
                                } else {
                                    let v652: bool = &*v637 == "";
                                    if v652 {
                                        let v653: Rc<str> = v643.borrow().l0.clone();
                                        v653.clone()
                                    } else {
                                        let v654: Rc<str> = v643.borrow().l0.clone();
                                        let v655: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v657: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v654, v655)), v637));
                                        v657.clone()
                                    }
                                };
                                let v661: usize = v659.chars().count();
                                let v662: i32 = ((v661) as i32);
                                let v663: i32 = v662.wrapping_add(14999i32);
                                let v664: i32 = v663.wrapping_div(15000i32);
                                let v665: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v666: bool = v637 != v665 ;
                                let v668: bool = if v666 {
                                    let v667: bool = v664 <= 1i32;
                                    v667
                                } else {
                                    false
                                };
                                if v668 {
                                    v643.borrow_mut().l0 = v659.clone();
                                    ()
                                } else {
                                    v643.borrow_mut().l0 = v665.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v659); };
                                    ()
                                }
                            } else {
                                println!("{}", v637);
                                ()
                            };
                            let mut v671: Rc<dyn Fn(Rc<str>) -> ()> = v641.borrow().l0.clone();
                            v671(v637.clone());
                            US2::US2_Some(v640.clone(), v641.clone(), v642.clone(), v643.clone(), v644.clone(), v645.clone())
                        };
                        file_copy_108(v600.clone(), v601.clone());
                        false
                    }
                };
                let v678: Rc<UH2> = if v675 {
                    let v676: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v74);
                    Rc::new(UH2::UH2_Cons(v599.clone(), v69.clone(), v676.clone(), v598.clone()))
                } else {
                    v598.clone()
                };
                let (mut v679, mut v680): (Rc<str>, Rc<str>) = fix_paths_99(v437.clone(), v52.clone(), v5.clone());
                let v681: bool = file_exists_41(v679.clone());
                let v754: bool = if v681 {
                    true
                } else {
                    let v682: bool = file_exists_41(v680.clone());
                    let v683: bool = v682 == false;
                    if v683 {
                        true
                    } else {
                        let v685: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v685); };
                        let v687: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v688, mut v689, mut v690, mut v691, mut v692, mut v693): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v687) };
                        let v694: US0 = v692.borrow().l0.clone();
                        let v699: i32 = match &v694 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v700: bool = v690.borrow().l0.clone();
                        let v701: bool = v700 == false;
                        let v703: bool = if v701 {
                            false
                        } else {
                            let v702: bool = 30i32 >= v699;
                            v702
                        };
                        let v704: bool = v703 == false;
                        let v752: US2 = if v704 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v685); };
                            let (mut v708, mut v709, mut v710, mut v711, mut v712, mut v713): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v687) };
                            let v714: Rc<str> = method3(v708.clone(), v709.clone(), v710.clone(), v711.clone(), v712.clone(), v713.clone());
                            let v715: Rc<str> = method4();
                            let v716: Rc<str> = method125(v708.clone(), v709.clone(), v710.clone(), v711.clone(), v712.clone(), v713.clone(), v714.clone(), v715.clone(), v679.clone(), v680.clone());
                            { let _ = spiral_trace_hold(&v685); };
                            let (mut v719, mut v720, mut v721, mut v722, mut v723, mut v724): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v687) };
                            let v725: i64 = v719.borrow().l0.clone();
                            let v726: i64 = v725.wrapping_add(1i64);
                            v719.borrow_mut().l0 = v726;
                            let v727: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v728: bool = cfg!(target_arch = "wasm32");
                            if v728 {
                                let v729: Rc<str> = v722.borrow().l0.clone();
                                let v730: bool = &*v729 == "";
                                let v738: Rc<str> = if v730 {
                                    v716.clone()
                                } else {
                                    let v731: bool = &*v716 == "";
                                    if v731 {
                                        let v732: Rc<str> = v722.borrow().l0.clone();
                                        v732.clone()
                                    } else {
                                        let v733: Rc<str> = v722.borrow().l0.clone();
                                        let v734: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v736: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v733, v734)), v716));
                                        v736.clone()
                                    }
                                };
                                let v740: usize = v738.chars().count();
                                let v741: i32 = ((v740) as i32);
                                let v742: i32 = v741.wrapping_add(14999i32);
                                let v743: i32 = v742.wrapping_div(15000i32);
                                let v744: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v745: bool = v716 != v744 ;
                                let v747: bool = if v745 {
                                    let v746: bool = v743 <= 1i32;
                                    v746
                                } else {
                                    false
                                };
                                if v747 {
                                    v722.borrow_mut().l0 = v738.clone();
                                    ()
                                } else {
                                    v722.borrow_mut().l0 = v744.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v738); };
                                    ()
                                }
                            } else {
                                println!("{}", v716);
                                ()
                            };
                            let mut v750: Rc<dyn Fn(Rc<str>) -> ()> = v720.borrow().l0.clone();
                            v750(v716.clone());
                            US2::US2_Some(v719.clone(), v720.clone(), v721.clone(), v722.clone(), v723.clone(), v724.clone())
                        };
                        file_copy_108(v679.clone(), v680.clone());
                        false
                    }
                };
                let v757: Rc<UH2> = if v754 {
                    let v755: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v73);
                    Rc::new(UH2::UH2_Cons(v437.clone(), v52.clone(), v755.clone(), v678.clone()))
                } else {
                    v678.clone()
                };
                let (mut v758, mut v759): (Rc<str>, Rc<str>) = fix_paths_99(v519.clone(), v52.clone(), v5.clone());
                let v760: bool = file_exists_41(v758.clone());
                let v833: bool = if v760 {
                    true
                } else {
                    let v761: bool = file_exists_41(v759.clone());
                    let v762: bool = v761 == false;
                    if v762 {
                        true
                    } else {
                        let v764: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v764); };
                        let v766: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v767, mut v768, mut v769, mut v770, mut v771, mut v772): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v766) };
                        let v773: US0 = v771.borrow().l0.clone();
                        let v778: i32 = match &v773 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v779: bool = v769.borrow().l0.clone();
                        let v780: bool = v779 == false;
                        let v782: bool = if v780 {
                            false
                        } else {
                            let v781: bool = 30i32 >= v778;
                            v781
                        };
                        let v783: bool = v782 == false;
                        let v831: US2 = if v783 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v764); };
                            let (mut v787, mut v788, mut v789, mut v790, mut v791, mut v792): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v766) };
                            let v793: Rc<str> = method3(v787.clone(), v788.clone(), v789.clone(), v790.clone(), v791.clone(), v792.clone());
                            let v794: Rc<str> = method4();
                            let v795: Rc<str> = method125(v787.clone(), v788.clone(), v789.clone(), v790.clone(), v791.clone(), v792.clone(), v793.clone(), v794.clone(), v758.clone(), v759.clone());
                            { let _ = spiral_trace_hold(&v764); };
                            let (mut v798, mut v799, mut v800, mut v801, mut v802, mut v803): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v766) };
                            let v804: i64 = v798.borrow().l0.clone();
                            let v805: i64 = v804.wrapping_add(1i64);
                            v798.borrow_mut().l0 = v805;
                            let v806: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v807: bool = cfg!(target_arch = "wasm32");
                            if v807 {
                                let v808: Rc<str> = v801.borrow().l0.clone();
                                let v809: bool = &*v808 == "";
                                let v817: Rc<str> = if v809 {
                                    v795.clone()
                                } else {
                                    let v810: bool = &*v795 == "";
                                    if v810 {
                                        let v811: Rc<str> = v801.borrow().l0.clone();
                                        v811.clone()
                                    } else {
                                        let v812: Rc<str> = v801.borrow().l0.clone();
                                        let v813: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v815: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v812, v813)), v795));
                                        v815.clone()
                                    }
                                };
                                let v819: usize = v817.chars().count();
                                let v820: i32 = ((v819) as i32);
                                let v821: i32 = v820.wrapping_add(14999i32);
                                let v822: i32 = v821.wrapping_div(15000i32);
                                let v823: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v824: bool = v795 != v823 ;
                                let v826: bool = if v824 {
                                    let v825: bool = v822 <= 1i32;
                                    v825
                                } else {
                                    false
                                };
                                if v826 {
                                    v801.borrow_mut().l0 = v817.clone();
                                    ()
                                } else {
                                    v801.borrow_mut().l0 = v823.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v817); };
                                    ()
                                }
                            } else {
                                println!("{}", v795);
                                ()
                            };
                            let mut v829: Rc<dyn Fn(Rc<str>) -> ()> = v799.borrow().l0.clone();
                            v829(v795.clone());
                            US2::US2_Some(v798.clone(), v799.clone(), v800.clone(), v801.clone(), v802.clone(), v803.clone())
                        };
                        file_copy_108(v758.clone(), v759.clone());
                        false
                    }
                };
                let v836: Rc<UH2> = if v833 {
                    let v834: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v72);
                    Rc::new(UH2::UH2_Cons(v519.clone(), v52.clone(), v834.clone(), v757.clone()))
                } else {
                    v757.clone()
                };
                let (mut v837, mut v838): (Rc<str>, Rc<str>) = fix_paths_99(v599.clone(), v52.clone(), v5.clone());
                let v839: bool = file_exists_41(v837.clone());
                let v912: bool = if v839 {
                    true
                } else {
                    let v840: bool = file_exists_41(v838.clone());
                    let v841: bool = v840 == false;
                    if v841 {
                        true
                    } else {
                        let v843: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v843); };
                        let v845: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v846, mut v847, mut v848, mut v849, mut v850, mut v851): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v845) };
                        let v852: US0 = v850.borrow().l0.clone();
                        let v857: i32 = match &v852 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v858: bool = v848.borrow().l0.clone();
                        let v859: bool = v858 == false;
                        let v861: bool = if v859 {
                            false
                        } else {
                            let v860: bool = 30i32 >= v857;
                            v860
                        };
                        let v862: bool = v861 == false;
                        let v910: US2 = if v862 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v843); };
                            let (mut v866, mut v867, mut v868, mut v869, mut v870, mut v871): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v845) };
                            let v872: Rc<str> = method3(v866.clone(), v867.clone(), v868.clone(), v869.clone(), v870.clone(), v871.clone());
                            let v873: Rc<str> = method4();
                            let v874: Rc<str> = method125(v866.clone(), v867.clone(), v868.clone(), v869.clone(), v870.clone(), v871.clone(), v872.clone(), v873.clone(), v837.clone(), v838.clone());
                            { let _ = spiral_trace_hold(&v843); };
                            let (mut v877, mut v878, mut v879, mut v880, mut v881, mut v882): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v845) };
                            let v883: i64 = v877.borrow().l0.clone();
                            let v884: i64 = v883.wrapping_add(1i64);
                            v877.borrow_mut().l0 = v884;
                            let v885: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v886: bool = cfg!(target_arch = "wasm32");
                            if v886 {
                                let v887: Rc<str> = v880.borrow().l0.clone();
                                let v888: bool = &*v887 == "";
                                let v896: Rc<str> = if v888 {
                                    v874.clone()
                                } else {
                                    let v889: bool = &*v874 == "";
                                    if v889 {
                                        let v890: Rc<str> = v880.borrow().l0.clone();
                                        v890.clone()
                                    } else {
                                        let v891: Rc<str> = v880.borrow().l0.clone();
                                        let v892: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v894: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v891, v892)), v874));
                                        v894.clone()
                                    }
                                };
                                let v898: usize = v896.chars().count();
                                let v899: i32 = ((v898) as i32);
                                let v900: i32 = v899.wrapping_add(14999i32);
                                let v901: i32 = v900.wrapping_div(15000i32);
                                let v902: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v903: bool = v874 != v902 ;
                                let v905: bool = if v903 {
                                    let v904: bool = v901 <= 1i32;
                                    v904
                                } else {
                                    false
                                };
                                if v905 {
                                    v880.borrow_mut().l0 = v896.clone();
                                    ()
                                } else {
                                    v880.borrow_mut().l0 = v902.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v896); };
                                    ()
                                }
                            } else {
                                println!("{}", v874);
                                ()
                            };
                            let mut v908: Rc<dyn Fn(Rc<str>) -> ()> = v878.borrow().l0.clone();
                            v908(v874.clone());
                            US2::US2_Some(v877.clone(), v878.clone(), v879.clone(), v880.clone(), v881.clone(), v882.clone())
                        };
                        file_copy_108(v837.clone(), v838.clone());
                        false
                    }
                };
                let v915: Rc<UH2> = if v912 {
                    let v913: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure68(v5.clone(), v4.clone(), v71);
                    Rc::new(UH2::UH2_Cons(v599.clone(), v52.clone(), v913.clone(), v836.clone()))
                } else {
                    v836.clone()
                };
                let (mut v916, mut v917): (Rc<str>, Rc<str>) = fix_paths_99(v68.clone(), v52.clone(), v5.clone());
                let v918: bool = file_exists_41(v916.clone());
                let v991: bool = if v918 {
                    true
                } else {
                    let v919: bool = file_exists_41(v917.clone());
                    let v920: bool = v919 == false;
                    if v920 {
                        true
                    } else {
                        let v922: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
                        { let _ = spiral_trace_hold(&v922); };
                        let v924: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
                        let (mut v925, mut v926, mut v927, mut v928, mut v929, mut v930): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v924) };
                        let v931: US0 = v929.borrow().l0.clone();
                        let v936: i32 = match &v931 {
                            US0::US0_Critical => {
                                50i32
                            }
                            US0::US0_Debug => {
                                20i32
                            }
                            US0::US0_Info => {
                                30i32
                            }
                            US0::US0_Verbose => {
                                10i32
                            }
                            US0::US0_Warning => {
                                40i32
                            }
                        };
                        let v937: bool = v927.borrow().l0.clone();
                        let v938: bool = v937 == false;
                        let v940: bool = if v938 {
                            false
                        } else {
                            let v939: bool = 30i32 >= v936;
                            v939
                        };
                        let v941: bool = v940 == false;
                        let v989: US2 = if v941 {
                            US2::US2_None
                        } else {
                            { let _ = spiral_trace_hold(&v922); };
                            let (mut v945, mut v946, mut v947, mut v948, mut v949, mut v950): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v924) };
                            let v951: Rc<str> = method3(v945.clone(), v946.clone(), v947.clone(), v948.clone(), v949.clone(), v950.clone());
                            let v952: Rc<str> = method4();
                            let v953: Rc<str> = method125(v945.clone(), v946.clone(), v947.clone(), v948.clone(), v949.clone(), v950.clone(), v951.clone(), v952.clone(), v916.clone(), v917.clone());
                            { let _ = spiral_trace_hold(&v922); };
                            let (mut v956, mut v957, mut v958, mut v959, mut v960, mut v961): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v924) };
                            let v962: i64 = v956.borrow().l0.clone();
                            let v963: i64 = v962.wrapping_add(1i64);
                            v956.borrow_mut().l0 = v963;
                            let v964: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let v965: bool = cfg!(target_arch = "wasm32");
                            if v965 {
                                let v966: Rc<str> = v959.borrow().l0.clone();
                                let v967: bool = &*v966 == "";
                                let v975: Rc<str> = if v967 {
                                    v953.clone()
                                } else {
                                    let v968: bool = &*v953 == "";
                                    if v968 {
                                        let v969: Rc<str> = v959.borrow().l0.clone();
                                        v969.clone()
                                    } else {
                                        let v970: Rc<str> = v959.borrow().l0.clone();
                                        let v971: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let v973: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v970, v971)), v953));
                                        v973.clone()
                                    }
                                };
                                let v977: usize = v975.chars().count();
                                let v978: i32 = ((v977) as i32);
                                let v979: i32 = v978.wrapping_add(14999i32);
                                let v980: i32 = v979.wrapping_div(15000i32);
                                let v981: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let v982: bool = v953 != v981 ;
                                let v984: bool = if v982 {
                                    let v983: bool = v980 <= 1i32;
                                    v983
                                } else {
                                    false
                                };
                                if v984 {
                                    v959.borrow_mut().l0 = v975.clone();
                                    ()
                                } else {
                                    v959.borrow_mut().l0 = v981.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v975); };
                                    ()
                                }
                            } else {
                                println!("{}", v953);
                                ()
                            };
                            let mut v987: Rc<dyn Fn(Rc<str>) -> ()> = v957.borrow().l0.clone();
                            v987(v953.clone());
                            US2::US2_Some(v956.clone(), v957.clone(), v958.clone(), v959.clone(), v960.clone(), v961.clone())
                        };
                        file_copy_108(v916.clone(), v917.clone());
                        false
                    }
                };
                let v996: Rc<UH2> = if v991 {
                    let v992: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure65(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                    let v993: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) };
                    Rc::new(UH2::UH2_Cons(v68.clone(), v52.clone(), v992.clone(), v993.clone()))
                } else {
                    { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) }
                };
                let v997: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
                let v998: Rc<UH1> = Rc::new(UH1::UH1_Cons(v915.clone(), v997.clone()));
                Rc::new(UH1::UH1_Cons(v996.clone(), v998.clone()))
            };
            let v1001: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new(Vec::new()));
            let v1002: i32 = 0i32;
            let v1003: i32 = method126(v1001.clone(), v1000.clone(), v1002);
            let v1004: Rc<Vec<Rc<UH2>>> = Rc::new(v1001.borrow().clone());
            let v1005: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new((v1004).as_ref().clone()));
            let v1006: Vec<Rc<UH2>> = (v1005).borrow().clone();
            let v1007: Rc<RefCell<Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>>> = Rc::new(RefCell::new(vec![]));
            let v1008: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = (v1007).borrow().clone();
            let v1009: Vec<Rc<UH2>> = method127(v1006.clone());
            let v1010: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new(v1009));
            let v1011: Rc<Vec<Rc<UH2>>> = Rc::new((v1010).borrow().clone());
            let v1012: i32 = (v1011).len() as i32;
            let v1013: i32 = v1012.wrapping_sub(1i32);
            let v1014: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
            let v1015: Rc<UH1> = method128(v1011.clone(), v1013, v1014.clone());
            let v1016: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method129(v1015.clone(), v1008.clone());
            let (mut v1017, mut v1018): (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) = method138(v34.clone(), v1016.clone());
            let v1019: (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) = (v1017, v1018);
            let v1020: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> = Ok::<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>(v1019);
            let v1021: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> = method139(v1020.clone());
            let mut v1022: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = method140(v9.clone());
            let v1024: bool = true; let mut v1022 = v1022;
            let v1026: bool = true; v1022.push(v1021);
            let v1028: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = v1022;
            (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0, v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone(), v7, v11, v1028.clone());
            continue;
        } else {
            return v9.clone();
        }
    }
}
fn method141(mut v0: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> {
    v0
}
fn run_22(mut v0: bool, mut v1: US4, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>, mut v5: Rc<str>) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> {
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("SPIRAL_REPO_ROOT"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = get_environment_variable_1(v6.clone());
    let mut v8: bool = &*v7 != "";
    let v40: Rc<str> = if v8 {
        normalize_path_23(v7.clone())
    } else {
        let mut v10: Rc<str> = get_current_directory_37();
        let mut v11: US4 = run_38(v10.clone());
        let mut v17: US4 = match &v11 {
            US4::US4_None => {
                let mut v14: Rc<str> = Rc::<str>::from(env!("CARGO_MANIFEST_DIR"));
                run_38(v14.clone())
            }
            US4::US4_Some(v12) => {
                let mut v12: Rc<str> = v12.clone();
                US4::US4_Some(v12.clone())
            }
        };
        let v23: US4 = match &v17 {
            US4::US4_None => {
                let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/workspaces"); } LIT.with(|lit| lit.clone()) };
                run_38(v20.clone())
            }
            US4::US4_Some(v18) => {
                let v18: Rc<str> = v18.clone();
                US4::US4_Some(v18.clone())
            }
        };
        let mut v27: Rc<str> = match &v23 {
            US4::US4_None => {
                std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
            }
            US4::US4_Some(v24) => {
                let v24: Rc<str> = v24.clone();
                v24.clone()
            }
        };
        let mut v28: Rc<str> = get_file_name_27(v27.clone());
        let mut v29: bool = "deps" == &*v28;
        let v37: Rc<str> = if v29 {
            let v30: Option<Rc<str>> = directory_get_parent_29(v27.clone());
            let mut v31: Rc<str> = v30.unwrap();
            let mut v32: US4 = run_38(v31.clone());
            match &v32 {
                US4::US4_None => {
                    std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
                }
                US4::US4_Some(v33) => {
                    let mut v33: Rc<str> = v33.clone();
                    v33.clone()
                }
            }
        } else {
            v27.clone()
        };
        let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("spiral"); } LIT.with(|lit| lit.clone()) };
        method34(v37.clone(), v38.clone())
    };
    let mut v41: Rc<str> = get_full_path_44(v5.clone());
    let mut v42: Rc<str> = get_full_path_44(v4.clone());
    let v43: Rc<str> = get_full_path_44(v3.clone());
    let mut v45: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    { let _ = spiral_trace_hold(&v45); };
    let mut v47: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
    let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
    let v54: US0 = v52.borrow().l0.clone();
    let mut v59: i32 = match &v54 {
        US0::US0_Critical => {
            50i32
        }
        US0::US0_Debug => {
            20i32
        }
        US0::US0_Info => {
            30i32
        }
        US0::US0_Verbose => {
            10i32
        }
        US0::US0_Warning => {
            40i32
        }
    };
    let v60: bool = v50.borrow().l0.clone();
    let v61: bool = v60 == false;
    let mut v63: bool = if v61 {
        false
    } else {
        let v62: bool = 20i32 >= v59;
        v62
    };
    let v64: bool = v63 == false;
    let v112: US2 = if v64 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v45); };
        let (mut v68, mut v69, mut v70, mut v71, mut v72, mut v73): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
        let mut v74: Rc<str> = method3(v68.clone(), v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone());
        let v75: Rc<str> = method48();
        let mut v76: Rc<str> = method49(v68.clone(), v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone(), v74.clone(), v75.clone(), v41.clone(), v42.clone(), v43.clone(), v2.clone(), v1.clone(), v0);
        { let _ = spiral_trace_hold(&v45); };
        let (mut v79, mut v80, mut v81, mut v82, mut v83, mut v84): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
        let v85: i64 = v79.borrow().l0.clone();
        let v86: i64 = v85.wrapping_add(1i64);
        v79.borrow_mut().l0 = v86;
        let mut v87: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let v88: bool = cfg!(target_arch = "wasm32");
        if v88 {
            let v89: Rc<str> = v82.borrow().l0.clone();
            let v90: bool = &*v89 == "";
            let mut v98: Rc<str> = if v90 {
                v76.clone()
            } else {
                let v91: bool = &*v76 == "";
                if v91 {
                    let v92: Rc<str> = v82.borrow().l0.clone();
                    v92.clone()
                } else {
                    let mut v93: Rc<str> = v82.borrow().l0.clone();
                    let v94: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v96: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v93, v94)), v76));
                    v96.clone()
                }
            };
            let v100: usize = v98.chars().count();
            let v101: i32 = ((v100) as i32);
            let mut v102: i32 = v101.wrapping_add(14999i32);
            let mut v103: i32 = v102.wrapping_div(15000i32);
            let v104: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v105: bool = v76 != v104 ;
            let mut v107: bool = if v105 {
                let mut v106: bool = v103 <= 1i32;
                v106
            } else {
                false
            };
            if v107 {
                v82.borrow_mut().l0 = v98.clone();
                ()
            } else {
                v82.borrow_mut().l0 = v104.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v98); };
                ()
            }
        } else {
            println!("{}", v76);
            ()
        };
        let mut v110: Rc<dyn Fn(Rc<str>) -> ()> = v80.borrow().l0.clone();
        v110(v76.clone());
        US2::US2_Some(v79.clone(), v80.clone(), v81.clone(), v82.clone(), v83.clone(), v84.clone())
    };
    let v114: bool = true; let __future_init = Box::pin(/*;
    let mut v116: bool = */ async move { /*;
    let v118: bool = */ ();
    let (mut v123, mut v124): (Rc<str>, bool) = match &v1 {
        US4::US4_None => {
            let v120: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            (v120.clone(), false)
        }
        US4::US4_Some(v119) => {
            let mut v119: Rc<str> = v119.clone();
            (v119.clone(), true)
        }
    };
    let v125: Vec<Rc<str>> = { let mut out: Vec<Rc<str>> = Vec::new(); let mut stack = vec![std::path::PathBuf::from(&*v42)]; while let Some(dir) = stack.pop() { if let Ok(entries) = std::fs::read_dir(&dir) { for entry in entries.flatten() { let path = entry.path(); if path.is_dir() { stack.push(path) } else { let s = path.display().to_string(); if s.ends_with(".md") && !s.ends_with(".hangul.md") && (!v124 || s.contains(&*v123)) { out.push(Rc::from(s.as_str())) } } } } } out };
    { let _ = spiral_trace_hold(&v45); };
    let (mut v128, mut v129, mut v130, mut v131, mut v132, mut v133): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
    let v134: US0 = v132.borrow().l0.clone();
    let v139: i32 = match &v134 {
        US0::US0_Critical => {
            50i32
        }
        US0::US0_Debug => {
            20i32
        }
        US0::US0_Info => {
            30i32
        }
        US0::US0_Verbose => {
            10i32
        }
        US0::US0_Warning => {
            40i32
        }
    };
    let v140: bool = v130.borrow().l0.clone();
    let v141: bool = v140 == false;
    let mut v143: bool = if v141 {
        false
    } else {
        let v142: bool = 20i32 >= v139;
        v142
    };
    let mut v144: bool = v143 == false;
    let v193: US2 = if v144 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v45); };
        let (mut v148, mut v149, mut v150, mut v151, mut v152, mut v153): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
        let mut v154: Rc<str> = method3(v148.clone(), v149.clone(), v150.clone(), v151.clone(), v152.clone(), v153.clone());
        let mut v155: Rc<str> = method48();
        let mut v156: usize = ((v125).len() as usize);
        let mut v157: Rc<str> = method52(v148.clone(), v149.clone(), v150.clone(), v151.clone(), v152.clone(), v153.clone(), v154.clone(), v155.clone(), v156.clone());
        { let _ = spiral_trace_hold(&v45); };
        let (mut v160, mut v161, mut v162, mut v163, mut v164, mut v165): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v47) };
        let v166: i64 = v160.borrow().l0.clone();
        let mut v167: i64 = v166.wrapping_add(1i64);
        v160.borrow_mut().l0 = v167;
        let v168: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let v169: bool = cfg!(target_arch = "wasm32");
        if v169 {
            let v170: Rc<str> = v163.borrow().l0.clone();
            let v171: bool = &*v170 == "";
            let v179: Rc<str> = if v171 {
                v157.clone()
            } else {
                let mut v172: bool = &*v157 == "";
                if v172 {
                    let mut v173: Rc<str> = v163.borrow().l0.clone();
                    v173.clone()
                } else {
                    let v174: Rc<str> = v163.borrow().l0.clone();
                    let mut v175: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v177: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v174, v175)), v157));
                    v177.clone()
                }
            };
            let v181: usize = v179.chars().count();
            let v182: i32 = ((v181) as i32);
            let v183: i32 = v182.wrapping_add(14999i32);
            let v184: i32 = v183.wrapping_div(15000i32);
            let v185: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v186: bool = v157 != v185 ;
            let v188: bool = if v186 {
                let mut v187: bool = v184 <= 1i32;
                v187
            } else {
                false
            };
            if v188 {
                v163.borrow_mut().l0 = v179.clone();
                ()
            } else {
                v163.borrow_mut().l0 = v185.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v179); };
                ()
            }
        } else {
            println!("{}", v157);
            ()
        };
        let mut v191: Rc<dyn Fn(Rc<str>) -> ()> = v161.borrow().l0.clone();
        v191(v157.clone());
        US2::US2_Some(v160.clone(), v161.clone(), v162.clone(), v163.clone(), v164.clone(), v165.clone())
    };
    let v194: Vec<Rc<str>> = method53(v125.clone());
    let v195: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v194));
    let v196: i32 = (v195.borrow().len() as i32);
    let v197: i32 = 0i32;
    let v198: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = Vec::new();
    let v199: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = loop_54(v0, v2.clone(), v40.clone(), v41.clone(), v42.clone(), v43.clone(), v195.clone(), v196, v197, v198.clone());
    let v200: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = method141(v199.clone());
    let mut v201: Rc<RefCell<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>>> = Rc::new(RefCell::new(v200));
    let v202: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = (v201).borrow().clone();
    let v203: Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String> = Ok::<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>(v202);
    let v204: bool = true; (v203) }); //;
    let mut v206: _ = __future_init;
    let mut v208: std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> = v206;
    v208
}
fn ok_c70() -> Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US28> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US28> = Rc::new(move |mut v0: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>| -> US28 {
        US28::US28_Ok(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method142() -> Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US28> {
    ok_c70()
}
fn error_c71() -> Rc<dyn Fn(std::string::String) -> US28> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US28> = Rc::new(move |mut v0: std::string::String| -> US28 {
        US28::US28_Error(v0.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method143() -> Rc<dyn Fn(std::string::String) -> US28> {
    error_c71()
}
fn method144(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: std::string::String) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_11(v9);
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
    method8(v32)
}
fn method145(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: usize) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = format_real_11(v9);
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
    method8(v32)
}
fn spiral_main() -> i32 {
    let mut v0: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(std::env::args().skip(1).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let mut v2: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c0();
    { let _ = spiral_trace_hold(&v2); };
    let mut v4: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c2();
    { let _ = spiral_trace_hold(&v4); };
    let mut v6: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = fresh_c3();
    let (mut v7, mut v8, mut v9, mut v10, mut v11, mut v12): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
    let mut v13: US0 = v11.borrow().l0.clone();
    let v18: i32 = match &v13 {
        US0::US0_Critical => {
            50i32
        }
        US0::US0_Debug => {
            20i32
        }
        US0::US0_Info => {
            30i32
        }
        US0::US0_Verbose => {
            10i32
        }
        US0::US0_Warning => {
            40i32
        }
    };
    let v19: bool = v9.borrow().l0.clone();
    let mut v20: bool = v19 == false;
    let mut v22: bool = if v20 {
        false
    } else {
        let v21: bool = 30i32 >= v18;
        v21
    };
    let v23: bool = v22 == false;
    let mut v71: US2 = if v23 {
        US2::US2_None
    } else {
        { let _ = spiral_trace_hold(&v4); };
        let (mut v27, mut v28, mut v29, mut v30, mut v31, mut v32): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
        let mut v33: Rc<str> = method3(v27.clone(), v28.clone(), v29.clone(), v30.clone(), v31.clone(), v32.clone());
        let v34: Rc<str> = method4();
        let mut v35: Rc<str> = method7(v27, v28, v29, v30, v31, v32, v33, v34, v0);
        { let _ = spiral_trace_hold(&v4); };
        let (mut v38, mut v39, mut v40, mut v41, mut v42, mut v43): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
        let v44: i64 = v38.borrow().l0.clone();
        let mut v45: i64 = v44.wrapping_add(1i64);
        v38.borrow_mut().l0 = v45;
        let mut v46: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v47: bool = cfg!(target_arch = "wasm32");
        if v47 {
            let mut v48: Rc<str> = v41.borrow().l0.clone();
            let mut v49: bool = &*v48 == "";
            let mut v57: Rc<str> = if v49 {
                v35.clone()
            } else {
                let v50: bool = &*v35 == "";
                if v50 {
                    let v51: Rc<str> = v41.borrow().l0.clone();
                    v51
                } else {
                    let mut v52: Rc<str> = v41.borrow().l0.clone();
                    let v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let v55: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v52, v53)), v35));
                    v55
                }
            };
            let mut v59: usize = v57.chars().count();
            let v60: i32 = ((v59) as i32);
            let v61: i32 = v60.wrapping_add(14999i32);
            let v62: i32 = v61.wrapping_div(15000i32);
            let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let v64: bool = v35 != v63 ;
            let v66: bool = if v64 {
                let mut v65: bool = v62 <= 1i32;
                v65
            } else {
                false
            };
            if v66 {
                v41.borrow_mut().l0 = v57.clone();
                ()
            } else {
                v41.borrow_mut().l0 = v63;
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v57); };
                ()
            }
        } else {
            println!("{}", v35);
            ()
        };
        let mut v69: Rc<dyn Fn(Rc<str>) -> ()> = v39.borrow().l0.clone();
        v69(v35);
        US2::US2_Some(v38, v39, v40, v41, v42, v43)
    };
    let v72: clap::Command = get_command_14();
    let mut v74: clap::ArgMatches = clap::Command::get_matches(v72);
    let v75: Rc<str> = method15();
    let mut v77: &str = &*v75;
    let mut v79: Option<std::string::String> = clap::ArgMatches::get_one(&v74, v77).cloned();
    let mut v80: Option<std::string::String> = method16(v79);
    let mut v81: Rc<dyn Fn((std::string::String)) -> US3> = closure5();
    let mut v82: Option<US3> = v80.map(|x| v81(x));
    let v84: US3 = US3::US3_None;
    let v85: US3 = v84;
    let v86: US3 = v82.unwrap_or(v85);
    let v90: std::string::String = match &v86 {
        US3::US3_None => {
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US3::US3_Some(v87) => {
            let mut v87: std::string::String = v87.clone();
            v87
        }
    };
    let v92: Rc<str> = Rc::<str>::from(String::as_str(&v90));
    let mut v93: Rc<str> = method17();
    let v95: &str = &*v93;
    let mut v97: Option<std::string::String> = clap::ArgMatches::get_one(&v74, v95).cloned();
    let mut v98: Option<std::string::String> = method16(v97);
    let mut v99: Option<US3> = v98.map(|x| v81(x));
    let v101: US3 = US3::US3_None;
    let mut v102: US3 = v101;
    let mut v103: US3 = v99.unwrap_or(v102);
    let mut v107: std::string::String = match &v103 {
        US3::US3_None => {
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US3::US3_Some(v104) => {
            let v104: std::string::String = v104.clone();
            v104
        }
    };
    let v109: Rc<str> = Rc::<str>::from(String::as_str(&v107));
    let mut v110: Rc<str> = method18();
    let v112: &str = &*v110;
    let v114: Option<std::string::String> = clap::ArgMatches::get_one(&v74, v112).cloned();
    let v115: Option<std::string::String> = method16(v114);
    let mut v116: Option<US3> = v115.map(|x| v81(x));
    let v118: US3 = US3::US3_None;
    let mut v119: US3 = v118;
    let v120: US3 = v116.unwrap_or(v119);
    let mut v124: std::string::String = match &v120 {
        US3::US3_None => {
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US3::US3_Some(v121) => {
            let mut v121: std::string::String = v121.clone();
            v121
        }
    };
    let v126: Rc<str> = Rc::<str>::from(String::as_str(&v124));
    let mut v127: Rc<str> = method19();
    let v129: &str = &*v127;
    let v131: Option<std::string::String> = clap::ArgMatches::get_one(&v74, v129).cloned();
    let v132: Option<std::string::String> = method16(v131);
    let mut v133: Option<US3> = v132.map(|x| v81(x));
    let v135: US3 = US3::US3_None;
    let v136: US3 = v135;
    let v137: US3 = v133.unwrap_or(v136);
    let mut v144: US4 = match &v137 {
        US3::US3_None => {
            US4::US4_None
        }
        US3::US3_Some(v138) => {
            let v138: std::string::String = v138.clone();
            let v140: Rc<str> = Rc::<str>::from(String::as_str(&v138));
            US4::US4_Some(v140)
        }
    };
    let mut v148: Rc<str> = match &v144 {
        US4::US4_None => {
            let v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("por-br"); } LIT.with(|lit| lit.clone()) };
            v146
        }
        US4::US4_Some(v145) => {
            let v145: Rc<str> = v145.clone();
            v145
        }
    };
    let v149: Rc<str> = method20();
    let mut v151: &str = &*v149;
    let mut v153: Option<std::string::String> = clap::ArgMatches::get_one(&v74, v151).cloned();
    let mut v154: Option<std::string::String> = method16(v153);
    let mut v155: Option<US3> = v154.map(|x| v81(x));
    let mut v157: US3 = US3::US3_None;
    let mut v158: US3 = v157;
    let v159: US3 = v155.unwrap_or(v158);
    let v166: US4 = match &v159 {
        US3::US3_None => {
            US4::US4_None
        }
        US3::US3_Some(v160) => {
            let mut v160: std::string::String = v160.clone();
            let v162: Rc<str> = Rc::<str>::from(String::as_str(&v160));
            US4::US4_Some(v162)
        }
    };
    let mut v167: Rc<str> = method21();
    let v169: &str = &*v167;
    let v171: bool = clap::ArgMatches::get_flag(&v74, v169);
    let mut v172: std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> = run_22(v171, v166, v148, v126, v109, v92);
    let v174: Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String> = futures::executor::block_on(v172);
    let mut v175: Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US28> = method142();
    let mut v176: Rc<dyn Fn(std::string::String) -> US28> = method143();
    let v177: US28 = match v174 { Ok(x) => v175(x), Err(e) => v176(e) };
    let v316: i32 = match &v177 {
        US28::US28_Error(v247) => {
            let v247: std::string::String = v247.clone();
            { let _ = spiral_trace_hold(&v4); };
            let (mut v250, mut v251, mut v252, mut v253, mut v254, mut v255): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
            let v256: US0 = v254.borrow().l0.clone();
            let v261: i32 = match &v256 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let v262: bool = v252.borrow().l0.clone();
            let v263: bool = v262 == false;
            let v265: bool = if v263 {
                false
            } else {
                let v264: bool = 50i32 >= v261;
                v264
            };
            let v266: bool = v265 == false;
            let v314: US2 = if v266 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v4); };
                let (mut v270, mut v271, mut v272, mut v273, mut v274, mut v275): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
                let v276: Rc<str> = method3(v270.clone(), v271.clone(), v272.clone(), v273.clone(), v274.clone(), v275.clone());
                let v277: Rc<str> = method88();
                let v278: Rc<str> = method144(v270, v271, v272, v273, v274, v275, v276, v277, v247);
                { let _ = spiral_trace_hold(&v4); };
                let (mut v281, mut v282, mut v283, mut v284, mut v285, mut v286): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
                let v287: i64 = v281.borrow().l0.clone();
                let v288: i64 = v287.wrapping_add(1i64);
                v281.borrow_mut().l0 = v288;
                let v289: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let v290: bool = cfg!(target_arch = "wasm32");
                if v290 {
                    let v291: Rc<str> = v284.borrow().l0.clone();
                    let v292: bool = &*v291 == "";
                    let v300: Rc<str> = if v292 {
                        v278.clone()
                    } else {
                        let v293: bool = &*v278 == "";
                        if v293 {
                            let v294: Rc<str> = v284.borrow().l0.clone();
                            v294
                        } else {
                            let v295: Rc<str> = v284.borrow().l0.clone();
                            let v296: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v298: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v295, v296)), v278));
                            v298
                        }
                    };
                    let v302: usize = v300.chars().count();
                    let v303: i32 = ((v302) as i32);
                    let v304: i32 = v303.wrapping_add(14999i32);
                    let v305: i32 = v304.wrapping_div(15000i32);
                    let v306: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let v307: bool = v278 != v306 ;
                    let v309: bool = if v307 {
                        let v308: bool = v305 <= 1i32;
                        v308
                    } else {
                        false
                    };
                    if v309 {
                        v284.borrow_mut().l0 = v300.clone();
                        ()
                    } else {
                        v284.borrow_mut().l0 = v306;
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v300); };
                        ()
                    }
                } else {
                    println!("{}", v278);
                    ()
                };
                let mut v312: Rc<dyn Fn(Rc<str>) -> ()> = v282.borrow().l0.clone();
                v312(v278);
                US2::US2_Some(v281, v282, v283, v284, v285, v286)
            };
            1i32
        }
        US28::US28_Ok(v178) => {
            let mut v178: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = v178.clone();
            { let _ = spiral_trace_hold(&v4); };
            let (mut v181, mut v182, mut v183, mut v184, mut v185, mut v186): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
            let mut v187: US0 = v185.borrow().l0.clone();
            let v192: i32 = match &v187 {
                US0::US0_Critical => {
                    50i32
                }
                US0::US0_Debug => {
                    20i32
                }
                US0::US0_Info => {
                    30i32
                }
                US0::US0_Verbose => {
                    10i32
                }
                US0::US0_Warning => {
                    40i32
                }
            };
            let v193: bool = v183.borrow().l0.clone();
            let v194: bool = v193 == false;
            let v196: bool = if v194 {
                false
            } else {
                let v195: bool = 30i32 >= v192;
                v195
            };
            let v197: bool = v196 == false;
            let v246: US2 = if v197 {
                US2::US2_None
            } else {
                { let _ = spiral_trace_hold(&v4); };
                let (mut v201, mut v202, mut v203, mut v204, mut v205, mut v206): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
                let v207: Rc<str> = method3(v201.clone(), v202.clone(), v203.clone(), v204.clone(), v205.clone(), v206.clone());
                let mut v208: Rc<str> = method4();
                let mut v209: usize = ((v178).len() as usize);
                let v210: Rc<str> = method145(v201, v202, v203, v204, v205, v206, v207, v208, v209);
                { let _ = spiral_trace_hold(&v4); };
                let (mut v213, mut v214, mut v215, mut v216, mut v217, mut v218): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
                let v219: i64 = v213.borrow().l0.clone();
                let v220: i64 = v219.wrapping_add(1i64);
                v213.borrow_mut().l0 = v220;
                let mut v221: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let mut v222: bool = cfg!(target_arch = "wasm32");
                if v222 {
                    let v223: Rc<str> = v216.borrow().l0.clone();
                    let v224: bool = &*v223 == "";
                    let v232: Rc<str> = if v224 {
                        v210.clone()
                    } else {
                        let mut v225: bool = &*v210 == "";
                        if v225 {
                            let mut v226: Rc<str> = v216.borrow().l0.clone();
                            v226
                        } else {
                            let v227: Rc<str> = v216.borrow().l0.clone();
                            let mut v228: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let v230: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from(format!("{}{}", v227, v228)), v210));
                            v230
                        }
                    };
                    let v234: usize = v232.chars().count();
                    let v235: i32 = ((v234) as i32);
                    let v236: i32 = v235.wrapping_add(14999i32);
                    let mut v237: i32 = v236.wrapping_div(15000i32);
                    let v238: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v239: bool = v210 != v238 ;
                    let v241: bool = if v239 {
                        let v240: bool = v237 <= 1i32;
                        v240
                    } else {
                        false
                    };
                    if v241 {
                        v216.borrow_mut().l0 = v232.clone();
                        ()
                    } else {
                        v216.borrow_mut().l0 = v238;
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v232); };
                        ()
                    }
                } else {
                    println!("{}", v210);
                    ()
                };
                let mut v244: Rc<dyn Fn(Rc<str>) -> ()> = v214.borrow().l0.clone();
                v244(v210);
                US2::US2_Some(v213, v214, v215, v216, v217, v218)
            };
            0i32
        }
    };
    if v316 != 0 { std::process::exit(v316) };
    0
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 1 });
}
