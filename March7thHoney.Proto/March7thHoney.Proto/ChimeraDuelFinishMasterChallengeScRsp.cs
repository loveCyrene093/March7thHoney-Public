using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelFinishMasterChallengeScRsp : IMessage<ChimeraDuelFinishMasterChallengeScRsp>, IMessage, IEquatable<ChimeraDuelFinishMasterChallengeScRsp>, IDeepCloneable<ChimeraDuelFinishMasterChallengeScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelFinishMasterChallengeScRsp> _parser = new MessageParser<ChimeraDuelFinishMasterChallengeScRsp>(() => new ChimeraDuelFinishMasterChallengeScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OFFIDMEJBGIFieldNumber = 6;

	private uint oFFIDMEJBGI_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelFinishMasterChallengeScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelFinishMasterChallengeScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFFIDMEJBGI
	{
		get
		{
			return oFFIDMEJBGI_;
		}
		set
		{
			oFFIDMEJBGI_ = value;
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
	public ChimeraDuelFinishMasterChallengeScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelFinishMasterChallengeScRsp(ChimeraDuelFinishMasterChallengeScRsp other)
		: this()
	{
		oFFIDMEJBGI_ = other.oFFIDMEJBGI_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelFinishMasterChallengeScRsp Clone()
	{
		return new ChimeraDuelFinishMasterChallengeScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelFinishMasterChallengeScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelFinishMasterChallengeScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFFIDMEJBGI != other.OFFIDMEJBGI)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (OFFIDMEJBGI != 0)
		{
			num ^= OFFIDMEJBGI.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (OFFIDMEJBGI != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(OFFIDMEJBGI);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
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
		if (OFFIDMEJBGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFFIDMEJBGI);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelFinishMasterChallengeScRsp other)
	{
		if (other != null)
		{
			if (other.OFFIDMEJBGI != 0)
			{
				OFFIDMEJBGI = other.OFFIDMEJBGI;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 48u:
				OFFIDMEJBGI = input.ReadUInt32();
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
