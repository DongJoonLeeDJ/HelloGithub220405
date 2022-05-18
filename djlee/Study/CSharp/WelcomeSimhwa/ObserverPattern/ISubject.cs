using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISubject
    {
        void register(IObserver o); //IObserver 구현한 객체 추가
        void unregister(IObserver o);//IObserver 구현한 객체 삭제
        void notifyObserver();//IObserver에 있는 메소드를 일괄 호출
    }
}
