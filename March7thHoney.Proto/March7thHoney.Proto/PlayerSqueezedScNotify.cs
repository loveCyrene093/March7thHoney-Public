using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerSqueezedScNotify : IMessage<PlayerSqueezedScNotify>, IMessage, IEquatable<PlayerSqueezedScNotify>, IDeepCloneable<PlayerSqueezedScNotify>, IBufferMessage
{
	private static readonly MessageParser<PlayerSqueezedScNotify> _parser = new MessageParser<PlayerSqueezedScNotify>(() => new PlayerSqueezedScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KickTypeFieldNumber = 2;

	private KickType kickType_;

	public const int BlackInfoFieldNumber = 4;

	private BlackInfo blackInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerSqueezedScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerSqueezedScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KickType KickType
	{
		get
		{
			return kickType_;
		}
		set
		{
			kickType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlackInfo BlackInfo
	{
		get
		{
			return blackInfo_;
		}
		set
		{
			blackInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSqueezedScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSqueezedScNotify(PlayerSqueezedScNotify other)
		: this()
	{
		kickType_ = other.kickType_;
		blackInfo_ = ((other.blackInfo_ != null) ? other.blackInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSqueezedScNotify Clone()
	{
		return new PlayerSqueezedScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerSqueezedScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerSqueezedScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KickType != other.KickType)
		{
			return false;
		}
		if (!object.Equals(BlackInfo, other.BlackInfo))
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
		if (KickType != KickType.KickSqueezed)
		{
			num ^= KickType.GetHashCode();
		}
		if (blackInfo_ != null)
		{
			num ^= BlackInfo.GetHashCode();
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
		if (KickType != KickType.KickSqueezed)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)KickType);
		}
		if (blackInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BlackInfo);
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
		if (KickType != KickType.KickSqueezed)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KickType);
		}
		if (blackInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BlackInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerSqueezedScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KickType != KickType.KickSqueezed)
		{
			KickType = other.KickType;
		}
		if (other.blackInfo_ != null)
		{
			if (blackInfo_ == null)
			{
				BlackInfo = new BlackInfo();
			}
			BlackInfo.MergeFrom(other.BlackInfo);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				KickType = (KickType)input.ReadEnum();
				break;
			case 34u:
				if (blackInfo_ == null)
				{
					BlackInfo = new BlackInfo();
				}
				input.ReadMessage(BlackInfo);
				break;
			}
		}
	}
}
