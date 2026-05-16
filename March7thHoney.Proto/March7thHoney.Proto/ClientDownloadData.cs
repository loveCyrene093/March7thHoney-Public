using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClientDownloadData : IMessage<ClientDownloadData>, IMessage, IEquatable<ClientDownloadData>, IDeepCloneable<ClientDownloadData>, IBufferMessage
{
	private static readonly MessageParser<ClientDownloadData> _parser = new MessageParser<ClientDownloadData>(() => new ClientDownloadData());

	private UnknownFieldSet _unknownFields;

	public const int VersionFieldNumber = 1;

	private uint version_;

	public const int TimeFieldNumber = 2;

	private long time_;

	public const int DataFieldNumber = 3;

	private ByteString data_ = ByteString.Empty;

	public const int EFKCMFIJGIJFieldNumber = 4;

	private uint eFKCMFIJGIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClientDownloadData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClientDownloadDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
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
	public uint EFKCMFIJGIJ
	{
		get
		{
			return eFKCMFIJGIJ_;
		}
		set
		{
			eFKCMFIJGIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientDownloadData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientDownloadData(ClientDownloadData other)
		: this()
	{
		version_ = other.version_;
		time_ = other.time_;
		data_ = other.data_;
		eFKCMFIJGIJ_ = other.eFKCMFIJGIJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientDownloadData Clone()
	{
		return new ClientDownloadData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClientDownloadData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClientDownloadData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (Data != other.Data)
		{
			return false;
		}
		if (EFKCMFIJGIJ != other.EFKCMFIJGIJ)
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
		if (Version != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
		}
		if (Data.Length != 0)
		{
			num ^= Data.GetHashCode();
		}
		if (EFKCMFIJGIJ != 0)
		{
			num ^= EFKCMFIJGIJ.GetHashCode();
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
		if (Version != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Version);
		}
		if (Time != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(Time);
		}
		if (Data.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(Data);
		}
		if (EFKCMFIJGIJ != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EFKCMFIJGIJ);
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
		if (Version != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Version);
		}
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (Data.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Data);
		}
		if (EFKCMFIJGIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EFKCMFIJGIJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClientDownloadData other)
	{
		if (other != null)
		{
			if (other.Version != 0)
			{
				Version = other.Version;
			}
			if (other.Time != 0L)
			{
				Time = other.Time;
			}
			if (other.Data.Length != 0)
			{
				Data = other.Data;
			}
			if (other.EFKCMFIJGIJ != 0)
			{
				EFKCMFIJGIJ = other.EFKCMFIJGIJ;
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
				Version = input.ReadUInt32();
				break;
			case 16u:
				Time = input.ReadInt64();
				break;
			case 26u:
				Data = input.ReadBytes();
				break;
			case 32u:
				EFKCMFIJGIJ = input.ReadUInt32();
				break;
			}
		}
	}
}
