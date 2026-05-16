using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightHandBookRoleInfo : IMessage<GridFightHandBookRoleInfo>, IMessage, IEquatable<GridFightHandBookRoleInfo>, IDeepCloneable<GridFightHandBookRoleInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightHandBookRoleInfo> _parser = new MessageParser<GridFightHandBookRoleInfo>(() => new GridFightHandBookRoleInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightAvatarListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_gridFightAvatarList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> gridFightAvatarList_ = new RepeatedField<uint>();

	public const int LCGHMJFAMEEFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_lCGHMJFAMEE_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> lCGHMJFAMEE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightHandBookRoleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightHandBookRoleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightAvatarList => gridFightAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LCGHMJFAMEE => lCGHMJFAMEE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookRoleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookRoleInfo(GridFightHandBookRoleInfo other)
		: this()
	{
		gridFightAvatarList_ = other.gridFightAvatarList_.Clone();
		lCGHMJFAMEE_ = other.lCGHMJFAMEE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookRoleInfo Clone()
	{
		return new GridFightHandBookRoleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightHandBookRoleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightHandBookRoleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightAvatarList_.Equals(other.gridFightAvatarList_))
		{
			return false;
		}
		if (!lCGHMJFAMEE_.Equals(other.lCGHMJFAMEE_))
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
		num ^= gridFightAvatarList_.GetHashCode();
		num ^= lCGHMJFAMEE_.GetHashCode();
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
		gridFightAvatarList_.WriteTo(ref output, _repeated_gridFightAvatarList_codec);
		lCGHMJFAMEE_.WriteTo(ref output, _repeated_lCGHMJFAMEE_codec);
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
		num += gridFightAvatarList_.CalculateSize(_repeated_gridFightAvatarList_codec);
		num += lCGHMJFAMEE_.CalculateSize(_repeated_lCGHMJFAMEE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightHandBookRoleInfo other)
	{
		if (other != null)
		{
			gridFightAvatarList_.Add(other.gridFightAvatarList_);
			lCGHMJFAMEE_.Add(other.lCGHMJFAMEE_);
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
			case 88u:
			case 90u:
				gridFightAvatarList_.AddEntriesFrom(ref input, _repeated_gridFightAvatarList_codec);
				break;
			case 104u:
			case 106u:
				lCGHMJFAMEE_.AddEntriesFrom(ref input, _repeated_lCGHMJFAMEE_codec);
				break;
			}
		}
	}
}
