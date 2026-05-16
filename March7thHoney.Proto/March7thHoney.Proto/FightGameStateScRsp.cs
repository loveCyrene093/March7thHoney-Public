using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightGameStateScRsp : IMessage<FightGameStateScRsp>, IMessage, IEquatable<FightGameStateScRsp>, IDeepCloneable<FightGameStateScRsp>, IBufferMessage
{
	private static readonly MessageParser<FightGameStateScRsp> _parser = new MessageParser<FightGameStateScRsp>(() => new FightGameStateScRsp());

	private UnknownFieldSet _unknownFields;

	public const int POFOCMIHJIAFieldNumber = 9;

	private JLGNKMBMPKL pOFOCMIHJIA_;

	public const int BIEBFHECEPMFieldNumber = 11;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_bIEBFHECEPM_codec = FieldCodec.ForMessage(90u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> bIEBFHECEPM_ = new RepeatedField<ADHNJADIJAC>();

	public const int OPOGEMADLEIFieldNumber = 12;

	private IFCBCBLFALM oPOGEMADLEI_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightGameStateScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FightGameStateScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLGNKMBMPKL POFOCMIHJIA
	{
		get
		{
			return pOFOCMIHJIA_;
		}
		set
		{
			pOFOCMIHJIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADHNJADIJAC> BIEBFHECEPM => bIEBFHECEPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFCBCBLFALM OPOGEMADLEI
	{
		get
		{
			return oPOGEMADLEI_;
		}
		set
		{
			oPOGEMADLEI_ = value;
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
	public FightGameStateScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameStateScRsp(FightGameStateScRsp other)
		: this()
	{
		pOFOCMIHJIA_ = ((other.pOFOCMIHJIA_ != null) ? other.pOFOCMIHJIA_.Clone() : null);
		bIEBFHECEPM_ = other.bIEBFHECEPM_.Clone();
		oPOGEMADLEI_ = ((other.oPOGEMADLEI_ != null) ? other.oPOGEMADLEI_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameStateScRsp Clone()
	{
		return new FightGameStateScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FightGameStateScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightGameStateScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(POFOCMIHJIA, other.POFOCMIHJIA))
		{
			return false;
		}
		if (!bIEBFHECEPM_.Equals(other.bIEBFHECEPM_))
		{
			return false;
		}
		if (!object.Equals(OPOGEMADLEI, other.OPOGEMADLEI))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (pOFOCMIHJIA_ != null)
		{
			num ^= POFOCMIHJIA.GetHashCode();
		}
		num ^= bIEBFHECEPM_.GetHashCode();
		if (oPOGEMADLEI_ != null)
		{
			num ^= OPOGEMADLEI.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (pOFOCMIHJIA_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(POFOCMIHJIA);
		}
		bIEBFHECEPM_.WriteTo(ref output, _repeated_bIEBFHECEPM_codec);
		if (oPOGEMADLEI_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(OPOGEMADLEI);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (pOFOCMIHJIA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(POFOCMIHJIA);
		}
		num += bIEBFHECEPM_.CalculateSize(_repeated_bIEBFHECEPM_codec);
		if (oPOGEMADLEI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OPOGEMADLEI);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightGameStateScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pOFOCMIHJIA_ != null)
		{
			if (pOFOCMIHJIA_ == null)
			{
				POFOCMIHJIA = new JLGNKMBMPKL();
			}
			POFOCMIHJIA.MergeFrom(other.POFOCMIHJIA);
		}
		bIEBFHECEPM_.Add(other.bIEBFHECEPM_);
		if (other.oPOGEMADLEI_ != null)
		{
			if (oPOGEMADLEI_ == null)
			{
				OPOGEMADLEI = new IFCBCBLFALM();
			}
			OPOGEMADLEI.MergeFrom(other.OPOGEMADLEI);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 74u:
				if (pOFOCMIHJIA_ == null)
				{
					POFOCMIHJIA = new JLGNKMBMPKL();
				}
				input.ReadMessage(POFOCMIHJIA);
				break;
			case 90u:
				bIEBFHECEPM_.AddEntriesFrom(ref input, _repeated_bIEBFHECEPM_codec);
				break;
			case 98u:
				if (oPOGEMADLEI_ == null)
				{
					OPOGEMADLEI = new IFCBCBLFALM();
				}
				input.ReadMessage(OPOGEMADLEI);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
