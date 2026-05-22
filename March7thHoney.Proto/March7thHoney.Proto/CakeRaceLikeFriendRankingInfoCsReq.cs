using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CakeRaceLikeFriendRankingInfoCsReq : IMessage<CakeRaceLikeFriendRankingInfoCsReq>, IMessage, IEquatable<CakeRaceLikeFriendRankingInfoCsReq>, IDeepCloneable<CakeRaceLikeFriendRankingInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<CakeRaceLikeFriendRankingInfoCsReq> _parser = new MessageParser<CakeRaceLikeFriendRankingInfoCsReq>(() => new CakeRaceLikeFriendRankingInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TeleportIdFieldNumber = 5;

	private uint teleportId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CakeRaceLikeFriendRankingInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CakeRaceLikeFriendRankingInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TeleportId
	{
		get
		{
			return teleportId_;
		}
		set
		{
			teleportId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceLikeFriendRankingInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceLikeFriendRankingInfoCsReq(CakeRaceLikeFriendRankingInfoCsReq other)
		: this()
	{
		teleportId_ = other.teleportId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceLikeFriendRankingInfoCsReq Clone()
	{
		return new CakeRaceLikeFriendRankingInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CakeRaceLikeFriendRankingInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CakeRaceLikeFriendRankingInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TeleportId != other.TeleportId)
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
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
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
		if (TeleportId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(TeleportId);
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
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CakeRaceLikeFriendRankingInfoCsReq other)
	{
		if (other != null)
		{
			if (other.TeleportId != 0)
			{
				TeleportId = other.TeleportId;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				TeleportId = input.ReadUInt32();
			}
		}
	}
}
