using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleGridFigntAvatarCoreRoleInfo : IMessage<BattleGridFigntAvatarCoreRoleInfo>, IMessage, IEquatable<BattleGridFigntAvatarCoreRoleInfo>, IDeepCloneable<BattleGridFigntAvatarCoreRoleInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleGridFigntAvatarCoreRoleInfo> _parser = new MessageParser<BattleGridFigntAvatarCoreRoleInfo>(() => new BattleGridFigntAvatarCoreRoleInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightAvatarListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_gridFightAvatarList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> gridFightAvatarList_ = new RepeatedField<uint>();

	public const int CBDBFANJGPBFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_cBDBFANJGPB_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> cBDBFANJGPB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleGridFigntAvatarCoreRoleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleGridFigntAvatarCoreRoleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightAvatarList => gridFightAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CBDBFANJGPB => cBDBFANJGPB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFigntAvatarCoreRoleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFigntAvatarCoreRoleInfo(BattleGridFigntAvatarCoreRoleInfo other)
		: this()
	{
		gridFightAvatarList_ = other.gridFightAvatarList_.Clone();
		cBDBFANJGPB_ = other.cBDBFANJGPB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFigntAvatarCoreRoleInfo Clone()
	{
		return new BattleGridFigntAvatarCoreRoleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleGridFigntAvatarCoreRoleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleGridFigntAvatarCoreRoleInfo other)
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
		if (!cBDBFANJGPB_.Equals(other.cBDBFANJGPB_))
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
		num ^= cBDBFANJGPB_.GetHashCode();
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
		cBDBFANJGPB_.WriteTo(ref output, _repeated_cBDBFANJGPB_codec);
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
		num += cBDBFANJGPB_.CalculateSize(_repeated_cBDBFANJGPB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleGridFigntAvatarCoreRoleInfo other)
	{
		if (other != null)
		{
			gridFightAvatarList_.Add(other.gridFightAvatarList_);
			cBDBFANJGPB_.Add(other.cBDBFANJGPB_);
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
			case 8u:
			case 10u:
				gridFightAvatarList_.AddEntriesFrom(ref input, _repeated_gridFightAvatarList_codec);
				break;
			case 16u:
			case 18u:
				cBDBFANJGPB_.AddEntriesFrom(ref input, _repeated_cBDBFANJGPB_codec);
				break;
			}
		}
	}
}
