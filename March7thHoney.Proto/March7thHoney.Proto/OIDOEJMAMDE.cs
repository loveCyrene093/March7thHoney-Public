using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OIDOEJMAMDE : IMessage<OIDOEJMAMDE>, IMessage, IEquatable<OIDOEJMAMDE>, IDeepCloneable<OIDOEJMAMDE>, IBufferMessage
{
	private static readonly MessageParser<OIDOEJMAMDE> _parser = new MessageParser<OIDOEJMAMDE>(() => new OIDOEJMAMDE());

	private UnknownFieldSet _unknownFields;

	public const int KBEFKONPKGJFieldNumber = 9;

	private ItemCostData kBEFKONPKGJ_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OIDOEJMAMDE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OIDOEJMAMDEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData KBEFKONPKGJ
	{
		get
		{
			return kBEFKONPKGJ_;
		}
		set
		{
			kBEFKONPKGJ_ = value;
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
	public OIDOEJMAMDE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OIDOEJMAMDE(OIDOEJMAMDE other)
		: this()
	{
		kBEFKONPKGJ_ = ((other.kBEFKONPKGJ_ != null) ? other.kBEFKONPKGJ_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OIDOEJMAMDE Clone()
	{
		return new OIDOEJMAMDE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OIDOEJMAMDE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OIDOEJMAMDE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KBEFKONPKGJ, other.KBEFKONPKGJ))
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
		if (kBEFKONPKGJ_ != null)
		{
			num ^= KBEFKONPKGJ.GetHashCode();
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
		if (kBEFKONPKGJ_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(KBEFKONPKGJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		if (kBEFKONPKGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KBEFKONPKGJ);
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
	public void MergeFrom(OIDOEJMAMDE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kBEFKONPKGJ_ != null)
		{
			if (kBEFKONPKGJ_ == null)
			{
				KBEFKONPKGJ = new ItemCostData();
			}
			KBEFKONPKGJ.MergeFrom(other.KBEFKONPKGJ);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 74u:
				if (kBEFKONPKGJ_ == null)
				{
					KBEFKONPKGJ = new ItemCostData();
				}
				input.ReadMessage(KBEFKONPKGJ);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
