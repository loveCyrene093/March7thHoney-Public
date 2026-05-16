using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LKOOAHOFJAC : IMessage<LKOOAHOFJAC>, IMessage, IEquatable<LKOOAHOFJAC>, IDeepCloneable<LKOOAHOFJAC>, IBufferMessage
{
	private static readonly MessageParser<LKOOAHOFJAC> _parser = new MessageParser<LKOOAHOFJAC>(() => new LKOOAHOFJAC());

	private UnknownFieldSet _unknownFields;

	public const int ServerTimestampMsFieldNumber = 4;

	private ulong serverTimestampMs_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int SecretKeySeedFieldNumber = 6;

	private ulong secretKeySeed_;

	public const int ALLHDAFGDCJFieldNumber = 11;

	private bool aLLHDAFGDCJ_;

	public const int KFMAEGNNJDLFieldNumber = 14;

	private uint kFMAEGNNJDL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LKOOAHOFJAC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LKOOAHOFJACReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong ServerTimestampMs
	{
		get
		{
			return serverTimestampMs_;
		}
		set
		{
			serverTimestampMs_ = value;
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
	public ulong SecretKeySeed
	{
		get
		{
			return secretKeySeed_;
		}
		set
		{
			secretKeySeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ALLHDAFGDCJ
	{
		get
		{
			return aLLHDAFGDCJ_;
		}
		set
		{
			aLLHDAFGDCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KFMAEGNNJDL
	{
		get
		{
			return kFMAEGNNJDL_;
		}
		set
		{
			kFMAEGNNJDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKOOAHOFJAC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKOOAHOFJAC(LKOOAHOFJAC other)
		: this()
	{
		serverTimestampMs_ = other.serverTimestampMs_;
		retcode_ = other.retcode_;
		secretKeySeed_ = other.secretKeySeed_;
		aLLHDAFGDCJ_ = other.aLLHDAFGDCJ_;
		kFMAEGNNJDL_ = other.kFMAEGNNJDL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKOOAHOFJAC Clone()
	{
		return new LKOOAHOFJAC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LKOOAHOFJAC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LKOOAHOFJAC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ServerTimestampMs != other.ServerTimestampMs)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (SecretKeySeed != other.SecretKeySeed)
		{
			return false;
		}
		if (ALLHDAFGDCJ != other.ALLHDAFGDCJ)
		{
			return false;
		}
		if (KFMAEGNNJDL != other.KFMAEGNNJDL)
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
		if (ServerTimestampMs != 0L)
		{
			num ^= ServerTimestampMs.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (SecretKeySeed != 0L)
		{
			num ^= SecretKeySeed.GetHashCode();
		}
		if (ALLHDAFGDCJ)
		{
			num ^= ALLHDAFGDCJ.GetHashCode();
		}
		if (KFMAEGNNJDL != 0)
		{
			num ^= KFMAEGNNJDL.GetHashCode();
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
		if (ServerTimestampMs != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(ServerTimestampMs);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (SecretKeySeed != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(SecretKeySeed);
		}
		if (ALLHDAFGDCJ)
		{
			output.WriteRawTag(88);
			output.WriteBool(ALLHDAFGDCJ);
		}
		if (KFMAEGNNJDL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(KFMAEGNNJDL);
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
		if (ServerTimestampMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ServerTimestampMs);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (SecretKeySeed != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(SecretKeySeed);
		}
		if (ALLHDAFGDCJ)
		{
			num += 2;
		}
		if (KFMAEGNNJDL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KFMAEGNNJDL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LKOOAHOFJAC other)
	{
		if (other != null)
		{
			if (other.ServerTimestampMs != 0L)
			{
				ServerTimestampMs = other.ServerTimestampMs;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.SecretKeySeed != 0L)
			{
				SecretKeySeed = other.SecretKeySeed;
			}
			if (other.ALLHDAFGDCJ)
			{
				ALLHDAFGDCJ = other.ALLHDAFGDCJ;
			}
			if (other.KFMAEGNNJDL != 0)
			{
				KFMAEGNNJDL = other.KFMAEGNNJDL;
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
			case 32u:
				ServerTimestampMs = input.ReadUInt64();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 48u:
				SecretKeySeed = input.ReadUInt64();
				break;
			case 88u:
				ALLHDAFGDCJ = input.ReadBool();
				break;
			case 112u:
				KFMAEGNNJDL = input.ReadUInt32();
				break;
			}
		}
	}
}
