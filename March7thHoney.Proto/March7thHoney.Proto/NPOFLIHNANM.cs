using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NPOFLIHNANM : IMessage<NPOFLIHNANM>, IMessage, IEquatable<NPOFLIHNANM>, IDeepCloneable<NPOFLIHNANM>, IBufferMessage
{
	private static readonly MessageParser<NPOFLIHNANM> _parser = new MessageParser<NPOFLIHNANM>(() => new NPOFLIHNANM());

	private UnknownFieldSet _unknownFields;

	public const int ClientTimeMsFieldNumber = 1;

	private ulong clientTimeMs_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int ServerTimeMsFieldNumber = 12;

	private ulong serverTimeMs_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NPOFLIHNANM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NPOFLIHNANMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong ClientTimeMs
	{
		get
		{
			return clientTimeMs_;
		}
		set
		{
			clientTimeMs_ = value;
		}
	}

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
	public ulong ServerTimeMs
	{
		get
		{
			return serverTimeMs_;
		}
		set
		{
			serverTimeMs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPOFLIHNANM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPOFLIHNANM(NPOFLIHNANM other)
		: this()
	{
		clientTimeMs_ = other.clientTimeMs_;
		retcode_ = other.retcode_;
		serverTimeMs_ = other.serverTimeMs_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPOFLIHNANM Clone()
	{
		return new NPOFLIHNANM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NPOFLIHNANM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NPOFLIHNANM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ClientTimeMs != other.ClientTimeMs)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ServerTimeMs != other.ServerTimeMs)
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
		if (ClientTimeMs != 0L)
		{
			num ^= ClientTimeMs.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ServerTimeMs != 0L)
		{
			num ^= ServerTimeMs.GetHashCode();
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
		if (ClientTimeMs != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(ClientTimeMs);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (ServerTimeMs != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(ServerTimeMs);
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
		if (ClientTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ClientTimeMs);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ServerTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ServerTimeMs);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NPOFLIHNANM other)
	{
		if (other != null)
		{
			if (other.ClientTimeMs != 0L)
			{
				ClientTimeMs = other.ClientTimeMs;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.ServerTimeMs != 0L)
			{
				ServerTimeMs = other.ServerTimeMs;
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
				ClientTimeMs = input.ReadUInt64();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				ServerTimeMs = input.ReadUInt64();
				break;
			}
		}
	}
}
