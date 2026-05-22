using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeRaidNotify : IMessage<ChallengeRaidNotify>, IMessage, IEquatable<ChallengeRaidNotify>, IDeepCloneable<ChallengeRaidNotify>, IBufferMessage
{
	private static readonly MessageParser<ChallengeRaidNotify> _parser = new MessageParser<ChallengeRaidNotify>(() => new ChallengeRaidNotify());

	private UnknownFieldSet _unknownFields;

	public const int OFLCHDECPDAFieldNumber = 15;

	private ENDOLEJCHKP oFLCHDECPDA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeRaidNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeRaidNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENDOLEJCHKP OFLCHDECPDA
	{
		get
		{
			return oFLCHDECPDA_;
		}
		set
		{
			oFLCHDECPDA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeRaidNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeRaidNotify(ChallengeRaidNotify other)
		: this()
	{
		oFLCHDECPDA_ = ((other.oFLCHDECPDA_ != null) ? other.oFLCHDECPDA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeRaidNotify Clone()
	{
		return new ChallengeRaidNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeRaidNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeRaidNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OFLCHDECPDA, other.OFLCHDECPDA))
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
		if (oFLCHDECPDA_ != null)
		{
			num ^= OFLCHDECPDA.GetHashCode();
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
		if (oFLCHDECPDA_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(OFLCHDECPDA);
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
		if (oFLCHDECPDA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OFLCHDECPDA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeRaidNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oFLCHDECPDA_ != null)
		{
			if (oFLCHDECPDA_ == null)
			{
				OFLCHDECPDA = new ENDOLEJCHKP();
			}
			OFLCHDECPDA.MergeFrom(other.OFLCHDECPDA);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (oFLCHDECPDA_ == null)
			{
				OFLCHDECPDA = new ENDOLEJCHKP();
			}
			input.ReadMessage(OFLCHDECPDA);
		}
	}
}
