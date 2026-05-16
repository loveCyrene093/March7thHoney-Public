using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelFinishMasterChallengeCsReq : IMessage<ChimeraDuelFinishMasterChallengeCsReq>, IMessage, IEquatable<ChimeraDuelFinishMasterChallengeCsReq>, IDeepCloneable<ChimeraDuelFinishMasterChallengeCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelFinishMasterChallengeCsReq> _parser = new MessageParser<ChimeraDuelFinishMasterChallengeCsReq>(() => new ChimeraDuelFinishMasterChallengeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int OFFIDMEJBGIFieldNumber = 9;

	private uint oFFIDMEJBGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelFinishMasterChallengeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelFinishMasterChallengeCsReqReflection.Descriptor.MessageTypes[0];

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
	public ChimeraDuelFinishMasterChallengeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelFinishMasterChallengeCsReq(ChimeraDuelFinishMasterChallengeCsReq other)
		: this()
	{
		oFFIDMEJBGI_ = other.oFFIDMEJBGI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelFinishMasterChallengeCsReq Clone()
	{
		return new ChimeraDuelFinishMasterChallengeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelFinishMasterChallengeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelFinishMasterChallengeCsReq other)
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
			output.WriteRawTag(72);
			output.WriteUInt32(OFFIDMEJBGI);
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelFinishMasterChallengeCsReq other)
	{
		if (other != null)
		{
			if (other.OFFIDMEJBGI != 0)
			{
				OFFIDMEJBGI = other.OFFIDMEJBGI;
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
			if (num != 72)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				OFFIDMEJBGI = input.ReadUInt32();
			}
		}
	}
}
