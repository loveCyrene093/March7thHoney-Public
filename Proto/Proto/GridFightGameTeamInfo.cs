using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameTeamInfo : IMessage<GridFightGameTeamInfo>, IMessage, IEquatable<GridFightGameTeamInfo>, IDeepCloneable<GridFightGameTeamInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameTeamInfo> _parser = new MessageParser<GridFightGameTeamInfo>(() => new GridFightGameTeamInfo());

	private UnknownFieldSet _unknownFields;

	public const int CDLAIJCKJJNFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_cDLAIJCKJJN_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> cDLAIJCKJJN_ = new RepeatedField<uint>();

	public const int GridGameForgeItemListFieldNumber = 8;

	private static readonly FieldCodec<GridGameForgeItemInfo> _repeated_gridGameForgeItemList_codec = FieldCodec.ForMessage(66u, GridGameForgeItemInfo.Parser);

	private readonly RepeatedField<GridGameForgeItemInfo> gridGameForgeItemList_ = new RepeatedField<GridGameForgeItemInfo>();

	public const int GridGameNpcListFieldNumber = 10;

	private static readonly FieldCodec<GridGameNpcInfo> _repeated_gridGameNpcList_codec = FieldCodec.ForMessage(82u, GridGameNpcInfo.Parser);

	private readonly RepeatedField<GridGameNpcInfo> gridGameNpcList_ = new RepeatedField<GridGameNpcInfo>();

	public const int MMAJCLACOBNFieldNumber = 13;

	private static readonly FieldCodec<CKCKIDHMMEG> _repeated_mMAJCLACOBN_codec = FieldCodec.ForMessage(106u, CKCKIDHMMEG.Parser);

	private readonly RepeatedField<CKCKIDHMMEG> mMAJCLACOBN_ = new RepeatedField<CKCKIDHMMEG>();

	public const int GridGameRoleListFieldNumber = 14;

	private static readonly FieldCodec<GridGameRoleInfo> _repeated_gridGameRoleList_codec = FieldCodec.ForMessage(114u, GridGameRoleInfo.Parser);

	private readonly RepeatedField<GridGameRoleInfo> gridGameRoleList_ = new RepeatedField<GridGameRoleInfo>();

	public const int HOFIENMALOPFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_hOFIENMALOP_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> hOFIENMALOP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameTeamInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameTeamInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CDLAIJCKJJN => cDLAIJCKJJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameForgeItemInfo> GridGameForgeItemList => gridGameForgeItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameNpcInfo> GridGameNpcList => gridGameNpcList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CKCKIDHMMEG> MMAJCLACOBN => mMAJCLACOBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameRoleInfo> GridGameRoleList => gridGameRoleList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HOFIENMALOP => hOFIENMALOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTeamInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTeamInfo(GridFightGameTeamInfo other)
		: this()
	{
		cDLAIJCKJJN_ = other.cDLAIJCKJJN_.Clone();
		gridGameForgeItemList_ = other.gridGameForgeItemList_.Clone();
		gridGameNpcList_ = other.gridGameNpcList_.Clone();
		mMAJCLACOBN_ = other.mMAJCLACOBN_.Clone();
		gridGameRoleList_ = other.gridGameRoleList_.Clone();
		hOFIENMALOP_ = other.hOFIENMALOP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTeamInfo Clone()
	{
		return new GridFightGameTeamInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameTeamInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameTeamInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cDLAIJCKJJN_.Equals(other.cDLAIJCKJJN_))
		{
			return false;
		}
		if (!gridGameForgeItemList_.Equals(other.gridGameForgeItemList_))
		{
			return false;
		}
		if (!gridGameNpcList_.Equals(other.gridGameNpcList_))
		{
			return false;
		}
		if (!mMAJCLACOBN_.Equals(other.mMAJCLACOBN_))
		{
			return false;
		}
		if (!gridGameRoleList_.Equals(other.gridGameRoleList_))
		{
			return false;
		}
		if (!hOFIENMALOP_.Equals(other.hOFIENMALOP_))
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
		num ^= cDLAIJCKJJN_.GetHashCode();
		num ^= gridGameForgeItemList_.GetHashCode();
		num ^= gridGameNpcList_.GetHashCode();
		num ^= mMAJCLACOBN_.GetHashCode();
		num ^= gridGameRoleList_.GetHashCode();
		num ^= hOFIENMALOP_.GetHashCode();
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
		cDLAIJCKJJN_.WriteTo(ref output, _repeated_cDLAIJCKJJN_codec);
		gridGameForgeItemList_.WriteTo(ref output, _repeated_gridGameForgeItemList_codec);
		gridGameNpcList_.WriteTo(ref output, _repeated_gridGameNpcList_codec);
		mMAJCLACOBN_.WriteTo(ref output, _repeated_mMAJCLACOBN_codec);
		gridGameRoleList_.WriteTo(ref output, _repeated_gridGameRoleList_codec);
		hOFIENMALOP_.WriteTo(ref output, _repeated_hOFIENMALOP_codec);
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
		num += cDLAIJCKJJN_.CalculateSize(_repeated_cDLAIJCKJJN_codec);
		num += gridGameForgeItemList_.CalculateSize(_repeated_gridGameForgeItemList_codec);
		num += gridGameNpcList_.CalculateSize(_repeated_gridGameNpcList_codec);
		num += mMAJCLACOBN_.CalculateSize(_repeated_mMAJCLACOBN_codec);
		num += gridGameRoleList_.CalculateSize(_repeated_gridGameRoleList_codec);
		num += hOFIENMALOP_.CalculateSize(_repeated_hOFIENMALOP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameTeamInfo other)
	{
		if (other != null)
		{
			cDLAIJCKJJN_.Add(other.cDLAIJCKJJN_);
			gridGameForgeItemList_.Add(other.gridGameForgeItemList_);
			gridGameNpcList_.Add(other.gridGameNpcList_);
			mMAJCLACOBN_.Add(other.mMAJCLACOBN_);
			gridGameRoleList_.Add(other.gridGameRoleList_);
			hOFIENMALOP_.Add(other.hOFIENMALOP_);
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
				cDLAIJCKJJN_.AddEntriesFrom(ref input, _repeated_cDLAIJCKJJN_codec);
				break;
			case 66u:
				gridGameForgeItemList_.AddEntriesFrom(ref input, _repeated_gridGameForgeItemList_codec);
				break;
			case 82u:
				gridGameNpcList_.AddEntriesFrom(ref input, _repeated_gridGameNpcList_codec);
				break;
			case 106u:
				mMAJCLACOBN_.AddEntriesFrom(ref input, _repeated_mMAJCLACOBN_codec);
				break;
			case 114u:
				gridGameRoleList_.AddEntriesFrom(ref input, _repeated_gridGameRoleList_codec);
				break;
			case 120u:
			case 122u:
				hOFIENMALOP_.AddEntriesFrom(ref input, _repeated_hOFIENMALOP_codec);
				break;
			}
		}
	}
}
