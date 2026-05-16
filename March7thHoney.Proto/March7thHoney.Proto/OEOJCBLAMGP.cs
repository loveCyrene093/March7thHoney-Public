using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OEOJCBLAMGP : IMessage<OEOJCBLAMGP>, IMessage, IEquatable<OEOJCBLAMGP>, IDeepCloneable<OEOJCBLAMGP>, IBufferMessage
{
	private static readonly MessageParser<OEOJCBLAMGP> _parser = new MessageParser<OEOJCBLAMGP>(() => new OEOJCBLAMGP());

	private UnknownFieldSet _unknownFields;

	public const int IEBFIIPBADJFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_iEBFIIPBADJ_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> iEBFIIPBADJ_ = new RepeatedField<uint>();

	public const int OPFEKAKFNJMFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_oPFEKAKFNJM_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> oPFEKAKFNJM_ = new RepeatedField<uint>();

	public const int ANAHLHJDDDCFieldNumber = 13;

	private static readonly FieldCodec<LimaoNewsOfficeSurveyState> _repeated_aNAHLHJDDDC_codec = FieldCodec.ForEnum(106u, (LimaoNewsOfficeSurveyState x) => (int)x, (int x) => (LimaoNewsOfficeSurveyState)x);

	private readonly RepeatedField<LimaoNewsOfficeSurveyState> aNAHLHJDDDC_ = new RepeatedField<LimaoNewsOfficeSurveyState>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OEOJCBLAMGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OEOJCBLAMGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IEBFIIPBADJ => iEBFIIPBADJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OPFEKAKFNJM => oPFEKAKFNJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LimaoNewsOfficeSurveyState> ANAHLHJDDDC => aNAHLHJDDDC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEOJCBLAMGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEOJCBLAMGP(OEOJCBLAMGP other)
		: this()
	{
		iEBFIIPBADJ_ = other.iEBFIIPBADJ_.Clone();
		oPFEKAKFNJM_ = other.oPFEKAKFNJM_.Clone();
		aNAHLHJDDDC_ = other.aNAHLHJDDDC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEOJCBLAMGP Clone()
	{
		return new OEOJCBLAMGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OEOJCBLAMGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OEOJCBLAMGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iEBFIIPBADJ_.Equals(other.iEBFIIPBADJ_))
		{
			return false;
		}
		if (!oPFEKAKFNJM_.Equals(other.oPFEKAKFNJM_))
		{
			return false;
		}
		if (!aNAHLHJDDDC_.Equals(other.aNAHLHJDDDC_))
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
		num ^= iEBFIIPBADJ_.GetHashCode();
		num ^= oPFEKAKFNJM_.GetHashCode();
		num ^= aNAHLHJDDDC_.GetHashCode();
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
		iEBFIIPBADJ_.WriteTo(ref output, _repeated_iEBFIIPBADJ_codec);
		oPFEKAKFNJM_.WriteTo(ref output, _repeated_oPFEKAKFNJM_codec);
		aNAHLHJDDDC_.WriteTo(ref output, _repeated_aNAHLHJDDDC_codec);
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
		num += iEBFIIPBADJ_.CalculateSize(_repeated_iEBFIIPBADJ_codec);
		num += oPFEKAKFNJM_.CalculateSize(_repeated_oPFEKAKFNJM_codec);
		num += aNAHLHJDDDC_.CalculateSize(_repeated_aNAHLHJDDDC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OEOJCBLAMGP other)
	{
		if (other != null)
		{
			iEBFIIPBADJ_.Add(other.iEBFIIPBADJ_);
			oPFEKAKFNJM_.Add(other.oPFEKAKFNJM_);
			aNAHLHJDDDC_.Add(other.aNAHLHJDDDC_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 32u:
			case 34u:
				iEBFIIPBADJ_.AddEntriesFrom(ref input, _repeated_iEBFIIPBADJ_codec);
				break;
			case 48u:
			case 50u:
				oPFEKAKFNJM_.AddEntriesFrom(ref input, _repeated_oPFEKAKFNJM_codec);
				break;
			case 104u:
			case 106u:
				aNAHLHJDDDC_.AddEntriesFrom(ref input, _repeated_aNAHLHJDDDC_codec);
				break;
			}
		}
	}
}
