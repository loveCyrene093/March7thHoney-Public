using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServerPrefs : IMessage<ServerPrefs>, IMessage, IEquatable<ServerPrefs>, IDeepCloneable<ServerPrefs>, IBufferMessage
{
	private static readonly MessageParser<ServerPrefs> _parser = new MessageParser<ServerPrefs>(() => new ServerPrefs());

	private UnknownFieldSet _unknownFields;

	public const int ServerPrefsIdFieldNumber = 8;

	private uint serverPrefsId_;

	public const int DataFieldNumber = 10;

	private ByteString data_ = ByteString.Empty;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerPrefs> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ServerPrefsReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ServerPrefsId
	{
		get
		{
			return serverPrefsId_;
		}
		set
		{
			serverPrefsId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerPrefs()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerPrefs(ServerPrefs other)
		: this()
	{
		serverPrefsId_ = other.serverPrefsId_;
		data_ = other.data_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerPrefs Clone()
	{
		return new ServerPrefs(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ServerPrefs);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerPrefs other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ServerPrefsId != other.ServerPrefsId)
		{
			return false;
		}
		if (Data != other.Data)
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
		if (ServerPrefsId != 0)
		{
			num ^= ServerPrefsId.GetHashCode();
		}
		if (Data.Length != 0)
		{
			num ^= Data.GetHashCode();
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
		if (ServerPrefsId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ServerPrefsId);
		}
		if (Data.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteBytes(Data);
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
		if (ServerPrefsId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ServerPrefsId);
		}
		if (Data.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ServerPrefs other)
	{
		if (other != null)
		{
			if (other.ServerPrefsId != 0)
			{
				ServerPrefsId = other.ServerPrefsId;
			}
			if (other.Data.Length != 0)
			{
				Data = other.Data;
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
			case 64u:
				ServerPrefsId = input.ReadUInt32();
				break;
			case 82u:
				Data = input.ReadBytes();
				break;
			}
		}
	}
}
