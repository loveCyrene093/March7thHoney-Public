using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleAvatarGlobalBuffInfo : IMessage<BattleAvatarGlobalBuffInfo>, IMessage, IEquatable<BattleAvatarGlobalBuffInfo>, IDeepCloneable<BattleAvatarGlobalBuffInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleAvatarGlobalBuffInfo> _parser = new MessageParser<BattleAvatarGlobalBuffInfo>(() => new BattleAvatarGlobalBuffInfo());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int MazeBuffIdFieldNumber = 2;

	private uint mazeBuffId_;

	public const int ILBMFAKFDKIFieldNumber = 3;

	private uint iLBMFAKFDKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleAvatarGlobalBuffInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleAvatarGlobalBuffInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MazeBuffId
	{
		get
		{
			return mazeBuffId_;
		}
		set
		{
			mazeBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILBMFAKFDKI
	{
		get
		{
			return iLBMFAKFDKI_;
		}
		set
		{
			iLBMFAKFDKI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatarGlobalBuffInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatarGlobalBuffInfo(BattleAvatarGlobalBuffInfo other)
		: this()
	{
		avatarId_ = other.avatarId_;
		mazeBuffId_ = other.mazeBuffId_;
		iLBMFAKFDKI_ = other.iLBMFAKFDKI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleAvatarGlobalBuffInfo Clone()
	{
		return new BattleAvatarGlobalBuffInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleAvatarGlobalBuffInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleAvatarGlobalBuffInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (MazeBuffId != other.MazeBuffId)
		{
			return false;
		}
		if (ILBMFAKFDKI != other.ILBMFAKFDKI)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (MazeBuffId != 0)
		{
			num ^= MazeBuffId.GetHashCode();
		}
		if (ILBMFAKFDKI != 0)
		{
			num ^= ILBMFAKFDKI.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		if (MazeBuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MazeBuffId);
		}
		if (ILBMFAKFDKI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ILBMFAKFDKI);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (MazeBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MazeBuffId);
		}
		if (ILBMFAKFDKI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILBMFAKFDKI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleAvatarGlobalBuffInfo other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.MazeBuffId != 0)
			{
				MazeBuffId = other.MazeBuffId;
			}
			if (other.ILBMFAKFDKI != 0)
			{
				ILBMFAKFDKI = other.ILBMFAKFDKI;
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
			case 8u:
				AvatarId = input.ReadUInt32();
				break;
			case 16u:
				MazeBuffId = input.ReadUInt32();
				break;
			case 24u:
				ILBMFAKFDKI = input.ReadUInt32();
				break;
			}
		}
	}
}
