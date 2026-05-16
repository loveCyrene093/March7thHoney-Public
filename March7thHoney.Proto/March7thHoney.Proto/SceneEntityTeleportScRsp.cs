using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEntityTeleportScRsp : IMessage<SceneEntityTeleportScRsp>, IMessage, IEquatable<SceneEntityTeleportScRsp>, IDeepCloneable<SceneEntityTeleportScRsp>, IBufferMessage
{
	private static readonly MessageParser<SceneEntityTeleportScRsp> _parser = new MessageParser<SceneEntityTeleportScRsp>(() => new SceneEntityTeleportScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int EntityMotionFieldNumber = 3;

	private EntityMotion entityMotion_;

	public const int ClientPosVersionFieldNumber = 13;

	private uint clientPosVersion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEntityTeleportScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEntityTeleportScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityMotion EntityMotion
	{
		get
		{
			return entityMotion_;
		}
		set
		{
			entityMotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ClientPosVersion
	{
		get
		{
			return clientPosVersion_;
		}
		set
		{
			clientPosVersion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityTeleportScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityTeleportScRsp(SceneEntityTeleportScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		entityMotion_ = ((other.entityMotion_ != null) ? other.entityMotion_.Clone() : null);
		clientPosVersion_ = other.clientPosVersion_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityTeleportScRsp Clone()
	{
		return new SceneEntityTeleportScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEntityTeleportScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEntityTeleportScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(EntityMotion, other.EntityMotion))
		{
			return false;
		}
		if (ClientPosVersion != other.ClientPosVersion)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (entityMotion_ != null)
		{
			num ^= EntityMotion.GetHashCode();
		}
		if (ClientPosVersion != 0)
		{
			num ^= ClientPosVersion.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (entityMotion_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EntityMotion);
		}
		if (ClientPosVersion != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ClientPosVersion);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (entityMotion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EntityMotion);
		}
		if (ClientPosVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneEntityTeleportScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.entityMotion_ != null)
		{
			if (entityMotion_ == null)
			{
				EntityMotion = new EntityMotion();
			}
			EntityMotion.MergeFrom(other.EntityMotion);
		}
		if (other.ClientPosVersion != 0)
		{
			ClientPosVersion = other.ClientPosVersion;
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
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				if (entityMotion_ == null)
				{
					EntityMotion = new EntityMotion();
				}
				input.ReadMessage(EntityMotion);
				break;
			case 104u:
				ClientPosVersion = input.ReadUInt32();
				break;
			}
		}
	}
}
