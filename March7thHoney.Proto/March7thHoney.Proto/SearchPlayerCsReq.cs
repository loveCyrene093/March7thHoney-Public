using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SearchPlayerCsReq : IMessage<SearchPlayerCsReq>, IMessage, IEquatable<SearchPlayerCsReq>, IDeepCloneable<SearchPlayerCsReq>, IBufferMessage
{
	private static readonly MessageParser<SearchPlayerCsReq> _parser = new MessageParser<SearchPlayerCsReq>(() => new SearchPlayerCsReq());

	private UnknownFieldSet _unknownFields;

	public const int UidListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_uidList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> uidList_ = new RepeatedField<uint>();

	public const int ICHENOJECAPFieldNumber = 9;

	private bool iCHENOJECAP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SearchPlayerCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SearchPlayerCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UidList => uidList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICHENOJECAP
	{
		get
		{
			return iCHENOJECAP_;
		}
		set
		{
			iCHENOJECAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SearchPlayerCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SearchPlayerCsReq(SearchPlayerCsReq other)
		: this()
	{
		uidList_ = other.uidList_.Clone();
		iCHENOJECAP_ = other.iCHENOJECAP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SearchPlayerCsReq Clone()
	{
		return new SearchPlayerCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SearchPlayerCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SearchPlayerCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!uidList_.Equals(other.uidList_))
		{
			return false;
		}
		if (ICHENOJECAP != other.ICHENOJECAP)
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
		num ^= uidList_.GetHashCode();
		if (ICHENOJECAP)
		{
			num ^= ICHENOJECAP.GetHashCode();
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
		uidList_.WriteTo(ref output, _repeated_uidList_codec);
		if (ICHENOJECAP)
		{
			output.WriteRawTag(72);
			output.WriteBool(ICHENOJECAP);
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
		num += uidList_.CalculateSize(_repeated_uidList_codec);
		if (ICHENOJECAP)
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
	public void MergeFrom(SearchPlayerCsReq other)
	{
		if (other != null)
		{
			uidList_.Add(other.uidList_);
			if (other.ICHENOJECAP)
			{
				ICHENOJECAP = other.ICHENOJECAP;
			}
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
			case 56u:
			case 58u:
				uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
				break;
			case 72u:
				ICHENOJECAP = input.ReadBool();
				break;
			}
		}
	}
}
