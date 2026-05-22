using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetPlayerOutfitCsReq : IMessage<SetPlayerOutfitCsReq>, IMessage, IEquatable<SetPlayerOutfitCsReq>, IDeepCloneable<SetPlayerOutfitCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetPlayerOutfitCsReq> _parser = new MessageParser<SetPlayerOutfitCsReq>(() => new SetPlayerOutfitCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PlayerOutfitDataFieldNumber = 2;

	private PlayerOutfitInfo playerOutfitData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetPlayerOutfitCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetPlayerOutfitCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerOutfitInfo PlayerOutfitData
	{
		get
		{
			return playerOutfitData_;
		}
		set
		{
			playerOutfitData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetPlayerOutfitCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetPlayerOutfitCsReq(SetPlayerOutfitCsReq other)
		: this()
	{
		playerOutfitData_ = ((other.playerOutfitData_ != null) ? other.playerOutfitData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetPlayerOutfitCsReq Clone()
	{
		return new SetPlayerOutfitCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetPlayerOutfitCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetPlayerOutfitCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PlayerOutfitData, other.PlayerOutfitData))
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
		if (playerOutfitData_ != null)
		{
			num ^= PlayerOutfitData.GetHashCode();
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
		if (playerOutfitData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PlayerOutfitData);
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
		if (playerOutfitData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerOutfitData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetPlayerOutfitCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.playerOutfitData_ != null)
		{
			if (playerOutfitData_ == null)
			{
				PlayerOutfitData = new PlayerOutfitInfo();
			}
			PlayerOutfitData.MergeFrom(other.PlayerOutfitData);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (playerOutfitData_ == null)
			{
				PlayerOutfitData = new PlayerOutfitInfo();
			}
			input.ReadMessage(PlayerOutfitData);
		}
	}
}
