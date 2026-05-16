using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OEBJBPNNOKO : IMessage<OEBJBPNNOKO>, IMessage, IEquatable<OEBJBPNNOKO>, IDeepCloneable<OEBJBPNNOKO>, IBufferMessage
{
	private static readonly MessageParser<OEBJBPNNOKO> _parser = new MessageParser<OEBJBPNNOKO>(() => new OEBJBPNNOKO());

	private UnknownFieldSet _unknownFields;

	public const int IACKOCPGIAKFieldNumber = 4;

	private MACJBIAFNOI iACKOCPGIAK_;

	public const int SummonedPetIdFieldNumber = 6;

	private uint summonedPetId_;

	public const int UidFieldNumber = 8;

	private uint uid_;

	public const int CGLMHJFCFPHFieldNumber = 11;

	private PlayerSimpleInfo cGLMHJFCFPH_;

	public const int EKODIFJOBFBFieldNumber = 12;

	private long eKODIFJOBFB_;

	public const int HCJMLMIGACGFieldNumber = 13;

	private bool hCJMLMIGACG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OEBJBPNNOKO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OEBJBPNNOKOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MACJBIAFNOI IACKOCPGIAK
	{
		get
		{
			return iACKOCPGIAK_;
		}
		set
		{
			iACKOCPGIAK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SummonedPetId
	{
		get
		{
			return summonedPetId_;
		}
		set
		{
			summonedPetId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSimpleInfo CGLMHJFCFPH
	{
		get
		{
			return cGLMHJFCFPH_;
		}
		set
		{
			cGLMHJFCFPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EKODIFJOBFB
	{
		get
		{
			return eKODIFJOBFB_;
		}
		set
		{
			eKODIFJOBFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HCJMLMIGACG
	{
		get
		{
			return hCJMLMIGACG_;
		}
		set
		{
			hCJMLMIGACG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBJBPNNOKO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBJBPNNOKO(OEBJBPNNOKO other)
		: this()
	{
		iACKOCPGIAK_ = ((other.iACKOCPGIAK_ != null) ? other.iACKOCPGIAK_.Clone() : null);
		summonedPetId_ = other.summonedPetId_;
		uid_ = other.uid_;
		cGLMHJFCFPH_ = ((other.cGLMHJFCFPH_ != null) ? other.cGLMHJFCFPH_.Clone() : null);
		eKODIFJOBFB_ = other.eKODIFJOBFB_;
		hCJMLMIGACG_ = other.hCJMLMIGACG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEBJBPNNOKO Clone()
	{
		return new OEBJBPNNOKO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OEBJBPNNOKO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OEBJBPNNOKO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IACKOCPGIAK, other.IACKOCPGIAK))
		{
			return false;
		}
		if (SummonedPetId != other.SummonedPetId)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (!object.Equals(CGLMHJFCFPH, other.CGLMHJFCFPH))
		{
			return false;
		}
		if (EKODIFJOBFB != other.EKODIFJOBFB)
		{
			return false;
		}
		if (HCJMLMIGACG != other.HCJMLMIGACG)
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
		if (iACKOCPGIAK_ != null)
		{
			num ^= IACKOCPGIAK.GetHashCode();
		}
		if (SummonedPetId != 0)
		{
			num ^= SummonedPetId.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (cGLMHJFCFPH_ != null)
		{
			num ^= CGLMHJFCFPH.GetHashCode();
		}
		if (EKODIFJOBFB != 0L)
		{
			num ^= EKODIFJOBFB.GetHashCode();
		}
		if (HCJMLMIGACG)
		{
			num ^= HCJMLMIGACG.GetHashCode();
		}
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
		if (iACKOCPGIAK_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(IACKOCPGIAK);
		}
		if (SummonedPetId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(SummonedPetId);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Uid);
		}
		if (cGLMHJFCFPH_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CGLMHJFCFPH);
		}
		if (EKODIFJOBFB != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(EKODIFJOBFB);
		}
		if (HCJMLMIGACG)
		{
			output.WriteRawTag(104);
			output.WriteBool(HCJMLMIGACG);
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
		if (iACKOCPGIAK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IACKOCPGIAK);
		}
		if (SummonedPetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SummonedPetId);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (cGLMHJFCFPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CGLMHJFCFPH);
		}
		if (EKODIFJOBFB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EKODIFJOBFB);
		}
		if (HCJMLMIGACG)
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
	public void MergeFrom(OEBJBPNNOKO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iACKOCPGIAK_ != null)
		{
			if (iACKOCPGIAK_ == null)
			{
				IACKOCPGIAK = new MACJBIAFNOI();
			}
			IACKOCPGIAK.MergeFrom(other.IACKOCPGIAK);
		}
		if (other.SummonedPetId != 0)
		{
			SummonedPetId = other.SummonedPetId;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.cGLMHJFCFPH_ != null)
		{
			if (cGLMHJFCFPH_ == null)
			{
				CGLMHJFCFPH = new PlayerSimpleInfo();
			}
			CGLMHJFCFPH.MergeFrom(other.CGLMHJFCFPH);
		}
		if (other.EKODIFJOBFB != 0L)
		{
			EKODIFJOBFB = other.EKODIFJOBFB;
		}
		if (other.HCJMLMIGACG)
		{
			HCJMLMIGACG = other.HCJMLMIGACG;
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
			case 34u:
				if (iACKOCPGIAK_ == null)
				{
					IACKOCPGIAK = new MACJBIAFNOI();
				}
				input.ReadMessage(IACKOCPGIAK);
				break;
			case 48u:
				SummonedPetId = input.ReadUInt32();
				break;
			case 64u:
				Uid = input.ReadUInt32();
				break;
			case 90u:
				if (cGLMHJFCFPH_ == null)
				{
					CGLMHJFCFPH = new PlayerSimpleInfo();
				}
				input.ReadMessage(CGLMHJFCFPH);
				break;
			case 96u:
				EKODIFJOBFB = input.ReadInt64();
				break;
			case 104u:
				HCJMLMIGACG = input.ReadBool();
				break;
			}
		}
	}
}
