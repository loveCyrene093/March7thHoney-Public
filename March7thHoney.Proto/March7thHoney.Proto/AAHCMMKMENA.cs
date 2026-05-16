using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AAHCMMKMENA : IMessage<AAHCMMKMENA>, IMessage, IEquatable<AAHCMMKMENA>, IDeepCloneable<AAHCMMKMENA>, IBufferMessage
{
	private static readonly MessageParser<AAHCMMKMENA> _parser = new MessageParser<AAHCMMKMENA>(() => new AAHCMMKMENA());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int JHCJMKDDNNFFieldNumber = 10;

	private LobbyGameExtInfo jHCJMKDDNNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AAHCMMKMENA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AAHCMMKMENAReflection.Descriptor.MessageTypes[0];

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
	public LobbyGameExtInfo JHCJMKDDNNF
	{
		get
		{
			return jHCJMKDDNNF_;
		}
		set
		{
			jHCJMKDDNNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAHCMMKMENA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAHCMMKMENA(AAHCMMKMENA other)
		: this()
	{
		retcode_ = other.retcode_;
		jHCJMKDDNNF_ = ((other.jHCJMKDDNNF_ != null) ? other.jHCJMKDDNNF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAHCMMKMENA Clone()
	{
		return new AAHCMMKMENA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AAHCMMKMENA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AAHCMMKMENA other)
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
		if (!object.Equals(JHCJMKDDNNF, other.JHCJMKDDNNF))
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
		if (jHCJMKDDNNF_ != null)
		{
			num ^= JHCJMKDDNNF.GetHashCode();
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
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (jHCJMKDDNNF_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(JHCJMKDDNNF);
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
		if (jHCJMKDDNNF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHCJMKDDNNF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AAHCMMKMENA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.jHCJMKDDNNF_ != null)
		{
			if (jHCJMKDDNNF_ == null)
			{
				JHCJMKDDNNF = new LobbyGameExtInfo();
			}
			JHCJMKDDNNF.MergeFrom(other.JHCJMKDDNNF);
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
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				if (jHCJMKDDNNF_ == null)
				{
					JHCJMKDDNNF = new LobbyGameExtInfo();
				}
				input.ReadMessage(JHCJMKDDNNF);
				break;
			}
		}
	}
}
