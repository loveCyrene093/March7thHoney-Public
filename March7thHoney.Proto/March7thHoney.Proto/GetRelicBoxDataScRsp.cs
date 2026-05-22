using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRelicBoxDataScRsp : IMessage<GetRelicBoxDataScRsp>, IMessage, IEquatable<GetRelicBoxDataScRsp>, IDeepCloneable<GetRelicBoxDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRelicBoxDataScRsp> _parser = new MessageParser<GetRelicBoxDataScRsp>(() => new GetRelicBoxDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OHEKDKJCOFDFieldNumber = 2;

	private PGLFACHCGCB oHEKDKJCOFD_;

	public const int KKHBAPABFJCFieldNumber = 4;

	private GMONEHJIKMA kKHBAPABFJC_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int IAHIEBCFPCDFieldNumber = 6;

	private static readonly FieldCodec<NBIOEKILHEN> _repeated_iAHIEBCFPCD_codec = FieldCodec.ForMessage(50u, NBIOEKILHEN.Parser);

	private readonly RepeatedField<NBIOEKILHEN> iAHIEBCFPCD_ = new RepeatedField<NBIOEKILHEN>();

	public const int GEJAPCKOHIGFieldNumber = 7;

	private uint gEJAPCKOHIG_;

	public const int GPEAFAJGCPHFieldNumber = 12;

	private OMHAOBFKIKE gPEAFAJGCPH_;

	public const int KAIMHOJAAKPFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_kAIMHOJAAKP_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> kAIMHOJAAKP_ = new RepeatedField<uint>();

	public const int StateFieldNumber = 15;

	private JHHBIOJHEGL state_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRelicBoxDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRelicBoxDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGLFACHCGCB OHEKDKJCOFD
	{
		get
		{
			return oHEKDKJCOFD_;
		}
		set
		{
			oHEKDKJCOFD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMONEHJIKMA KKHBAPABFJC
	{
		get
		{
			return kKHBAPABFJC_;
		}
		set
		{
			kKHBAPABFJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NBIOEKILHEN> IAHIEBCFPCD => iAHIEBCFPCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GEJAPCKOHIG
	{
		get
		{
			return gEJAPCKOHIG_;
		}
		set
		{
			gEJAPCKOHIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMHAOBFKIKE GPEAFAJGCPH
	{
		get
		{
			return gPEAFAJGCPH_;
		}
		set
		{
			gPEAFAJGCPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KAIMHOJAAKP => kAIMHOJAAKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHHBIOJHEGL State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRelicBoxDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRelicBoxDataScRsp(GetRelicBoxDataScRsp other)
		: this()
	{
		oHEKDKJCOFD_ = ((other.oHEKDKJCOFD_ != null) ? other.oHEKDKJCOFD_.Clone() : null);
		kKHBAPABFJC_ = ((other.kKHBAPABFJC_ != null) ? other.kKHBAPABFJC_.Clone() : null);
		retcode_ = other.retcode_;
		iAHIEBCFPCD_ = other.iAHIEBCFPCD_.Clone();
		gEJAPCKOHIG_ = other.gEJAPCKOHIG_;
		gPEAFAJGCPH_ = ((other.gPEAFAJGCPH_ != null) ? other.gPEAFAJGCPH_.Clone() : null);
		kAIMHOJAAKP_ = other.kAIMHOJAAKP_.Clone();
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRelicBoxDataScRsp Clone()
	{
		return new GetRelicBoxDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRelicBoxDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRelicBoxDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OHEKDKJCOFD, other.OHEKDKJCOFD))
		{
			return false;
		}
		if (!object.Equals(KKHBAPABFJC, other.KKHBAPABFJC))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!iAHIEBCFPCD_.Equals(other.iAHIEBCFPCD_))
		{
			return false;
		}
		if (GEJAPCKOHIG != other.GEJAPCKOHIG)
		{
			return false;
		}
		if (!object.Equals(GPEAFAJGCPH, other.GPEAFAJGCPH))
		{
			return false;
		}
		if (!kAIMHOJAAKP_.Equals(other.kAIMHOJAAKP_))
		{
			return false;
		}
		if (State != other.State)
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
		if (oHEKDKJCOFD_ != null)
		{
			num ^= OHEKDKJCOFD.GetHashCode();
		}
		if (kKHBAPABFJC_ != null)
		{
			num ^= KKHBAPABFJC.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= iAHIEBCFPCD_.GetHashCode();
		if (GEJAPCKOHIG != 0)
		{
			num ^= GEJAPCKOHIG.GetHashCode();
		}
		if (gPEAFAJGCPH_ != null)
		{
			num ^= GPEAFAJGCPH.GetHashCode();
		}
		num ^= kAIMHOJAAKP_.GetHashCode();
		if (State != JHHBIOJHEGL.Clphmajjila)
		{
			num ^= State.GetHashCode();
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
		if (oHEKDKJCOFD_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(OHEKDKJCOFD);
		}
		if (kKHBAPABFJC_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(KKHBAPABFJC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		iAHIEBCFPCD_.WriteTo(ref output, _repeated_iAHIEBCFPCD_codec);
		if (GEJAPCKOHIG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GEJAPCKOHIG);
		}
		if (gPEAFAJGCPH_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(GPEAFAJGCPH);
		}
		kAIMHOJAAKP_.WriteTo(ref output, _repeated_kAIMHOJAAKP_codec);
		if (State != JHHBIOJHEGL.Clphmajjila)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)State);
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
		if (oHEKDKJCOFD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OHEKDKJCOFD);
		}
		if (kKHBAPABFJC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KKHBAPABFJC);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += iAHIEBCFPCD_.CalculateSize(_repeated_iAHIEBCFPCD_codec);
		if (GEJAPCKOHIG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GEJAPCKOHIG);
		}
		if (gPEAFAJGCPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GPEAFAJGCPH);
		}
		num += kAIMHOJAAKP_.CalculateSize(_repeated_kAIMHOJAAKP_codec);
		if (State != JHHBIOJHEGL.Clphmajjila)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRelicBoxDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oHEKDKJCOFD_ != null)
		{
			if (oHEKDKJCOFD_ == null)
			{
				OHEKDKJCOFD = new PGLFACHCGCB();
			}
			OHEKDKJCOFD.MergeFrom(other.OHEKDKJCOFD);
		}
		if (other.kKHBAPABFJC_ != null)
		{
			if (kKHBAPABFJC_ == null)
			{
				KKHBAPABFJC = new GMONEHJIKMA();
			}
			KKHBAPABFJC.MergeFrom(other.KKHBAPABFJC);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		iAHIEBCFPCD_.Add(other.iAHIEBCFPCD_);
		if (other.GEJAPCKOHIG != 0)
		{
			GEJAPCKOHIG = other.GEJAPCKOHIG;
		}
		if (other.gPEAFAJGCPH_ != null)
		{
			if (gPEAFAJGCPH_ == null)
			{
				GPEAFAJGCPH = new OMHAOBFKIKE();
			}
			GPEAFAJGCPH.MergeFrom(other.GPEAFAJGCPH);
		}
		kAIMHOJAAKP_.Add(other.kAIMHOJAAKP_);
		if (other.State != JHHBIOJHEGL.Clphmajjila)
		{
			State = other.State;
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
				if (oHEKDKJCOFD_ == null)
				{
					OHEKDKJCOFD = new PGLFACHCGCB();
				}
				input.ReadMessage(OHEKDKJCOFD);
				break;
			case 34u:
				if (kKHBAPABFJC_ == null)
				{
					KKHBAPABFJC = new GMONEHJIKMA();
				}
				input.ReadMessage(KKHBAPABFJC);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 50u:
				iAHIEBCFPCD_.AddEntriesFrom(ref input, _repeated_iAHIEBCFPCD_codec);
				break;
			case 56u:
				GEJAPCKOHIG = input.ReadUInt32();
				break;
			case 98u:
				if (gPEAFAJGCPH_ == null)
				{
					GPEAFAJGCPH = new OMHAOBFKIKE();
				}
				input.ReadMessage(GPEAFAJGCPH);
				break;
			case 112u:
			case 114u:
				kAIMHOJAAKP_.AddEntriesFrom(ref input, _repeated_kAIMHOJAAKP_codec);
				break;
			case 120u:
				State = (JHHBIOJHEGL)input.ReadEnum();
				break;
			}
		}
	}
}
