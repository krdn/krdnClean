## Infrastructure Project

클린 아키텍처에서 인프라 관련 사항은 핵심 비즈니스 규칙(또는 DDD의 도메인 모델)과 분리되어 유지됩니다.

EF, 파일, 이메일, 웹 서비스, Azure/AWS/GCP 등과 관련된 코드가 있어야 하는 유일한 프로젝트는 Infrastructure입니다.

인프라는 추상화(인터페이스)가 존재하는 코어(그리고 선택적으로 사용 사례)에 의존해야 합니다.

인프라 클래스는 코어(사용 사례) 프로젝트에 있는 인터페이스를 구현합니다.

이러한 구현은 시작 시 DI를 사용하여 연결됩니다. 이 경우 각 프로젝트에 정의된 Autofac 및 모듈 클래스를 사용합니다.

도움이 필요하신가요? 여기에서 샘플을 확인하세요:
https://github.com/ardalis/CleanArchitecture/sample

Still need help?
Contact us at https://nimblepros.com
