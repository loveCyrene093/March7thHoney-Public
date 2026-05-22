using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NFPEDBOOFFF : IMessage<NFPEDBOOFFF>, IMessage, IEquatable<NFPEDBOOFFF>, IDeepCloneable<NFPEDBOOFFF>, IBufferMessage
{
	private static readonly MessageParser<NFPEDBOOFFF> _parser = new MessageParser<NFPEDBOOFFF>(() => new NFPEDBOOFFF());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int NCJHFFDDHLIFieldNumber = 10;

	private OMNJNKNMLKL nCJHFFDDHLI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NFPEDBOOFFF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NFPEDBOOFFFReflection.Descriptor.MessageTypes[0];

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
	public OMNJNKNMLKL NCJHFFDDHLI
	{
		get
		{
			return nCJHFFDDHLI_;
		}
		set
		{
			nCJHFFDDHLI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFPEDBOOFFF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFPEDBOOFFF(NFPEDBOOFFF other)
		: this()
	{
		retcode_ = other.retcode_;
		nCJHFFDDHLI_ = ((other.nCJHFFDDHLI_ != null) ? other.nCJHFFDDHLI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFPEDBOOFFF Clone()
	{
		return new NFPEDBOOFFF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NFPEDBOOFFF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NFPEDBOOFFF other)
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
		if (!object.Equals(NCJHFFDDHLI, other.NCJHFFDDHLI))
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
		if (nCJHFFDDHLI_ != null)
		{
			num ^= NCJHFFDDHLI.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (nCJHFFDDHLI_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(NCJHFFDDHLI);
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
		if (nCJHFFDDHLI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NCJHFFDDHLI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NFPEDBOOFFF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.nCJHFFDDHLI_ != null)
		{
			if (nCJHFFDDHLI_ == null)
			{
				NCJHFFDDHLI = new OMNJNKNMLKL();
			}
			NCJHFFDDHLI.MergeFrom(other.NCJHFFDDHLI);
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				if (nCJHFFDDHLI_ == null)
				{
					NCJHFFDDHLI = new OMNJNKNMLKL();
				}
				input.ReadMessage(NCJHFFDDHLI);
				break;
			}
		}
	}
}
