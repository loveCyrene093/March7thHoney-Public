using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCHJABAFADH : IMessage<PCHJABAFADH>, IMessage, IEquatable<PCHJABAFADH>, IDeepCloneable<PCHJABAFADH>, IBufferMessage
{
	public enum MBLKGBAGBKBOneofCase
	{
		None = 0,
		ONBLFPHLGNB = 1,
		NOCOJNOPNJG = 3,
		PFFIJEHMDHE = 5,
		IEKICNFCCEP = 11,
		DPEMFGABBAB = 12
	}

	private static readonly MessageParser<PCHJABAFADH> _parser = new MessageParser<PCHJABAFADH>(() => new PCHJABAFADH());

	private UnknownFieldSet _unknownFields;

	public const int ONBLFPHLGNBFieldNumber = 1;

	public const int NOCOJNOPNJGFieldNumber = 3;

	public const int PFFIJEHMDHEFieldNumber = 5;

	public const int IEKICNFCCEPFieldNumber = 11;

	public const int DPEMFGABBABFieldNumber = 12;

	private object mBLKGBAGBKB_;

	private MBLKGBAGBKBOneofCase mBLKGBAGBKBCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCHJABAFADH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCHJABAFADHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHOLCOMMDEB ONBLFPHLGNB
	{
		get
		{
			if (mBLKGBAGBKBCase_ != MBLKGBAGBKBOneofCase.ONBLFPHLGNB)
			{
				return null;
			}
			return (KHOLCOMMDEB)mBLKGBAGBKB_;
		}
		set
		{
			mBLKGBAGBKB_ = value;
			mBLKGBAGBKBCase_ = ((value != null) ? MBLKGBAGBKBOneofCase.ONBLFPHLGNB : MBLKGBAGBKBOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONDOIAABCDG NOCOJNOPNJG
	{
		get
		{
			if (mBLKGBAGBKBCase_ != MBLKGBAGBKBOneofCase.NOCOJNOPNJG)
			{
				return null;
			}
			return (ONDOIAABCDG)mBLKGBAGBKB_;
		}
		set
		{
			mBLKGBAGBKB_ = value;
			mBLKGBAGBKBCase_ = ((value != null) ? MBLKGBAGBKBOneofCase.NOCOJNOPNJG : MBLKGBAGBKBOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILKOFGPOFIA PFFIJEHMDHE
	{
		get
		{
			if (mBLKGBAGBKBCase_ != MBLKGBAGBKBOneofCase.PFFIJEHMDHE)
			{
				return null;
			}
			return (ILKOFGPOFIA)mBLKGBAGBKB_;
		}
		set
		{
			mBLKGBAGBKB_ = value;
			mBLKGBAGBKBCase_ = ((value != null) ? MBLKGBAGBKBOneofCase.PFFIJEHMDHE : MBLKGBAGBKBOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDPFOINNLOM IEKICNFCCEP
	{
		get
		{
			if (mBLKGBAGBKBCase_ != MBLKGBAGBKBOneofCase.IEKICNFCCEP)
			{
				return null;
			}
			return (FDPFOINNLOM)mBLKGBAGBKB_;
		}
		set
		{
			mBLKGBAGBKB_ = value;
			mBLKGBAGBKBCase_ = ((value != null) ? MBLKGBAGBKBOneofCase.IEKICNFCCEP : MBLKGBAGBKBOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALBHOIEJOIN DPEMFGABBAB
	{
		get
		{
			if (mBLKGBAGBKBCase_ != MBLKGBAGBKBOneofCase.DPEMFGABBAB)
			{
				return null;
			}
			return (ALBHOIEJOIN)mBLKGBAGBKB_;
		}
		set
		{
			mBLKGBAGBKB_ = value;
			mBLKGBAGBKBCase_ = ((value != null) ? MBLKGBAGBKBOneofCase.DPEMFGABBAB : MBLKGBAGBKBOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBLKGBAGBKBOneofCase MBLKGBAGBKBCase => mBLKGBAGBKBCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCHJABAFADH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCHJABAFADH(PCHJABAFADH other)
		: this()
	{
		switch (other.MBLKGBAGBKBCase)
		{
		case MBLKGBAGBKBOneofCase.ONBLFPHLGNB:
			ONBLFPHLGNB = other.ONBLFPHLGNB.Clone();
			break;
		case MBLKGBAGBKBOneofCase.NOCOJNOPNJG:
			NOCOJNOPNJG = other.NOCOJNOPNJG.Clone();
			break;
		case MBLKGBAGBKBOneofCase.PFFIJEHMDHE:
			PFFIJEHMDHE = other.PFFIJEHMDHE.Clone();
			break;
		case MBLKGBAGBKBOneofCase.IEKICNFCCEP:
			IEKICNFCCEP = other.IEKICNFCCEP.Clone();
			break;
		case MBLKGBAGBKBOneofCase.DPEMFGABBAB:
			DPEMFGABBAB = other.DPEMFGABBAB.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCHJABAFADH Clone()
	{
		return new PCHJABAFADH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMBLKGBAGBKB()
	{
		mBLKGBAGBKBCase_ = MBLKGBAGBKBOneofCase.None;
		mBLKGBAGBKB_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCHJABAFADH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCHJABAFADH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ONBLFPHLGNB, other.ONBLFPHLGNB))
		{
			return false;
		}
		if (!object.Equals(NOCOJNOPNJG, other.NOCOJNOPNJG))
		{
			return false;
		}
		if (!object.Equals(PFFIJEHMDHE, other.PFFIJEHMDHE))
		{
			return false;
		}
		if (!object.Equals(IEKICNFCCEP, other.IEKICNFCCEP))
		{
			return false;
		}
		if (!object.Equals(DPEMFGABBAB, other.DPEMFGABBAB))
		{
			return false;
		}
		if (MBLKGBAGBKBCase != other.MBLKGBAGBKBCase)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.ONBLFPHLGNB)
		{
			num ^= ONBLFPHLGNB.GetHashCode();
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.NOCOJNOPNJG)
		{
			num ^= NOCOJNOPNJG.GetHashCode();
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.PFFIJEHMDHE)
		{
			num ^= PFFIJEHMDHE.GetHashCode();
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.IEKICNFCCEP)
		{
			num ^= IEKICNFCCEP.GetHashCode();
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.DPEMFGABBAB)
		{
			num ^= DPEMFGABBAB.GetHashCode();
		}
		num ^= (int)mBLKGBAGBKBCase_;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.ONBLFPHLGNB)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ONBLFPHLGNB);
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.NOCOJNOPNJG)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NOCOJNOPNJG);
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.PFFIJEHMDHE)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PFFIJEHMDHE);
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.IEKICNFCCEP)
		{
			output.WriteRawTag(90);
			output.WriteMessage(IEKICNFCCEP);
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.DPEMFGABBAB)
		{
			output.WriteRawTag(98);
			output.WriteMessage(DPEMFGABBAB);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.ONBLFPHLGNB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ONBLFPHLGNB);
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.NOCOJNOPNJG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NOCOJNOPNJG);
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.PFFIJEHMDHE)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PFFIJEHMDHE);
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.IEKICNFCCEP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IEKICNFCCEP);
		}
		if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.DPEMFGABBAB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DPEMFGABBAB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCHJABAFADH other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.MBLKGBAGBKBCase)
		{
		case MBLKGBAGBKBOneofCase.ONBLFPHLGNB:
			if (ONBLFPHLGNB == null)
			{
				ONBLFPHLGNB = new KHOLCOMMDEB();
			}
			ONBLFPHLGNB.MergeFrom(other.ONBLFPHLGNB);
			break;
		case MBLKGBAGBKBOneofCase.NOCOJNOPNJG:
			if (NOCOJNOPNJG == null)
			{
				NOCOJNOPNJG = new ONDOIAABCDG();
			}
			NOCOJNOPNJG.MergeFrom(other.NOCOJNOPNJG);
			break;
		case MBLKGBAGBKBOneofCase.PFFIJEHMDHE:
			if (PFFIJEHMDHE == null)
			{
				PFFIJEHMDHE = new ILKOFGPOFIA();
			}
			PFFIJEHMDHE.MergeFrom(other.PFFIJEHMDHE);
			break;
		case MBLKGBAGBKBOneofCase.IEKICNFCCEP:
			if (IEKICNFCCEP == null)
			{
				IEKICNFCCEP = new FDPFOINNLOM();
			}
			IEKICNFCCEP.MergeFrom(other.IEKICNFCCEP);
			break;
		case MBLKGBAGBKBOneofCase.DPEMFGABBAB:
			if (DPEMFGABBAB == null)
			{
				DPEMFGABBAB = new ALBHOIEJOIN();
			}
			DPEMFGABBAB.MergeFrom(other.DPEMFGABBAB);
			break;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
			{
				KHOLCOMMDEB kHOLCOMMDEB = new KHOLCOMMDEB();
				if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.ONBLFPHLGNB)
				{
					kHOLCOMMDEB.MergeFrom(ONBLFPHLGNB);
				}
				input.ReadMessage(kHOLCOMMDEB);
				ONBLFPHLGNB = kHOLCOMMDEB;
				break;
			}
			case 26u:
			{
				ONDOIAABCDG oNDOIAABCDG = new ONDOIAABCDG();
				if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.NOCOJNOPNJG)
				{
					oNDOIAABCDG.MergeFrom(NOCOJNOPNJG);
				}
				input.ReadMessage(oNDOIAABCDG);
				NOCOJNOPNJG = oNDOIAABCDG;
				break;
			}
			case 42u:
			{
				ILKOFGPOFIA iLKOFGPOFIA = new ILKOFGPOFIA();
				if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.PFFIJEHMDHE)
				{
					iLKOFGPOFIA.MergeFrom(PFFIJEHMDHE);
				}
				input.ReadMessage(iLKOFGPOFIA);
				PFFIJEHMDHE = iLKOFGPOFIA;
				break;
			}
			case 90u:
			{
				FDPFOINNLOM fDPFOINNLOM = new FDPFOINNLOM();
				if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.IEKICNFCCEP)
				{
					fDPFOINNLOM.MergeFrom(IEKICNFCCEP);
				}
				input.ReadMessage(fDPFOINNLOM);
				IEKICNFCCEP = fDPFOINNLOM;
				break;
			}
			case 98u:
			{
				ALBHOIEJOIN aLBHOIEJOIN = new ALBHOIEJOIN();
				if (mBLKGBAGBKBCase_ == MBLKGBAGBKBOneofCase.DPEMFGABBAB)
				{
					aLBHOIEJOIN.MergeFrom(DPEMFGABBAB);
				}
				input.ReadMessage(aLBHOIEJOIN);
				DPEMFGABBAB = aLBHOIEJOIN;
				break;
			}
			}
		}
	}
}
