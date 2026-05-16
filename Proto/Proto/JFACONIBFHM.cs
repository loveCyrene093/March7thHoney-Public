using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JFACONIBFHM : IMessage<JFACONIBFHM>, IMessage, IEquatable<JFACONIBFHM>, IDeepCloneable<JFACONIBFHM>, IBufferMessage
{
	private static readonly MessageParser<JFACONIBFHM> _parser = new MessageParser<JFACONIBFHM>(() => new JFACONIBFHM());

	private UnknownFieldSet _unknownFields;

	public const int GridFightTraitInfoFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_gridFightTraitInfo_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> gridFightTraitInfo_ = new RepeatedField<uint>();

	public const int EONENLLBGENFieldNumber = 12;

	private static readonly FieldCodec<OEGICCFGHJE> _repeated_eONENLLBGEN_codec = FieldCodec.ForMessage(98u, OEGICCFGHJE.Parser);

	private readonly RepeatedField<OEGICCFGHJE> eONENLLBGEN_ = new RepeatedField<OEGICCFGHJE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JFACONIBFHM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JFACONIBFHMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightTraitInfo => gridFightTraitInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OEGICCFGHJE> EONENLLBGEN => eONENLLBGEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFACONIBFHM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFACONIBFHM(JFACONIBFHM other)
		: this()
	{
		gridFightTraitInfo_ = other.gridFightTraitInfo_.Clone();
		eONENLLBGEN_ = other.eONENLLBGEN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFACONIBFHM Clone()
	{
		return new JFACONIBFHM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JFACONIBFHM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JFACONIBFHM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightTraitInfo_.Equals(other.gridFightTraitInfo_))
		{
			return false;
		}
		if (!eONENLLBGEN_.Equals(other.eONENLLBGEN_))
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
		num ^= gridFightTraitInfo_.GetHashCode();
		num ^= eONENLLBGEN_.GetHashCode();
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
		gridFightTraitInfo_.WriteTo(ref output, _repeated_gridFightTraitInfo_codec);
		eONENLLBGEN_.WriteTo(ref output, _repeated_eONENLLBGEN_codec);
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
		num += gridFightTraitInfo_.CalculateSize(_repeated_gridFightTraitInfo_codec);
		num += eONENLLBGEN_.CalculateSize(_repeated_eONENLLBGEN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JFACONIBFHM other)
	{
		if (other != null)
		{
			gridFightTraitInfo_.Add(other.gridFightTraitInfo_);
			eONENLLBGEN_.Add(other.eONENLLBGEN_);
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
			case 40u:
			case 42u:
				gridFightTraitInfo_.AddEntriesFrom(ref input, _repeated_gridFightTraitInfo_codec);
				break;
			case 98u:
				eONENLLBGEN_.AddEntriesFrom(ref input, _repeated_eONENLLBGEN_codec);
				break;
			}
		}
	}
}
