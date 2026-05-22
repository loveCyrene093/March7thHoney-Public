using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EvolveBuildShopAbilityDownCsReq : IMessage<EvolveBuildShopAbilityDownCsReq>, IMessage, IEquatable<EvolveBuildShopAbilityDownCsReq>, IDeepCloneable<EvolveBuildShopAbilityDownCsReq>, IBufferMessage
{
	private static readonly MessageParser<EvolveBuildShopAbilityDownCsReq> _parser = new MessageParser<EvolveBuildShopAbilityDownCsReq>(() => new EvolveBuildShopAbilityDownCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NJPCMDNHOFLFieldNumber = 5;

	private uint nJPCMDNHOFL_;

	public const int LevelFieldNumber = 12;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvolveBuildShopAbilityDownCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvolveBuildShopAbilityDownCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NJPCMDNHOFL
	{
		get
		{
			return nJPCMDNHOFL_;
		}
		set
		{
			nJPCMDNHOFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildShopAbilityDownCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildShopAbilityDownCsReq(EvolveBuildShopAbilityDownCsReq other)
		: this()
	{
		nJPCMDNHOFL_ = other.nJPCMDNHOFL_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildShopAbilityDownCsReq Clone()
	{
		return new EvolveBuildShopAbilityDownCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvolveBuildShopAbilityDownCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvolveBuildShopAbilityDownCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NJPCMDNHOFL != other.NJPCMDNHOFL)
		{
			return false;
		}
		if (Level != other.Level)
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
		if (NJPCMDNHOFL != 0)
		{
			num ^= NJPCMDNHOFL.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		if (NJPCMDNHOFL != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NJPCMDNHOFL);
		}
		if (Level != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Level);
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
		if (NJPCMDNHOFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJPCMDNHOFL);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvolveBuildShopAbilityDownCsReq other)
	{
		if (other != null)
		{
			if (other.NJPCMDNHOFL != 0)
			{
				NJPCMDNHOFL = other.NJPCMDNHOFL;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 40u:
				NJPCMDNHOFL = input.ReadUInt32();
				break;
			case 96u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
