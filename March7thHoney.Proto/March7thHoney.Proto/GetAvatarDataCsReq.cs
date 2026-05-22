using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAvatarDataCsReq : IMessage<GetAvatarDataCsReq>, IMessage, IEquatable<GetAvatarDataCsReq>, IDeepCloneable<GetAvatarDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetAvatarDataCsReq> _parser = new MessageParser<GetAvatarDataCsReq>(() => new GetAvatarDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BaseAvatarIdListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	public const int IsGetAllFieldNumber = 3;

	private bool isGetAll_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAvatarDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAvatarDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsGetAll
	{
		get
		{
			return isGetAll_;
		}
		set
		{
			isGetAll_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAvatarDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAvatarDataCsReq(GetAvatarDataCsReq other)
		: this()
	{
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		isGetAll_ = other.isGetAll_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAvatarDataCsReq Clone()
	{
		return new GetAvatarDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAvatarDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAvatarDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
		{
			return false;
		}
		if (IsGetAll != other.IsGetAll)
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
		num ^= baseAvatarIdList_.GetHashCode();
		if (IsGetAll)
		{
			num ^= IsGetAll.GetHashCode();
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
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
		if (IsGetAll)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsGetAll);
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
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		if (IsGetAll)
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
	public void MergeFrom(GetAvatarDataCsReq other)
	{
		if (other != null)
		{
			baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.IsGetAll)
			{
				IsGetAll = other.IsGetAll;
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
			case 16u:
			case 18u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			case 24u:
				IsGetAll = input.ReadBool();
				break;
			}
		}
	}
}
