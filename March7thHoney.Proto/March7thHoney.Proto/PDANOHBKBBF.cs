using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PDANOHBKBBF : IMessage<PDANOHBKBBF>, IMessage, IEquatable<PDANOHBKBBF>, IDeepCloneable<PDANOHBKBBF>, IBufferMessage
{
	private static readonly MessageParser<PDANOHBKBBF> _parser = new MessageParser<PDANOHBKBBF>(() => new PDANOHBKBBF());

	private UnknownFieldSet _unknownFields;

	public const int IEKPOMOMOPHFieldNumber = 1;

	private string iEKPOMOMOPH_ = "";

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PDANOHBKBBF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PDANOHBKBBFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IEKPOMOMOPH
	{
		get
		{
			return iEKPOMOMOPH_;
		}
		set
		{
			iEKPOMOMOPH_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public PDANOHBKBBF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDANOHBKBBF(PDANOHBKBBF other)
		: this()
	{
		iEKPOMOMOPH_ = other.iEKPOMOMOPH_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDANOHBKBBF Clone()
	{
		return new PDANOHBKBBF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PDANOHBKBBF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PDANOHBKBBF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IEKPOMOMOPH != other.IEKPOMOMOPH)
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
		if (IEKPOMOMOPH.Length != 0)
		{
			num ^= IEKPOMOMOPH.GetHashCode();
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
		if (IEKPOMOMOPH.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(IEKPOMOMOPH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
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
		if (IEKPOMOMOPH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IEKPOMOMOPH);
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
	public void MergeFrom(PDANOHBKBBF other)
	{
		if (other != null)
		{
			if (other.IEKPOMOMOPH.Length != 0)
			{
				IEKPOMOMOPH = other.IEKPOMOMOPH;
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
			case 10u:
				IEKPOMOMOPH = input.ReadString();
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
