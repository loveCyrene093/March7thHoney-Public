using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClientObjDownloadData : IMessage<ClientObjDownloadData>, IMessage, IEquatable<ClientObjDownloadData>, IDeepCloneable<ClientObjDownloadData>, IBufferMessage
{
	private static readonly MessageParser<ClientObjDownloadData> _parser = new MessageParser<ClientObjDownloadData>(() => new ClientObjDownloadData());

	private UnknownFieldSet _unknownFields;

	public const int ScInfoFieldNumber = 1;

	private ByteString scInfo_ = ByteString.Empty;

	public const int ClientObjDownloadData_FieldNumber = 2;

	private ClientDownloadData clientObjDownloadData_;

	public const int DynCodeFieldNumber = 3;

	private static readonly FieldCodec<ClientDownloadData> _repeated_dynCode_codec = FieldCodec.ForMessage(26u, ClientDownloadData.Parser);

	private readonly RepeatedField<ClientDownloadData> dynCode_ = new RepeatedField<ClientDownloadData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClientObjDownloadData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClientObjDownloadDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString ScInfo
	{
		get
		{
			return scInfo_;
		}
		set
		{
			scInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientDownloadData ClientObjDownloadData_
	{
		get
		{
			return clientObjDownloadData_;
		}
		set
		{
			clientObjDownloadData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ClientDownloadData> DynCode => dynCode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientObjDownloadData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientObjDownloadData(ClientObjDownloadData other)
		: this()
	{
		scInfo_ = other.scInfo_;
		clientObjDownloadData_ = ((other.clientObjDownloadData_ != null) ? other.clientObjDownloadData_.Clone() : null);
		dynCode_ = other.dynCode_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientObjDownloadData Clone()
	{
		return new ClientObjDownloadData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClientObjDownloadData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClientObjDownloadData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScInfo != other.ScInfo)
		{
			return false;
		}
		if (!object.Equals(ClientObjDownloadData_, other.ClientObjDownloadData_))
		{
			return false;
		}
		if (!dynCode_.Equals(other.dynCode_))
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
		if (ScInfo.Length != 0)
		{
			num ^= ScInfo.GetHashCode();
		}
		if (clientObjDownloadData_ != null)
		{
			num ^= ClientObjDownloadData_.GetHashCode();
		}
		num ^= dynCode_.GetHashCode();
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
		if (ScInfo.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(ScInfo);
		}
		if (clientObjDownloadData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ClientObjDownloadData_);
		}
		dynCode_.WriteTo(ref output, _repeated_dynCode_codec);
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
		if (ScInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(ScInfo);
		}
		if (clientObjDownloadData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ClientObjDownloadData_);
		}
		num += dynCode_.CalculateSize(_repeated_dynCode_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClientObjDownloadData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ScInfo.Length != 0)
		{
			ScInfo = other.ScInfo;
		}
		if (other.clientObjDownloadData_ != null)
		{
			if (clientObjDownloadData_ == null)
			{
				ClientObjDownloadData_ = new ClientDownloadData();
			}
			ClientObjDownloadData_.MergeFrom(other.ClientObjDownloadData_);
		}
		dynCode_.Add(other.dynCode_);
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
				ScInfo = input.ReadBytes();
				break;
			case 18u:
				if (clientObjDownloadData_ == null)
				{
					ClientObjDownloadData_ = new ClientDownloadData();
				}
				input.ReadMessage(ClientObjDownloadData_);
				break;
			case 26u:
				dynCode_.AddEntriesFrom(ref input, _repeated_dynCode_codec);
				break;
			}
		}
	}
}
