using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneNpcInfo : IMessage<SceneNpcInfo>, IMessage, IEquatable<SceneNpcInfo>, IDeepCloneable<SceneNpcInfo>, IBufferMessage
{
	private static readonly MessageParser<SceneNpcInfo> _parser = new MessageParser<SceneNpcInfo>(() => new SceneNpcInfo());

	private UnknownFieldSet _unknownFields;

	public const int NpcIdFieldNumber = 3;

	private uint npcId_;

	public const int ExtraInfoFieldNumber = 12;

	private NpcExtraInfo extraInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneNpcInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneNpcInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NpcId
	{
		get
		{
			return npcId_;
		}
		set
		{
			npcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcExtraInfo ExtraInfo
	{
		get
		{
			return extraInfo_;
		}
		set
		{
			extraInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneNpcInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneNpcInfo(SceneNpcInfo other)
		: this()
	{
		npcId_ = other.npcId_;
		extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneNpcInfo Clone()
	{
		return new SceneNpcInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneNpcInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneNpcInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NpcId != other.NpcId)
		{
			return false;
		}
		if (!object.Equals(ExtraInfo, other.ExtraInfo))
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
		if (NpcId != 0)
		{
			num ^= NpcId.GetHashCode();
		}
		if (extraInfo_ != null)
		{
			num ^= ExtraInfo.GetHashCode();
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
		if (NpcId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NpcId);
		}
		if (extraInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ExtraInfo);
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
		if (NpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NpcId);
		}
		if (extraInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtraInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneNpcInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NpcId != 0)
		{
			NpcId = other.NpcId;
		}
		if (other.extraInfo_ != null)
		{
			if (extraInfo_ == null)
			{
				ExtraInfo = new NpcExtraInfo();
			}
			ExtraInfo.MergeFrom(other.ExtraInfo);
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
			case 24u:
				NpcId = input.ReadUInt32();
				break;
			case 98u:
				if (extraInfo_ == null)
				{
					ExtraInfo = new NpcExtraInfo();
				}
				input.ReadMessage(ExtraInfo);
				break;
			}
		}
	}
}
