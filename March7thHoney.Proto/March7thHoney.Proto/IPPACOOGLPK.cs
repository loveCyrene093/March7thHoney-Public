using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IPPACOOGLPK : IMessage<IPPACOOGLPK>, IMessage, IEquatable<IPPACOOGLPK>, IDeepCloneable<IPPACOOGLPK>, IBufferMessage
{
	private static readonly MessageParser<IPPACOOGLPK> _parser = new MessageParser<IPPACOOGLPK>(() => new IPPACOOGLPK());

	private UnknownFieldSet _unknownFields;

	public const int ReturnDataFieldNumber = 10;

	private IEACMDFDLBF returnData_;

	public const int MGMFENIOPHOFieldNumber = 11;

	private string mGMFENIOPHO_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IPPACOOGLPK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IPPACOOGLPKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEACMDFDLBF ReturnData
	{
		get
		{
			return returnData_;
		}
		set
		{
			returnData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MGMFENIOPHO
	{
		get
		{
			return mGMFENIOPHO_;
		}
		set
		{
			mGMFENIOPHO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPPACOOGLPK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPPACOOGLPK(IPPACOOGLPK other)
		: this()
	{
		returnData_ = ((other.returnData_ != null) ? other.returnData_.Clone() : null);
		mGMFENIOPHO_ = other.mGMFENIOPHO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPPACOOGLPK Clone()
	{
		return new IPPACOOGLPK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IPPACOOGLPK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IPPACOOGLPK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ReturnData, other.ReturnData))
		{
			return false;
		}
		if (MGMFENIOPHO != other.MGMFENIOPHO)
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
		if (returnData_ != null)
		{
			num ^= ReturnData.GetHashCode();
		}
		if (MGMFENIOPHO.Length != 0)
		{
			num ^= MGMFENIOPHO.GetHashCode();
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
		if (returnData_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ReturnData);
		}
		if (MGMFENIOPHO.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(MGMFENIOPHO);
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
		if (returnData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReturnData);
		}
		if (MGMFENIOPHO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MGMFENIOPHO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IPPACOOGLPK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.returnData_ != null)
		{
			if (returnData_ == null)
			{
				ReturnData = new IEACMDFDLBF();
			}
			ReturnData.MergeFrom(other.ReturnData);
		}
		if (other.MGMFENIOPHO.Length != 0)
		{
			MGMFENIOPHO = other.MGMFENIOPHO;
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
			case 82u:
				if (returnData_ == null)
				{
					ReturnData = new IEACMDFDLBF();
				}
				input.ReadMessage(ReturnData);
				break;
			case 90u:
				MGMFENIOPHO = input.ReadString();
				break;
			}
		}
	}
}
