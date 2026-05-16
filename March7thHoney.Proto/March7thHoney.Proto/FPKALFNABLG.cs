using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FPKALFNABLG : IMessage<FPKALFNABLG>, IMessage, IEquatable<FPKALFNABLG>, IDeepCloneable<FPKALFNABLG>, IBufferMessage
{
	public enum CELGHABIOONOneofCase
	{
		None = 0,
		BFNAHAIGOBH = 13,
		MPEKPBMIMCP = 15
	}

	private static readonly MessageParser<FPKALFNABLG> _parser = new MessageParser<FPKALFNABLG>(() => new FPKALFNABLG());

	private UnknownFieldSet _unknownFields;

	public const int BIKHOEGFEFDFieldNumber = 2;

	private KBOJACAEADL bIKHOEGFEFD_;

	public const int ICILBNDIDGPFieldNumber = 12;

	private bool iCILBNDIDGP_;

	public const int BFNAHAIGOBHFieldNumber = 13;

	public const int MPEKPBMIMCPFieldNumber = 15;

	private object cELGHABIOON_;

	private CELGHABIOONOneofCase cELGHABIOONCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FPKALFNABLG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FPKALFNABLGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBOJACAEADL BIKHOEGFEFD
	{
		get
		{
			return bIKHOEGFEFD_;
		}
		set
		{
			bIKHOEGFEFD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICILBNDIDGP
	{
		get
		{
			return iCILBNDIDGP_;
		}
		set
		{
			iCILBNDIDGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BFNAHAIGOBH
	{
		get
		{
			if (!HasBFNAHAIGOBH)
			{
				return 0u;
			}
			return (uint)cELGHABIOON_;
		}
		set
		{
			cELGHABIOON_ = value;
			cELGHABIOONCase_ = CELGHABIOONOneofCase.BFNAHAIGOBH;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasBFNAHAIGOBH => cELGHABIOONCase_ == CELGHABIOONOneofCase.BFNAHAIGOBH;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MPEKPBMIMCP
	{
		get
		{
			if (!HasMPEKPBMIMCP)
			{
				return false;
			}
			return (bool)cELGHABIOON_;
		}
		set
		{
			cELGHABIOON_ = value;
			cELGHABIOONCase_ = CELGHABIOONOneofCase.MPEKPBMIMCP;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMPEKPBMIMCP => cELGHABIOONCase_ == CELGHABIOONOneofCase.MPEKPBMIMCP;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CELGHABIOONOneofCase CELGHABIOONCase => cELGHABIOONCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPKALFNABLG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPKALFNABLG(FPKALFNABLG other)
		: this()
	{
		bIKHOEGFEFD_ = ((other.bIKHOEGFEFD_ != null) ? other.bIKHOEGFEFD_.Clone() : null);
		iCILBNDIDGP_ = other.iCILBNDIDGP_;
		switch (other.CELGHABIOONCase)
		{
		case CELGHABIOONOneofCase.BFNAHAIGOBH:
			BFNAHAIGOBH = other.BFNAHAIGOBH;
			break;
		case CELGHABIOONOneofCase.MPEKPBMIMCP:
			MPEKPBMIMCP = other.MPEKPBMIMCP;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPKALFNABLG Clone()
	{
		return new FPKALFNABLG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBFNAHAIGOBH()
	{
		if (HasBFNAHAIGOBH)
		{
			ClearCELGHABIOON();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMPEKPBMIMCP()
	{
		if (HasMPEKPBMIMCP)
		{
			ClearCELGHABIOON();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCELGHABIOON()
	{
		cELGHABIOONCase_ = CELGHABIOONOneofCase.None;
		cELGHABIOON_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FPKALFNABLG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FPKALFNABLG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BIKHOEGFEFD, other.BIKHOEGFEFD))
		{
			return false;
		}
		if (ICILBNDIDGP != other.ICILBNDIDGP)
		{
			return false;
		}
		if (BFNAHAIGOBH != other.BFNAHAIGOBH)
		{
			return false;
		}
		if (MPEKPBMIMCP != other.MPEKPBMIMCP)
		{
			return false;
		}
		if (CELGHABIOONCase != other.CELGHABIOONCase)
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
		if (bIKHOEGFEFD_ != null)
		{
			num ^= BIKHOEGFEFD.GetHashCode();
		}
		if (ICILBNDIDGP)
		{
			num ^= ICILBNDIDGP.GetHashCode();
		}
		if (HasBFNAHAIGOBH)
		{
			num ^= BFNAHAIGOBH.GetHashCode();
		}
		if (HasMPEKPBMIMCP)
		{
			num ^= MPEKPBMIMCP.GetHashCode();
		}
		num ^= (int)cELGHABIOONCase_;
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
		if (bIKHOEGFEFD_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BIKHOEGFEFD);
		}
		if (ICILBNDIDGP)
		{
			output.WriteRawTag(96);
			output.WriteBool(ICILBNDIDGP);
		}
		if (HasBFNAHAIGOBH)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BFNAHAIGOBH);
		}
		if (HasMPEKPBMIMCP)
		{
			output.WriteRawTag(120);
			output.WriteBool(MPEKPBMIMCP);
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
		if (bIKHOEGFEFD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BIKHOEGFEFD);
		}
		if (ICILBNDIDGP)
		{
			num += 2;
		}
		if (HasBFNAHAIGOBH)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFNAHAIGOBH);
		}
		if (HasMPEKPBMIMCP)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FPKALFNABLG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bIKHOEGFEFD_ != null)
		{
			if (bIKHOEGFEFD_ == null)
			{
				BIKHOEGFEFD = new KBOJACAEADL();
			}
			BIKHOEGFEFD.MergeFrom(other.BIKHOEGFEFD);
		}
		if (other.ICILBNDIDGP)
		{
			ICILBNDIDGP = other.ICILBNDIDGP;
		}
		switch (other.CELGHABIOONCase)
		{
		case CELGHABIOONOneofCase.BFNAHAIGOBH:
			BFNAHAIGOBH = other.BFNAHAIGOBH;
			break;
		case CELGHABIOONOneofCase.MPEKPBMIMCP:
			MPEKPBMIMCP = other.MPEKPBMIMCP;
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
			case 18u:
				if (bIKHOEGFEFD_ == null)
				{
					BIKHOEGFEFD = new KBOJACAEADL();
				}
				input.ReadMessage(BIKHOEGFEFD);
				break;
			case 96u:
				ICILBNDIDGP = input.ReadBool();
				break;
			case 104u:
				BFNAHAIGOBH = input.ReadUInt32();
				break;
			case 120u:
				MPEKPBMIMCP = input.ReadBool();
				break;
			}
		}
	}
}
