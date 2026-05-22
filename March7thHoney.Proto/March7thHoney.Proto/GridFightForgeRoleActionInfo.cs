using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightForgeRoleActionInfo : IMessage<GridFightForgeRoleActionInfo>, IMessage, IEquatable<GridFightForgeRoleActionInfo>, IDeepCloneable<GridFightForgeRoleActionInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightForgeRoleActionInfo> _parser = new MessageParser<GridFightForgeRoleActionInfo>(() => new GridFightForgeRoleActionInfo());

	private UnknownFieldSet _unknownFields;

	public const int ForgeGoodsListFieldNumber = 1;

	private static readonly FieldCodec<GridFightForgeRoleInfo> _repeated_forgeGoodsList_codec = FieldCodec.ForMessage(10u, GridFightForgeRoleInfo.Parser);

	private readonly RepeatedField<GridFightForgeRoleInfo> forgeGoodsList_ = new RepeatedField<GridFightForgeRoleInfo>();

	public const int ForgeItemIdFieldNumber = 9;

	private uint forgeItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightForgeRoleActionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightForgeRoleActionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightForgeRoleInfo> ForgeGoodsList => forgeGoodsList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ForgeItemId
	{
		get
		{
			return forgeItemId_;
		}
		set
		{
			forgeItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleActionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleActionInfo(GridFightForgeRoleActionInfo other)
		: this()
	{
		forgeGoodsList_ = other.forgeGoodsList_.Clone();
		forgeItemId_ = other.forgeItemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleActionInfo Clone()
	{
		return new GridFightForgeRoleActionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightForgeRoleActionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightForgeRoleActionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!forgeGoodsList_.Equals(other.forgeGoodsList_))
		{
			return false;
		}
		if (ForgeItemId != other.ForgeItemId)
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
		num ^= forgeGoodsList_.GetHashCode();
		if (ForgeItemId != 0)
		{
			num ^= ForgeItemId.GetHashCode();
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
		forgeGoodsList_.WriteTo(ref output, _repeated_forgeGoodsList_codec);
		if (ForgeItemId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ForgeItemId);
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
		num += forgeGoodsList_.CalculateSize(_repeated_forgeGoodsList_codec);
		if (ForgeItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ForgeItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightForgeRoleActionInfo other)
	{
		if (other != null)
		{
			forgeGoodsList_.Add(other.forgeGoodsList_);
			if (other.ForgeItemId != 0)
			{
				ForgeItemId = other.ForgeItemId;
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
			case 10u:
				forgeGoodsList_.AddEntriesFrom(ref input, _repeated_forgeGoodsList_codec);
				break;
			case 72u:
				ForgeItemId = input.ReadUInt32();
				break;
			}
		}
	}
}
