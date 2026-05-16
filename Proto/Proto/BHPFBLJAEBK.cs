using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BHPFBLJAEBK : IMessage<BHPFBLJAEBK>, IMessage, IEquatable<BHPFBLJAEBK>, IDeepCloneable<BHPFBLJAEBK>, IBufferMessage
{
	private static readonly MessageParser<BHPFBLJAEBK> _parser = new MessageParser<BHPFBLJAEBK>(() => new BHPFBLJAEBK());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int KBEFKONPKGJFieldNumber = 14;

	private ItemCostData kBEFKONPKGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BHPFBLJAEBK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BHPFBLJAEBKReflection.Descriptor.MessageTypes[0];

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
	public BHPFBLJAEBK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHPFBLJAEBK(BHPFBLJAEBK other)
		: this()
	{
		retcode_ = other.retcode_;
		kBEFKONPKGJ_ = ((other.kBEFKONPKGJ_ != null) ? other.kBEFKONPKGJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHPFBLJAEBK Clone()
	{
		return new BHPFBLJAEBK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BHPFBLJAEBK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BHPFBLJAEBK other)
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
		if (!object.Equals(KBEFKONPKGJ, other.KBEFKONPKGJ))
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
		if (kBEFKONPKGJ_ != null)
		{
			num ^= KBEFKONPKGJ.GetHashCode();
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
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (kBEFKONPKGJ_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(KBEFKONPKGJ);
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
		if (kBEFKONPKGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KBEFKONPKGJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BHPFBLJAEBK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.kBEFKONPKGJ_ != null)
		{
			if (kBEFKONPKGJ_ == null)
			{
				KBEFKONPKGJ = new ItemCostData();
			}
			KBEFKONPKGJ.MergeFrom(other.KBEFKONPKGJ);
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
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (kBEFKONPKGJ_ == null)
				{
					KBEFKONPKGJ = new ItemCostData();
				}
				input.ReadMessage(KBEFKONPKGJ);
				break;
			}
		}
	}
}
