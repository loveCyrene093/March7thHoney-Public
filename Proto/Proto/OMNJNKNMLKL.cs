using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OMNJNKNMLKL : IMessage<OMNJNKNMLKL>, IMessage, IEquatable<OMNJNKNMLKL>, IDeepCloneable<OMNJNKNMLKL>, IBufferMessage
{
	private static readonly MessageParser<OMNJNKNMLKL> _parser = new MessageParser<OMNJNKNMLKL>(() => new OMNJNKNMLKL());

	private UnknownFieldSet _unknownFields;

	public const int EGHPNKEFCLIFieldNumber = 1;

	private MBCJAOHMNFD eGHPNKEFCLI_;

	public const int GIHHBJMAGOCFieldNumber = 11;

	private uint gIHHBJMAGOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OMNJNKNMLKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OMNJNKNMLKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBCJAOHMNFD EGHPNKEFCLI
	{
		get
		{
			return eGHPNKEFCLI_;
		}
		set
		{
			eGHPNKEFCLI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GIHHBJMAGOC
	{
		get
		{
			return gIHHBJMAGOC_;
		}
		set
		{
			gIHHBJMAGOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMNJNKNMLKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMNJNKNMLKL(OMNJNKNMLKL other)
		: this()
	{
		eGHPNKEFCLI_ = ((other.eGHPNKEFCLI_ != null) ? other.eGHPNKEFCLI_.Clone() : null);
		gIHHBJMAGOC_ = other.gIHHBJMAGOC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMNJNKNMLKL Clone()
	{
		return new OMNJNKNMLKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OMNJNKNMLKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OMNJNKNMLKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EGHPNKEFCLI, other.EGHPNKEFCLI))
		{
			return false;
		}
		if (GIHHBJMAGOC != other.GIHHBJMAGOC)
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
		if (eGHPNKEFCLI_ != null)
		{
			num ^= EGHPNKEFCLI.GetHashCode();
		}
		if (GIHHBJMAGOC != 0)
		{
			num ^= GIHHBJMAGOC.GetHashCode();
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
		if (eGHPNKEFCLI_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(EGHPNKEFCLI);
		}
		if (GIHHBJMAGOC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GIHHBJMAGOC);
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
		if (eGHPNKEFCLI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EGHPNKEFCLI);
		}
		if (GIHHBJMAGOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GIHHBJMAGOC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OMNJNKNMLKL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eGHPNKEFCLI_ != null)
		{
			if (eGHPNKEFCLI_ == null)
			{
				EGHPNKEFCLI = new MBCJAOHMNFD();
			}
			EGHPNKEFCLI.MergeFrom(other.EGHPNKEFCLI);
		}
		if (other.GIHHBJMAGOC != 0)
		{
			GIHHBJMAGOC = other.GIHHBJMAGOC;
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
			case 10u:
				if (eGHPNKEFCLI_ == null)
				{
					EGHPNKEFCLI = new MBCJAOHMNFD();
				}
				input.ReadMessage(EGHPNKEFCLI);
				break;
			case 88u:
				GIHHBJMAGOC = input.ReadUInt32();
				break;
			}
		}
	}
}
