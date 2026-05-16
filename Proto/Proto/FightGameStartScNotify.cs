using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightGameStartScNotify : IMessage<FightGameStartScNotify>, IMessage, IEquatable<FightGameStartScNotify>, IDeepCloneable<FightGameStartScNotify>, IBufferMessage
{
	private static readonly MessageParser<FightGameStartScNotify> _parser = new MessageParser<FightGameStartScNotify>(() => new FightGameStartScNotify());

	private UnknownFieldSet _unknownFields;

	public const int OPOGEMADLEIFieldNumber = 2;

	private IFCBCBLFALM oPOGEMADLEI_;

	public const int BIEBFHECEPMFieldNumber = 6;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_bIEBFHECEPM_codec = FieldCodec.ForMessage(50u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> bIEBFHECEPM_ = new RepeatedField<ADHNJADIJAC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightGameStartScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FightGameStartScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<ADHNJADIJAC> BIEBFHECEPM => bIEBFHECEPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameStartScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameStartScNotify(FightGameStartScNotify other)
		: this()
	{
		oPOGEMADLEI_ = ((other.oPOGEMADLEI_ != null) ? other.oPOGEMADLEI_.Clone() : null);
		bIEBFHECEPM_ = other.bIEBFHECEPM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameStartScNotify Clone()
	{
		return new FightGameStartScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FightGameStartScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightGameStartScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OPOGEMADLEI, other.OPOGEMADLEI))
		{
			return false;
		}
		if (!bIEBFHECEPM_.Equals(other.bIEBFHECEPM_))
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
		if (oPOGEMADLEI_ != null)
		{
			num ^= OPOGEMADLEI.GetHashCode();
		}
		num ^= bIEBFHECEPM_.GetHashCode();
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
		if (oPOGEMADLEI_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(OPOGEMADLEI);
		}
		bIEBFHECEPM_.WriteTo(ref output, _repeated_bIEBFHECEPM_codec);
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
		if (oPOGEMADLEI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OPOGEMADLEI);
		}
		num += bIEBFHECEPM_.CalculateSize(_repeated_bIEBFHECEPM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightGameStartScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oPOGEMADLEI_ != null)
		{
			if (oPOGEMADLEI_ == null)
			{
				OPOGEMADLEI = new IFCBCBLFALM();
			}
			OPOGEMADLEI.MergeFrom(other.OPOGEMADLEI);
		}
		bIEBFHECEPM_.Add(other.bIEBFHECEPM_);
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
				if (oPOGEMADLEI_ == null)
				{
					OPOGEMADLEI = new IFCBCBLFALM();
				}
				input.ReadMessage(OPOGEMADLEI);
				break;
			case 50u:
				bIEBFHECEPM_.AddEntriesFrom(ref input, _repeated_bIEBFHECEPM_codec);
				break;
			}
		}
	}
}
